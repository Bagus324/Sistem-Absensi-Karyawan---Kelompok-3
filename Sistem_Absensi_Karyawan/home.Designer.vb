<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class home
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(home))
        Me.BtnKaryawan = New System.Windows.Forms.Button()
        Me.BtnJabatan = New System.Windows.Forms.Button()
        Me.BtnGaji = New System.Windows.Forms.Button()
        Me.BtnAbsen = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnKaryawan
        '
        Me.BtnKaryawan.Location = New System.Drawing.Point(154, 371)
        Me.BtnKaryawan.Name = "BtnKaryawan"
        Me.BtnKaryawan.Size = New System.Drawing.Size(75, 23)
        Me.BtnKaryawan.TabIndex = 0
        Me.BtnKaryawan.Text = "Karyawan"
        Me.BtnKaryawan.UseVisualStyleBackColor = True
        '
        'BtnJabatan
        '
        Me.BtnJabatan.Location = New System.Drawing.Point(270, 371)
        Me.BtnJabatan.Name = "BtnJabatan"
        Me.BtnJabatan.Size = New System.Drawing.Size(75, 23)
        Me.BtnJabatan.TabIndex = 1
        Me.BtnJabatan.Text = "Jabatan"
        Me.BtnJabatan.UseVisualStyleBackColor = True
        '
        'BtnGaji
        '
        Me.BtnGaji.Location = New System.Drawing.Point(380, 371)
        Me.BtnGaji.Name = "BtnGaji"
        Me.BtnGaji.Size = New System.Drawing.Size(75, 23)
        Me.BtnGaji.TabIndex = 2
        Me.BtnGaji.Text = "Penggajian"
        Me.BtnGaji.UseVisualStyleBackColor = True
        '
        'BtnAbsen
        '
        Me.BtnAbsen.Location = New System.Drawing.Point(485, 371)
        Me.BtnAbsen.Name = "BtnAbsen"
        Me.BtnAbsen.Size = New System.Drawing.Size(75, 23)
        Me.BtnAbsen.TabIndex = 3
        Me.BtnAbsen.Text = "Absensi"
        Me.BtnAbsen.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Sistem_Absensi_Karyawan.My.Resources.Resources.download
        Me.PictureBox1.InitialImage = CType(resources.GetObject("PictureBox1.InitialImage"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(115, 95)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(480, 270)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(180, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(188, 25)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Selamat Datang di"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Mongolian Baiti", 24.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(374, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(159, 34)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "ABSENku"
        '
        'home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(740, 450)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.BtnAbsen)
        Me.Controls.Add(Me.BtnGaji)
        Me.Controls.Add(Me.BtnJabatan)
        Me.Controls.Add(Me.BtnKaryawan)
        Me.Name = "home"
        Me.Text = "home"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnKaryawan As Button
    Friend WithEvents BtnJabatan As Button
    Friend WithEvents BtnGaji As Button
    Friend WithEvents BtnAbsen As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
