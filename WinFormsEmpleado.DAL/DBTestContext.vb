Imports System.Data.SqlClient

Public Class DBTestContext
    Protected Function DbConnection() As SqlConnection
        Return New SqlConnection("Server = localhost\SQLEXPRESS02; Database = Test; Trusted_Connection = True; TrustServerCertificate = true")
    End Function
End Class
