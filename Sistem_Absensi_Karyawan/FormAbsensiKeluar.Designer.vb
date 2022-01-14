<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAbsensiKeluar
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
        Me.BtnTambahAbsensi = New System.Windows.Forms.Button()
        Me.DtpTanggal = New System.Windows.Forms.DateTimePicker()
        Me.LblTanggal = New System.Windows.Forms.Label()
        Me.DtpAbsenKeluar = New System.Windows.Forms.DateTimePicker()
        Me.LblAbsenKeluar = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lblabsensi = New System.Windows.Forms.Label()
        Me.LblNama = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'BtnTambahAbsensi
        '
        Me.BtnTambahAbsensi.Location = New System.Drawing.Point(514, 327)
        Me.BtnTambahAbsensi.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnTambahAbsensi.Name = "BtnTambahAbsensi"
        Me.BtnTambahAbsensi.Size = New System.Drawing.Size(107, 23)
        Me.BtnTambahAbsensi.TabIndex = 43
        Me.BtnTambahAbsensi.Text = "Tambah Absensi"
        Me.BtnTambahAbsensi.UseVisualStyleBackColor = True
        '
        'DtpTanggal
        '
        Me.DtpTanggal.Enabled = False
        Me.DtpTanggal.Location = New System.Drawing.Point(396, 161)
        Me.DtpTanggal.Name = "DtpTanggal"
        Me.DtpTanggal.Size = New System.Drawing.Size(225, 20)
        Me.DtpTanggal.TabIndex = 42
        '
        'LblTanggal
        '
        Me.LblTanggal.AutoSize = True
        Me.LblTanggal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTanggal.Location = New System.Drawing.Point(180, 162)
        Me.LblTanggal.Name = "LblTanggal"
        Me.LblTanggal.Size = New System.Drawing.Size(66, 20)
        Me.LblTanggal.TabIndex = 41
        Me.LblTanggal.Text = "Tanggal"
        '
        'DtpAbsenKeluar
        '
        Me.DtpAbsenKeluar.CustomFormat = "HH:mm"
        Me.DtpAbsenKeluar.Enabled = False
        Me.DtpAbsenKeluar.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DtpAbsenKeluar.Location = New System.Drawing.Point(396, 201)
        Me.DtpAbsenKeluar.Name = "DtpAbsenKeluar"
        Me.DtpAbsenKeluar.ShowUpDown = True
        Me.DtpAbsenKeluar.Size = New System.Drawing.Size(225, 20)
        Me.DtpAbsenKeluar.TabIndex = 40
        '
        'LblAbsenKeluar
        '
        Me.LblAbsenKeluar.AutoSize = True
        Me.LblAbsenKeluar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblAbsenKeluar.Location = New System.Drawing.Point(180, 202)
        Me.LblAbsenKeluar.Name = "LblAbsenKeluar"
        Me.LblAbsenKeluar.Size = New System.Drawing.Size(154, 20)
        Me.LblAbsenKeluar.TabIndex = 39
        Me.LblAbsenKeluar.Text = "Waktu Absen Keluar"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(546, 385)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 37
        Me.Button1.Text = "batal"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'lblabsensi
        '
        Me.lblabsensi.AutoSize = True
        Me.lblabsensi.Font = New System.Drawing.Font("Stencil", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblabsensi.Location = New System.Drawing.Point(288, 42)
        Me.lblabsensi.Name = "lblabsensi"
        Me.lblabsensi.Size = New System.Drawing.Size(263, 34)
        Me.lblabsensi.TabIndex = 36
        Me.lblabsensi.Text = "Absensi Keluar"
        '
        'LblNama
        '
        Me.LblNama.AutoSize = True
        Me.LblNama.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNama.Location = New System.Drawing.Point(180, 124)
        Me.LblNama.Name = "LblNama"
        Me.LblNama.Size = New System.Drawing.Size(124, 20)
        Me.LblNama.TabIndex = 33
        Me.LblNama.Text = "Nama Karyawan"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(396, 123)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(225, 21)
        Me.ComboBox1.TabIndex = 44
        '
        'FormAbsensiKeluar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.BtnTambahAbsensi)
        Me.Controls.Add(Me.DtpTanggal)
        Me.Controls.Add(Me.LblTanggal)
        Me.Controls.Add(Me.DtpAbsenKeluar)
        Me.Controls.Add(Me.LblAbsenKeluar)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lblabsensi)
        Me.Controls.Add(Me.LblNama)
        Me.Name = "FormAbsensiKeluar"
        Me.Text = "FormAbsensiKeluar"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnTambahAbsensi As Button
    Friend WithEvents DtpTanggal As DateTimePicker
    Friend WithEvents LblTanggal As Label
    Friend WithEvents DtpAbsenKeluar As DateTimePicker
    Friend WithEvents LblAbsenKeluar As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents lblabsensi As Label
    Friend WithEvents LblNama As Label
    Friend WithEvents ComboBox1 As ComboBox
End Class
