<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HapusAbsensi
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
        Me.BtnHapusAbsensi = New System.Windows.Forms.Button()
        Me.LblNama = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LblTgl = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(86, 109)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(438, 20)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Apakah anda ingin menghapus absensi atas nama karyawan"
        '
        'BtnHapusAbsensi
        '
        Me.BtnHapusAbsensi.Location = New System.Drawing.Point(344, 225)
        Me.BtnHapusAbsensi.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnHapusAbsensi.Name = "BtnHapusAbsensi"
        Me.BtnHapusAbsensi.Size = New System.Drawing.Size(83, 33)
        Me.BtnHapusAbsensi.TabIndex = 3
        Me.BtnHapusAbsensi.Text = "Hapus"
        Me.BtnHapusAbsensi.UseVisualStyleBackColor = True
        '
        'LblNama
        '
        Me.LblNama.AutoSize = True
        Me.LblNama.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNama.Location = New System.Drawing.Point(86, 151)
        Me.LblNama.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblNama.Name = "LblNama"
        Me.LblNama.Size = New System.Drawing.Size(0, 20)
        Me.LblNama.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(86, 185)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 20)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Pada tanggal"
        '
        'LblTgl
        '
        Me.LblTgl.AutoSize = True
        Me.LblTgl.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTgl.Location = New System.Drawing.Point(226, 185)
        Me.LblTgl.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblTgl.Name = "LblTgl"
        Me.LblTgl.Size = New System.Drawing.Size(103, 20)
        Me.LblTgl.TabIndex = 8
        Me.LblTgl.Text = "Pada tanggal"
        '
        'HapusAbsensi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.LblTgl)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LblNama)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BtnHapusAbsensi)
        Me.Name = "HapusAbsensi"
        Me.Text = "HapusAbsensi"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents BtnHapusAbsensi As Button
    Friend WithEvents LblNama As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents LblTgl As Label
End Class
