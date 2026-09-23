Public Class Form1
    Private Sub chkMember_CheckedChanged(sender As Object, e As EventArgs) Handles chkMember.CheckedChanged

    End Sub

    Private Sub btnHitung_Click(sender As Object, e As EventArgs) Handles btnHitung.Click
        ' 1. Deklarasi Variabel
        Dim beratCucian As Integer
        Dim hargaPerKg As Decimal = 6000D ' Misal harga dasar Rp6.000/kg
        Dim diskonPersen As Decimal = 0D

        ' 2. Validasi Input dengan TryParse
        ' Mencegah error jika user memasukkan huruf atau membiarkan kosong
        If Not Integer.TryParse(txtBerat.Text, beratCucian) Then
            MessageBox.Show("Input tidak valid! Masukkan angka untuk berat cucian.")
            Exit Sub
        End If

        ' 3. Proses Perhitungan Awal
        Dim subtotal As Decimal = beratCucian * hargaPerKg

        ' 4. Evaluasi Kondisi Percabangan (If-Else)
        ' Syarat 1: Jika berat >= 5 kg, dapat diskon dasar 10%
        If beratCucian >= 5 Then
            diskonPersen = 0.1D
        End If

        ' Syarat 2: Jika Member DAN berat >= 5 kg, dapat tambahan 5% (Total 15%)
        If chkMember.Checked And beratCucian >= 5 Then
            diskonPersen = diskonPersen + 0.05D
        End If

        ' 5. Proses Perhitungan Akhir
        Dim nominalDiskon As Decimal = subtotal * diskonPersen
        Dim totalBayar As Decimal = subtotal - nominalDiskon

        ' 6. Tampilkan Output ke Label
        lblSubTotal.Text = "Subtotal: Rp " & subtotal.ToString("N0")
        lblDiskon.Text = "Diskon: Rp " & nominalDiskon.ToString("N0")
        lblTotal.Text = "Total Bayar: Rp " & totalBayar.ToString("N0")
    End Sub
End Class
