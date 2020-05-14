Public Class Form1
    Private Sub proses_Click(sender As Object, e As EventArgs) Handles proses.Click
        Dim npm As String
        Dim nama As String
        Dim hadir As Integer
        Dim tugas As Integer
        Dim uts As Integer
        Dim uas As Integer
        Dim nilaihuruf As String
        Dim nilaiangka As Integer
        Dim ket As String
        npm = Textnpm.Text
        nama = Textnama.Text
        hadir = Val(Texthadir.Text)
        tugas = Val(Texttugas.Text)
        uts = Val(Textuts.Text)
        uas = Val(Textuas.Text)
        nilaiangka = (0.1 * hadir + 0.2 * tugas + 0.3 * uts + 0.4 * uas)
        Textangka.Text = nilaiangka

        If nilaiangka <= 50 Then
            nilaihuruf = "E"
            ket = "Nilai Anda sangat kurang! Maaf, Anda Gagal! :'("
        ElseIf nilaiangka <= 50 Then
            nilaihuruf = "D"
            ket = "Nilai Anda Kurang! Maaf,Anda Gagal! :'("
        ElseIf nilaiangka <= 60 Then
            nilaihuruf = "C"
            ket = "Nilai Anda cukup! Anda Lulus,Tingkakan lagi!"
        ElseIf nilaiangka <= 66 Then
            nilaihuruf = "C+"
            ket = "Nilai Anda cukup! Anda Lulus,Tingkakan lagi!"
        ElseIf nilaiangka <= 70 Then
            nilaihuruf = "B"
            ket = "Nilai Anda Baik! Anda Lulus,Pertahankan! :)"
        ElseIf nilaiangka <= 76 Then
            nilaihuruf = "B+"
            ket = "Nilai Anda Baik! Anda Lulus,Pertahankan! :)"
        ElseIf nilaiangka >= 80 Then
            nilaihuruf = "A"
            ket = "Nilai Anda Sangat Baik! Anda Lulus,Selamat! :)"
        End If
        Texthuruf.Text = nilaihuruf
        Textket.Text = ket
    End Sub

    Private Sub hapus_Click(sender As Object, e As EventArgs) Handles hapus.Click
        Textnpm.Text = ""
        Textnama.Text = ""
        Texthadir.Text = ""
        Texttugas.Text = ""
        Textuts.Text = ""
        Textuas.Text = ""
        Textangka.Text = ""
        Texthuruf.Text = ""
        Textket.Text = ""
    End Sub

    Private Sub keluar_Click(sender As Object, e As EventArgs) Handles keluar.Click
        Close()
    End Sub
End Class
