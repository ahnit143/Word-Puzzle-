<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmRegister
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRegister))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblAcc = New System.Windows.Forms.Label()
        Me.lblConPwd = New System.Windows.Forms.Label()
        Me.lblPwd = New System.Windows.Forms.Label()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.lblLN = New System.Windows.Forms.Label()
        Me.lblFN = New System.Windows.Forms.Label()
        Me.txtConPwd = New System.Windows.Forms.TextBox()
        Me.txtPwd = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.txtFirst = New System.Windows.Forms.TextBox()
        Me.txtLast = New System.Windows.Forms.TextBox()
        Me.btnRegister = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(256, 13)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(216, 42)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "REGISTER"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Location = New System.Drawing.Point(0, -2)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(772, 548)
        Me.Panel1.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.Panel2.Controls.Add(Me.lblAcc)
        Me.Panel2.Controls.Add(Me.lblConPwd)
        Me.Panel2.Controls.Add(Me.lblPwd)
        Me.Panel2.Controls.Add(Me.lblEmail)
        Me.Panel2.Controls.Add(Me.lblUsername)
        Me.Panel2.Controls.Add(Me.lblLN)
        Me.Panel2.Controls.Add(Me.lblFN)
        Me.Panel2.Controls.Add(Me.txtConPwd)
        Me.Panel2.Controls.Add(Me.txtPwd)
        Me.Panel2.Controls.Add(Me.txtEmail)
        Me.Panel2.Controls.Add(Me.txtUsername)
        Me.Panel2.Controls.Add(Me.txtFirst)
        Me.Panel2.Controls.Add(Me.txtLast)
        Me.Panel2.Controls.Add(Me.btnRegister)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Location = New System.Drawing.Point(13, 15)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(744, 498)
        Me.Panel2.TabIndex = 0
        '
        'lblAcc
        '
        Me.lblAcc.AutoSize = True
        Me.lblAcc.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAcc.Location = New System.Drawing.Point(221, 440)
        Me.lblAcc.Name = "lblAcc"
        Me.lblAcc.Size = New System.Drawing.Size(265, 20)
        Me.lblAcc.TabIndex = 14
        Me.lblAcc.Text = "Already Have An Account? Sign In"
        '
        'lblConPwd
        '
        Me.lblConPwd.AutoSize = True
        Me.lblConPwd.Location = New System.Drawing.Point(389, 305)
        Me.lblConPwd.Name = "lblConPwd"
        Me.lblConPwd.Size = New System.Drawing.Size(123, 16)
        Me.lblConPwd.TabIndex = 13
        Me.lblConPwd.Text = "*Confirm Password:"
        '
        'lblPwd
        '
        Me.lblPwd.AutoSize = True
        Me.lblPwd.Location = New System.Drawing.Point(88, 305)
        Me.lblPwd.Name = "lblPwd"
        Me.lblPwd.Size = New System.Drawing.Size(75, 16)
        Me.lblPwd.TabIndex = 12
        Me.lblPwd.Text = "*Password:"
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Location = New System.Drawing.Point(88, 226)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(49, 16)
        Me.lblEmail.TabIndex = 11
        Me.lblEmail.Text = "*Email:"
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.Location = New System.Drawing.Point(88, 158)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(78, 16)
        Me.lblUsername.TabIndex = 10
        Me.lblUsername.Text = "*Username:"
        '
        'lblLN
        '
        Me.lblLN.AutoSize = True
        Me.lblLN.Location = New System.Drawing.Point(389, 93)
        Me.lblLN.Name = "lblLN"
        Me.lblLN.Size = New System.Drawing.Size(83, 16)
        Me.lblLN.TabIndex = 9
        Me.lblLN.Text = "*Last Name: "
        '
        'lblFN
        '
        Me.lblFN.AutoSize = True
        Me.lblFN.Location = New System.Drawing.Point(88, 93)
        Me.lblFN.Name = "lblFN"
        Me.lblFN.Size = New System.Drawing.Size(83, 16)
        Me.lblFN.TabIndex = 8
        Me.lblFN.Text = "*First Name: "
        '
        'txtConPwd
        '
        Me.txtConPwd.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtConPwd.ForeColor = System.Drawing.Color.Black
        Me.txtConPwd.Location = New System.Drawing.Point(392, 325)
        Me.txtConPwd.Margin = New System.Windows.Forms.Padding(4)
        Me.txtConPwd.Name = "txtConPwd"
        Me.txtConPwd.Size = New System.Drawing.Size(270, 34)
        Me.txtConPwd.TabIndex = 7
        Me.txtConPwd.UseSystemPasswordChar = True
        '
        'txtPwd
        '
        Me.txtPwd.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPwd.ForeColor = System.Drawing.Color.Black
        Me.txtPwd.Location = New System.Drawing.Point(91, 325)
        Me.txtPwd.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPwd.Name = "txtPwd"
        Me.txtPwd.Size = New System.Drawing.Size(270, 34)
        Me.txtPwd.TabIndex = 6
        Me.txtPwd.UseSystemPasswordChar = True
        '
        'txtEmail
        '
        Me.txtEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.ForeColor = System.Drawing.Color.Black
        Me.txtEmail.Location = New System.Drawing.Point(91, 246)
        Me.txtEmail.Margin = New System.Windows.Forms.Padding(4)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(571, 34)
        Me.txtEmail.TabIndex = 5
        '
        'txtUsername
        '
        Me.txtUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsername.ForeColor = System.Drawing.Color.Black
        Me.txtUsername.Location = New System.Drawing.Point(91, 178)
        Me.txtUsername.Margin = New System.Windows.Forms.Padding(4)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(571, 34)
        Me.txtUsername.TabIndex = 4
        '
        'txtFirst
        '
        Me.txtFirst.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFirst.ForeColor = System.Drawing.Color.Black
        Me.txtFirst.Location = New System.Drawing.Point(91, 113)
        Me.txtFirst.Margin = New System.Windows.Forms.Padding(4)
        Me.txtFirst.Name = "txtFirst"
        Me.txtFirst.Size = New System.Drawing.Size(270, 34)
        Me.txtFirst.TabIndex = 3
        '
        'txtLast
        '
        Me.txtLast.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLast.ForeColor = System.Drawing.Color.Black
        Me.txtLast.Location = New System.Drawing.Point(392, 113)
        Me.txtLast.Margin = New System.Windows.Forms.Padding(4)
        Me.txtLast.Name = "txtLast"
        Me.txtLast.Size = New System.Drawing.Size(270, 34)
        Me.txtLast.TabIndex = 2
        '
        'btnRegister
        '
        Me.btnRegister.BackColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(107, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.btnRegister.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegister.Location = New System.Drawing.Point(91, 386)
        Me.btnRegister.Margin = New System.Windows.Forms.Padding(4)
        Me.btnRegister.Name = "btnRegister"
        Me.btnRegister.Size = New System.Drawing.Size(571, 50)
        Me.btnRegister.TabIndex = 1
        Me.btnRegister.Text = "SIGN UP"
        Me.btnRegister.UseVisualStyleBackColor = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(744, 66)
        Me.Panel3.TabIndex = 0
        '
        'frmRegister
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(770, 524)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmRegister"
        Me.Text = "frmRegister"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents txtLast As TextBox
    Friend WithEvents btnRegister As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents lblConPwd As Label
    Friend WithEvents lblPwd As Label
    Friend WithEvents lblEmail As Label
    Friend WithEvents lblUsername As Label
    Friend WithEvents lblLN As Label
    Friend WithEvents lblFN As Label
    Friend WithEvents txtConPwd As TextBox
    Friend WithEvents txtPwd As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtFirst As TextBox
    Friend WithEvents lblAcc As Label
End Class
