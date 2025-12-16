<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPlg
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.TxtKdPlg = New System.Windows.Forms.TextBox
        Me.TxtNmPlg = New System.Windows.Forms.TextBox
        Me.TxtTelepon = New System.Windows.Forms.TextBox
        Me.BtTambah = New System.Windows.Forms.Button
        Me.BtRubah = New System.Windows.Forms.Button
        Me.BtHapus = New System.Windows.Forms.Button
        Me.BtSimpan = New System.Windows.Forms.Button
        Me.BtBatal = New System.Windows.Forms.Button
        Me.BtSelesai = New System.Windows.Forms.Button
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(12, 46)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(86, 13)
        Me.label1.TabIndex = 0
        Me.label1.Text = "Kode Pelanggan"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 92)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nama Pelanggan"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 134)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Telepon"
        '
        'TxtKdPlg
        '
        Me.TxtKdPlg.Location = New System.Drawing.Point(125, 39)
        Me.TxtKdPlg.Name = "TxtKdPlg"
        Me.TxtKdPlg.Size = New System.Drawing.Size(100, 20)
        Me.TxtKdPlg.TabIndex = 3
        '
        'TxtNmPlg
        '
        Me.TxtNmPlg.Location = New System.Drawing.Point(125, 85)
        Me.TxtNmPlg.Name = "TxtNmPlg"
        Me.TxtNmPlg.Size = New System.Drawing.Size(100, 20)
        Me.TxtNmPlg.TabIndex = 4
        '
        'TxtTelepon
        '
        Me.TxtTelepon.Location = New System.Drawing.Point(125, 131)
        Me.TxtTelepon.Name = "TxtTelepon"
        Me.TxtTelepon.Size = New System.Drawing.Size(100, 20)
        Me.TxtTelepon.TabIndex = 5
        '
        'BtTambah
        '
        Me.BtTambah.Location = New System.Drawing.Point(15, 180)
        Me.BtTambah.Name = "BtTambah"
        Me.BtTambah.Size = New System.Drawing.Size(75, 23)
        Me.BtTambah.TabIndex = 6
        Me.BtTambah.Text = "Tambah"
        Me.BtTambah.UseVisualStyleBackColor = True
        '
        'BtRubah
        '
        Me.BtRubah.Location = New System.Drawing.Point(96, 180)
        Me.BtRubah.Name = "BtRubah"
        Me.BtRubah.Size = New System.Drawing.Size(75, 23)
        Me.BtRubah.TabIndex = 7
        Me.BtRubah.Text = "Rubah"
        Me.BtRubah.UseVisualStyleBackColor = True
        '
        'BtHapus
        '
        Me.BtHapus.Location = New System.Drawing.Point(177, 180)
        Me.BtHapus.Name = "BtHapus"
        Me.BtHapus.Size = New System.Drawing.Size(75, 23)
        Me.BtHapus.TabIndex = 8
        Me.BtHapus.Text = "Hapus"
        Me.BtHapus.UseVisualStyleBackColor = True
        '
        'BtSimpan
        '
        Me.BtSimpan.Location = New System.Drawing.Point(258, 180)
        Me.BtSimpan.Name = "BtSimpan"
        Me.BtSimpan.Size = New System.Drawing.Size(75, 23)
        Me.BtSimpan.TabIndex = 9
        Me.BtSimpan.Text = "Simpan"
        Me.BtSimpan.UseVisualStyleBackColor = True
        '
        'BtBatal
        '
        Me.BtBatal.Location = New System.Drawing.Point(339, 180)
        Me.BtBatal.Name = "BtBatal"
        Me.BtBatal.Size = New System.Drawing.Size(75, 23)
        Me.BtBatal.TabIndex = 10
        Me.BtBatal.Text = "Batal"
        Me.BtBatal.UseVisualStyleBackColor = True
        '
        'BtSelesai
        '
        Me.BtSelesai.Location = New System.Drawing.Point(420, 180)
        Me.BtSelesai.Name = "BtSelesai"
        Me.BtSelesai.Size = New System.Drawing.Size(75, 23)
        Me.BtSelesai.TabIndex = 11
        Me.BtSelesai.Text = "Selesai"
        Me.BtSelesai.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 234)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(481, 83)
        Me.DataGridView1.TabIndex = 17
        '
        'FrmPlg
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(507, 362)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.BtSelesai)
        Me.Controls.Add(Me.BtBatal)
        Me.Controls.Add(Me.BtSimpan)
        Me.Controls.Add(Me.BtHapus)
        Me.Controls.Add(Me.BtRubah)
        Me.Controls.Add(Me.BtTambah)
        Me.Controls.Add(Me.TxtTelepon)
        Me.Controls.Add(Me.TxtNmPlg)
        Me.Controls.Add(Me.TxtKdPlg)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.label1)
        Me.Name = "FrmPlg"
        Me.Text = "FrmPlg"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TxtKdPlg As System.Windows.Forms.TextBox
    Friend WithEvents TxtNmPlg As System.Windows.Forms.TextBox
    Friend WithEvents TxtTelepon As System.Windows.Forms.TextBox
    Friend WithEvents BtTambah As System.Windows.Forms.Button
    Friend WithEvents BtRubah As System.Windows.Forms.Button
    Friend WithEvents BtHapus As System.Windows.Forms.Button
    Friend WithEvents BtSimpan As System.Windows.Forms.Button
    Friend WithEvents BtBatal As System.Windows.Forms.Button
    Friend WithEvents BtSelesai As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
End Class
