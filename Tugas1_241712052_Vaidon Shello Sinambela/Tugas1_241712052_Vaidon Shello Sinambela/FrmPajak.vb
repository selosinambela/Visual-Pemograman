Public Class FrmPajak
    Private Sub txtPendapatan_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPendapatan.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub btnHitung_Click(sender As Object, e As EventArgs) Handles btnHitung.Click
        Dim pendapatan As Double
        Dim persentasePajak As Double
        Dim totalPajak As Double

        If Not Double.TryParse(txtPendapatan.Text, pendapatan) Then
            MessageBox.Show("Masukkan angka pendapatan dengan benar!")
            txtPendapatan.Focus()
            Return
        End If

        If pendapatan > 100000000 Then
            persentasePajak = 0.3
        ElseIf pendapatan > 30000000 Then
            persentasePajak = 0.2
        ElseIf pendapatan > 5000000 Then
            persentasePajak = 0.1
        Else
            persentasePajak = 0
        End If

        totalPajak = pendapatan * persentasePajak

        MessageBox.Show("Total Pajak Harus Dibayar: Rp. " & totalPajak.ToString("N0"))
    End Sub

    Private Sub btnKeluar_Click(sender As Object, e As EventArgs) Handles btnKeluar.Click
        Application.Exit()
    End Sub
End Class