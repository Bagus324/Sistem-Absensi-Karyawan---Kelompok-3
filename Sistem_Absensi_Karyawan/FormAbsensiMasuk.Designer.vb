<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAbsensiMasuk
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
        Me.TextBoxNama = New System.Windows.Forms.TextBox()
        Me.LblAbsenMasuk = New System.Windows.Forms.Label()
        Me.LblNama = New System.Windows.Forms.Label()
        Me.lblabsensi = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DtpAbsenMasuk = New System.Windows.Forms.DateTimePicker()
        Me.LblAbsenKeluar = New System.Windows.Forms.Label()
        Me.DtpAbsenKeluar = New System.Windows.Forms.DateTimePicker()
        Me.LblTanggal = New System.Windows.Forms.Label()
        Me.DtpTanggal = New System.Windows.Forms.DateTimePicker()
        Me.BtnTambahAbsensi = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TextBoxNama
        '
        Me.TextBoxNama.Location = New System.Drawing.Point(327, 124)
        Me.TextBoxNama.Name = "TextBoxNama"
        Me.TextBoxNama.Size = New System.Drawing.Size(225, 20)
        Me.TextBoxNama.TabIndex = 13
        '
        'LblAbsenMasuk
        '
        Me.LblAbsenMasuk.AutoSize = True
        Me.LblAbsenMasuk.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblAbsenMasuk.Location = New System.Drawing.Point(111, 199)
        Me.LblAbsenMasuk.Name = "LblAbsenMasuk"
        Me.LblAbsenMasuk.Size = New System.Drawing.Size(156, 20)
        Me.LblAbsenMasuk.TabIndex = 10
        Me.LblAbsenMasuk.Text = "Waktu Absen Masuk"
        '
        'LblNama
        '
        Me.LblNama.AutoSize = True
        Me.LblNama.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNama.Location = New System.Drawing.Point(111, 122)
        Me.LblNama.Name = "LblNama"
        Me.LblNama.Size = New System.Drawing.Size(124, 20)
        Me.LblNama.TabIndex = 8
        Me.LblNama.Text = "Nama Karyawan"
        '
        'lblabsensi
        '
        Me.lblabsensi.AutoSize = True
        Me.lblabsensi.Font = New System.Drawing.Font("Stencil", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblabsensi.Location = New System.Drawing.Point(219, 40)
        Me.lblabsensi.Name = "lblabsensi"
        Me.lblabsensi.Size = New System.Drawing.Size(249, 34)
        Me.lblabsensi.TabIndex = 25
        Me.lblabsensi.Text = "Absensi Masuk"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(477, 383)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 26
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'DtpAbsenMasuk
        '
        Me.DtpAbsenMasuk.CustomFormat = "HH:mm"
        Me.DtpAbsenMasuk.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DtpAbsenMasuk.Location = New System.Drawing.Point(327, 198)
        Me.DtpAbsenMasuk.Name = "DtpAbsenMasuk"
        Me.DtpAbsenMasuk.ShowUpDown = True
        Me.DtpAbsenMasuk.Size = New System.Drawing.Size(225, 20)
        Me.DtpAbsenMasuk.TabIndex = 27
        Me.DtpAbsenMasuk.Value = New Date(2022, 1, 5, 11, 13, 41, 0)
        '
        'LblAbsenKeluar
        '
        Me.LblAbsenKeluar.AutoSize = True
        Me.LblAbsenKeluar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblAbsenKeluar.Location = New System.Drawing.Point(111, 239)
        Me.LblAbsenKeluar.Name = "LblAbsenKeluar"
        Me.LblAbsenKeluar.Size = New System.Drawing.Size(154, 20)
        Me.LblAbsenKeluar.TabIndex = 28
        Me.LblAbsenKeluar.Text = "Waktu Absen Keluar"
        '
        'DtpAbsenKeluar
        '
        Me.DtpAbsenKeluar.CustomFormat = "HH:mm"
        Me.DtpAbsenKeluar.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DtpAbsenKeluar.Location = New System.Drawing.Point(327, 238)
        Me.DtpAbsenKeluar.Name = "DtpAbsenKeluar"
        Me.DtpAbsenKeluar.ShowUpDown = True
        Me.DtpAbsenKeluar.Size = New System.Drawing.Size(225, 20)
        Me.DtpAbsenKeluar.TabIndex = 29
        '
        'LblTanggal
        '
        Me.LblTanggal.AutoSize = True
        Me.LblTanggal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTanggal.Location = New System.Drawing.Point(111, 160)
        Me.LblTanggal.Name = "LblTanggal"
        Me.LblTanggal.Size = New System.Drawing.Size(66, 20)
        Me.LblTanggal.TabIndex = 30
        Me.LblTanggal.Text = "Tanggal"
        '
        'DtpTanggal
        '
        Me.DtpTanggal.Location = New System.Drawing.Point(327, 159)
        Me.DtpTanggal.Name = "DtpTanggal"
        Me.DtpTanggal.Size = New System.Drawing.Size(225, 20)
        Me.DtpTanggal.TabIndex = 31
        '
        'BtnTambahAbsensi
        '
        Me.BtnTambahAbsensi.Location = New System.Drawing.Point(445, 325)
        Me.BtnTambahAbsensi.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnTambahAbsensi.Name = "BtnTambahAbsensi"
        Me.BtnTambahAbsensi.Size = New System.Drawing.Size(107, 23)
        Me.BtnTambahAbsensi.TabIndex = 32
        Me.BtnTambahAbsensi.Text = "Tambah Absensi"
        Me.BtnTambahAbsensi.UseVisualStyleBackColor = True
        '
        'FormAbsensiMasuk
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.BtnTambahAbsensi)
        Me.Controls.Add(Me.DtpTanggal)
        Me.Controls.Add(Me.LblTanggal)
        Me.Controls.Add(Me.DtpAbsenKeluar)
        Me.Controls.Add(Me.LblAbsenKeluar)
        Me.Controls.Add(Me.DtpAbsenMasuk)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lblabsensi)
        Me.Controls.Add(Me.TextBoxNama)
        Me.Controls.Add(Me.LblAbsenMasuk)
        Me.Controls.Add(Me.LblNama)
        Me.Name = "FormAbsensiMasuk"
        Me.Text = "Absensi Masuk"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBoxNama As TextBox
    Friend WithEvents LblAbsenMasuk As Label
    Friend WithEvents LblNama As Label
    Friend WithEvents lblabsensi As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents DtpAbsenMasuk As DateTimePicker
    Friend WithEvents LblAbsenKeluar As Label
    Friend WithEvents DtpAbsenKeluar As DateTimePicker
    Friend WithEvents LblTanggal As Label
    Friend WithEvents DtpTanggal As DateTimePicker
    Friend WithEvents BtnTambahAbsensi As Button
End Class
