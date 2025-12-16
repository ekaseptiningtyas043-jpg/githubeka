<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.TxtKdjasa = New System.Windows.Forms.TextBox
        Me.TxtNmJasa = New System.Windows.Forms.TextBox
        Me.TxtTarif = New System.Windows.Forms.TextBox
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
        Me.Label1.Location = New System.Drawing.Point(20, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Kode Jasa"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(20, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nama Jasa"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(20, 80)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Tarif Jasa"
        '
        'TxtKdjasa
        '
        Me.TxtKdjasa.Location = New System.Drawing.Point(151, 16)
        Me.TxtKdjasa.Name = "TxtKdjasa"
        Me.TxtKdjasa.Size = New System.Drawing.Size(100, 20)
        Me.TxtKdjasa.TabIndex = 3
        '
        'TxtNmJasa
        '
        Me.TxtNmJasa.Location = New System.Drawing.Point(151, 50)
        Me.TxtNmJasa.Name = "TxtNmJasa"
        Me.TxtNmJasa.Size = New System.Drawing.Size(176, 20)
        Me.TxtNmJasa.TabIndex = 4
        '
        'TxtTarif
        '
        Me.TxtTarif.Location = New System.Drawing.Point(151, 80)
        Me.TxtTarif.Name = "TxtTarif"
        Me.TxtTarif.Size = New System.Drawing.Size(126, 20)
        Me.TxtTarif.TabIndex = 5
        '
        'BtTambah
        '
        Me.BtTambah.Location = New System.Drawing.Point(23, 130)
        Me.BtTambah.Name = "BtTambah"
        Me.BtTambah.Size = New System.Drawing.Size(58, 23)
        Me.BtTambah.TabIndex = 6
        Me.BtTambah.Text = "Tambah"
        Me.BtTambah.UseVisualStyleBackColor = True
        '
        'BtRubah
        '
        Me.BtRubah.Location = New System.Drawing.Point(105, 130)
        Me.BtRubah.Name = "BtRubah"
        Me.BtRubah.Size = New System.Drawing.Size(58, 23)
        Me.BtRubah.TabIndex = 7
        Me.BtRubah.Text = "Rubah"
        Me.BtRubah.UseVisualStyleBackColor = True
        '
        'BtHapus
        '
        Me.BtHapus.Location = New System.Drawing.Point(183, 130)
        Me.BtHapus.Name = "BtHapus"
        Me.BtHapus.Size = New System.Drawing.Size(58, 23)
        Me.BtHapus.TabIndex = 8
        Me.BtHapus.Text = "Hapus"
        Me.BtHapus.UseVisualStyleBackColor = True
        '
        'BtSimpan
        '
        Me.BtSimpan.Location = New System.Drawing.Point(260, 130)
        Me.BtSimpan.Name = "BtSimpan"
        Me.BtSimpan.Size = New System.Drawing.Size(58, 23)
        Me.BtSimpan.TabIndex = 9
        Me.BtSimpan.Text = "Simpan"
        Me.BtSimpan.UseVisualStyleBackColor = True
        '
        'BtBatal
        '
        Me.BtBatal.Location = New System.Drawing.Point(342, 130)
        Me.BtBatal.Name = "BtBatal"
        Me.BtBatal.Size = New System.Drawing.Size(58, 23)
        Me.BtBatal.TabIndex = 10
        Me.BtBatal.Text = "Batal"
        Me.BtBatal.UseVisualStyleBackColor = True
        '
        'BtSelesai
        '
        Me.BtSelesai.Location = New System.Drawing.Point(426, 130)
        Me.BtSelesai.Name = "BtSelesai"
        Me.BtSelesai.Size = New System.Drawing.Size(58, 23)
        Me.BtSelesai.TabIndex = 11
        Me.BtSelesai.Text = "Selesai"
        Me.BtSelesai.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(11, 173)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(550, 147)
        Me.DataGridView1.TabIndex = 12
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(582, 334)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.BtSelesai)
        Me.Controls.Add(Me.BtBatal)
        Me.Controls.Add(Me.BtSimpan)
        Me.Controls.Add(Me.BtHapus)
        Me.Controls.Add(Me.BtRubah)
        Me.Controls.Add(Me.BtTambah)
        Me.Controls.Add(Me.TxtTarif)
        Me.Controls.Add(Me.TxtNmJasa)
        Me.Controls.Add(Me.TxtKdjasa)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Pengolahan Data Jasa"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TxtKdjasa As System.Windows.Forms.TextBox
    Friend WithEvents TxtNmJasa As System.Windows.Forms.TextBox
    Friend WithEvents TxtTarif As System.Windows.Forms.TextBox
    Friend WithEvents BtTambah As System.Windows.Forms.Button
    Friend WithEvents BtRubah As System.Windows.Forms.Button
    Friend WithEvents BtHapus As System.Windows.Forms.Button
    Friend WithEvents BtSimpan As System.Windows.Forms.Button
    Friend WithEvents BtBatal As System.Windows.Forms.Button
    Friend WithEvents BtSelesai As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView

End Class
