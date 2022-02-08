Imports MySql.Data.MySqlClient
Public Class karyawan
    Public conn As MySqlConnection
    Public cmd As MySqlCommand
    Public da As MySqlDataAdapter
    Public dt As New DataTable("kategori")
    Public ds As New DataSet
    Public DR As MySqlDataReader
    Public id As String

    Function No()
        Dim temp As Integer
        Try
            conn = Form1.koneksi()
            Dim str As String
            str = "select count(*) 'no' from karyawan"
            Dim cmd = New MySqlCommand(str, conn)
            DR = cmd.ExecuteReader

            If DR.HasRows Then
                While DR.Read()
                    temp = DR.Item("no") + 1
                End While
            Else
                temp = 1
            End If
            DR.Close()
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
            MessageBox.Show("Indexing gagal dilakukan!")
        End Try
        Return temp
    End Function

    Sub tampilKaryawan()
        DataGridView1.DataSource = Nothing
        ds.Clear()
        Try
            conn = Form1.koneksi()
            Dim qs As String = "Select id_kar 'Username', nama_kar 'Karyawan', jabatan 'Jabatan', password 'Password', ket_kar 'Keterangan' From karyawan where status = 1 ORDER BY Username"
            da = New MySqlDataAdapter(qs, conn)
            da.Fill(ds, 0)
            dt = ds.Tables(0)
            DataGridView1.DataSource = dt
            conn.Close()
        Catch ex As Exception
            MsgBox("Tampilan karyawan bermasalah! " + ex.ToString)
        End Try
    End Sub

    Sub tambahKaryawan()
        Dim indeks As Integer = No()
        If TextBoxPass.Text = TextBoxRePass.Text Then
            Try
                Dim passwordMD5 As String = Form1.getMD5Hash(TextBoxPass.Text)
                conn = Form1.koneksi()
                Dim qs As String = "insert into karyawan(id_kar, nama_kar,password, jabatan,status,ket_kar) VALUES('kar" & indeks & "','" & TextBoxNama.Text & "','" & passwordMD5 & "','" & ComboBoxJabatan.Text & "',1,'" & TextBoxKet.Text & "')"
                cmd = New MySqlCommand(qs, conn)
                cmd.ExecuteNonQuery()
                conn.Close()
                MsgBox("Tambah data karyawan berhasil dilakukan!")
            Catch ex As Exception
                MsgBox("Tambah data karyawan gagal dilakukan!")
            End Try
        Else
            MsgBox("Password dan re-Password tidak sama!")
        End If
    End Sub

    Sub ubahKaryawan()
        If TextBoxPass.Text = TextBoxRePass.Text Then
            Try
                Dim passwordMD5 As String = Form1.getMD5Hash(TextBoxPass.Text)
                conn = Form1.koneksi()
                Dim qs As String = "update karyawan set NAMA_KAR ='" & TextBoxNama.Text & "',PASSWORD ='" & passwordMD5 & "', JABATAN = '" & ComboBoxJabatan.SelectedItem.ToString & "', KET_KAR = '" & TextBoxKet.Text & "' WHERE ID_KAR = '" & TextBoxUsername.Text & "'"
                cmd = New MySqlCommand(qs, conn)
                cmd.ExecuteNonQuery()
                conn.Close()
                MsgBox("Edit data karyawan berhasil dilakukan!")
            Catch ex As Exception
                MsgBox("Edit data karyawan gagal dilakukan!")
            End Try
        Else
            MsgBox("Password dan re-Password tidak sama!")
        End If
    End Sub

    Sub hapusKaryawan()
        Try
            conn = Form1.koneksi()
            Dim qs As String = "update karyawan set NAMA_KAR ='" & TextBoxNama.Text & "',STATUS=0 WHERE ID_KAR = '" & TextBoxUsername.Text & "'"
            cmd = New MySqlCommand(qs, conn)
            cmd.ExecuteNonQuery()
            conn.Close()
            MsgBox("Hapus data karyawan berhasil dilakukan!")
        Catch ex As Exception
            MsgBox("Hapus data karyawan gagal dilakukan!")
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        tambahKaryawan()
        tampilKaryawan()
        clearData()
        formatTampilanGrid()
    End Sub

    Private Sub karyawan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tampilKaryawan()
        tampilId()
        formatTampilanGrid()
    End Sub


    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        Try
            TextBoxUsername.Text = DataGridView1.Rows(e.RowIndex).Cells(0).Value.ToString
            TextBoxNama.Text = DataGridView1.Rows(e.RowIndex).Cells(1).Value.ToString
            TextBoxKet.Text = DataGridView1.Rows(e.RowIndex).Cells(4).Value.ToString
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ubahKaryawan()
        tampilKaryawan()
        formatTampilanGrid()
    End Sub

    Private Sub Hapus_Click(sender As Object, e As EventArgs) Handles Hapus.Click
        hapusKaryawan()
        tampilKaryawan()
        formatTampilanGrid()
    End Sub

    Sub clearData()
        TextBoxCari.Text = ""
        TextBoxNama.Text = ""
        TextBoxKet.Text = ""
        TextBoxPass.Text = ""
        TextBoxUsername.Text = ""
        TextBoxRePass.Text = ""
        ComboBoxJabatan.Refresh()
        tampilKaryawan()
    End Sub

    Sub tampilId()
        Dim temp As Integer = No()
        id = "kar" + temp.ToString
        TextBoxUsername.Text = id
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        clearData()
        formatTampilanGrid()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        tampilKaryawan()
        tampilId()
        formatTampilanGrid()
    End Sub

    Sub formatTampilanGrid()
        For i As Integer = 0 To DataGridView1.Rows.Count - 1
            If i Mod 2 = 0 Then
                DataGridView1.Rows(i).Cells(0).Style.BackColor = Color.White
                DataGridView1.Rows(i).Cells(1).Style.BackColor = Color.White
                DataGridView1.Rows(i).Cells(2).Style.BackColor = Color.White
                DataGridView1.Rows(i).Cells(3).Style.BackColor = Color.White
                DataGridView1.Rows(i).Cells(4).Style.BackColor = Color.White
            Else
                DataGridView1.Rows(i).Cells(0).Style.BackColor = Color.GreenYellow
                DataGridView1.Rows(i).Cells(1).Style.BackColor = Color.GreenYellow
                DataGridView1.Rows(i).Cells(2).Style.BackColor = Color.GreenYellow
                DataGridView1.Rows(i).Cells(3).Style.BackColor = Color.GreenYellow
                DataGridView1.Rows(i).Cells(4).Style.BackColor = Color.GreenYellow
            End If
        Next
    End Sub

    Sub CariKaryawan()
        DataGridView1.DataSource = Nothing
        ds.Clear()
        Dim berdasarkan As String = "nama"
        If RadioButton_Username.Checked Then
            berdasarkan = "username"
        ElseIf RadioButton_Nama.Checked Then
            berdasarkan = "nama"
        ElseIf RadioButton_Jabatan.Checked Then
            berdasarkan = "jabatan"
        ElseIf RadioButton_Ket.Checked Then
            berdasarkan = "keterangan"
        End If

        Dim qs As String = "Select id_kar 'Username', nama_kar 'Karyawan', jabatan 'Jabatan', password 'Password', ket_kar 'Keterangan' From karyawan where status = 1 ORDER BY Username"
        If berdasarkan = "username" Then
            qs = "Select id_kar 'Username', nama_kar 'Karyawan', jabatan 'Jabatan', password 'Password', ket_kar 'Keterangan' From karyawan where status = 1  AND Id_kar like '%" & TextBoxCari.Text & "%' ORDER BY Username"
        ElseIf berdasarkan = "nama" Then
            qs = "Select id_kar 'Username', nama_kar 'Karyawan', jabatan 'Jabatan', password 'Password', ket_kar 'Keterangan' From karyawan where status = 1 AND nama_kar like '%" & TextBoxCari.Text & "%' ORDER BY Username"
        ElseIf berdasarkan = "jabatan" Then
            qs = "Select id_kar 'Username', nama_kar 'Karyawan', jabatan 'Jabatan', password 'Password', ket_kar 'Keterangan' From karyawan where status = 1 AND jabatan like '%" & TextBoxCari.Text & "%' ORDER BY Username"
        ElseIf berdasarkan = "keterangan" Then
            qs = "Select id_kar 'Username', nama_kar 'Karyawan', jabatan 'Jabatan', password 'Password', ket_kar 'Keterangan' From karyawan where status = 1 AND ket_kar like '%" & TextBoxCari.Text & "%' ORDER BY username"
        Else
            qs = "Select id_kar 'Username', nama_kar 'Karyawan', jabatan 'Jabatan', password 'Password', ket_kar 'Keterangan' From karyawan where status = 1"
        End If
        Try
            conn = Form1.koneksi()
            da = New MySqlDataAdapter(qs, conn)
            da.Fill(ds, 0)
            dt = ds.Tables(0)
            DataGridView1.DataSource = dt
            conn.Close()
        Catch ex As Exception
            MsgBox("Tampilan karyawan bermasalah! " + ex.ToString)
        End Try
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        CariKaryawan()
        formatTampilanGrid()
    End Sub
End Class