Public Class frmHard
    Dim words() As String = {"oblivious", "eclipse", "brilliant", "phenomenon", "luminous", "curosity", "spectacular"}
    Dim item As Integer = 0
    Dim random As Random = New Random()
    Dim score As Integer = 0
    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub frmHard_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub btn_Start_Click(sender As Object, e As EventArgs) Handles btn_Start.Click
        item = 0
        TextBox1.Text = ""
        lbl_Result.Text = ""
        score = 0

        displayWord()
        btn_Next.Enabled = True
        btn_Start.Enabled = False
    End Sub

    Private Sub btn_Next_Click(sender As Object, e As EventArgs) Handles btn_Next.Click
        checkWord()
        If item < words.Length - 1 Then
            item += 1
            displayWord()
        End If
    End Sub

    Public Sub displayWord()
        Dim pos1 As Integer = System.Convert.ToInt32(((random.Next((words(item).Length)))))
        Dim pos2 As Integer = System.Convert.ToInt32(((random.Next((words(item).Length)))))
        Dim pos3 As Integer = System.Convert.ToInt32(((random.Next((words(item).Length)))))

        Dim word As String = words(item)
        Dim wee As String = ""

        word = word.Remove(pos1, 1).Insert(pos1, "_")
        word = word.Remove(pos2, 1).Insert(pos2, "_")
        word = word.Remove(pos3, 1).Insert(pos3, "_")

        lbl_Word.Text = word
    End Sub

    Public Sub checkWord()
        If words(item).ToLower().Trim() = TextBox1.Text.ToLower().Trim() Then
            lbl_Result.Text = "Correct"
            lbl_Result.BackColor = Color.Green
            score += 1
        Else
            lbl_Result.Text = "Wrong"
            lbl_Result.BackColor = Color.Red
        End If

        If item = words.Length - 1 Then
            lbl_Result.Text &= " ( " & score & " / " & words.Length & " )"
            lbl_Result.BackColor = Color.LightPink
            btn_Start.Enabled = True

            'Save Score to Database
            SaveScore("Hard", score)

            MessageBox.Show("Game finished! Score saved.", "Hard Mode", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

        TextBox1.Text = ""
    End Sub
End Class