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
        Me.BtnKaryawan = New System.Windows.Forms.Button()
        Me.BtnJabatan = New System.Windows.Forms.Button()
        Me.BtnGaji = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'BtnKaryawan
        '
        Me.BtnKaryawan.Location = New System.Drawing.Point(39, 75)
        Me.BtnKaryawan.Name = "BtnKaryawan"
        Me.BtnKaryawan.Size = New System.Drawing.Size(75, 23)
        Me.BtnKaryawan.TabIndex = 0
        Me.BtnKaryawan.Text = "Karyawan"
        Me.BtnKaryawan.UseVisualStyleBackColor = True
        '
        'BtnJabatan
        '
        Me.BtnJabatan.Location = New System.Drawing.Point(155, 75)
        Me.BtnJabatan.Name = "BtnJabatan"
        Me.BtnJabatan.Size = New System.Drawing.Size(75, 23)
        Me.BtnJabatan.TabIndex = 1
        Me.BtnJabatan.Text = "Jabatan"
        Me.BtnJabatan.UseVisualStyleBackColor = True
        '
        'BtnGaji
        '
        Me.BtnGaji.Location = New System.Drawing.Point(265, 75)
        Me.BtnGaji.Name = "BtnGaji"
        Me.BtnGaji.Size = New System.Drawing.Size(75, 23)
        Me.BtnGaji.TabIndex = 2
        Me.BtnGaji.Text = "Penggajian"
        Me.BtnGaji.UseVisualStyleBackColor = True
        '
        'home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.BtnGaji)
        Me.Controls.Add(Me.BtnJabatan)
        Me.Controls.Add(Me.BtnKaryawan)
        Me.Name = "home"
        Me.Text = "home"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BtnKaryawan As Button
    Friend WithEvents BtnJabatan As Button
    Friend WithEvents BtnGaji As Button
End Class
