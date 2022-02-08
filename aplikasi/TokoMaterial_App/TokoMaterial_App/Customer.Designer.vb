<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Customer
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RadioButtonGrosir = New System.Windows.Forms.RadioButton()
        Me.RadioButtonRetail = New System.Windows.Forms.RadioButton()
        Me.TextBoxTelp = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBoxEmail = New System.Windows.Forms.TextBox()
        Me.TextBoxAlamat = New System.Windows.Forms.TextBox()
        Me.TextBoxNama = New System.Windows.Forms.TextBox()
        Me.TextBoxID = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBoxKet = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TextBoxCari = New System.Windows.Forms.TextBox()
        Me.ButtonCari = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.RadioButton_ket = New System.Windows.Forms.RadioButton()
        Me.RadioButton_telp = New System.Windows.Forms.RadioButton()
        Me.RadioButton_email = New System.Windows.Forms.RadioButton()
        Me.RadioButton_alamat = New System.Windows.Forms.RadioButton()
        Me.RadioButton_nama = New System.Windows.Forms.RadioButton()
        Me.RadioButton_id = New System.Windows.Forms.RadioButton()
        Me.ButtonClear = New System.Windows.Forms.Button()
        Me.ButtonRefresh = New System.Windows.Forms.Button()
        Me.ButtonTambah = New System.Windows.Forms.Button()
        Me.ButtonHapus = New System.Windows.Forms.Button()
        Me.ButtonUbah = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RadioButtonGrosir)
        Me.GroupBox1.Controls.Add(Me.RadioButtonRetail)
        Me.GroupBox1.Controls.Add(Me.TextBoxTelp)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.TextBoxEmail)
        Me.GroupBox1.Controls.Add(Me.TextBoxAlamat)
        Me.GroupBox1.Controls.Add(Me.TextBoxNama)
        Me.GroupBox1.Controls.Add(Me.TextBoxID)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 99)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(278, 279)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Master Pelanggan"
        '
        'RadioButtonGrosir
        '
        Me.RadioButtonGrosir.AutoSize = True
        Me.RadioButtonGrosir.Location = New System.Drawing.Point(182, 241)
        Me.RadioButtonGrosir.Name = "RadioButtonGrosir"
        Me.RadioButtonGrosir.Size = New System.Drawing.Size(81, 28)
        Me.RadioButtonGrosir.TabIndex = 13
        Me.RadioButtonGrosir.TabStop = True
        Me.RadioButtonGrosir.Text = "grosir"
        Me.RadioButtonGrosir.UseVisualStyleBackColor = True
        '
        'RadioButtonRetail
        '
        Me.RadioButtonRetail.AutoSize = True
        Me.RadioButtonRetail.Checked = True
        Me.RadioButtonRetail.Location = New System.Drawing.Point(90, 241)
        Me.RadioButtonRetail.Name = "RadioButtonRetail"
        Me.RadioButtonRetail.Size = New System.Drawing.Size(73, 28)
        Me.RadioButtonRetail.TabIndex = 12
        Me.RadioButtonRetail.TabStop = True
        Me.RadioButtonRetail.Text = "retail"
        Me.RadioButtonRetail.UseVisualStyleBackColor = True
        '
        'TextBoxTelp
        '
        Me.TextBoxTelp.Location = New System.Drawing.Point(83, 196)
        Me.TextBoxTelp.Name = "TextBoxTelp"
        Me.TextBoxTelp.Size = New System.Drawing.Size(180, 29)
        Me.TextBoxTelp.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(30, 241)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(54, 20)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Jenis :"
        '
        'TextBoxEmail
        '
        Me.TextBoxEmail.Location = New System.Drawing.Point(83, 153)
        Me.TextBoxEmail.Name = "TextBoxEmail"
        Me.TextBoxEmail.Size = New System.Drawing.Size(180, 29)
        Me.TextBoxEmail.TabIndex = 8
        '
        'TextBoxAlamat
        '
        Me.TextBoxAlamat.Location = New System.Drawing.Point(83, 111)
        Me.TextBoxAlamat.Name = "TextBoxAlamat"
        Me.TextBoxAlamat.Size = New System.Drawing.Size(180, 29)
        Me.TextBoxAlamat.TabIndex = 7
        '
        'TextBoxNama
        '
        Me.TextBoxNama.Location = New System.Drawing.Point(83, 73)
        Me.TextBoxNama.Name = "TextBoxNama"
        Me.TextBoxNama.Size = New System.Drawing.Size(180, 29)
        Me.TextBoxNama.TabIndex = 6
        '
        'TextBoxID
        '
        Me.TextBoxID.Enabled = False
        Me.TextBoxID.Location = New System.Drawing.Point(83, 33)
        Me.TextBoxID.Name = "TextBoxID"
        Me.TextBoxID.Size = New System.Drawing.Size(180, 29)
        Me.TextBoxID.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(10, 115)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 20)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Alamat :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(18, 75)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 20)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Nama :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(30, 199)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Telp :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(16, 156)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "E-Mail :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(46, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ID :"
        '
        'TextBoxKet
        '
        Me.TextBoxKet.Location = New System.Drawing.Point(19, 32)
        Me.TextBoxKet.Multiline = True
        Me.TextBoxKet.Name = "TextBoxKet"
        Me.TextBoxKet.Size = New System.Drawing.Size(217, 238)
        Me.TextBoxKet.TabIndex = 0
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(11, 455)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(559, 172)
        Me.DataGridView1.TabIndex = 13
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TextBoxKet)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(309, 99)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(261, 279)
        Me.GroupBox2.TabIndex = 12
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Keterangan"
        '
        'TextBoxCari
        '
        Me.TextBoxCari.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxCari.Location = New System.Drawing.Point(62, 52)
        Me.TextBoxCari.Multiline = True
        Me.TextBoxCari.Name = "TextBoxCari"
        Me.TextBoxCari.Size = New System.Drawing.Size(388, 29)
        Me.TextBoxCari.TabIndex = 12
        '
        'ButtonCari
        '
        Me.ButtonCari.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonCari.Location = New System.Drawing.Point(471, 50)
        Me.ButtonCari.Name = "ButtonCari"
        Me.ButtonCari.Size = New System.Drawing.Size(71, 30)
        Me.ButtonCari.TabIndex = 17
        Me.ButtonCari.Text = "Cari"
        Me.ButtonCari.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.RadioButton_ket)
        Me.GroupBox3.Controls.Add(Me.RadioButton_telp)
        Me.GroupBox3.Controls.Add(Me.RadioButton_email)
        Me.GroupBox3.Controls.Add(Me.RadioButton_alamat)
        Me.GroupBox3.Controls.Add(Me.RadioButton_nama)
        Me.GroupBox3.Controls.Add(Me.RadioButton_id)
        Me.GroupBox3.Controls.Add(Me.TextBoxCari)
        Me.GroupBox3.Controls.Add(Me.ButtonCari)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(12, 3)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(558, 90)
        Me.GroupBox3.TabIndex = 19
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Pencarian :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Image = Global.TokoMaterial_App.My.Resources.Resources.toolbar_find
        Me.Label7.Location = New System.Drawing.Point(16, 33)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(40, 48)
        Me.Label7.TabIndex = 24
        Me.Label7.Text = "     " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "     "
        '
        'RadioButton_ket
        '
        Me.RadioButton_ket.AutoSize = True
        Me.RadioButton_ket.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton_ket.Location = New System.Drawing.Point(446, 23)
        Me.RadioButton_ket.Name = "RadioButton_ket"
        Me.RadioButton_ket.Size = New System.Drawing.Size(95, 20)
        Me.RadioButton_ket.TabIndex = 23
        Me.RadioButton_ket.TabStop = True
        Me.RadioButton_ket.Text = "Keterangan"
        Me.RadioButton_ket.UseVisualStyleBackColor = True
        '
        'RadioButton_telp
        '
        Me.RadioButton_telp.AutoSize = True
        Me.RadioButton_telp.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton_telp.Location = New System.Drawing.Point(386, 23)
        Me.RadioButton_telp.Name = "RadioButton_telp"
        Me.RadioButton_telp.Size = New System.Drawing.Size(54, 20)
        Me.RadioButton_telp.TabIndex = 22
        Me.RadioButton_telp.TabStop = True
        Me.RadioButton_telp.Text = "Telp"
        Me.RadioButton_telp.UseVisualStyleBackColor = True
        '
        'RadioButton_email
        '
        Me.RadioButton_email.AutoSize = True
        Me.RadioButton_email.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton_email.Location = New System.Drawing.Point(316, 23)
        Me.RadioButton_email.Name = "RadioButton_email"
        Me.RadioButton_email.Size = New System.Drawing.Size(64, 20)
        Me.RadioButton_email.TabIndex = 21
        Me.RadioButton_email.TabStop = True
        Me.RadioButton_email.Text = "E-mail"
        Me.RadioButton_email.UseVisualStyleBackColor = True
        '
        'RadioButton_alamat
        '
        Me.RadioButton_alamat.AutoSize = True
        Me.RadioButton_alamat.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton_alamat.Location = New System.Drawing.Point(238, 23)
        Me.RadioButton_alamat.Name = "RadioButton_alamat"
        Me.RadioButton_alamat.Size = New System.Drawing.Size(68, 20)
        Me.RadioButton_alamat.TabIndex = 20
        Me.RadioButton_alamat.TabStop = True
        Me.RadioButton_alamat.Text = "Alamat"
        Me.RadioButton_alamat.UseVisualStyleBackColor = True
        '
        'RadioButton_nama
        '
        Me.RadioButton_nama.AutoSize = True
        Me.RadioButton_nama.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton_nama.Location = New System.Drawing.Point(169, 23)
        Me.RadioButton_nama.Name = "RadioButton_nama"
        Me.RadioButton_nama.Size = New System.Drawing.Size(63, 20)
        Me.RadioButton_nama.TabIndex = 19
        Me.RadioButton_nama.TabStop = True
        Me.RadioButton_nama.Text = "Nama"
        Me.RadioButton_nama.UseVisualStyleBackColor = True
        '
        'RadioButton_id
        '
        Me.RadioButton_id.AutoSize = True
        Me.RadioButton_id.Checked = True
        Me.RadioButton_id.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton_id.Location = New System.Drawing.Point(126, 23)
        Me.RadioButton_id.Name = "RadioButton_id"
        Me.RadioButton_id.Size = New System.Drawing.Size(39, 20)
        Me.RadioButton_id.TabIndex = 18
        Me.RadioButton_id.TabStop = True
        Me.RadioButton_id.Text = "ID"
        Me.RadioButton_id.UseVisualStyleBackColor = True
        '
        'ButtonClear
        '
        Me.ButtonClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonClear.Image = Global.TokoMaterial_App.My.Resources.Resources.edit_clear
        Me.ButtonClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonClear.Location = New System.Drawing.Point(349, 395)
        Me.ButtonClear.Name = "ButtonClear"
        Me.ButtonClear.Size = New System.Drawing.Size(86, 41)
        Me.ButtonClear.TabIndex = 21
        Me.ButtonClear.Text = "Clear"
        Me.ButtonClear.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonClear.UseVisualStyleBackColor = True
        '
        'ButtonRefresh
        '
        Me.ButtonRefresh.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonRefresh.Image = Global.TokoMaterial_App.My.Resources.Resources.arrow_refresh
        Me.ButtonRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonRefresh.Location = New System.Drawing.Point(469, 394)
        Me.ButtonRefresh.Name = "ButtonRefresh"
        Me.ButtonRefresh.Size = New System.Drawing.Size(101, 41)
        Me.ButtonRefresh.TabIndex = 20
        Me.ButtonRefresh.Text = "Refresh"
        Me.ButtonRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonRefresh.UseVisualStyleBackColor = True
        '
        'ButtonTambah
        '
        Me.ButtonTambah.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonTambah.Image = Global.TokoMaterial_App.My.Resources.Resources.increase
        Me.ButtonTambah.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonTambah.Location = New System.Drawing.Point(218, 395)
        Me.ButtonTambah.Name = "ButtonTambah"
        Me.ButtonTambah.Size = New System.Drawing.Size(100, 43)
        Me.ButtonTambah.TabIndex = 16
        Me.ButtonTambah.Text = "Tambah"
        Me.ButtonTambah.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonTambah.UseVisualStyleBackColor = True
        '
        'ButtonHapus
        '
        Me.ButtonHapus.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonHapus.Image = Global.TokoMaterial_App.My.Resources.Resources.cancel
        Me.ButtonHapus.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonHapus.Location = New System.Drawing.Point(12, 396)
        Me.ButtonHapus.Name = "ButtonHapus"
        Me.ButtonHapus.Size = New System.Drawing.Size(85, 41)
        Me.ButtonHapus.TabIndex = 15
        Me.ButtonHapus.Text = "Hapus"
        Me.ButtonHapus.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonHapus.UseVisualStyleBackColor = True
        '
        'ButtonUbah
        '
        Me.ButtonUbah.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonUbah.Image = Global.TokoMaterial_App.My.Resources.Resources.write
        Me.ButtonUbah.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonUbah.Location = New System.Drawing.Point(116, 394)
        Me.ButtonUbah.Name = "ButtonUbah"
        Me.ButtonUbah.Size = New System.Drawing.Size(83, 43)
        Me.ButtonUbah.TabIndex = 14
        Me.ButtonUbah.Text = "Ubah"
        Me.ButtonUbah.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonUbah.UseVisualStyleBackColor = True
        '
        'Customer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Highlight
        Me.ClientSize = New System.Drawing.Size(582, 639)
        Me.Controls.Add(Me.ButtonClear)
        Me.Controls.Add(Me.ButtonRefresh)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ButtonTambah)
        Me.Controls.Add(Me.ButtonHapus)
        Me.Controls.Add(Me.ButtonUbah)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "Customer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Customer"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBoxEmail As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxAlamat As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxNama As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxID As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBoxKet As System.Windows.Forms.TextBox
    Friend WithEvents ButtonTambah As System.Windows.Forms.Button
    Friend WithEvents ButtonHapus As System.Windows.Forms.Button
    Friend WithEvents ButtonUbah As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBoxTelp As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TextBoxCari As System.Windows.Forms.TextBox
    Friend WithEvents ButtonCari As System.Windows.Forms.Button
    Friend WithEvents RadioButtonGrosir As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButtonRetail As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents RadioButton_ket As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton_telp As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton_email As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton_alamat As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton_nama As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton_id As System.Windows.Forms.RadioButton
    Friend WithEvents ButtonRefresh As System.Windows.Forms.Button
    Friend WithEvents ButtonClear As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
End Class
