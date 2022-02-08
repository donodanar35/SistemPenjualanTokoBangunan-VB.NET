Imports MySql.Data.MySqlClient
Public Class barang
    Public conn As MySqlConnection
    Public cmd As MySqlCommand
    Public da As MySqlDataAdapter
    Public dt As New DataTable("barang")
    Public ds As New DataSet
    Public DR As MySqlDataReader
    Public id As String



    Function No()
        Dim temp As Integer
        Try
            conn = Form1.koneksi()
            Dim str As String
            str = "select count(*) 'no' from barang"
            Dim cmd = New MySqlCommand(str, conn)
            DR = cmd.ExecuteReader

            If DR.HasRows Then
                While DR.Read()
                    temp = DR.Item("no") + 1
                End While
            Else
                temp = 1
            End If
            DR.Close()
            conn.Close()
        Catch ex As Exception
            MessageBox.Show("Indexing gagal dilakukan!")
        End Try
        Return temp
    End Function

    Sub tampilKategori()
        Try
            conn = Form1.koneksi()
            Dim qs As String = "Select id_kat, nama_kat From KATEGORI WHERE STATUS = 1"
            da = New MySqlDataAdapter(qs, conn)
            Dim dtKategori As New DataTable("kategori")
            da.Fill(dtKategori)

            ComboBoxKategori.DataSource = dtKategori
            ComboBoxKategori.DisplayMember = "nama_kat"
            ComboBoxKategori.ValueMember = "id_kat"
            conn.Close()
        Catch ex As Exception
            MsgBox("Tampilan kategori bermasalah! ")
        End Try
    End Sub

    Sub tampilSatuan()
        Try
            conn = Form1.koneksi()
            Dim qs As String = "SELECT id_satuan, nama_satuan From SATUAN WHERE STATUS = 1"
            da = New MySqlDataAdapter(qs, conn)
            Dim dtSatuan As New DataTable("satuan")
            da.Fill(dtSatuan)

            ComboBoxSatuan.DataSource = dtSatuan
            ComboBoxSatuan.DisplayMember = "nama_satuan"
            ComboBoxSatuan.ValueMember = "id_satuan"
            conn.Close()
        Catch ex As Exception
            MsgBox("Tampilan satuan bermasalah! ")
        End Try
    End Sub

    Sub tampilBarang()
        DataGridView1.Rows.Clear()
        Dim qs As String = "Select b.id_brg 'ID', k.nama_kat 'Kategori', b.nama_brg 'Barang', b.harga_beli 'Harga Beli', b.harga_jual 'Harga Jual', b.diskon 'Diskon', b.min_qty 'Penjualan Minimal', b.ppn 'PPN', b.sampel 'Sampel', b.stok 'Stok', s.nama_satuan 'Satuan', b.merk_brg 'Merek', b.bobot_brg 'Bobot', b.ket_brg 'Keterangan' From BARANG b, SATUAN s, KATEGORI k WHERE b.status = 1 AND s.ID_SATUAN = b.ID_SATUAN AND k.id_kat = b.id_kat ORDER BY ID"

        Dim berdasarkan As String = "nama"
        If RadioButton_Id.Checked Then
            berdasarkan = "id"
        ElseIf RadioButton_Nama.Checked Then
            berdasarkan = "nama"
        ElseIf RadioButton_kategori.Checked Then
            berdasarkan = "kategori"
        ElseIf RadioButton_Merk.Checked Then
            berdasarkan = "merk"
        ElseIf RadioButton_Ket.Checked Then
            berdasarkan = "keterangan"
        End If

        If berdasarkan = "id" Then
            qs = "Select b.id_brg 'ID', k.nama_kat 'Kategori', b.nama_brg 'Barang', b.harga_beli 'Harga Beli', b.harga_jual 'Harga Jual', b.diskon 'Diskon', b.min_qty 'Penjualan Minimal', b.ppn 'PPN', b.sampel 'Sampel', b.stok 'Stok', s.nama_satuan 'Satuan', b.merk_brg 'Merek', b.bobot_brg 'Bobot', b.ket_brg 'Keterangan' From BARANG b, SATUAN s, KATEGORI k WHERE b.status = 1 AND s.ID_SATUAN = b.ID_SATUAN AND k.id_kat = b.id_kat AND b.id_brg like '%" & TextBoxCari.Text & "%' ORDER BY Kategori"
        ElseIf berdasarkan = "nama" Then
            qs = "Select b.id_brg 'ID', k.nama_kat 'Kategori', b.nama_brg 'Barang', b.harga_beli 'Harga Beli', b.harga_jual 'Harga Jual', b.diskon 'Diskon', b.min_qty 'Penjualan Minimal', b.ppn 'PPN', b.sampel 'Sampel', b.stok 'Stok', s.nama_satuan 'Satuan', b.merk_brg 'Merek', b.bobot_brg 'Bobot', b.ket_brg 'Keterangan' From BARANG b, SATUAN s, KATEGORI k WHERE b.status = 1 AND s.ID_SATUAN = b.ID_SATUAN AND k.id_kat = b.id_kat AND b.nama_brg like '%" & TextBoxCari.Text & "%' ORDER BY Kategori"
        ElseIf berdasarkan = "kategori" Then
            qs = "Select b.id_brg 'ID', k.nama_kat 'Kategori', b.nama_brg 'Barang', b.harga_beli 'Harga Beli', b.harga_jual 'Harga Jual', b.diskon 'Diskon', b.min_qty 'Penjualan Minimal', b.ppn 'PPN', b.sampel 'Sampel', b.stok 'Stok', s.nama_satuan 'Satuan', b.merk_brg 'Merek', b.bobot_brg 'Bobot', b.ket_brg 'Keterangan' From BARANG b, SATUAN s, KATEGORI k WHERE b.status = 1 AND s.ID_SATUAN = b.ID_SATUAN AND k.id_kat = b.id_kat AND k.nama_kat like '%" & TextBoxCari.Text & "%' ORDER BY Kategori"
        ElseIf berdasarkan = "merk" Then
            qs = "Select b.id_brg 'ID', k.nama_kat 'Kategori', b.nama_brg 'Barang', b.harga_beli 'Harga Beli', b.harga_jual 'Harga Jual', b.diskon 'Diskon', b.min_qty 'Penjualan Minimal', b.ppn 'PPN', b.sampel 'Sampel', b.stok 'Stok', s.nama_satuan 'Satuan', b.merk_brg 'Merek', b.bobot_brg 'Bobot', b.ket_brg 'Keterangan' From BARANG b, SATUAN s, KATEGORI k WHERE b.status = 1 AND s.ID_SATUAN = b.ID_SATUAN AND k.id_kat = b.id_kat AND b.merk_brg like '%" & TextBoxCari.Text & "%' ORDER BY Kategori"
        ElseIf berdasarkan = "keterangan" Then
            qs = "Select b.id_brg 'ID', k.nama_kat 'Kategori', b.nama_brg 'Barang', b.harga_beli 'Harga Beli', b.harga_jual 'Harga Jual', b.diskon 'Diskon', b.min_qty 'Penjualan Minimal', b.ppn 'PPN', b.sampel 'Sampel', b.stok 'Stok', s.nama_satuan 'Satuan', b.merk_brg 'Merek', b.bobot_brg 'Bobot', b.ket_brg 'Keterangan' From BARANG b, SATUAN s, KATEGORI k WHERE b.status = 1 AND s.ID_SATUAN = b.ID_SATUAN AND k.id_kat = b.id_kat AND b.ket_brg like '%" & TextBoxCari.Text & "%' ORDER BY Kategori"
        Else
            qs = "Select b.id_brg 'ID', k.nama_kat 'Kategori', b.nama_brg 'Barang', b.harga_beli 'Harga Beli', b.harga_jual 'Harga Jual', b.diskon 'Diskon', b.min_qty 'Penjualan Minimal', b.ppn 'PPN', b.sampel 'Sampel', b.stok 'Stok', s.nama_satuan 'Satuan', b.merk_brg 'Merek', b.bobot_brg 'Bobot', b.ket_brg 'Keterangan' From BARANG b, SATUAN s, KATEGORI k WHERE b.status = 1 AND s.ID_SATUAN = b.ID_SATUAN AND k.id_kat = b.id_kat AND b.id_brg like '%" & TextBoxCari.Text & "%' ORDER BY Kategori"
        End If

        ds.Clear()
        DataGridView1.Rows.Clear()
        Dim temp As String = ""
        Try
            Dim id As String = ""
            Dim kategori As String = ""
            Dim barang As String = ""
            Dim hb As Decimal = 0
            Dim hj As Decimal = 0
            Dim diskon As Decimal = 0
            Dim min_qty As Decimal = 0
            Dim ppn As Decimal = 0
            Dim sampel As String = ""
            Dim stok As Integer = 0
            Dim satuan As String = ""
            Dim merek As String = ""
            Dim bobot As Integer = 0
            Dim ket As String = ""

            conn = Form1.koneksi()
            Dim cmd = New MySqlCommand(qs, conn)
            Dim DRX As MySqlDataReader
            DRX = cmd.ExecuteReader

            If DRX.HasRows Then
                While DRX.Read()
                    id = DRX.Item("ID")
                    kategori = DRX.Item("Kategori")
                    barang = DRX.Item("Barang")
                    hb = DRX.Item("Harga Beli")
                    hj = DRX.Item("Harga Jual")
                    diskon = DRX.Item("Diskon")
                    min_qty = DRX.Item("Penjualan Minimal")
                    ppn = DRX.Item("PPN")
                    sampel = DRX.Item("Sampel")
                    stok = DRX.Item("Stok")
                    satuan = DRX.Item("Satuan")
                    merek = DRX.Item("Merek")
                    bobot = DRX.Item("Bobot")
                    ket = DRX.Item("Keterangan")
                    DataGridView1.Rows.Insert(DataGridView1.NewRowIndex, id, kategori, barang, hb, hj, diskon, min_qty, ppn, sampel, stok, satuan, merek, bobot, ket)
                End While
            Else
                MsgBox("Data tidak tersedia!")
            End If
            DRX.Close()
            conn.Close()
        Catch ex As Exception
            MsgBox("Tampilan barang bermasalah! " + ex.ToString)
        End Try
    End Sub

    Sub tambahBarang()
        Dim indeks As Integer = No()
        If TextBoxNama.Text <> "" Then
            If TextBoxSampel.Text <> "" And TextBoxStok.Text <> "" Then
                Try
                    conn = Form1.koneksi()
                    Dim qs As String = "INSERT INTO BARANG (PPN, HARGA_BELI, HARGA_JUAL, ID_BRG, ID_KAT, NAMA_BRG, SAMPEL, STOK, ID_SATUAN, MERK_BRG, BOBOT_BRG, KET_BRG, STATUS) VALUES (0.1, 0, 0, 'brg" & indeks & "', '" & ComboBoxKategori.SelectedValue.ToString & "', '" & TextBoxNama.Text & "', '" & TextBoxSampel.Text & "', '" & TextBoxStok.Text & "', '" & ComboBoxSatuan.SelectedValue.ToString & "', '" & TextBoxMerk.Text & "','" & TextBoxBobot.Text & "','" & TextBoxKet.Text & "', '1');"
                    cmd = New MySqlCommand(qs, conn)
                    cmd.ExecuteNonQuery()
                    conn.Close()
                    MsgBox("Tambah data barang berhasil dilakukan!")
                Catch ex As Exception
                    MsgBox("Tambah data barang gagal dilakukan! " + ex.ToString)
                End Try
            Else
                MsgBox("Sampel dan stok barang belum diisi!")
            End If
        Else
            MsgBox("Nama barang belum dimasukkan!")
        End If
    End Sub

    Sub ubahBarang()
        If TextBoxNama.Text <> "" Then
            Try
                conn = Form1.koneksi()
                Dim qs As String = "update barang set NAMA_BRG ='" & TextBoxNama.Text & "', SAMPEL ='" & TextBoxSampel.Text & "', STOK = '" & TextBoxStok.Text & "', ID_SATUAN = '" & ComboBoxSatuan.SelectedValue.ToString & "', ID_KAT ='" & ComboBoxKategori.SelectedValue.ToString & "',MERK_BRG ='" & TextBoxMerk.Text & "',BOBOT_BRG ='" & TextBoxBobot.Text & "', KET_BRG ='" & TextBoxKet.Text & "' WHERE ID_BRG = '" & TextBoxId.Text & "'"
                cmd = New MySqlCommand(qs, conn)
                cmd.ExecuteNonQuery()
                conn.Close()
                MsgBox("Edit data barang berhasil dilakukan!")
            Catch ex As Exception
                MsgBox("Edit data barang gagal dilakukan!")
            End Try
        Else
            MsgBox("Nama barang wajib dimasukkan!")
        End If
    End Sub

    Sub hapusBarang()
        Try
            conn = Form1.koneksi()
            Dim qs As String = "update barang set STATUS=0 WHERE ID_BRG = '" & TextBoxId.Text & "'"
            cmd = New MySqlCommand(qs, conn)
            cmd.ExecuteNonQuery()
            conn.Close()
            MsgBox("Hapus data barang berhasil dilakukan!")
        Catch ex As Exception
            MsgBox("Hapus data barang gagal dilakukan!")
        End Try
    End Sub


    Private Sub TextBox3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxStok.KeyPress
        Dim allowedChars As String = "0123456789."
        If allowedChars.IndexOf(e.KeyChar) = -1 Then
            ' Invalid Character
            e.Handled = True
        End If
    End Sub

    Public jabatanku As String = TokoMaterial.jabatan

    Sub formatTampilanGrid()
        For i As Integer = 0 To DataGridView1.Rows.Count - 1
            If i Mod 2 = 0 Then
                DataGridView1.Rows(i).Cells(0).Style.BackColor = Color.White
                DataGridView1.Rows(i).Cells(1).Style.BackColor = Color.White
                DataGridView1.Rows(i).Cells(2).Style.BackColor = Color.White
                DataGridView1.Rows(i).Cells(3).Style.BackColor = Color.White
                DataGridView1.Rows(i).Cells(4).Style.BackColor = Color.White
                DataGridView1.Rows(i).Cells(5).Style.BackColor = Color.White
                DataGridView1.Rows(i).Cells(6).Style.BackColor = Color.White
                DataGridView1.Rows(i).Cells(7).Style.BackColor = Color.White
                DataGridView1.Rows(i).Cells(8).Style.BackColor = Color.White
                DataGridView1.Rows(i).Cells(9).Style.BackColor = Color.White
                DataGridView1.Rows(i).Cells(10).Style.BackColor = Color.White
                DataGridView1.Rows(i).Cells(11).Style.BackColor = Color.White
                DataGridView1.Rows(i).Cells(12).Style.BackColor = Color.White
                DataGridView1.Rows(i).Cells(13).Style.BackColor = Color.White
            Else
                DataGridView1.Rows(i).Cells(0).Style.BackColor = Color.GreenYellow
                DataGridView1.Rows(i).Cells(1).Style.BackColor = Color.GreenYellow
                DataGridView1.Rows(i).Cells(2).Style.BackColor = Color.GreenYellow
                DataGridView1.Rows(i).Cells(3).Style.BackColor = Color.GreenYellow
                DataGridView1.Rows(i).Cells(4).Style.BackColor = Color.GreenYellow
                DataGridView1.Rows(i).Cells(5).Style.BackColor = Color.GreenYellow
                DataGridView1.Rows(i).Cells(6).Style.BackColor = Color.GreenYellow
                DataGridView1.Rows(i).Cells(7).Style.BackColor = Color.GreenYellow
                DataGridView1.Rows(i).Cells(8).Style.BackColor = Color.GreenYellow
                DataGridView1.Rows(i).Cells(9).Style.BackColor = Color.GreenYellow
                DataGridView1.Rows(i).Cells(10).Style.BackColor = Color.GreenYellow
                DataGridView1.Rows(i).Cells(11).Style.BackColor = Color.GreenYellow
                DataGridView1.Rows(i).Cells(12).Style.BackColor = Color.GreenYellow
                DataGridView1.Rows(i).Cells(13).Style.BackColor = Color.GreenYellow
            End If
        Next
    End Sub

    Sub user_acces()
        If jabatanku = "kasir" Or jabatanku = "staf gudang" Then
            ButtonTambah.Visible = False
            ButtonHapus.Visible = False
            ButtonUbah.Visible = False
        End If
    End Sub

    Private Sub barang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        user_acces()
        tampilBarang()
        tampilKategori()
        tampilSatuan()
        formatTampilanGrid()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles ButtonTambah.Click
        If ComboBoxKategori.Items.Count <= 0 Or ComboBoxSatuan.Items.Count <= 0 Then
            MsgBox("Harap isi data barang!")
        Else
            tambahBarang()
            tampilBarang()
            clearData()
            formatTampilanGrid()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ButtonUbah.Click
        ubahBarang()
        tampilBarang()
        formatTampilanGrid()
    End Sub

    Private Sub Hapus_Click(sender As Object, e As EventArgs) Handles ButtonHapus.Click
        hapusBarang()
        tampilBarang()
        formatTampilanGrid()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles ButtonCari.Click
        tampilBarang()
        formatTampilanGrid()
    End Sub

    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        Try
            TextBoxId.Text = DataGridView1.Rows(e.RowIndex).Cells(0).Value.ToString
            TextBoxNama.Text = DataGridView1.Rows(e.RowIndex).Cells(2).Value.ToString
            TextBoxSampel.Text = DataGridView1.Rows(e.RowIndex).Cells(8).Value.ToString
            TextBoxStok.Text = DataGridView1.Rows(e.RowIndex).Cells(9).Value.ToString
            TextBoxMerk.Text = DataGridView1.Rows(e.RowIndex).Cells(11).Value.ToString
            TextBoxBobot.Text = DataGridView1.Rows(e.RowIndex).Cells(12).Value.ToString
            TextBoxKet.Text = DataGridView1.Rows(e.RowIndex).Cells(13).Value.ToString
        Catch ex As Exception
        End Try
    End Sub

    Private Sub TextBoxHarga_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxSampel.KeyPress
        Dim allowedChars As String = "0123456789."
        If allowedChars.IndexOf(e.KeyChar) = -1 Then
            ' Invalid Character
            e.Handled = True
        End If
    End Sub

    Private Sub TextBoxBobot_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxBobot.KeyPress
        Dim allowedChars As String = "0123456789."
        If allowedChars.IndexOf(e.KeyChar) = -1 Then
            ' Invalid Character
            e.Handled = True
        End If
    End Sub

    Sub tampilId()
        Dim nomer As Integer = No()
        id = "brg" + nomer.ToString
        TextBoxId.Text = id
    End Sub

    Sub clearData()
        TextBoxBobot.Text = ""
        TextBoxSampel.Text = ""
        TextBoxCari.Text = ""
        TextBoxId.Text = ""
        TextBoxNama.Text = ""
        TextBoxKet.Text = ""
        TextBoxMerk.Text = ""
        TextBoxStok.Text = ""
        tampilBarang()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles ButtonRefresh.Click
        tampilBarang()
        tampilId()
        formatTampilanGrid()
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles ButtonClear.Click
        clearData()
        formatTampilanGrid()
    End Sub
End Class