Imports System.Data.SQLite

Public Class frmRegister
    Private lnmae As Object

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles lblFN.Click

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles lblConPwd.Click

    End Sub



    Private Sub txtFirst_Enter(sender As Object, e As EventArgs) Handles txtFirst.Enter
        lblFN.ForeColor = Color.Red
    End Sub

    Private Sub txtFirst_Leave(sender As Object, e As EventArgs) Handles txtFirst.Leave
        lblFN.ForeColor = Color.Black
    End Sub

    Private Sub txtLast_Enter(sender As Object, e As EventArgs) Handles txtLast.Enter
        lblLN.ForeColor = Color.Red
    End Sub

    Private Sub txtLast_Leave(sender As Object, e As EventArgs) Handles txtLast.Leave
        lblLN.ForeColor = Color.Black
    End Sub

    Private Sub txtUsername_Enter(sender As Object, e As EventArgs) Handles txtUsername.Enter
        lblUsername.ForeColor = Color.Red
    End Sub

    Private Sub txtUsername_Leave(sender As Object, e As EventArgs) Handles txtUsername.Leave
        lblUsername.ForeColor = Color.Black
    End Sub

    Private Sub txtEmail_Enter(sender As Object, e As EventArgs) Handles txtEmail.Enter
        lblEmail.ForeColor = Color.Red
    End Sub

    Private Sub txtEmail_Leave(sender As Object, e As EventArgs) Handles txtEmail.Leave
        lblEmail.ForeColor = Color.Black
    End Sub

    Private Sub txtPwd_Enter(sender As Object, e As EventArgs) Handles txtPwd.Enter
        lblPwd.ForeColor = Color.Red
    End Sub

    Private Sub txtPwd_Leave(sender As Object, e As EventArgs) Handles txtPwd.Leave
        lblPwd.ForeColor = Color.Black
    End Sub

    Private Sub txtConPwd_Enter(sender As Object, e As EventArgs) Handles txtConPwd.Enter
        lblConPwd.ForeColor = Color.Red
    End Sub

    Private Sub txtConPwd_Leave(sender As Object, e As EventArgs) Handles txtConPwd.Leave
        lblConPwd.ForeColor = Color.Black
    End Sub

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click

        ' check if the fields are empty 
        'check if the password = the confirm password
        ' check if the username already exists 

        ' get textobxes values 
        Dim fname As String = txtFirst.Text
        Dim lname As String = txtLast.Text
        Dim username As String = txtUsername.Text
        Dim email As String = txtEmail.Text
        Dim password As String = txtPwd.Text
        Dim cpassword As String = txtConPwd.Text

        If fname.Trim() = "" Or lname.Trim() = "" Or username.Trim() = "" Or email.Trim() = "" Or password.Trim() = "" Then

            MessageBox.Show("One or More Fields are Empty", "Missing Data", MessageBoxButtons.OK, MessageBoxIcon.Stop)

        ElseIf Not String.Equals(password, cpassword) Then

            MessageBox.Show("Wrong Confirmation Password", "Password Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)

        ElseIf usernameExist(username) Then

            MessageBox.Show("This Username already exist!, Choose Another One!", "Duplicate Username!", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Else

            'add the new user 
            Dim conn As New db_connection()
            Dim command As New SQLiteCommand("INSERT INTO users (first_name, last_name, email, username, password) VALUES (@fn, @ln, @email, @usn, @pass)", conn.getConnection)

            command.Parameters.AddWithValue("@fn", fname)
            command.Parameters.AddWithValue("@ln", lname)
            command.Parameters.AddWithValue("@email", email)
            command.Parameters.AddWithValue("@usn", username)
            command.Parameters.AddWithValue("@pass", password)

            conn.openConnection()

            If command.ExecuteNonQuery() = 1 Then

                MessageBox.Show("Registeration completed successfully!", "User Added", MessageBoxButtons.OK, MessageBoxIcon.Information)
                conn.closeConnection()

                Me.Hide()
                Dim lForm As New Form1
                lForm.Show()

            Else


                MessageBox.Show("Something Happened", "User is not inserted!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                conn.closeConnection()

            End If

        End If
    End Sub

    ' create a function to check if the username already exists 
    Public Function usernameExist(ByVal username As String) As Boolean

        Dim con As New db_connection()
        Dim table As New DataTable()
        Dim command As New SQLiteCommand("SELECT 1 FROM users WHERE username = @usn", con.getConnection)
        command.Parameters.AddWithValue("@usn", username)

        Dim adapter As New SQLiteDataAdapter(command)
        adapter.Fill(table)

        ' if hte username exist return true 
        If table.Rows.Count > 0 Then

            Return True

            'if not return false


        Else

            Return False
        End If

    End Function

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Label2_Click_1(sender As Object, e As EventArgs) Handles lblAcc.Click

        Me.Hide()
        Dim lForm As New Form1
        lForm.Show()

    End Sub

    Private Sub lblAcc_MouseEnter(sender As Object, e As EventArgs) Handles lblAcc.MouseEnter
        lblAcc.ForeColor = Color.Blue
    End Sub

    Private Sub lblAcc_MouseLeave(sender As Object, e As EventArgs) Handles lblAcc.MouseLeave
        lblAcc.ForeColor = Color.Black
    End Sub
End Class