Imports System.Xml

Public Class koneksi_konf
    Public Function getKoneksiKonfigurasi()
        Dim result As String = ""
        Try
            Dim xmlFile As XmlReader
            xmlFile = XmlReader.Create(Application.StartupPath + "/xml/koneksi.xml", New XmlReaderSettings())
            Dim ds As New DataSet
            Dim dv As DataView
            ds.ReadXml(xmlFile)

            Dim dt As DataTable = ds.Tables("koneksi")
            dv = New DataView(ds.Tables("koneksi"))
            result = dv(0)("server").ToString
            result = result + "-" + dv(0)("database").ToString
            result = result + "-" + dv(0)("username").ToString
            result = result + "-" + dv(0)("password").ToString
            xmlFile.Close()
        Catch ex As Exception
            MsgBox("Tampilan koneksi bermasalah!")
        End Try
        Return result
    End Function

    Sub tampilKoneksi()
        Dim arrKoneksi() As String
        Dim result As String = getKoneksiKonfigurasi()
        'MsgBox(result)
        arrKoneksi = result.Split("-")
        TextBoxServer.Text = arrKoneksi(0)
        TextBoxDB.Text = arrKoneksi(1)
        TextBoxUsername.Text = arrKoneksi(2)
        TextBoxPass.Text = arrKoneksi(3)
    End Sub

    Public Sub SaveKoneksi()
        Dim paswd As String = ""
        Dim repasswd As String = ""
        Try
            If TextBoxPass.Text = "" And TextBoxRePass.Text = "" Then
                paswd = ""
                repasswd = ""
            Else
                paswd = TextBoxPass.Text
                repasswd = TextBoxRePass.Text
            End If

            If repasswd = paswd Then
                Dim xmlset As New XmlWriterSettings
                xmlset.Indent = True
                Dim writer As XmlWriter = XmlWriter.Create(Application.StartupPath + "\xml\koneksi.xml", xmlset)
                writer.WriteStartDocument()
                writer.WriteStartElement("koneksi")
                writer.WriteElementString("username", TextBoxUsername.Text)
                writer.WriteElementString("password", paswd)
                writer.WriteElementString("server", TextBoxServer.Text)
                writer.WriteElementString("database", TextBoxDB.Text)
                writer.WriteEndElement()
                writer.Close()
                MsgBox("Konfigurasi koneksi berhasil disimpan!")
            Else
                MsgBox("Password dan re-password tidak sama!")
            End If
        Catch ex As Exception
            MsgBox("Konfigurisi koneksi gagal disimpan!" + ex.ToString)
        End Try
    End Sub

    Private Sub koneksi_konf_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tampilKoneksi()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        SaveKoneksi()
        tampilKoneksi()
    End Sub
End Class