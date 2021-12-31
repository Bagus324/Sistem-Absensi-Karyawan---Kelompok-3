<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TambahJabatan
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
        Me.BtnTambah = New System.Windows.Forms.Button()
        Me.LblJabatan = New System.Windows.Forms.Label()
        Me.LblGajih = New System.Windows.Forms.Label()
        Me.TBGajih = New System.Windows.Forms.TextBox()
        Me.TBJabatan = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'BtnTambah
        '
        Me.BtnTambah.Location = New System.Drawing.Point(281, 167)
        Me.BtnTambah.Name = "BtnTambah"
        Me.BtnTambah.Size = New System.Drawing.Size(114, 23)
        Me.BtnTambah.TabIndex = 17
        Me.BtnTambah.Text = "Tambah"
        Me.BtnTambah.UseVisualStyleBackColor = True
        '
        'LblJabatan
        '
        Me.LblJabatan.AutoSize = True
        Me.LblJabatan.Location = New System.Drawing.Point(32, 90)
        Me.LblJabatan.Name = "LblJabatan"
        Me.LblJabatan.Size = New System.Drawing.Size(76, 13)
        Me.LblJabatan.TabIndex = 13
        Me.LblJabatan.Text = "Nama Jabatan"
        '
        'LblGajih
        '
        Me.LblGajih.AutoSize = True
        Me.LblGajih.Location = New System.Drawing.Point(32, 64)
        Me.LblGajih.Name = "LblGajih"
        Me.LblGajih.Size = New System.Drawing.Size(132, 13)
        Me.LblGajih.TabIndex = 9
        Me.LblGajih.Text = "Gajih Perhari (tanpa koma)"
        '
        'TBGajih
        '
        Me.TBGajih.Location = New System.Drawing.Point(190, 61)
        Me.TBGajih.Name = "TBGajih"
        Me.TBGajih.Size = New System.Drawing.Size(100, 20)
        Me.TBGajih.TabIndex = 18
        '
        'TBJabatan
        '
        Me.TBJabatan.Location = New System.Drawing.Point(190, 90)
        Me.TBJabatan.Name = "TBJabatan"
        Me.TBJabatan.Size = New System.Drawing.Size(100, 20)
        Me.TBJabatan.TabIndex = 19
        '
        'TambahJabatan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(611, 295)
        Me.Controls.Add(Me.TBJabatan)
        Me.Controls.Add(Me.TBGajih)
        Me.Controls.Add(Me.BtnTambah)
        Me.Controls.Add(Me.LblJabatan)
        Me.Controls.Add(Me.LblGajih)
        Me.Name = "TambahJabatan"
        Me.Text = "TambahJabatan"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnTambah As Button
    Friend WithEvents LblJabatan As Label
    Friend WithEvents LblGajih As Label
    Friend WithEvents TBGajih As TextBox
    Friend WithEvents TBJabatan As TextBox
End Class
