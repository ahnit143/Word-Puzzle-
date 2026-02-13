<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHard
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmHard))
        Me.lbl_Result = New System.Windows.Forms.Button()
        Me.lbl_Word = New System.Windows.Forms.Button()
        Me.btn_Start = New System.Windows.Forms.Button()
        Me.btn_Next = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lbl_Result
        '
        Me.lbl_Result.BackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.lbl_Result.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Result.Location = New System.Drawing.Point(44, 319)
        Me.lbl_Result.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lbl_Result.Name = "lbl_Result"
        Me.lbl_Result.Size = New System.Drawing.Size(319, 39)
        Me.lbl_Result.TabIndex = 13
        Me.lbl_Result.Text = "Result"
        Me.lbl_Result.UseVisualStyleBackColor = False
        '
        'lbl_Word
        '
        Me.lbl_Word.BackColor = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.lbl_Word.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Word.Location = New System.Drawing.Point(44, 45)
        Me.lbl_Word.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lbl_Word.Name = "lbl_Word"
        Me.lbl_Word.Size = New System.Drawing.Size(319, 53)
        Me.lbl_Word.TabIndex = 12
        Me.lbl_Word.Text = "Word"
        Me.lbl_Word.UseVisualStyleBackColor = False
        '
        'btn_Start
        '
        Me.btn_Start.BackColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(107, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.btn_Start.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Start.Location = New System.Drawing.Point(44, 169)
        Me.btn_Start.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_Start.Name = "btn_Start"
        Me.btn_Start.Size = New System.Drawing.Size(319, 39)
        Me.btn_Start.TabIndex = 10
        Me.btn_Start.Text = "Start"
        Me.btn_Start.UseVisualStyleBackColor = False
        '
        'btn_Next
        '
        Me.btn_Next.BackColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(107, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.btn_Next.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Next.Location = New System.Drawing.Point(44, 245)
        Me.btn_Next.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_Next.Name = "btn_Next"
        Me.btn_Next.Size = New System.Drawing.Size(319, 39)
        Me.btn_Next.TabIndex = 11
        Me.btn_Next.Text = "Next"
        Me.btn_Next.UseVisualStyleBackColor = False
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(44, 114)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(317, 34)
        Me.TextBox1.TabIndex = 9
        '
        'frmHard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(407, 406)
        Me.Controls.Add(Me.lbl_Result)
        Me.Controls.Add(Me.lbl_Word)
        Me.Controls.Add(Me.btn_Start)
        Me.Controls.Add(Me.btn_Next)
        Me.Controls.Add(Me.TextBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmHard"
        Me.Text = "frmHard"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_Result As Button
    Friend WithEvents lbl_Word As Button
    Friend WithEvents btn_Start As Button
    Friend WithEvents btn_Next As Button
    Friend WithEvents TextBox1 As TextBox
End Class
