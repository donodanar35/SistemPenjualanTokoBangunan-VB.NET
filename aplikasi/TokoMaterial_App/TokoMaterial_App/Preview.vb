Public Class Preview
    Public printWhat As String = ""
    Public id As String = ""
    Public awal As Date = Today
    Public akhir As Date = Today
    Public no As String = ""
    Public kepada As String = ""
    Public id_PO As String = ""
    Private Sub CrystalReportViewer1_Load(sender As Object, e As EventArgs) Handles CrystalReportViewer1.Load
        'MsgBox(printWhat + " " + id)
        Try
            If printWhat = "pembelian" Then
                Dim rp As New CrNotaPembelian
                rp.SetParameterValue("id_beli", id)
                rp.SetParameterValue("no", no)
                rp.SetParameterValue("kepada", kepada)
                CrystalReportViewer1.ReportSource = rp
                CrystalReportViewer1.Refresh()
            ElseIf printWhat = "sampel" Then
                Dim rp As New CrNotaSampel
                rp.SetParameterValue("id_sampel", id)
                rp.SetParameterValue("no", no)
                rp.SetParameterValue("kepada", kepada)
                CrystalReportViewer1.ReportSource = rp
                CrystalReportViewer1.Refresh()
            ElseIf printWhat = "penjualan" Then
                Dim rp As New CrNotaPenjualan
                rp.SetParameterValue("id_jual", id)
                rp.SetParameterValue("no", no)
                rp.SetParameterValue("kepada", kepada)
                CrystalReportViewer1.ReportSource = rp
                CrystalReportViewer1.Refresh()
            ElseIf printWhat = "diskon" Then
                Dim rp As New CrDiskon
                rp.SetParameterValue("id", id)
                CrystalReportViewer1.ReportSource = rp
                CrystalReportViewer1.Refresh()
            ElseIf printWhat = "persediaan_masuk" Then
                Dim rp As New CrPersediaanMasuk
                rp.SetParameterValue("id", id)
                CrystalReportViewer1.ReportSource = rp
                CrystalReportViewer1.Refresh()
            ElseIf printWhat = "persediaan_keluar" Then
                Dim rp As New CrPersediaanKeluar
                rp.SetParameterValue("id", id)
                rp.SetParameterValue("no", no)
                rp.SetParameterValue("kepada", kepada)
                CrystalReportViewer1.ReportSource = rp
                CrystalReportViewer1.Refresh()
            ElseIf printWhat = "surat_jalan" Then
                Dim rp As New CrSuratJalan_DO
                rp.SetParameterValue("id", id)
                rp.SetParameterValue("no", no)
                rp.SetParameterValue("kepada", kepada)
                CrystalReportViewer1.ReportSource = rp
                CrystalReportViewer1.Refresh()
            ElseIf printWhat = "permintaan_barang" Then
                Dim rp As New CrPermintaanBarang
                rp.SetParameterValue("ID_BELI", id)
                rp.SetParameterValue("ID_STOCKIN", id_PO)
                rp.SetParameterValue("no", no)
                rp.SetParameterValue("kepada", kepada)
                CrystalReportViewer1.ReportSource = rp
                CrystalReportViewer1.Refresh()
            ElseIf printWhat = "top_item" Then
                Dim rp As New CrTopBarang
                CrystalReportViewer1.ReportSource = rp
                CrystalReportViewer1.Refresh()
            ElseIf printWhat = "top_supplier" Then
                Dim rp As New CrTopSupplier
                CrystalReportViewer1.ReportSource = rp
                CrystalReportViewer1.Refresh()
            ElseIf printWhat = "top_customer" Then
                Dim rp As New CrTopCustomer
                CrystalReportViewer1.ReportSource = rp
                CrystalReportViewer1.Refresh()
            ElseIf printWhat = "Penjualan Periodik" Then
                Dim rp As New CrPenjualanPeriodik
                rp.SetParameterValue("awal", awal)
                rp.SetParameterValue("akhir", akhir)
                CrystalReportViewer1.ReportSource = rp
                CrystalReportViewer1.Refresh()
            ElseIf printWhat = "Pembelian Periodik" Then
                Dim rp As New CrPembelianPeriodik
                rp.SetParameterValue("awal", awal)
                rp.SetParameterValue("akhir", akhir)
                CrystalReportViewer1.ReportSource = rp
                CrystalReportViewer1.Refresh()
            ElseIf printWhat = "Sampel Periodik" Then
                Dim rp As New CrSampelPeriodik
                rp.SetParameterValue("awal", awal)
                rp.SetParameterValue("akhir", akhir)
                CrystalReportViewer1.ReportSource = rp
                CrystalReportViewer1.Refresh()
            ElseIf printWhat = "Promo Aktual" Then
                Dim rp As New CrPromoAktual
                rp.SetParameterValue("akhir", akhir)
                CrystalReportViewer1.ReportSource = rp
                CrystalReportViewer1.Refresh()
            ElseIf printWhat = "Stok Barang" Then
                Dim rp As New CrPersediaanAktual
                CrystalReportViewer1.ReportSource = rp
                CrystalReportViewer1.Refresh()
            ElseIf printWhat = "daftar barang" Then
                Dim rp As New CrDaftarBarang
                CrystalReportViewer1.ReportSource = rp
                CrystalReportViewer1.Refresh()
            ElseIf printWhat = "daftar suplier" Then
                Dim rp As New CrDaftarSuplier
                CrystalReportViewer1.ReportSource = rp
                CrystalReportViewer1.Refresh()
            ElseIf printWhat = "daftar customer" Then
                Dim rp As New CrDaftarCustomer
                CrystalReportViewer1.ReportSource = rp
                CrystalReportViewer1.Refresh()
            ElseIf printWhat = "Persediaan Masuk Periodik" Then
                MsgBox("masuk")
                Dim rp As New CrDaftarPersediaanMasuk
                rp.SetParameterValue("awal", awal)
                rp.SetParameterValue("akhir", akhir)
                CrystalReportViewer1.ReportSource = rp
                CrystalReportViewer1.Refresh()
            ElseIf printWhat = "Persediaan Keluar Periodik" Then
                MsgBox("keluar")
                Dim rp As New CrDaftarPersediaanKeluar
                rp.SetParameterValue("awal", awal)
                rp.SetParameterValue("akhir", akhir)
                CrystalReportViewer1.ReportSource = rp
                CrystalReportViewer1.Refresh()
            End If
        Catch ex As Exception
            MsgBox("cetak error! " + ex.ToString)
        End Try
    End Sub

    Private Sub Preview_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class