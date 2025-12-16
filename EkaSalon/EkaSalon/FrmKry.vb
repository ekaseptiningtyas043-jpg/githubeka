Imports System.Data.OleDb
Public Class FrmKry
    Dim Baru As String

    Private Sub FrmKry_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        Call Kosong()
        Call Tampil()
    End Sub
    Sub Tampil()
        Da = New OleDbDataAdapter("select * from TbKry", Conn)
        Ds = New DataSet
        Ds.Clear()
        Da.Fill(Ds, "TbKry")
        Me.DataGridView1.DataSource = (Ds.Tables("TbKry"))
    End Sub

    Private Sub FrmKry_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call Koneksi()
    End Sub
    Sub Kosong()
        Me.TxtKdKry.Enabled = False
        Me.TxtNmKry.Enabled = False
        Me.TxtTelpKry.Enabled = False
        Me.TxtPass.Enabled = False
        Me.TxtJabatan.Enabled = False
        Me.TxtKdKry.Text = ""
        Me.TxtNmKry.Text = ""
        Me.TxtTelpKry.Text = ""
        Me.TxtPass.Text = ""
        Me.TxtJabatan.Text = ""
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
        Me.TxtKdKry.Enabled = True
        Me.TxtKdKry.Focus()
        Me.BtTambah.Enabled = False
        Me.BtBatal.Enabled = True
    End Sub

    Private Sub BtTambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtTambah.Click
        Call Mulai()
    End Sub

    Private Sub TxtKdKry_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtKdKry.KeyPress
        e.KeyChar = UCase(e.KeyChar)
        If e.KeyChar = Chr(13) Then
            'Validasi Karakter Harus 3
            If Len(Trim(Me.TxtKdKry.Text)) <> 3 Then
                MsgBox("Karakter paling Harus 3 ...Ok", MsgBoxStyle.Information, "Pesan")
                Call Mulai()
                Exit Sub
            End If
            'Validari Karakter Paling Kiri harus K
            If Mid(Me.TxtKdKry.Text, 1, 1) <> "K" Then
                MsgBox("Karakter Paling Kiri Harus K ...Ok", MsgBoxStyle.Information, "Pesan")
                Call Mulai()
                Exit Sub
            End If
            'Pencarian Data
            'Ketemu - Dirubah/DiHapus - Tidak ketemu Data Baru
            Try
                'Pencarian
                Cmd = New OleDbCommand("select * From Tbjasa where KdJasa='" & _
                Me.TxtKdKry.Text & "'", Conn)
                Rd = Cmd.ExecuteReader
                Rd.Read()
                If Rd.HasRows = True Then
                    'data ketemu
                    'datanya ada ditampilkan
                    Me.TxtKdKry.Text = Rd.GetString(0)
                    Me.TxtNmKry.Text = Rd.GetString(1)
                    Me.TxtTelpKry.Text = CStr(Rd.GetValue(2))
                    Me.BtRubah.Enabled = True
                    Me.BtHapus.Enabled = True
                    Me.TxtKdKry.Enabled = False
                    'Mau Diapakan Dihapus di Rubah
                    Baru = "T"
                    Exit Sub
                End If
                'Data Tidak ketemu
                Baru = "Y"
                Me.TxtNmKry.Enabled = True
                Me.TxtNmKry.Focus()
            Catch ex As Exception
                'Kesalahan Dari pencarian
                MsgBox("Masih ada salah di pencarian ...Ok")
            End Try
            Me.TxtNmKry.Enabled = True
            Me.TxtNmKry.Focus()
        End If
    End Sub

    Private Sub TxtNmKry_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtNmKry.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.TxtTelpKry.Enabled = True
            Me.TxtTelpKry.Focus()
        End If
    End Sub
    Private Sub TxtTelpKry_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtTelpKry.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.TxtPass.Enabled = True
            Me.TxtPass.Focus()
        End If
    End Sub

    Private Sub TxtPass_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtPass.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.TxtJabatan.Enabled = True
            Me.TxtJabatan.Focus()
        End If
    End Sub

    Private Sub TxtJabatan_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtJabatan.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.BtSimpan.Enabled = True
            Me.BtSimpan.Focus()
        End If
    End Sub
    Sub SimpanData()
        Try
            Cmd = New OleDbCommand("select * from TbKry where KdKry = '" & _
                  Me.TxtKdKry.Text & "'", Conn)
            Rd = Cmd.ExecuteReader 'nilai di baca
            Rd.Read() 'jika tidak ditemukan simpan
            If Not Rd.HasRows Then
                Dim sqltambah As String = "insert into TbKry(KdKry,NmKry,TelpKry,Pass,Jabatan) values " & _
                "('" & Me.TxtKdKry.Text & "','" & Me.TxtNmKry.Text & _
                "','" & Me.TxtTelpKry.Text & "', '" & Me.TxtPass.Text & "','" & Me.TxtJabatan.Text & "')"
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
        Me.TxtNmKry.Enabled = True
        Me.TxtNmKry.Focus()
        Me.BtRubah.Enabled = False
        Me.BtRubah.Enabled = False
    End Sub
    Sub RubahData()
        Try
            Dim sqlRubah As String = "update TbKry SET " & _
            "NmKry ='" & Me.TxtNmKry.Text & _
            "',TelpKry ='" & Me.TxtTelpKry.Text & _
            "',Pass ='" & Me.TxtPass.Text & _
            "',Jabatan ='" & Me.TxtJabatan.Text & _
            "'Where KdKry ='" & Me.TxtKdKry.Text & "'"
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
            Dim SqlDelete As String = "Delete From TbKry " & _
            "where KdKry = '" & Me.TxtKdKry.Text & "'"
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