<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnTampil = New System.Windows.Forms.Button()
        Me.dgvMahasiswa = New System.Windows.Forms.DataGridView()
        Me.lblNama = New System.Windows.Forms.Label()
        Me.lblNim = New System.Windows.Forms.Label()
        Me.lblJurusan = New System.Windows.Forms.Label()
        Me.txtNama = New System.Windows.Forms.TextBox()
        Me.txtNIM = New System.Windows.Forms.TextBox()
        Me.txtJurusan = New System.Windows.Forms.TextBox()
        Me.btnTambah = New System.Windows.Forms.Button()
        CType(Me.dgvMahasiswa, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnTampil
        '
        Me.btnTampil.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.btnTampil.Location = New System.Drawing.Point(120, 293)
        Me.btnTampil.Name = "btnTampil"
        Me.btnTampil.Size = New System.Drawing.Size(216, 89)
        Me.btnTampil.TabIndex = 0
        Me.btnTampil.Text = "Tampilkan"
        Me.btnTampil.UseVisualStyleBackColor = False
        '
        'dgvMahasiswa
        '
        Me.dgvMahasiswa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMahasiswa.Location = New System.Drawing.Point(111, 74)
        Me.dgvMahasiswa.Name = "dgvMahasiswa"
        Me.dgvMahasiswa.RowHeadersWidth = 62
        Me.dgvMahasiswa.RowTemplate.Height = 28
        Me.dgvMahasiswa.Size = New System.Drawing.Size(239, 193)
        Me.dgvMahasiswa.TabIndex = 1
        '
        'lblNama
        '
        Me.lblNama.AutoSize = True
        Me.lblNama.Location = New System.Drawing.Point(429, 88)
        Me.lblNama.Name = "lblNama"
        Me.lblNama.Size = New System.Drawing.Size(51, 20)
        Me.lblNama.TabIndex = 2
        Me.lblNama.Text = "Nama"
        '
        'lblNim
        '
        Me.lblNim.AutoSize = True
        Me.lblNim.Location = New System.Drawing.Point(429, 135)
        Me.lblNim.Name = "lblNim"
        Me.lblNim.Size = New System.Drawing.Size(38, 20)
        Me.lblNim.TabIndex = 3
        Me.lblNim.Text = "NIM"
        '
        'lblJurusan
        '
        Me.lblJurusan.AutoSize = True
        Me.lblJurusan.Location = New System.Drawing.Point(429, 178)
        Me.lblJurusan.Name = "lblJurusan"
        Me.lblJurusan.Size = New System.Drawing.Size(66, 20)
        Me.lblJurusan.TabIndex = 4
        Me.lblJurusan.Text = "Jurusan"
        '
        'txtNama
        '
        Me.txtNama.Location = New System.Drawing.Point(566, 88)
        Me.txtNama.Name = "txtNama"
        Me.txtNama.Size = New System.Drawing.Size(100, 26)
        Me.txtNama.TabIndex = 5
        '
        'txtNIM
        '
        Me.txtNIM.Location = New System.Drawing.Point(566, 128)
        Me.txtNIM.Name = "txtNIM"
        Me.txtNIM.Size = New System.Drawing.Size(100, 26)
        Me.txtNIM.TabIndex = 6
        '
        'txtJurusan
        '
        Me.txtJurusan.Location = New System.Drawing.Point(566, 178)
        Me.txtJurusan.Name = "txtJurusan"
        Me.txtJurusan.Size = New System.Drawing.Size(100, 26)
        Me.txtJurusan.TabIndex = 7
        '
        'btnTambah
        '
        Me.btnTambah.BackColor = System.Drawing.SystemColors.Info
        Me.btnTambah.Location = New System.Drawing.Point(433, 230)
        Me.btnTambah.Name = "btnTambah"
        Me.btnTambah.Size = New System.Drawing.Size(233, 37)
        Me.btnTambah.TabIndex = 8
        Me.btnTambah.Text = "Tambah"
        Me.btnTambah.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnTambah)
        Me.Controls.Add(Me.txtJurusan)
        Me.Controls.Add(Me.txtNIM)
        Me.Controls.Add(Me.txtNama)
        Me.Controls.Add(Me.lblJurusan)
        Me.Controls.Add(Me.lblNim)
        Me.Controls.Add(Me.lblNama)
        Me.Controls.Add(Me.dgvMahasiswa)
        Me.Controls.Add(Me.btnTampil)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.dgvMahasiswa, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnTampil As Button
    Friend WithEvents dgvMahasiswa As DataGridView
    Friend WithEvents lblNama As Label
    Friend WithEvents lblNim As Label
    Friend WithEvents lblJurusan As Label
    Friend WithEvents txtNama As TextBox
    Friend WithEvents txtNIM As TextBox
    Friend WithEvents txtJurusan As TextBox
    Friend WithEvents btnTambah As Button
End Class
