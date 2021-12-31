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
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.BtnUsername = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.BtnPassword = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BtnFoto = New System.Windows.Forms.Button()
        Me.BtnSignIn = New System.Windows.Forms.Button()
        Me.BtnBatal = New System.Windows.Forms.Button()
        Me.BtnSignUp = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(188, 66)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(255, 20)
        Me.TextBox1.TabIndex = 0
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(188, 111)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(255, 20)
        Me.TextBox2.TabIndex = 1
        '
        'BtnUsername
        '
        Me.BtnUsername.AutoSize = True
        Me.BtnUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnUsername.Location = New System.Drawing.Point(81, 66)
        Me.BtnUsername.Name = "BtnUsername"
        Me.BtnUsername.Size = New System.Drawing.Size(97, 24)
        Me.BtnUsername.TabIndex = 2
        Me.BtnUsername.Text = "Username"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(188, 164)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(255, 20)
        Me.TextBox3.TabIndex = 3
        '
        'BtnPassword
        '
        Me.BtnPassword.AutoSize = True
        Me.BtnPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPassword.Location = New System.Drawing.Point(81, 114)
        Me.BtnPassword.Name = "BtnPassword"
        Me.BtnPassword.Size = New System.Drawing.Size(92, 24)
        Me.BtnPassword.TabIndex = 4
        Me.BtnPassword.Text = "Password"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(81, 164)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 24)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Email"
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(502, 59)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(119, 118)
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'BtnFoto
        '
        Me.BtnFoto.Location = New System.Drawing.Point(511, 196)
        Me.BtnFoto.Name = "BtnFoto"
        Me.BtnFoto.Size = New System.Drawing.Size(100, 23)
        Me.BtnFoto.TabIndex = 7
        Me.BtnFoto.Text = "Tambah Foto"
        Me.BtnFoto.UseVisualStyleBackColor = True
        '
        'BtnSignIn
        '
        Me.BtnSignIn.Location = New System.Drawing.Point(384, 266)
        Me.BtnSignIn.Name = "BtnSignIn"
        Me.BtnSignIn.Size = New System.Drawing.Size(100, 23)
        Me.BtnSignIn.TabIndex = 8
        Me.BtnSignIn.Text = "Sign In"
        Me.BtnSignIn.UseVisualStyleBackColor = True
        '
        'BtnBatal
        '
        Me.BtnBatal.Location = New System.Drawing.Point(521, 266)
        Me.BtnBatal.Name = "BtnBatal"
        Me.BtnBatal.Size = New System.Drawing.Size(100, 23)
        Me.BtnBatal.TabIndex = 9
        Me.BtnBatal.Text = "Batal"
        Me.BtnBatal.UseVisualStyleBackColor = True
        '
        'BtnSignUp
        '
        Me.BtnSignUp.Location = New System.Drawing.Point(241, 266)
        Me.BtnSignUp.Name = "BtnSignUp"
        Me.BtnSignUp.Size = New System.Drawing.Size(100, 23)
        Me.BtnSignUp.TabIndex = 10
        Me.BtnSignUp.Text = "Sign Up"
        Me.BtnSignUp.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(78, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(194, 33)
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
        Me.Controls.Add(Me.BtnBatal)
        Me.Controls.Add(Me.BtnSignIn)
        Me.Controls.Add(Me.BtnFoto)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BtnPassword)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.BtnUsername)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Name = "SignIn"
        Me.Text = "Batal"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents BtnUsername As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents BtnPassword As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BtnFoto As Button
    Friend WithEvents BtnSignIn As Button
    Friend WithEvents BtnBatal As Button
    Friend WithEvents BtnSignUp As Button
    Friend WithEvents Label1 As Label
End Class
