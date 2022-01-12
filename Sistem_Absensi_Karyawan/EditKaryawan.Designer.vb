<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditKaryawan
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
        Me.BtnEdit = New System.Windows.Forms.Button()
        Me.TbNIK = New System.Windows.Forms.TextBox()
        Me.TbNama = New System.Windows.Forms.TextBox()
        Me.CmBJabatan = New System.Windows.Forms.ComboBox()
        Me.LblJabatan = New System.Windows.Forms.Label()
        Me.LblAlamat = New System.Windows.Forms.Label()
        Me.RTXAlamat = New System.Windows.Forms.RichTextBox()
        Me.LblNIK = New System.Windows.Forms.Label()
        Me.LblNama = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'BtnEdit
        '
        Me.BtnEdit.Location = New System.Drawing.Point(392, 328)
        Me.BtnEdit.Name = "BtnEdit"
        Me.BtnEdit.Size = New System.Drawing.Size(114, 23)
        Me.BtnEdit.TabIndex = 17
        Me.BtnEdit.Text = "Perbarui"
        Me.BtnEdit.UseVisualStyleBackColor = True
        '
        'TbNIK
        '
        Me.TbNIK.Location = New System.Drawing.Point(143, 84)
        Me.TbNIK.Name = "TbNIK"
        Me.TbNIK.Size = New System.Drawing.Size(139, 20)
        Me.TbNIK.TabIndex = 16
        '
        'TbNama
        '
        Me.TbNama.Location = New System.Drawing.Point(143, 49)
        Me.TbNama.Name = "TbNama"
        Me.TbNama.Size = New System.Drawing.Size(139, 20)
        Me.TbNama.TabIndex = 15
        '
        'CmBJabatan
        '
        Me.CmBJabatan.FormattingEnabled = True
        Me.CmBJabatan.Items.AddRange(New Object() {"OB", "SO", "OM", "BM"})
        Me.CmBJabatan.Location = New System.Drawing.Point(143, 258)
        Me.CmBJabatan.Name = "CmBJabatan"
        Me.CmBJabatan.Size = New System.Drawing.Size(139, 21)
        Me.CmBJabatan.TabIndex = 14
        '
        'LblJabatan
        '
        Me.LblJabatan.AutoSize = True
        Me.LblJabatan.Location = New System.Drawing.Point(57, 261)
        Me.LblJabatan.Name = "LblJabatan"
        Me.LblJabatan.Size = New System.Drawing.Size(45, 13)
        Me.LblJabatan.TabIndex = 13
        Me.LblJabatan.Text = "Jabatan"
        '
        'LblAlamat
        '
        Me.LblAlamat.AutoSize = True
        Me.LblAlamat.Location = New System.Drawing.Point(57, 130)
        Me.LblAlamat.Name = "LblAlamat"
        Me.LblAlamat.Size = New System.Drawing.Size(39, 13)
        Me.LblAlamat.TabIndex = 12
        Me.LblAlamat.Text = "Alamat"
        '
        'RTXAlamat
        '
        Me.RTXAlamat.Location = New System.Drawing.Point(143, 127)
        Me.RTXAlamat.Name = "RTXAlamat"
        Me.RTXAlamat.Size = New System.Drawing.Size(139, 115)
        Me.RTXAlamat.TabIndex = 11
        Me.RTXAlamat.Text = ""
        '
        'LblNIK
        '
        Me.LblNIK.AutoSize = True
        Me.LblNIK.Location = New System.Drawing.Point(57, 87)
        Me.LblNIK.Name = "LblNIK"
        Me.LblNIK.Size = New System.Drawing.Size(25, 13)
        Me.LblNIK.TabIndex = 10
        Me.LblNIK.Text = "NIK"
        '
        'LblNama
        '
        Me.LblNama.AutoSize = True
        Me.LblNama.Location = New System.Drawing.Point(57, 52)
        Me.LblNama.Name = "LblNama"
        Me.LblNama.Size = New System.Drawing.Size(35, 13)
        Me.LblNama.TabIndex = 9
        Me.LblNama.Text = "Nama"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(140, 328)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(175, 18)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Penting : Pilih Jabatan"
        '
        'Edit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnEdit)
        Me.Controls.Add(Me.TbNIK)
        Me.Controls.Add(Me.TbNama)
        Me.Controls.Add(Me.CmBJabatan)
        Me.Controls.Add(Me.LblJabatan)
        Me.Controls.Add(Me.LblAlamat)
        Me.Controls.Add(Me.RTXAlamat)
        Me.Controls.Add(Me.LblNIK)
        Me.Controls.Add(Me.LblNama)
        Me.Name = "Edit"
        Me.Text = "Edit"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnEdit As Button
    Friend WithEvents TbNIK As TextBox
    Friend WithEvents TbNama As TextBox
    Friend WithEvents CmBJabatan As ComboBox
    Friend WithEvents LblJabatan As Label
    Friend WithEvents LblAlamat As Label
    Friend WithEvents RTXAlamat As RichTextBox
    Friend WithEvents LblNIK As Label
    Friend WithEvents LblNama As Label
    Friend WithEvents Label1 As Label
End Class
