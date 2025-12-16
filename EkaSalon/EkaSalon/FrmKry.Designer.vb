<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmKry
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.TxtKdKry = New System.Windows.Forms.TextBox
        Me.TxtNmKry = New System.Windows.Forms.TextBox
        Me.TxtTelpKry = New System.Windows.Forms.TextBox
        Me.TxtPass = New System.Windows.Forms.TextBox
        Me.TxtJabatan = New System.Windows.Forms.TextBox
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Kode Karyawan"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 87)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nama Karyawan"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 126)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Telepon Karyawan"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 170)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(30, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Pass"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 209)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Jabatan"
        '
        'TxtKdKry
        '
        Me.TxtKdKry.Location = New System.Drawing.Point(112, 40)
        Me.TxtKdKry.Name = "TxtKdKry"
        Me.TxtKdKry.Size = New System.Drawing.Size(100, 20)
        Me.TxtKdKry.TabIndex = 5
        '
        'TxtNmKry
        '
        Me.TxtNmKry.Location = New System.Drawing.Point(112, 80)
        Me.TxtNmKry.Name = "TxtNmKry"
        Me.TxtNmKry.Size = New System.Drawing.Size(100, 20)
        Me.TxtNmKry.TabIndex = 6
        '
        'TxtTelpKry
        '
        Me.TxtTelpKry.Location = New System.Drawing.Point(112, 119)
        Me.TxtTelpKry.Name = "TxtTelpKry"
        Me.TxtTelpKry.Size = New System.Drawing.Size(100, 20)
        Me.TxtTelpKry.TabIndex = 7
        '
        'TxtPass
        '
        Me.TxtPass.Location = New System.Drawing.Point(112, 167)
        Me.TxtPass.Name = "TxtPass"
        Me.TxtPass.Size = New System.Drawing.Size(100, 20)
        Me.TxtPass.TabIndex = 8
        '
        'TxtJabatan
        '
        Me.TxtJabatan.Location = New System.Drawing.Point(112, 202)
        Me.TxtJabatan.Name = "TxtJabatan"
        Me.TxtJabatan.Size = New System.Drawing.Size(100, 20)
        Me.TxtJabatan.TabIndex = 9
        '
        'BtTambah
        '
        Me.BtTambah.Location = New System.Drawing.Point(47, 274)
        Me.BtTambah.Name = "BtTambah"
        Me.BtTambah.Size = New System.Drawing.Size(75, 23)
        Me.BtTambah.TabIndex = 10
        Me.BtTambah.Text = "Tambah"
        Me.BtTambah.UseVisualStyleBackColor = True
        '
        'BtRubah
        '
        Me.BtRubah.Location = New System.Drawing.Point(128, 274)
        Me.BtRubah.Name = "BtRubah"
        Me.BtRubah.Size = New System.Drawing.Size(75, 23)
        Me.BtRubah.TabIndex = 11
        Me.BtRubah.Text = "Rubah"
        Me.BtRubah.UseVisualStyleBackColor = True
        '
        'BtHapus
        '
        Me.BtHapus.Location = New System.Drawing.Point(209, 274)
        Me.BtHapus.Name = "BtHapus"
        Me.BtHapus.Size = New System.Drawing.Size(75, 23)
        Me.BtHapus.TabIndex = 12
        Me.BtHapus.Text = "Hapus"
        Me.BtHapus.UseVisualStyleBackColor = True
        '
        'BtSimpan
        '
        Me.BtSimpan.Location = New System.Drawing.Point(290, 274)
        Me.BtSimpan.Name = "BtSimpan"
        Me.BtSimpan.Size = New System.Drawing.Size(75, 23)
        Me.BtSimpan.TabIndex = 13
        Me.BtSimpan.Text = "Simpan"
        Me.BtSimpan.UseVisualStyleBackColor = True
        '
        'BtBatal
        '
        Me.BtBatal.Location = New System.Drawing.Point(371, 274)
        Me.BtBatal.Name = "BtBatal"
        Me.BtBatal.Size = New System.Drawing.Size(75, 23)
        Me.BtBatal.TabIndex = 14
        Me.BtBatal.Text = "Batal"
        Me.BtBatal.UseVisualStyleBackColor = True
        '
        'BtSelesai
        '
        Me.BtSelesai.Location = New System.Drawing.Point(452, 274)
        Me.BtSelesai.Name = "BtSelesai"
        Me.BtSelesai.Size = New System.Drawing.Size(75, 23)
        Me.BtSelesai.TabIndex = 15
        Me.BtSelesai.Text = "Selesai"
        Me.BtSelesai.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(290, 38)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(564, 164)
        Me.DataGridView1.TabIndex = 16
        '
        'FrmKry
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(901, 337)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.BtSelesai)
        Me.Controls.Add(Me.BtBatal)
        Me.Controls.Add(Me.BtSimpan)
        Me.Controls.Add(Me.BtHapus)
        Me.Controls.Add(Me.BtRubah)
        Me.Controls.Add(Me.BtTambah)
        Me.Controls.Add(Me.TxtJabatan)
        Me.Controls.Add(Me.TxtPass)
        Me.Controls.Add(Me.TxtTelpKry)
        Me.Controls.Add(Me.TxtNmKry)
        Me.Controls.Add(Me.TxtKdKry)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmKry"
        Me.Text = "FrmKry"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TxtKdKry As System.Windows.Forms.TextBox
    Friend WithEvents TxtNmKry As System.Windows.Forms.TextBox
    Friend WithEvents TxtTelpKry As System.Windows.Forms.TextBox
    Friend WithEvents TxtPass As System.Windows.Forms.TextBox
    Friend WithEvents TxtJabatan As System.Windows.Forms.TextBox
    Friend WithEvents BtTambah As System.Windows.Forms.Button
    Friend WithEvents BtRubah As System.Windows.Forms.Button
    Friend WithEvents BtHapus As System.Windows.Forms.Button
    Friend WithEvents BtSimpan As System.Windows.Forms.Button
    Friend WithEvents BtBatal As System.Windows.Forms.Button
    Friend WithEvents BtSelesai As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
End Class
