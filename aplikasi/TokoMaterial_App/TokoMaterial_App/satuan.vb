Imports MySql.Data.MySqlClient
Public Class satuan
    Public conn As MySqlConnection
    Public cmd As MySqlCommand
    Public da As MySqlDataAdapter
    Public dt As New DataTable("satuan")
    Public ds As New DataSet
    Public DR As MySqlDataReader

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        tambahsatuan()
        tampilSatuan()
        clearData()
        formatTampilanGrid()
    End Sub

    Function No()
        Dim temp As Integer
        Try
            conn = Form1.koneksi()
            Dim str As String
            str = "select count(*) 'no' from satuan"
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

    Sub tambahsatuan()
        Try
            Dim indeks As Integer = 0
            indeks = No()
            If TextBoxSatuan.Text <> "" Then
                conn = Form1.koneksi()
                Dim qs As String = "insert into satuan(ID_SATUAN,NAMA_SATUAN,KET_SATUAN,STATUS) VALUES('" & "sat" & indeks & "','" & TextBoxSatuan.Text & "','" & TextBoxKet.Text & "',1)"
                cmd = New MySqlCommand(qs, conn)
                cmd.ExecuteNonQuery()
                conn.Close()
                MsgBox("Tambah satuan berhasil dilakukan!")
            Else
                MsgBox("Satuan belum diisi!")
            End If
        Catch ex As Exception
            MsgBox("Tambah data satuan gagal dilakukan! " + ex.ToString)
        End Try
    End Sub

    Sub tampilSatuan()
        DataGridView1.DataSource = Nothing
        ds.Clear()
        Try
            conn = Form1.koneksi()
            Dim qs As String = "Select id_satuan 'ID', nama_satuan 'Satuan', ket_satuan 'Keterangan' From satuan where status = 1 ORDER BY ID"
            da = New MySqlDataAdapter(qs, conn)
            da.Fill(ds, 0)
            dt = ds.Tables(0)
            DataGridView1.DataSource = dt
            conn.Close()
        Catch ex As Exception
            MsgBox("Tampil satuan bermasalah! " + ex.ToString)
        End Try
    End Sub

    Sub ubahSatuan()
        Try
            conn = Form1.koneksi()
            Dim qs As String = "update satuan set NAMA_SATUAN = '" & TextBoxSatuan.Text & "', KET_SATUAN ='" & TextBoxKet.Text & "' WHERE id_satuan = '" & id & "'"
            cmd = New MySqlCommand(qs, conn)
            cmd.ExecuteNonQuery()
            conn.Close()
            MsgBox("Edit satuan berhasil dilakukan!")
            id = ""
        Catch ex As Exception
            MsgBox("Edit data satuan gagal dilakukan!")
        End Try
    End Sub

    Sub hapusSatuan()
        Try
            conn = Form1.koneksi()
            Dim qs As String = "update satuan set STATUS=0 WHERE id_satuan = '" & id & "'"
            cmd = New MySqlCommand(qs, conn)
            cmd.ExecuteNonQuery()
            conn.Close()
            MsgBox("Hapus satuan berhasil dilakukan!")
            id = ""
        Catch ex As Exception
            MsgBox("Hapus data satuan gagal dilakukan!")
        End Try
    End Sub

    Private Sub satuan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tampilSatuan()
        formatTampilanGrid()
    End Sub

    Public id As String = ""
    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        Try
            id = DataGridView1.Rows(e.RowIndex).Cells(0).Value.ToString
            TextBoxSatuan.Text = DataGridView1.Rows(e.RowIndex).Cells(1).Value.ToString
            TextBoxKet.Text = DataGridView1.Rows(e.RowIndex).Cells(2).Value.ToString
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ubahSatuan()
        tampilSatuan()
        clearData()
        formatTampilanGrid()
    End Sub

    Private Sub Hapus_Click(sender As Object, e As EventArgs) Handles Hapus.Click
        hapusSatuan()
        tampilSatuan()
        clearData()
        formatTampilanGrid()
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

    Sub clearData()
        TextBoxKet.Text = ""
        TextBoxSatuan.Text = ""
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        clearData()
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Try
            id = DataGridView1.Rows(e.RowIndex).Cells(0).Value.ToString
            TextBoxSatuan.Text = DataGridView1.Rows(e.RowIndex).Cells(1).Value.ToString
            TextBoxKet.Text = DataGridView1.Rows(e.RowIndex).Cells(2).Value.ToString
        Catch ex As Exception
        End Try
    End Sub
End Class