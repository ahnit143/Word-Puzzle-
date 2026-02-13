Imports System.Data.SQLite

Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub



    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        'before the user can login we need to check if the textboxes are empty
        'if they contains the default values ( username & password )
        'check if this user exist in the database

        Dim conn As New db_connection()
        Dim table As New DataTable()

        Dim command As New SQLiteCommand("SELECT id FROM users WHERE username = @usn AND password = @pass", conn.getConnection)

        command.Parameters.AddWithValue("@usn", txtUsername.Text)
        command.Parameters.AddWithValue("@pass", txtPwd.Text)

        If txtUsername.Text.Trim() = "" Or txtUsername.Text.Trim().ToLower() = "username" Then

            MessageBox.Show("Enter your Username!", "Missing Username", MessageBoxButtons.OK, MessageBoxIcon.Information)

        ElseIf txtPwd.Text.Trim() = "" Or txtPwd.Text.Trim().ToLower() = "password" Then

            MessageBox.Show("Enter your Password!", "Missing Password", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Else

            Dim adapter As New SQLiteDataAdapter(command)
            adapter.Fill(table)

            If table.Rows.Count > 0 Then

                MessageBox.Show("Login Successfully", "LOGGED", MessageBoxButtons.OK, MessageBoxIcon.Information)

                Me.Hide()
                Dim gameOption As New frmGameOption
                gameOption.Show()


            Else
                MessageBox.Show("Username or Password doesn't exist!", "NOT LOGGED", MessageBoxButtons.OK, MessageBoxIcon.Error)

            End If
        End If


    End Sub


    Private Sub nikn(sender As Object, e As EventArgs) Handles txtPwd.Click

    End Sub

    Private Sub mm(sender As Object, e As EventArgs) Handles txtPwd.TextChanged

    End Sub

    Private Sub txtUsername_TextChanged(sender As Object, e As EventArgs) Handles txtUsername.TextChanged

    End Sub

    Private Sub txtUsername_Enter(sender As Object, e As EventArgs) Handles txtUsername.Enter
        'clear the textbox when the textbox get the focus 
        Dim username As String = txtUsername.Text
        'check if the username is empty 
        'check if the textbox contains the default value "username" 
        If username.Trim().ToLower() = "username" Or username.Trim() = "" Then

            'clear the textbox 
            txtUsername.Text = ""
            'change the textbox for color 
            txtUsername.ForeColor = Color.Black

        End If
    End Sub

    Private Sub txtUsername_Leave(sender As Object, e As EventArgs) Handles txtUsername.Leave
        'when the textbox get lost the focus 
        Dim username As String = txtUsername.Text
        'check if the username is empty 
        'check if the textbox contains the default value "username" 
        If username.Trim().ToLower() = "username" Or username.Trim() = "" Then

            'set the textbox text
            txtUsername.Text = "Username"
            'change the textbox for color 
            txtUsername.ForeColor = Color.Black

        End If
    End Sub

    Private Sub txtPwd_Enter(sender As Object, e As EventArgs) Handles txtPwd.Enter

        'when textbox password has focus
        Dim pass As String = txtPwd.Text
        If pass.Trim.ToLower() = "password" Or pass.Trim() = "" Then

            'clear the textbox text
            txtPwd.Text = ""
            'change the textbox for color
            txtPwd.ForeColor = Color.Black
            'use system password 
            txtPwd.UseSystemPasswordChar = True

        End If
    End Sub

    Private Sub txtPwd_Leave(sender As Object, e As EventArgs) Handles txtPwd.Leave

        'when textbox password lost focus
        Dim pass As String = txtPwd.Text
        If pass.Trim.ToLower() = "password" Or pass.Trim() = "" Then

            'set the textbox text
            txtPwd.Text = "Password"
            'change the textbox for color
            txtPwd.ForeColor = Color.Black
            'set system password 
            txtPwd.UseSystemPasswordChar = False
        End If
    End Sub

    Private Sub lblAcc_Click(sender As Object, e As EventArgs) Handles lblAcc.Click
        Me.Hide()
        Dim rForm As New frmRegister()
        rForm.Show()

    End Sub

    Private Sub lblAcc_MouseEnter(sender As Object, e As EventArgs) Handles lblAcc.MouseEnter
        lblAcc.ForeColor = Color.Blue
    End Sub

    Private Sub lblAcc_MouseLeave(sender As Object, e As EventArgs) Handles lblAcc.MouseLeave
        lblAcc.ForeColor = Color.Black
    End Sub
End Class
