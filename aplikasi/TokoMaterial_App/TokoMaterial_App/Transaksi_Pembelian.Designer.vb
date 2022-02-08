<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Transaksi_Pembelian
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
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.Column12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.RadioButtonKeterangan = New System.Windows.Forms.RadioButton()
        Me.DateTimePickerPesan = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePickerKirim = New System.Windows.Forms.DateTimePicker()
        Me.RadioButtonTglKirim = New System.Windows.Forms.RadioButton()
        Me.RadioButtonTglPesan = New System.Windows.Forms.RadioButton()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.RadioButtonSuplier = New System.Windows.Forms.RadioButton()
        Me.RadioButtonPetugas = New System.Windows.Forms.RadioButton()
        Me.RadioButtonID = New System.Windows.Forms.RadioButton()
        Me.TextBoxCari = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Hapus = New System.Windows.Forms.Button()
        Me.ButtonClear = New System.Windows.Forms.Button()
        Me.ButtonCetak = New System.Windows.Forms.Button()
        Me.ColumnId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column10 = New System.Windows.Forms.DataGridViewButtonColumn()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView2
        '
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column12, Me.Column14, Me.Column13, Me.Column11, Me.Column17})
        Me.DataGridView2.Location = New System.Drawing.Point(813, 160)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(525, 501)
        Me.DataGridView2.TabIndex = 60
        '
        'Column12
        '
        Me.Column12.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column12.HeaderText = "Barang"
        Me.Column12.Name = "Column12"
        '
        'Column14
        '
        Me.Column14.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column14.HeaderText = "Quantity"
        Me.Column14.Name = "Column14"
        '
        'Column13
        '
        Me.Column13.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column13.HeaderText = "Satuan"
        Me.Column13.Name = "Column13"
        '
        'Column11
        '
        Me.Column11.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column11.HeaderText = "Harga Jual"
        Me.Column11.Name = "Column11"
        '
        'Column17
        '
        Me.Column17.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column17.HeaderText = "Subtotal"
        Me.Column17.Name = "Column17"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 133)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 20)
        Me.Label3.TabIndex = 59
        Me.Label3.Text = "Pembelian"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.RadioButtonKeterangan)
        Me.GroupBox3.Controls.Add(Me.DateTimePickerPesan)
        Me.GroupBox3.Controls.Add(Me.DateTimePickerKirim)
        Me.GroupBox3.Controls.Add(Me.RadioButtonTglKirim)
        Me.GroupBox3.Controls.Add(Me.RadioButtonTglPesan)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.RadioButtonSuplier)
        Me.GroupBox3.Controls.Add(Me.RadioButtonPetugas)
        Me.GroupBox3.Controls.Add(Me.RadioButtonID)
        Me.GroupBox3.Controls.Add(Me.TextBoxCari)
        Me.GroupBox3.Controls.Add(Me.Button3)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(1293, 82)
        Me.GroupBox3.TabIndex = 58
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Pencarian :"
        '
        'RadioButtonKeterangan
        '
        Me.RadioButtonKeterangan.AutoSize = True
        Me.RadioButtonKeterangan.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButtonKeterangan.Location = New System.Drawing.Point(316, 17)
        Me.RadioButtonKeterangan.Name = "RadioButtonKeterangan"
        Me.RadioButtonKeterangan.Size = New System.Drawing.Size(95, 20)
        Me.RadioButtonKeterangan.TabIndex = 34
        Me.RadioButtonKeterangan.Text = "Keterangan"
        Me.RadioButtonKeterangan.UseVisualStyleBackColor = True
        '
        'DateTimePickerPesan
        '
        Me.DateTimePickerPesan.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePickerPesan.Location = New System.Drawing.Point(519, 19)
        Me.DateTimePickerPesan.Name = "DateTimePickerPesan"
        Me.DateTimePickerPesan.Size = New System.Drawing.Size(86, 20)
        Me.DateTimePickerPesan.TabIndex = 32
        '
        'DateTimePickerKirim
        '
        Me.DateTimePickerKirim.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePickerKirim.Location = New System.Drawing.Point(717, 19)
        Me.DateTimePickerKirim.Name = "DateTimePickerKirim"
        Me.DateTimePickerKirim.Size = New System.Drawing.Size(86, 20)
        Me.DateTimePickerKirim.TabIndex = 31
        '
        'RadioButtonTglKirim
        '
        Me.RadioButtonTglKirim.AutoSize = True
        Me.RadioButtonTglKirim.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButtonTglKirim.Location = New System.Drawing.Point(627, 19)
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
        Me.RadioButtonTglPesan.Location = New System.Drawing.Point(424, 19)
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
        'RadioButtonSuplier
        '
        Me.RadioButtonSuplier.AutoSize = True
        Me.RadioButtonSuplier.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButtonSuplier.Location = New System.Drawing.Point(226, 19)
        Me.RadioButtonSuplier.Name = "RadioButtonSuplier"
        Me.RadioButtonSuplier.Size = New System.Drawing.Size(84, 20)
        Me.RadioButtonSuplier.TabIndex = 21
        Me.RadioButtonSuplier.Text = "Pemasok"
        Me.RadioButtonSuplier.UseVisualStyleBackColor = True
        '
        'RadioButtonPetugas
        '
        Me.RadioButtonPetugas.AutoSize = True
        Me.RadioButtonPetugas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButtonPetugas.Location = New System.Drawing.Point(144, 19)
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
        Me.RadioButtonID.Location = New System.Drawing.Point(90, 19)
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
        Me.TextBoxCari.Size = New System.Drawing.Size(738, 23)
        Me.TextBoxCari.TabIndex = 12
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(811, 45)
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
        Me.Label1.Location = New System.Drawing.Point(819, 137)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(144, 20)
        Me.Label1.TabIndex = 57
        Me.Label1.Text = "Detail Pembelian"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColumnId, Me.Column1, Me.Column2, Me.Column5, Me.Column3, Me.Column9, Me.Column10})
        Me.DataGridView1.Location = New System.Drawing.Point(12, 160)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(786, 501)
        Me.DataGridView1.TabIndex = 56
        '
        'Hapus
        '
        Me.Hapus.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Hapus.Image = Global.TokoMaterial_App.My.Resources.Resources.cancel
        Me.Hapus.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Hapus.Location = New System.Drawing.Point(365, 100)
        Me.Hapus.Name = "Hapus"
        Me.Hapus.Size = New System.Drawing.Size(83, 45)
        Me.Hapus.TabIndex = 63
        Me.Hapus.Text = "Hapus"
        Me.Hapus.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Hapus.UseVisualStyleBackColor = True
        '
        'ButtonClear
        '
        Me.ButtonClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonClear.Image = Global.TokoMaterial_App.My.Resources.Resources.edit_clear
        Me.ButtonClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonClear.Location = New System.Drawing.Point(253, 100)
        Me.ButtonClear.Name = "ButtonClear"
        Me.ButtonClear.Size = New System.Drawing.Size(87, 45)
        Me.ButtonClear.TabIndex = 62
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
        Me.ButtonCetak.TabIndex = 61
        Me.ButtonCetak.Text = "Cetak"
        Me.ButtonCetak.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonCetak.UseVisualStyleBackColor = True
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
        Me.Column2.HeaderText = "Pemasok"
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
        'Transaksi_Pembelian
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
        Me.Name = "Transaksi_Pembelian"
        Me.Text = "Transaksi_Pembelian"
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Hapus As System.Windows.Forms.Button
    Friend WithEvents ButtonClear As System.Windows.Forms.Button
    Friend WithEvents ButtonCetak As System.Windows.Forms.Button
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents RadioButtonKeterangan As System.Windows.Forms.RadioButton
    Friend WithEvents DateTimePickerPesan As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePickerKirim As System.Windows.Forms.DateTimePicker
    Friend WithEvents RadioButtonTglKirim As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButtonTglPesan As System.Windows.Forms.RadioButton
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents RadioButtonSuplier As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButtonPetugas As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButtonID As System.Windows.Forms.RadioButton
    Friend WithEvents TextBoxCari As System.Windows.Forms.TextBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Column12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column14 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column17 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColumnId As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column10 As System.Windows.Forms.DataGridViewButtonColumn
End Class
