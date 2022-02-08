Imports MySql.Data.MySqlClient

Public Class Transaksi_Promo
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
    Dim tglAkhir As Date = Today

    Dim Cek_id As New ArrayList
    Dim Cek_barang As New ArrayList
    Dim Cek_diskon As New ArrayList
    Dim Cek_status As New ArrayList
    Dim Cek_awal As New ArrayList
    Dim Cek_akhir As New ArrayList
    Dim cek_minqty As New ArrayList

    Sub updatePromoNow()
        For i As Integer = 0 To Cek_barang.Count - 1
            Dim temp_akhir As Date = Cek_akhir(i)
            Dim temp_awal As Date = Cek_awal(i)
            If Format(Today, "yyyy-MM-dd") > temp_akhir Then
                UpdateStatusPromo(temp_akhir, Cek_id(i))
            ElseIf Format(Today, "yyyy-MM-dd") >= temp_awal Then
                UpdateDiskonPromo(Cek_awal(i), Cek_akhir(i), Cek_id(i))
            End If
        Next
    End Sub

    Function CekPromo()
        Dim cari As String = ""
        cari = TextBoxCari.Text
        Dim qs As String = "SELECT H.STATUS_PROMO 'STATUS', B.ID_BRG 'ID BRG', H.ID_DISC 'ID DISC', H.TGLAWAL_DISC 'AWAL', H.TGLAKHIR_DISC 'AKHIR', B.NAMA_BRG 'BARANG', D.DISC_PERSEN 'DISKON', D.MIN_QTY 'MIN QTY' FROM BARANG B, DDISKON D, HDISKON H WHERE H.STATUS = 1 AND B.ID_BRG = D.ID_BRG  AND H.ID_DISC = D.ID_DISC AND H.TGLAWAL_DISC >= '" & Format(Today, "yyyy-MM-dd") & "'  AND (H.STATUS_PROMO = 'diproses' OR H.STATUS_PROMO = 'aktif') GROUP BY D.ID_BRG;"

        usernameku = Form1.username
        ds.Clear()
        DataGridView1.Rows.Clear()
        Dim temp As Integer = 0
        Try
            conn = Form1.koneksi()
            Dim cmd = New MySqlCommand(qs, conn)
            Dim DRX As MySqlDataReader
            DRX = cmd.ExecuteReader

            If DRX.HasRows Then
                temp = 1
                While DRX.Read()
                    Cek_id.Add(DRX.Item("ID DISC"))
                    Cek_barang.Add(DRX.Item("ID BRG"))
                    Cek_diskon.Add(DRX.Item("DISKON"))
                    Cek_status.Add(DRX.Item("STATUS"))
                    Cek_awal.Add(DRX.Item("AWAL"))
                    Cek_akhir.Add(DRX.Item("AKHIR"))
                    cek_minqty.Add(DRX.Item("MIN QTY"))
                End While
            Else
                temp = 0
            End If
            DRX.Close()
            conn.Close()
        Catch ex As Exception
            MsgBox("Tampilan CekPromo bermasalah! " + ex.ToString)
        End Try
        Return temp
    End Function

    Sub tampilHPromo()
        Dim cari As String = ""
        cari = TextBoxCari.Text
        Dim qs As String = "SELECT H.ID_DISC 'ID', K.NAMA_KAR 'PETUGAS', H.PROMO 'PROMO', H.TGL 'TGL', H.TGLAWAL_DISC 'AWAL', H.TGLAKHIR_DISC 'AKHIR', H.KET_DISC 'KETERANGAN', H.STATUS_PROMO 'STATUS' FROM HDISKOn H, KARYAWAN K WHERE H.STATUS > 0 AND H.ID_KAR = K.ID_KAR ORDER BY ID"

       If RadioButtonID.Checked Then
            qs = "SELECT H.ID_DISC 'ID', K.NAMA_KAR 'PETUGAS', H.PROMO 'PROMO', H.TGL 'TGL', H.TGLAWAL_DISC 'AWAL', H.TGLAKHIR_DISC 'AKHIR', H.KET_DISC 'KETERANGAN', H.STATUS_PROMO 'STATUS' FROM HDISKON H, KARYAWAN K WHERE H.STATUS > 0 AND H.ID_KAR = K.ID_KAR AND H.ID_DISC LIKE '%" & TextBoxCari.Text & "%' ORDER BY ID"
        ElseIf RadioButtonKeterangan.Checked Then
            qs = "SELECT H.ID_DISC 'ID', K.NAMA_KAR 'PETUGAS', H.PROMO 'PROMO', H.TGL 'TGL', H.TGLAWAL_DISC 'AWAL', H.TGLAKHIR_DISC 'AKHIR', H.KET_DISC 'KETERANGAN', H.STATUS_PROMO 'STATUS' FROM HDISKON H, KARYAWAN K WHERE H.STATUS > 0 AND H.ID_KAR = K.ID_KAR AND H.KET_DISC LIKE '%" & TextBoxCari.Text & "%' ORDER BY ID "
        ElseIf RadioButtonPetugas.Checked Then
            qs = "SELECT H.ID_DISC 'ID', K.NAMA_KAR 'PETUGAS', H.PROMO 'PROMO', H.TGL 'TGL', H.TGLAWAL_DISC 'AWAL', H.TGLAKHIR_DISC 'AKHIR', H.KET_DISC 'KETERANGAN', H.STATUS_PROMO 'STATUS' FROM HDISKON H, KARYAWAN K WHERE H.STATUS > 0 AND H.ID_KAR = K.ID_KAR AND K.NAMA_KAR LIKE '%" & TextBoxCari.Text & "%' ORDER BY ID "
        ElseIf RadioButtonPromo.Checked Then
            qs = "SELECT H.ID_DISC 'ID', K.NAMA_KAR 'PETUGAS', H.PROMO 'PROMO', H.TGL 'TGL', H.TGLAWAL_DISC 'AWAL', H.TGLAKHIR_DISC 'AKHIR', H.KET_DISC 'KETERANGAN', H.STATUS_PROMO 'STATUS' FROM HDISKON H, KARYAWAN K WHERE H.STATUS > 0 AND H.ID_KAR = K.ID_KAR AND H.PROMO LIKE '%" & TextBoxCari.Text & "%' ORDER BY ID"
        ElseIf RadioButtonStatus.Checked Then
            qs = "SELECT H.ID_DISC 'ID', K.NAMA_KAR 'PETUGAS', H.PROMO 'PROMO', H.TGL 'TGL', H.TGLAWAL_DISC 'AWAL', H.TGLAKHIR_DISC 'AKHIR', H.KET_DISC 'KETERANGAN', H.STATUS_PROMO 'STATUS' FROM HDISKON H, KARYAWAN K WHERE H.STATUS > 0 AND H.ID_KAR = K.ID_KAR AND H.STATUS_PROMO LIKE '%" & TextBoxCari.Text & "%' ORDER BY ID"
        End If

        usernameku = Form1.username
        ds.Clear()
        DataGridView1.Rows.Clear()
        Dim temp As String = ""
        Try
            Dim id As String = ""
            Dim petugas As String = ""
            Dim promo As String = ""
            Dim tgl As String = ""
            Dim awal As String = ""
            Dim akhir As String = ""
            Dim ket As String = ""
            Dim status As String = ""

            conn = Form1.koneksi()
            Dim cmd = New MySqlCommand(qs, conn)
            Dim DRX As MySqlDataReader
            DRX = cmd.ExecuteReader

            If DRX.HasRows Then
                While DRX.Read()
                    idx = DRX.Item("ID")
                    petugas = DRX.Item("PETUGAS")
                    promo = DRX.Item("PROMO")
                    tgl = DRX.Item("TGL")
                    awal = DRX.Item("AWAL")
                    akhir = DRX.Item("AKHIR")
                    ket = DRX.Item("KETERANGAN")
                    status = DRX.Item("STATUS")

                    DataGridView1.Rows.Insert(DataGridView1.NewRowIndex, idx, petugas, promo, tgl, awal, akhir, ket, status, "Detail")
                End While
            Else
                MsgBox("Data tidak tersedia!")
            End If
            DRX.Close()
            conn.Close()
        Catch ex As Exception
            MsgBox("Tampilan HPromo bermasalah! " + ex.ToString)
        End Try
    End Sub

    Sub tampilDPromo()
        usernameku = Form1.username
        ds.Clear()
        DataGridView2.Rows.Clear()
        Dim temp As String = ""
        Try
            Dim barang As String = ""
            Dim MinQty As String = ""
            Dim discPerc As Decimal = 0
            Dim discIDR As Decimal = 0
            Dim hb As Decimal = 0
            Dim hj As Decimal = 0
            Dim hdisc As Decimal = 0
            Dim profitBrg As Decimal = 0
            Dim ProfitTrans As Decimal = 0

            conn = Form1.koneksi()
            Dim qs As String = "SELECT B.NAMA_BRG 'BARANG', D.DISC_PERSEN 'DISKON', D.DISC_IDR 'DISKON_IDR', D.MIN_QTY 'MIN_QTY', D.HARGA_BELI 'HARGA_BELI', D.HARGA_JUAL 'HARGA_JUAL', D.HARGA_DISKON 'HARGA_DISKON', D.PROFIT_PERBARANG 'PROFIT_BRG', D.PROFIT_PERTRANSAKSI 'PROFIT_TRANS' FROM BARANG B, DDISKON D WHERE B.ID_BRG = D.ID_BRG AND D.ID_DISC LIKE '" & idx & "'"
            Dim cmd = New MySqlCommand(qs, conn)
            Dim DRX As MySqlDataReader
            DRX = cmd.ExecuteReader

            If DRX.HasRows Then
                While DRX.Read()
                    barang = DRX.Item("BARANG")
                    MinQty = DRX.Item("MIN_QTY")
                    hb = DRX.Item("HARGA_BELI")
                    hj = DRX.Item("HARGA_JUAL")
                    hdisc = DRX.Item("HARGA_DISKON")
                    discPerc = DRX.Item("DISKON")
                    discIDR = DRX.Item("DISKON_IDR")
                    profitBrg = DRX.Item("PROFIT_BRG")
                    ProfitTrans = DRX.Item("PROFIT_TRANS")
                    DataGridView2.Rows.Insert(DataGridView2.NewRowIndex, barang, MinQty, discPerc, discIDR, hb, hj, hdisc, profitBrg, ProfitTrans)
                End While
            Else
                MsgBox("Data tidak tersedia!")
            End If
            DRX.Close()
            conn.Close()
            idx = ""
        Catch ex As Exception
            MsgBox("Tampilan DPromo bermasalah! " + ex.ToString)
        End Try
    End Sub

    Sub tampilBarangPromo()
        usernameku = Form1.username
        ds.Clear()
        DataGridView2.Rows.Clear()
        Dim temp As String = ""
        Try
            Dim barang As String = ""
            Dim MinQty As String = ""
            Dim discPerc As Decimal = 0
            Dim discIDR As Decimal = 0
            Dim hb As Decimal = 0
            Dim hj As Decimal = 0
            Dim hdisc As Decimal = 0
            Dim profitBrg As Decimal = 0
            Dim ProfitTrans As Decimal = 0
            Dim promo As String = ""
            Dim awal As String = ""
            Dim akhir As String = ""
            Dim idx As String = ""
            Dim idb As String = ""

            conn = Form1.koneksi()
            Dim qs As String = "SELECT B.ID_BRG 'IDB', H.ID_DISC 'ID', H.TGLAWAL_DISC 'AWAL', H.TGLAKHIR_DISC 'AKHIR', B.NAMA_BRG 'BARANG', H.PROMO 'PROMO', D.DISC_PERSEN 'DISKON', D.DISC_IDR 'DISKON_IDR', D.MIN_QTY 'MIN_QTY', D.HARGA_BELI 'HARGA_BELI', D.HARGA_JUAL 'HARGA_JUAL', D.HARGA_DISKON 'HARGA_DISKON', D.PROFIT_PERBARANG 'PROFIT_BRG', D.PROFIT_PERTRANSAKSI 'PROFIT_TRANS' FROM BARANG B, DDISKON D, HDISKON H WHERE H.STATUS >= 1 AND B.ID_BRG = D.ID_BRG AND H.ID_DISC = D.ID_DISC AND (H.TGLAKHIR_DISC >= '" & Format(Today, "yyyy-MM-dd") & "' AND  H.TGLAWAL_DISC <= '" & Format(Today, "yyyy-MM-dd") & "') AND H.STATUS_PROMO ='aktif'"
            Dim cmd = New MySqlCommand(qs, conn)
            Dim DRX As MySqlDataReader
            DRX = cmd.ExecuteReader

            If DRX.HasRows Then
                While DRX.Read()
                    idb = DRX.Item("IDB")
                    idx = DRX.Item("ID")
                    barang = DRX.Item("BARANG")
                    promo = DRX.Item("PROMO")
                    MinQty = DRX.Item("MIN_QTY")
                    hb = DRX.Item("HARGA_BELI")
                    hj = DRX.Item("HARGA_JUAL")
                    hdisc = DRX.Item("HARGA_DISKON")
                    discPerc = DRX.Item("DISKON")
                    discIDR = DRX.Item("DISKON_IDR")
                    profitBrg = DRX.Item("PROFIT_BRG")
                    ProfitTrans = DRX.Item("PROFIT_TRANS")
                    awal = DRX.Item("AWAL")
                    akhir = DRX.Item("AKHIR")
                    DataGridView3.Rows.Insert(DataGridView3.NewRowIndex, idb, barang, idx, promo, discPerc, discIDR, hb, hj, hdisc, MinQty, profitBrg, ProfitTrans, awal, akhir)
                End While
            Else
                MsgBox("data tidak tersedia")
            End If
            DRX.Close()
            conn.Close()
            idx = ""
        Catch ex As Exception
            MsgBox("Tampilan DPromo bermasalah! " + ex.ToString)
        End Try
    End Sub

    Sub HapusPromo()
        Try
            conn = Form1.koneksi()
            Dim qs As String = "UPDATE HDISKON SET status=0 WHERE ID_DISC LIKE '" & cetak & "'"
            cmd = New MySqlCommand(qs, conn)
            cmd.ExecuteNonQuery()
            conn.Close()
            cetak = ""
            MsgBox("Data promo " & cetak & " berhasil dilakukan!")
        Catch ex As Exception
            MsgBox("Hapus promo bermasalah!" + ex.ToString)
        End Try
    End Sub

    Sub updateAllPromo()
        Try
            For i As Integer = 0 To DataGridView1.Rows.Count - 2
                Dim id_diskon As String = DataGridView1.Rows(i).Cells(0).Value()
                Dim awal As Date = Date.Parse(DataGridView1.Rows(i).Cells(4).Value())
                Dim batasPromo As Date = Date.Parse(DataGridView1.Rows(i).Cells(5).Value())
                Dim status_promo As String = DataGridView1.Rows(i).Cells(7).Value()
                If Format(Today, "yyyy-MM-dd") > batasPromo Then
                    UpdateStatusPromo(batasPromo, id_diskon)
                ElseIf Format(Today, "yyyy-MM-dd") >= awal Then
                    UpdateDiskonPromo(awal, batasPromo, id_diskon)
                End If
                MsgBox("Pembaruan promo berhasil!")
            Next
        Catch ex As Exception
            MsgBox("UpdateAllPromo bermasalah! " + ex.ToString)
        End Try
    End Sub

    Function AmbilBarangPromo(id_diskon As String)
        Dim cari As String = ""
        cari = TextBoxCari.Text
        Dim qs As String = "SELECT D.ID_BRG 'ID' FROM DDISKON D WHERE D.ID_DISC LIKE '" & id_diskon & "'"
        usernameku = Form1.username
        Dim idb As New ArrayList
        Try
            conn = Form1.koneksi()
            Dim cmd = New MySqlCommand(qs, conn)
            Dim DRX As MySqlDataReader
            DRX = cmd.ExecuteReader

            If DRX.HasRows Then
                While DRX.Read()
                    idb.Add(DRX.Item("ID"))
                End While
            Else
                MsgBox("Data tidak tersedia!")
            End If
            DRX.Close()
            conn.Close()
        Catch ex As Exception
            MsgBox("Tampilan AmbilDataPromo bermasalah! " + ex.ToString)
        End Try
        Return idb
    End Function

    Function AmbilMinQtyBarang(id_diskon As String)
        Dim cari As String = ""
        cari = TextBoxCari.Text
        Dim qs As String = "SELECT D.MIN_QTY 'MIN QTY' FROM DDISKON D WHERE D.ID_DISC LIKE '" & id_diskon & "'"
        usernameku = Form1.username
        Dim idb As New ArrayList
        Try
            conn = Form1.koneksi()
            Dim cmd = New MySqlCommand(qs, conn)
            Dim DRX As MySqlDataReader
            DRX = cmd.ExecuteReader

            If DRX.HasRows Then
                While DRX.Read()
                    idb.Add(DRX.Item("MIN QTY"))
                End While
            Else
                MsgBox("Data min qty tidak tersedia!")
            End If
            DRX.Close()
            conn.Close()
        Catch ex As Exception
            MsgBox("Tampilan AmbilDiskonBarang bermasalah! " + ex.ToString)
        End Try
        Return idb
    End Function

    Function AmbilDiskonBarang(id_diskon As String)
        Dim cari As String = ""
        cari = TextBoxCari.Text
        Dim qs As String = "SELECT D.DISC_PERSEN 'DISKON' FROM DDISKON D WHERE D.ID_DISC LIKE '" & id_diskon & "'"
        usernameku = Form1.username
        Dim idb As New ArrayList
        Try
            conn = Form1.koneksi()
            Dim cmd = New MySqlCommand(qs, conn)
            Dim DRX As MySqlDataReader
            DRX = cmd.ExecuteReader

            If DRX.HasRows Then
                While DRX.Read()
                    idb.Add(DRX.Item("DISKON"))
                End While
            Else
                MsgBox("Data diskon tidak tersedia!")
            End If
            DRX.Close()
            conn.Close()
        Catch ex As Exception
            MsgBox("Tampilan AmbilDiskonBarang bermasalah! " + ex.ToString)
        End Try
        Return idb
    End Function

    Sub UpdateStatusPromo(batasPromo As Date, id_diskon As String)
        Try
            If batasPromo < Format(Today, "yyyy-MM-dd") Then
                conn = Form1.koneksi()
                Dim qs As String = "UPDATE HDISKON SET status_promo='kadaluarsa' WHERE ID_DISC LIKE '" & id_diskon & "'"
                cmd = New MySqlCommand(qs, conn)
                cmd.ExecuteNonQuery()
                Dim dataBarang As New ArrayList
                dataBarang = AmbilBarangPromo(id_diskon)
                conn = Form1.koneksi()
                Dim trans As MySqlTransaction = conn.BeginTransaction()
                Dim cmdy As New MySqlCommand
                Try
                    For i As Integer = 0 To dataBarang.Count - 1
                        Dim qsy As String = "UPDATE barang SET diskon = 0, min_qty = 0 " & " WHERE id_brg = '" & dataBarang(i) & "'"
                        cmdy = New MySqlCommand(qsy, conn)
                        cmdy.ExecuteNonQuery()
                    Next
                    trans.Commit()
                    'MessageBox.Show("Data diskon barang berhasil dilakukan!")
                Catch ex As Exception
                    trans.Rollback()
                    MessageBox.Show("Data diskon barang bersil dilakukan! " + ex.ToString)
                End Try
                trans.Dispose()
                cmdy.Dispose()
                conn.Close()
            Else
                MsgBox("promo masih berlaku! ")
            End If
        Catch ex As Exception
            MsgBox("Update promo bermasalah!" + ex.ToString)
        End Try
    End Sub

    Sub UpdateDiskonPromo(AwalPromo As Date, BatasPromo As Date, id_diskon As String)
        Try
            If ((Format(Today, "yyyy-MM-dd") > (Format(AwalPromo, "yyyy-MM-dd")) And (Format(Today, "yyyy-MM-dd") < Format(BatasPromo, "yyyy-MM-dd")) Or ((Format(Today, "yyyy-MM-dd") = Format(AwalPromo, "yyyy-MM-dd")) And (Format(Today, "yyyy-MM-dd") < Format(BatasPromo, "yyyy-MM-dd"))))) Then
                conn = Form1.koneksi()
                Dim qs As String = "UPDATE HDISKON SET status_promo='aktif', status=2 WHERE ID_DISC LIKE '" & id_diskon & "'"
                cmd = New MySqlCommand(qs, conn)
                cmd.ExecuteNonQuery()

                Dim dataBarang As New ArrayList
                Dim diskonBarang As New ArrayList
                Dim minQty As New ArrayList
                dataBarang = AmbilBarangPromo(id_diskon)
                diskonBarang = AmbilDiskonBarang(id_diskon)
                minQty = AmbilMinQtyBarang(id_diskon)

                conn = Form1.koneksi()
                Dim trans As MySqlTransaction = conn.BeginTransaction()
                Dim cmdy As New MySqlCommand
                Try
                    For i As Integer = 0 To dataBarang.Count - 1
                        Dim qsy As String = "UPDATE barang SET min_qty =" & minQty(i) & ", diskon = " & diskonBarang(i) & " WHERE id_brg = '" & dataBarang(i) & "'"
                        cmdy = New MySqlCommand(qsy, conn)
                        cmdy.ExecuteNonQuery()
                    Next
                    trans.Commit()
                Catch ex As Exception
                    trans.Rollback()
                    MessageBox.Show("Data diskon barang berhasil dilakukan! " + ex.ToString)
                End Try
                trans.Dispose()
                cmdy.Dispose()
                conn.Close()
            End If
        Catch ex As Exception
            MsgBox("Update promo bermasalah!" + ex.ToString)
        End Try
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Try
            If DataGridView1.Rows(e.RowIndex).Cells(8).Value = "Detail" Then
                idx = DataGridView1.Rows(e.RowIndex).Cells(0).Value
                tglAkhir = Date.Parse(DataGridView1.Rows(e.RowIndex).Cells(5).Value)
                tampilDPromo()
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Hapus_Click(sender As Object, e As EventArgs) Handles Hapus.Click
        Dim result As Integer = MessageBox.Show("Anda yakin menghapus faktur promo " + cetak + "?", "Hapus Faktur Promo " + cetak, MessageBoxButtons.YesNoCancel)
        If result = DialogResult.Cancel Then
            MessageBox.Show("Status faktur promo " + cetak + " dibatalkan!")
        ElseIf result = DialogResult.No Then
            MessageBox.Show("Status faktur promo " + cetak + " dibatalkan!")
        ElseIf result = DialogResult.Yes Then
            HapusPromo()
            tampilHPromo()
        End If
    End Sub

    Private Sub Transaksi_Sampel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tampilHPromo()
        tampilBarangPromo()
    End Sub

    Private Sub ButtonCetak_Click(sender As Object, e As EventArgs) Handles ButtonCetak.Click
        Dim result As Integer = MessageBox.Show("Anda yakin mencetak faktur promo " + cetak + "?", "Cetak Faktur Promo " + cetak, MessageBoxButtons.YesNoCancel)
        If result = DialogResult.Cancel Then
            MessageBox.Show("Cetak faktur promo " + cetak + " dibatalkan!")
        ElseIf result = DialogResult.No Then
            MessageBox.Show("Cetak faktur promo " + cetak + " dibatalkan!")
        ElseIf result = DialogResult.Yes Then
            Dim nota As New Preview
            nota.id = cetak
            nota.printWhat = "diskon"
            nota.ShowDialog()
            cetak = ""
        End If
    End Sub

    Sub clearData()
        DataGridView1.Rows.Clear()
        DataGridView2.Rows.Clear()
        DataGridView3.Rows.Clear()
        TextBoxCari.Text = ""
        tampilHPromo()
        tampilBarangPromo()
    End Sub

    Private Sub ButtonClear_Click(sender As Object, e As EventArgs) Handles ButtonClear.Click
        clearData()
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Try
            cetak = DataGridView1.Rows(e.RowIndex).Cells(0).Value
            tglAkhir = Date.Parse(DataGridView1.Rows(e.RowIndex).Cells(5).Value)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim result As Integer = MessageBox.Show("Anda yakin mau memperbarui status promo sekarang?", "Perbarui Status Promo", MessageBoxButtons.YesNoCancel)
        If result = DialogResult.Cancel Then
            MessageBox.Show("Dibatalkan!")
        ElseIf result = DialogResult.No Then
            MessageBox.Show("Dibatalkan!")
        ElseIf result = DialogResult.Yes Then
            updateAllPromo()
        End If
        clearData()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        DataGridView3.Rows.Clear()
        DataGridView1.Rows.Clear()
        tampilBarangPromo()
        tampilHPromo()
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        Dim tampilBrg As New barang
        tampilBrg.ShowDialog()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        tampilHPromo()
    End Sub
End Class