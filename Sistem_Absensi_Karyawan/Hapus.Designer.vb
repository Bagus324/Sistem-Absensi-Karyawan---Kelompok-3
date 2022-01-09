<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Hapus
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
<<<<<<< HEAD
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LblKoleksiHapus = New System.Windows.Forms.Label()
        Me.BtnHapus = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(255, 137)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(347, 20)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Anda yakin ingin menghapus data karyawan ini?"
        '
        'LblKoleksiHapus
        '
        Me.LblKoleksiHapus.AutoSize = True
        Me.LblKoleksiHapus.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblKoleksiHapus.ForeColor = System.Drawing.Color.Black
        Me.LblKoleksiHapus.Location = New System.Drawing.Point(277, 196)
        Me.LblKoleksiHapus.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblKoleksiHapus.Name = "LblKoleksiHapus"
        Me.LblKoleksiHapus.Size = New System.Drawing.Size(0, 36)
        Me.LblKoleksiHapus.TabIndex = 4
        '
        'BtnHapus
        '
        Me.BtnHapus.Location = New System.Drawing.Point(321, 281)
        Me.BtnHapus.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnHapus.Name = "BtnHapus"
        Me.BtnHapus.Size = New System.Drawing.Size(123, 33)
        Me.BtnHapus.TabIndex = 3
        Me.BtnHapus.Text = "Ya"
=======
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LblGaji = New System.Windows.Forms.Label()
        Me.BtnHapus = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(67, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(205, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Apakah Anda Ingin Menghapus"
        '
        'LblGaji
        '
        Me.LblGaji.AutoSize = True
        Me.LblGaji.Location = New System.Drawing.Point(133, 89)
        Me.LblGaji.Name = "LblGaji"
        Me.LblGaji.Size = New System.Drawing.Size(51, 17)
        Me.LblGaji.TabIndex = 1
        Me.LblGaji.Text = "Label2"
        '
        'BtnHapus
        '
        Me.BtnHapus.Location = New System.Drawing.Point(121, 154)
        Me.BtnHapus.Name = "BtnHapus"
        Me.BtnHapus.Size = New System.Drawing.Size(75, 23)
        Me.BtnHapus.TabIndex = 2
        Me.BtnHapus.Text = "Hapus"
>>>>>>> origin/Daffahakim
        Me.BtnHapus.UseVisualStyleBackColor = True
        '
        'Hapus
        '
<<<<<<< HEAD
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.LblKoleksiHapus)
        Me.Controls.Add(Me.BtnHapus)
=======
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(338, 245)
        Me.Controls.Add(Me.BtnHapus)
        Me.Controls.Add(Me.LblGaji)
        Me.Controls.Add(Me.Label1)
>>>>>>> origin/Daffahakim
        Me.Name = "Hapus"
        Me.Text = "Hapus"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

<<<<<<< HEAD
    Friend WithEvents Label2 As Label
    Friend WithEvents LblKoleksiHapus As Label
=======
    Friend WithEvents Label1 As Label
    Friend WithEvents LblGaji As Label
>>>>>>> origin/Daffahakim
    Friend WithEvents BtnHapus As Button
End Class
