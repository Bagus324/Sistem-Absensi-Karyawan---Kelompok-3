<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InfoAbsensi
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
        Me.BtnTutup = New System.Windows.Forms.Button()
        Me.LblTanggal = New System.Windows.Forms.Label()
        Me.LblAbsenKeluar = New System.Windows.Forms.Label()
        Me.lblabsensi = New System.Windows.Forms.Label()
        Me.LblAbsenMasuk = New System.Windows.Forms.Label()
        Me.LblNama = New System.Windows.Forms.Label()
        Me.LblInfoNama = New System.Windows.Forms.Label()
        Me.LblInfoTanggal = New System.Windows.Forms.Label()
        Me.LblInfoAbsenMasuk = New System.Windows.Forms.Label()
        Me.LblInfoAbsenKeluar = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'BtnTutup
        '
        Me.BtnTutup.Location = New System.Drawing.Point(464, 327)
        Me.BtnTutup.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnTutup.Name = "BtnTutup"
        Me.BtnTutup.Size = New System.Drawing.Size(107, 23)
        Me.BtnTutup.TabIndex = 42
        Me.BtnTutup.Text = "Tutup"
        Me.BtnTutup.UseVisualStyleBackColor = True
        '
        'LblTanggal
        '
        Me.LblTanggal.AutoSize = True
        Me.LblTanggal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTanggal.Location = New System.Drawing.Point(130, 162)
        Me.LblTanggal.Name = "LblTanggal"
        Me.LblTanggal.Size = New System.Drawing.Size(66, 20)
        Me.LblTanggal.TabIndex = 40
        Me.LblTanggal.Text = "Tanggal"
        '
        'LblAbsenKeluar
        '
        Me.LblAbsenKeluar.AutoSize = True
        Me.LblAbsenKeluar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblAbsenKeluar.Location = New System.Drawing.Point(130, 241)
        Me.LblAbsenKeluar.Name = "LblAbsenKeluar"
        Me.LblAbsenKeluar.Size = New System.Drawing.Size(154, 20)
        Me.LblAbsenKeluar.TabIndex = 38
        Me.LblAbsenKeluar.Text = "Waktu Absen Keluar"
        '
        'lblabsensi
        '
        Me.lblabsensi.AutoSize = True
        Me.lblabsensi.Font = New System.Drawing.Font("Stencil", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblabsensi.Location = New System.Drawing.Point(238, 42)
        Me.lblabsensi.Name = "lblabsensi"
        Me.lblabsensi.Size = New System.Drawing.Size(249, 34)
        Me.lblabsensi.TabIndex = 36
        Me.lblabsensi.Text = "Absensi Masuk"
        '
        'LblAbsenMasuk
        '
        Me.LblAbsenMasuk.AutoSize = True
        Me.LblAbsenMasuk.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblAbsenMasuk.Location = New System.Drawing.Point(130, 201)
        Me.LblAbsenMasuk.Name = "LblAbsenMasuk"
        Me.LblAbsenMasuk.Size = New System.Drawing.Size(156, 20)
        Me.LblAbsenMasuk.TabIndex = 34
        Me.LblAbsenMasuk.Text = "Waktu Absen Masuk"
        '
        'LblNama
        '
        Me.LblNama.AutoSize = True
        Me.LblNama.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNama.Location = New System.Drawing.Point(130, 124)
        Me.LblNama.Name = "LblNama"
        Me.LblNama.Size = New System.Drawing.Size(124, 20)
        Me.LblNama.TabIndex = 33
        Me.LblNama.Text = "Nama Karyawan"
        '
        'LblInfoNama
        '
        Me.LblInfoNama.AutoSize = True
        Me.LblInfoNama.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblInfoNama.Location = New System.Drawing.Point(344, 124)
        Me.LblInfoNama.Name = "LblInfoNama"
        Me.LblInfoNama.Size = New System.Drawing.Size(124, 20)
        Me.LblInfoNama.TabIndex = 43
        Me.LblInfoNama.Text = "Nama Karyawan"
        '
        'LblInfoTanggal
        '
        Me.LblInfoTanggal.AutoSize = True
        Me.LblInfoTanggal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblInfoTanggal.Location = New System.Drawing.Point(344, 162)
        Me.LblInfoTanggal.Name = "LblInfoTanggal"
        Me.LblInfoTanggal.Size = New System.Drawing.Size(66, 20)
        Me.LblInfoTanggal.TabIndex = 44
        Me.LblInfoTanggal.Text = "Tanggal"
        '
        'LblInfoAbsenMasuk
        '
        Me.LblInfoAbsenMasuk.AutoSize = True
        Me.LblInfoAbsenMasuk.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblInfoAbsenMasuk.Location = New System.Drawing.Point(344, 201)
        Me.LblInfoAbsenMasuk.Name = "LblInfoAbsenMasuk"
        Me.LblInfoAbsenMasuk.Size = New System.Drawing.Size(106, 20)
        Me.LblInfoAbsenMasuk.TabIndex = 45
        Me.LblInfoAbsenMasuk.Text = "Absen Masuk"
        '
        'LblInfoAbsenKeluar
        '
        Me.LblInfoAbsenKeluar.AutoSize = True
        Me.LblInfoAbsenKeluar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblInfoAbsenKeluar.Location = New System.Drawing.Point(344, 241)
        Me.LblInfoAbsenKeluar.Name = "LblInfoAbsenKeluar"
        Me.LblInfoAbsenKeluar.Size = New System.Drawing.Size(100, 20)
        Me.LblInfoAbsenKeluar.TabIndex = 46
        Me.LblInfoAbsenKeluar.Text = "AbsenKeluar"
        '
        'InfoAbsensi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.LblInfoAbsenKeluar)
        Me.Controls.Add(Me.LblInfoAbsenMasuk)
        Me.Controls.Add(Me.LblInfoTanggal)
        Me.Controls.Add(Me.LblInfoNama)
        Me.Controls.Add(Me.BtnTutup)
        Me.Controls.Add(Me.LblTanggal)
        Me.Controls.Add(Me.LblAbsenKeluar)
        Me.Controls.Add(Me.lblabsensi)
        Me.Controls.Add(Me.LblAbsenMasuk)
        Me.Controls.Add(Me.LblNama)
        Me.Name = "InfoAbsensi"
        Me.Text = "InfoAbsensi"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnTutup As Button
    Friend WithEvents LblTanggal As Label
    Friend WithEvents LblAbsenKeluar As Label
    Friend WithEvents lblabsensi As Label
    Friend WithEvents LblAbsenMasuk As Label
    Friend WithEvents LblNama As Label
    Friend WithEvents LblInfoNama As Label
    Friend WithEvents LblInfoTanggal As Label
    Friend WithEvents LblInfoAbsenMasuk As Label
    Friend WithEvents LblInfoAbsenKeluar As Label
End Class
