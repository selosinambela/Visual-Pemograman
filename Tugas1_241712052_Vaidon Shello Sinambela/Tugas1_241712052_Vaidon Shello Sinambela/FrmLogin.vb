Imports System.Windows

Public Class FrmLogin
    Private Sub picImage_Click(sender As Object, e As EventArgs) Handles picImage.Click

    End Sub

    Private Sub cmbRole_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbRole.SelectedIndexChanged
        If cmbRole.Text = "Staff" Then
            picImage.Image = Image.FromFile("Assets/staff.jpg")
        ElseIf cmbRole.Text = "Manajer" Then
            picImage.Image = Image.FromFile("Assets/manajer.jpg")
        End If

        picImage.SizeMode = PictureBoxSizeMode.Zoom
    End Sub

    Private Sub txtNama_TextChanged(sender As Object, e As EventArgs) Handles txtNama.TextChanged

    End Sub

    Private Sub txtNIM_TextChanged(sender As Object, e As EventArgs) Handles txtNIM.TextChanged

    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim role As String = cmbRole.Text
        Dim nama As String = txtNama.Text.Trim()
        Dim nim As String = txtNIM.Text.Trim()

        If nama = "" OrElse nim = "" Then
            MessageBox.Show("Nama dan NIM tidak boleh kosong.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
            txtNama.Clear()
            txtNIM.Clear()
        End If

        Dim isStaff As Boolean = (role = "Staff" AndAlso nama.ToLower() = "nadya" AndAlso nim = "241712051")
        Dim isManager As Boolean = (role = "Manager" AndAlso nama.ToLower() = "shata diyaul haq" AndAlso nim = "241712061")

        If isStaff OrElse isManager Then
            MessageBox.Show("Login berhasil! Selamat datang, " & nama, "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
            FrmPajak.Show()
            Me.Hide()

            txtNama.Clear()
            txtNIM.Clear()
            FrmPajak.Show()
            Me.Hide()
        Else
            MessageBox.Show("Role, nama, atau NIM tidak sesuai.", "Login Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtNama.Focus()
            txtNama.Clear()
            txtNIM.Clear()
        End If
    End Sub
End Class
