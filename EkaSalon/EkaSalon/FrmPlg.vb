Imports System.Data.OleDb
Public Class FrmPlg
    Dim Baru As String

    Private Sub FrmPlg_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        Call Kosong()
        Call Tampil()
    End Sub
    Sub Tampil()
        Da = New OleDbDataAdapter("select * from TbPlg", Conn)
        Ds = New DataSet
        Ds.Clear()
        Da.Fill(Ds, "TbPlg")
        Me.DataGridView1.DataSource = (Ds.Tables("TbPlg"))
    End Sub

    Private Sub FrmPlg_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call Koneksi()
    End Sub
    Sub Kosong()
        Me.TxtKdPlg.Enabled = False
        Me.TxtNmPlg.Enabled = False
        Me.TxtTelepon.Enabled = False
        Me.TxtKdPlg.Text = ""
        Me.TxtNmPlg.Text = ""
        Me.TxtTelepon.Text = ""
        Me.BtBatal.Enabled = False
        Me.BtHapus.Enabled = False
        Me.BtRubah.Enabled = False
        Me.BtSelesai.Enabled = True
        Me.BtSimpan.Enabled = False
        Me.BtTambah.Enabled = True
    End Sub

    Private Sub BtSelesai_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtSelesai.Click
        Me.Close()
    End Sub
    Sub Mulai()
        Me.TxtKdPlg.Enabled = True
        Me.TxtNmPlg.Focus()
        Me.BtTambah.Enabled = False
        Me.BtBatal.Enabled = True
    End Sub

    Private Sub BtTambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtTambah.Click
        Call Mulai()
    End Sub

    Private Sub TxtKdPlg_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtKdPlg.KeyPress
        e.KeyChar = UCase(e.KeyChar)
        If e.KeyChar = Chr(13) Then
            'Validasi jml karakter harus 3
            If Len(Trim(Me.TxtKdPlg.Text)) <> 3 Then
                MsgBox("Jumlah Karakter Harus 3 ...OK", MsgBoxStyle.Information, "Pesan")
                Call Mulai()
                Exit Sub
            End If
            'Validasi Karakter Paling kiri Harus P'
            If Mid(Me.TxtKdPlg.Text, 1, 1) <> "P" Then
                MsgBox("Karakter Paling Kiri Harus P ...OK", MsgBoxStyle.Information, "Pesan")
                Call Mulai()
                Exit Sub
            End If
            'Pencarian Data
            'Ketemu - Dirubah/Dihapus - Tidak ketemu Data Baru
            Try
                'Pencarian
                Cmd = New OleDbCommand("select * From TbPlg where KdPlg='" & _
                Me.TxtKdPlg.Text & "'", Conn)
                Rd = Cmd.ExecuteReader
                Rd.Read()
                If Rd.HasRows = True Then
                    'data ketemu
                    'datanya ditampilkan
                    Me.TxtKdPlg.Text = Rd.GetString(0)
                    Me.TxtNmPlg.Text = Rd.GetString(1)
                    Me.TxtTelepon.Text = CStr(Rd.GetValue(2))
                    Me.BtRubah.Enabled = True
                    Me.BtHapus.Enabled = True
                    Me.TxtKdPlg.Enabled = False
                    'Mau Diapakan Dihapus di Rubah
                    Baru = "T"
                    Exit Sub
                End If
                'Data Tidak Ketemu
                Baru = "Y"
                Me.TxtNmPlg.Enabled = True
                Me.TxtNmPlg.Focus()
            Catch ex As Exception
                'Kesalahan Dari Pencarian
                MsgBox("Masih Ada Salah di Pencarian ...OK")
            End Try
            Me.TxtNmPlg.Enabled = True
            Me.TxtNmPlg.Focus()
        End If
    End Sub
    Private Sub TxtNmPlg_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtNmPlg.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.TxtTelepon.Enabled = True
            Me.TxtTelepon.Focus()
        End If
    End Sub

    Private Sub TxtTelepon_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtTelepon.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.BtSimpan.Enabled = True
            Me.BtSimpan.Focus()
        End If
    End Sub
    Sub SimpanData()
        Try
            Cmd = New OleDbCommand("select * from TbPlg where KdPlg = '" & _
                  Me.TxtKdPlg.Text & "'", Conn)
            Rd = Cmd.ExecuteReader 'nilai di baca
            Rd.Read() 'jika tidak ditemukan simpan
            If Not Rd.HasRows Then
                Dim sqltambah As String = "insert into TbPlg(KdPlg,NmPlg,Telp) values " & _
                "('" & Me.TxtKdPlg.Text & "','" & Me.TxtNmPlg.Text & _
                "','" & Me.TxtTelepon.Text & "')"
                Cmd = New OleDbCommand(sqltambah, Conn)
                Cmd.ExecuteNonQuery()
                Call Kosong()
                Call Tampil()
            End If
        Catch ex As Exception
            MsgBox("Masih Ada Yang Salah Di Try Simpan Data")
        End Try
    End Sub

    Private Sub BtSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtSimpan.Click
        If Baru = "Y" Then
            Call SimpanData()
        End If
        If Baru = "T" Then
            Call RubahData()
        End If
    End Sub

    Private Sub BtRubah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtRubah.Click
        Me.TxtNmPlg.Enabled = True
        Me.TxtNmPlg.Focus()
        Me.BtRubah.Enabled = False
        Me.BtRubah.Enabled = False
    End Sub
    Sub RubahData()
        Try
            Dim sqlRubah As String = "update TbPlg SET " & _
            "NmPlg ='" & Me.TxtNmPlg.Text & _
            "',Telp ='" & Me.TxtTelepon.Text & _
            "'Where KdPlg ='" & Me.TxtKdPlg.Text & "'"
            Cmd = New OleDbCommand(sqlRubah, Conn)
            Cmd.ExecuteNonQuery()
            Call Kosong()
            Call Tampil()
        Catch ex As Exception
            MsgBox("Masih ada Yang salah di try edit data")
        End Try
    End Sub
    Sub HapusData()
        Try
            Dim SqlDelete As String = "Delete From TbPlg " & _
            "where KdPlg = '" & Me.TxtKdPlg.Text & "'"
            Cmd = New OleDbCommand(SqlDelete, Conn)
            Cmd.ExecuteNonQuery()
            Call Kosong()
            Call Tampil()
        Catch ex As Exception
            MsgBox("Masih ada yang salah di try hapus data")
        End Try
    End Sub

    Private Sub BtHapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtHapus.Click
        Call HapusData()
    End Sub
End Class