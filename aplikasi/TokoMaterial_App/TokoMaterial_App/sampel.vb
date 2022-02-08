Imports MySql.Data.MySqlClient
Public Class sampel
    Public usernameku As String
    Public namapetugas As String
    Public id_sampel As String
    Public conn As MySqlConnection
    Public cmd As MySqlCommand
    Public da As MySqlDataAdapter
    Public dt As New DataTable("barang")
    Public ds As New DataSet
    Public DR As MySqlDataReader

    Public id_stok As String = ""
    Function No()
        Dim temp As Integer
        Try
            conn = Form1.koneksi()
            Dim str As String
            str = "select count(*) 'no' from hsampel"
            Dim cmd = New MySqlCommand(str, conn)
            DR = cmd.ExecuteReader

            If DR.HasRows Then
                While DR.Read()
                    temp = DR.Item("no") + 1
                End While
            Else
                temp = 1
            End If
            cmd.Dispose()
            DR.Close()

            Dim tempx As Integer = 0
            If DR.HasRows Then
                While DR.Read()
                    tempx = DR.Item("no") + 1
                End While
            Else
                tempx = 1
            End If

            id_stok = "stok" + tempx.ToString
            id_sampel = "sam" + temp.ToString
            TextBoxId.Text = id_sampel
            cmd.Dispose()
            DR.Close()
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
            MessageBox.Show("Indexing gagal dilakukan!")
        End Try
        Return temp
    End Function

    Sub tambahHeaderSampel()
        If TextBoxId.Text <> "" Then
            Try
                usernameku = Form1.username
                conn = Form1.koneksi()

                Dim total As Decimal = 0
                For i As Integer = 0 To DataGridView1.Rows.Count - 1
                    Dim temp As Decimal = DataGridView1.Rows(i).Cells(5).Value
                    total = total + temp
                Next

                Dim qs As String = "INSERT INTO HSAMPEL (NAMA_PENERIMA, ALAMAT_PENERIMA, TELP_PENERIMA, ID_SAM, ID_KAR, ID_CUS, TGL_SAM, TGL_KIRIM, KET_SAM, TOTAL, TOTAL_ITEM, STATUS) VALUES ('" & TextBoxPenerima.Text & "','" & TextBoxAlamat.Text & "','" & TextBoxTelp.Text & "','" & TextBoxId.Text & "','" & usernameku & "','" & ComboBoxCustomer.SelectedValue.ToString & "','" & Format(DateTimePicker1.Value, "yyyy-MM-dd") & "','" & Format(DateTimePickerKirim.Value, "yyyy-MM-dd") & "','" & TextBoxKet.Text & "', '" & total & "', '" & TextBoxItem.Text & "',1)"
                cmd = New MySqlCommand(qs, conn)
                cmd.ExecuteNonQuery()
                cmd.Dispose()
                conn.Close()
            Catch ex As Exception
                MsgBox("Header transaksi sampel error! " + ex.ToString)
            End Try
        Else
            MsgBox("Id_sampel kosong!")
        End If
    End Sub

    Sub tambahDetailSampel()
        tambahHeaderSampel()
        tambahHeaderStockout()
        If TextBoxId.Text <> "" Then
            conn = Form1.koneksi()
            Dim trans As MySqlTransaction = conn.BeginTransaction()
            Try
                For i As Integer = 0 To DataGridView1.RowCount - 2
                    Dim qs As String = "INSERT INTO DSAMPEL (ID_SAM, ID_BRG, QTY_SAM) VALUES ('" & id_sampel & "','" & DataGridView1.Rows(i).Cells(0).Value & "','" & DataGridView1.Rows(i).Cells(2).Value & "')"
                    Dim cmd = New MySqlCommand(qs, conn)
                    cmd.ExecuteNonQuery()

                    Dim qsx As String = "INSERT INTO DSTOCKOUT (ID_BRG, ID_STOCKOUT, QTY, N_BAIK, N_RUSAK, HARGA_BELI, SUBTOTAL) VALUES ('" & DataGridView1.Rows(i).Cells(0).Value & "','" & id_stockout & "','" & DataGridView1.Rows(i).Cells(2).Value & "','" & DataGridView1.Rows(i).Cells(2).Value & "',0 ,'" & DataGridView1.Rows(i).Cells(4).Value & "','" & DataGridView1.Rows(i).Cells(5).Value & "')"
                    Dim cmdx = New MySqlCommand(qsx, conn)
                    cmdx.ExecuteNonQuery()

                    Dim stokLama As Decimal = DataGridView1.Rows(i).Cells(6).Value
                    Dim stokBaru As Decimal = DataGridView1.Rows(i).Cells(2).Value
                    stokBaru = stokLama - stokBaru
                    Dim qsy As String = "UPDATE barang SET stok = '" & stokBaru & "' WHERE id_brg = '" & DataGridView1.Rows(i).Cells(0).Value & "'"
                    Dim cmdy = New MySqlCommand(qsy, conn)
                    cmdy.ExecuteNonQuery()
                Next
                trans.Commit()
                cmd.Dispose()
                MessageBox.Show("Data transaksi sampel berhasil dilakukan!")
            Catch ex As Exception
                trans.Rollback()
                MessageBox.Show("Data transaksi sampel gagal dilakukan!" + ex.ToString)
            End Try
            conn.Close()
        Else
            MsgBox("Id_sampel kosong!")
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

                Dim total As Decimal = 0
                For i As Integer = 0 To DataGridView1.Rows.Count - 1
                    Dim temp As Decimal = DataGridView1.Rows(i).Cells(5).Value
                    total = total + temp
                Next

                Dim qs As String = "INSERT INTO HSTOCKOUT (ID_STOCKOUT, ID_KAR, TGL_PESAN, TGL_KIRIM, REFERENSI, TOTAL, TOTAL_ITEM, KETERANGAN, STATUS_STOK, STATUS) VALUES ('" & id_stockout & "', '" & usernameku & "', '" & Format(DateTimePicker1.Value, "yyyy-MM-dd") & "', '" & Format(DateTimePickerKirim.Value, "yyyy-MM-dd") & "', '" & TextBoxId.Text & "', '" & total & "', '" & TextBoxItem.Text & "', '" & TextBoxKet.Text & "', 'dipesan', 1)"
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

    Sub tampilCustomer()
        ComboBoxCustomer.DataSource = Nothing
        ds.Clear()
        Try
            conn = Form1.koneksi()
            Dim qs As String = "Select id_cus, nama_cus From CUSTOMER WHERE STATUS = 1 AND nama_cus like '%" & TextBoxCariCustomer.Text & "%'"
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
            MsgBox("Tampilan petugas bermasalah! ")
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
            'ComboBoxBarang.Items.Add(dtBarang.Rows("nama_brg"))
            conn.Close()
        Catch ex As Exception
            MsgBox("Tampilan barang bermasalah! ")
        End Try
    End Sub

    Dim barang As String = ""
    Dim hb As Decimal = 0
    Dim subtotal As Decimal = 0
    Dim stok As Decimal = 0
    Function ambilBarang()
        usernameku = Form1.username
        ds.Clear()
        Dim temp() As String = {"", 0, 0, "", 0}
        Try
            conn = Form1.koneksi()
            Dim qs As String = "SELECT b.stok 'stok', b.nama_brg 'barang',  b.harga_beli 'hb', b.sampel 'sampel', s.nama_satuan 'satuan' From BARANG b, SATUAN s WHERE b.id_satuan = s.id_satuan AND b.id_brg like '" & ComboBoxBarang.SelectedValue.ToString & "'"
            Dim cmd = New MySqlCommand(qs, conn)
            Dim DRX As MySqlDataReader
            DRX = cmd.ExecuteReader

            If DRX.HasRows Then
                While DRX.Read()
                    temp(0) = DRX.Item("barang")
                    temp(1) = DRX.Item("hb")
                    temp(2) = DRX.Item("sampel")
                    temp(3) = DRX.Item("satuan")
                    temp(4) = DRX.Item("stok")
                    TextBoxQty.Text = DRX.Item("sampel")
                End While
            End If

            DR.Close()
            conn.Close()
        Catch ex As Exception
            MsgBox("Fungsi ambilBarang bermasalah! " + ex.ToString)
        End Try
        Return temp
    End Function

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
            MsgBox("Fungsi ambilStokBarang bermasalah! ")
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
            MsgBox("CekStokBarang bermasalah!")
        End Try
        Return isCekStok
    End Function

    Sub tambahDataSampel()
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
            TextBoxItem.Text = DataGridView1.Rows.Count
            Dim sampel As Decimal = Decimal.Parse(TextBoxQty.Text)
            subtotal = hb * sampel
            If isBrg <> 1 Then
                DataGridView1.Rows.Insert(DataGridView1.NewRowIndex, ComboBoxBarang.SelectedValue.ToString, barang, TextBoxQty.Text, TextBoxSatuan.Text, hb, subtotal, stok, "Cancel")
            End If
            subtotal = 0
            hb = 0
            barang = ""
        Else
            MsgBox("Stok barang habis!")
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles ButtonTambah.Click
        If ComboBoxBarang.Items.Count <= 0 Then
            tambahDataSampel()
        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Try
            If DataGridView1.Rows(e.RowIndex).Cells(7).Value = "Cancel" Then
                DataGridView1.Rows.RemoveAt(e.RowIndex)
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub TextBoxQty_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxQty.KeyPress
        Dim allowedChars As String = "0123456789."
        If allowedChars.IndexOf(e.KeyChar) = -1 Then
            ' Invalid Character
            e.Handled = True
        End If
    End Sub

    Sub isClear()
        No()
        TextBoxAlamat.Text = ""
        TextBoxCaribarang.Text = ""
        TextBoxCariCustomer.Text = ""
        TextBoxKet.Text = ""
        TextBoxItem.Text = ""
        TextBoxPenerima.Text = ""
        TextBoxTelp.Text = ""
        TextBoxKet.Text = ""
        TextBoxQty.Text = 0
    End Sub

    Sub isLoad()
        No()
        tampilBarang()
        tampilCustomer()
        tampilPetugas()
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles ButtonClear.Click
        isClear()
        isLoad()
    End Sub

    Private Sub ButtonNew_Click(sender As Object, e As EventArgs) Handles ButtonNew.Click
        ButtonClear.Enabled = True
        ButtonProsess.Enabled = True
        ButtonTambah.Enabled = True
        ButtonCetak.Enabled = False
        isClear()
        isLoad()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ButtonCetak.Click
        Dim nota As New Preview
        nota.no = "1"
        nota.kepada = "customer"
        nota.id = TextBoxId.Text
        nota.printWhat = "sampel"
        nota.ShowDialog()

        Dim nota2 As New Preview
        nota2.no = "2"
        nota2.kepada = "staf gudang"
        nota2.id = TextBoxId.Text
        nota2.printWhat = "sampel"
        nota2.ShowDialog()
    End Sub

    Private Sub ComboBoxBarang_SelectedValueChanged(sender As Object, e As EventArgs) Handles ComboBoxBarang.SelectedValueChanged
        Dim temp() As String = ambilBarang()
        barang = temp(0)
        hb = temp(1)
        stok = temp(4)
        TextBoxQty.Text = temp(2)
        TextBoxSatuan.Text = temp(3)
    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        Dim brg As New barang
        brg.ShowDialog()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        tampilBarang()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        tampilCustomer()
    End Sub

    Private Sub ButtonProsess_Click(sender As Object, e As EventArgs) Handles ButtonProsess.Click
        If ComboBoxBarang.Items.Count <= 0 Then
            MsgBox("Harap isi data barang!")
        Else
            If DataGridView1.Rows.Count <= 1 Then
                MsgBox("Harap tambahkan data barang!")
            Else
                tambahDetailSampel()
                ButtonClear.Enabled = False
                ButtonProsess.Enabled = False
                ButtonTambah.Enabled = False
                ButtonCetak.Enabled = True
            End If
        End If
    End Sub

    Private Sub sampel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        No()
        tampilBarang()
        tampilCustomer()
        tampilPetugas()
    End Sub
End Class