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
<<<<<<< HEAD
        Me.LblUsername = New System.Windows.Forms.Label()
=======
        Me.LBLNIK = New System.Windows.Forms.Label()
        Me.Buttontest = New System.Windows.Forms.Button()
>>>>>>> origin/Daffahakim
        Me.SuspendLayout()
        '
        'TBUname
        '
        Me.TBUname.Location = New System.Drawing.Point(200, 79)
        Me.TBUname.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TBUname.Name = "TBUname"
        Me.TBUname.Size = New System.Drawing.Size(199, 22)
        Me.TBUname.TabIndex = 0
        '
        'LblUsername
        '
<<<<<<< HEAD
        Me.LblUsername.AutoSize = True
        Me.LblUsername.Location = New System.Drawing.Point(71, 67)
        Me.LblUsername.Name = "LblUsername"
        Me.LblUsername.Size = New System.Drawing.Size(55, 13)
        Me.LblUsername.TabIndex = 1
        Me.LblUsername.Text = "Username"
=======
        Me.LBLNIK.AutoSize = True
        Me.LBLNIK.Location = New System.Drawing.Point(95, 82)
        Me.LBLNIK.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LBLNIK.Name = "LBLNIK"
        Me.LBLNIK.Size = New System.Drawing.Size(73, 17)
        Me.LBLNIK.TabIndex = 1
        Me.LBLNIK.Text = "Username"
>>>>>>> origin/Daffahakim
        '
        'Buttontest
        '
        Me.Buttontest.Location = New System.Drawing.Point(421, 82)
        Me.Buttontest.Name = "Buttontest"
        Me.Buttontest.Size = New System.Drawing.Size(75, 23)
        Me.Buttontest.TabIndex = 2
        Me.Buttontest.Text = "Button1"
        Me.Buttontest.UseVisualStyleBackColor = True
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
<<<<<<< HEAD
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.LblUsername)
=======
        Me.ClientSize = New System.Drawing.Size(1067, 554)
        Me.Controls.Add(Me.Buttontest)
        Me.Controls.Add(Me.LBLNIK)
>>>>>>> origin/Daffahakim
        Me.Controls.Add(Me.TBUname)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Login"
        Me.Text = "Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TBUname As TextBox
<<<<<<< HEAD
    Friend WithEvents LblUsername As Label
=======
    Friend WithEvents LBLNIK As Label
    Friend WithEvents Buttontest As Button
>>>>>>> origin/Daffahakim
End Class
