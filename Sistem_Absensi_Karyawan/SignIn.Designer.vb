<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SignIn
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
        Me.TextBoxUsername = New System.Windows.Forms.TextBox()
        Me.TextBoxPassword = New System.Windows.Forms.TextBox()
        Me.BtnUsername = New System.Windows.Forms.Label()
        Me.BtnPassword = New System.Windows.Forms.Label()
        Me.BtnSignIn = New System.Windows.Forms.Button()
        Me.BtnSignUp = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'TextBoxUsername
        '
        Me.TextBoxUsername.Location = New System.Drawing.Point(192, 86)
        Me.TextBoxUsername.Name = "TextBoxUsername"
        Me.TextBoxUsername.Size = New System.Drawing.Size(255, 20)
        Me.TextBoxUsername.TabIndex = 0
        '
        'TextBoxPassword
        '
        Me.TextBoxPassword.Location = New System.Drawing.Point(192, 131)
        Me.TextBoxPassword.Name = "TextBoxPassword"
        Me.TextBoxPassword.Size = New System.Drawing.Size(255, 20)
        Me.TextBoxPassword.TabIndex = 1
        '
        'BtnUsername
        '
        Me.BtnUsername.AutoSize = True
        Me.BtnUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnUsername.Location = New System.Drawing.Point(85, 86)
        Me.BtnUsername.Name = "BtnUsername"
        Me.BtnUsername.Size = New System.Drawing.Size(97, 24)
        Me.BtnUsername.TabIndex = 2
        Me.BtnUsername.Text = "Username"
        '
        'BtnPassword
        '
        Me.BtnPassword.AutoSize = True
        Me.BtnPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPassword.Location = New System.Drawing.Point(85, 134)
        Me.BtnPassword.Name = "BtnPassword"
        Me.BtnPassword.Size = New System.Drawing.Size(92, 24)
        Me.BtnPassword.TabIndex = 4
        Me.BtnPassword.Text = "Password"
        '
        'BtnSignIn
        '
        Me.BtnSignIn.Location = New System.Drawing.Point(388, 286)
        Me.BtnSignIn.Name = "BtnSignIn"
        Me.BtnSignIn.Size = New System.Drawing.Size(100, 23)
        Me.BtnSignIn.TabIndex = 8
        Me.BtnSignIn.Text = "Sign In"
        Me.BtnSignIn.UseVisualStyleBackColor = True
        '
        'BtnSignUp
        '
        Me.BtnSignUp.Location = New System.Drawing.Point(245, 286)
        Me.BtnSignUp.Name = "BtnSignUp"
        Me.BtnSignUp.Size = New System.Drawing.Size(100, 23)
        Me.BtnSignUp.TabIndex = 10
        Me.BtnSignUp.Text = "Sign Up"
        Me.BtnSignUp.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Stencil", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(83, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(212, 34)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "Form Sign In"
        '
        'SignIn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnSignUp)
        Me.Controls.Add(Me.BtnSignIn)
        Me.Controls.Add(Me.BtnPassword)
        Me.Controls.Add(Me.BtnUsername)
        Me.Controls.Add(Me.TextBoxPassword)
        Me.Controls.Add(Me.TextBoxUsername)
        Me.Name = "SignIn"
        Me.Text = "Sign In"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBoxUsername As TextBox
    Friend WithEvents TextBoxPassword As TextBox
    Friend WithEvents BtnUsername As Label
    Friend WithEvents BtnPassword As Label
    Friend WithEvents BtnSignIn As Button
    Friend WithEvents BtnSignUp As Button
    Friend WithEvents Label1 As Label
End Class
