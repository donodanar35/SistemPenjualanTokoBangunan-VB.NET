Imports MySql.Data.MySqlClient

Public Class Transaksi_Pembelian
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


    Sub tampilHBeli()
        Dim cari As String = ""
        cari = TextBoxCari.Text
        Dim qs As String = "SELECT H.ID_BELI 'ID', K.NAMA_KAR 'PETUGAS', S.NAMA_SUP 'SUPPLIER', H.TGL_BELI 'TGLPESAN', H.TGL_KIRIM 'TGLKIRIM', H.KET_BELI 'KETERANGAN' FROM HBELI H, KARYAWAN K, SUPPLIER S WHERE H.STATUS = 1 AND S.ID_SUP = H.ID_SUP AND H.ID_KAR = K.ID_KAR ORDER BY ID"

        If RadioButtonSuplier.Checked Then
            qs = "SELECT H.ID_BELI 'ID', K.NAMA_KAR 'PETUGAS', S.NAMA_SUP 'SUPPLIER', H.TGL_BELI 'TGLPESAN', H.TGL_KIRIM 'TGLKIRIM', H.KET_BELI 'KETERANGAN' FROM HBELI H, KARYAWAN K, SUPPLIER S WHERE H.STATUS = 1 AND S.ID_SUP = H.ID_SUP AND H.ID_KAR = K.ID_KAR  AND S.NAMA_SUP like '%" & TextBoxCari.Text & "%' ORDER BY ID"
        ElseIf RadioButtonID.Checked Then
            qs = "SELECT H.ID_BELI 'ID', K.NAMA_KAR 'PETUGAS', S.NAMA_SUP 'SUPPLIER', H.TGL_BELI 'TGLPESAN', H.TGL_KIRIM 'TGLKIRIM', H.KET_BELI 'KETERANGAN' FROM HBELI H, KARYAWAN K, SUPPLIER S WHERE H.STATUS = 1 AND S.ID_SUP = H.ID_SUP AND H.ID_KAR = K.ID_KAR  AND H.ID_BELI like '%" & TextBoxCari.Text & "%' ORDER BY ID"
        ElseIf RadioButtonKeterangan.Checked Then
            qs = "SELECT H.ID_BELI 'ID', K.NAMA_KAR 'PETUGAS', S.NAMA_SUP 'SUPPLIER', H.TGL_BELI 'TGLPESAN', H.TGL_KIRIM 'TGLKIRIM', H.KET_BELI 'KETERANGAN' FROM HBELI H, KARYAWAN K, SUPPLIER S WHERE H.STATUS = 1 AND S.ID_SUP = H.ID_SUP AND H.ID_KAR = K.ID_KAR  AND H.KET_BELI like '%" & TextBoxCari.Text & "%' ORDER BY ID"
        ElseIf RadioButtonPetugas.Checked Then
            qs = "SELECT H.ID_BELI 'ID', K.NAMA_KAR 'PETUGAS', S.NAMA_SUP 'SUPPLIER', H.TGL_BELI 'TGLPESAN', H.TGL_KIRIM 'TGLKIRIM', H.KET_BELI 'KETERANGAN' FROM HBELI H, KARYAWAN K, SUPPLIER S WHERE H.STATUS = 1 AND S.ID_SUP = H.ID_SUP AND H.ID_KAR = K.ID_KAR  AND K.NAMA_KAR like '%" & TextBoxCari.Text & "%' ORDER BY ID"
        ElseIf RadioButtonTglKirim.Checked Then
            qs = "SELECT H.ID_BELI 'ID', K.NAMA_KAR 'PETUGAS', S.NAMA_SUP 'SUPPLIER', H.TGL_BELI 'TGLPESAN', H.TGL_KIRIM 'TGLKIRIM', H.KET_BELI 'KETERANGAN' FROM HBELI H, KARYAWAN K, SUPPLIER S WHERE H.STATUS = 1 AND S.ID_SUP = H.ID_SUP AND H.ID_KAR = K.ID_KAR  AND H.TGL_KIRIM like '%" & Format(DateTimePickerKirim.Value, "yyyy-MM-dd") & "%' ORDER BY ID"
        ElseIf RadioButtonTglPesan.Checked Then
            qs = "SELECT H.ID_BELI 'ID', K.NAMA_KAR 'PETUGAS', S.NAMA_SUP 'SUPPLIER', H.TGL_BELI 'TGLPESAN', H.TGL_KIRIM 'TGLKIRIM', H.KET_BELI 'KETERANGAN' FROM HBELI H, KARYAWAN K, SUPPLIER S WHERE H.STATUS = 1 AND S.ID_SUP = H.ID_SUP AND H.ID_KAR = K.ID_KAR  AND H.TGL_BELI like '%" & Format(DateTimePickerPesan.Value, "yyyy-MM-dd") & "%' ORDER BY ID"
        End If

        usernameku = Form1.username
        ds.Clear()
        DataGridView1.Rows.Clear()
        Dim temp As String = ""
        Try
            Dim id As String = ""
            Dim petugas As String = ""
            Dim supplier As String = ""
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
                    supplier = DRX.Item("supplier")
                    tglPesan = DRX.Item("TGLPESAN")
                    tglKirim = DRX.Item("TGLKIRIM")
                    ket = DRX.Item("KETERANGAN")
                    DataGridView1.Rows.Insert(DataGridView1.NewRowIndex, idx, petugas, supplier, tglPesan, tglKirim, ket, "Detail")
                End While
            Else
                MsgBox("Data tidak tersedia!")
            End If
            DRX.Close()
            conn.Close()
        Catch ex As Exception
            MsgBox("Tampilan Hbeli bermasalah! " + ex.ToString)
        End Try
    End Sub

    Sub tampilDBeli()
        usernameku = Form1.username
        ds.Clear()
        DataGridView2.Rows.Clear()
        Dim temp As String = ""
        Try
            Dim barang As String = ""
            Dim satuan As String = ""
            Dim qty As String = ""
            Dim hb As Decimal = 0
            Dim ppn As Decimal = 0
            Dim diskon As Decimal = 0
            Dim subtotal As Decimal = 0

            conn = Form1.koneksi()
            Dim qs As String = "SELECT B.NAMA_BRG 'BARANG', S.NAMA_SATUAN 'SATUAN', D.QTY_BELI 'QTY', D.HRG_BELI 'HARGA_BELI', D.SUBTOTAL_BELI 'SUBTOTAL' FROM SATUAN S, BARANG B, DBELI D WHERE B.ID_BRG = D.ID_BRG And S.ID_SATUAN = B.ID_SATUAN AND D.ID_BELI LIKE '" & idx & "'"
            Dim cmd = New MySqlCommand(qs, conn)
            Dim DRX As MySqlDataReader
            DRX = cmd.ExecuteReader

            If DRX.HasRows Then
                While DRX.Read()
                    barang = DRX.Item("BARANG")
                    satuan = DRX.Item("SATUAN")
                    qty = DRX.Item("QTY")
                    hb = DRX.Item("HARGA_BELI")
                    subtotal = DRX.Item("SUBTOTAL")
                    DataGridView2.Rows.Insert(DataGridView2.NewRowIndex, barang, qty, satuan, hb, subtotal)
                End While
            Else
                MsgBox("Data tidak tersedia!")
            End If
            DRX.Close()
            conn.Close()
            idx = ""
        Catch ex As Exception
            MsgBox("Tampilan Dbeli bermasalah! " + ex.ToString)
        End Try
    End Sub

    Sub HapusSampel()
        Try
            conn = Form1.koneksi()
            Dim qs As String = "UPDATE HBELI SET status=0 WHERE ID_BELI LIKE '" & cetak & "'"
            cmd = New MySqlCommand(qs, conn)
            cmd.ExecuteNonQuery()
            conn.Close()
            cetak = ""
            MsgBox("Data pembelian " & cetak & " berhasil dilakukan!")
        Catch ex As Exception
            MsgBox("Hapus sampel bermasalah!")
        End Try
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Try
            If DataGridView1.Rows(e.RowIndex).Cells(6).Value = "Detail" Then
                idx = DataGridView1.Rows(e.RowIndex).Cells(0).Value
                tampilDBeli()
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Hapus_Click(sender As Object, e As EventArgs) Handles Hapus.Click
        Dim result As Integer = MessageBox.Show("Anda yakin menghapus faktur beli " + cetak + "?", "Hapus Faktur beli " + cetak, MessageBoxButtons.YesNoCancel)
        If result = DialogResult.Cancel Then
            MessageBox.Show("Status faktur beli " + cetak + " dibatalkan!")
        ElseIf result = DialogResult.No Then
            MessageBox.Show("Status faktur beli " + cetak + " dibatalkan!")
        ElseIf result = DialogResult.Yes Then
            HapusSampel()
            tampilHBeli()
        End If
    End Sub

    Private Sub Transaksi_Sampel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tampilHBeli()
    End Sub

    Private Sub ButtonCetak_Click(sender As Object, e As EventArgs) Handles ButtonCetak.Click
        Dim result As Integer = MessageBox.Show("Anda yakin mencetak faktur beli " + cetak + "?", "Cetak Faktur Beli " + cetak, MessageBoxButtons.YesNoCancel)
        If result = DialogResult.Cancel Then
            MessageBox.Show("Cetak faktur beli " + cetak + " dibatalkan!")
        ElseIf result = DialogResult.No Then
            MessageBox.Show("Cetak faktur beli " + cetak + " dibatalkan!")
        ElseIf result = DialogResult.Yes Then
            Dim nota As New Preview
            nota.id = cetak
            nota.no = "1"
            nota.kepada = "bendahara"
            nota.printWhat = "pembelian"
            nota.ShowDialog()

            Dim nota2 As New Preview
            nota2.id = cetak
            nota2.no = "2"
            nota2.kepada = "staf gudang"
            nota2.printWhat = "pembelian"
            nota2.ShowDialog()

            cetak = ""
        End If
    End Sub

    Private Sub ButtonClear_Click(sender As Object, e As EventArgs) Handles ButtonClear.Click
        DataGridView1.Rows.Clear()
        DataGridView2.Rows.Clear()
        TextBoxCari.Text = ""
        tampilHBeli()
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Try
            cetak = DataGridView1.Rows(e.RowIndex).Cells(0).Value
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        tampilHBeli()
    End Sub

End Class