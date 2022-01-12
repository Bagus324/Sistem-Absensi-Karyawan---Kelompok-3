<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditJabatan
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
        Me.TBJabatan = New System.Windows.Forms.TextBox()
        Me.TBGajih = New System.Windows.Forms.TextBox()
        Me.BtnUbah = New System.Windows.Forms.Button()
        Me.LblJabatan = New System.Windows.Forms.Label()
        Me.LblGajih = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'TBJabatan
        '
        Me.TBJabatan.Location = New System.Drawing.Point(197, 98)
        Me.TBJabatan.Name = "TBJabatan"
        Me.TBJabatan.Size = New System.Drawing.Size(100, 20)
        Me.TBJabatan.TabIndex = 24
        '
        'TBGajih
        '
        Me.TBGajih.Location = New System.Drawing.Point(197, 69)
        Me.TBGajih.Name = "TBGajih"
        Me.TBGajih.Size = New System.Drawing.Size(100, 20)
        Me.TBGajih.TabIndex = 23
        '
        'BtnUbah
        '
        Me.BtnUbah.Location = New System.Drawing.Point(288, 175)
        Me.BtnUbah.Name = "BtnUbah"
        Me.BtnUbah.Size = New System.Drawing.Size(114, 23)
        Me.BtnUbah.TabIndex = 22
        Me.BtnUbah.Text = "Ubah"
        Me.BtnUbah.UseVisualStyleBackColor = True
        '
        'LblJabatan
        '
        Me.LblJabatan.AutoSize = True
        Me.LblJabatan.Location = New System.Drawing.Point(39, 98)
        Me.LblJabatan.Name = "LblJabatan"
        Me.LblJabatan.Size = New System.Drawing.Size(76, 13)
        Me.LblJabatan.TabIndex = 21
        Me.LblJabatan.Text = "Nama Jabatan"
        '
        'LblGajih
        '
        Me.LblGajih.AutoSize = True
        Me.LblGajih.Location = New System.Drawing.Point(39, 72)
        Me.LblGajih.Name = "LblGajih"
        Me.LblGajih.Size = New System.Drawing.Size(132, 13)
        Me.LblGajih.TabIndex = 20
        Me.LblGajih.Text = "Gajih Perhari (tanpa koma)"
        '
        'EditJabatan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.TBJabatan)
        Me.Controls.Add(Me.TBGajih)
        Me.Controls.Add(Me.BtnUbah)
        Me.Controls.Add(Me.LblJabatan)
        Me.Controls.Add(Me.LblGajih)
        Me.Name = "EditJabatan"
        Me.Text = "EditJabatan"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TBJabatan As TextBox
    Friend WithEvents TBGajih As TextBox
    Friend WithEvents BtnUbah As Button
    Friend WithEvents LblJabatan As Label
    Friend WithEvents LblGajih As Label
End Class
