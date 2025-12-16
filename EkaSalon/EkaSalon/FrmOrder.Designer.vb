<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmOrder
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
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.TxtNoOrder = New System.Windows.Forms.TextBox
        Me.TxtKdPlg = New System.Windows.Forms.TextBox
        Me.TxtNmPlg = New System.Windows.Forms.TextBox
        Me.TxtTlpPlg = New System.Windows.Forms.TextBox
        Me.TxtKetOrder = New System.Windows.Forms.TextBox
        Me.TxtKdKry = New System.Windows.Forms.TextBox
        Me.TxtNmKry = New System.Windows.Forms.TextBox
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker
        Me.BtnTambah = New System.Windows.Forms.Button
        Me.BtnSimpan = New System.Windows.Forms.Button
        Me.BtnBatal = New System.Windows.Forms.Button
        Me.BtnSelesai = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(31, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "No Order"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(31, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Kode Pelanggan"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(31, 98)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(89, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Nama Pelanggan"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(31, 130)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Telp Pelangan"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(31, 162)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(91, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Keterangan Order"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(31, 221)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(82, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Kode Karyawan"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(31, 251)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(85, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Nama Karyawan"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(31, 298)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(75, 13)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Tanggal Order"
        '
        'TxtNoOrder
        '
        Me.TxtNoOrder.Location = New System.Drawing.Point(126, 30)
        Me.TxtNoOrder.Name = "TxtNoOrder"
        Me.TxtNoOrder.Size = New System.Drawing.Size(100, 20)
        Me.TxtNoOrder.TabIndex = 8
        '
        'TxtKdPlg
        '
        Me.TxtKdPlg.Location = New System.Drawing.Point(126, 57)
        Me.TxtKdPlg.Name = "TxtKdPlg"
        Me.TxtKdPlg.Size = New System.Drawing.Size(100, 20)
        Me.TxtKdPlg.TabIndex = 9
        '
        'TxtNmPlg
        '
        Me.TxtNmPlg.Location = New System.Drawing.Point(126, 98)
        Me.TxtNmPlg.Name = "TxtNmPlg"
        Me.TxtNmPlg.Size = New System.Drawing.Size(236, 20)
        Me.TxtNmPlg.TabIndex = 10
        '
        'TxtTlpPlg
        '
        Me.TxtTlpPlg.Location = New System.Drawing.Point(126, 123)
        Me.TxtTlpPlg.Name = "TxtTlpPlg"
        Me.TxtTlpPlg.Size = New System.Drawing.Size(157, 20)
        Me.TxtTlpPlg.TabIndex = 11
        '
        'TxtKetOrder
        '
        Me.TxtKetOrder.Location = New System.Drawing.Point(126, 162)
        Me.TxtKetOrder.Name = "TxtKetOrder"
        Me.TxtKetOrder.Size = New System.Drawing.Size(236, 20)
        Me.TxtKetOrder.TabIndex = 12
        '
        'TxtKdKry
        '
        Me.TxtKdKry.Location = New System.Drawing.Point(122, 218)
        Me.TxtKdKry.Name = "TxtKdKry"
        Me.TxtKdKry.Size = New System.Drawing.Size(100, 20)
        Me.TxtKdKry.TabIndex = 13
        '
        'TxtNmKry
        '
        Me.TxtNmKry.Location = New System.Drawing.Point(122, 248)
        Me.TxtNmKry.Name = "TxtNmKry"
        Me.TxtNmKry.Size = New System.Drawing.Size(192, 20)
        Me.TxtNmKry.TabIndex = 14
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(122, 291)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(192, 20)
        Me.DateTimePicker1.TabIndex = 15
        '
        'BtnTambah
        '
        Me.BtnTambah.Location = New System.Drawing.Point(303, 332)
        Me.BtnTambah.Name = "BtnTambah"
        Me.BtnTambah.Size = New System.Drawing.Size(75, 23)
        Me.BtnTambah.TabIndex = 16
        Me.BtnTambah.Text = "Tambah"
        Me.BtnTambah.UseVisualStyleBackColor = True
        '
        'BtnSimpan
        '
        Me.BtnSimpan.Location = New System.Drawing.Point(384, 332)
        Me.BtnSimpan.Name = "BtnSimpan"
        Me.BtnSimpan.Size = New System.Drawing.Size(75, 23)
        Me.BtnSimpan.TabIndex = 17
        Me.BtnSimpan.Text = "Simpan"
        Me.BtnSimpan.UseVisualStyleBackColor = True
        '
        'BtnBatal
        '
        Me.BtnBatal.Location = New System.Drawing.Point(465, 332)
        Me.BtnBatal.Name = "BtnBatal"
        Me.BtnBatal.Size = New System.Drawing.Size(75, 23)
        Me.BtnBatal.TabIndex = 18
        Me.BtnBatal.Text = "Batal"
        Me.BtnBatal.UseVisualStyleBackColor = True
        '
        'BtnSelesai
        '
        Me.BtnSelesai.Location = New System.Drawing.Point(546, 332)
        Me.BtnSelesai.Name = "BtnSelesai"
        Me.BtnSelesai.Size = New System.Drawing.Size(75, 23)
        Me.BtnSelesai.TabIndex = 19
        Me.BtnSelesai.Text = "Selesai"
        Me.BtnSelesai.UseVisualStyleBackColor = True
        '
        'FrmOrder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(651, 367)
        Me.Controls.Add(Me.BtnSelesai)
        Me.Controls.Add(Me.BtnBatal)
        Me.Controls.Add(Me.BtnSimpan)
        Me.Controls.Add(Me.BtnTambah)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.TxtNmKry)
        Me.Controls.Add(Me.TxtKdKry)
        Me.Controls.Add(Me.TxtKetOrder)
        Me.Controls.Add(Me.TxtTlpPlg)
        Me.Controls.Add(Me.TxtNmPlg)
        Me.Controls.Add(Me.TxtKdPlg)
        Me.Controls.Add(Me.TxtNoOrder)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmOrder"
        Me.Text = "Pengolah Data Order"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TxtNoOrder As System.Windows.Forms.TextBox
    Friend WithEvents TxtKdPlg As System.Windows.Forms.TextBox
    Friend WithEvents TxtNmPlg As System.Windows.Forms.TextBox
    Friend WithEvents TxtTlpPlg As System.Windows.Forms.TextBox
    Friend WithEvents TxtKetOrder As System.Windows.Forms.TextBox
    Friend WithEvents TxtKdKry As System.Windows.Forms.TextBox
    Friend WithEvents TxtNmKry As System.Windows.Forms.TextBox
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents BtnTambah As System.Windows.Forms.Button
    Friend WithEvents BtnSimpan As System.Windows.Forms.Button
    Friend WithEvents BtnBatal As System.Windows.Forms.Button
    Friend WithEvents BtnSelesai As System.Windows.Forms.Button
End Class
