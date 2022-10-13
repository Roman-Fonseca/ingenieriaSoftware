Imports MySql.Data
Imports MySql.Data.MySqlClient

Module conexion

    Public GLO_CambiosProductos As Integer = 0

    Public ruta As String

    Public GloconexionDB As New MySql.Data.MySqlClient.MySqlConnection
    Public Glocomando As New MySql.Data.MySqlClient.MySqlCommand
    Public Glodatareader As MySql.Data.MySqlClient.MySqlDataReader

    Public Function ConexionMySQL() As Boolean
        If GloconexionDB.State = ConnectionState.Closed Then
            'GloconexionDB.ConnectionString = "server= localhost; DataBase= tienda; user id= root; password =root"
            GloconexionDB.ConnectionString = "server=ROMAN; port=3306;DataBase= tienda; user id= rootdos; password =rootroot12345"
            GloconexionDB.Open()
        End If
        Return True
    End Function


End Module
