Imports MySql.Data.MySqlClient
Public Class supplier
    Public conn As MySqlConnection
    Public cmd As MySqlCommand
    Public da As MySqlDataAdapter
    Public dt As New DataTable("supplier")
    Public ds As New DataSet
    Public DR As MySqlDataReader
    Public id As Integer

    Function No()
        Dim temp As Integer
        Try
            conn = Form1.koneksi()
            Dim str As String
            str = "select count(*) 'no' from supplier"
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

    Sub tampilSupplier()
        DataGridView1.DataSource = Nothing
        ds.Clear()
        Try
            conn = Form1.koneksi()
            Dim qs As String = "Select id_sup 'ID', nama_sup 'Suplier', alamat_sup 'Alamat', email_sup 'E-mail', telp_sup 'Telp', ket_sup 'Keterangan' From supplier where status = 1 ORDER BY ID"
            da = New MySqlDataAdapter(qs, conn)
            da.Fill(ds, 0)
            dt = ds.Tables(0)
            DataGridView1.DataSource = dt
            conn.Close()
        Catch ex As Exception
            MsgBox("Tampilan supplier bermasalah! " + ex.ToString)
        End Try
    End Sub

    Sub tambahSupplier()
        Dim indeks As Integer = No()
        If TextBoxNama.Text <> "" Then
            Try
                conn = Form1.koneksi()
                Dim qs As String = "insert into supplier(id_sup, nama_sup, alamat_sup, email_sup, telp_sup, status, ket_sup) VALUES('sup" & indeks & "','" & TextBoxNama.Text & "','" & TextBoxReAlamat.Text & "','" & TextBoxEmail.Text & "','" & TextBoxTelp.Text & "',1,'" & TextBoxKet.Text & "')"
                cmd = New MySqlCommand(qs, conn)
                cmd.ExecuteNonQuery()
                conn.Close()
                MsgBox("Tambah data supplier berhasil dilakukan!")
            Catch ex As Exception
                MsgBox("Tambah data supplier gagal dilakukan! " + ex.ToString)
            End Try
        Else
            MsgBox("Nama supplier belum dimasukkan!")
        End If
    End Sub

    Sub ubahSupplier()
        If TextBoxNama.Text <> "" Then
            Try
                conn = Form1.koneksi()
                Dim qs As String = "update supplier set NAMA_SUP ='" & TextBoxNama.Text & "',ALAMAT_SUP ='" & TextBoxReAlamat.Text & "', EMAIL_SUP = '" & TextBoxEmail.Text & "', TELP_SUP = '" & TextBoxTelp.Text & "', KET_SUP ='" & TextBoxKet.Text & "' WHERE ID_SUP = '" & TextBoxID.Text & "'"
                cmd = New MySqlCommand(qs, conn)
                cmd.ExecuteNonQuery()
                conn.Close()
                MsgBox("Edit data supplier berhasil dilakukan!")
            Catch ex As Exception
                MsgBox("Edit data supplier gagal dilakukan!")
            End Try
        Else
            MsgBox("Nama Supplier wajib dimasukkan!")
        End If
    End Sub

    Sub hapusSupplier()
        Try
            conn = Form1.koneksi()
            Dim qs As String = "update supplier set STATUS=0 WHERE ID_SUP = '" & TextBoxID.Text & "'"
            cmd = New MySqlCommand(qs, conn)
            cmd.ExecuteNonQuery()
            conn.Close()
            MsgBox("Hapus data supplier berhasil dilakukan!")
        Catch ex As Exception
            MsgBox("Hapus data supplier gagal dilakukan!")
        End Try
    End Sub

    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        Try
            TextBoxID.Text = DataGridView1.Rows(e.RowIndex).Cells(0).Value.ToString
            TextBoxNama.Text = DataGridView1.Rows(e.RowIndex).Cells(1).Value.ToString
            TextBoxReAlamat.Text = DataGridView1.Rows(e.RowIndex).Cells(2).Value.ToString
            TextBoxEmail.Text = DataGridView1.Rows(e.RowIndex).Cells(3).Value.ToString
            TextBoxTelp.Text = DataGridView1.Rows(e.RowIndex).Cells(4).Value.ToString
            TextBoxKet.Text = DataGridView1.Rows(e.RowIndex).Cells(5).Value.ToString
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles ButtonTambah.Click
        tambahSupplier()
        tampilSupplier()
        clearData()
        formatTampilanGrid()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ButtonUbah.Click
        ubahSupplier()
        tampilSupplier()
        formatTampilanGrid()
    End Sub

    Private Sub Hapus_Click(sender As Object, e As EventArgs) Handles ButtonHapus.Click
        hapusSupplier()
        tampilSupplier()
        formatTampilanGrid()
    End Sub

    Dim jabatanku As String = Form1.jabatan
    Sub user_access()
        If jabatanku = "staf gudang" Then
            ButtonTambah.Visible = False
            ButtonHapus.Visible = False
            ButtonUbah.Visible = False
        End If
    End Sub

    Private Sub supplier_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        user_access()
        tampilSupplier()
        tampilId()
        formatTampilanGrid()
    End Sub

    Sub CariSupplier()
        DataGridView1.DataSource = Nothing
        ds.Clear()
        Dim berdasarkan As String = "nama"
        If RadioButton_id.Checked Then
            berdasarkan = "id"
        ElseIf RadioButton_nama.Checked Then
            berdasarkan = "nama"
        ElseIf RadioButton_alamat.Checked Then
            berdasarkan = "alamat"
        ElseIf RadioButton_Ket.Checked Then
            berdasarkan = "keterangan"
        ElseIf RadioButton_telp.Checked Then
            berdasarkan = "telp"
        ElseIf RadioButton_email.Checked Then
            berdasarkan = "email"
        End If

        Dim qs As String = "Select id_sup 'ID', nama_sup 'Suplier', alamat_sup 'Alamat', email_sup 'E-mail', telp_sup 'Telp', ket_sup 'Keterangan' From supplier where status = 1  AND Id_sup like '%" & TextBoxCari.Text & "%' ORDER BY ID"
        If berdasarkan = "id" Then
            qs = "Select id_sup 'ID', nama_sup 'Suplier', alamat_sup 'Alamat', email_sup 'E-mail', telp_sup 'Telp', ket_sup 'Keterangan' From supplier where status = 1  AND Id_sup like '%" & TextBoxCari.Text & "%' ORDER BY ID"
        ElseIf berdasarkan = "nama" Then
            qs = "Select id_sup 'ID', nama_sup 'Suplier', alamat_sup 'Alamat', email_sup 'E-mail', telp_sup 'Telp', ket_sup 'Keterangan' From supplier where status = 1 AND nama_sup like '%" & TextBoxCari.Text & "%' ORDER BY ID"
        ElseIf berdasarkan = "alamat" Then
            qs = "Select id_sup 'ID', nama_sup 'Suplier', alamat_sup 'Alamat', email_sup 'E-mail', telp_sup 'Telp', ket_sup 'Keterangan' From supplier where status = 1 AND alamat_sup like '%" & TextBoxCari.Text & "%' ORDER BY ID"
        ElseIf berdasarkan = "keterangan" Then
            qs = "Select id_sup 'ID', nama_sup 'Suplier', alamat_sup 'Alamat', email_sup 'E-mail', telp_sup 'Telp', ket_sup 'Keterangan' From supplier where status = 1 AND ket_sup like '%" & TextBoxCari.Text & "%' ORDER BY ID"
        ElseIf berdasarkan = "telp" Then
            qs = "Select id_sup 'ID', nama_sup 'Suplier', alamat_sup 'Alamat', email_sup 'E-mail', telp_sup 'Telp', ket_sup 'Keterangan' From supplier where status = 1 AND telp_sup like '%" & TextBoxCari.Text & "%' ORDER BY ID"
        ElseIf berdasarkan = "email" Then
            qs = "Select id_sup 'ID', nama_sup 'Suplier', alamat_sup 'Alamat', email_sup 'E-mail', telp_sup 'Telp', ket_sup 'Keterangan' From supplier where status = 1 AND email_sup like '%" & TextBoxCari.Text & "%' ORDER BY ID"
        Else
            qs = "Select id_sup 'ID', nama_sup 'Suplier', alamat_sup 'Alamat', email_sup 'E-mail', telp_sup 'Telp', ket_sup 'Keterangan' From supplier where status = 1 ORDER BY ID"
        End If
        Try
            conn = Form1.koneksi()
            da = New MySqlDataAdapter(qs, conn)
            da.Fill(ds, 0)
            dt = ds.Tables(0)
            DataGridView1.DataSource = dt
            conn.Close()
        Catch ex As Exception
            MsgBox("Tampilan suppplier bermasalah! " + ex.ToString)
        End Try
    End Sub

    Sub clearData()
        TextBoxCari.Text = ""
        TextBoxEmail.Text = ""
        TextBoxID.Text = ""
        TextBoxKet.Text = ""
        TextBoxTelp.Text = ""
        TextBoxNama.Text = ""
        TextBoxReAlamat.Text = ""
        tampilSupplier()
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
                DataGridView1.Rows(i).Cells(5).Style.BackColor = Color.White
            Else
                DataGridView1.Rows(i).Cells(0).Style.BackColor = Color.GreenYellow
                DataGridView1.Rows(i).Cells(1).Style.BackColor = Color.GreenYellow
                DataGridView1.Rows(i).Cells(2).Style.BackColor = Color.GreenYellow
                DataGridView1.Rows(i).Cells(3).Style.BackColor = Color.GreenYellow
                DataGridView1.Rows(i).Cells(4).Style.BackColor = Color.GreenYellow
                DataGridView1.Rows(i).Cells(5).Style.BackColor = Color.GreenYellow
            End If
        Next
    End Sub

    Sub tampilId()
        Dim temp As Integer = No()
        'id = "sup" + temp
        'TextBoxID.Text = id
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles ButtonCari.Click
        CariSupplier()
        formatTampilanGrid()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles ButtonRefresh.Click
        tampilSupplier()
        tampilId()
        formatTampilanGrid()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles ButtonClear.Click
        clearData()
    End Sub
End Class