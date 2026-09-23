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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtBerat = New System.Windows.Forms.TextBox()
        Me.chkMember = New System.Windows.Forms.CheckBox()
        Me.btnHitung = New System.Windows.Forms.Button()
        Me.lblSubTotal = New System.Windows.Forms.Label()
        Me.lblDiskon = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lblMember = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(246, 111)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(136, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Berat Cucian (kg):"
        '
        'txtBerat
        '
        Me.txtBerat.Location = New System.Drawing.Point(413, 108)
        Me.txtBerat.Name = "txtBerat"
        Me.txtBerat.Size = New System.Drawing.Size(100, 26)
        Me.txtBerat.TabIndex = 1
        '
        'chkMember
        '
        Me.chkMember.AutoSize = True
        Me.chkMember.Location = New System.Drawing.Point(413, 149)
        Me.chkMember.Name = "chkMember"
        Me.chkMember.Size = New System.Drawing.Size(93, 24)
        Me.chkMember.TabIndex = 2
        Me.chkMember.Text = "Member"
        Me.chkMember.UseVisualStyleBackColor = True
        '
        'btnHitung
        '
        Me.btnHitung.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.btnHitung.Location = New System.Drawing.Point(297, 188)
        Me.btnHitung.Name = "btnHitung"
        Me.btnHitung.Size = New System.Drawing.Size(161, 34)
        Me.btnHitung.TabIndex = 3
        Me.btnHitung.Text = "Hitung Tarif"
        Me.btnHitung.UseVisualStyleBackColor = False
        '
        'lblSubTotal
        '
        Me.lblSubTotal.AutoSize = True
        Me.lblSubTotal.Location = New System.Drawing.Point(293, 247)
        Me.lblSubTotal.Name = "lblSubTotal"
        Me.lblSubTotal.Size = New System.Drawing.Size(111, 20)
        Me.lblSubTotal.TabIndex = 4
        Me.lblSubTotal.Text = "Subtotal: Rp 0"
        '
        'lblDiskon
        '
        Me.lblDiskon.AutoSize = True
        Me.lblDiskon.Location = New System.Drawing.Point(293, 276)
        Me.lblDiskon.Name = "lblDiskon"
        Me.lblDiskon.Size = New System.Drawing.Size(100, 20)
        Me.lblDiskon.TabIndex = 5
        Me.lblDiskon.Text = "Diskon: Rp 0"
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Location = New System.Drawing.Point(293, 307)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(131, 20)
        Me.lblTotal.TabIndex = 6
        Me.lblTotal.Text = "Total Bayar: Rp 0"
        '
        'lblMember
        '
        Me.lblMember.AutoSize = True
        Me.lblMember.Location = New System.Drawing.Point(247, 149)
        Me.lblMember.Name = "lblMember"
        Me.lblMember.Size = New System.Drawing.Size(139, 20)
        Me.lblMember.TabIndex = 7
        Me.lblMember.Text = "Verifikasi Member:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblMember)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.lblDiskon)
        Me.Controls.Add(Me.lblSubTotal)
        Me.Controls.Add(Me.btnHitung)
        Me.Controls.Add(Me.chkMember)
        Me.Controls.Add(Me.txtBerat)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtBerat As TextBox
    Friend WithEvents chkMember As CheckBox
    Friend WithEvents btnHitung As Button
    Friend WithEvents lblSubTotal As Label
    Friend WithEvents lblDiskon As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents lblMember As Label
End Class
