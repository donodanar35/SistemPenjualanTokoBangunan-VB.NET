Imports MySql.Data.MySqlClient
Public Class konf_user
    Public conn As MySqlConnection
    Public cmd As MySqlCommand
    Public da As MySqlDataAdapter
    Public dt As New DataTable("kategori")
    Public ds As New DataSet
    Public DR As MySqlDataReader
    Public usernameku As String = TokoMaterial.username

    Sub tampilKaryawan()
        DataGridView1.DataSource = Nothing
        ds.Clear()
        Try
            conn = Form1.koneksi()
            Dim qs As String = "Select id_kar, nama_kar, jabatan, ket_kar From karyawan where id_kar = '" & usernameku & "'"
            da = New MySqlDataAdapter(qs, conn)
            da.Fill(ds, 0)
            dt = ds.Tables(0)
            DataGridView1.DataSource = dt
            conn.Close()
        Catch ex As Exception
            MsgBox("Tampilan karyawan bermasalah! " + ex.ToString)
        End Try
    End Sub

    Sub ubahKaryawan()
        If TextBoxPass.Text = TextBoxRePass.Text Then
            Try
                Dim passwordMD5 As String = Form1.getMD5Hash(TextBoxPass.Text)
                conn = Form1.koneksi()
                Dim qs As String = "update karyawan set NAMA_KAR ='" & TextBoxNama.Text & "',PASSWORD ='" & passwordMD5 & "', KET_KAR = '" & TextBoxKet.Text & "' WHERE ID_KAR = '" & usernameku & "'"
                cmd = New MySqlCommand(qs, conn)
                cmd.ExecuteNonQuery()
                conn.Close()
                MsgBox("Edit data pengguna berhasil dilakukan!")
            Catch ex As Exception
                MsgBox("Edit data pengguna gagal dilakukan!")
            End Try
        Else
            MsgBox("Password dan re-Password tidak sama!")
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ubahKaryawan()
        tampilKaryawan()
    End Sub

    Private Sub konf_user_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tampilKaryawan()
    End Sub

    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        Try
            TextBoxUsername.Text = DataGridView1.Rows(e.RowIndex).Cells(0).Value.ToString
            TextBoxNama.Text = DataGridView1.Rows(e.RowIndex).Cells(1).Value.ToString
            TextBoxKet.Text = DataGridView1.Rows(e.RowIndex).Cells(3).Value.ToString
        Catch ex As Exception
        End Try
    End Sub
End Class