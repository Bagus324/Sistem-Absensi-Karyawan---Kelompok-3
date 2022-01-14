<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TambahGajih
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CmbNama = New System.Windows.Forms.ComboBox()
        Me.CmBBulan = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TBTotal = New System.Windows.Forms.TextBox()
        Me.BtnTambahGaji = New System.Windows.Forms.Button()
        Me.BtnHitung = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(131, 83)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "nama"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(131, 131)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(33, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "bulan"
        '
        'CmbNama
        '
        Me.CmbNama.FormattingEnabled = True
        Me.CmbNama.Location = New System.Drawing.Point(246, 80)
        Me.CmbNama.Name = "CmbNama"
        Me.CmbNama.Size = New System.Drawing.Size(206, 21)
        Me.CmbNama.TabIndex = 4
        '
        'CmBBulan
        '
        Me.CmBBulan.FormattingEnabled = True
        Me.CmBBulan.Location = New System.Drawing.Point(246, 131)
        Me.CmBBulan.Name = "CmBBulan"
        Me.CmBBulan.Size = New System.Drawing.Size(206, 21)
        Me.CmBBulan.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(131, 177)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "total gajih"
        '
        'TBTotal
        '
        Me.TBTotal.Enabled = False
        Me.TBTotal.Location = New System.Drawing.Point(246, 177)
        Me.TBTotal.Name = "TBTotal"
        Me.TBTotal.Size = New System.Drawing.Size(206, 20)
        Me.TBTotal.TabIndex = 7
        '
        'BtnTambahGaji
        '
        Me.BtnTambahGaji.Location = New System.Drawing.Point(377, 235)
        Me.BtnTambahGaji.Name = "BtnTambahGaji"
        Me.BtnTambahGaji.Size = New System.Drawing.Size(75, 23)
        Me.BtnTambahGaji.TabIndex = 8
        Me.BtnTambahGaji.Text = "tambah"
        Me.BtnTambahGaji.UseVisualStyleBackColor = True
        '
        'BtnHitung
        '
        Me.BtnHitung.Location = New System.Drawing.Point(492, 175)
        Me.BtnHitung.Name = "BtnHitung"
        Me.BtnHitung.Size = New System.Drawing.Size(75, 23)
        Me.BtnHitung.TabIndex = 9
        Me.BtnHitung.Text = "Hitung"
        Me.BtnHitung.UseVisualStyleBackColor = True
        '
        'TambahGajih
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.BtnHitung)
        Me.Controls.Add(Me.BtnTambahGaji)
        Me.Controls.Add(Me.TBTotal)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.CmBBulan)
        Me.Controls.Add(Me.CmbNama)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "TambahGajih"
        Me.Text = "TambahGajih"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents CmbNama As ComboBox
    Friend WithEvents CmBBulan As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TBTotal As TextBox
    Friend WithEvents BtnTambahGaji As Button
    Friend WithEvents BtnHitung As Button
End Class
