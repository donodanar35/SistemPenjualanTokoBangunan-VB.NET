Imports MySql.Data.MySqlClient
Public Class Kategori
    Public conn As MySqlConnection
    Public cmd As MySqlCommand
    Public da As MySqlDataAdapter
    Public dt As New DataTable("kategori")
    Public ds As New DataSet
    Public DR As MySqlDataReader

    Function No()
        Dim temp As Integer
        Try
            conn = Form1.koneksi()
            Dim str As String
            str = "select count(*) 'no' from kategori"
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

    Sub tampilKategori()
        DataGridView1.DataSource = Nothing
        ds.Clear()
        Try
            conn = Form1.koneksi()
            Dim qs As String = "Select id_kat 'ID', nama_kat 'Kategori', ket_kat 'Keterangan' From kategori where status = 1 ORDER BY ID"
            da = New MySqlDataAdapter(qs, conn)
            da.Fill(ds, 0)
            dt = ds.Tables(0)
            DataGridView1.DataSource = dt
            conn.Close()
        Catch ex As Exception
            MsgBox("Tampil satuan bermasalah! " + ex.ToString)
        End Try
    End Sub

    Sub tambahKategori()
        Dim indeks As Integer = No()
        Try
            conn = Form1.koneksi()
            Dim qs As String = "insert into kategori(ID_KAT,NAMA_KAT,KET_KAT,STATUS) VALUES('kat" & indeks & "','" & TextBoxKetegori.Text & "','" & TextBoxKet.Text & "',1)"
            cmd = New MySqlCommand(qs, conn)
            cmd.ExecuteNonQuery()
            conn.Close()
            MsgBox("Tambah kategori berhasil dilakukan!")
        Catch ex As Exception
            MsgBox("Tambah data kategori gagal dilakukan!")
        End Try
    End Sub

    Sub ubahKategori()
        Try
            conn = Form1.koneksi()
            Dim qs As String = "update kategori set NAMA_KAT ='" & TextBoxKetegori.Text & "',KET_KAT ='" & TextBoxKet.Text & "',STATUS=1 WHERE NAMA_KAT = '" & TextBoxKetegori.Text & "'"
            cmd = New MySqlCommand(qs, conn)
            cmd.ExecuteNonQuery()
            conn.Close()
            MsgBox("Edit data kategori berhasil dilakukan!")
        Catch ex As Exception
            MsgBox("Edit data kategori gagal dilakukan!")
        End Try
    End Sub

    Sub hapusKategori()
        Try
            conn = Form1.koneksi()
            Dim qs As String = "update kategori set NAMA_KAT ='" & TextBoxKetegori.Text & "',KET_KAT ='" & TextBoxKet.Text & "',STATUS=0 WHERE NAMA_KAT = '" & TextBoxKetegori.Text & "'"
            cmd = New MySqlCommand(qs, conn)
            cmd.ExecuteNonQuery()
            conn.Close()
            MsgBox("Hapus data kategori berhasil dilakukan!")
        Catch ex As Exception
            MsgBox("Hapus data kategori gagal dilakukan!")
        End Try
    End Sub

    Sub ClearData()
        TextBoxKet.Text = ""
        TextBoxKetegori.Text = ""
    End Sub


    Private Sub Kategori_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tampilKategori()
        formatTampilanGrid()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        tambahKategori()
        tampilKategori()
        ClearData()
        formatTampilanGrid()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ubahKategori()
        tampilKategori()
        ClearData()
        formatTampilanGrid()
    End Sub

    Private Sub Hapus_Click(sender As Object, e As EventArgs) Handles Hapus.Click
        hapusKategori()
        tampilKategori()
        ClearData()
        formatTampilanGrid()
    End Sub

    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        Try
            TextBoxKetegori.Text = DataGridView1.Rows(e.RowIndex).Cells(1).Value.ToString
            TextBoxKet.Text = DataGridView1.Rows(e.RowIndex).Cells(2).Value.ToString
        Catch ex As Exception
        End Try
    End Sub

    Sub formatTampilanGrid()
        For i As Integer = 0 To DataGridView1.Rows.Count - 1
            If i Mod 2 = 0 Then
                DataGridView1.Rows(i).Cells(0).Style.BackColor = Color.White
                DataGridView1.Rows(i).Cells(1).Style.BackColor = Color.White
                DataGridView1.Rows(i).Cells(2).Style.BackColor = Color.White
            Else
                DataGridView1.Rows(i).Cells(0).Style.BackColor = Color.GreenYellow
                DataGridView1.Rows(i).Cells(1).Style.BackColor = Color.GreenYellow
                DataGridView1.Rows(i).Cells(2).Style.BackColor = Color.GreenYellow
            End If
        Next
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ClearData()
    End Sub
End Class