Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblNim.Click

    End Sub

    Private Sub lblNama_Click(sender As Object, e As EventArgs) Handles lblNama.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnTampilkan_Click(sender As Object, e As EventArgs) Handles btnTampilkan.Click
        MessageBox.Show("Hello, Welcome to system!" & vbCrLf &
                        "Nama : " & txtNama.Text & vbCrLf &
                        "Nim : " & txtNim.Text & vbCrLf &
                        "Kom : " & txtKom.Text
        )
    End Sub

    Private Sub txtNama_TextChanged(sender As Object, e As EventArgs) Handles txtNama.TextChanged

    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        txtNama.Clear()
        txtNim.Clear()
        txtKom.Clear()
    End Sub

    Private Sub btnKeluar_Click(sender As Object, e As EventArgs) Handles btnKeluar.Click
        Me.Close()
    End Sub
End Class
