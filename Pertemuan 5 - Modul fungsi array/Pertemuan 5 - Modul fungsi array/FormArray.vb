Public Class FormArray
    Private Sub btnTampil_Click(sender As Object, e As EventArgs) Handles btnTampil.Click
        'MessageBox.Show(Hitung(txtPanjang.Text, txtLebar.Text))
        'For i As Integer = 0 To nilai.Length - 1
        'lstNilai.Items.Add(nilai(i))
        'Next

        MessageBox.Show(nilai2D(1, 2))
    End Sub

    Private Sub txtPanjang_keyPress(sender As Object, e As KeyPressEventArgs) Handles txtPanjang.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If

    End Sub
End Class
