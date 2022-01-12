<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SignUp
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
        Me.BtnSignUp = New System.Windows.Forms.Button()
        Me.BtnBatal = New System.Windows.Forms.Button()
        Me.BtnPassword = New System.Windows.Forms.Label()
        Me.BtnUsername = New System.Windows.Forms.Label()
        Me.TextBoxPassword = New System.Windows.Forms.TextBox()
        Me.TextBoxUsername = New System.Windows.Forms.TextBox()
        Me.LblSignUp = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBoxEmail = New System.Windows.Forms.TextBox()
        Me.OFDGambar = New System.Windows.Forms.OpenFileDialog()
        Me.PBGambar = New System.Windows.Forms.PictureBox()
        Me.BtnGambar = New System.Windows.Forms.Button()
        CType(Me.PBGambar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnSignUp
        '
        Me.BtnSignUp.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSignUp.Location = New System.Drawing.Point(218, 295)
        Me.BtnSignUp.Name = "BtnSignUp"
        Me.BtnSignUp.Size = New System.Drawing.Size(100, 33)
        Me.BtnSignUp.TabIndex = 21
        Me.BtnSignUp.Text = "Sign Up"
        Me.BtnSignUp.UseVisualStyleBackColor = True
        '
        'BtnBatal
        '
        Me.BtnBatal.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBatal.Location = New System.Drawing.Point(355, 295)
        Me.BtnBatal.Name = "BtnBatal"
        Me.BtnBatal.Size = New System.Drawing.Size(100, 33)
        Me.BtnBatal.TabIndex = 20
        Me.BtnBatal.Text = "Batal"
        Me.BtnBatal.UseVisualStyleBackColor = True
        '
        'BtnPassword
        '
        Me.BtnPassword.AutoSize = True
        Me.BtnPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPassword.Location = New System.Drawing.Point(100, 134)
        Me.BtnPassword.Name = "BtnPassword"
        Me.BtnPassword.Size = New System.Drawing.Size(92, 24)
        Me.BtnPassword.TabIndex = 15
        Me.BtnPassword.Text = "Password"
        '
        'BtnUsername
        '
        Me.BtnUsername.AutoSize = True
        Me.BtnUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnUsername.Location = New System.Drawing.Point(100, 86)
        Me.BtnUsername.Name = "BtnUsername"
        Me.BtnUsername.Size = New System.Drawing.Size(97, 24)
        Me.BtnUsername.TabIndex = 13
        Me.BtnUsername.Text = "Username"
        '
        'TextBoxPassword
        '
        Me.TextBoxPassword.Location = New System.Drawing.Point(207, 134)
        Me.TextBoxPassword.Name = "TextBoxPassword"
        Me.TextBoxPassword.Size = New System.Drawing.Size(248, 20)
        Me.TextBoxPassword.TabIndex = 12
        '
        'TextBoxUsername
        '
        Me.TextBoxUsername.Location = New System.Drawing.Point(207, 89)
        Me.TextBoxUsername.Name = "TextBoxUsername"
        Me.TextBoxUsername.Size = New System.Drawing.Size(248, 20)
        Me.TextBoxUsername.TabIndex = 11
        '
        'LblSignUp
        '
        Me.LblSignUp.AutoSize = True
        Me.LblSignUp.Font = New System.Drawing.Font("Stencil", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSignUp.Location = New System.Drawing.Point(98, 21)
        Me.LblSignUp.Name = "LblSignUp"
        Me.LblSignUp.Size = New System.Drawing.Size(220, 34)
        Me.LblSignUp.TabIndex = 24
        Me.LblSignUp.Text = "Form Sign Up"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(100, 184)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 24)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Email"
        '
        'TextBoxEmail
        '
        Me.TextBoxEmail.Location = New System.Drawing.Point(207, 185)
        Me.TextBoxEmail.Name = "TextBoxEmail"
        Me.TextBoxEmail.Size = New System.Drawing.Size(248, 20)
        Me.TextBoxEmail.TabIndex = 14
        '
        'OFDGambar
        '
        Me.OFDGambar.FileName = "OpenFileDialog1"
        '
        'PBGambar
        '
        Me.PBGambar.Location = New System.Drawing.Point(541, 89)
        Me.PBGambar.Name = "PBGambar"
        Me.PBGambar.Size = New System.Drawing.Size(135, 141)
        Me.PBGambar.TabIndex = 25
        Me.PBGambar.TabStop = False
        '
        'BtnGambar
        '
        Me.BtnGambar.Location = New System.Drawing.Point(541, 246)
        Me.BtnGambar.Name = "BtnGambar"
        Me.BtnGambar.Size = New System.Drawing.Size(135, 23)
        Me.BtnGambar.TabIndex = 26
        Me.BtnGambar.Text = "Upload Gambar"
        Me.BtnGambar.UseVisualStyleBackColor = True
        '
        'SignUp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.BtnGambar)
        Me.Controls.Add(Me.PBGambar)
        Me.Controls.Add(Me.LblSignUp)
        Me.Controls.Add(Me.BtnSignUp)
        Me.Controls.Add(Me.BtnBatal)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BtnPassword)
        Me.Controls.Add(Me.TextBoxEmail)
        Me.Controls.Add(Me.BtnUsername)
        Me.Controls.Add(Me.TextBoxPassword)
        Me.Controls.Add(Me.TextBoxUsername)
        Me.Name = "SignUp"
        Me.Text = "SignUp"
        CType(Me.PBGambar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnSignUp As Button
    Friend WithEvents BtnBatal As Button
    Friend WithEvents BtnPassword As Label
    Friend WithEvents BtnUsername As Label
    Friend WithEvents TextBoxPassword As TextBox
    Friend WithEvents TextBoxUsername As TextBox
    Friend WithEvents LblSignUp As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBoxEmail As TextBox
    Friend WithEvents OFDGambar As OpenFileDialog
    Friend WithEvents PBGambar As PictureBox
    Friend WithEvents BtnGambar As Button
End Class
