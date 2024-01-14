Imports System.Data.SqlClient
Imports WinFormsEmpleado.Models

Public Class VacacionesRepository
    Inherits DBTestContext
    Implements IVacacionesRepository

    Public Function Insert(entity As Vacaciones) As Boolean Implements IVacacionesRepository.Insert
        Dim result As Integer = 0
        Using conn = DbConnection()
            conn.Open()

            Dim sql As String = "spInsertVacaciones"
            Using cmd As New SqlCommand(sql, conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.CommandTimeout = 1000

                Dim parameter As New SqlParameter() With {
                    .ParameterName = "@empleadoId",
                    .Direction = ParameterDirection.Input,
                    .Value = entity.EmpleadoId
                }
                cmd.Parameters.Add(parameter)

                parameter = New SqlParameter() With {
                    .ParameterName = "@diaSolicitado",
                    .Direction = ParameterDirection.Input,
                    .Value = entity.DiaSolicitado
                }
                cmd.Parameters.Add(parameter)

                result = cmd.ExecuteNonQuery()
            End Using
            conn.Close()
        End Using
        Return result > 0
    End Function

    Public Function Delete(id As Integer) As Boolean Implements IVacacionesRepository.Delete
        Dim result As Integer = 0
        Using conn = DbConnection()
            conn.Open()

            Dim sql As String = "spDeleteVacacionesEmpleado"
            Using cmd As New SqlCommand(sql, conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.CommandTimeout = 1000

                Dim parameter As New SqlParameter() With {
                    .ParameterName = "@id",
                    .Direction = ParameterDirection.Input,
                    .Value = id
                }
                cmd.Parameters.Add(parameter)

                result = cmd.ExecuteNonQuery()
            End Using
            conn.Close()
        End Using
        Return result > 0
    End Function

    Public Function GetAll(empleadoId As Integer) As List(Of Vacaciones) Implements IVacacionesRepository.GetAll
        Dim list As New List(Of Vacaciones)()
        Using conn = DbConnection()
            conn.Open()
            Dim sql As String = "spReadVacacionesEmpleado"
            Using cmd As New SqlCommand(sql, conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.CommandTimeout = 1000
                Dim parameter As New SqlParameter() With {
                    .ParameterName = "@empleadoId",
                    .Direction = ParameterDirection.Input,
                    .Value = empleadoId
                }
                cmd.Parameters.Add(parameter)

                Dim reader As SqlDataReader = cmd.ExecuteReader()
                While reader.Read()
                    Dim vacaciones As New Vacaciones() With {
                    .Id = Convert.ToInt32(reader("Id")),
                    .EmpleadoId = Convert.ToInt32(reader("EmpleadoId")),
                    .DiaSolicitado = Convert.ToDateTime(reader("DiaSolicitado"))
                }
                    list.Add(vacaciones)
                End While
            End Using
            conn.Close()
        End Using
        Return list
    End Function
End Class
