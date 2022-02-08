<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Transaksi_Sampel
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.RadioButtonKeterangan = New System.Windows.Forms.RadioButton()
        Me.RadioButtonTelp = New System.Windows.Forms.RadioButton()
        Me.DateTimePickerPesan = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePickerKirim = New System.Windows.Forms.DateTimePicker()
        Me.RadioButtonTglKirim = New System.Windows.Forms.RadioButton()
        Me.RadioButtonTglPesan = New System.Windows.Forms.RadioButton()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.RadioButtonAlamat = New System.Windows.Forms.RadioButton()
        Me.RadioButtonPenerima = New System.Windows.Forms.RadioButton()
        Me.RadioButtonCustomer = New System.Windows.Forms.RadioButton()
        Me.RadioButtonPetugas = New System.Windows.Forms.RadioButton()
        Me.RadioButtonID = New System.Windows.Forms.RadioButton()
        Me.TextBoxCari = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.Column12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ButtonClear = New System.Windows.Forms.Button()
        Me.ButtonCetak = New System.Windows.Forms.Button()
        Me.Hapus = New System.Windows.Forms.Button()
        Me.ColumnId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column10 = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 133)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 20)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "Sampel"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.RadioButtonKeterangan)
        Me.GroupBox3.Controls.Add(Me.RadioButtonTelp)
        Me.GroupBox3.Controls.Add(Me.DateTimePickerPesan)
        Me.GroupBox3.Controls.Add(Me.DateTimePickerKirim)
        Me.GroupBox3.Controls.Add(Me.RadioButtonTglKirim)
        Me.GroupBox3.Controls.Add(Me.RadioButtonTglPesan)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.RadioButtonAlamat)
        Me.GroupBox3.Controls.Add(Me.RadioButtonPenerima)
        Me.GroupBox3.Controls.Add(Me.RadioButtonCustomer)
        Me.GroupBox3.Controls.Add(Me.RadioButtonPetugas)
        Me.GroupBox3.Controls.Add(Me.RadioButtonID)
        Me.GroupBox3.Controls.Add(Me.TextBoxCari)
        Me.GroupBox3.Controls.Add(Me.Button3)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(1215, 82)
        Me.GroupBox3.TabIndex = 24
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Pencarian :"
        '
        'RadioButtonKeterangan
        '
        Me.RadioButtonKeterangan.AutoSize = True
        Me.RadioButtonKeterangan.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButtonKeterangan.Location = New System.Drawing.Point(634, 17)
        Me.RadioButtonKeterangan.Name = "RadioButtonKeterangan"
        Me.RadioButtonKeterangan.Size = New System.Drawing.Size(95, 20)
        Me.RadioButtonKeterangan.TabIndex = 34
        Me.RadioButtonKeterangan.Text = "Keterangan"
        Me.RadioButtonKeterangan.UseVisualStyleBackColor = True
        '
        'RadioButtonTelp
        '
        Me.RadioButtonTelp.AutoSize = True
        Me.RadioButtonTelp.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButtonTelp.Location = New System.Drawing.Point(513, 17)
        Me.RadioButtonTelp.Name = "RadioButtonTelp"
        Me.RadioButtonTelp.Size = New System.Drawing.Size(115, 20)
        Me.RadioButtonTelp.TabIndex = 33
        Me.RadioButtonTelp.Text = "Telp Penerima"
        Me.RadioButtonTelp.UseVisualStyleBackColor = True
        '
        'DateTimePickerPesan
        '
        Me.DateTimePickerPesan.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePickerPesan.Location = New System.Drawing.Point(846, 17)
        Me.DateTimePickerPesan.Name = "DateTimePickerPesan"
        Me.DateTimePickerPesan.Size = New System.Drawing.Size(86, 20)
        Me.DateTimePickerPesan.TabIndex = 32
        '
        'DateTimePickerKirim
        '
        Me.DateTimePickerKirim.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePickerKirim.Location = New System.Drawing.Point(1047, 17)
        Me.DateTimePickerKirim.Name = "DateTimePickerKirim"
        Me.DateTimePickerKirim.Size = New System.Drawing.Size(86, 20)
        Me.DateTimePickerKirim.TabIndex = 31
        '
        'RadioButtonTglKirim
        '
        Me.RadioButtonTglKirim.AutoSize = True
        Me.RadioButtonTglKirim.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButtonTglKirim.Location = New System.Drawing.Point(957, 17)
        Me.RadioButtonTglKirim.Name = "RadioButtonTglKirim"
        Me.RadioButtonTglKirim.Size = New System.Drawing.Size(84, 20)
        Me.RadioButtonTglKirim.TabIndex = 30
        Me.RadioButtonTglKirim.Text = "Tgl Kirim :"
        Me.RadioButtonTglKirim.UseVisualStyleBackColor = True
        '
        'RadioButtonTglPesan
        '
        Me.RadioButtonTglPesan.AutoSize = True
        Me.RadioButtonTglPesan.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButtonTglPesan.Location = New System.Drawing.Point(751, 17)
        Me.RadioButtonTglPesan.Name = "RadioButtonTglPesan"
        Me.RadioButtonTglPesan.Size = New System.Drawing.Size(94, 20)
        Me.RadioButtonTglPesan.TabIndex = 29
        Me.RadioButtonTglPesan.Text = "Tgl Pesan :"
        Me.RadioButtonTglPesan.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Image = Global.TokoMaterial_App.My.Resources.Resources.toolbar_find
        Me.Label7.Location = New System.Drawing.Point(19, 23)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(28, 32)
        Me.Label7.TabIndex = 24
        Me.Label7.Text = "     " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "     "
        '
        'RadioButtonAlamat
        '
        Me.RadioButtonAlamat.AutoSize = True
        Me.RadioButtonAlamat.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButtonAlamat.Location = New System.Drawing.Point(378, 17)
        Me.RadioButtonAlamat.Name = "RadioButtonAlamat"
        Me.RadioButtonAlamat.Size = New System.Drawing.Size(129, 20)
        Me.RadioButtonAlamat.TabIndex = 23
        Me.RadioButtonAlamat.Text = "Alamat Penerima"
        Me.RadioButtonAlamat.UseVisualStyleBackColor = True
        '
        'RadioButtonPenerima
        '
        Me.RadioButtonPenerima.AutoSize = True
        Me.RadioButtonPenerima.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButtonPenerima.Location = New System.Drawing.Point(279, 17)
        Me.RadioButtonPenerima.Name = "RadioButtonPenerima"
        Me.RadioButtonPenerima.Size = New System.Drawing.Size(84, 20)
        Me.RadioButtonPenerima.TabIndex = 22
        Me.RadioButtonPenerima.Text = "Penerima"
        Me.RadioButtonPenerima.UseVisualStyleBackColor = True
        '
        'RadioButtonCustomer
        '
        Me.RadioButtonCustomer.AutoSize = True
        Me.RadioButtonCustomer.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButtonCustomer.Location = New System.Drawing.Point(186, 17)
        Me.RadioButtonCustomer.Name = "RadioButtonCustomer"
        Me.RadioButtonCustomer.Size = New System.Drawing.Size(92, 20)
        Me.RadioButtonCustomer.TabIndex = 21
        Me.RadioButtonCustomer.Text = "Pelanggan"
        Me.RadioButtonCustomer.UseVisualStyleBackColor = True
        '
        'RadioButtonPetugas
        '
        Me.RadioButtonPetugas.AutoSize = True
        Me.RadioButtonPetugas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButtonPetugas.Location = New System.Drawing.Point(108, 17)
        Me.RadioButtonPetugas.Name = "RadioButtonPetugas"
        Me.RadioButtonPetugas.Size = New System.Drawing.Size(76, 20)
        Me.RadioButtonPetugas.TabIndex = 19
        Me.RadioButtonPetugas.Text = "Petugas"
        Me.RadioButtonPetugas.UseVisualStyleBackColor = True
        '
        'RadioButtonID
        '
        Me.RadioButtonID.AutoSize = True
        Me.RadioButtonID.Checked = True
        Me.RadioButtonID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButtonID.Location = New System.Drawing.Point(65, 17)
        Me.RadioButtonID.Name = "RadioButtonID"
        Me.RadioButtonID.Size = New System.Drawing.Size(39, 20)
        Me.RadioButtonID.TabIndex = 18
        Me.RadioButtonID.TabStop = True
        Me.RadioButtonID.Text = "ID"
        Me.RadioButtonID.UseVisualStyleBackColor = True
        '
        'TextBoxCari
        '
        Me.TextBoxCari.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxCari.Location = New System.Drawing.Point(65, 45)
        Me.TextBoxCari.Multiline = True
        Me.TextBoxCari.Name = "TextBoxCari"
        Me.TextBoxCari.Size = New System.Drawing.Size(1068, 23)
        Me.TextBoxCari.TabIndex = 12
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(1145, 45)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(54, 23)
        Me.Button3.TabIndex = 17
        Me.Button3.Text = "Cari"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(973, 133)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(121, 20)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "Detail Sampel"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColumnId, Me.Column1, Me.Column2, Me.Column5, Me.Column3, Me.Column6, Me.Column7, Me.Column8, Me.Column9, Me.Column10})
        Me.DataGridView1.Location = New System.Drawing.Point(12, 160)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(943, 501)
        Me.DataGridView1.TabIndex = 22
        '
        'DataGridView2
        '
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column12, Me.Column13, Me.Column14})
        Me.DataGridView2.Location = New System.Drawing.Point(969, 160)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(369, 501)
        Me.DataGridView2.TabIndex = 26
        '
        'Column12
        '
        Me.Column12.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column12.HeaderText = "Barang"
        Me.Column12.Name = "Column12"
        '
        'Column13
        '
        Me.Column13.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column13.HeaderText = "Satuan"
        Me.Column13.Name = "Column13"
        '
        'Column14
        '
        Me.Column14.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column14.HeaderText = "Quantity"
        Me.Column14.Name = "Column14"
        '
        'ButtonClear
        '
        Me.ButtonClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonClear.Image = Global.TokoMaterial_App.My.Resources.Resources.edit_clear
        Me.ButtonClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonClear.Location = New System.Drawing.Point(253, 100)
        Me.ButtonClear.Name = "ButtonClear"
        Me.ButtonClear.Size = New System.Drawing.Size(87, 45)
        Me.ButtonClear.TabIndex = 46
        Me.ButtonClear.Text = "Clear"
        Me.ButtonClear.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonClear.UseVisualStyleBackColor = True
        '
        'ButtonCetak
        '
        Me.ButtonCetak.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonCetak.Image = Global.TokoMaterial_App.My.Resources.Resources.printer_1_
        Me.ButtonCetak.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonCetak.Location = New System.Drawing.Point(136, 100)
        Me.ButtonCetak.Name = "ButtonCetak"
        Me.ButtonCetak.Size = New System.Drawing.Size(96, 45)
        Me.ButtonCetak.TabIndex = 45
        Me.ButtonCetak.Text = "Cetak"
        Me.ButtonCetak.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonCetak.UseVisualStyleBackColor = True
        '
        'Hapus
        '
        Me.Hapus.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Hapus.Image = Global.TokoMaterial_App.My.Resources.Resources.cancel
        Me.Hapus.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Hapus.Location = New System.Drawing.Point(365, 100)
        Me.Hapus.Name = "Hapus"
        Me.Hapus.Size = New System.Drawing.Size(83, 45)
        Me.Hapus.TabIndex = 47
        Me.Hapus.Text = "Hapus"
        Me.Hapus.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Hapus.UseVisualStyleBackColor = True
        '
        'ColumnId
        '
        Me.ColumnId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ColumnId.HeaderText = "ID"
        Me.ColumnId.Name = "ColumnId"
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.Column1.HeaderText = "Petugas"
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 71
        '
        'Column2
        '
        Me.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column2.HeaderText = "Pelanggan"
        Me.Column2.Name = "Column2"
        '
        'Column5
        '
        Me.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column5.HeaderText = "Tgl Pesan"
        Me.Column5.Name = "Column5"
        Me.Column5.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'Column3
        '
        Me.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column3.HeaderText = "Tgl Kirim"
        Me.Column3.Name = "Column3"
        '
        'Column6
        '
        Me.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column6.HeaderText = "Penerima"
        Me.Column6.Name = "Column6"
        '
        'Column7
        '
        Me.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column7.HeaderText = "Alamat Penerima"
        Me.Column7.Name = "Column7"
        '
        'Column8
        '
        Me.Column8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column8.HeaderText = "Telp Penerima"
        Me.Column8.Name = "Column8"
        '
        'Column9
        '
        Me.Column9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column9.HeaderText = "Keterangan"
        Me.Column9.Name = "Column9"
        '
        'Column10
        '
        Me.Column10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column10.HeaderText = "Detail"
        Me.Column10.Name = "Column10"
        Me.Column10.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column10.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'Transaksi_Sampel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Highlight
        Me.ClientSize = New System.Drawing.Size(1350, 729)
        Me.Controls.Add(Me.Hapus)
        Me.Controls.Add(Me.ButtonClear)
        Me.Controls.Add(Me.ButtonCetak)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Transaksi_Sampel"
        Me.Text = "Transaksi_Sampel"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents DateTimePickerPesan As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePickerKirim As System.Windows.Forms.DateTimePicker
    Friend WithEvents RadioButtonTglKirim As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButtonTglPesan As System.Windows.Forms.RadioButton
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents RadioButtonAlamat As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButtonPenerima As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButtonCustomer As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButtonPetugas As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButtonID As System.Windows.Forms.RadioButton
    Friend WithEvents TextBoxCari As System.Windows.Forms.TextBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents RadioButtonKeterangan As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButtonTelp As System.Windows.Forms.RadioButton
    Friend WithEvents Column12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column14 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ButtonClear As System.Windows.Forms.Button
    Friend WithEvents ButtonCetak As System.Windows.Forms.Button
    Friend WithEvents Hapus As System.Windows.Forms.Button
    Friend WithEvents ColumnId As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column10 As System.Windows.Forms.DataGridViewButtonColumn
End Class
