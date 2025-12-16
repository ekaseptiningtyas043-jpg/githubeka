Imports System.Data.OleDb
Public Class Form1
    Dim Baru As String

    Private Sub Form1_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        Call kosong()
        Call Tampil()
    End Sub
    Sub Tampil()
        Da = New OleDbDataAdapter("select * from Tbjasa", Conn)
        Ds = New DataSet
        Ds.Clear()
        Da.Fill(Ds, "TbJasa")
        Me.DataGridView1.DataSource = (Ds.Tables("TbJasa"))
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call Koneksi()
    End Sub
    Sub kosong()
        Me.TxtKdjasa.Enabled = False
        Me.TxtNmJasa.Enabled = False
        Me.TxtTarif.Enabled = False
        Me.TxtKdjasa.Text = ""
        Me.TxtNmJasa.Text = ""
        Me.TxtTarif.Text = ""
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
        Me.TxtKdjasa.Enabled = True
        Me.TxtKdjasa.Focus()
        Me.BtTambah.Enabled = False
        Me.BtBatal.Enabled = True
    End Sub

    Private Sub BtTambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtTambah.Click
        Call Mulai()
    End Sub

    Private Sub TxtKdjasa_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtKdjasa.KeyPress
        e.KeyChar = UCase(e.KeyChar)
        If e.KeyChar = Chr(13) Then
            'Validasi jml karakter Harus 3
            If Len(Trim(Me.TxtKdjasa.Text)) <> 3 Then
                MsgBox("Jumlah Karakter Harus 3 ...OK", MsgBoxStyle.Information, "Pesan")
                Call Mulai()
                Exit Sub
            End If
            'Validasi Karakter Paling kiri Harus L'
            If Mid(Me.TxtKdjasa.Text, 1, 1) <> "J" Then
                MsgBox("Karakter Paling Kiri Harus J ...OK", MsgBoxStyle.Information, "Pesan")
                Call Mulai()
                Exit Sub
            End If
            'Pencarian Data
            'Ketemu - Dirubah/Dihapus - Tidak ketemu Data Baru
            Try
                'Pencarian
                Cmd = New OleDbCommand("Select * From TbJasa where KdJasa='" & _
                Me.TxtKdjasa.Text & "'", Conn)
                Rd = Cmd.ExecuteReader
                Rd.Read()
                If Rd.HasRows = True Then
                    'data ketemu
                    'datanya ditampilkan
                    Me.TxtKdjasa.Text = Rd.GetString(0)
                    Me.TxtNmJasa.Text = Rd.GetString(1)
                    Me.TxtTarif.Text = CStr(Rd.GetValue(2))
                    Me.BtRubah.Enabled = True
                    Me.BtHapus.Enabled = True
                    Me.TxtKdjasa.Enabled = False
                    'Mau Diapakan Dihapus di Rubah
                    Baru = "T"
                    Exit Sub
                End If
                'Data Tidak Ketemu
                Baru = "Y"
                Me.TxtNmJasa.Enabled = True
                Me.TxtNmJasa.Focus()
            Catch ex As Exception
                'Kesalahan Dari Pencarian
                MsgBox("Masih Ada Salah di Pencarian ...OK")
            End Try
            Me.TxtNmJasa.Enabled = True
            Me.TxtNmJasa.Focus()
        End If
    End Sub

    Private Sub TxtNmJasa_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtNmJasa.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.TxtTarif.Enabled = True
            Me.TxtTarif.Focus()
        End If
    End Sub

    Private Sub TxtTarif_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtTarif.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.BtSimpan.Enabled = True
            Me.BtSimpan.Focus()
        End If
    End Sub
    Sub SimpanData()
        Try
            Cmd = New OleDbCommand("select * from TbJasa where KdJasa = '" & _
                  Me.TxtKdjasa.Text & "'", Conn)
            Rd = Cmd.ExecuteReader 'nilai di baca
            Rd.Read() 'jika tidak ditemukan simpan
            If Not Rd.HasRows Then
                Dim sqltambah As String = "insert into TbJasa(KdJasa,NmJasa,Tarif) values " & _
                "('" & Me.TxtKdjasa.Text & "','" & Me.TxtNmJasa.Text & _
                "','" & Me.TxtTarif.Text & "')"
                Cmd = New OleDbCommand(sqltambah, Conn)
                Cmd.ExecuteNonQuery()
                Call kosong()
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
        Me.TxtNmJasa.Enabled = True
        Me.TxtNmJasa.Focus()
        Me.BtRubah.Enabled = False
        Me.BtRubah.Enabled = False
    End Sub
    Sub RubahData()
        Try
            Dim sqlRubah As String = "update TbJasa SET " & _
            "NmJasa ='" & Me.TxtNmJasa.Text & _
            "',Tarif ='" & Me.TxtTarif.Text & _
            "'Where KdJasa ='" & Me.TxtKdjasa.Text & "'"
            Cmd = New OleDbCommand(sqlRubah, Conn)
            Cmd.ExecuteNonQuery()
            Call kosong()
            Call Tampil()
        Catch ex As Exception
            MsgBox("Masih ada Yang salah di try edit data")
        End Try
    End Sub
    Sub HapusData()
        Try
            Dim SqlDelete As String = "Delete From TbJasa " & _
            "where KdJasa = '" & Me.TxtKdjasa.Text & "'"
            Cmd = New OleDbCommand(SqlDelete, Conn)
            Cmd.ExecuteNonQuery()
            Call kosong()
            Call Tampil()
        Catch ex As Exception
            MsgBox("Masih ada yang salah di try hapus data")
        End Try
    End Sub

    Private Sub BtHapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtHapus.Click
        Call HapusData()
    End Sub
End Class


