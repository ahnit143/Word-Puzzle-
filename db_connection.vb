Imports System.Data.SQLite
Public Class db_connection
    'create the connection
    Private connection As New SQLiteConnection(
        "Data Source = vbnet_game.db; Version = 3;")

    'return the connection 

    ReadOnly Property getConnection() As SQLiteConnection
        Get
            Return connection
        End Get
    End Property

    'open the connection 
    Public Sub openConnection()

        If connection.State = ConnectionState.Closed Then
            connection.Open()
        End If
    End Sub

    'close the connection 
    Public Sub closeConnection()

        If connection.State = ConnectionState.Open Then
            connection.Close()
        End If
    End Sub
End Class
