<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class formperulangan
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.txtNilaiAwal = New System.Windows.Forms.TextBox()
        Me.txtNilaiAkhir = New System.Windows.Forms.TextBox()
        Me.lstHasil = New System.Windows.Forms.ListBox()
        Me.btnInput = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtNilaiAwal
        '
        Me.txtNilaiAwal.Location = New System.Drawing.Point(371, 143)
        Me.txtNilaiAwal.Name = "txtNilaiAwal"
        Me.txtNilaiAwal.Size = New System.Drawing.Size(100, 26)
        Me.txtNilaiAwal.TabIndex = 0
        '
        'txtNilaiAkhir
        '
        Me.txtNilaiAkhir.Location = New System.Drawing.Point(371, 190)
        Me.txtNilaiAkhir.Name = "txtNilaiAkhir"
        Me.txtNilaiAkhir.Size = New System.Drawing.Size(100, 26)
        Me.txtNilaiAkhir.TabIndex = 1
        '
        'lstHasil
        '
        Me.lstHasil.FormattingEnabled = True
        Me.lstHasil.ItemHeight = 20
        Me.lstHasil.Location = New System.Drawing.Point(499, 143)
        Me.lstHasil.Name = "lstHasil"
        Me.lstHasil.Size = New System.Drawing.Size(120, 84)
        Me.lstHasil.TabIndex = 2
        '
        'btnInput
        '
        Me.btnInput.Location = New System.Drawing.Point(371, 249)
        Me.btnInput.Name = "btnInput"
        Me.btnInput.Size = New System.Drawing.Size(75, 23)
        Me.btnInput.TabIndex = 3
        Me.btnInput.Text = "Button1"
        Me.btnInput.UseVisualStyleBackColor = True
        '
        'formperulangan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnInput)
        Me.Controls.Add(Me.lstHasil)
        Me.Controls.Add(Me.txtNilaiAkhir)
        Me.Controls.Add(Me.txtNilaiAwal)
        Me.Name = "formperulangan"
        Me.Text = "Formperulangan"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtNilaiAwal As TextBox
    Friend WithEvents txtNilaiAkhir As TextBox
    Friend WithEvents lstHasil As ListBox
    Friend WithEvents btnInput As Button
End Class
