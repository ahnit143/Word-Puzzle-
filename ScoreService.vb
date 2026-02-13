Imports System.Data.SQLite

Module ScoreService

    Public Sub SaveScore(gameOption As String, score As Integer)

        Dim conn As New db_connection()

        Dim cmd As New SQLiteCommand(
            "INSERT INTO scores (user_id, game_option, score)
             VALUES (@uid, @game, @score)",
            conn.getConnection
        )

        cmd.Parameters.AddWithValue("@uid", LoggedUserID)
        cmd.Parameters.AddWithValue("@game", gameOption)
        cmd.Parameters.AddWithValue("@score", score)

        conn.openConnection()
        cmd.ExecuteNonQuery()
        conn.closeConnection()

    End Sub

End Module

