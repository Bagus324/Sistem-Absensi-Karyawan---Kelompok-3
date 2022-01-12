<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TambahKaryawan
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
        Me.LblNama = New System.Windows.Forms.Label()
        Me.LblNIK = New System.Windows.Forms.Label()
        Me.RTXAlamat = New System.Windows.Forms.RichTextBox()
        Me.LblAlamat = New System.Windows.Forms.Label()
        Me.LblJabatan = New System.Windows.Forms.Label()
        Me.CmBJabatan = New System.Windows.Forms.ComboBox()
        Me.TbNama = New System.Windows.Forms.TextBox()
        Me.TbNIK = New System.Windows.Forms.TextBox()
        Me.BtnTambah = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LblNama
        '
        Me.LblNama.AutoSize = True
        Me.LblNama.Location = New System.Drawing.Point(74, 85)
        Me.LblNama.Name = "LblNama"
        Me.LblNama.Size = New System.Drawing.Size(35, 13)
        Me.LblNama.TabIndex = 0
        Me.LblNama.Text = "Nama"
        '
        'LblNIK
        '
        Me.LblNIK.AutoSize = True
        Me.LblNIK.Location = New System.Drawing.Point(74, 120)
        Me.LblNIK.Name = "LblNIK"
        Me.LblNIK.Size = New System.Drawing.Size(25, 13)
        Me.LblNIK.TabIndex = 1
        Me.LblNIK.Text = "NIK"
        '
        'RTXAlamat
        '
        Me.RTXAlamat.Location = New System.Drawing.Point(160, 160)
        Me.RTXAlamat.Name = "RTXAlamat"
        Me.RTXAlamat.Size = New System.Drawing.Size(139, 115)
        Me.RTXAlamat.TabIndex = 2
        Me.RTXAlamat.Text = ""
        '
        'LblAlamat
        '
        Me.LblAlamat.AutoSize = True
        Me.LblAlamat.Location = New System.Drawing.Point(74, 163)
        Me.LblAlamat.Name = "LblAlamat"
        Me.LblAlamat.Size = New System.Drawing.Size(39, 13)
        Me.LblAlamat.TabIndex = 3
        Me.LblAlamat.Text = "Alamat"
        '
        'LblJabatan
        '
        Me.LblJabatan.AutoSize = True
        Me.LblJabatan.Location = New System.Drawing.Point(74, 294)
        Me.LblJabatan.Name = "LblJabatan"
        Me.LblJabatan.Size = New System.Drawing.Size(45, 13)
        Me.LblJabatan.TabIndex = 4
        Me.LblJabatan.Text = "Jabatan"
        '
        'CmBJabatan
        '
        Me.CmBJabatan.FormattingEnabled = True
        Me.CmBJabatan.Location = New System.Drawing.Point(160, 291)
        Me.CmBJabatan.Name = "CmBJabatan"
        Me.CmBJabatan.Size = New System.Drawing.Size(139, 21)
        Me.CmBJabatan.TabIndex = 5
        '
        'TbNama
        '
        Me.TbNama.Location = New System.Drawing.Point(160, 82)
        Me.TbNama.Name = "TbNama"
        Me.TbNama.Size = New System.Drawing.Size(139, 20)
        Me.TbNama.TabIndex = 6
        '
        'TbNIK
        '
        Me.TbNIK.Location = New System.Drawing.Point(160, 117)
        Me.TbNIK.Name = "TbNIK"
        Me.TbNIK.Size = New System.Drawing.Size(139, 20)
        Me.TbNIK.TabIndex = 7
        '
        'BtnTambah
        '
        Me.BtnTambah.Location = New System.Drawing.Point(409, 361)
        Me.BtnTambah.Name = "BtnTambah"
        Me.BtnTambah.Size = New System.Drawing.Size(114, 23)
        Me.BtnTambah.TabIndex = 8
        Me.BtnTambah.Text = "Tambah"
        Me.BtnTambah.UseVisualStyleBackColor = True
        '
        'TambahKaryawan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.BtnTambah)
        Me.Controls.Add(Me.TbNIK)
        Me.Controls.Add(Me.TbNama)
        Me.Controls.Add(Me.CmBJabatan)
        Me.Controls.Add(Me.LblJabatan)
        Me.Controls.Add(Me.LblAlamat)
        Me.Controls.Add(Me.RTXAlamat)
        Me.Controls.Add(Me.LblNIK)
        Me.Controls.Add(Me.LblNama)
        Me.Name = "TambahKaryawan"
        Me.Text = "TambahKaryawan"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblNama As Label
    Friend WithEvents LblNIK As Label
    Friend WithEvents RTXAlamat As RichTextBox
    Friend WithEvents LblAlamat As Label
    Friend WithEvents LblJabatan As Label
    Friend WithEvents CmBJabatan As ComboBox
    Friend WithEvents TbNama As TextBox
    Friend WithEvents TbNIK As TextBox
    Friend WithEvents BtnTambah As Button
End Class
