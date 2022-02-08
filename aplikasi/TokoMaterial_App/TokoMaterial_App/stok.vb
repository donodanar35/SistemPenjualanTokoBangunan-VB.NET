Imports MySql.Data.MySqlClient

Public Class stok
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
    Public IsTerima As Integer = 0
    Public id_stockin As String = ""

    Function No()
        Dim temp As Integer = 0
        If IsTerima = 0 Then
            Try
                conn = Form1.koneksi()
                Dim str As String = ""

                If RadioButtonIn.Checked Then
                    str = "select count(*) 'no' from hstockin"
                ElseIf RadioButtonOut.Checked Then
                    str = "select count(*) 'no' from hstockout"
                End If

                Dim cmd = New MySqlCommand(str, conn)
                DR = cmd.ExecuteReader

                If DR.HasRows Then
                    While DR.Read()
                        temp = DR.Item("no") + 1
                    End While
                Else
                    temp = 1
                End If

                If RadioButtonIn.Checked Then
                    id = "stockin" + temp.ToString
                    TextBoxId.Text = id
                ElseIf RadioButtonOut.Checked Then
                    id = "stockout" + temp.ToString
                    TextBoxId.Text = id
                End If

                DR.Close()
                conn.Close()
            Catch ex As Exception
                MsgBox(ex.ToString)
                MessageBox.Show("Indexing gagal dilakukan!")
            End Try
        Else
            TextBoxId.Text = id_stockin
        End If
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

    Sub tampilBarang(barang As String, ref As String, isTerima As Integer)
        ds.Clear()
        Try
            conn = Form1.koneksi()
            Dim qs As String = "Select id_brg, nama_brg From BARANG WHERE STATUS = 1 AND nama_brg like '%" & barang & "%'"
            If IsTerima = 1 Then
                qs = "Select d.id_brg, b.nama_brg From BARANG b, DBELI d WHERE b.id_brg = d.id_brg AND d.id_beli like '" & ref & "'"
            End If
            'MsgBox("terima: " + IsTerima)
            da = New MySqlDataAdapter(qs, conn)
            Dim dtBarang As New DataTable("barang")
            da.Fill(dtBarang)

            ComboBoxBarang.DataSource = dtBarang
            ComboBoxBarang.DisplayMember = "nama_brg"
            ComboBoxBarang.ValueMember = "id_brg"
            conn.Close()
        Catch ex As Exception
            MsgBox("Tampilan barang bermasalah! " + ex.ToString)
        End Try
    End Sub

    Function ambilNamaBarang()
        usernameku = Form1.username
        ds.Clear()
        Dim temp() As String = {"", "", 0, 0}
        Try
            conn = Form1.koneksi()
            Dim qs As String = "SELECT b.nama_brg 'nama_brg', s.nama_satuan 'nama_satuan', b.harga_beli 'hb', b.stok 'stok' From BARANG b, SATUAN s WHERE b.id_brg like '" & ComboBoxBarang.SelectedValue.ToString & "' AND b.id_satuan = s.id_satuan"
            Dim cmd = New MySqlCommand(qs, conn)
            Dim DRX As MySqlDataReader
            DRX = cmd.ExecuteReader

            If DRX.HasRows Then
                While DRX.Read()
                    temp(0) = DRX.Item("nama_brg")
                    temp(1) = DRX.Item("nama_satuan")
                    temp(2) = DRX.Item("hb")
                    temp(3) = DRX.Item("stok")
                    TextBoxSatuan.Text = temp(1)
                    TextBoxHB.Text = temp(2)
                    TextBoxStok.Text = temp(3)
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
            Dim hb As Decimal = 0
            Dim subtotal As Decimal = 0
            Dim qty As Decimal = 0
            Dim nbaik As Decimal = 0
            Dim nrusak As Decimal = 0
            Dim stok As Decimal = 0

            Dim isBrg As Integer = 0
            For i As Integer = 0 To DataGridView1.RowCount - 2
                Dim brg As String = DataGridView1.Rows(i).Cells(0).Value.ToString
                If brg = ComboBoxBarang.SelectedValue.ToString Then
                    isBrg = 1
                    MsgBox("Barang yang anda masukan telah diinput!")
                    Exit For
                End If
            Next

            If TextBoxQty.Text = "" Then
                qty = 0
                hb = 0
                nbaik = 0
                nrusak = 0
                subtotal = 0
                stok = 0
            Else
                qty = Decimal.Parse(TextBoxQty.Text)
                hb = Decimal.Parse(TextBoxHB.Text)
                nbaik = Decimal.Parse(TextBoxNBaik.Text)
                nrusak = Decimal.Parse(TextBoxNRusak.Text)
                stok = Decimal.Parse(TextBoxStok.Text)
                subtotal = hb * qty
                TextBoxSubtotal.Text = subtotal
            End If

            Dim temp() As String = {"", ""}
            temp = ambilNamaBarang()

            If (isBrg <> 1 And qty <> 0 And TextBoxQty.Text <> "") Then
                DataGridView1.Rows.Insert(DataGridView1.NewRowIndex, ComboBoxBarang.SelectedValue, temp(0), qty, nbaik, nrusak, hb, subtotal, stok, "Cancel")
            End If
        Catch ex As Exception
            MsgBox("Fungsi tambahData bermasalah! " + ex.ToString)
        End Try
    End Sub

    Public io As String = "in"
    Public status As String = "diproses"

    Sub tambahHeaderData()
        If TextBoxId.Text <> "" Then
            Try
                If Format(DateTimePickerTgl.Value, "yyyy-MM-dd") > Format(DateTimePickerKirim.Value, "yyyy-MM-dd") Then
                    MsgBox("Tgl pesan salah!")
                Else
                    If Format(Today, "yyyy-MM-dd") > Format(DateTimePickerKirim.Value, "yyyy-MM-dd") Then
                        status = "selesai"
                    ElseIf Format(Today, "yyyy-MM-dd") = Format(DateTimePickerKirim.Value, "yyyy-MM-dd") Then
                        status = "selesai"
                    ElseIf Format(Today, "yyyy-MM-dd") < Format(DateTimePickerKirim.Value, "yyyy-MM-dd") Then
                        status = "diproses"
                    End If

                    usernameku = Form1.username
                    conn = Form1.koneksi()
                    Dim qs As String = "INSERT INTO HSTOCKIN (ID_STOCKIN, ID_KAR, TGL_PESAN, TGL_KIRIM, TGL_TERIMA, REFERENSI, TOTAL, TOTAL_ITEM, KETERANGAN, STATUS_STOK, STATUS) VALUES ('" & TextBoxId.Text & "', '" & usernameku & "', '" & Format(DateTimePickerTgl.Value, "yyyy-MM-dd") & "', '" & Format(DateTimePickerKirim.Value, "yyyy-MM-dd") & "', '" & Format(DateTimePickerTerima.Value, "yyyy-MM-dd") & "' , '" & TextBoxRef.Text & "', '" & TextBoxTotal.Text & "', '" & TextBoxTItem.Text & "', '" & TextBoxKet.Text & "', '" & status & "', 1)"

                    id_stockin = TextBoxId.Text
                    If RadioButtonIn.Checked Then
                        If IsTerima = 0 Then
                            qs = "INSERT INTO HSTOCKIN (ID_STOCKIN, ID_KAR, TGL_PESAN, TGL_KIRIM, TGL_TERIMA, REFERENSI, TOTAL, TOTAL_ITEM, KETERANGAN, STATUS_STOK, STATUS) VALUES ('" & id_stockin & "', '" & usernameku & "', '" & Format(DateTimePickerTgl.Value, "yyyy-MM-dd") & "', '" & Format(DateTimePickerKirim.Value, "yyyy-MM-dd") & "', '" & Format(DateTimePickerTerima.Value, "yyyy-MM-dd") & "' , '" & TextBoxRef.Text & "', '" & TextBoxTotal.Text & "', '" & TextBoxTItem.Text & "', '" & TextBoxKet.Text & "', '" & status & "', 1)"
                        Else
                            qs = "UPDATE HSTOCKIN SET ID_KAR ='" & usernameku & "', TGL_TERIMA ='" & Format(DateTimePickerTerima.Value, "yyyy-MM-dd") & "', REFERENSI = '" & TextBoxRef.Text & "', TOTAL = '" & TextBoxTotal.Text & "', TOTAL_ITEM = '" & TextBoxTItem.Text & "', KETERANGAN = '" & TextBoxKet.Text & "', STATUS_STOK ='selesai', STATUS =1 WHERE ID_STOCKIN = '" & TextBoxId.Text & "'"
                            status = "selesai"
                        End If
                    ElseIf RadioButtonOut.Checked Then
                        qs = "INSERT INTO HSTOCKOUT (ID_STOCKOUT, ID_KAR, TGL_PESAN, TGL_KIRIM, REFERENSI, TOTAL, TOTAL_ITEM, KETERANGAN, STATUS_STOK, STATUS) VALUES ('" & TextBoxId.Text & "', '" & usernameku & "', '" & Format(DateTimePickerTgl.Value, "yyyy-MM-dd") & "', '" & Format(DateTimePickerKirim.Value, "yyyy-MM-dd") & "' , '" & TextBoxRef.Text & "', '" & TextBoxTotal.Text & "', '" & TextBoxTItem.Text & "', '" & TextBoxKet.Text & "', '" & status & "', 1)"
                    End If
                    cmd = New MySqlCommand(qs, conn)
                    cmd.ExecuteNonQuery()
                    cmd.Dispose()
                    conn.Close()

                    ButtonSimpan.Enabled = False
                    ButtonTambah.Enabled = False
                    ButtonCetak.Enabled = True
                    ButtonClear.Enabled = False
                End If
            Catch ex As Exception
                MsgBox("Header transaksi stok error! " + ex.ToString)
            End Try
        Else
            MsgBox("Id kosong!")
        End If
    End Sub

    Sub tambahDetailData()
        If DataGridView1.Rows.Count - 1 > 0 Then
            If Format(DateTimePickerTgl.Value, "yyyy-MM-dd") > Format(DateTimePickerKirim.Value, "yyyy-MM-dd") Then
            Else
                tambahHeaderData()
                If TextBoxId.Text <> "" Then
                    conn = Form1.koneksi()
                    Dim trans As MySqlTransaction = conn.BeginTransaction()
                    Try
                        For i As Integer = 0 To DataGridView1.RowCount - 2
                            Dim qs As String = "INSERT INTO DSTOCKIN (ID_BRG, ID_STOCKIN, QTY, N_BAIK, N_RUSAK, HARGA_BELI, SUBTOTAL) VALUES ('" & DataGridView1.Rows(i).Cells(0).Value & "','" & TextBoxId.Text & "','" & DataGridView1.Rows(i).Cells(2).Value & "','" & DataGridView1.Rows(i).Cells(3).Value & "','" & DataGridView1.Rows(i).Cells(4).Value & "','" & DataGridView1.Rows(i).Cells(5).Value & "','" & DataGridView1.Rows(i).Cells(6).Value & "')"
                            If RadioButtonIn.Checked Then
                                qs = "INSERT INTO DSTOCKIN (ID_BRG, ID_STOCKIN, QTY, N_BAIK, N_RUSAK, HARGA_BELI, SUBTOTAL) VALUES ('" & DataGridView1.Rows(i).Cells(0).Value & "','" & TextBoxId.Text & "','" & DataGridView1.Rows(i).Cells(2).Value & "','" & DataGridView1.Rows(i).Cells(3).Value & "','" & DataGridView1.Rows(i).Cells(4).Value & "','" & DataGridView1.Rows(i).Cells(5).Value & "','" & DataGridView1.Rows(i).Cells(6).Value & "')"
                            ElseIf RadioButtonOut.Checked Then
                                qs = "INSERT INTO DSTOCKOUT (ID_BRG, ID_STOCKOUT, QTY, N_BAIK, N_RUSAK, HARGA_BELI, SUBTOTAL) VALUES ('" & DataGridView1.Rows(i).Cells(0).Value & "','" & TextBoxId.Text & "','" & DataGridView1.Rows(i).Cells(2).Value & "','" & DataGridView1.Rows(i).Cells(3).Value & "','" & DataGridView1.Rows(i).Cells(4).Value & "','" & DataGridView1.Rows(i).Cells(5).Value & "','" & DataGridView1.Rows(i).Cells(6).Value & "')"
                            End If

                            Dim cmd = New MySqlCommand(qs, conn)
                            cmd.ExecuteNonQuery()
                            cmd.Dispose()
                            Dim Mystok As Decimal = DataGridView1.Rows(i).Cells(7).Value

                            Dim qsx As String = ""
                            If RadioButtonIn.Checked And status = "selesai" Then
                                Dim tempStok As Decimal = DataGridView1.Rows(i).Cells(2).Value
                                Mystok = Mystok + tempStok
                            ElseIf RadioButtonOut.Checked And (status = "selesai" Or status = "diproses") Then
                                Dim tempStok As Decimal = DataGridView1.Rows(i).Cells(2).Value
                                Mystok = Mystok - tempStok
                            End If
                            qsx = "UPDATE barang SET stok = '" & Mystok & "' WHERE id_brg = '" & DataGridView1.Rows(i).Cells(0).Value & "'"

                            Dim cmdx = New MySqlCommand(qsx, conn)
                            cmdx.ExecuteNonQuery()
                            cmdx.Dispose()
                        Next
                        status = "diproses"
                        trans.Commit()
                        MessageBox.Show("Data transaksi stok berhasil dilakukan!")
                    Catch ex As Exception
                        trans.Rollback()
                        MessageBox.Show("Data transaksi stok gagal dilakukan!" + ex.ToString)
                    End Try
                    conn.Close()
                Else
                    MsgBox("Id kosong!")
                End If
            End If
        Else
            MsgBox("Harap mengisi barang!")
        End If
    End Sub

    Function HitungTotal()
        Try
            total = 0
            If DataGridView1.RowCount >= 2 Then
                For i As Integer = 0 To DataGridView1.RowCount - 2
                    Dim temp As Decimal = DataGridView1.Rows(i).Cells(6).Value
                    total = total + temp
                Next
            End If
            TextBoxTItem.Text = DataGridView1.RowCount - 1
            TextBoxTotal.Text = total
        Catch ex As Exception
            MsgBox("Hitung total pembelian bermasalah! " + ex.ToString)
        End Try
        Return total
    End Function

    Sub ClearData()
        TextBoxCariBarang.Text = ""
        TextBoxHB.Text = 0
        TextBoxNBaik.Text = 0
        TextBoxNRusak.Text = 0
        TextBoxSubtotal.Text = 0.0
        TextBoxQty.Text = 0
        TextBoxSatuan.Text = ""
    End Sub

    Sub ClearAll()
        ClearTrans()
        ClearData()
        TextBoxId.Text = ""
        TextBoxKet.Text = ""
        TextBoxRef.Text = ""
        TextBoxPetugas.Text = ""
        RadioButtonOut.Checked = True
        No()
        tampilBarang("", "", 0)
        tampilPetugas()
    End Sub

    Sub ClearTrans()
        TextBoxCariBarang.Text = ""
        TextBoxQty.Text = 0
        tampilBarang("", "", 0)
    End Sub

    Private Sub stok_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tampilBarang("", "", 0)
        tampilPetugas()
        No()
    End Sub

    Private Sub ButtonTambah_Click(sender As Object, e As EventArgs) Handles ButtonTambah.Click
        If ComboBoxBarang.Items.Count <= 0 Then
            MsgBox("Harap isi data barang!")
        Else
            If TextBoxQty.Text = "" Then
                TextBoxQty.Text = 0
            Else
                Dim temp As Integer = TextBoxQty.Text
                If temp > 0 Then
                    Dim nbaik As Decimal = 0
                    Dim nRusak As Decimal = 0
                    nbaik = Decimal.Parse(TextBoxNBaik.Text)
                    nRusak = Decimal.Parse(TextBoxNRusak.Text)
                    Dim totalBarang As Decimal = nbaik + nRusak
                    Dim qty As Decimal = 0
                    qty = Decimal.Parse(TextBoxQty.Text)

                    If qty <> totalBarang Then
                        MsgBox("Jumlah barang baik + barang rusak harus sama dengan qty!")
                    Else
                        tambahData()
                        HitungTotal()
                        ClearData()
                    End If
                    ClearTrans()
                Else
                    MsgBox("Harap masukkan qty barang! ")
                End If
            End If

        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Try
            If DataGridView1.Rows(e.RowIndex).Cells(8).Value = "Cancel" Then
                DataGridView1.Rows.RemoveAt(e.RowIndex)
            End If
            HitungTotal()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub ButtonSimpan_Click(sender As Object, e As EventArgs) Handles ButtonSimpan.Click
        tambahDetailData()
    End Sub

    Private Sub ComboBoxBarang_SelectedValueChanged(sender As Object, e As EventArgs) Handles ComboBoxBarang.SelectedValueChanged
        ambilNamaBarang()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        tampilBarang(TextBoxCariBarang.Text, "", 0)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        ButtonSimpan.Enabled = True
        ButtonTambah.Enabled = True
        ButtonCetak.Enabled = True
        ButtonClear.Enabled = True
        DataGridView1.Rows.Clear()
        ClearAll()
        No()
        tampilBarang("", "", 0)
        tampilPetugas()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim tampilBrg As New barang
        tampilBrg.Show()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles ButtonClear.Click
        ClearAll()
    End Sub

    Private Sub ButtonCetak_Click(sender As Object, e As EventArgs) Handles ButtonCetak.Click
        If RadioButtonIn.Checked Then
            Dim cetak As New Preview
            cetak.id = TextBoxId.Text
            cetak.printWhat = "persediaan_masuk"
            cetak.ShowDialog()
        ElseIf RadioButtonOut.Checked Then
            Dim cetak As New Preview
            cetak.id = TextBoxId.Text
            cetak.no = "1"
            cetak.kepada = "staf gudang"
            cetak.printWhat = "persediaan_keluar"
            cetak.ShowDialog()

            Dim cetak2 As New Preview
            cetak2.id = TextBoxId.Text
            cetak2.no = "2"
            cetak2.kepada = "kurir"
            cetak2.printWhat = "surat_jalan"
            cetak2.ShowDialog()
        End If
    End Sub

    Private Sub RadioButtonIn_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonIn.CheckedChanged
        visibleTerima()
    End Sub

    Private Sub RadioButtonOut_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonOut.CheckedChanged
        visibleTerima()
    End Sub

    Sub visibleTerima()
        If RadioButtonIn.Checked Then
            LabelTerima.Visible = True
            DateTimePickerTerima.Visible = True
            No()
        ElseIf RadioButtonOut.Checked Then
            LabelTerima.Visible = False
            DateTimePickerTerima.Visible = False
            No()
        End If
    End Sub

    Private Sub TextBoxQty_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxQty.KeyPress
        Dim allowedChars As String = "0123456789."
        If allowedChars.IndexOf(e.KeyChar) = -1 Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBoxNBaik_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxNBaik.KeyPress
        Dim allowedChars As String = "0123456789."
        If allowedChars.IndexOf(e.KeyChar) = -1 Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBoxNRusak_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxNRusak.KeyPress
        Dim allowedChars As String = "0123456789."
        If allowedChars.IndexOf(e.KeyChar) = -1 Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBoxHB_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxHB.KeyPress
        Dim allowedChars As String = "0123456789."
        If allowedChars.IndexOf(e.KeyChar) = -1 Then
            e.Handled = True
        End If
    End Sub
End Class