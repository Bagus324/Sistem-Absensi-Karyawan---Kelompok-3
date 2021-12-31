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
        Me.LblHapusAbsensi = New System.Windows.Forms.Label()
        Me.BtnHapusAbsensi = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(243, 110)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(297, 20)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Apakah anda ingin menghapus absensi?"
        '
        'LblHapusAbsensi
        '
        Me.LblHapusAbsensi.AutoSize = True
        Me.LblHapusAbsensi.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblHapusAbsensi.ForeColor = System.Drawing.Color.Black
        Me.LblHapusAbsensi.Location = New System.Drawing.Point(328, 166)
        Me.LblHapusAbsensi.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblHapusAbsensi.Name = "LblHapusAbsensi"
        Me.LblHapusAbsensi.Size = New System.Drawing.Size(118, 31)
        Me.LblHapusAbsensi.TabIndex = 4
        Me.LblHapusAbsensi.Text = "Absensi"
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
        'HapusAbsensi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.LblHapusAbsensi)
        Me.Controls.Add(Me.BtnHapusAbsensi)
        Me.Name = "HapusAbsensi"
        Me.Text = "HapusAbsensi"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents LblHapusAbsensi As Label
    Friend WithEvents BtnHapusAbsensi As Button
End Class
