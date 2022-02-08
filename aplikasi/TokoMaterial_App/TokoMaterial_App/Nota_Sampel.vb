Public Class Nota_Sampel

    Private Sub Nota_Sampel_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub CrystalReportViewer1_Load(sender As Object, e As EventArgs) Handles CrystalReportViewer1.Load
        Dim no As String = sampel.id_sampel
        MsgBox(no)
    End Sub
End Class