Public Class Laporan

    Public printApa As String = "Penjualan Periodik"
    Private Sub ButtonCetak_Click(sender As Object, e As EventArgs) Handles ButtonCetak.Click
        Dim cetak As New Preview
        cetak.printWhat = printApa
        cetak.awal = DateTimePickerAwal.Value
        cetak.akhir = DateTimePickerAkir.Value
        If printApa = "Promo Aktual" Then
            cetak.akhir = Today
        End If
        cetak.ShowDialog()
    End Sub

    Private Sub Laporan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GroupBoxLaporan.Text = "Laporan " + printApa
        If printApa = "Promo Aktual" Then
            Label1.Visible = False
            Label2.Visible = False
            DateTimePickerAwal.Visible = False
            DateTimePickerAkir.Visible = False
        End If
    End Sub
End Class