<<<<<<< HEAD
﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
=======
﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
>>>>>>> origin/Daffahakim
Partial Class Penggajian
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
<<<<<<< HEAD
    <System.Diagnostics.DebuggerNonUserCode()> _
=======
    <System.Diagnostics.DebuggerNonUserCode()>
>>>>>>> origin/Daffahakim
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
<<<<<<< HEAD
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        components = New System.ComponentModel.Container
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Text = "Penggajian"
    End Sub
=======
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btnHitungGaji = New System.Windows.Forms.Button()
        Me.btnHapus = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(32, 25)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(428, 111)
        Me.DataGridView1.TabIndex = 0
        '
        'btnHitungGaji
        '
        Me.btnHitungGaji.Location = New System.Drawing.Point(215, 142)
        Me.btnHitungGaji.Name = "btnHitungGaji"
        Me.btnHitungGaji.Size = New System.Drawing.Size(79, 28)
        Me.btnHitungGaji.TabIndex = 1
        Me.btnHitungGaji.Text = "Hitung"
        Me.btnHitungGaji.UseVisualStyleBackColor = True
        '
        'btnHapus
        '
        Me.btnHapus.Location = New System.Drawing.Point(381, 142)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(79, 28)
        Me.btnHapus.TabIndex = 2
        Me.btnHapus.Text = "Hapus"
        Me.btnHapus.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(300, 142)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 28)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Ubah"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Penggajian
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(507, 190)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnHapus)
        Me.Controls.Add(Me.btnHitungGaji)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Penggajian"
        Me.Text = "Penggajian"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnHitungGaji As Button
    Friend WithEvents btnHapus As Button
    Friend WithEvents Button1 As Button
>>>>>>> origin/Daffahakim
End Class
