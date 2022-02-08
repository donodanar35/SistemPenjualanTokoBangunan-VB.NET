Imports MySql.Data.MySqlClient

Public Class Perbarui_Persediaan
    Public usernameku As String
    Public namapetugas As String
    Public id As String
    Public conn As MySqlConnection
    Public cmd As MySqlCommand
    Public da As MySqlDataAdapter
    Public dt As New DataTable("barang")
    Public ds As New DataSet
    Public DR As MySqlDataReader
    Dim id_stockin As String = ""
    Dim id_stockout As String = ""
    Dim status_stockin As String = ""
    Dim status_stockout As String = ""

    Dim cek_id_stockout As New ArrayList
    Dim cek_kirim_stockout As New ArrayList
    Dim cek_id_stockin As New ArrayList
    Dim cek_kirim_stockin As New ArrayList

    Function CekStockin()
        Dim cari As String = ""
        cari = TextBoxCariIn.Text
        Dim qs As String = "SELECT H.ID_STOCKIN 'ID', H.TGL_KIRIM 'KIRIM', H.STATUS_STOK 'STATUS' FROM HSTOCKIN H WHERE H.STATUS_STOK LIKE 'diproses' AND (H.TGL_KIRIM < '" & Format(Today, "yyyy-MM-dd") & "' OR H.TGL_KIRIM = '" & Format(Today, "yyyy-MM-dd") & "');"

        usernameku = Form1.username
        ds.Clear()
        Dim temp As Integer = 0
        Try
            conn = Form1.koneksi()
            Dim cmd = New MySqlCommand(qs, conn)
            Dim DRX As MySqlDataReader
            DRX = cmd.ExecuteReader

            If DRX.HasRows Then
                temp = 1
                While DRX.Read()
                    cek_id_stockin.Add(DRX.Item("ID"))
                    cek_kirim_stockin.Add(DRX.Item("KIRIM"))
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

    Sub updateStockinNow()
        For i As Integer = 0 To cek_id_stockin.Count - 1
            If (Format(cek_kirim_stockin(i), "yyyy-MM-dd") < Format(Today, "yyyy-MM-dd") Or Format(cek_kirim_stockin(i), "yyyy-MM-dd") = Format(Today, "yyyy-MM-dd")) Then
                Me.ShowDialog()
                Exit For
            End If
        Next
    End Sub

    Function CekStockout()
        Dim cari As String = ""
        cari = TextBoxCariIn.Text
        Dim qs As String = "SELECT H.ID_STOCKOUT 'ID', H.TGL_KIRIM 'KIRIM', H.STATUS_STOK 'STATUS' FROM HSTOCKOUT H WHERE H.STATUS_STOK LIKE 'diproses' AND (H.TGL_KIRIM < '" & Format(Today, "yyyy-MM-dd") & "' OR H.TGL_KIRIM = '" & Format(Today, "yyyy-MM-dd") & "');"

        usernameku = Form1.username
        ds.Clear()
        Dim temp As Integer = 0
        Try
            conn = Form1.koneksi()
            Dim cmd = New MySqlCommand(qs, conn)
            Dim DRX As MySqlDataReader
            DRX = cmd.ExecuteReader

            If DRX.HasRows Then
                temp = 1
                While DRX.Read()
                    cek_id_stockout.Add(DRX.Item("ID"))
                    cek_kirim_stockout.Add(DRX.Item("KIRIM"))
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

    Sub updateStockoutNow()
        For i As Integer = 0 To cek_id_stockout.Count - 1
            If (Format(cek_kirim_stockout(i), "yyyy-MM-dd") < Format(Today, "yyyy-MM-dd") Or Format(cek_kirim_stockout(i), "yyyy-MM-dd") = Format(Today, "yyyy-MM-dd")) Then
                KirimPersediaan(cek_id_stockout(i))
                'cetakStockout(cek_id_stockout(i))
            End If
        Next
    End Sub

    Sub tampilHStockin()
        Dim cari As String = ""
        cari = TextBoxCariIn.Text
        Dim qs As String = "SELECT H.ID_STOCKIN 'ID', K.NAMA_KAR 'KARYAWAN', H.TGL_PESAN 'TGLPESAN', H.TGL_KIRIM 'TGLKIRIM', H.TGL_TERIMA 'TGLTERIMA', H.STATUS_STOK 'STATUS', H.REFERENSI 'REFERENSI', H.TOTAL 'TOTAL', H.TOTAL_ITEM 'TOTAL_ITEM', H.KETERANGAN 'KETERANGAN' FROM HSTOCKIN H, KARYAWAN K WHERE H.STATUS = 1 AND H.ID_KAR = K.ID_KAR ORDER BY STATUS"

        If RadioButton_id_IN.Checked Then
            qs = "SELECT H.ID_STOCKIN 'ID', K.NAMA_KAR 'KARYAWAN', H.TGL_PESAN 'TGLPESAN', H.TGL_KIRIM 'TGLKIRIM', H.TGL_TERIMA 'TGLTERIMA', H.STATUS_STOK 'STATUS', H.REFERENSI 'REFERENSI', H.TOTAL 'TOTAL', H.TOTAL_ITEM 'TOTAL_ITEM', H.KETERANGAN 'KETERANGAN'  FROM HSTOCKIN H, KARYAWAN K  WHERE H.STATUS = 1 AND H.ID_KAR = K.ID_KAR AND H.ID_STOCKIN LIKE '%" & TextBoxCariIn.Text & "%' ORDER  BY STATUS;"
        ElseIf RadioButtonRef_IN.Checked Then
            qs = "SELECT H.ID_STOCKIN 'ID', K.NAMA_KAR 'KARYAWAN', H.TGL_PESAN 'TGLPESAN', H.TGL_KIRIM 'TGLKIRIM', H.TGL_TERIMA 'TGLTERIMA', H.STATUS_STOK 'STATUS', H.REFERENSI 'REFERENSI', H.TOTAL 'TOTAL', H.TOTAL_ITEM 'TOTAL_ITEM', H.KETERANGAN 'KETERANGAN' FROM HSTOCKIN H, KARYAWAN K  WHERE H.STATUS = 1 AND H.ID_KAR = K.ID_KAR AND H.REFERENSI LIKE '%" & TextBoxCariIn.Text & "%' ORDER  BY STATUS;"
        ElseIf RadioButtonStatus_In.Checked Then
            qs = "SELECT H.ID_STOCKIN 'ID', K.NAMA_KAR 'KARYAWAN', H.TGL_PESAN 'TGLPESAN', H.TGL_KIRIM 'TGLKIRIM', H.TGL_TERIMA 'TGLTERIMA', H.STATUS_STOK 'STATUS', H.REFERENSI 'REFERENSI', H.TOTAL 'TOTAL', H.TOTAL_ITEM 'TOTAL_ITEM', H.KETERANGAN 'KETERANGAN' FROM HSTOCKIN H, KARYAWAN K  WHERE H.STATUS = 1 AND H.ID_KAR = K.ID_KAR AND H.STATUS_STOK LIKE '%" & TextBoxCariIn.Text & "%' ORDER  BY STATUS;"
        ElseIf RadioButtonTglKirim_IN.Checked Then
            qs = "SELECT H.ID_STOCKIN 'ID', K.NAMA_KAR 'KARYAWAN', H.TGL_PESAN 'TGLPESAN', H.TGL_KIRIM 'TGLKIRIM', H.TGL_TERIMA 'TGLTERIMA', H.STATUS_STOK 'STATUS', H.REFERENSI 'REFERENSI', H.TOTAL 'TOTAL', H.TOTAL_ITEM 'TOTAL_ITEM', H.KETERANGAN 'KETERANGAN' FROM HSTOCKIN H, KARYAWAN K  WHERE H.STATUS = 1 AND H.ID_KAR = K.ID_KAR AND H.TGL_KIRIM LIKE '%" & Format(DateTimePickerKirim_IN.Value, "yyyy-MM-dd") & "%' ORDER  BY STATUS;"
        ElseIf RadioButtonTglPesan_IN.Checked Then
            qs = "SELECT H.ID_STOCKIN 'ID', K.NAMA_KAR 'KARYAWAN', H.TGL_PESAN 'TGLPESAN', H.TGL_KIRIM 'TGLKIRIM', H.TGL_TERIMA 'TGLTERIMA', H.STATUS_STOK 'STATUS', H.REFERENSI 'REFERENSI', H.TOTAL 'TOTAL', H.TOTAL_ITEM 'TOTAL_ITEM', H.KETERANGAN 'KETERANGAN' FROM HSTOCKIN H, KARYAWAN K  WHERE H.STATUS = 1 AND H.ID_KAR = K.ID_KAR AND H.TGL_PESAN LIKE '%" & Format(DateTimePickerPesan_IN.Value, "yyyy-MM-dd") & "%' ORDER  BY STATUS;"
        End If

        usernameku = Form1.username
        ds.Clear()
        DataGridViewHStockin.Rows.Clear()
        DataGridViewDStockin.Rows.Clear()
        Dim temp As String = ""
        Try
            Dim id As String = ""
            Dim karyawan As String = ""
            Dim tglPesan As Date = Today
            Dim tglKirim As Date = Today
            Dim tglTerima As Date = Today
            Dim status As String = ""
            Dim ref As String = ""
            Dim total As Decimal = 0
            Dim TItem As Decimal = 0
            Dim ket As String = ""

            conn = Form1.koneksi()
            Dim cmd = New MySqlCommand(qs, conn)
            Dim DRX As MySqlDataReader
            DRX = cmd.ExecuteReader

            If DRX.HasRows Then
                While DRX.Read()
                    id = DRX.Item("ID")
                    karyawan = DRX.Item("KARYAWAN")
                    tglPesan = DRX.Item("TGLPESAN")
                    tglKirim = DRX.Item("TGLKIRIM")
                    tglTerima = DRX.Item("TGLTERIMA")
                    status = DRX.Item("STATUS")
                    ref = DRX.Item("REFERENSI")
                    total = DRX.Item("TOTAL")
                    TItem = DRX.Item("TOTAL_ITEM")
                    ket = DRX.Item("KETERANGAN")
                    If status = "diproses" Then
                        DataGridViewHStockin.Rows.Insert(DataGridViewHStockin.NewRowIndex, id, karyawan, Format(tglPesan, "dd-MM-yyyy"), Format(tglKirim, "dd-MM-yyyy"), "", ref, TItem, total, ket, status, "Detail")
                    Else
                        DataGridViewHStockin.Rows.Insert(DataGridViewHStockin.NewRowIndex, id, karyawan, Format(tglPesan, "dd-MM-yyyy"), Format(tglKirim, "dd-MM-yyyy"), Format(tglTerima, "dd-MM-yyyy"), ref, TItem, total, ket, status, "Detail")
                    End If

                End While
            Else
                MsgBox("Data tidak tersedia!")
            End If
            DRX.Close()
            conn.Close()
        Catch ex As Exception
            MsgBox("Tampilan HSTOCKIN bermasalah! " + ex.ToString)
        End Try
    End Sub

    Sub tampilDStockIn()
        usernameku = Form1.username
        ds.Clear()
        DataGridViewDStockin.Rows.Clear()
        Dim temp As String = ""
        Try
            Dim barang As String = ""
            Dim satuan As String = ""
            Dim qty As String = ""
            Dim nbaik As String = ""
            Dim nrusak As String = ""
            Dim hb As Decimal = 0
            Dim subtotal As Decimal = 0

            conn = Form1.koneksi()
            Dim qs As String = "SELECT B.NAMA_BRG 'BARANG', S.NAMA_SATUAN 'SATUAN', D.QTY 'QTY', D.N_BAIK 'KONDISI_BAIK', D.N_RUSAK 'KONDISI_RUSAK', D.HARGA_BELI 'HARGA_BELI', D.SUBTOTAL 'SUBTOTAL' FROM SATUAN S, BARANG B, DSTOCKIN D WHERE B.ID_BRG = D.ID_BRG And S.ID_SATUAN = B.ID_SATUAN AND D.ID_STOCKIN like '" & id_stockin & "'"
            Dim cmd = New MySqlCommand(qs, conn)
            Dim DRX As MySqlDataReader
            DRX = cmd.ExecuteReader

            If DRX.HasRows Then
                While DRX.Read()
                    barang = DRX.Item("BARANG")
                    satuan = DRX.Item("SATUAN")
                    qty = DRX.Item("QTY")
                    nbaik = DRX.Item("KONDISI_BAIK")
                    nrusak = DRX.Item("KONDISI_RUSAK")
                    hb = DRX.Item("HARGA_BELI")
                    subtotal = DRX.Item("SUBTOTAL")
                    DataGridViewDStockin.Rows.Insert(DataGridViewDStockin.NewRowIndex, barang, satuan, qty, nbaik, nrusak, hb, subtotal)
                End While
            Else
                MsgBox("Data tidak tersedia!")
            End If
            DRX.Close()
            conn.Close()
        Catch ex As Exception
            MsgBox("Tampilan DSTOK bermasalah! " + ex.ToString)
        End Try
    End Sub


    Sub tampilHStockOut()
        Dim cari As String = ""
        cari = TextBoxCariOut.Text
        Dim qs As String = "SELECT H.ID_STOCKOUT 'ID', K.NAMA_KAR 'KARYAWAN', H.TGL_PESAN 'TGLPESAN', H.TGL_KIRIM 'TGLKIRIM', H.STATUS_STOK 'STATUS', H.REFERENSI 'REFERENSI', H.TOTAL 'TOTAL', H.TOTAL_ITEM 'TOTAL_ITEM', H.KETERANGAN 'KETERANGAN' FROM HSTOCKOUT H, KARYAWAN K WHERE H.STATUS = 1 AND H.ID_KAR = K.ID_KAR ORDER BY STATUS"

        If RadioButtonID_Out.Checked Then
            qs = "SELECT H.ID_STOCKOUT 'ID', K.NAMA_KAR 'KARYAWAN', H.TGL_PESAN 'TGLPESAN', H.TGL_KIRIM 'TGLKIRIM', H.STATUS_STOK 'STATUS', H.REFERENSI 'REFERENSI', H.TOTAL 'TOTAL', H.TOTAL_ITEM 'TOTAL_ITEM', H.KETERANGAN 'KETERANGAN' FROM HSTOCKOUT H, KARYAWAN K WHERE H.STATUS = 1 AND H.ID_KAR = K.ID_KAR AND H.ID_STOCKOUT LIKE '%" & TextBoxCariOut.Text & "%' ORDER BY STATUS"
        ElseIf RadioButtonRef_Out.Checked Then
            qs = "SELECT H.ID_STOCKOUT 'ID', K.NAMA_KAR 'KARYAWAN', H.TGL_PESAN 'TGLPESAN', H.TGL_KIRIM 'TGLKIRIM', H.STATUS_STOK 'STATUS', H.REFERENSI 'REFERENSI', H.TOTAL 'TOTAL', H.TOTAL_ITEM 'TOTAL_ITEM', H.KETERANGAN 'KETERANGAN' FROM HSTOCKOUT H, KARYAWAN K WHERE H.STATUS = 1 AND H.ID_KAR = K.ID_KAR AND H.REFERENSI LIKE '%" & TextBoxCariOut.Text & "%' ORDER BY STATUS"
        ElseIf RadioButtonStatus_Out.Checked Then
            qs = "SELECT H.ID_STOCKOUT 'ID', K.NAMA_KAR 'KARYAWAN', H.TGL_PESAN 'TGLPESAN', H.TGL_KIRIM 'TGLKIRIM', H.STATUS_STOK 'STATUS', H.REFERENSI 'REFERENSI', H.TOTAL 'TOTAL', H.TOTAL_ITEM 'TOTAL_ITEM', H.KETERANGAN 'KETERANGAN' FROM HSTOCKOUT H, KARYAWAN K WHERE H.STATUS = 1 AND H.ID_KAR = K.ID_KAR AND H.STATUS_STOK LIKE '%" & TextBoxCariOut.Text & "%' ORDER BY STATUS"
        ElseIf RadioButtonTglKirim_Out.Checked Then
            qs = "SELECT H.ID_STOCKOUT 'ID', K.NAMA_KAR 'KARYAWAN', H.TGL_PESAN 'TGLPESAN', H.TGL_KIRIM 'TGLKIRIM', H.STATUS_STOK 'STATUS', H.REFERENSI 'REFERENSI', H.TOTAL 'TOTAL', H.TOTAL_ITEM 'TOTAL_ITEM', H.KETERANGAN 'KETERANGAN' FROM HSTOCKOUT H, KARYAWAN K WHERE H.STATUS = 1 AND H.ID_KAR = K.ID_KAR AND H.TGL_KIRIM LIKE '%" & Format(DateTimePickerTglKirim_Out.Value, "yyyy-MM-dd") & "%' ORDER BY STATUS"
        ElseIf RadioButtonTglPesan_Out.Checked Then
            qs = "SELECT H.ID_STOCKOUT 'ID', K.NAMA_KAR 'KARYAWAN', H.TGL_PESAN 'TGLPESAN', H.TGL_KIRIM 'TGLKIRIM', H.STATUS_STOK 'STATUS', H.REFERENSI 'REFERENSI', H.TOTAL 'TOTAL', H.TOTAL_ITEM 'TOTAL_ITEM', H.KETERANGAN 'KETERANGAN' FROM HSTOCKOUT H, KARYAWAN K WHERE H.STATUS = 1 AND H.ID_KAR = K.ID_KAR AND H.TGL_PESAN LIKE '%" & Format(DateTimePickerTglPesan_Out.Value, "yyyy-MM-dd") & "%' ORDER BY STATUS"
        End If

        usernameku = Form1.username
        ds.Clear()
        DataGridViewHStockout.Rows.Clear()
        Dim temp As String = ""
        Try
            Dim id As String = ""
            Dim karyawan As String = ""
            Dim tglPesan As Date = Today
            Dim tglKirim As Date = Today
            Dim tglTerima As Date = Today
            Dim status As String = ""
            Dim ref As String = ""
            Dim total As Decimal = 0
            Dim TItem As Decimal = 0
            Dim ket As String = ""

            conn = Form1.koneksi()
            Dim cmd = New MySqlCommand(qs, conn)
            Dim DRX As MySqlDataReader
            DRX = cmd.ExecuteReader

            If DRX.HasRows Then
                While DRX.Read()
                    id = DRX.Item("ID")
                    karyawan = DRX.Item("KARYAWAN")
                    tglPesan = DRX.Item("TGLPESAN")
                    tglKirim = DRX.Item("TGLKIRIM")
                    status = DRX.Item("STATUS")
                    ref = DRX.Item("REFERENSI")
                    total = DRX.Item("TOTAL")
                    TItem = DRX.Item("TOTAL_ITEM")
                    ket = DRX.Item("KETERANGAN")
                    Dim perbarui As String = ""
                    perbarui = DRX.Item("STATUS")

                    DataGridViewHStockout.Rows.Insert(DataGridViewHStockout.NewRowIndex, id, karyawan, Format(tglPesan, "dd-MM-yyyy"), Format(tglKirim, "dd-MM-yyyy"), ref, TItem, total, ket, status, "Detail")
                End While
            Else
                MsgBox("Data tidak tersedia!")
            End If
            DRX.Close()
            conn.Close()
        Catch ex As Exception
            MsgBox("Tampilan HSTOCKIN bermasalah! " + ex.ToString)
        End Try
    End Sub

    Sub tampilDStockOut()
        usernameku = Form1.username
        ds.Clear()
        DataGridViewDStockout.Rows.Clear()
        Dim temp As String = ""
        Try
            Dim barang As String = ""
            Dim satuan As String = ""
            Dim qty As String = ""
            Dim nbaik As String = ""
            Dim nrusak As String = ""
            Dim hb As Decimal = 0
            Dim subtotal As Decimal = 0

            conn = Form1.koneksi()
            Dim qs As String = "SELECT B.NAMA_BRG 'BARANG', S.NAMA_SATUAN 'SATUAN', D.QTY 'QTY', D.N_BAIK 'KONDISI_BAIK', D.N_RUSAK 'KONDISI_RUSAK', D.HARGA_BELI 'HARGA_BELI', D.SUBTOTAL 'SUBTOTAL' FROM SATUAN S, BARANG B, DSTOCKOUT D WHERE B.ID_BRG = D.ID_BRG And S.ID_SATUAN = B.ID_SATUAN AND D.ID_STOCKOUT like '" & id_stockout & "'"
            Dim cmd = New MySqlCommand(qs, conn)
            Dim DRX As MySqlDataReader
            DRX = cmd.ExecuteReader

            If DRX.HasRows Then
                While DRX.Read()
                    barang = DRX.Item("BARANG")
                    satuan = DRX.Item("SATUAN")
                    qty = DRX.Item("QTY")
                    nbaik = DRX.Item("KONDISI_BAIK")
                    nrusak = DRX.Item("KONDISI_RUSAK")
                    hb = DRX.Item("HARGA_BELI")
                    subtotal = DRX.Item("SUBTOTAL")
                    DataGridViewDStockout.Rows.Insert(DataGridViewDStockout.NewRowIndex, barang, satuan, qty, nbaik, nrusak, hb, subtotal)
                End While
            Else
                MsgBox("Data tidak tersedia!")
            End If
            DRX.Close()
            conn.Close()
        Catch ex As Exception
            MsgBox("Tampilan DSTOK bermasalah! " + ex.ToString)
        End Try
    End Sub

    Sub KirimPersediaan(id_out As String)
        Try
            conn = Form1.koneksi()
            Dim qs As String = "update hstockout set status_stok ='selesai' WHERE id_stockout = '" & id_out & "'"
            cmd = New MySqlCommand(qs, conn)
            cmd.ExecuteNonQuery()
            conn.Close()
            MsgBox("Faktur persediaan " + id_stockout + " dalam proses pengiriman!")
        Catch ex As Exception
            MsgBox("Faktur persediaan " + id_stockout + " gagal diubah!")
        End Try
    End Sub

    Sub formatTampilanGrid()
        For i As Integer = 0 To DataGridViewHStockin.Rows.Count - 1
            If i Mod 2 = 0 Then
                DataGridViewHStockin.Rows(i).Cells(0).Style.BackColor = Color.White
                DataGridViewHStockin.Rows(i).Cells(1).Style.BackColor = Color.White
                DataGridViewHStockin.Rows(i).Cells(2).Style.BackColor = Color.White
                DataGridViewHStockin.Rows(i).Cells(3).Style.BackColor = Color.White
                DataGridViewHStockin.Rows(i).Cells(4).Style.BackColor = Color.White
                DataGridViewHStockin.Rows(i).Cells(6).Style.BackColor = Color.White
                DataGridViewHStockin.Rows(i).Cells(7).Style.BackColor = Color.White
                DataGridViewHStockin.Rows(i).Cells(8).Style.BackColor = Color.White
                DataGridViewHStockin.Rows(i).Cells(9).Style.BackColor = Color.White
                DataGridViewHStockin.Rows(i).Cells(10).Style.BackColor = Color.White
            Else
                DataGridViewHStockin.Rows(i).Cells(0).Style.BackColor = Color.GreenYellow
                DataGridViewHStockin.Rows(i).Cells(1).Style.BackColor = Color.GreenYellow
                DataGridViewHStockin.Rows(i).Cells(2).Style.BackColor = Color.GreenYellow
                DataGridViewHStockin.Rows(i).Cells(3).Style.BackColor = Color.GreenYellow
                DataGridViewHStockin.Rows(i).Cells(4).Style.BackColor = Color.GreenYellow
                DataGridViewHStockin.Rows(i).Cells(5).Style.BackColor = Color.GreenYellow
                DataGridViewHStockin.Rows(i).Cells(6).Style.BackColor = Color.GreenYellow
                DataGridViewHStockin.Rows(i).Cells(7).Style.BackColor = Color.GreenYellow
                DataGridViewHStockin.Rows(i).Cells(8).Style.BackColor = Color.GreenYellow
                DataGridViewHStockin.Rows(i).Cells(9).Style.BackColor = Color.GreenYellow
                DataGridViewHStockin.Rows(i).Cells(10).Style.BackColor = Color.GreenYellow
            End If
            If DataGridViewHStockin.Rows(i).Cells(9).Value = "diproses" Then
                DataGridViewHStockin.Rows(i).Cells(0).Style.BackColor = Color.Yellow
                DataGridViewHStockin.Rows(i).Cells(1).Style.BackColor = Color.Yellow
                DataGridViewHStockin.Rows(i).Cells(2).Style.BackColor = Color.Yellow
                DataGridViewHStockin.Rows(i).Cells(3).Style.BackColor = Color.Yellow
                DataGridViewHStockin.Rows(i).Cells(4).Style.BackColor = Color.Yellow
                DataGridViewHStockin.Rows(i).Cells(5).Style.BackColor = Color.Yellow
                DataGridViewHStockin.Rows(i).Cells(6).Style.BackColor = Color.Yellow
                DataGridViewHStockin.Rows(i).Cells(7).Style.BackColor = Color.Yellow
                DataGridViewHStockin.Rows(i).Cells(8).Style.BackColor = Color.Yellow
                DataGridViewHStockin.Rows(i).Cells(9).Style.BackColor = Color.Yellow
                DataGridViewHStockin.Rows(i).Cells(10).Style.BackColor = Color.Yellow
            End If
        Next

        For i As Integer = 0 To DataGridViewHStockout.Rows.Count - 1
            If i Mod 2 = 0 Then
                DataGridViewHStockout.Rows(i).Cells(0).Style.BackColor = Color.White
                DataGridViewHStockout.Rows(i).Cells(1).Style.BackColor = Color.White
                DataGridViewHStockout.Rows(i).Cells(2).Style.BackColor = Color.White
                DataGridViewHStockout.Rows(i).Cells(3).Style.BackColor = Color.White
                DataGridViewHStockout.Rows(i).Cells(4).Style.BackColor = Color.White
                DataGridViewHStockout.Rows(i).Cells(6).Style.BackColor = Color.White
                DataGridViewHStockout.Rows(i).Cells(7).Style.BackColor = Color.White
                DataGridViewHStockout.Rows(i).Cells(8).Style.BackColor = Color.White
                DataGridViewHStockout.Rows(i).Cells(9).Style.BackColor = Color.White
            Else
                DataGridViewHStockout.Rows(i).Cells(0).Style.BackColor = Color.GreenYellow
                DataGridViewHStockout.Rows(i).Cells(1).Style.BackColor = Color.GreenYellow
                DataGridViewHStockout.Rows(i).Cells(2).Style.BackColor = Color.GreenYellow
                DataGridViewHStockout.Rows(i).Cells(3).Style.BackColor = Color.GreenYellow
                DataGridViewHStockout.Rows(i).Cells(4).Style.BackColor = Color.GreenYellow
                DataGridViewHStockout.Rows(i).Cells(5).Style.BackColor = Color.GreenYellow
                DataGridViewHStockout.Rows(i).Cells(6).Style.BackColor = Color.GreenYellow
                DataGridViewHStockout.Rows(i).Cells(7).Style.BackColor = Color.GreenYellow
                DataGridViewHStockout.Rows(i).Cells(8).Style.BackColor = Color.GreenYellow
                DataGridViewHStockout.Rows(i).Cells(9).Style.BackColor = Color.GreenYellow
            End If
            If DataGridViewHStockin.Rows(i).Cells(8).Value = "diproses" Then
                DataGridViewHStockout.Rows(i).Cells(0).Style.BackColor = Color.Yellow
                DataGridViewHStockout.Rows(i).Cells(1).Style.BackColor = Color.Yellow
                DataGridViewHStockout.Rows(i).Cells(2).Style.BackColor = Color.Yellow
                DataGridViewHStockout.Rows(i).Cells(3).Style.BackColor = Color.Yellow
                DataGridViewHStockout.Rows(i).Cells(4).Style.BackColor = Color.Yellow
                DataGridViewHStockout.Rows(i).Cells(5).Style.BackColor = Color.Yellow
                DataGridViewHStockout.Rows(i).Cells(6).Style.BackColor = Color.Yellow
                DataGridViewHStockout.Rows(i).Cells(7).Style.BackColor = Color.Yellow
                DataGridViewHStockout.Rows(i).Cells(8).Style.BackColor = Color.Yellow
                DataGridViewHStockout.Rows(i).Cells(9).Style.BackColor = Color.Yellow
            End If
        Next
    End Sub

    Private Sub Perbarui_Persediaan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tampilHStockin()
        tampilHStockOut()
        'formatTampilanGrid()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewHStockout.CellContentClick
        Try
            If DataGridViewHStockout.Rows(e.RowIndex).Cells(9).Value = "Detail" Then
                id_stockout = DataGridViewHStockout.Rows(e.RowIndex).Cells(0).Value
                status_stockout = DataGridViewHStockout.Rows(e.RowIndex).Cells(8).Value
                tampilDStockOut()
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        tampilHStockin()
    End Sub

    Private Sub ButtonCetak_Click(sender As Object, e As EventArgs) Handles ButtonCetak.Click
        Dim result As Integer = MessageBox.Show("Anda yakin mau cetak faktur " + id_stockin + " sekarang?", "Cetak Faktur " + id_stockin, MessageBoxButtons.YesNoCancel)
        If result = DialogResult.Cancel Then
            MessageBox.Show("Dibatalkan!")
        ElseIf result = DialogResult.No Then
        ElseIf result = DialogResult.Yes Then
            cetakStockin()
        End If
        'formatTampilanGrid()
    End Sub

    Sub cetakStockin()
        Dim cetak As New Preview
        cetak.id = id_stockin
        cetak.printWhat = "persediaan_masuk"
        cetak.ShowDialog()

        If refIN <> "" Then
            Dim cetak2 As New Preview
            cetak2.printWhat = "permintaan_barang"
            cetak2.id = refIN
            cetak2.id_PO = id_stockin
            cetak2.kepada = "staf gudang"
            cetak2.no = "2"
            cetak2.ShowDialog()
        End If
    End Sub

    Private Sub ButtonClear_Click(sender As Object, e As EventArgs) Handles ButtonClear.Click
        clearDataIn()
        'formatTampilanGrid()
    End Sub

    Sub clearDataOut()
        id_stockout = ""
        DataGridViewHStockout.Rows.Clear()
        DataGridViewDStockout.Rows.Clear()
        TextBoxCariOut.Text = ""
        DateTimePickerTglKirim_Out.Value = Today
        DateTimePickerTglPesan_Out.Value = Today
        tampilHStockOut()
    End Sub

    Sub clearDataIn()
        id_stockin = ""
        DataGridViewHStockin.Rows.Clear()
        DataGridViewDStockin.Rows.Clear()
        TextBoxCariIn.Text = ""
        DateTimePickerKirim_IN.Value = Today
        DateTimePickerPesan_IN.Value = Today
        tampilHStockin()
    End Sub

    Dim refIN As String = ""
    Private Sub DataGridViewHStockin_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewHStockin.CellContentClick
        Try
            If DataGridViewHStockin.Rows(e.RowIndex).Cells(10).Value = "Detail" Then
                id_stockin = DataGridViewHStockin.Rows(e.RowIndex).Cells(0).Value
                refIN = DataGridViewHStockin.Rows(e.RowIndex).Cells(5).Value.ToString
                status_stockin = DataGridViewHStockin.Rows(e.RowIndex).Cells(9).Value
                tampilDStockIn()
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim result As Integer = MessageBox.Show("Anda yakin mau cetak faktur " + id_stockout + " sekarang?", "Cetak Faktur " + id_stockout, MessageBoxButtons.YesNoCancel)
        If result = DialogResult.Cancel Then
            MessageBox.Show("Dibatalkan!")
        ElseIf result = DialogResult.No Then
        ElseIf result = DialogResult.Yes Then
            cetakStockout(id_stockout)
        End If
        'formatTampilanGrid()
    End Sub

    Sub cetakStockout(id As String)
        Dim cetak As New Preview
        cetak.id = id
        cetak.no = "1"
        cetak.kepada = "staf gudang"
        cetak.printWhat = "persediaan_keluar"
        cetak.ShowDialog()

        Dim cetak2 As New Preview
        cetak2.id = id
        cetak2.no = "2"
        cetak2.kepada = "kurir"
        cetak2.printWhat = "surat_jalan"
        cetak2.ShowDialog()
    End Sub

    Sub kirim()
        Dim result As Integer = MessageBox.Show("Anda yakin mau kirim pesanan " + id_stockout + " sekarang?", "Kirim Pesanan " + id_stockout, MessageBoxButtons.YesNoCancel)
        If result = DialogResult.Cancel Then
            MessageBox.Show("Dibatalkan!")
        ElseIf result = DialogResult.No Then
        ElseIf result = DialogResult.Yes Then
            If status_stockout = "selesai" Then
                MsgBox("Barang pesanan telah dikirim!")
            Else
                KirimPersediaan(id_stockout)
                tampilHStockOut()
                cetakStockout(id_stockout)
                clearDataOut()
            End If
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        kirim()
        clearDataOut()
        'formatTampilanGrid()
    End Sub
    Sub terima()
        Dim result As Integer = MessageBox.Show("Anda yakin menerima pesanan " + id_stockin + " sekarang?", "Terima Pesanan " + id_stockin, MessageBoxButtons.YesNoCancel)
        If result = DialogResult.Cancel Then
            MessageBox.Show("Dibatalkan!")
        ElseIf result = DialogResult.No Then
        ElseIf result = DialogResult.Yes Then

            If status_stockin = "selesai" Then
                MsgBox("Pesanan barang telah diterima!")
            Else
                If refIN = "" Then
                    MsgBox("Pesanan barang anda tidak mempunyai referensi!")
                Else
                    Dim stok As New stok
                    stok.RadioButtonOut.Enabled = False
                    stok.RadioButtonIn.Checked = True
                    stok.DateTimePickerTgl.Enabled = False
                    stok.DateTimePickerKirim.Enabled = False
                    stok.TextBoxRef.Enabled = False
                    stok.IsTerima = 1
                    stok.tampilBarang("", refIN, 1)
                    stok.id_stockin = id_stockin
                    stok.TextBoxRef.Text = refIN
                    stok.ShowDialog()
                End If
            End If
        End If
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        terima()
        clearDataIn()
        'formatTampilanGrid()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim brg As New barang
        brg.ShowDialog()
        'formatTampilanGrid()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        clearDataOut()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        tampilHStockOut()
    End Sub

    Private Sub DataGridViewHStockin_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewHStockin.CellClick
        Try
            id_stockin = DataGridViewHStockin.Rows(e.RowIndex).Cells(0).Value
            refIN = DataGridViewHStockin.Rows(e.RowIndex).Cells(5).Value.ToString
        Catch ex As Exception
        End Try
    End Sub

    Private Sub DataGridViewHStockout_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewHStockout.CellClick
        Try
            id_stockout = DataGridViewHStockout.Rows(e.RowIndex).Cells(0).Value
        Catch ex As Exception
        End Try
    End Sub
End Class