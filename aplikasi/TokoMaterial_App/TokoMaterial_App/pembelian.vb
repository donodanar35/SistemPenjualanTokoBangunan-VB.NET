Imports MySql.Data.MySqlClient

Public Class pembelian
    Public usernameku As String
    Public namapetugas As String
    Public id As String
    Public conn As MySqlConnection
    Public cmd As MySqlCommand
    Public da As MySqlDataAdapter
    Public dt As New DataTable("barang")
    Public ds As New DataSet
    Public DR As MySqlDataReader
    Public total As Decimal = 0

    Function No()
        Dim temp As Integer
        Try
            conn = Form1.koneksi()
            Dim str As String
            str = "select count(*) 'no' from hbeli"
            Dim cmd = New MySqlCommand(str, conn)
            DR = cmd.ExecuteReader

            If DR.HasRows Then
                While DR.Read()
                    temp = DR.Item("no") + 1
                End While
            Else
                temp = 1
            End If
            id = "beli" + temp.ToString
            TextBoxId.Text = id
            DR.Close()
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
            MessageBox.Show("Indexing gagal dilakukan!")
        End Try
        Return temp
    End Function

    Sub tampilSupplier(id_sam As String)
        ComboBoxSupplier.DataSource = Nothing
        ds.Clear()
        Try
            conn = Form1.koneksi()
            Dim qs As String = "Select s.id_sup 'id_sup', s.nama_sup 'nama_sup' From SUPPLIER s WHERE s.STATUS = 1 AND s.nama_sup like '%" & id_sam & "%'"
            da = New MySqlDataAdapter(qs, conn)
            Dim dtSupplier As New DataTable("supplier")
            da.Fill(dtSupplier)

            ComboBoxSupplier.DataSource = dtSupplier
            ComboBoxSupplier.DisplayMember = "nama_sup"
            ComboBoxSupplier.ValueMember = "id_sup"
            conn.Close()
        Catch ex As Exception
            MsgBox("Tampilan supplier bermasalah! ")
        End Try
    End Sub

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
        Dim temp() As String = {"", 0.0, ""}
        Try
            conn = Form1.koneksi()
            Dim qs As String = "SELECT b.nama_brg 'nama_brg', b.harga_beli 'harga_beli', s.nama_satuan 'nama_satuan' From BARANG b, SATUAN s WHERE b.id_brg like '" & ComboBoxBarang.SelectedValue.ToString & "' AND b.id_satuan = s.id_satuan"
            Dim cmd = New MySqlCommand(qs, conn)
            Dim DRX As MySqlDataReader
            DRX = cmd.ExecuteReader

            If DRX.HasRows Then
                While DRX.Read()
                    temp(0) = DRX.Item("nama_brg")
                    temp(1) = DRX.Item("harga_beli")
                    TextBoxHarga.Text = temp(1)
                    temp(2) = DRX.Item("nama_satuan")
                    TextBoxSatuan.Text = temp(2)
                End While
            End If

            DRX.Close()
            conn.Close()
        Catch ex As Exception
            MsgBox("Fungsi ambilBarang bermasalah! " + ex.ToString)
        End Try
        Return temp
    End Function

    Sub tambahData()
        Try
            Dim isBrg As Integer = 0
            For i As Integer = 0 To DataGridView1.RowCount - 2
                Dim brg As String = DataGridView1.Rows(i).Cells(0).Value.ToString
                If brg = ComboBoxBarang.SelectedValue.ToString Then
                    isBrg = 1
                    MsgBox("Barang yang anda masukan telah diinput!")
                    Exit For
                End If
            Next
            Dim qty As Decimal = 0
            If TextBoxQty.Text = "" Then
                qty = 0
            Else
                qty = TextBoxQty.Text
            End If

            Dim subtotalx As Decimal = 0.0
            Dim tempNamaBrg() As String = ambilNamaBarang()

            If (isBrg <> 1 And qty <> 0 And TextBoxQty.Text <> "") Then
                subtotalx = qty * TextBoxHarga.Text
                DataGridView1.Rows.Insert(DataGridView1.NewRowIndex, ComboBoxBarang.SelectedValue.ToString, tempNamaBrg(0), tempNamaBrg(1), TextBoxQty.Text, tempNamaBrg(2), subtotalx, "Cancel")
            End If
        Catch ex As Exception
            MsgBox("Fungsi tambahData bermasalah! " + ex.ToString)
        End Try
    End Sub

    Sub tambahHeaderData()
        'MsgBox(usernameku + " " + ComboBoxSupplier.SelectedValue.ToString + " " + Format(DateTimePickerTgl.Value, "yyyy-MM-dd") & " " + TextBoxTotal.Text & " " & TextBoxKet.Text)
        If TextBoxId.Text <> "" Then
            Try
                usernameku = Form1.username
                conn = Form1.koneksi()
                Dim qs As String = "INSERT INTO HBELI (ID_BELI, ID_KAR, ID_SUP, TGL_BELI, TGL_KIRIM, TOTAL, TOTAL_ITEM, KET_BELI, STATUS) VALUES ('" & TextBoxId.Text & "', '" & usernameku & "', '" & ComboBoxSupplier.SelectedValue.ToString & "', '" & Format(DateTimePickerTgl.Value, "yyyy-MM-dd") & "' , '" & Format(DateTimePickerkIRIM.Value, "yyyy-MM-dd") & "' , '" & TextBoxTotal.Text & "', '" & TextBoxTItem.Text & "', '" & TextBoxKet.Text & "', 1)"
                cmd = New MySqlCommand(qs, conn)
                cmd.ExecuteNonQuery()
                conn.Close()
            Catch ex As Exception
                MsgBox("Header transaksi pembelian error! " + ex.ToString)
            End Try
        Else
            MsgBox("Id kosong!")
        End If
    End Sub

    Sub tambahDetailData()
        If DataGridView1.Rows.Count - 1 > 0 Then
            tambahHeaderData()
            tambahHeaderStockin()
            conn = Form1.koneksi()
            Dim trans As MySqlTransaction = conn.BeginTransaction()
            If TextBoxId.Text <> "" Then
                Try
                    For i As Integer = 0 To DataGridView1.RowCount - 2
                        Dim qs As String = "INSERT INTO DBELI (ID_BRG, ID_BELI, QTY_BELI, HRG_BELI, SUBTOTAL_BELI) VALUES ('" & DataGridView1.Rows(i).Cells(0).Value & "','" & TextBoxId.Text & "','" & DataGridView1.Rows(i).Cells(3).Value & "','" & DataGridView1.Rows(i).Cells(2).Value & "','" & DataGridView1.Rows(i).Cells(5).Value & "')"
                        Dim cmd = New MySqlCommand(qs, conn)
                        cmd.ExecuteNonQuery()

                        'Dim qsx As String = "INSERT INTO DSTOCKIN (ID_BRG, ID_STOCKIN, QTY, N_BAIK, N_RUSAK, HARGA_BELI, SUBTOTAL) VALUES ('" & DataGridView1.Rows(i).Cells(0).Value & "','" & id_stockin & "','" & DataGridView1.Rows(i).Cells(3).Value & "','" & DataGridView1.Rows(i).Cells(3).Value & "','0','" & DataGridView1.Rows(i).Cells(2).Value & "','" & DataGridView1.Rows(i).Cells(5).Value & "')"
                        'Dim cmdx = New MySqlCommand(qsx, conn)
                        'cmdx.ExecuteNonQuery()
                    Next
                    trans.Commit()
                    MessageBox.Show("Data transaksi pembelian berhasil dilakukan!")
                Catch ex As Exception
                    trans.Rollback()
                    MessageBox.Show("Data transaksi pembelian gagal dilakukan!")
                End Try
            Else
                MsgBox("Id kosong!")
            End If
            trans.Dispose()
            conn.Close()
        End If
    End Sub

    Function NoStockin()
        Dim temp As Integer = 0
        Dim idx As String = ""
        Try
            conn = Form1.koneksi()
            Dim str As String = ""
            str = "select count(*) 'no' from hstockin"

            Dim cmd = New MySqlCommand(str, conn)
            DR = cmd.ExecuteReader

            If DR.HasRows Then
                While DR.Read()
                    temp = DR.Item("no") + 1
                End While
            Else
                temp = 1
            End If

            idx = "stockin" + temp.ToString

            DR.Close()
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
            MessageBox.Show("Indexing gagal dilakukan!")
        End Try
        Return idx
    End Function

    Dim id_stockin As String = ""
    Sub tambahHeaderStockin()
        id_stockin = NoStockin()
        If id_stockin <> "" Then
            Try
                usernameku = Form1.username
                conn = Form1.koneksi()
                Dim qs As String = "INSERT INTO HSTOCKIN (ID_STOCKIN, ID_KAR, TGL_PESAN, TGL_KIRIM, TGL_TERIMA, REFERENSI, TOTAL, TOTAL_ITEM, KETERANGAN, STATUS_STOK, STATUS) VALUES ('" & id_stockin & "', '" & usernameku & "', '" & Format(DateTimePickerTgl.Value, "yyyy-MM-dd") & "','2012-12-12','" & Format(DateTimePickerkIRIM.Value, "yyyy-MM-dd") & "', '" & TextBoxId.Text & "', '" & TextBoxTotal.Text & "', '" & TextBoxTItem.Text & "', '" & TextBoxKet.Text & "', 'diproses', 1)"
                cmd = New MySqlCommand(qs, conn)
                cmd.ExecuteNonQuery()
                cmd.Dispose()
                conn.Close()
            Catch ex As Exception
                MsgBox("Header transaksi stok error! " + ex.ToString)
            End Try
        Else
            MsgBox("Id kosong!")
        End If
    End Sub

    Sub ClearDataTransaksi()
        TextBoxCariBarang.Text = ""
        TextBoxQty.Text = "0"
        tampilBarang()
    End Sub

    Function HitungTotalPembelian()
        Try
            total = 0
            If DataGridView1.RowCount >= 2 Then
                For i As Integer = 0 To DataGridView1.RowCount - 2
                    Dim temp As Decimal = DataGridView1.Rows(i).Cells(5).Value
                    total = total + temp
                Next
            End If
            TextBoxTotal.Text = total
            TextBoxTItem.Text = DataGridView1.RowCount - 1
        Catch ex As Exception
            MsgBox("Hitung total pembelian bermasalah! " + ex.ToString)
        End Try
        Return total
    End Function

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles ButtonTambah.Click
        If ComboBoxBarang.Items.Count <= 0 Then
            MsgBox("Harap isi data barang!")
        Else
            If TextBoxQty.Text = "" Then
                TextBoxQty.Text = 0
            End If
            If TextBoxQty.Text = 0 Then
                MsgBox("Harap masukan qty barang!")
            Else
                tambahData()
                TextBoxCariBarang.Text = ""
                TextBoxQty.Text = ""
                HitungTotalPembelian()
            End If
        End If
    End Sub

    Private Sub pembelian_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tampilBarang()
        tampilPetugas()
        tampilSupplier("")
        No()
    End Sub

    Private Sub ComboBoxBarang_SelectedValueChanged(sender As Object, e As EventArgs) Handles ComboBoxBarang.SelectedValueChanged
        ambilNamaBarang()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles ButtonSimpan.Click
        If ComboBoxBarang.Items.Count <= 0 Then
            MsgBox("Harap isi data barang!")
        Else
            If DataGridView1.Rows.Count > 1 Then
                tambahDetailData()
                ButtonCetak.Enabled = True
                ButtonSimpan.Enabled = False
                ButtonTambah.Enabled = False
                ButtonClear.Enabled = False
            Else
                MsgBox("Harap mengisi barang!")
            End If
        End If
    End Sub

    Private Sub TextBoxQty_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxQty.KeyPress
        Dim allowedChars As String = "0123456789."
        If allowedChars.IndexOf(e.KeyChar) = -1 Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBoxHarga_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxHarga.KeyPress
        Dim allowedChars As String = "0123456789."
        If allowedChars.IndexOf(e.KeyChar) = -1 Then
            ' Invalid Character
            e.Handled = True
        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Try
            If DataGridView1.Rows(e.RowIndex).Cells(6).Value = "Cancel" Then
                DataGridView1.Rows.RemoveAt(e.RowIndex)
            End If
            HitungTotalPembelian()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        tampilSupplier(TextBoxCariSup.Text)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        tampilBarang()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        ButtonSimpan.Enabled = True
        ButtonTambah.Enabled = True
        ButtonClear.Enabled = True
        ClearData()
        DataGridView1.Rows.Clear()
        id_stockin = ""
    End Sub

    Sub ClearData()
        DataGridView1.Rows.Clear()
        No()
        ButtonCetak.Enabled = False
        tampilBarang()
        tampilPetugas()
        tampilSupplier("")
        TextBoxCariBarang.Text = ""
        TextBoxCariSup.Text = ""
        TextBoxHarga.Text = ""
        TextBoxKet.Text = ""
        TextBoxQty.Text = 0
        TextBoxSatuan.Text = ""
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles ButtonClear.Click
        ClearData()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ButtonCetak.Click
        Dim cetak As New Preview
        cetak.printWhat = "pembelian"
        cetak.id = TextBoxId.Text
        cetak.kepada = "pemasok"
        cetak.no = "1"
        cetak.ShowDialog()

        Dim cetak2 As New Preview
        cetak2.printWhat = "permintaan_barang"
        cetak2.id = TextBoxId.Text
        cetak2.id_PO = id_stockin
        cetak2.kepada = "staf gudang"
        cetak2.no = "2"
        cetak2.ShowDialog()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Dim lihatBrg As New barang
        lihatBrg.ShowDialog()
    End Sub
End Class