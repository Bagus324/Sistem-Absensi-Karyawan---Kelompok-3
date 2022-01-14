<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HapusGaji
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
        Me.LblBln = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LblNama = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BtnHapusGajih = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LblBln
        '
        Me.LblBln.AutoSize = True
        Me.LblBln.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblBln.Location = New System.Drawing.Point(166, 119)
        Me.LblBln.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblBln.Name = "LblBln"
        Me.LblBln.Size = New System.Drawing.Size(0, 20)
        Me.LblBln.TabIndex = 13
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(59, 119)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 20)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Pada tanggal"
        '
        'LblNama
        '
        Me.LblNama.AutoSize = True
        Me.LblNama.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNama.Location = New System.Drawing.Point(59, 85)
        Me.LblNama.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblNama.Name = "LblNama"
        Me.LblNama.Size = New System.Drawing.Size(0, 20)
        Me.LblNama.TabIndex = 11
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(59, 43)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(438, 20)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Apakah anda ingin menghapus absensi atas nama karyawan"
        '
        'BtnHapusGajih
        '
        Me.BtnHapusGajih.Location = New System.Drawing.Point(317, 159)
        Me.BtnHapusGajih.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnHapusGajih.Name = "BtnHapusGajih"
        Me.BtnHapusGajih.Size = New System.Drawing.Size(83, 33)
        Me.BtnHapusGajih.TabIndex = 9
        Me.BtnHapusGajih.Text = "Hapus"
        Me.BtnHapusGajih.UseVisualStyleBackColor = True
        '
        'HapusGaji
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(573, 280)
        Me.Controls.Add(Me.LblBln)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LblNama)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BtnHapusGajih)
        Me.Name = "HapusGaji"
        Me.Text = "HapusGaji"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblBln As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents LblNama As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents BtnHapusGajih As Button
End Class
