<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.TBUname = New System.Windows.Forms.TextBox()
        Me.LBLUname = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'TBUname
        '
        Me.TBUname.Location = New System.Drawing.Point(150, 64)
        Me.TBUname.Name = "TBUname"
        Me.TBUname.Size = New System.Drawing.Size(150, 20)
        Me.TBUname.TabIndex = 0
        '
        'LBLUname
        '
        Me.LBLUname.AutoSize = True
        Me.LBLUname.Location = New System.Drawing.Point(71, 67)
        Me.LBLUname.Name = "LBLUname"
        Me.LBLUname.Size = New System.Drawing.Size(55, 13)
        Me.LBLUname.TabIndex = 1
        Me.LBLUname.Text = "Username"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.LBLUname)
        Me.Controls.Add(Me.TBUname)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TBUname As TextBox
    Friend WithEvents LBLUname As Label
End Class
