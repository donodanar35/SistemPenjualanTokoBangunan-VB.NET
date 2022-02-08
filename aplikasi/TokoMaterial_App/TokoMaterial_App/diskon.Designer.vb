<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class diskon
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
        Me.ButtonTambah = New System.Windows.Forms.Button()
        Me.TextBoxPetugas = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TextBoxSatuan = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.TextBoxMinQty = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TextBoxProfitTransaksi = New System.Windows.Forms.TextBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.TextBoxCariBarang = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TextBoxDiskonIDR = New System.Windows.Forms.TextBox()
        Me.TextBoxProfitBrg = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TextBoxHDiskon = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TextBoxHJ = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TextBoxHB = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextBoxDiskonPersen = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ComboBoxBarang = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DateTimePickerMulai = New System.Windows.Forms.DateTimePicker()
        Me.TextBoxId = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBoxKet = New System.Windows.Forms.TextBox()
        Me.ButtonSimpan = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TextBoxPromo = New System.Windows.Forms.TextBox()
        Me.DateTimePickerAkhir = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ButtonNew = New System.Windows.Forms.Button()
        Me.ButtonCetak = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ButtonClear = New System.Windows.Forms.Button()
        Me.ColumnId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Username = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnDiskonIDR = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnMinQTy = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnHB = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnHJ = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnHDiskon = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnProfitPerBrg = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnProfitPerTrans = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnCancel = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtonTambah
        '
        Me.ButtonTambah.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonTambah.Image = Global.TokoMaterial_App.My.Resources.Resources.increase
        Me.ButtonTambah.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonTambah.Location = New System.Drawing.Point(218, 140)
        Me.ButtonTambah.Name = "ButtonTambah"
        Me.ButtonTambah.Size = New System.Drawing.Size(107, 35)
        Me.ButtonTambah.TabIndex = 40
        Me.ButtonTambah.Text = "Tambah"
        Me.ButtonTambah.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonTambah.UseVisualStyleBackColor = True
        '
        'TextBoxPetugas
        '
        Me.TextBoxPetugas.Enabled = False
        Me.TextBoxPetugas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxPetugas.Location = New System.Drawing.Point(98, 64)
        Me.TextBoxPetugas.Name = "TextBoxPetugas"
        Me.TextBoxPetugas.Size = New System.Drawing.Size(227, 22)
        Me.TextBoxPetugas.TabIndex = 29
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Button1)
        Me.GroupBox3.Controls.Add(Me.Button7)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.TextBoxSatuan)
        Me.GroupBox3.Controls.Add(Me.Label15)
        Me.GroupBox3.Controls.Add(Me.TextBoxMinQty)
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Controls.Add(Me.TextBoxProfitTransaksi)
        Me.GroupBox3.Controls.Add(Me.Button5)
        Me.GroupBox3.Controls.Add(Me.TextBoxCariBarang)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.TextBoxDiskonIDR)
        Me.GroupBox3.Controls.Add(Me.ButtonTambah)
        Me.GroupBox3.Controls.Add(Me.TextBoxProfitBrg)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.TextBoxHDiskon)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.TextBoxHJ)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.TextBoxHB)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.TextBoxDiskonPersen)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.ComboBoxBarang)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(12, 236)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(838, 189)
        Me.GroupBox3.TabIndex = 41
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Detail Diskon"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = Global.TokoMaterial_App.My.Resources.Resources.find1
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(353, 141)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(141, 35)
        Me.Button1.TabIndex = 45
        Me.Button1.Text = "Lihat Barang"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.Location = New System.Drawing.Point(291, 107)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(34, 24)
        Me.Button7.TabIndex = 53
        Me.Button7.Text = "Ok"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(290, 74)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(31, 16)
        Me.Label12.TabIndex = 52
        Me.Label12.Text = "IDR"
        '
        'TextBoxSatuan
        '
        Me.TextBoxSatuan.Enabled = False
        Me.TextBoxSatuan.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxSatuan.Location = New System.Drawing.Point(207, 107)
        Me.TextBoxSatuan.Name = "TextBoxSatuan"
        Me.TextBoxSatuan.Size = New System.Drawing.Size(77, 22)
        Me.TextBoxSatuan.TabIndex = 51
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(28, 107)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(58, 16)
        Me.Label15.TabIndex = 50
        Me.Label15.Text = "Min Qty :"
        '
        'TextBoxMinQty
        '
        Me.TextBoxMinQty.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxMinQty.Location = New System.Drawing.Point(98, 107)
        Me.TextBoxMinQty.Name = "TextBoxMinQty"
        Me.TextBoxMinQty.Size = New System.Drawing.Size(104, 22)
        Me.TextBoxMinQty.TabIndex = 49
        Me.TextBoxMinQty.Text = "0"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(509, 156)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(161, 16)
        Me.Label14.TabIndex = 48
        Me.Label14.Text = "Total Profit per Transaksi:"
        '
        'TextBoxProfitTransaksi
        '
        Me.TextBoxProfitTransaksi.Enabled = False
        Me.TextBoxProfitTransaksi.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxProfitTransaksi.Location = New System.Drawing.Point(687, 153)
        Me.TextBoxProfitTransaksi.Name = "TextBoxProfitTransaksi"
        Me.TextBoxProfitTransaksi.Size = New System.Drawing.Size(110, 22)
        Me.TextBoxProfitTransaksi.TabIndex = 47
        '
        'Button5
        '
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(436, 31)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(34, 24)
        Me.Button5.TabIndex = 46
        Me.Button5.Text = "Cari"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'TextBoxCariBarang
        '
        Me.TextBoxCariBarang.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxCariBarang.Location = New System.Drawing.Point(353, 31)
        Me.TextBoxCariBarang.Name = "TextBoxCariBarang"
        Me.TextBoxCariBarang.Size = New System.Drawing.Size(77, 22)
        Me.TextBoxCariBarang.TabIndex = 45
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(182, 71)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(20, 16)
        Me.Label13.TabIndex = 44
        Me.Label13.Text = "%"
        '
        'TextBoxDiskonIDR
        '
        Me.TextBoxDiskonIDR.Enabled = False
        Me.TextBoxDiskonIDR.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxDiskonIDR.Location = New System.Drawing.Point(208, 71)
        Me.TextBoxDiskonIDR.Name = "TextBoxDiskonIDR"
        Me.TextBoxDiskonIDR.Size = New System.Drawing.Size(76, 22)
        Me.TextBoxDiskonIDR.TabIndex = 41
        '
        'TextBoxProfitBrg
        '
        Me.TextBoxProfitBrg.Enabled = False
        Me.TextBoxProfitBrg.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxProfitBrg.Location = New System.Drawing.Point(687, 121)
        Me.TextBoxProfitBrg.Name = "TextBoxProfitBrg"
        Me.TextBoxProfitBrg.Size = New System.Drawing.Size(110, 22)
        Me.TextBoxProfitBrg.TabIndex = 21
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(559, 125)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(111, 16)
        Me.Label11.TabIndex = 20
        Me.Label11.Text = "Profit per Barang:"
        '
        'TextBoxHDiskon
        '
        Me.TextBoxHDiskon.Enabled = False
        Me.TextBoxHDiskon.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxHDiskon.Location = New System.Drawing.Point(687, 90)
        Me.TextBoxHDiskon.Name = "TextBoxHDiskon"
        Me.TextBoxHDiskon.Size = New System.Drawing.Size(110, 22)
        Me.TextBoxHDiskon.TabIndex = 19
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(496, 91)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(174, 16)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = "Harga Jual Setelah Diskon :"
        '
        'TextBoxHJ
        '
        Me.TextBoxHJ.Enabled = False
        Me.TextBoxHJ.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxHJ.Location = New System.Drawing.Point(687, 60)
        Me.TextBoxHJ.Name = "TextBoxHJ"
        Me.TextBoxHJ.Size = New System.Drawing.Size(110, 22)
        Me.TextBoxHJ.TabIndex = 17
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(592, 62)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(80, 16)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "Harga Jual :"
        '
        'TextBoxHB
        '
        Me.TextBoxHB.Enabled = False
        Me.TextBoxHB.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxHB.Location = New System.Drawing.Point(687, 31)
        Me.TextBoxHB.Name = "TextBoxHB"
        Me.TextBoxHB.Size = New System.Drawing.Size(110, 22)
        Me.TextBoxHB.TabIndex = 14
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(592, 31)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(78, 16)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Harga Beli :"
        '
        'TextBoxDiskonPersen
        '
        Me.TextBoxDiskonPersen.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxDiskonPersen.Location = New System.Drawing.Point(98, 68)
        Me.TextBoxDiskonPersen.Name = "TextBoxDiskonPersen"
        Me.TextBoxDiskonPersen.Size = New System.Drawing.Size(76, 22)
        Me.TextBoxDiskonPersen.TabIndex = 12
        Me.TextBoxDiskonPersen.Text = "0"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(30, 71)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(56, 16)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Diskon :"
        '
        'ComboBoxBarang
        '
        Me.ComboBoxBarang.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxBarang.FormattingEnabled = True
        Me.ComboBoxBarang.Items.AddRange(New Object() {"manager", "kasir", "admin"})
        Me.ComboBoxBarang.Location = New System.Drawing.Point(98, 31)
        Me.ComboBoxBarang.Name = "ComboBoxBarang"
        Me.ComboBoxBarang.Size = New System.Drawing.Size(223, 24)
        Me.ComboBoxBarang.TabIndex = 12
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(28, 31)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 16)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Barang :"
        '
        'DateTimePickerMulai
        '
        Me.DateTimePickerMulai.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePickerMulai.Location = New System.Drawing.Point(98, 136)
        Me.DateTimePickerMulai.Name = "DateTimePickerMulai"
        Me.DateTimePickerMulai.Size = New System.Drawing.Size(227, 20)
        Me.DateTimePickerMulai.TabIndex = 10
        '
        'TextBoxId
        '
        Me.TextBoxId.Enabled = False
        Me.TextBoxId.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxId.Location = New System.Drawing.Point(98, 27)
        Me.TextBoxId.Name = "TextBoxId"
        Me.TextBoxId.Size = New System.Drawing.Size(227, 22)
        Me.TextBoxId.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(38, 102)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 16)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Promo :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(30, 67)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 16)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Petugas :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(23, 136)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Tgl Mulai :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(65, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(27, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ID :"
        '
        'TextBoxKet
        '
        Me.TextBoxKet.Location = New System.Drawing.Point(17, 26)
        Me.TextBoxKet.Multiline = True
        Me.TextBoxKet.Name = "TextBoxKet"
        Me.TextBoxKet.Size = New System.Drawing.Size(178, 166)
        Me.TextBoxKet.TabIndex = 0
        '
        'ButtonSimpan
        '
        Me.ButtonSimpan.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonSimpan.Image = Global.TokoMaterial_App.My.Resources.Resources.filesaveas___edit
        Me.ButtonSimpan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonSimpan.Location = New System.Drawing.Point(233, 434)
        Me.ButtonSimpan.Name = "ButtonSimpan"
        Me.ButtonSimpan.Size = New System.Drawing.Size(104, 46)
        Me.ButtonSimpan.TabIndex = 42
        Me.ButtonSimpan.Text = "Simpan"
        Me.ButtonSimpan.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonSimpan.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TextBoxKet)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(379, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(211, 208)
        Me.GroupBox2.TabIndex = 37
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Keterangan"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TextBoxPromo)
        Me.GroupBox1.Controls.Add(Me.DateTimePickerAkhir)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.TextBoxPetugas)
        Me.GroupBox1.Controls.Add(Me.DateTimePickerMulai)
        Me.GroupBox1.Controls.Add(Me.TextBoxId)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(342, 207)
        Me.GroupBox1.TabIndex = 36
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Diskon"
        '
        'TextBoxPromo
        '
        Me.TextBoxPromo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxPromo.Location = New System.Drawing.Point(98, 100)
        Me.TextBoxPromo.Name = "TextBoxPromo"
        Me.TextBoxPromo.Size = New System.Drawing.Size(227, 22)
        Me.TextBoxPromo.TabIndex = 32
        '
        'DateTimePickerAkhir
        '
        Me.DateTimePickerAkhir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePickerAkhir.Location = New System.Drawing.Point(98, 171)
        Me.DateTimePickerAkhir.Name = "DateTimePickerAkhir"
        Me.DateTimePickerAkhir.Size = New System.Drawing.Size(227, 20)
        Me.DateTimePickerAkhir.TabIndex = 31
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(19, 171)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(67, 16)
        Me.Label7.TabIndex = 30
        Me.Label7.Text = "Tgl Akhir :"
        '
        'ButtonNew
        '
        Me.ButtonNew.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonNew.Image = Global.TokoMaterial_App.My.Resources.Resources.new_doc
        Me.ButtonNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonNew.Location = New System.Drawing.Point(8, 434)
        Me.ButtonNew.Name = "ButtonNew"
        Me.ButtonNew.Size = New System.Drawing.Size(96, 46)
        Me.ButtonNew.TabIndex = 43
        Me.ButtonNew.Text = "New"
        Me.ButtonNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonNew.UseVisualStyleBackColor = True
        '
        'ButtonCetak
        '
        Me.ButtonCetak.Enabled = False
        Me.ButtonCetak.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonCetak.Image = Global.TokoMaterial_App.My.Resources.Resources.printer_1_
        Me.ButtonCetak.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonCetak.Location = New System.Drawing.Point(456, 434)
        Me.ButtonCetak.Name = "ButtonCetak"
        Me.ButtonCetak.Size = New System.Drawing.Size(96, 46)
        Me.ButtonCetak.TabIndex = 39
        Me.ButtonCetak.Text = "Cetak"
        Me.ButtonCetak.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonCetak.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColumnId, Me.Username, Me.DataGridViewTextBoxColumn1, Me.ColumnDiskonIDR, Me.ColumnMinQTy, Me.ColumnHB, Me.ColumnHJ, Me.ColumnHDiskon, Me.ColumnProfitPerBrg, Me.ColumnProfitPerTrans, Me.ColumnCancel})
        Me.DataGridView1.Location = New System.Drawing.Point(12, 495)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(838, 216)
        Me.DataGridView1.TabIndex = 38
        '
        'ButtonClear
        '
        Me.ButtonClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonClear.Image = Global.TokoMaterial_App.My.Resources.Resources.edit_clear
        Me.ButtonClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonClear.Location = New System.Drawing.Point(754, 434)
        Me.ButtonClear.Name = "ButtonClear"
        Me.ButtonClear.Size = New System.Drawing.Size(96, 46)
        Me.ButtonClear.TabIndex = 44
        Me.ButtonClear.Text = "Clear"
        Me.ButtonClear.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonClear.UseVisualStyleBackColor = True
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
        Me.Username.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.Username.DataPropertyName = "id_brg"
        Me.Username.HeaderText = "Barang"
        Me.Username.Name = "Username"
        Me.Username.Width = 66
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "disc_persen"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Diskon%"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'ColumnDiskonIDR
        '
        Me.ColumnDiskonIDR.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ColumnDiskonIDR.HeaderText = "DiskonIDR"
        Me.ColumnDiskonIDR.Name = "ColumnDiskonIDR"
        '
        'ColumnMinQTy
        '
        Me.ColumnMinQTy.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ColumnMinQTy.HeaderText = "Min Qty"
        Me.ColumnMinQTy.Name = "ColumnMinQTy"
        '
        'ColumnHB
        '
        Me.ColumnHB.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ColumnHB.HeaderText = "Harga Beli"
        Me.ColumnHB.Name = "ColumnHB"
        '
        'ColumnHJ
        '
        Me.ColumnHJ.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ColumnHJ.HeaderText = "Harga Jual"
        Me.ColumnHJ.Name = "ColumnHJ"
        '
        'ColumnHDiskon
        '
        Me.ColumnHDiskon.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ColumnHDiskon.HeaderText = "Harga Diskon"
        Me.ColumnHDiskon.Name = "ColumnHDiskon"
        '
        'ColumnProfitPerBrg
        '
        Me.ColumnProfitPerBrg.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ColumnProfitPerBrg.HeaderText = "Profit Per Barang"
        Me.ColumnProfitPerBrg.Name = "ColumnProfitPerBrg"
        '
        'ColumnProfitPerTrans
        '
        Me.ColumnProfitPerTrans.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ColumnProfitPerTrans.HeaderText = "Profit Per Transaksi"
        Me.ColumnProfitPerTrans.Name = "ColumnProfitPerTrans"
        '
        'ColumnCancel
        '
        Me.ColumnCancel.HeaderText = "Cancel"
        Me.ColumnCancel.Name = "ColumnCancel"
        Me.ColumnCancel.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ColumnCancel.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'diskon
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Highlight
        Me.ClientSize = New System.Drawing.Size(862, 670)
        Me.Controls.Add(Me.ButtonClear)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.ButtonSimpan)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ButtonNew)
        Me.Controls.Add(Me.ButtonCetak)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "diskon"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Diskon"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ButtonTambah As System.Windows.Forms.Button
    Friend WithEvents TextBoxPetugas As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBoxDiskonPersen As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents ComboBoxBarang As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents DateTimePickerMulai As System.Windows.Forms.DateTimePicker
    Friend WithEvents TextBoxId As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBoxKet As System.Windows.Forms.TextBox
    Friend WithEvents ButtonSimpan As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ButtonNew As System.Windows.Forms.Button
    Friend WithEvents ButtonCetak As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents DateTimePickerAkhir As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TextBoxPromo As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents TextBoxProfitTransaksi As System.Windows.Forms.TextBox
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents TextBoxCariBarang As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents TextBoxDiskonIDR As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxProfitBrg As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents TextBoxHDiskon As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents TextBoxHJ As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TextBoxHB As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents TextBoxSatuan As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents TextBoxMinQty As System.Windows.Forms.TextBox
    Friend WithEvents ButtonClear As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ColumnId As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Username As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColumnDiskonIDR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColumnMinQTy As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColumnHB As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColumnHJ As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColumnHDiskon As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColumnProfitPerBrg As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColumnProfitPerTrans As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColumnCancel As System.Windows.Forms.DataGridViewButtonColumn
End Class
