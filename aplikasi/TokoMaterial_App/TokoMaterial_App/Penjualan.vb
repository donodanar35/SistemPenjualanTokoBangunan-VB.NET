Imports MySql.Data.MySqlClient

Public Class Penjualan
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
            str = "select count(*) 'no' from hjual"
            Dim cmd = New MySqlCommand(str, conn)
            DR = cmd.ExecuteReader

            If DR.HasRows Then
                While DR.Read()
                    temp = DR.Item("no") + 1
                End While
            Else
                temp = 1
            End If
            id = "jual" + temp.ToString
            TextBoxId.Text = id
            DR.Close()
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
            MessageBox.Show("Indexing gagal dilakukan!")
        End Try
        Return temp
    End Function

    Sub tampilCustomer(id_sam As String)
        ComboBoxCustomer.DataSource = Nothing
        ds.Clear()
        Try
            conn = Form1.koneksi()
            Dim qs As String = "Select c.id_cus, c.nama_cus From CUSTOMER c, hsampel h WHERE c.STATUS = 1 AND h.id_sam like '" & id_sam & "' AND h.id_cus = c.id_cus"
            da = New MySqlDataAdapter(qs, conn)
            Dim dtCustomer As New DataTable("customer")
            da.Fill(dtCustomer)

            ComboBoxCustomer.DataSource = dtCustomer
            ComboBoxCustomer.DisplayMember = "nama_cus"
            ComboBoxCustomer.ValueMember = "id_cus"
            conn.Close()
        Catch ex As Exception
            MsgBox("Tampilan customer bermasalah! ")
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

    Sub tampilSampel()
        ds.Clear()
        Try
            conn = Form1.koneksi()
            Dim qs As String = "Select id_sam From HSAMPEL WHERE STATUS = 1 AND id_sam like '%" & TextBoxCariSampel.Text & "%'"
            da = New MySqlDataAdapter(qs, conn)
            Dim dtSampel As New DataTable("sampel")
            da.Fill(dtSampel)

            ComboBoxSampel.DataSource = dtSampel
            ComboBoxSampel.DisplayMember = "id_sam"
            ComboBoxSampel.ValueMember = "id_sam"
            conn.Close()
        Catch ex As Exception
            MsgBox("Tampilan sampel bermasalah! ")
        End Try
    End Sub

    Sub tampilBarang()
        ds.Clear()
        Try
            conn = Form1.koneksi()
            Dim qs As String = "Select b.id_brg, b.nama_brg From BARANG b, DSAMPEL d WHERE b.STATUS = 1 AND b.id_brg = d.id_brg AND b.nama_brg like '%" & TextBoxCariBarang.Text & "%' AND d.id_sam like '" & ComboBoxSampel.SelectedValue.ToString & "'"
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

    Function ambilStokBarang()
        usernameku = Form1.username
        ds.Clear()
        Dim temp As Integer = 0
        Try
            conn = Form1.koneksi()
            Dim qs As String = "SELECT stok From BARANG WHERE id_brg like '" & ComboBoxBarang.SelectedValue.ToString & "'"
            Dim cmd = New MySqlCommand(qs, conn)
            Dim DRX As MySqlDataReader
            DRX = cmd.ExecuteReader

            If DRX.HasRows Then
                While DRX.Read()
                    temp = DRX.Item("stok")
                End While
            End If

            DRX.Close()
            conn.Close()
        Catch ex As Exception
            MsgBox("Fungsi ambilStokBarang bermasalah! " + ex.ToString)
        End Try
        Return temp
    End Function

    Function cekStokBarang()
        Dim isCekStok As Integer = 0
        Try
            Dim stok As Integer = ambilStokBarang()
            If stok >= TextBoxQty.Text Then
                isCekStok = 1
            End If
        Catch ex As Exception
            MsgBox("CekStokBarang bermasalah!" + ex.ToString)
        End Try
        Return isCekStok
    End Function


    Function ambilNamaBarang()
        usernameku = Form1.username
        ds.Clear()
        Dim temp() As String = {"", 0.0, 0.1, 0.0, 0.0, "", 0, 0, 0}
        Try
            conn = Form1.koneksi()
            Dim qs As String = "SELECT b.stok 'stok', b.nama_brg 'nama_brg', b.harga_jual 'harga_jual', b.harga_beli 'harga_beli', b.ppn 'ppn', b.diskon 'diskon', b.stok 'stok', s.nama_satuan 'nama_satuan', b.min_qty 'min_qty' From BARANG b, SATUAN s WHERE b.id_brg like '" & ComboBoxBarang.SelectedValue & "' AND b.id_satuan = s.id_satuan"
            Dim cmd = New MySqlCommand(qs, conn)
            Dim DRX As MySqlDataReader
            DRX = cmd.ExecuteReader

            If DRX.HasRows Then
                While DRX.Read()
                    temp(0) = DRX.Item("nama_brg")
                    temp(1) = DRX.Item("harga_jual")
                    TextBoxHarga.Text = temp(1)
                    temp(2) = DRX.Item("ppn")
                    TextBoxPPN.Text = temp(2)
                    temp(3) = DRX.Item("diskon")
                    TextBoxDiskon.Text = temp(3)
                    temp(4) = DRX.Item("stok")
                    TextBoxTotalStok.Text = temp(4)
                    temp(5) = DRX.Item("nama_satuan")
                    TextBoxSatuan.Text = temp(5)
                    temp(6) = DRX.Item("min_qty")
                    temp(7) = DRX.Item("harga_beli")
                    temp(8) = DRX.Item("stok")
                End While
            End If

            DRX.Close()
            conn.Close()
        Catch ex As Exception
            MsgBox("Fungsi ambilBarang bermasalah! " + ex.ToString)
        End Try
        Return temp
    End Function

    Function HitungSubtotal()
        Dim temp() As String = ambilNamaBarang()
        Dim min_q As Decimal = temp(6)
        Dim qty As Decimal = 0
        qty = Decimal.Parse(TextBoxQty.Text)
        Dim diskon As Decimal = 0
        If qty >= min_q Then
            diskon = Decimal.Parse(temp(3))
        Else
            diskon = 0
        End If

        Dim harga As Decimal = 0
        harga = Decimal.Parse(temp(1))
        Dim ppn As Decimal = 0.1
        ppn = Decimal.Parse(temp(2))
        Dim subtotal As Decimal = 0
        Dim tPPN As Decimal = 0
        Dim tDiskon As Decimal = 0

        tPPN = (harga * qty * ppn)
        tDiskon = (harga * qty * (diskon / 100))
        subtotal = (harga * qty)
        subtotal = subtotal + tPPN - tDiskon
        Return subtotal
    End Function

    Sub tambahData()
        Try
            Dim qty As Decimal = 0
            If TextBoxQty.Text = "" Or TextBoxQty.Text = 0 Then
                MsgBox("Harap masukan quantity barang!")
            Else
                qty = TextBoxQty.Text
                Dim subtotal As Decimal = HitungSubtotal()
                Dim isStok As Integer = cekStokBarang()
                If isStok = 1 Then
                    Dim isBrg As Integer = 0
                    For i As Integer = 0 To DataGridView1.RowCount - 2
                        Dim brg As String = DataGridView1.Rows(i).Cells(0).Value.ToString
                        If brg = ComboBoxBarang.SelectedValue.ToString Then
                            isBrg = 1
                            MsgBox("Barang yang anda masukan telah diinput!")
                            Exit For
                        End If
                    Next
                    TextBoxTItem.Text = DataGridView1.Rows.Count
                    Dim tempNamaBrg() As String = ambilNamaBarang()
                    If isBrg <> 1 Then
                        DataGridView1.Rows.Insert(DataGridView1.NewRowIndex, ComboBoxBarang.SelectedValue.ToString, tempNamaBrg(0), TextBoxHarga.Text, TextBoxQty.Text, TextBoxDiskon.Text, TextBoxPPN.Text, subtotal, tempNamaBrg(7), tempNamaBrg(8), "Cancel")
                    End If
                Else
                    MsgBox("Stok barang habis!")
                End If
            End If
        Catch ex As Exception
            MsgBox("TambahData bermasalah!")
        End Try
    End Sub

    Sub tambahHeaderData()
        Dim totalDiskon = HitungTotalDiskon()
        Dim totalPPN = HitungTotalPPN()
        If TextBoxId.Text <> "" Then
            Try
                usernameku = Form1.username
                conn = Form1.koneksi()
                Dim qs As String = "INSERT INTO HJUAL (ID_JUAL, ID_KAR, ID_CUS, ID_SAM, TGL_JUAL, TGL_KIRIM, NAMA_PENERIMA, ALAMAT_PENERIMA, TELP_PENERIMA, TOTAL, TOTAL_ITEM, DIBAYAR, KEMBALI, TOTAL_PPN, TOTAL_DISKON, KET_JUAL, STATUS) VALUES ('" & TextBoxId.Text & "','" & usernameku & "','" & ComboBoxCustomer.SelectedValue.ToString & "','" & ComboBoxSampel.SelectedValue.ToString & "','" & Format(DateTimePickerTgl.Value, "yyyy-MM-dd") & "','" & Format(DateTimePickerKirim.Value, "yyyy-MM-dd") & "','" & TextBoxPenerima.Text & "','" & TextBoxAlamat.Text & "','" & TextBoxTelp.Text & "','" & TextBoxTotal.Text & "','" & TextBoxTItem.Text & "','" & TextBoxDibayar.Text & "','" & TextBoxKembali.Text & "','" & totalPPN & "','" & totalDiskon & "','" & TextBoxKet.Text & "',1)"
                cmd = New MySqlCommand(qs, conn)
                cmd.ExecuteNonQuery()
                conn.Close()
            Catch ex As Exception
                MsgBox("Header transaksi penjualan error! " + ex.ToString)
            End Try
        Else
            MsgBox("Id kosong!")
        End If
    End Sub

    Sub tambahDetailData()
        If DataGridView1.Rows.Count - 1 > 0 Then
            tambahHeaderData()
            tambahHeaderStockout()
            Dim dibayar As Decimal = 0
            dibayar = Decimal.Parse(TextBoxDibayar.Text)
            conn = Form1.koneksi()
            Dim trans As MySqlTransaction = conn.BeginTransaction()
            If TextBoxId.Text <> "" Then
                If dibayar >= 0 Then
                    Try
                        For i As Integer = 0 To DataGridView1.RowCount - 2
                            Dim qty As Decimal = DataGridView1.Rows(i).Cells(3).Value
                            Dim diskon As Decimal = DataGridView1.Rows(i).Cells(4).Value
                            Dim qs As String = "INSERT INTO DJUAL (ID_BRG, ID_JUAL, QTY_JUAL, HRG_JUAL, PPN, DISKON, SUBTOTAL_JUAL) VALUES ('" & DataGridView1.Rows(i).Cells(0).Value & "','" & TextBoxId.Text & "','" & DataGridView1.Rows(i).Cells(3).Value & "','" & DataGridView1.Rows(i).Cells(2).Value & "','" & DataGridView1.Rows(i).Cells(5).Value & "','" & diskon & "','" & DataGridView1.Rows(i).Cells(6).Value & "')"
                            Dim cmd = New MySqlCommand(qs, conn)
                            cmd.ExecuteNonQuery()

                            Dim subtotal_beli As Decimal = 0
                            Dim qty_out As Decimal = 0
                            qty_out = DataGridView1.Rows(i).Cells(3).Value
                            Dim hb As Decimal = 0
                            hb = DataGridView1.Rows(i).Cells(7).Value
                            subtotal_beli = hb * qty_out

                            Dim qsx As String = "INSERT INTO DSTOCKOUT (ID_BRG, ID_STOCKOUT, QTY, N_BAIK, N_RUSAK, HARGA_BELI, SUBTOTAL) VALUES ('" & DataGridView1.Rows(i).Cells(0).Value & "','" & id_stockout & "','" & DataGridView1.Rows(i).Cells(3).Value & "','" & DataGridView1.Rows(i).Cells(3).Value & "',0 ,'" & DataGridView1.Rows(i).Cells(7).Value & "','" & subtotal_beli & "')"
                            Dim cmdx = New MySqlCommand(qsx, conn)
                            cmdx.ExecuteNonQuery()

                            Dim stokLama As Decimal = DataGridView1.Rows(i).Cells(8).Value
                            Dim stokBaru As Decimal = DataGridView1.Rows(i).Cells(3).Value
                            stokBaru = stokLama - stokBaru
                            Dim qsy As String = "UPDATE barang SET stok = '" & stokBaru & "' WHERE id_brg = '" & DataGridView1.Rows(i).Cells(0).Value & "'"
                            Dim cmdy = New MySqlCommand(qsy, conn)
                            cmdy.ExecuteNonQuery()
                        Next
                        trans.Commit()
                        MessageBox.Show("Data transaksi penjualan berhasil dilakukan!")
                    Catch ex As Exception
                        trans.Rollback()
                        MessageBox.Show("Data transaksi penjualan gagal dilakukan! " + ex.ToString)
                    End Try
                Else
                    MsgBox("Anda belum membayar! ")
                End If
            Else
                MsgBox("Id kosong!")
            End If
            trans.Dispose()
            conn.Clone()
        Else
            MsgBox("Harap mengisi barang!")
        End If
    End Sub

    Function NoStockout()
        Dim temp As Integer = 0
        Dim idx As String = ""
        Try
            conn = Form1.koneksi()
            Dim str As String = ""
            str = "select count(*) 'no' from hstockout"

            Dim cmd = New MySqlCommand(str, conn)
            DR = cmd.ExecuteReader

            If DR.HasRows Then
                While DR.Read()
                    temp = DR.Item("no") + 1
                End While
            Else
                temp = 1
            End If

            idx = "stockout" + temp.ToString

            DR.Close()
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
            MessageBox.Show("Indexing gagal dilakukan!")
        End Try
        Return idx
    End Function

    Dim id_stockout As String = ""
    Sub tambahHeaderStockout()
        id_stockout = NoStockout()
        If id_stockout <> "" Then
            Try
                usernameku = Form1.username
                conn = Form1.koneksi()
                Dim qs As String = "INSERT INTO HSTOCKOUT (ID_STOCKOUT, ID_KAR, TGL_PESAN, TGL_KIRIM, REFERENSI, TOTAL, TOTAL_ITEM, KETERANGAN, STATUS_STOK, STATUS) VALUES ('" & id_stockout & "', '" & usernameku & "', '" & Format(DateTimePickerTgl.Value, "yyyy-MM-dd") & "', '" & Format(DateTimePickerKirim.Value, "yyyy-MM-dd") & "', '" & TextBoxId.Text & "', '" & TextBoxTotal.Text & "', '" & TextBoxTItem.Text & "', '" & TextBoxKet.Text & "', 'dipesan', 1)"
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
        TextBoxSatuan.Text = ""
        TextBoxHarga.Text = "0"
        TextBoxDiskon.Text = "0"
        TextBoxPPN.Text = "0.1"
        tampilBarang()
    End Sub

    Function HitungTotalPenjualan()
        Try
            total = 0
            If DataGridView1.RowCount >= 2 Then
                For i As Integer = 0 To DataGridView1.RowCount - 2
                    Dim temp As Decimal = DataGridView1.Rows(i).Cells(6).Value
                    total = total + temp
                Next
            End If
            TextBoxTotal.Text = total
        Catch ex As Exception
            MsgBox("Hitung total penjualan bermasalah! " + ex.ToString)
        End Try
        Return total
    End Function

    Function HitungTotalDiskon()
        Dim totalDiskon As Decimal = 0
        Try
            If DataGridView1.RowCount >= 2 Then
                For i As Integer = 0 To DataGridView1.RowCount - 2
                    Dim diskon As Decimal = DataGridView1.Rows(i).Cells(4).Value
                    Dim harga As Decimal = DataGridView1.Rows(i).Cells(2).Value
                    Dim qty As Decimal = DataGridView1.Rows(i).Cells(3).Value
                    totalDiskon = totalDiskon + (harga * qty * diskon)
                Next
            End If
        Catch ex As Exception
            MsgBox("Hitung total diskon bermasalah! " + ex.ToString)
        End Try
        Return totalDiskon
    End Function

    Function HitungTotalPPN()
        Dim totalPPN As Decimal = 0
        Dim total As Decimal = 0
        Dim PPN As Decimal = 0
        Try
            PPN = Decimal.Parse(TextBoxPPN.Text)
            total = Decimal.Parse(TextBoxTotal.Text)
            totalPPN = total * PPN
        Catch ex As Exception
            MsgBox("Hitung total diskon bermasalah! " + ex.ToString)
        End Try
        Return totalPPN
    End Function

    Function HitungSisaBayar()
        Dim total As Decimal = 0
        total = Decimal.Parse(TextBoxTotal.Text)
        Dim dibayar As Decimal = 0
        dibayar = Decimal.Parse(TextBoxDibayar.Text)
        Dim sisa As Decimal = dibayar - total
        If sisa >= 0 Then
            TextBoxKembali.Text = sisa
        Else
            MsgBox("Uang pembayaran tidak cukup! ")
        End If
        Return sisa
    End Function

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Try
            If DataGridView1.Rows(e.RowIndex).Cells(9).Value = "Cancel" Then
                DataGridView1.Rows.RemoveAt(e.RowIndex)
            End If
            HitungTotalPenjualan()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles ButtonTambah.Click
        If ComboBoxBarang.Items.Count <= 0 Then
            MsgBox("Harap isi data barang!")
        Else
            tambahData()
            HitungTotalPenjualan()
            ClearDataTransaksi()
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs)
        tampilCustomer("")
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        tampilSampel()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        tampilBarang()
    End Sub

    Private Sub Penjualan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If ComboBoxSampel.Items.Count > 0 Then
            No()
            tampilCustomer("")
            tampilPetugas()
            tampilSampel()
            tampilBarang()
        Else
            MsgBox("sampel kosong!")
            Me.Close()
        End If
    End Sub

    Private Sub ComboBoxBarang_SelectedValueChanged(sender As Object, e As EventArgs) Handles ComboBoxBarang.SelectedValueChanged
        Dim temp() As String = ambilNamaBarang()
        HitungSubtotal()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        HitungSisaBayar()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles ButtonProses.Click
        If ComboBoxBarang.Items.Count <= 0 Then
            MsgBox("Harap isi data barang!")
        Else
            If DataGridView1.Rows.Count > 1 Then
                If ComboBoxCustomer.Items.Count > 0 Then
                    If TextBoxDibayar.Text = 0 Then
                        MsgBox("Anda belum membayar!")
                    Else
                        tambahDetailData()
                        ButtonClear.Enabled = False
                        ButtonCetak.Enabled = True
                        ButtonTambah.Enabled = False
                        ButtonProses.Enabled = False
                    End If
                Else
                    MsgBox("Anda belum memasukkan customer! Harap pilih nomer sampel yang sesuai!")
                End If
            Else
                MsgBox("Harap tambahkan data barang! ")
            End If
        End If
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles ButtonClear.Click
        isClear()
    End Sub


    Sub isClear()
        TextBoxPenerima.Text = ""
        TextBoxAlamat.Text = ""
        TextBoxTelp.Text = ""
        TextBoxKet.Text = ""
        TextBoxCariSampel.Text = ""

        TextBoxCariBarang.Text = ""
        TextBoxQty.Text = 0
        TextBoxTotalStok.Text = 0
        TextBoxHarga.Text = 0
        TextBoxSatuan.Text = ""
        TextBoxDiskon.Text = 0

        TextBoxTotal.Text = 0
        TextBoxDibayar.Text = 0
        TextBoxKembali.Text = 0
        TextBoxPPN.Text = 0.1
        tampilBarang()
        tampilPetugas()
        tampilSampel()
        tampilCustomer("")
    End Sub

    Sub isLoad()
        No()
        tampilBarang()
        tampilCustomer("")
        tampilPetugas()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        isClear()
        No()
        ButtonClear.Enabled = True
        ButtonTambah.Enabled = True
        ButtonProses.Enabled = True
        ButtonCetak.Enabled = False
        isLoad()
        DataGridView1.Rows.Clear()
    End Sub

    Private Sub ComboBoxSampel_SelectedValueChanged(sender As Object, e As EventArgs) Handles ComboBoxSampel.SelectedValueChanged
        If ComboBoxSampel.Items.Count > 0 Then
            tampilCustomer(ComboBoxSampel.SelectedValue.ToString)
            tampilBarang()
        Else
            MsgBox("sampel kosong!")
            Me.Dispose()
        End If
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        Dim brg As New barang
        brg.ShowDialog()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ButtonCetak.Click
        Dim nota As New Preview
        nota.printWhat = "penjualan"
        nota.no = "1"
        nota.kepada = "customer"
        Dim idx As String = TextBoxId.Text
        nota.id = idx
        nota.ShowDialog()

        Dim nota2 As New Preview
        nota2.printWhat = "penjualan"
        nota2.no = "2"
        nota2.kepada = "staf gudang"
        nota2.id = idx
        nota2.ShowDialog()
        'Dim nota2 As New Preview
        'nota2.printWhat = "persediaan_keluar"
        'Dim idy As String = id_stockout
        'nota2.id = idy
        'nota2.ShowDialog()
    End Sub

    Private Sub TextBoxDibayar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxDibayar.KeyPress
        Dim allowedChars As String = "0123456789."
        If allowedChars.IndexOf(e.KeyChar) = -1 Then
            ' Invalid Character
            e.Handled = True
        End If
    End Sub

    Private Sub TextBoxQty_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxQty.KeyPress
        Dim allowedChars As String = "0123456789."
        If allowedChars.IndexOf(e.KeyChar) = -1 Then
            ' Invalid Character
            e.Handled = True
        End If
    End Sub
End Class