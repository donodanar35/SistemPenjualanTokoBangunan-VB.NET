Imports MySql.Data.MySqlClient

Public Class diskon
    Public usernameku As String
    Public namapetugas As String
    Public id As String
    Public conn As MySqlConnection
    Public cmd As MySqlCommand
    Public da As MySqlDataAdapter
    Public dt As New DataTable("diskon")
    Public ds As New DataSet
    Public DR As MySqlDataReader
    Public total As Decimal = 0

    Function No()
        Dim temp As Integer
        Try
            conn = Form1.koneksi()
            Dim str As String
            str = "select count(*) 'no' from hdiskon"
            Dim cmd = New MySqlCommand(str, conn)
            DR = cmd.ExecuteReader

            If DR.HasRows Then
                While DR.Read()
                    temp = DR.Item("no") + 1
                End While
            Else
                temp = 1
            End If
            id = "diskon" + temp.ToString
            TextBoxId.Text = id
            DR.Close()
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
            MessageBox.Show("Indexing gagal dilakukan!")
        End Try
        Return temp
    End Function

    Sub tampilPetugas()
        usernameku = Form1.username
        ds.Clear()
        Dim temp As String = ""
        Try
            conn = Form1.koneksi()
            Dim qs As String = "SELECT nama_kar From KARYAWAN WHERE id_kar like '" & usernameku & "'"
            Dim cmd = New MySqlCommand(qs, conn)
            Dim DRX As MySqlDataReader
            DRX = cmd.ExecuteReader

            If DRX.HasRows Then
                While DRX.Read()
                    temp = DRX.Item("nama_kar")
                End While
            Else
                temp = ""
            End If
            TextBoxPetugas.Text = temp
            DRX.Close()
            conn.Close()
        Catch ex As Exception
            MsgBox("Tampilan petugas bermasalah! " + ex.ToString)
        End Try
    End Sub

    Sub tampilBarang()
        ds.Clear()
        Try
            conn = Form1.koneksi()
            Dim qs As String = "Select id_brg, nama_brg From BARANG WHERE STATUS = 1 AND nama_brg like '%" & TextBoxCaribarang.Text & "%'"
            da = New MySqlDataAdapter(qs, conn)
            Dim dtBarang As New DataTable("barang")
            da.Fill(dtBarang)

            ComboBoxBarang.DataSource = dtBarang
            ComboBoxBarang.DisplayMember = "nama_brg"
            ComboBoxBarang.ValueMember = "id_brg"
            conn.Close()
        Catch ex As Exception
            MsgBox("Tampilan barang bermasalah! ")
        End Try
    End Sub

    Function ambilNamaBarang()
        usernameku = Form1.username
        ds.Clear()
        Dim temp() As String = {"", 0.0, 0.0, ""}
        Try
            conn = Form1.koneksi()
            Dim qs As String = "SELECT b.nama_brg 'nama_brg', b.harga_beli 'harga_beli', b.harga_jual 'harga_jual', s.nama_satuan 'nama_satuan' From BARANG b, SATUAN s WHERE b.id_brg like '" & ComboBoxBarang.SelectedValue.ToString & "' AND b.id_satuan = s.id_satuan"
            Dim cmd = New MySqlCommand(qs, conn)
            Dim DRX As MySqlDataReader
            DRX = cmd.ExecuteReader

            If DRX.HasRows Then
                While DRX.Read()
                    temp(0) = DRX.Item("nama_brg")
                    temp(1) = DRX.Item("harga_beli")
                    TextBoxHB.Text = temp(1)
                    temp(2) = DRX.Item("harga_jual")
                    TextBoxHJ.Text = temp(2)
                    temp(3) = DRX.Item("nama_satuan")
                    TextBoxSatuan.Text = temp(3)
                End While
            End If

            DRX.Close()
            conn.Close()
        Catch ex As Exception
            MsgBox("Fungsi ambilBarang bermasalah! " + ex.ToString)
        End Try
        Return temp
    End Function

    Function tambahHeaderData()
        'MsgBox(usernameku + " " + ComboBoxSupplier.SelectedValue.ToString + " " + Format(DateTimePickerTgl.Value, "yyyy-MM-dd") & " " + TextBoxTotal.Text & " " & TextBoxKet.Text)
        Dim status_promo As String = "proses"
        If TextBoxId.Text <> "" Then
            Try
                Dim awal As Date = Format(DateTimePickerMulai.Value, "yyyy-MM-dd")
                Dim akhir As Date = Format(DateTimePickerAkhir.Value, "yyyy-MM-dd")
                If ((Today > awal) And (Today > akhir)) Then
                    status_promo = "kadaluarsa"
                ElseIf (Today > awal) Then
                    status_promo = "aktif"
                ElseIf (Today = awal) Then
                    status_promo = "aktif"
                ElseIf (Today < awal) Then
                    status_promo = "diproses"
                End If

                usernameku = Form1.username
                conn = Form1.koneksi()
                Dim qs As String = "INSERT INTO HDISKON (ID_DISC, ID_KAR, PROMO, TGL, TGLAWAL_DISC, TGLAKHIR_DISC, KET_DISC, STATUS_PROMO, STATUS) VALUES ('" & TextBoxId.Text & "', '" & usernameku & "', '" & TextBoxPromo.Text & "', '" & Format(Today, "yyyy-MM-dd") & "', '" & Format(DateTimePickerMulai.Value, "yyyy-MM-dd") & "' , '" & Format(DateTimePickerAkhir.Value, "yyyy-MM-dd") & "', '" & TextBoxKet.Text & "', '" & status_promo & "', 1)"
                cmd = New MySqlCommand(qs, conn)
                cmd.ExecuteNonQuery()
                conn.Close()
            Catch ex As Exception
                MsgBox("Header transaksi diskon error! " + ex.ToString)
            End Try
        Else
            MsgBox("Id kosong!")
        End If
        Return status_promo
    End Function

    Function tambahDetailData()
        Dim status_promo As String = ""
        status_promo = tambahHeaderData()
        If TextBoxId.Text <> "" Then
            conn = Form1.koneksi()
            Dim trans As MySqlTransaction = conn.BeginTransaction()
            Try
                For ii As Integer = 0 To DataGridView1.RowCount - 2
                    Dim qs As String = "INSERT INTO DDISKON (ID_BRG, ID_DISC, DISC_PERSEN, DISC_IDR, MIN_QTY, HARGA_BELI, HARGA_JUAL, HARGA_DISKON, PROFIT_PERBARANG, PROFIT_PERTRANSAKSI) VALUES ('" & DataGridView1.Rows(ii).Cells(0).Value & "', '" & TextBoxId.Text & "', '" & DataGridView1.Rows(ii).Cells(2).Value & "', '" & DataGridView1.Rows(ii).Cells(3).Value & "', '" & DataGridView1.Rows(ii).Cells(4).Value & "', '" & DataGridView1.Rows(ii).Cells(5).Value & "', '" & DataGridView1.Rows(ii).Cells(6).Value & "', '" & DataGridView1.Rows(ii).Cells(7).Value & "', '" & DataGridView1.Rows(ii).Cells(8).Value & "', '" & DataGridView1.Rows(ii).Cells(9).Value & "')"
                    Dim cmd = New MySqlCommand(qs, conn)
                    cmd.ExecuteNonQuery()
                    'Dim qsx = "UPDATE barang SET diskon = '" & DataGridView1.Rows(ii).Cells(2).Value & "', min_qty ='" & DataGridView1.Rows(ii).Cells(4).Value & "' WHERE id_brg = '" & DataGridView1.Rows(ii).Cells(0).Value & "'"
                    'Dim cmdx = New MySqlCommand(qsx, conn)
                    'cmdx.ExecuteNonQuery()
                Next
                trans.Commit()
                MessageBox.Show("Data transaksi diskon berhasil dilakukan!")
            Catch ex As Exception
                trans.Rollback()
                MessageBox.Show("Data transaksi diskon gagal dilakukan!" + ex.ToString)
            End Try
        Else
            MsgBox("Id kosong!")
        End If
        conn.Close()
        Return status_promo
    End Function

    Function cekDiskonBrg()
        Dim temp As New ArrayList
        Try
            conn = Form1.koneksi()
            Dim str As String
            str = "SELECT d.id_brg 'id' FROM ddiskon d, hdiskon h WHERE d.id_disc = h.id_disc AND h.status > 1 AND (h.status_promo = 'aktif' OR h.status_promo = 'diproses') GROUP BY id"
            Dim cmd = New MySqlCommand(str, conn)
            DR = cmd.ExecuteReader
            If DR.HasRows Then
                While DR.Read()
                    temp.Add(DR.Item("id"))
                End While
            End If
            DR.Close()
            conn.Close()
        Catch ex As Exception
            MessageBox.Show("Indexing gagal dilakukan! " + ex.ToString)
        End Try
        Return temp
    End Function

    Sub tambahData()
        Try
            Dim tglawal As Date = Today
            Dim tglakhir As Date = Today
            tglawal = Format(DateTimePickerMulai.Value, "yyyy-MM-dd")
            tglakhir = Format(DateTimePickerAkhir.Value, "yyyy-MM-dd")
            If tglawal >= tglakhir Then
                MsgBox("Rentang tgl promo salah!")
            Else
                If TextBoxPromo.Text = "" Then
                    MsgBox("Harap mengisi promo!")
                Else
                    Dim cekBrgDiskon As New ArrayList
                    cekBrgDiskon = cekDiskonBrg()
                    Dim isBrg As Integer = 0
                    If cekBrgDiskon.Count > 0 Then
                        Dim id As String = ""
                        For Each id In cekBrgDiskon
                            If ComboBoxBarang.SelectedValue.ToString = id Then
                                isBrg = 1
                                MsgBox("Barang yang anda masukan telah didiskon!")
                                Exit For
                            End If
                        Next
                        
                    End If

                    For i As Integer = 0 To DataGridView1.RowCount - 2
                        Dim brg As String = DataGridView1.Rows(i).Cells(0).Value.ToString
                        If brg = ComboBoxBarang.SelectedValue.ToString Then
                            isBrg = 1
                            MsgBox("Barang yang anda masukan telah diinput!")
                            Exit For
                        End If
                    Next

                    Dim tempNamaBrg() As String
                    tempNamaBrg = ambilNamaBarang()
                    Dim diskon As Integer = 0
                    diskon = HitungDiskon()
                    If isBrg = 0 Then
                        If diskon > 0 Then
                            DataGridView1.Rows.Insert(DataGridView1.NewRowIndex, ComboBoxBarang.SelectedValue.ToString, tempNamaBrg(0), TextBoxDiskonPersen.Text, TextBoxDiskonIDR.Text, TextBoxMinQty.Text, TextBoxHB.Text, TextBoxHJ.Text, TextBoxHDiskon.Text, TextBoxProfitBrg.Text, TextBoxProfitTransaksi.Text, "Cancel")
                        End If
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox("Fungsi tambahData bermasalah! " + ex.ToString)
        End Try
    End Sub


    Sub ClearDataTransaksi()
        TextBoxCariBarang.Text = ""
        TextBoxMinQty.Text = 0
        TextBoxDiskonPersen.Text = 0
        TextBoxDiskonIDR.Text = 0
        TextBoxHB.Text = 0
        TextBoxHJ.Text = 0
        TextBoxHDiskon.Text = 0
        TextBoxProfitBrg.Text = 0
        TextBoxProfitTransaksi.Text = 0
        tampilBarang()
    End Sub

    Function HitungDiskon()
        Dim minqty As Decimal = 0
        Dim diskonPersen As Decimal = 0.0
        Dim diskonIDR As Decimal = 0.0
        Dim hdiskon As Decimal = 0.0
        Dim hj As Decimal = 0.0
        Dim hb As Decimal = 0.0
        Dim profitbrg As Decimal = 0.0
        Dim profittrans As Decimal = 0.0
        Dim cekDiskon As Integer = 0
        Try
            If TextBoxMinQty.Text = "" Or TextBoxDiskonPersen.Text = "" Then
                MsgBox("Harap mengisi min qty dan diskon barang!")
            Else
                minqty = TextBoxMinQty.Text
                diskonPersen = TextBoxDiskonPersen.Text
                If diskonPersen >= 100 Then
                    MsgBox("Diskon terlalu besar!")
                    cekDiskon = 0
                    TextBoxDiskonPersen.Text = 0
                Else
                    cekDiskon = Integer.Parse(TextBoxDiskonPersen.Text)
                    diskonPersen = diskonPersen / 100
                    hj = TextBoxHJ.Text
                    hb = TextBoxHB.Text

                    diskonIDR = hj * diskonPersen
                    TextBoxDiskonIDR.Text = diskonIDR
                    hdiskon = hj - diskonIDR
                    TextBoxHDiskon.Text = hdiskon
                    profitbrg = hdiskon - hb
                    TextBoxProfitBrg.Text = profitbrg
                    profittrans = profitbrg * minqty
                    TextBoxProfitTransaksi.Text = profittrans
                End If
            End If
        Catch ex As Exception
            MsgBox("Hitung diskon bermasalah! " + ex.ToString)
        End Try
        Return cekDiskon
    End Function


    Private Sub diskon_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tampilBarang()
        tampilPetugas()
        No()
    End Sub

    Private Sub ComboBoxBarang_SelectedValueChanged(sender As Object, e As EventArgs) Handles ComboBoxBarang.SelectedValueChanged
        ambilNamaBarang()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        HitungDiskon()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        tampilBarang()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles ButtonTambah.Click
        If ComboBoxBarang.Items.Count <= 0 Then
            MsgBox("Harap isi data barang!")
        Else
            tambahData()
            ClearDataTransaksi()
        End If
        
    End Sub

    Sub updateDiskonBarang()
        Dim awal As Date = DateTimePickerMulai.Value
        Dim akhir As Date = DateTimePickerAkhir.Value
        Dim id_diskon As String = TextBoxId.Text
        Dim trans_promo As New Transaksi_Promo
        trans_promo.UpdateDiskonPromo(awal, akhir, id_diskon)
        MsgBox("Data promo berhasil diperbarui!")
        trans_promo.Dispose()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles ButtonSimpan.Click
        If DataGridView1.Rows.Count - 1 = 0 Then
            MsgBox("Anda belum memasukan barang!")
        Else
            Dim status_promo As String = tambahDetailData()
            updateDiskonBarang()
            ButtonClear.Enabled = False
            ButtonSimpan.Enabled = False
            ButtonCetak.Enabled = True
            ButtonTambah.Enabled = False
        End If
    End Sub

    Private Sub ButtonNew_Click(sender As Object, e As EventArgs) Handles ButtonNew.Click
        No()
        clearData()
        ButtonClear.Enabled = False
        ButtonCetak.Enabled = False
        ButtonSimpan.Enabled = True
        ButtonTambah.Enabled = True
        DataGridView1.Rows.Clear()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Try
            If DataGridView1.Rows(e.RowIndex).Cells(10).Value = "Cancel" Then
                DataGridView1.Rows.RemoveAt(e.RowIndex)
            End If
        Catch ex As Exception
        End Try
    End Sub

    Sub clearData()
        TextBoxCariBarang.Text = ""
        TextBoxDiskonIDR.Text = ""
        TextBoxDiskonPersen.Text = ""
        TextBoxHB.Text = ""
        TextBoxHJ.Text = ""
        TextBoxHDiskon.Text = ""
        TextBoxKet.Text = ""
        TextBoxMinQty.Text = ""
        TextBoxProfitTransaksi.Text = ""
        TextBoxProfitBrg.Text = ""
        TextBoxPromo.Text = ""
        TextBoxSatuan.Text = ""
        DateTimePickerMulai.Value = Today
        DateTimePickerAkhir.Value = Today
        tampilBarang()
        tampilPetugas()
    End Sub

    Private Sub ButtonClear_Click(sender As Object, e As EventArgs) Handles ButtonClear.Click
        clearData()
    End Sub

    Private Sub ButtonCetak_Click(sender As Object, e As EventArgs) Handles ButtonCetak.Click
        Dim pre As New Preview
        pre.printWhat = "diskon"
        pre.id = TextBoxId.Text
        pre.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim tampilBrg As New barang
        tampilBrg.ShowDialog()
    End Sub

    Private Sub TextBoxDiskonPersen_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxDiskonPersen.KeyPress
        Dim allowedChars As String = "0123456789."
        If allowedChars.IndexOf(e.KeyChar) = -1 Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBoxMinQty_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxMinQty.KeyPress
        Dim allowedChars As String = "0123456789."
        If allowedChars.IndexOf(e.KeyChar) = -1 Then
            e.Handled = True
        End If
    End Sub
End Class