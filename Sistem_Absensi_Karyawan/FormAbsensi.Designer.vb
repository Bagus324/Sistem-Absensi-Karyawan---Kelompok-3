<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormAbsensi
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
        Me.ToolStripFormAbsensi = New System.Windows.Forms.ToolStrip()
        Me.BtnAbsensi = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripDropDownButton1 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.AbsensiMasukToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AbsensiKeluarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.ListBoxAbsensi = New System.Windows.Forms.ListBox()
        Me.BtnEdit = New System.Windows.Forms.Button()
        Me.BtnHapusAbsensi = New System.Windows.Forms.Button()
        Me.BtnSelect = New System.Windows.Forms.Button()
        Me.ToolStripFormAbsensi.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStripFormAbsensi
        '
        Me.ToolStripFormAbsensi.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BtnAbsensi, Me.ToolStripDropDownButton1})
        Me.ToolStripFormAbsensi.Location = New System.Drawing.Point(0, 0)
        Me.ToolStripFormAbsensi.Name = "ToolStripFormAbsensi"
        Me.ToolStripFormAbsensi.Size = New System.Drawing.Size(800, 25)
        Me.ToolStripFormAbsensi.TabIndex = 0
        Me.ToolStripFormAbsensi.Text = "ToolStrip1"
        '
        'BtnAbsensi
        '
        Me.BtnAbsensi.Name = "BtnAbsensi"
        Me.BtnAbsensi.Size = New System.Drawing.Size(48, 22)
        Me.BtnAbsensi.Text = "Absensi"
        '
        'ToolStripDropDownButton1
        '
        Me.ToolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripDropDownButton1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AbsensiMasukToolStripMenuItem, Me.AbsensiKeluarToolStripMenuItem})
        Me.ToolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripDropDownButton1.Name = "ToolStripDropDownButton1"
        Me.ToolStripDropDownButton1.Size = New System.Drawing.Size(13, 22)
        Me.ToolStripDropDownButton1.Text = "ToolStripDropDownButton1"
        '
        'AbsensiMasukToolStripMenuItem
        '
        Me.AbsensiMasukToolStripMenuItem.Name = "AbsensiMasukToolStripMenuItem"
        Me.AbsensiMasukToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
        Me.AbsensiMasukToolStripMenuItem.Text = "Absensi Masuk"
        '
        'AbsensiKeluarToolStripMenuItem
        '
        Me.AbsensiKeluarToolStripMenuItem.Name = "AbsensiKeluarToolStripMenuItem"
        Me.AbsensiKeluarToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
        Me.AbsensiKeluarToolStripMenuItem.Text = "Absensi Keluar"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(395, 46)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(323, 123)
        Me.DataGridView1.TabIndex = 1
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'ListBoxAbsensi
        '
        Me.ListBoxAbsensi.FormattingEnabled = True
        Me.ListBoxAbsensi.Location = New System.Drawing.Point(12, 46)
        Me.ListBoxAbsensi.Name = "ListBoxAbsensi"
        Me.ListBoxAbsensi.Size = New System.Drawing.Size(354, 225)
        Me.ListBoxAbsensi.TabIndex = 2
        '
        'BtnEdit
        '
        Me.BtnEdit.Location = New System.Drawing.Point(476, 212)
        Me.BtnEdit.Name = "BtnEdit"
        Me.BtnEdit.Size = New System.Drawing.Size(75, 23)
        Me.BtnEdit.TabIndex = 3
        Me.BtnEdit.Text = "Edit"
        Me.BtnEdit.UseVisualStyleBackColor = True
        '
        'BtnHapusAbsensi
        '
        Me.BtnHapusAbsensi.Location = New System.Drawing.Point(641, 212)
        Me.BtnHapusAbsensi.Name = "BtnHapusAbsensi"
        Me.BtnHapusAbsensi.Size = New System.Drawing.Size(75, 23)
        Me.BtnHapusAbsensi.TabIndex = 4
        Me.BtnHapusAbsensi.Text = "Hapus"
        Me.BtnHapusAbsensi.UseVisualStyleBackColor = True
        '
        'BtnSelect
        '
        Me.BtnSelect.Location = New System.Drawing.Point(560, 212)
        Me.BtnSelect.Name = "BtnSelect"
        Me.BtnSelect.Size = New System.Drawing.Size(75, 23)
        Me.BtnSelect.TabIndex = 5
        Me.BtnSelect.Text = "Select"
        Me.BtnSelect.UseVisualStyleBackColor = True
        '
        'FormAbsensi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.BtnSelect)
        Me.Controls.Add(Me.BtnHapusAbsensi)
        Me.Controls.Add(Me.BtnEdit)
        Me.Controls.Add(Me.ListBoxAbsensi)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.ToolStripFormAbsensi)
        Me.Name = "FormAbsensi"
        Me.Text = "Form Absensi"
        Me.ToolStripFormAbsensi.ResumeLayout(False)
        Me.ToolStripFormAbsensi.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ToolStripFormAbsensi As ToolStrip
    Friend WithEvents BtnAbsensi As ToolStripLabel
    Friend WithEvents ToolStripDropDownButton1 As ToolStripDropDownButton
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents ListBoxAbsensi As ListBox
    Friend WithEvents AbsensiMasukToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AbsensiKeluarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BtnEdit As Button
    Friend WithEvents BtnHapusAbsensi As Button
    Friend WithEvents BtnSelect As Button
End Class
