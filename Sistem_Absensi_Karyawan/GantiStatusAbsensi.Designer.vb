<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class GantiStatusAbsensi
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lblabsensi = New System.Windows.Forms.Label()
        Me.BtnEdit = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DtpTanggal = New System.Windows.Forms.DateTimePicker()
        Me.DtpAbsenKeluar = New System.Windows.Forms.DateTimePicker()
        Me.DtpAbsenMasuk = New System.Windows.Forms.DateTimePicker()
        Me.TextBoxNama = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lblabsensi
        '
        Me.lblabsensi.AutoSize = True
        Me.lblabsensi.Font = New System.Drawing.Font("Stencil", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblabsensi.Location = New System.Drawing.Point(244, 66)
        Me.lblabsensi.Name = "lblabsensi"
        Me.lblabsensi.Size = New System.Drawing.Size(214, 34)
        Me.lblabsensi.TabIndex = 35
        Me.lblabsensi.Text = "Edit Absensi"
        '
        'BtnEdit
        '
        Me.BtnEdit.Location = New System.Drawing.Point(612, 332)
        Me.BtnEdit.Name = "BtnEdit"
        Me.BtnEdit.Size = New System.Drawing.Size(75, 23)
        Me.BtnEdit.TabIndex = 41
        Me.BtnEdit.Text = "Edit Absensi"
        Me.BtnEdit.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(141, 180)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 20)
        Me.Label1.TabIndex = 48
        Me.Label1.Text = "Tanggal"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(141, 259)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(154, 20)
        Me.Label2.TabIndex = 46
        Me.Label2.Text = "Waktu Absen Keluar"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(141, 219)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(156, 20)
        Me.Label3.TabIndex = 43
        Me.Label3.Text = "Waktu Absen Masuk"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(141, 142)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(124, 20)
        Me.Label4.TabIndex = 42
        Me.Label4.Text = "Nama Karyawan"
        '
        'DtpTanggal
        '
        Me.DtpTanggal.Location = New System.Drawing.Point(362, 180)
        Me.DtpTanggal.Name = "DtpTanggal"
        Me.DtpTanggal.Size = New System.Drawing.Size(225, 20)
        Me.DtpTanggal.TabIndex = 53
        '
        'DtpAbsenKeluar
        '
        Me.DtpAbsenKeluar.CustomFormat = "HH:mm"
        Me.DtpAbsenKeluar.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DtpAbsenKeluar.Location = New System.Drawing.Point(362, 259)
        Me.DtpAbsenKeluar.Name = "DtpAbsenKeluar"
        Me.DtpAbsenKeluar.ShowUpDown = True
        Me.DtpAbsenKeluar.Size = New System.Drawing.Size(225, 20)
        Me.DtpAbsenKeluar.TabIndex = 52
        '
        'DtpAbsenMasuk
        '
        Me.DtpAbsenMasuk.CustomFormat = "HH:mm"
        Me.DtpAbsenMasuk.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DtpAbsenMasuk.Location = New System.Drawing.Point(362, 219)
        Me.DtpAbsenMasuk.Name = "DtpAbsenMasuk"
        Me.DtpAbsenMasuk.ShowUpDown = True
        Me.DtpAbsenMasuk.Size = New System.Drawing.Size(225, 20)
        Me.DtpAbsenMasuk.TabIndex = 51
        Me.DtpAbsenMasuk.Value = New Date(2022, 1, 5, 11, 13, 41, 0)
        '
        'TextBoxNama
        '
        Me.TextBoxNama.Location = New System.Drawing.Point(362, 145)
        Me.TextBoxNama.Name = "TextBoxNama"
        Me.TextBoxNama.Size = New System.Drawing.Size(225, 20)
        Me.TextBoxNama.TabIndex = 50
        '
        'GantiStatusAbsensi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.DtpTanggal)
        Me.Controls.Add(Me.DtpAbsenKeluar)
        Me.Controls.Add(Me.DtpAbsenMasuk)
        Me.Controls.Add(Me.TextBoxNama)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.BtnEdit)
        Me.Controls.Add(Me.lblabsensi)
        Me.Name = "GantiStatusAbsensi"
        Me.Text = "Edit Absensi"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblabsensi As Label
    Friend WithEvents BtnEdit As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents DtpTanggal As DateTimePicker
    Friend WithEvents DtpAbsenKeluar As DateTimePicker
    Friend WithEvents DtpAbsenMasuk As DateTimePicker
    Friend WithEvents TextBoxNama As TextBox
End Class
