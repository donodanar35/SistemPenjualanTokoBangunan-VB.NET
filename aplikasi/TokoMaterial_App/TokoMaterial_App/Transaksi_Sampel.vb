Imports MySql.Data.MySqlClient

Public Class Transaksi_Sampel
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


    Sub tampilHSampel()
        Dim cari As String = ""
        cari = TextBoxCari.Text
        Dim qs As String = "SELECT H.ID_SAM 'ID', K.NAMA_KAR 'PETUGAS', C.NAMA_CUS 'CUSTOMER', H.TGL_SAM 'TGLPESAN', H.TGL_KIRIM 'TGLKIRIM', H.NAMA_PENERIMA 'PENERIMA', H.ALAMAT_PENERIMA 'ALAMAT', H.TELP_PENERIMA 'TELP', H.KET_SAM 'KETERANGAN' FROM HSAMPEL H, KARYAWAN K, CUSTOMER C WHERE H.STATUS = 1 AND C.ID_CUS = H.ID_CUS AND H.ID_KAR = K.ID_KAR ORDER BY ID"

        If RadioButtonAlamat.Checked Then
            qs = "SELECT H.ID_SAM 'ID', K.NAMA_KAR 'PETUGAS', C.NAMA_CUS 'CUSTOMER', H.TGL_SAM 'TGLPESAN', H.TGL_KIRIM 'TGLKIRIM', H.NAMA_PENERIMA 'PENERIMA', H.ALAMAT_PENERIMA 'ALAMAT', H.TELP_PENERIMA 'TELP', H.KET_SAM 'KETERANGAN' FROM HSAMPEL H, KARYAWAN K, CUSTOMER C WHERE H.STATUS = 1 AND C.ID_CUS = H.ID_CUS AND H.ID_KAR = K.ID_KAR AND H.ALAMAT_PENERIMA like '%" & TextBoxCari.Text & "%' ORDER BY ID"
        ElseIf RadioButtonCustomer.Checked Then
            qs = "SELECT H.ID_SAM 'ID', K.NAMA_KAR 'PETUGAS', C.NAMA_CUS 'CUSTOMER', H.TGL_SAM 'TGLPESAN', H.TGL_KIRIM 'TGLKIRIM', H.NAMA_PENERIMA 'PENERIMA', H.ALAMAT_PENERIMA 'ALAMAT', H.TELP_PENERIMA 'TELP', H.KET_SAM 'KETERANGAN' FROM HSAMPEL H, KARYAWAN K, CUSTOMER C WHERE H.STATUS = 1 AND C.ID_CUS = H.ID_CUS AND H.ID_KAR = K.ID_KAR AND C.NAMA_CUS like '%" & TextBoxCari.Text & "%' ORDER BY ID"
        ElseIf RadioButtonID.Checked Then
            qs = "SELECT H.ID_SAM 'ID', K.NAMA_KAR 'PETUGAS', C.NAMA_CUS 'CUSTOMER', H.TGL_SAM 'TGLPESAN', H.TGL_KIRIM 'TGLKIRIM', H.NAMA_PENERIMA 'PENERIMA', H.ALAMAT_PENERIMA 'ALAMAT', H.TELP_PENERIMA 'TELP', H.KET_SAM 'KETERANGAN' FROM HSAMPEL H, KARYAWAN K, CUSTOMER C WHERE H.STATUS = 1 AND C.ID_CUS = H.ID_CUS AND H.ID_KAR = K.ID_KAR AND H.ID_SAM like '%" & TextBoxCari.Text & "%' ORDER BY ID"
        ElseIf RadioButtonKeterangan.Checked Then
            qs = "SELECT H.ID_SAM 'ID', K.NAMA_KAR 'PETUGAS', C.NAMA_CUS 'CUSTOMER', H.TGL_SAM 'TGLPESAN', H.TGL_KIRIM 'TGLKIRIM', H.NAMA_PENERIMA 'PENERIMA', H.ALAMAT_PENERIMA 'ALAMAT', H.TELP_PENERIMA 'TELP', H.KET_SAM 'KETERANGAN' FROM HSAMPEL H, KARYAWAN K, CUSTOMER C WHERE H.STATUS = 1 AND C.ID_CUS = H.ID_CUS AND H.ID_KAR = K.ID_KAR AND H.KET_SAM like '%" & TextBoxCari.Text & "%' ORDER BY ID"
        ElseIf RadioButtonPenerima.Checked Then
            qs = "SELECT H.ID_SAM 'ID', K.NAMA_KAR 'PETUGAS', C.NAMA_CUS 'CUSTOMER', H.TGL_SAM 'TGLPESAN', H.TGL_KIRIM 'TGLKIRIM', H.NAMA_PENERIMA 'PENERIMA', H.ALAMAT_PENERIMA 'ALAMAT', H.TELP_PENERIMA 'TELP', H.KET_SAM 'KETERANGAN' FROM HSAMPEL H, KARYAWAN K, CUSTOMER C WHERE H.STATUS = 1 AND C.ID_CUS = H.ID_CUS AND H.ID_KAR = K.ID_KAR AND H.NAMA_PENERIMA like '%" & TextBoxCari.Text & "%' ORDER BY ID"
        ElseIf RadioButtonPetugas.Checked Then
            qs = "SELECT H.ID_SAM 'ID', K.NAMA_KAR 'PETUGAS', C.NAMA_CUS 'CUSTOMER', H.TGL_SAM 'TGLPESAN', H.TGL_KIRIM 'TGLKIRIM', H.NAMA_PENERIMA 'PENERIMA', H.ALAMAT_PENERIMA 'ALAMAT', H.TELP_PENERIMA 'TELP', H.KET_SAM 'KETERANGAN' FROM HSAMPEL H, KARYAWAN K, CUSTOMER C WHERE H.STATUS = 1 AND C.ID_CUS = H.ID_CUS AND H.ID_KAR = K.ID_KAR AND K.NAMA_KAR like '%" & TextBoxCari.Text & "%' ORDER BY ID"
        ElseIf RadioButtonTelp.Checked Then
            qs = "SELECT H.ID_SAM 'ID', K.NAMA_KAR 'PETUGAS', C.NAMA_CUS 'CUSTOMER', H.TGL_SAM 'TGLPESAN', H.TGL_KIRIM 'TGLKIRIM', H.NAMA_PENERIMA 'PENERIMA', H.ALAMAT_PENERIMA 'ALAMAT', H.TELP_PENERIMA 'TELP', H.KET_SAM 'KETERANGAN' FROM HSAMPEL H, KARYAWAN K, CUSTOMER C WHERE H.STATUS = 1 AND C.ID_CUS = H.ID_CUS AND H.ID_KAR = K.ID_KAR AND H.TELP_PENERIMA like '%" & TextBoxCari.Text & "%' ORDER BY ID"
        ElseIf RadioButtonTglKirim.Checked Then
            qs = "SELECT H.ID_SAM 'ID', K.NAMA_KAR 'PETUGAS', C.NAMA_CUS 'CUSTOMER', H.TGL_SAM 'TGLPESAN', H.TGL_KIRIM 'TGLKIRIM', H.NAMA_PENERIMA 'PENERIMA', H.ALAMAT_PENERIMA 'ALAMAT', H.TELP_PENERIMA 'TELP', H.KET_SAM 'KETERANGAN' FROM HSAMPEL H, KARYAWAN K, CUSTOMER C WHERE H.STATUS = 1 AND C.ID_CUS = H.ID_CUS AND H.ID_KAR = K.ID_KAR AND H.TGL_KIRIM like '%" & Format(DateTimePickerKirim.Value, "yyyy-MM-dd") & "%' ORDER BY ID"
        ElseIf RadioButtonTglPesan.Checked Then
            qs = "SELECT H.ID_SAM 'ID', K.NAMA_KAR 'PETUGAS', C.NAMA_CUS 'CUSTOMER', H.TGL_SAM 'TGLPESAN', H.TGL_KIRIM 'TGLKIRIM', H.NAMA_PENERIMA 'PENERIMA', H.ALAMAT_PENERIMA 'ALAMAT', H.TELP_PENERIMA 'TELP', H.KET_SAM 'KETERANGAN' FROM HSAMPEL H, KARYAWAN K, CUSTOMER C WHERE H.STATUS = 1 AND C.ID_CUS = H.ID_CUS AND H.ID_KAR = K.ID_KAR AND H.TGL_SAM like '%" & Format(DateTimePickerPesan.Value, "yyyy-MM-dd") & "%' ORDER BY ID"
        End If

        usernameku = Form1.username
        ds.Clear()
        DataGridView1.Rows.Clear()
        Dim temp As String = ""
        Try
            Dim id As String = ""
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
                    petugas = DRX.Item("PETUGAS")
                    customer = DRX.Item("CUSTOMER")
                    tglPesan = DRX.Item("TGLPESAN")
                    tglKirim = DRX.Item("TGLKIRIM")
                    penerima = DRX.Item("PENERIMA")
                    alamat = DRX.Item("ALAMAT")
                    telp = DRX.Item("TELP")
                    ket = DRX.Item("KETERANGAN")
                    DataGridView1.Rows.Insert(DataGridView1.NewRowIndex, idx, petugas, customer, tglPesan, tglKirim, penerima, alamat, telp, ket, "Detail")
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

    Sub tampilDSampel()
        usernameku = Form1.username
        ds.Clear()
        DataGridView2.Rows.Clear()
        Dim temp As String = ""
        Try
            Dim barang As String = ""
            Dim satuan As String = ""
            Dim qty As String = ""

            conn = Form1.koneksi()
            Dim qs As String = "SELECT B.NAMA_BRG 'BARANG', S.NAMA_SATUAN 'SATUAN', D.QTY_SAM 'QTY' FROM SATUAN S, BARANG B, DSAMPEL D WHERE B.ID_BRG = D.ID_BRG And S.ID_SATUAN = B.ID_SATUAN AND D.ID_SAM like '" & idx & "'"
            Dim cmd = New MySqlCommand(qs, conn)
            Dim DRX As MySqlDataReader
            DRX = cmd.ExecuteReader

            If DRX.HasRows Then
                While DRX.Read()
                    barang = DRX.Item("BARANG")
                    satuan = DRX.Item("SATUAN")
                    qty = DRX.Item("QTY")
                    DataGridView2.Rows.Insert(DataGridView2.NewRowIndex, barang, satuan, qty)
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
            Dim qs As String = "UPDATE HSAMPEL SET status=0 WHERE ID_SAM LIKE '" & cetak & "'"
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
            If DataGridView1.Rows(e.RowIndex).Cells(9).Value = "Detail" Then
                idx = DataGridView1.Rows(e.RowIndex).Cells(0).Value
                tampilDSampel()
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Hapus_Click(sender As Object, e As EventArgs) Handles Hapus.Click
        Dim result As Integer = MessageBox.Show("Anda yakin menghapus faktur sampel " + cetak + "?", "Hapus Faktur Sampel " + cetak, MessageBoxButtons.YesNoCancel)
        If result = DialogResult.Cancel Then
            MessageBox.Show("Status faktur sampel " + cetak + " dibatalkan!")
        ElseIf result = DialogResult.No Then
            MessageBox.Show("Status faktur sampel " + cetak + " dibatalkan!")
        ElseIf result = DialogResult.Yes Then
            HapusSampel()
            tampilHSampel()
        End If
    End Sub

    Private Sub Transaksi_Sampel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tampilHSampel()
    End Sub

    Private Sub ButtonCetak_Click(sender As Object, e As EventArgs) Handles ButtonCetak.Click
        Dim result As Integer = MessageBox.Show("Anda yakin mencetak faktur sampel " + cetak + "?", "Cetak Faktur Sampel " + cetak, MessageBoxButtons.YesNoCancel)
        If result = DialogResult.Cancel Then
            MessageBox.Show("Cetak faktur sampel " + cetak + " dibatalkan!")
        ElseIf result = DialogResult.No Then
            MessageBox.Show("Cetak faktur sampel " + cetak + " dibatalkan!")
        ElseIf result = DialogResult.Yes Then
            Dim nota As New Preview
            nota.id = cetak
            nota.no = "1"
            nota.kepada = "customer"
            nota.printWhat = "sampel"
            nota.ShowDialog()

            Dim nota2 As New Preview
            nota2.id = cetak
            nota2.no = "2"
            nota2.kepada = "staf gudang"
            nota2.printWhat = "sampel"
            nota2.ShowDialog()
            cetak = ""
        End If
    End Sub

    Private Sub ButtonClear_Click(sender As Object, e As EventArgs) Handles ButtonClear.Click
        DataGridView1.Rows.Clear()
        DataGridView2.Rows.Clear()
        TextBoxCari.Text = ""
        tampilHSampel()
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Try
            cetak = DataGridView1.Rows(e.RowIndex).Cells(0).Value
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        tampilHSampel()
    End Sub
End Class