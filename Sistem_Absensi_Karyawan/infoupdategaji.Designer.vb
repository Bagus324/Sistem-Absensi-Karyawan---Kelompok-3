<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class infoupdategaji
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Lblidk = New System.Windows.Forms.Label()
        Me.Lblidb = New System.Windows.Forms.Label()
        Me.Lblttg = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(153, 96)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(109, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "id_karyawan"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(153, 129)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 21)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "id_bulan"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(153, 171)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 21)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "total_gajih"
        '
        'Lblidk
        '
        Me.Lblidk.AutoSize = True
        Me.Lblidk.Location = New System.Drawing.Point(297, 96)
        Me.Lblidk.Name = "Lblidk"
        Me.Lblidk.Size = New System.Drawing.Size(51, 17)
        Me.Lblidk.TabIndex = 3
        Me.Lblidk.Text = "Label4"
        '
        'Lblidb
        '
        Me.Lblidb.AutoSize = True
        Me.Lblidb.Location = New System.Drawing.Point(297, 129)
        Me.Lblidb.Name = "Lblidb"
        Me.Lblidb.Size = New System.Drawing.Size(51, 17)
        Me.Lblidb.TabIndex = 4
        Me.Lblidb.Text = "Label5"
        '
        'Lblttg
        '
        Me.Lblttg.AutoSize = True
        Me.Lblttg.Location = New System.Drawing.Point(297, 171)
        Me.Lblttg.Name = "Lblttg"
        Me.Lblttg.Size = New System.Drawing.Size(51, 17)
        Me.Lblttg.TabIndex = 5
        Me.Lblttg.Text = "Label6"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(223, 234)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(58, 28)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "tutup"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'infoupdategaji
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Lblttg)
        Me.Controls.Add(Me.Lblidb)
        Me.Controls.Add(Me.Lblidk)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "infoupdategaji"
        Me.Text = "infoupdategaji"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Lblidk As Label
    Friend WithEvents Lblidb As Label
    Friend WithEvents Lblttg As Label
    Friend WithEvents Button1 As Button
End Class
