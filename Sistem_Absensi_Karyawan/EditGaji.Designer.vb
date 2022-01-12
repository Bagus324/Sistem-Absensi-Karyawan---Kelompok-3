<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditGaji
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
        Me.TbBulan = New System.Windows.Forms.TextBox()
        Me.TbNama = New System.Windows.Forms.TextBox()
        Me.LblBulan = New System.Windows.Forms.Label()
        Me.LblNama = New System.Windows.Forms.Label()
        Me.TBGajih = New System.Windows.Forms.TextBox()
        Me.LblTotal = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'BtnEdit
        '
        Me.BtnEdit.Location = New System.Drawing.Point(158, 191)
        Me.BtnEdit.Name = "BtnEdit"
        Me.BtnEdit.Size = New System.Drawing.Size(114, 23)
        Me.BtnEdit.TabIndex = 27
        Me.BtnEdit.Text = "Perbarui"
        Me.BtnEdit.UseVisualStyleBackColor = True
        '
        'TbBulan
        '
        Me.TbBulan.Enabled = False
        Me.TbBulan.Location = New System.Drawing.Point(158, 83)
        Me.TbBulan.Name = "TbBulan"
        Me.TbBulan.Size = New System.Drawing.Size(139, 20)
        Me.TbBulan.TabIndex = 26
        '
        'TbNama
        '
        Me.TbNama.Enabled = False
        Me.TbNama.Location = New System.Drawing.Point(158, 48)
        Me.TbNama.Name = "TbNama"
        Me.TbNama.Size = New System.Drawing.Size(139, 20)
        Me.TbNama.TabIndex = 25
        '
        'LblBulan
        '
        Me.LblBulan.AutoSize = True
        Me.LblBulan.Location = New System.Drawing.Point(72, 86)
        Me.LblBulan.Name = "LblBulan"
        Me.LblBulan.Size = New System.Drawing.Size(34, 13)
        Me.LblBulan.TabIndex = 20
        Me.LblBulan.Text = "Bulan"
        '
        'LblNama
        '
        Me.LblNama.AutoSize = True
        Me.LblNama.Location = New System.Drawing.Point(72, 51)
        Me.LblNama.Name = "LblNama"
        Me.LblNama.Size = New System.Drawing.Size(35, 13)
        Me.LblNama.TabIndex = 19
        Me.LblNama.Text = "Nama"
        '
        'TBGajih
        '
        Me.TBGajih.Location = New System.Drawing.Point(158, 129)
        Me.TBGajih.Name = "TBGajih"
        Me.TBGajih.Size = New System.Drawing.Size(139, 20)
        Me.TBGajih.TabIndex = 30
        '
        'LblTotal
        '
        Me.LblTotal.AutoSize = True
        Me.LblTotal.Location = New System.Drawing.Point(72, 132)
        Me.LblTotal.Name = "LblTotal"
        Me.LblTotal.Size = New System.Drawing.Size(58, 13)
        Me.LblTotal.TabIndex = 29
        Me.LblTotal.Text = "Total Gajih"
        '
        'EditGaji
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(451, 300)
        Me.Controls.Add(Me.TBGajih)
        Me.Controls.Add(Me.LblTotal)
        Me.Controls.Add(Me.BtnEdit)
        Me.Controls.Add(Me.TbBulan)
        Me.Controls.Add(Me.TbNama)
        Me.Controls.Add(Me.LblBulan)
        Me.Controls.Add(Me.LblNama)
        Me.Name = "EditGaji"
        Me.Text = "EditGaji"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnEdit As Button
    Friend WithEvents TbBulan As TextBox
    Friend WithEvents TbNama As TextBox
    Friend WithEvents LblBulan As Label
    Friend WithEvents LblNama As Label
    Friend WithEvents TBGajih As TextBox
    Friend WithEvents LblTotal As Label
End Class
