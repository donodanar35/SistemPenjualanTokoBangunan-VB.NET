<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class stok
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
        Me.ButtonClear = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.ButtonCetak = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DateTimePickerKirim = New System.Windows.Forms.DateTimePicker()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.RadioButtonIn = New System.Windows.Forms.RadioButton()
        Me.RadioButtonOut = New System.Windows.Forms.RadioButton()
        Me.TextBoxPetugas = New System.Windows.Forms.TextBox()
        Me.TextBoxRef = New System.Windows.Forms.TextBox()
        Me.DateTimePickerTgl = New System.Windows.Forms.DateTimePicker()
        Me.TextBoxId = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ButtonSimpan = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.TextBoxStok = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextBoxNRusak = New System.Windows.Forms.TextBox()
        Me.TextBoxNBaik = New System.Windows.Forms.TextBox()
        Me.TextBoxHB = New System.Windows.Forms.TextBox()
        Me.TextBoxQty = New System.Windows.Forms.TextBox()
        Me.TextBoxSatuan = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBoxSubtotal = New System.Windows.Forms.TextBox()
        Me.LabelHarga = New System.Windows.Forms.Label()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.TextBoxCariBarang = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ComboBoxBarang = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ButtonTambah = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DateTimePickerTerima = New System.Windows.Forms.DateTimePicker()
        Me.LabelTerima = New System.Windows.Forms.Label()
        Me.TextBoxTotal = New System.Windows.Forms.TextBox()
        Me.TextBoxTItem = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TextBoxKet = New System.Windows.Forms.TextBox()
        Me.ColumnId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Username = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.password = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.N_Baik = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.N_Rusak = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Harga = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnSatuan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cancel = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'ButtonClear
        '
        Me.ButtonClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonClear.Image = Global.TokoMaterial_App.My.Resources.Resources.edit_clear
        Me.ButtonClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonClear.Location = New System.Drawing.Point(609, 428)
        Me.ButtonClear.Name = "ButtonClear"
        Me.ButtonClear.Size = New System.Drawing.Size(96, 45)
        Me.ButtonClear.TabIndex = 43
        Me.ButtonClear.Text = "Clear"
        Me.ButtonClear.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonClear.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Image = Global.TokoMaterial_App.My.Resources.Resources.new_doc
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button4.Location = New System.Drawing.Point(12, 428)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(93, 45)
        Me.Button4.TabIndex = 42
        Me.Button4.Text = "New"
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button4.UseVisualStyleBackColor = True
        '
        'ButtonCetak
        '
        Me.ButtonCetak.Enabled = False
        Me.ButtonCetak.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonCetak.Image = Global.TokoMaterial_App.My.Resources.Resources.printer_1_
        Me.ButtonCetak.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonCetak.Location = New System.Drawing.Point(413, 428)
        Me.ButtonCetak.Name = "ButtonCetak"
        Me.ButtonCetak.Size = New System.Drawing.Size(96, 45)
        Me.ButtonCetak.TabIndex = 39
        Me.ButtonCetak.Text = "Cetak"
        Me.ButtonCetak.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonCetak.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DateTimePickerKirim)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.GroupBox4)
        Me.GroupBox1.Controls.Add(Me.TextBoxPetugas)
        Me.GroupBox1.Controls.Add(Me.TextBoxRef)
        Me.GroupBox1.Controls.Add(Me.DateTimePickerTgl)
        Me.GroupBox1.Controls.Add(Me.TextBoxId)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(342, 256)
        Me.GroupBox1.TabIndex = 37
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Persediaan"
        '
        'DateTimePickerKirim
        '
        Me.DateTimePickerKirim.Enabled = False
        Me.DateTimePickerKirim.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePickerKirim.Location = New System.Drawing.Point(98, 167)
        Me.DateTimePickerKirim.Name = "DateTimePickerKirim"
        Me.DateTimePickerKirim.Size = New System.Drawing.Size(227, 20)
        Me.DateTimePickerKirim.TabIndex = 41
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(16, 171)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(66, 16)
        Me.Label9.TabIndex = 40
        Me.Label9.Text = "Tgl Kirim :"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.RadioButtonIn)
        Me.GroupBox4.Controls.Add(Me.RadioButtonOut)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(22, 198)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(303, 48)
        Me.GroupBox4.TabIndex = 39
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Masuk / Keluar"
        '
        'RadioButtonIn
        '
        Me.RadioButtonIn.AutoSize = True
        Me.RadioButtonIn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButtonIn.Location = New System.Drawing.Point(78, 20)
        Me.RadioButtonIn.Name = "RadioButtonIn"
        Me.RadioButtonIn.Size = New System.Drawing.Size(66, 20)
        Me.RadioButtonIn.TabIndex = 33
        Me.RadioButtonIn.Text = "masuk"
        Me.RadioButtonIn.UseVisualStyleBackColor = True
        '
        'RadioButtonOut
        '
        Me.RadioButtonOut.AutoSize = True
        Me.RadioButtonOut.Checked = True
        Me.RadioButtonOut.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButtonOut.Location = New System.Drawing.Point(221, 21)
        Me.RadioButtonOut.Name = "RadioButtonOut"
        Me.RadioButtonOut.Size = New System.Drawing.Size(63, 20)
        Me.RadioButtonOut.TabIndex = 34
        Me.RadioButtonOut.TabStop = True
        Me.RadioButtonOut.Text = "keluar"
        Me.RadioButtonOut.UseVisualStyleBackColor = True
        '
        'TextBoxPetugas
        '
        Me.TextBoxPetugas.Enabled = False
        Me.TextBoxPetugas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxPetugas.Location = New System.Drawing.Point(98, 68)
        Me.TextBoxPetugas.Name = "TextBoxPetugas"
        Me.TextBoxPetugas.Size = New System.Drawing.Size(227, 22)
        Me.TextBoxPetugas.TabIndex = 31
        '
        'TextBoxRef
        '
        Me.TextBoxRef.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxRef.Location = New System.Drawing.Point(98, 101)
        Me.TextBoxRef.Name = "TextBoxRef"
        Me.TextBoxRef.Size = New System.Drawing.Size(227, 22)
        Me.TextBoxRef.TabIndex = 29
        '
        'DateTimePickerTgl
        '
        Me.DateTimePickerTgl.Enabled = False
        Me.DateTimePickerTgl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePickerTgl.Location = New System.Drawing.Point(98, 135)
        Me.DateTimePickerTgl.Name = "DateTimePickerTgl"
        Me.DateTimePickerTgl.Size = New System.Drawing.Size(227, 20)
        Me.DateTimePickerTgl.TabIndex = 10
        '
        'TextBoxId
        '
        Me.TextBoxId.Enabled = False
        Me.TextBoxId.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxId.Location = New System.Drawing.Point(98, 32)
        Me.TextBoxId.Name = "TextBoxId"
        Me.TextBoxId.Size = New System.Drawing.Size(227, 22)
        Me.TextBoxId.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(8, 105)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 16)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Referensi :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(16, 69)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 16)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Petugas :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(4, 139)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Tgl Pesan :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(55, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(25, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Id :"
        '
        'ButtonSimpan
        '
        Me.ButtonSimpan.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonSimpan.Image = Global.TokoMaterial_App.My.Resources.Resources.document_save
        Me.ButtonSimpan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonSimpan.Location = New System.Drawing.Point(212, 428)
        Me.ButtonSimpan.Name = "ButtonSimpan"
        Me.ButtonSimpan.Size = New System.Drawing.Size(106, 45)
        Me.ButtonSimpan.TabIndex = 41
        Me.ButtonSimpan.Text = "Simpan"
        Me.ButtonSimpan.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonSimpan.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColumnId, Me.Username, Me.password, Me.N_Baik, Me.N_Rusak, Me.Harga, Me.ColumnSatuan, Me.Column1, Me.Cancel})
        Me.DataGridView1.Location = New System.Drawing.Point(12, 484)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(693, 191)
        Me.DataGridView1.TabIndex = 38
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.TextBoxStok)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.TextBoxNRusak)
        Me.GroupBox3.Controls.Add(Me.TextBoxNBaik)
        Me.GroupBox3.Controls.Add(Me.TextBoxHB)
        Me.GroupBox3.Controls.Add(Me.TextBoxQty)
        Me.GroupBox3.Controls.Add(Me.TextBoxSatuan)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.Button1)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.TextBoxSubtotal)
        Me.GroupBox3.Controls.Add(Me.LabelHarga)
        Me.GroupBox3.Controls.Add(Me.Button5)
        Me.GroupBox3.Controls.Add(Me.TextBoxCariBarang)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.ComboBoxBarang)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.ButtonTambah)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(12, 274)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(693, 141)
        Me.GroupBox3.TabIndex = 40
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Transaksi Barang"
        '
        'TextBoxStok
        '
        Me.TextBoxStok.Enabled = False
        Me.TextBoxStok.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxStok.Location = New System.Drawing.Point(597, 108)
        Me.TextBoxStok.Name = "TextBoxStok"
        Me.TextBoxStok.Size = New System.Drawing.Size(75, 22)
        Me.TextBoxStok.TabIndex = 51
        Me.TextBoxStok.Text = "0"
        Me.TextBoxStok.Visible = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(594, 89)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(41, 16)
        Me.Label8.TabIndex = 50
        Me.Label8.Text = "Stok :"
        Me.Label8.Visible = False
        '
        'TextBoxNRusak
        '
        Me.TextBoxNRusak.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxNRusak.Location = New System.Drawing.Point(191, 110)
        Me.TextBoxNRusak.Name = "TextBoxNRusak"
        Me.TextBoxNRusak.Size = New System.Drawing.Size(75, 22)
        Me.TextBoxNRusak.TabIndex = 49
        Me.TextBoxNRusak.Text = "0"
        '
        'TextBoxNBaik
        '
        Me.TextBoxNBaik.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxNBaik.Location = New System.Drawing.Point(91, 110)
        Me.TextBoxNBaik.Name = "TextBoxNBaik"
        Me.TextBoxNBaik.Size = New System.Drawing.Size(75, 22)
        Me.TextBoxNBaik.TabIndex = 48
        Me.TextBoxNBaik.Text = "0"
        '
        'TextBoxHB
        '
        Me.TextBoxHB.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxHB.Location = New System.Drawing.Point(550, 31)
        Me.TextBoxHB.Name = "TextBoxHB"
        Me.TextBoxHB.Size = New System.Drawing.Size(122, 22)
        Me.TextBoxHB.TabIndex = 47
        Me.TextBoxHB.Text = "0.00"
        '
        'TextBoxQty
        '
        Me.TextBoxQty.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxQty.Location = New System.Drawing.Point(87, 64)
        Me.TextBoxQty.Name = "TextBoxQty"
        Me.TextBoxQty.Size = New System.Drawing.Size(160, 22)
        Me.TextBoxQty.TabIndex = 44
        Me.TextBoxQty.Text = "0"
        '
        'TextBoxSatuan
        '
        Me.TextBoxSatuan.Enabled = False
        Me.TextBoxSatuan.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxSatuan.Location = New System.Drawing.Point(253, 64)
        Me.TextBoxSatuan.Name = "TextBoxSatuan"
        Me.TextBoxSatuan.Size = New System.Drawing.Size(72, 22)
        Me.TextBoxSatuan.TabIndex = 43
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(178, 91)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(100, 16)
        Me.Label11.TabIndex = 41
        Me.Label11.Text = "Kondisi Rusak :"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(84, 91)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(88, 16)
        Me.Label10.TabIndex = 39
        Me.Label10.Text = "Kondisi Baik :"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = Global.TokoMaterial_App.My.Resources.Resources.find1
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(403, 97)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(141, 35)
        Me.Button1.TabIndex = 38
        Me.Button1.Text = "Lihat Barang"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(481, 62)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(63, 16)
        Me.Label7.TabIndex = 37
        Me.Label7.Text = "Subtotal :"
        '
        'TextBoxSubtotal
        '
        Me.TextBoxSubtotal.Enabled = False
        Me.TextBoxSubtotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxSubtotal.Location = New System.Drawing.Point(550, 59)
        Me.TextBoxSubtotal.Name = "TextBoxSubtotal"
        Me.TextBoxSubtotal.Size = New System.Drawing.Size(122, 22)
        Me.TextBoxSubtotal.TabIndex = 36
        Me.TextBoxSubtotal.Text = "0.00"
        '
        'LabelHarga
        '
        Me.LabelHarga.AutoSize = True
        Me.LabelHarga.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelHarga.Location = New System.Drawing.Point(466, 30)
        Me.LabelHarga.Name = "LabelHarga"
        Me.LabelHarga.Size = New System.Drawing.Size(78, 16)
        Me.LabelHarga.TabIndex = 35
        Me.LabelHarga.Text = "Harga Beli :"
        '
        'Button5
        '
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(403, 32)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(33, 25)
        Me.Button5.TabIndex = 33
        Me.Button5.Text = "Cari"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'TextBoxCariBarang
        '
        Me.TextBoxCariBarang.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxCariBarang.Location = New System.Drawing.Point(331, 33)
        Me.TextBoxCariBarang.Name = "TextBoxCariBarang"
        Me.TextBoxCariBarang.Size = New System.Drawing.Size(65, 22)
        Me.TextBoxCariBarang.TabIndex = 32
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(19, 64)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(62, 16)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Quantity :"
        '
        'ComboBoxBarang
        '
        Me.ComboBoxBarang.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxBarang.FormattingEnabled = True
        Me.ComboBoxBarang.Items.AddRange(New Object() {"manager", "kasir", "admin"})
        Me.ComboBoxBarang.Location = New System.Drawing.Point(87, 31)
        Me.ComboBoxBarang.Name = "ComboBoxBarang"
        Me.ComboBoxBarang.Size = New System.Drawing.Size(238, 24)
        Me.ComboBoxBarang.TabIndex = 12
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(23, 31)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 16)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Barang :"
        '
        'ButtonTambah
        '
        Me.ButtonTambah.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonTambah.Image = Global.TokoMaterial_App.My.Resources.Resources.add
        Me.ButtonTambah.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonTambah.Location = New System.Drawing.Point(292, 97)
        Me.ButtonTambah.Name = "ButtonTambah"
        Me.ButtonTambah.Size = New System.Drawing.Size(104, 35)
        Me.ButtonTambah.TabIndex = 32
        Me.ButtonTambah.Text = "Tambah"
        Me.ButtonTambah.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonTambah.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DateTimePickerTerima)
        Me.GroupBox2.Controls.Add(Me.LabelTerima)
        Me.GroupBox2.Controls.Add(Me.TextBoxTotal)
        Me.GroupBox2.Controls.Add(Me.TextBoxTItem)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.TextBoxKet)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(371, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(334, 256)
        Me.GroupBox2.TabIndex = 39
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Keterangan"
        '
        'DateTimePickerTerima
        '
        Me.DateTimePickerTerima.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePickerTerima.Location = New System.Drawing.Point(108, 101)
        Me.DateTimePickerTerima.Name = "DateTimePickerTerima"
        Me.DateTimePickerTerima.Size = New System.Drawing.Size(131, 20)
        Me.DateTimePickerTerima.TabIndex = 43
        Me.DateTimePickerTerima.Visible = False
        '
        'LabelTerima
        '
        Me.LabelTerima.AutoSize = True
        Me.LabelTerima.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTerima.Location = New System.Drawing.Point(14, 104)
        Me.LabelTerima.Name = "LabelTerima"
        Me.LabelTerima.Size = New System.Drawing.Size(80, 16)
        Me.LabelTerima.TabIndex = 42
        Me.LabelTerima.Text = "Tgl Terima :"
        Me.LabelTerima.Visible = False
        '
        'TextBoxTotal
        '
        Me.TextBoxTotal.Enabled = False
        Me.TextBoxTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxTotal.Location = New System.Drawing.Point(108, 167)
        Me.TextBoxTotal.Name = "TextBoxTotal"
        Me.TextBoxTotal.Size = New System.Drawing.Size(131, 22)
        Me.TextBoxTotal.TabIndex = 45
        Me.TextBoxTotal.Text = "0.00"
        '
        'TextBoxTItem
        '
        Me.TextBoxTItem.Enabled = False
        Me.TextBoxTItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxTItem.Location = New System.Drawing.Point(110, 136)
        Me.TextBoxTItem.Name = "TextBoxTItem"
        Me.TextBoxTItem.Size = New System.Drawing.Size(129, 22)
        Me.TextBoxTItem.TabIndex = 46
        Me.TextBoxTItem.Text = "0"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(21, 139)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(73, 16)
        Me.Label13.TabIndex = 45
        Me.Label13.Text = "Total Item :"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(49, 167)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(45, 16)
        Me.Label12.TabIndex = 44
        Me.Label12.Text = "Total :"
        '
        'TextBoxKet
        '
        Me.TextBoxKet.Location = New System.Drawing.Point(17, 32)
        Me.TextBoxKet.Multiline = True
        Me.TextBoxKet.Name = "TextBoxKet"
        Me.TextBoxKet.Size = New System.Drawing.Size(222, 58)
        Me.TextBoxKet.TabIndex = 0
        '
        'ColumnId
        '
        Me.ColumnId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ColumnId.HeaderText = "ID"
        Me.ColumnId.Name = "ColumnId"
        Me.ColumnId.Visible = False
        '
        'Username
        '
        Me.Username.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Username.DataPropertyName = "id_brg"
        Me.Username.HeaderText = "Barang"
        Me.Username.Name = "Username"
        '
        'password
        '
        Me.password.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.password.DataPropertyName = "qty_beli"
        Me.password.HeaderText = "Quantity"
        Me.password.Name = "password"
        '
        'N_Baik
        '
        Me.N_Baik.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.N_Baik.HeaderText = "Kondisi Baik"
        Me.N_Baik.Name = "N_Baik"
        '
        'N_Rusak
        '
        Me.N_Rusak.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.N_Rusak.HeaderText = "Kondisi Rusak"
        Me.N_Rusak.Name = "N_Rusak"
        '
        'Harga
        '
        Me.Harga.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Harga.DataPropertyName = "harga_beli"
        Me.Harga.HeaderText = "Harga Beli"
        Me.Harga.Name = "Harga"
        '
        'ColumnSatuan
        '
        Me.ColumnSatuan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ColumnSatuan.HeaderText = "Subtotal"
        Me.ColumnSatuan.Name = "ColumnSatuan"
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column1.HeaderText = "Stok"
        Me.Column1.Name = "Column1"
        Me.Column1.Visible = False
        '
        'Cancel
        '
        Me.Cancel.HeaderText = "Cancel"
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Cancel.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'stok
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Highlight
        Me.ClientSize = New System.Drawing.Size(717, 685)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.ButtonClear)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.ButtonCetak)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ButtonSimpan)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Name = "stok"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Persediaan"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ButtonClear As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents ButtonCetak As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBoxPetugas As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxRef As System.Windows.Forms.TextBox
    Friend WithEvents DateTimePickerTgl As System.Windows.Forms.DateTimePicker
    Friend WithEvents TextBoxId As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ButtonSimpan As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TextBoxSubtotal As System.Windows.Forms.TextBox
    Friend WithEvents LabelHarga As System.Windows.Forms.Label
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents TextBoxCariBarang As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents ComboBoxBarang As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ButtonTambah As System.Windows.Forms.Button
    Friend WithEvents RadioButtonOut As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButtonIn As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBoxKet As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents TextBoxTItem As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents TextBoxSatuan As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBoxHB As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxQty As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxTotal As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxNRusak As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxNBaik As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxStok As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents DateTimePickerKirim As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents DateTimePickerTerima As System.Windows.Forms.DateTimePicker
    Friend WithEvents LabelTerima As System.Windows.Forms.Label
    Friend WithEvents ColumnId As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Username As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents password As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents N_Baik As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents N_Rusak As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Harga As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColumnSatuan As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Cancel As System.Windows.Forms.DataGridViewButtonColumn
End Class
