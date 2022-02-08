Imports MySql.Data.MySqlClient

Public Class Transaksi_Penjualan
    Public usernameku As String
    Public namapetugas As String
    Public id As String
    Public conn As MySqlConnection
    Public cmd As MySqlCommand
    Public da As MySqlDataAdapter
    Public dt As New DataTable("barang")
    Public ds As New DataSet
    Public DR As MySqlDataReader
    Dim idx As String = ""
    Dim cetak As String = ""


    Sub tampilHJual()
        Dim cari As String = ""
        cari = TextBoxCari.Text
        Dim qs As String = "SELECT H.ID_JUAL 'ID', H.ID_SAM 'SAMPEL', K.NAMA_KAR 'PETUGAS', C.NAMA_CUS 'CUSTOMER', H.TGL_JUAL 'TGLPESAN', H.TGL_KIRIM 'TGLKIRIM', H.NAMA_PENERIMA 'PENERIMA', H.ALAMAT_PENERIMA 'ALAMAT', H.TELP_PENERIMA 'TELP', H.KET_JUAL 'KETERANGAN' FROM HJUAL H, KARYAWAN K, CUSTOMER C WHERE H.STATUS = 1 AND C.ID_CUS = H.ID_CUS AND H.ID_KAR = K.ID_KAR ORDER BY ID"

        If RadioButtonAlamat.Checked Then
            qs = "SELECT H.ID_JUAL 'ID', H.ID_SAM 'SAMPEL', K.NAMA_KAR 'PETUGAS', C.NAMA_CUS 'CUSTOMER', H.TGL_JUAL 'TGLPESAN', H.TGL_KIRIM 'TGLKIRIM', H.NAMA_PENERIMA 'PENERIMA', H.ALAMAT_PENERIMA 'ALAMAT', H.TELP_PENERIMA 'TELP', H.KET_JUAL 'KETERANGAN' FROM HJUAL H, KARYAWAN K, CUSTOMER C WHERE H.STATUS = 1 AND C.ID_CUS = H.ID_CUS AND H.ID_KAR = K.ID_KAR AND H.ALAMAT_PENERIMA like '%" & TextBoxCari.Text & "%' ORDER BY ID"
        ElseIf RadioButtonCustomer.Checked Then
            qs = "SELECT H.ID_JUAL 'ID', H.ID_SAM 'SAMPEL', K.NAMA_KAR 'PETUGAS', C.NAMA_CUS 'CUSTOMER', H.TGL_JUAL 'TGLPESAN', H.TGL_KIRIM 'TGLKIRIM', H.NAMA_PENERIMA 'PENERIMA', H.ALAMAT_PENERIMA 'ALAMAT', H.TELP_PENERIMA 'TELP', H.KET_JUAL 'KETERANGAN' FROM HJUAL H, KARYAWAN K, CUSTOMER C WHERE H.STATUS = 1 AND C.ID_CUS = H.ID_CUS AND H.ID_KAR = K.ID_KAR AND C.NAMA_CUS like '%" & TextBoxCari.Text & "%' ORDER BY ID"
        ElseIf RadioButtonID.Checked Then
            qs = "SELECT H.ID_JUAL 'ID', H.ID_SAM 'SAMPEL', K.NAMA_KAR 'PETUGAS', C.NAMA_CUS 'CUSTOMER', H.TGL_JUAL 'TGLPESAN', H.TGL_KIRIM 'TGLKIRIM', H.NAMA_PENERIMA 'PENERIMA', H.ALAMAT_PENERIMA 'ALAMAT', H.TELP_PENERIMA 'TELP', H.KET_JUAL 'KETERANGAN' FROM HJUAL H, KARYAWAN K, CUSTOMER C WHERE H.STATUS = 1 AND C.ID_CUS = H.ID_CUS AND H.ID_KAR = K.ID_KAR AND H.ID_JUAL like '%" & TextBoxCari.Text & "%' ORDER BY ID"
        ElseIf RadioButtonKeterangan.Checked Then
            qs = "SELECT H.ID_JUAL 'ID', H.ID_SAM 'SAMPEL', K.NAMA_KAR 'PETUGAS', C.NAMA_CUS 'CUSTOMER', H.TGL_JUAL 'TGLPESAN', H.TGL_KIRIM 'TGLKIRIM', H.NAMA_PENERIMA 'PENERIMA', H.ALAMAT_PENERIMA 'ALAMAT', H.TELP_PENERIMA 'TELP', H.KET_JUAL 'KETERANGAN' FROM HJUAL H, KARYAWAN K, CUSTOMER C WHERE H.STATUS = 1 AND C.ID_CUS = H.ID_CUS AND H.ID_KAR = K.ID_KAR AND H.KET_JUAL like '%" & TextBoxCari.Text & "%' ORDER BY ID"
        ElseIf RadioButtonPenerima.Checked Then
            qs = "SELECT H.ID_JUAL 'ID', H.ID_SAM 'SAMPEL', K.NAMA_KAR 'PETUGAS', C.NAMA_CUS 'CUSTOMER', H.TGL_JUAL 'TGLPESAN', H.TGL_KIRIM 'TGLKIRIM', H.NAMA_PENERIMA 'PENERIMA', H.ALAMAT_PENERIMA 'ALAMAT', H.TELP_PENERIMA 'TELP', H.KET_JUAL 'KETERANGAN' FROM HJUAL H, KARYAWAN K, CUSTOMER C WHERE H.STATUS = 1 AND C.ID_CUS = H.ID_CUS AND H.ID_KAR = K.ID_KAR AND H.NAMA_PENERIMA like '%" & TextBoxCari.Text & "%' ORDER BY ID"
        ElseIf RadioButtonPetugas.Checked Then
            qs = "SELECT H.ID_JUAL 'ID', H.ID_SAM 'SAMPEL', K.NAMA_KAR 'PETUGAS', C.NAMA_CUS 'CUSTOMER', H.TGL_JUAL 'TGLPESAN', H.TGL_KIRIM 'TGLKIRIM', H.NAMA_PENERIMA 'PENERIMA', H.ALAMAT_PENERIMA 'ALAMAT', H.TELP_PENERIMA 'TELP', H.KET_JUAL 'KETERANGAN' FROM HJUAL H, KARYAWAN K, CUSTOMER C WHERE H.STATUS = 1 AND C.ID_CUS = H.ID_CUS AND H.ID_KAR = K.ID_KAR AND K.NAMA_KAR like '%" & TextBoxCari.Text & "%' ORDER BY ID"
        ElseIf RadioButtonTelp.Checked Then
            qs = "SELECT H.ID_JUAL 'ID', H.ID_SAM 'SAMPEL', K.NAMA_KAR 'PETUGAS', C.NAMA_CUS 'CUSTOMER', H.TGL_JUAL 'TGLPESAN', H.TGL_KIRIM 'TGLKIRIM', H.NAMA_PENERIMA 'PENERIMA', H.ALAMAT_PENERIMA 'ALAMAT', H.TELP_PENERIMA 'TELP', H.KET_JUAL 'KETERANGAN' FROM HJUAL H, KARYAWAN K, CUSTOMER C WHERE H.STATUS = 1 AND C.ID_CUS = H.ID_CUS AND H.ID_KAR = K.ID_KAR AND H.TELP_PENERIMA like '%" & TextBoxCari.Text & "%' ORDER BY ID"
        ElseIf RadioButtonTglKirim.Checked Then
            qs = "SELECT H.ID_JUAL 'ID', H.ID_SAM 'SAMPEL', K.NAMA_KAR 'PETUGAS', C.NAMA_CUS 'CUSTOMER', H.TGL_JUAL 'TGLPESAN', H.TGL_KIRIM 'TGLKIRIM', H.NAMA_PENERIMA 'PENERIMA', H.ALAMAT_PENERIMA 'ALAMAT', H.TELP_PENERIMA 'TELP', H.KET_JUAL 'KETERANGAN' FROM HJUAL H, KARYAWAN K, CUSTOMER C WHERE H.STATUS = 1 AND C.ID_CUS = H.ID_CUS AND H.ID_KAR = K.ID_KAR AND H.TGL_KIRIM like '%" & Format(DateTimePickerKirim.Value, "yyyy-MM-dd") & "%' ORDER BY ID"
        ElseIf RadioButtonTglPesan.Checked Then
            qs = "SELECT H.ID_JUAL 'ID', H.ID_SAM 'SAMPEL', K.NAMA_KAR 'PETUGAS', C.NAMA_CUS 'CUSTOMER', H.TGL_JUAL 'TGLPESAN', H.TGL_KIRIM 'TGLKIRIM', H.NAMA_PENERIMA 'PENERIMA', H.ALAMAT_PENERIMA 'ALAMAT', H.TELP_PENERIMA 'TELP', H.KET_JUAL 'KETERANGAN' FROM HJUAL H, KARYAWAN K, CUSTOMER C WHERE H.STATUS = 1 AND C.ID_CUS = H.ID_CUS AND H.ID_KAR = K.ID_KAR AND H.TGL_JUAL like '%" & Format(DateTimePickerPesan.Value, "yyyy-MM-dd") & "%' ORDER BY ID"
        ElseIf RadioButtonSampel.Checked Then
            qs = "SELECT H.ID_JUAL 'ID', H.ID_SAM 'SAMPEL', K.NAMA_KAR 'PETUGAS', C.NAMA_CUS 'CUSTOMER', H.TGL_JUAL 'TGLPESAN', H.TGL_KIRIM 'TGLKIRIM', H.NAMA_PENERIMA 'PENERIMA', H.ALAMAT_PENERIMA 'ALAMAT', H.TELP_PENERIMA 'TELP', H.KET_JUAL 'KETERANGAN' FROM HJUAL H, KARYAWAN K, CUSTOMER C WHERE H.STATUS = 1 AND C.ID_CUS = H.ID_CUS AND H.ID_KAR = K.ID_KAR AND H.ID_SAM like '%" & TextBoxCari.Text & "%' ORDER BY ID"
        End If

        usernameku = Form1.username
        ds.Clear()
        DataGridView1.Rows.Clear()
        Dim temp As String = ""
        Try
            Dim id As String = ""
            Dim sampel As String = ""
            Dim petugas As String = ""
            Dim customer As String = ""
            Dim tglPesan As String = ""
            Dim tglKirim As String = ""
            Dim penerima As String = ""
            Dim alamat As String = ""
            Dim telp As String = ""
            Dim ket As String = ""

            conn = Form1.koneksi()
            Dim cmd = New MySqlCommand(qs, conn)
            Dim DRX As MySqlDataReader
            DRX = cmd.ExecuteReader

            If DRX.HasRows Then
                While DRX.Read()
                    idx = DRX.Item("ID")
                    sampel = DRX.Item("SAMPEL")
                    petugas = DRX.Item("PETUGAS")
                    customer = DRX.Item("CUSTOMER")
                    tglPesan = DRX.Item("TGLPESAN")
                    tglKirim = DRX.Item("TGLKIRIM")
                    penerima = DRX.Item("PENERIMA")
                    alamat = DRX.Item("ALAMAT")
                    telp = DRX.Item("TELP")
                    ket = DRX.Item("KETERANGAN")
                    DataGridView1.Rows.Insert(DataGridView1.NewRowIndex, idx, sampel, petugas, customer, tglPesan, tglKirim, penerima, alamat, telp, ket, "Detail")
                End While
            Else
                MsgBox("Data tidak tersedia!")
            End If
            DRX.Close()
            conn.Close()
        Catch ex As Exception
            MsgBox("Tampilan HSampel bermasalah! " + ex.ToString)
        End Try
    End Sub

    Sub tampilDJual()
        usernameku = Form1.username
        ds.Clear()
        DataGridView2.Rows.Clear()
        Dim temp As String = ""
        Try
            Dim barang As String = ""
            Dim satuan As String = ""
            Dim qty As String = ""
            Dim hj As Decimal = 0
            Dim ppn As Decimal = 0
            Dim diskon As Decimal = 0
            Dim subtotal As Decimal = 0

            conn = Form1.koneksi()
            Dim qs As String = "SELECT B.NAMA_BRG 'BARANG', S.NAMA_SATUAN 'SATUAN', D.QTY_JUAL 'QTY', D.HRG_JUAL 'HARGA_JUAL', D.PPN 'PPN', D.DISKOn 'DISKON', D.SUBTOTAL_JUAL 'SUBTOTAL' FROM SATUAN S, BARANG B, DJUAL D WHERE B.ID_BRG = D.ID_BRG And S.ID_SATUAN = B.ID_SATUAN AND D.ID_JUAL like '" & idx & "'"
            Dim cmd = New MySqlCommand(qs, conn)
            Dim DRX As MySqlDataReader
            DRX = cmd.ExecuteReader

            If DRX.HasRows Then
                While DRX.Read()
                    barang = DRX.Item("BARANG")
                    satuan = DRX.Item("SATUAN")
                    qty = DRX.Item("QTY")
                    hj = DRX.Item("HARGA_JUAL")
                    ppn = DRX.Item("PPN")
                    diskon = DRX.Item("DISKON")
                    subtotal = DRX.Item("SUBTOTAL")
                    DataGridView2.Rows.Insert(DataGridView2.NewRowIndex, barang, qty, satuan, hj, diskon, ppn, subtotal)
                End While
            Else
                MsgBox("Data tidak tersedia!")
            End If
            DRX.Close()
            conn.Close()
            idx = ""
        Catch ex As Exception
            MsgBox("Tampilan DSampel bermasalah! " + ex.ToString)
        End Try
    End Sub

    Sub HapusSampel()
        Try
            conn = Form1.koneksi()
            Dim qs As String = "UPDATE HJUAL SET status=0 WHERE ID_JUAL LIKE '" & cetak & "'"
            cmd = New MySqlCommand(qs, conn)
            cmd.ExecuteNonQuery()
            conn.Close()
            cetak = ""
            MsgBox("Data sampel " & cetak & " berhasil dilakukan!")
        Catch ex As Exception
            MsgBox("Hapus sampel bermasalah!")
        End Try
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Try
            If DataGridView1.Rows(e.RowIndex).Cells(10).Value = "Detail" Then
                idx = DataGridView1.Rows(e.RowIndex).Cells(0).Value
                tampilDJual()
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Hapus_Click(sender As Object, e As EventArgs) Handles Hapus.Click
        Dim result As Integer = MessageBox.Show("Anda yakin menghapus faktur jual " + cetak + "?", "Hapus Faktur Jual " + cetak, MessageBoxButtons.YesNoCancel)
        If result = DialogResult.Cancel Then
            MessageBox.Show("Status faktur jual " + cetak + " dibatalkan!")
        ElseIf result = DialogResult.No Then
            MessageBox.Show("Status faktur jual " + cetak + " dibatalkan!")
        ElseIf result = DialogResult.Yes Then
            HapusSampel()
            tampilHJual()
        End If
    End Sub

    Private Sub Transaksi_Sampel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tampilHJual()
    End Sub

    Private Sub ButtonCetak_Click(sender As Object, e As EventArgs) Handles ButtonCetak.Click
        Dim result As Integer = MessageBox.Show("Anda yakin mencetak faktur jual " + cetak + "?", "Cetak Faktur Jual " + cetak, MessageBoxButtons.YesNoCancel)
        If result = DialogResult.Cancel Then
            MessageBox.Show("Cetak faktur jual " + cetak + " dibatalkan!")
        ElseIf result = DialogResult.No Then
            MessageBox.Show("Cetak faktur jual " + cetak + " dibatalkan!")
        ElseIf result = DialogResult.Yes Then
            Dim nota As New Preview
            nota.id = cetak
            nota.no = "1"
            nota.kepada = "customer"
            nota.printWhat = "penjualan"
            nota.ShowDialog()

            Dim nota2 As New Preview
            nota2.id = cetak
            nota2.no = "2"
            nota2.kepada = "staf gudang"
            nota2.printWhat = "penjualan"
            nota2.ShowDialog()

            cetak = ""
        End If
    End Sub

    Private Sub ButtonClear_Click(sender As Object, e As EventArgs) Handles ButtonClear.Click
        DataGridView1.Rows.Clear()
        DataGridView2.Rows.Clear()
        TextBoxCari.Text = ""
        tampilHJual()
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Try
            cetak = DataGridView1.Rows(e.RowIndex).Cells(0).Value
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        tampilHJual()
    End Sub

End Class