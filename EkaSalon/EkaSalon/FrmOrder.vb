Public Class FrmOrder

    Private Sub FrmOrder_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call Koneksi()
    End Sub
    Sub Kosong()
        Me.TxtNoOrder.Enabled = False
        Me.TxtKdPlg.Enabled = False
        Me.TxtNmPlg.Enabled = False
        Me.TxtTlpPlg.Enabled = False
        Me.TxtKetOrder.Enabled = False
        Me.TxtKdKry.Enabled = False
        Me.TxtNmKry.Enabled = False
        Me.DateTimePicker1.Enabled = False
        Me.TxtNoOrder.Text = ""
        Me.TxtKdPlg.Text = ""
        Me.TxtNmPlg.Text = ""
        Me.TxtTlpPlg.Text = ""
        Me.TxtKetOrder.Text = ""
        Me.TxtKdKry.Text = ""
        Me.TxtNmKry.Text = ""
        Me.DateTimePicker1.Value = Today
        Me.BtnBatal.Enabled = False
        Me.BtnSelesai.Enabled = True
        Me.BtnSimpan.Enabled = False
        Me.BtnTambah.Enabled = True
    End Sub

    Private Sub BtnSelesai_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSelesai.Click
        Me.Close()
    End Sub
    Private Sub BtnTambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnTambah.Click
        Call Mulai()
    End Sub

    Private Sub TxtKdPlg_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtKdPlg.KeyPress
        e.KeyChar = UCase(e.KeyChar)
        If e.KeyChar = Chr(13) Then
            'Pencarian Data
            'Ketemu - Dirubah/Dihapus - Tidak ketemu Data Baru
            Try
                'Pencarian
                Cmd = New OleDb.OleDbCommand("select * From TbPlg where KdPlg='" & _
                Me.TxtKdPlg.Text & "'", Conn)
                Rd = Cmd.ExecuteReader
                Rd.Read()
                If Rd.HasRows = True Then
                    'data ketemu
                    'datanya ditampilkan
                    Me.TxtKdPlg.Text = Rd.GetString(0)
                    Me.TxtNmPlg.Text = Rd.GetString(1)
                    Me.TxtTlpPlg.Text = CStr(Rd.GetValue(2))
                    Me.TxtKdPlg.Enabled = False
                    Me.TxtKetOrder.Enabled = True
                    Me.TxtKetOrder.Focus()
                    Exit Sub
                End If
            Catch ex As Exception
                'Kesalahan Dari Pencarian
                MsgBox("Masih Ada Salah di Pencarian ...OK")
            End Try
            Me.TxtNmPlg.Enabled = True
            Me.TxtNmPlg.Focus()
        End If
    End Sub
    Sub mulai()
        Me.TxtNoOrder.Enabled = True
        Me.TxtNoOrder.Focus()
    End Sub

    Private Sub TxtNoOrder_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtNoOrder.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.TxtKdPlg.Enabled = True
            Me.TxtKdPlg.Focus()
        End If
    End Sub

    Private Sub TxtKetOrder_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtKetOrder.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.TxtKdKry.Enabled = True
            Me.TxtKdKry.Focus()
        End If
    End Sub

    Private Sub TxtKdKry_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtKdKry.KeyPress
        e.KeyChar = UCase(e.KeyChar)
        If e.KeyChar = Chr(13) Then
            'Pencarian Data
            'Ketemu - Dirubah/DiHapus - Tidak ketemu Data Baru
            Try
                'Pencarian
                Cmd = New OleDb.OleDbCommand("select * From TbKry where KdKry='" & _
                Me.TxtKdKry.Text & "'", Conn)
                Rd = Cmd.ExecuteReader
                Rd.Read()
                If Rd.HasRows = True Then
                    'data ketemu
                    'datanya ada ditampilkan
                    Me.TxtKdKry.Text = Rd.GetString(0)
                    Me.TxtNmKry.Text = Rd.GetString(1)
                    Me.TxtKdKry.Enabled = False
                    Me.DateTimePicker1.Enabled = True
                    Me.DateTimePicker1.Focus()
                    Exit Sub
                End If
            Catch ex As Exception
                'Kesalahan Dari pencarian
                MsgBox("Masih ada salah di pencarian ...Ok")
            End Try
        End If
    End Sub
    Private Sub DateTimePicker1_CloseUp(ByVal sender As Object, ByVal e As System.EventArgs) Handles DateTimePicker1.CloseUp
        Me.BtnSimpan.Enabled = True
        Me.BtnSimpan.Focus()
    End Sub
    Sub SimpanData()
        Try
            Cmd = New OleDb.OleDbCommand("select * from TbOrder where KdOrder = '" & _
                  Me.TxtKdKry.Text & "'", Conn)
            Rd = Cmd.ExecuteReader 'nilai di baca
            Rd.Read() 'jika tidak ditemukan simpan
            If Not Rd.HasRows Then
                Dim sqltambah As String = "insert into TbOrder(NoOrder,KdPlg,KdKry,Keterangan,Tanggal) values " & _
                "('" & Me.TxtNoOrder.Text & "','" & Me.TxtKdPlg.Text & _
                "','" & Me.TxtKdKry.Text & "', '" & Me.TxtKetOrder.Text & "','" & Me.DateTimePicker1.Text & "')"
                Cmd = New OleDb.OleDbCommand(sqltambah, Conn)
                Cmd.ExecuteNonQuery()
                Call Kosong()
            End If
        Catch ex As Exception
            MsgBox("Masih Ada Yang Salah Di Try Simpan Data")
        End Try
    End Sub

    Private Sub BtnSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSimpan.Click
        If Baru = "Y" Then
            Call SimpanData()
        End If
    End Sub
End Class