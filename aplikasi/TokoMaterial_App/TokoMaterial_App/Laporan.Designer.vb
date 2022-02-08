<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Laporan
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
        Me.DateTimePickerAwal = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePickerAkir = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ButtonCetak = New System.Windows.Forms.Button()
        Me.GroupBoxLaporan = New System.Windows.Forms.GroupBox()
        Me.GroupBoxLaporan.SuspendLayout()
        Me.SuspendLayout()
        '
        'DateTimePickerAwal
        '
        Me.DateTimePickerAwal.Location = New System.Drawing.Point(80, 30)
        Me.DateTimePickerAwal.Name = "DateTimePickerAwal"
        Me.DateTimePickerAwal.Size = New System.Drawing.Size(163, 22)
        Me.DateTimePickerAwal.TabIndex = 0
        '
        'DateTimePickerAkir
        '
        Me.DateTimePickerAkir.Location = New System.Drawing.Point(80, 60)
        Me.DateTimePickerAkir.Name = "DateTimePickerAkir"
        Me.DateTimePickerAkir.Size = New System.Drawing.Size(163, 22)
        Me.DateTimePickerAkir.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(24, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 16)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Awal :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(22, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 16)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Akhir :"
        '
        'ButtonCetak
        '
        Me.ButtonCetak.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonCetak.Image = Global.TokoMaterial_App.My.Resources.Resources.printer_1_
        Me.ButtonCetak.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonCetak.Location = New System.Drawing.Point(102, 94)
        Me.ButtonCetak.Name = "ButtonCetak"
        Me.ButtonCetak.Size = New System.Drawing.Size(96, 45)
        Me.ButtonCetak.TabIndex = 24
        Me.ButtonCetak.Text = "Cetak"
        Me.ButtonCetak.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonCetak.UseVisualStyleBackColor = True
        '
        'GroupBoxLaporan
        '
        Me.GroupBoxLaporan.Controls.Add(Me.Label1)
        Me.GroupBoxLaporan.Controls.Add(Me.ButtonCetak)
        Me.GroupBoxLaporan.Controls.Add(Me.DateTimePickerAwal)
        Me.GroupBoxLaporan.Controls.Add(Me.Label2)
        Me.GroupBoxLaporan.Controls.Add(Me.DateTimePickerAkir)
        Me.GroupBoxLaporan.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBoxLaporan.Location = New System.Drawing.Point(12, 12)
        Me.GroupBoxLaporan.Name = "GroupBoxLaporan"
        Me.GroupBoxLaporan.Size = New System.Drawing.Size(269, 149)
        Me.GroupBoxLaporan.TabIndex = 25
        Me.GroupBoxLaporan.TabStop = False
        Me.GroupBoxLaporan.Text = "Cetak Laporan Penjualan Periodik"
        '
        'Laporan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Highlight
        Me.ClientSize = New System.Drawing.Size(293, 173)
        Me.Controls.Add(Me.GroupBoxLaporan)
        Me.MaximizeBox = False
        Me.Name = "Laporan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cetak Laporan"
        Me.GroupBoxLaporan.ResumeLayout(False)
        Me.GroupBoxLaporan.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DateTimePickerAwal As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePickerAkir As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ButtonCetak As System.Windows.Forms.Button
    Friend WithEvents GroupBoxLaporan As System.Windows.Forms.GroupBox
End Class
