Imports MySql.Data.MySqlClient
Public Class Customer
    Public conn As MySqlConnection
    Public cmd As MySqlCommand
    Public da As MySqlDataAdapter
    Public dt As New DataTable("customer")
    Public ds As New DataSet
    Public DR As MySqlDataReader

    Function No()
        Dim temp As Integer
        Try
            conn = Form1.koneksi()
            Dim str As String
            str = "select count(*) 'no' from customer"
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
            'MsgBox(temp)
        Catch ex As Exception
            MsgBox(ex.ToString)
            MessageBox.Show("Indexing gagal dilakukan!")
        End Try
        Return temp
    End Function

    Sub tampilCustomer()
        DataGridView1.DataSource = Nothing
        ds.Clear()
        Try
            conn = Form1.koneksi()
            Dim qs As String = "Select id_cus 'ID', nama_cus 'Customer', alamat_cus 'Alamat', email_cus 'E-mail', telp_cus 'Telp', jenis_cus 'Jenis', ket_cus 'Keterangan' From customer where status = 1 ORDER BY ID"
            da = New MySqlDataAdapter(qs, conn)
            da.Fill(ds, 0)
            dt = ds.Tables(0)
            DataGridView1.DataSource = dt
            conn.Close()
        Catch ex As Exception
            MsgBox("Tampilan customer bermasalah! " + ex.ToString)
        End Try
    End Sub

    Sub CariCustomer()
        DataGridView1.DataSource = Nothing
        ds.Clear()
        Dim berdasarkan As String = "nama"
        If RadioButton_alamat.Checked Then
            berdasarkan = "alamat"
        ElseIf RadioButton_email.Checked Then
            berdasarkan = "email"
        ElseIf RadioButton_id.Checked Then
            berdasarkan = "id"
        ElseIf RadioButton_ket.Checked Then
            berdasarkan = "keterangan"
        ElseIf RadioButton_nama.Checked Then
            berdasarkan = "nama"
        ElseIf RadioButton_telp.Checked Then
            berdasarkan = "telp"
        End If

        Dim qs As String = "Select id_cus 'ID', nama_cus 'Customer', alamat_cus 'Alamat', email_cus 'E-mail', telp_cus 'Telp', jenis_cus 'Jenis', ket_cus 'Keterangan' From customer where status = 1 AND Id_cus like '%" & TextBoxCari.Text & "%' ORDER BY ID"
        If berdasarkan = "id" Then
            qs = "Select id_cus 'ID', nama_cus 'Customer', alamat_cus 'Alamat', email_cus 'E-mail', telp_cus 'Telp', jenis_cus 'Jenis', ket_cus 'Keterangan' From customer where status = 1 AND Id_cus like '%" & TextBoxCari.Text & "%' ORDER BY ID"
        ElseIf berdasarkan = "nama" Then
            qs = "Select id_cus 'ID', nama_cus 'Customer', alamat_cus 'Alamat', email_cus 'E-mail', telp_cus 'Telp', jenis_cus 'Jenis', ket_cus 'Keterangan' From customer where status = 1 AND nama_cus like '%" & TextBoxCari.Text & "%' ORDER BY ID"
        ElseIf berdasarkan = "alamat" Then
            qs = "Select id_cus 'ID', nama_cus 'Customer', alamat_cus 'Alamat', email_cus 'E-mail', telp_cus 'Telp', jenis_cus 'Jenis', ket_cus 'Keterangan' From customer where status = 1 AND alamat_cus like '%" & TextBoxCari.Text & "%' ORDER BY ID"
        ElseIf berdasarkan = "email" Then
            qs = "Select id_cus 'ID', nama_cus 'Customer', alamat_cus 'Alamat', email_cus 'E-mail', telp_cus 'Telp', jenis_cus 'Jenis', ket_cus 'Keterangan' From customer where status = 1 AND email_cus like '%" & TextBoxCari.Text & "%' ORDER BY ID"
        ElseIf berdasarkan = "telp" Then
            qs = "Select id_cus 'ID', nama_cus 'Customer', alamat_cus 'Alamat', email_cus 'E-mail', telp_cus 'Telp', jenis_cus 'Jenis', ket_cus 'Keterangan' From customer where status = 1 AND telp_cus like '%" & TextBoxCari.Text & "%' ORDER BY ID"
        ElseIf berdasarkan = "jenis" Then
            qs = "Select id_cus 'ID', nama_cus 'Customer', alamat_cus 'Alamat', email_cus 'E-mail', telp_cus 'Telp', jenis_cus 'Jenis', ket_cus 'Keterangan' From customer where status = 1 AND jenis_cus like '%" & TextBoxCari.Text & "%' ORDER BY ID"
        ElseIf berdasarkan = "keterangan" Then
            qs = "Select id_cus 'ID', nama_cus 'Customer', alamat_cus 'Alamat', email_cus 'E-mail', telp_cus 'Telp', jenis_cus 'Jenis', ket_cus 'Keterangan' From customer where status = 1 AND ket_cus like '%" & TextBoxCari.Text & "%' ORDER BY ID"
        Else
            qs = "Select id_cus 'ID', nama_cus 'Customer', alamat_cus 'Alamat', email_cus 'E-mail', telp_cus 'Telp', jenis_cus 'Jenis', ket_cus 'Keterangan' From customer where status = 1 AND nama_cus like '%" & TextBoxCari.Text & "%' ORDER BY ID"
        End If
        Try
            conn = Form1.koneksi()
            da = New MySqlDataAdapter(qs, conn)
            da.Fill(ds, 0)
            dt = ds.Tables(0)
            DataGridView1.DataSource = dt
            conn.Close()
        Catch ex As Exception
            MsgBox("Tampilan customer bermasalah! " + ex.ToString)
        End Try
    End Sub

    Sub tambahCustomer()
        Dim indeks As Integer = No()
        Dim jenis As String
        If RadioButtonGrosir.Checked Then
            jenis = "grosir"
        ElseIf RadioButtonRetail.Checked Then
            jenis = "retail"
        Else
            jenis = "retail"
        End If
        If TextBoxNama.Text <> "" Then
            Try
                conn = Form1.koneksi()
                Dim qs As String = "INSERT INTO customer (ID_CUS, NAMA_CUS, ALAMAT_CUS, EMAIL_CUS, TELP_CUS, JENIS_CUS, KET_CUS, STATUS) VALUES ('cus" & indeks & "', '" & TextBoxNama.Text & "', '" & TextBoxAlamat.Text & "', '" & TextBoxEmail.Text & "', '" & TextBoxTelp.Text & "', '" & jenis & "', '" & TextBoxKet.Text & "', '1');"
                cmd = New MySqlCommand(qs, conn)
                cmd.ExecuteNonQuery()
                conn.Close()
                MsgBox("Tambah data customer berhasil dilakukan!")
            Catch ex As Exception
                MsgBox("Tambah data customer gagal dilakukan! " + ex.ToString)
            End Try
        Else
            MsgBox("Nama customer belum dimasukkan!")
        End If
    End Sub

    Sub ubahCustomer()
        If TextBoxNama.Text <> "" Then
            Try
                Dim jenis As String = "retail"
                If RadioButtonRetail.Checked Then
                    jenis = "retail"
                ElseIf RadioButtonGrosir.Checked Then
                    jenis = "grosir"
                End If
                conn = Form1.koneksi()
                Dim qs As String = "update customer set NAMA_CUS ='" & TextBoxNama.Text & "',ALAMAT_CUS ='" & TextBoxAlamat.Text & "', EMAIL_CUS = '" & TextBoxEmail.Text & "', TELP_CUS = '" & TextBoxTelp.Text & "',JENIS_CUS ='" & jenis & "', KET_CUS ='" & TextBoxKet.Text & "' WHERE ID_CUS = '" & TextBoxID.Text & "'"
                cmd = New MySqlCommand(qs, conn)
                cmd.ExecuteNonQuery()
                conn.Close()
                MsgBox("Edit data customer berhasil dilakukan!")
            Catch ex As Exception
                MsgBox("Edit data customer gagal dilakukan!")
            End Try
        Else
            MsgBox("Nama customer wajib dimasukkan!")
        End If
    End Sub

    Sub hapusCustomer()
        Try
            conn = Form1.koneksi()
            Dim qs As String = "update Customer set STATUS=0 WHERE ID_CUS = '" & TextBoxID.Text & "'"
            cmd = New MySqlCommand(qs, conn)
            cmd.ExecuteNonQuery()
            conn.Close()
            MsgBox("Hapus data customer berhasil dilakukan!")
        Catch ex As Exception
            MsgBox("Hapus data customer gagal dilakukan!")
        End Try
    End Sub

    Private Sub DataGridView1_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentDoubleClick
        Try
            TextBoxID.Text = DataGridView1.Rows(e.RowIndex).Cells(0).Value.ToString
            TextBoxNama.Text = DataGridView1.Rows(e.RowIndex).Cells(1).Value.ToString
            TextBoxAlamat.Text = DataGridView1.Rows(e.RowIndex).Cells(2).Value.ToString
            TextBoxEmail.Text = DataGridView1.Rows(e.RowIndex).Cells(3).Value.ToString
            TextBoxTelp.Text = DataGridView1.Rows(e.RowIndex).Cells(4).Value.ToString
            TextBoxKet.Text = DataGridView1.Rows(e.RowIndex).Cells(6).Value.ToString
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles ButtonCari.Click
        CariCustomer()
        formatTampilanGrid()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles ButtonTambah.Click
        'No()
        tambahCustomer()
        tampilCustomer()
        ClearData()
        formatTampilanGrid()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ButtonUbah.Click
        ubahCustomer()
        tampilCustomer()
        formatTampilanGrid()
    End Sub

    Private Sub Hapus_Click(sender As Object, e As EventArgs) Handles ButtonHapus.Click
        hapusCustomer()
        tampilCustomer()
        formatTampilanGrid()
    End Sub

    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        Try
            TextBoxID.Text = DataGridView1.Rows(e.RowIndex).Cells(0).Value.ToString
            TextBoxNama.Text = DataGridView1.Rows(e.RowIndex).Cells(1).Value.ToString
            TextBoxAlamat.Text = DataGridView1.Rows(e.RowIndex).Cells(2).Value.ToString
            TextBoxEmail.Text = DataGridView1.Rows(e.RowIndex).Cells(3).Value.ToString
            TextBoxTelp.Text = DataGridView1.Rows(e.RowIndex).Cells(4).Value.ToString
            TextBoxKet.Text = DataGridView1.Rows(e.RowIndex).Cells(6).Value.ToString
        Catch ex As Exception
        End Try
    End Sub

    Dim jabatanku As String = Form1.jabatan
    Sub user_access()
        If jabatanku = "kasir" Then
            ButtonTambah.Visible = True
            ButtonUbah.Visible = True
            ButtonHapus.Visible = False
        End If
    End Sub

    Private Sub Customer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        user_access()
        tampilCustomer()
        formatTampilanGrid()
    End Sub

    Sub ClearData()
        TextBoxAlamat.Text = ""
        TextBoxCari.Text = ""
        TextBoxEmail.Text = ""
        TextBoxID.Text = ""
        TextBoxKet.Text = ""
        TextBoxNama.Text = ""
        TextBoxTelp.Text = ""
        tampilCustomer()
    End Sub

    Sub formatTampilanGrid()
        For i As Integer = 0 To DataGridView1.Rows.Count - 1
            If i Mod 2 = 0 Then
                DataGridView1.Rows(i).Cells(0).Style.BackColor = Color.White
                DataGridView1.Rows(i).Cells(1).Style.BackColor = Color.White
                DataGridView1.Rows(i).Cells(2).Style.BackColor = Color.White
                DataGridView1.Rows(i).Cells(3).Style.BackColor = Color.White
                DataGridView1.Rows(i).Cells(4).Style.BackColor = Color.White
                DataGridView1.Rows(i).Cells(6).Style.BackColor = Color.White
                DataGridView1.Rows(i).Cells(4).Style.BackColor = Color.White
            Else
                DataGridView1.Rows(i).Cells(0).Style.BackColor = Color.GreenYellow
                DataGridView1.Rows(i).Cells(1).Style.BackColor = Color.GreenYellow
                DataGridView1.Rows(i).Cells(2).Style.BackColor = Color.GreenYellow
                DataGridView1.Rows(i).Cells(3).Style.BackColor = Color.GreenYellow
                DataGridView1.Rows(i).Cells(4).Style.BackColor = Color.GreenYellow
                DataGridView1.Rows(i).Cells(5).Style.BackColor = Color.GreenYellow
                DataGridView1.Rows(i).Cells(6).Style.BackColor = Color.GreenYellow
            End If
        Next
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles ButtonClear.Click
        ClearData()
        formatTampilanGrid()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles ButtonRefresh.Click
        tampilCustomer()
        formatTampilanGrid()
    End Sub
End Class