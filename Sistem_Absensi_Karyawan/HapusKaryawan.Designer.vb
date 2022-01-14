<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HapusKaryawan
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LblKoleksiHapus = New System.Windows.Forms.Label()
        Me.BtnHapus = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(70, 46)
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
        Me.LblKoleksiHapus.Location = New System.Drawing.Point(92, 105)
        Me.LblKoleksiHapus.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblKoleksiHapus.Name = "LblKoleksiHapus"
        Me.LblKoleksiHapus.Size = New System.Drawing.Size(0, 36)
        Me.LblKoleksiHapus.TabIndex = 4
        '
        'BtnHapus
        '
        Me.BtnHapus.Location = New System.Drawing.Point(136, 190)
        Me.BtnHapus.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnHapus.Name = "BtnHapus"
        Me.BtnHapus.Size = New System.Drawing.Size(123, 33)
        Me.BtnHapus.TabIndex = 3
        Me.BtnHapus.Text = "Ya"
        Me.BtnHapus.UseVisualStyleBackColor = True
        '
        'HapusKaryawan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(488, 309)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.LblKoleksiHapus)
        Me.Controls.Add(Me.BtnHapus)
        Me.Name = "HapusKaryawan"
        Me.Text = "Hapus"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents LblKoleksiHapus As Label
    Friend WithEvents BtnHapus As Button
End Class
