<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        lblNama = New Label()
        txtNama = New TextBox()
        txtNim = New TextBox()
        lblNim = New Label()
        lblKom = New Label()
        txtKom = New TextBox()
        btnTampilkan = New Button()
        btnHapus = New Button()
        btnKeluar = New Button()
        SuspendLayout()
        ' 
        ' lblNama
        ' 
        lblNama.AutoSize = True
        lblNama.Location = New Point(210, 101)
        lblNama.Name = "lblNama"
        lblNama.Size = New Size(68, 25)
        lblNama.TabIndex = 0
        lblNama.Text = "Name :"
        ' 
        ' txtNama
        ' 
        txtNama.Location = New Point(286, 98)
        txtNama.Name = "txtNama"
        txtNama.Size = New Size(150, 31)
        txtNama.TabIndex = 1
        ' 
        ' txtNim
        ' 
        txtNim.Location = New Point(286, 157)
        txtNim.Name = "txtNim"
        txtNim.Size = New Size(150, 31)
        txtNim.TabIndex = 2
        ' 
        ' lblNim
        ' 
        lblNim.AutoSize = True
        lblNim.Location = New Point(211, 160)
        lblNim.Name = "lblNim"
        lblNim.Size = New Size(55, 25)
        lblNim.TabIndex = 3
        lblNim.Text = "NIM :"
        ' 
        ' lblKom
        ' 
        lblKom.AutoSize = True
        lblKom.Location = New Point(211, 213)
        lblKom.Name = "lblKom"
        lblKom.Size = New Size(60, 25)
        lblKom.TabIndex = 4
        lblKom.Text = "KOM :"
        ' 
        ' txtKom
        ' 
        txtKom.Location = New Point(286, 213)
        txtKom.Name = "txtKom"
        txtKom.Size = New Size(150, 31)
        txtKom.TabIndex = 5
        ' 
        ' btnTampilkan
        ' 
        btnTampilkan.Location = New Point(168, 281)
        btnTampilkan.Name = "btnTampilkan"
        btnTampilkan.Size = New Size(112, 34)
        btnTampilkan.TabIndex = 6
        btnTampilkan.Text = "Tampilkan"
        btnTampilkan.UseVisualStyleBackColor = True
        ' 
        ' btnHapus
        ' 
        btnHapus.Location = New Point(286, 281)
        btnHapus.Name = "btnHapus"
        btnHapus.Size = New Size(112, 34)
        btnHapus.TabIndex = 8
        btnHapus.Text = "Hapus"
        btnHapus.UseVisualStyleBackColor = True
        ' 
        ' btnKeluar
        ' 
        btnKeluar.Location = New Point(404, 281)
        btnKeluar.Name = "btnKeluar"
        btnKeluar.Size = New Size(112, 34)
        btnKeluar.TabIndex = 9
        btnKeluar.Text = "Keluar"
        btnKeluar.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(661, 496)
        Controls.Add(btnKeluar)
        Controls.Add(btnHapus)
        Controls.Add(btnTampilkan)
        Controls.Add(txtKom)
        Controls.Add(lblKom)
        Controls.Add(lblNim)
        Controls.Add(txtNim)
        Controls.Add(txtNama)
        Controls.Add(lblNama)
        Name = "Form1"
        Text = "Profile Mahasiswa"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblNama As Label
    Friend WithEvents txtNama As TextBox
    Friend WithEvents txtNim As TextBox
    Friend WithEvents lblNim As Label
    Friend WithEvents lblKom As Label
    Friend WithEvents txtKom As TextBox
    Friend WithEvents btnTampilkan As Button
    Friend WithEvents btnHapus As Button
    Friend WithEvents btnKeluar As Button

End Class
