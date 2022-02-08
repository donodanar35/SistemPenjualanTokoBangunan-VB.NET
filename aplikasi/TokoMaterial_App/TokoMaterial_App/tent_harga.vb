Imports MySql.Data.MySqlClient

Public Class tent_harga
    Public conn As MySqlConnection
    Public cmd As MySqlCommand
    Public da As MySqlDataAdapter
    Public dt As New DataTable("barang")
    Public ds As New DataSet
    Public DR As MySqlDataReader
    Public id As String

    Sub tampilBarang(nama_brg As String)
        Try
            conn = Form1.koneksi()
            Dim qs As String = "Select b.id_brg 'id_brg', b.nama_brg 'nama_brg', k.nama_kat 'kategori', s.nama_satuan 'satuan', b.diskon 'diskon', b.ppn 'ppn', b.harga_jual 'hj', b.harga_beli 'hb' From BARANG b, KATEGORI k, SATUAN s WHERE s.id_satuan = b.id_satuan AND k.id_kat = b.id_kat AND  b.STATUS = 1 AND b.nama_brg like '%" & nama_brg & "%'"
            da = New MySqlDataAdapter(qs, conn)
            Dim dtKategori As New DataTable("barang")
            da.Fill(dtKategori)

            ComboBoxBarang.DataSource = dtKategori
            ComboBoxBarang.DisplayMember = "nama_brg"
            ComboBoxBarang.ValueMember = "id_brg"
            conn.Close()

            LabelId.Text = dtKategori.Rows.Item(0).Item("id_brg")
            LabelNamaBarang.Text = dtKategori.Rows.Item(0).Item("nama_brg")
            LabelKategori.Text = dtKategori.Rows.Item(0).Item("kategori")
            LabelSatuan.Text = dtKategori.Rows.Item(0).Item("satuan")
            LabelDiskon.Text = dtKategori.Rows.Item(0).Item("diskon")
            LabelPPN.Text = dtKategori.Rows.Item(0).Item("ppn")
            LabelHJ.Text = dtKategori.Rows.Item(0).Item("hj")
            LabelHB.Text = dtKategori.Rows.Item(0).Item("hb")

        Catch ex As Exception
            MsgBox("Tampilan barang bermasalah! " + ex.ToString)
        End Try
    End Sub


    Sub CariBrg()
        Dim temp As String = ""
        Try
            conn = Form1.koneksi()
            Dim str As String
            'str = "Select b.id_brg, b.nama_brg, b.harga_beli, b.harga_jual, s.nama_satuan, k.nama_kat From BARANG b, kategori k, satuan s WHERE b.STATUS = 1 AND b.nama_brg like '%" & TextBoxCariBarang.Text & "%' AND k.id_kat = b.id_brg AND s.id_satuan = b.id_satuan"
            str = "select nama_brg 'nama' from barang where status = 1 and id_brg like '" & ComboBoxBarang.SelectedValue.ToString & "'"
            Dim cmd = New MySqlCommand(str, conn)
            DR = cmd.ExecuteReader

            If DR.Read Then
                If DR.IsDBNull(0) Then
                    temp = 0
                Else
                    If DR.HasRows Then
                        While DR.Read()
                            temp = DR.Item("nama")
                        End While
                    Else
                        temp = ""
                    End If
                End If
            End If
            
            DR.Close()
            conn.Close()

            TextBoxCariBarang.Text = temp
        Catch ex As Exception
            MessageBox.Show("Cari barang bermasalah! " + ex.ToString)
        End Try
    End Sub

    Sub CariHargaHB()
        Dim temp As String = 0
        Try
            conn = Form1.koneksi()
            Dim str As String = "select ISNULL(avg(hrg_beli),'') 'harga' from dbeli where id_brg like '" & ComboBoxBarang.SelectedValue.ToString & "'"

            If RadioButton_hb_max.Checked Then
                str = "select max(hrg_beli) 'harga' from dbeli where id_brg like '" & ComboBoxBarang.SelectedValue.ToString & "'"
            ElseIf RadioButton_hb_min.Checked Then
                str = "select min(hrg_beli) 'harga' from dbeli where id_brg like '" & ComboBoxBarang.SelectedValue.ToString & "'"
            ElseIf RadioButton_hb_avg.Checked Then
                str = "select avg(hrg_beli) 'harga' from dbeli where id_brg like '" & ComboBoxBarang.SelectedValue.ToString & "'"
            ElseIf RadioButton_hb_current.Checked Then
                str = "select hrg_beli 'harga' from dbeli where id_brg like '" & ComboBoxBarang.SelectedValue.ToString & "' limit 1"
            End If

            Dim cmd = New MySqlCommand(str, conn)
            DR = cmd.ExecuteReader

            If DR.Read Then
                If DR.IsDBNull(0) Then
                    temp = 0
                Else
                    If DR.HasRows Then
                        While DR.Read()
                            temp = DR.Item("harga")
                        End While
                    ElseIf DR.HasRows.Equals("") Then
                        temp = 0
                    End If
                End If
            End If
            
            DR.Close()
            conn.Close()

            TextBoxHB.Text = temp
        Catch ex As Exception
            MessageBox.Show("Cari harga beli bermasalah! " + ex.ToString)
        End Try
    End Sub

    Sub CariHargaHJ()
        Dim temp As String = 0
        Try
            conn = Form1.koneksi()
            Dim str As String = "select avg(hrg_jual) 'harga' from djual where id_brg like '" & ComboBoxBarang.SelectedValue.ToString & "'"

            If RadioButton_hj_max.Checked Then
                str = "select max(hrg_jual) 'harga' from djual where id_brg like '" & ComboBoxBarang.SelectedValue.ToString & "'"
            ElseIf RadioButton_hj_min.Checked Then
                str = "select min(hrg_jual) 'harga' from djual where id_brg like '" & ComboBoxBarang.SelectedValue.ToString & "'"
            ElseIf RadioButton_hj_avg.Checked Then
                str = "select avg(hrg_jual) 'harga' from djual where id_brg like '" & ComboBoxBarang.SelectedValue.ToString & "'"
            ElseIf RadioButton_hj_current.Checked Then
                str = "select hrg_jual 'harga' from djual where id_brg like '" & ComboBoxBarang.SelectedValue.ToString & "' limit 1"
            End If

            Dim cmd = New MySqlCommand(str, conn)
            DR = cmd.ExecuteReader

            If DR.Read Then
                If DR.IsDBNull(0) Then
                    temp = 0
                Else
                    If DR.HasRows Then
                        While DR.Read()
                            temp = DR.Item("harga")
                        End While
                    Else
                        temp = 0
                    End If
                End If
            End If

            DR.Close()
            conn.Close()

            TextBoxHJ.Text = temp
        Catch ex As Exception
            MessageBox.Show("Cari harga jual bermasalah! " + ex.ToString)
        End Try
    End Sub

    Sub SelectBrg()
        Try
            conn = Form1.koneksi()
            Dim str As String
            str = "Select b.id_brg 'id', b.ppn 'ppn', b.diskon 'diskon', b.id_brg, b.nama_brg 'nama', b.harga_beli 'hb', b.harga_jual 'hj', s.nama_satuan 'sat', k.nama_kat 'kat' From BARANG b, kategori k, satuan s WHERE b.STATUS = 1 AND b.id_brg like '" & ComboBoxBarang.SelectedValue.ToString & "' AND k.id_kat = b.id_kat AND s.id_satuan = b.id_satuan"
            'str = "select nama_brg 'nama' from barang where status = 1 and id_brg like '" & ComboBoxBarang.SelectedValue.ToString & "'"
            Dim cmd = New MySqlCommand(str, conn)
            DR = cmd.ExecuteReader

            Dim tempIntHB As Decimal = 0
            Dim tempIntHJ As Decimal = 0
            Dim tempIntPPN As Decimal = 0
            Dim tempIntDiskon As Decimal = 0
            Dim nettoBersih As Decimal = 0
            Dim nettoKotor As Decimal = 0
            If DR.HasRows Then
                While DR.Read()
                    LabelId.Text = DR.Item("id")
                    LabelNamaBarang.Text = DR.Item("nama")
                    LabelKategori.Text = DR.Item("kat")
                    LabelSatuan.Text = DR.Item("sat")
                    tempIntHB = DR.Item("hb")
                    tempIntHJ = DR.Item("hj")
                    LabelHB.Text = DR.Item("hb")
                    TextBoxHB.Text = DR.Item("hb")
                    LabelHJ.Text = DR.Item("hj")
                    TextBoxHJ.Text = DR.Item("hj")
                    tempIntPPN = DR.Item("ppn")
                    LabelPPN.Text = tempIntPPN
                    TextBoxPPN.Text = tempIntPPN
                    tempIntDiskon = DR.Item("diskon")
                    LabelDiskon.Text = tempIntDiskon
                    TextBoxDiskon.Text = tempIntDiskon
                    nettoKotor = tempIntHJ - tempIntHB
                    LabelNettoKotor.Text = nettoKotor
                    nettoBersih = tempIntHJ - ((tempIntHJ * tempIntPPN) + (tempIntHJ * tempIntDiskon))
                    LabelNettoBersih.Text = nettoBersih
                End While
            End If
            DR.Close()
            conn.Close()
        Catch ex As Exception
            MessageBox.Show("Select barang bermasalah! " + ex.ToString)
        End Try
    End Sub

    Private Sub tent_harga_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tampilBarang("")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        tampilBarang(TextBoxCariBarang.Text)
        CariBrg()
        SelectBrg()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBoxPPN.Enabled = True
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        TextBoxDiskon.Enabled = True
    End Sub

    Sub UbahBarang()
        Try
            conn = Form1.koneksi()
            Dim qs As String = "update barang set HARGA_JUAL ='" & TextBoxHJ.Text & "', HARGA_BELI ='" & TextBoxHB.Text & "', DISKON = '" & TextBoxDiskon.Text & "', PPN = '" & TextBoxPPN.Text & "' WHERE ID_BRG = '" & LabelId.Text & "'"
            cmd = New MySqlCommand(qs, conn)
            cmd.ExecuteNonQuery()
            conn.Close()
            MsgBox("Edit data barang berhasil dilakukan!")
        Catch ex As Exception
            MsgBox("Edit data barang gagal dilakukan!")
        End Try
    End Sub

    Sub ClearData()
        TextBoxCariBarang.Text = ""
        TextBoxDiskon.Text = 0
        TextBoxPPN.Text = "0.1"
        TextBoxHB.Text = "0"
        TextBoxHJ.Text = "0"
        LabelDiskon.Text = "0"
        LabelHB.Text = "0"
        LabelHJ.Text = "0"
        LabelId.Text = ""
        LabelKategori.Text = ""
        LabelNamaBarang.Text = ""
        LabelNettoBersih.Text = "0"
        LabelNettoKotor.Text = "0"
        LabelPPN.Text = "0"
        LabelSatuan.Text = "0"
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If TextBoxHB.Text <> "" And TextBoxHJ.Text <> "" And TextBoxDiskon.Text <> "" And TextBoxPPN.Text <> "" Then
            UbahBarang()
            ClearData()
            tampilBarang("")
        Else
            MsgBox("Kolom tidak boleh kosong!")
        End If
    End Sub

    Private Sub TextBoxHB_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxHB.KeyPress
        Dim allowedChars As String = "0123456789."
        If allowedChars.IndexOf(e.KeyChar) = -1 Then
            ' Invalid Character
            e.Handled = True
        End If
    End Sub

    Private Sub TextBoxHJ_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxHJ.KeyPress
        Dim allowedChars As String = "0123456789."
        If allowedChars.IndexOf(e.KeyChar) = -1 Then
            ' Invalid Character
            e.Handled = True
        End If
    End Sub

    Private Sub TextBoxPPN_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxPPN.KeyPress
        Dim allowedChars As String = "0123456789."
        If allowedChars.IndexOf(e.KeyChar) = -1 Then
            ' Invalid Character
            e.Handled = True
        End If
    End Sub

    Private Sub TextBoxDiskon_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxDiskon.KeyPress
        Dim allowedChars As String = "0123456789."
        If allowedChars.IndexOf(e.KeyChar) = -1 Then
            ' Invalid Character
            e.Handled = True
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        ClearData()
        tampilBarang("")
    End Sub

    Private Sub ComboBoxBarang_SelectedValueChanged(sender As Object, e As EventArgs) Handles ComboBoxBarang.SelectedValueChanged
        SelectBrg()
    End Sub

    Private Sub RadioButton4_EnabledChanged(sender As Object, e As EventArgs) Handles RadioButton_hb_max.EnabledChanged
        CariHargaHJ()
    End Sub

    Private Sub RadioButton_hb_current_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton_hb_current.CheckedChanged
        CariHargaHB()
    End Sub

    Private Sub RadioButton_hb_avg_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton_hb_avg.CheckedChanged
        CariHargaHB()
    End Sub

    Private Sub RadioButton_hb_max_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton_hb_max.CheckedChanged
        CariHargaHB()
    End Sub

    Private Sub RadioButton_hb_min_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton_hb_min.CheckedChanged
        CariHargaHB()
    End Sub

    Private Sub RadioButton_hj_current_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton_hj_current.CheckedChanged
        CariHargaHJ()
    End Sub

    Private Sub RadioButton_hj_avg_EnabledChanged(sender As Object, e As EventArgs) Handles RadioButton_hj_avg.EnabledChanged
        CariHargaHJ()
    End Sub

    Private Sub RadioButton_hj_max_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton_hj_max.CheckedChanged
        CariHargaHJ()
    End Sub

    Private Sub RadioButton_hj_min_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton_hj_min.CheckedChanged
        CariHargaHJ()
    End Sub
End Class