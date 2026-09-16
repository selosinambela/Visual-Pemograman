<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormArray
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtPanjang = New System.Windows.Forms.TextBox()
        Me.txtLebar = New System.Windows.Forms.TextBox()
        Me.lstNilai = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'btnTampil
        '
        Me.btnTampil.Location = New System.Drawing.Point(222, 191)
        Me.btnTampil.Name = "btnTampil"
        Me.btnTampil.Size = New System.Drawing.Size(120, 33)
        Me.btnTampil.TabIndex = 0
        Me.btnTampil.Text = "Tampilkan"
        Me.btnTampil.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(196, 97)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Panjang"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(196, 140)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Lebar"
        '
        'txtPanjang
        '
        Me.txtPanjang.Location = New System.Drawing.Point(269, 97)
        Me.txtPanjang.Name = "txtPanjang"
        Me.txtPanjang.Size = New System.Drawing.Size(100, 26)
        Me.txtPanjang.TabIndex = 3
        '
        'txtLebar
        '
        Me.txtLebar.Location = New System.Drawing.Point(269, 140)
        Me.txtLebar.Name = "txtLebar"
        Me.txtLebar.Size = New System.Drawing.Size(100, 26)
        Me.txtLebar.TabIndex = 4
        '
        'lstNilai
        '
        Me.lstNilai.FormattingEnabled = True
        Me.lstNilai.ItemHeight = 20
        Me.lstNilai.Location = New System.Drawing.Point(416, 97)
        Me.lstNilai.Name = "lstNilai"
        Me.lstNilai.Size = New System.Drawing.Size(161, 104)
        Me.lstNilai.TabIndex = 5
        '
        'FormArray
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lstNilai)
        Me.Controls.Add(Me.txtLebar)
        Me.Controls.Add(Me.txtPanjang)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnTampil)
        Me.Name = "FormArray"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnTampil As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtPanjang As TextBox
    Friend WithEvents txtLebar As TextBox
    Friend WithEvents lstNilai As ListBox
End Class
