<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class GantiStatusAbsensi
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lblstatus = New System.Windows.Forms.Label()
        Me.BtnStatus = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ComboBoxStatus = New System.Windows.Forms.ComboBox()
        Me.Lblsatatus = New System.Windows.Forms.Label()
        Me.TBNama = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lblstatus
        '
        Me.lblstatus.AutoSize = True
        Me.lblstatus.Font = New System.Drawing.Font("Stencil", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblstatus.Location = New System.Drawing.Point(99, 71)
        Me.lblstatus.Name = "lblstatus"
        Me.lblstatus.Size = New System.Drawing.Size(352, 34)
        Me.lblstatus.TabIndex = 35
        Me.lblstatus.Text = "Ganti Status Absensi"
        '
        'BtnStatus
        '
        Me.BtnStatus.Location = New System.Drawing.Point(472, 257)
        Me.BtnStatus.Name = "BtnStatus"
        Me.BtnStatus.Size = New System.Drawing.Size(75, 23)
        Me.BtnStatus.TabIndex = 41
        Me.BtnStatus.Text = "Ganti Status"
        Me.BtnStatus.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(101, 150)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(124, 20)
        Me.Label4.TabIndex = 42
        Me.Label4.Text = "Nama Karyawan"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(141, 186)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 20)
        Me.Label2.TabIndex = 54
        '
        'ComboBoxStatus
        '
        Me.ComboBoxStatus.FormattingEnabled = True
        Me.ComboBoxStatus.Items.AddRange(New Object() {"Sudah Lengkap", "Belum Lengkap"})
        Me.ComboBoxStatus.Location = New System.Drawing.Point(322, 193)
        Me.ComboBoxStatus.Name = "ComboBoxStatus"
        Me.ComboBoxStatus.Size = New System.Drawing.Size(225, 21)
        Me.ComboBoxStatus.TabIndex = 55
        '
        'Lblsatatus
        '
        Me.Lblsatatus.AutoSize = True
        Me.Lblsatatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblsatatus.Location = New System.Drawing.Point(101, 194)
        Me.Lblsatatus.Name = "Lblsatatus"
        Me.Lblsatatus.Size = New System.Drawing.Size(56, 20)
        Me.Lblsatatus.TabIndex = 56
        Me.Lblsatatus.Text = "Status"
        '
        'TBNama
        '
        Me.TBNama.Enabled = False
        Me.TBNama.Location = New System.Drawing.Point(322, 150)
        Me.TBNama.Name = "TBNama"
        Me.TBNama.Size = New System.Drawing.Size(225, 20)
        Me.TBNama.TabIndex = 57
        '
        'GantiStatusAbsensi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(613, 360)
        Me.Controls.Add(Me.TBNama)
        Me.Controls.Add(Me.Lblsatatus)
        Me.Controls.Add(Me.ComboBoxStatus)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.BtnStatus)
        Me.Controls.Add(Me.lblstatus)
        Me.Name = "GantiStatusAbsensi"
        Me.Text = "Edit Absensi"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblstatus As Label
    Friend WithEvents BtnStatus As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ComboBoxStatus As ComboBox
    Friend WithEvents Lblsatatus As Label
    Friend WithEvents TBNama As TextBox
End Class
