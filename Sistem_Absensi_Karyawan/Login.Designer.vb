<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Me.LBLNIK = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'TBUname
        '
        Me.TBUname.Location = New System.Drawing.Point(150, 64)
        Me.TBUname.Name = "TBUname"
        Me.TBUname.Size = New System.Drawing.Size(150, 20)
        Me.TBUname.TabIndex = 0
        '
        'LBLNIK
        '
        Me.LBLNIK.AutoSize = True
        Me.LBLNIK.Location = New System.Drawing.Point(71, 67)
        Me.LBLNIK.Name = "LBLNIK"
        Me.LBLNIK.Size = New System.Drawing.Size(38, 13)
        Me.LBLNIK.TabIndex = 1
        Me.LBLNIK.Text = "NAMA"
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.LBLNIK)
        Me.Controls.Add(Me.TBUname)
        Me.Name = "Login"
        Me.Text = "Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TBUname As TextBox
    Friend WithEvents LBLNIK As Label
End Class
