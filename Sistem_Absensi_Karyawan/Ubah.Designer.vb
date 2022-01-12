<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ubah
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtkaryawan = New System.Windows.Forms.TextBox()
        Me.txtbulan = New System.Windows.Forms.TextBox()
        Me.txttotal = New System.Windows.Forms.TextBox()
        Me.btnubah = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(88, 95)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(109, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "id_karyawan"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(88, 150)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 21)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "id_bulan"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(88, 205)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 21)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "total_gajih"
        '
        'txtkaryawan
        '
        Me.txtkaryawan.Location = New System.Drawing.Point(182, 92)
        Me.txtkaryawan.Name = "txtkaryawan"
        Me.txtkaryawan.Size = New System.Drawing.Size(100, 22)
        Me.txtkaryawan.TabIndex = 3
        '
        'txtbulan
        '
        Me.txtbulan.Location = New System.Drawing.Point(182, 150)
        Me.txtbulan.Name = "txtbulan"
        Me.txtbulan.Size = New System.Drawing.Size(100, 22)
        Me.txtbulan.TabIndex = 4
        '
        'txttotal
        '
        Me.txttotal.Location = New System.Drawing.Point(182, 205)
        Me.txttotal.Name = "txttotal"
        Me.txttotal.Size = New System.Drawing.Size(100, 22)
        Me.txttotal.TabIndex = 5
        '
        'btnubah
        '
        Me.btnubah.Location = New System.Drawing.Point(137, 248)
        Me.btnubah.Name = "btnubah"
        Me.btnubah.Size = New System.Drawing.Size(75, 23)
        Me.btnubah.TabIndex = 6
        Me.btnubah.Text = "Ubah"
        Me.btnubah.UseVisualStyleBackColor = True
        '
        'Ubah
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(371, 322)
        Me.Controls.Add(Me.btnubah)
        Me.Controls.Add(Me.txttotal)
        Me.Controls.Add(Me.txtbulan)
        Me.Controls.Add(Me.txtkaryawan)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Ubah"
        Me.Text = "Ubah"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtkaryawan As TextBox
    Friend WithEvents txtbulan As TextBox
    Friend WithEvents txttotal As TextBox
    Friend WithEvents btnubah As Button
End Class
