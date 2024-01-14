Imports System.Data.SqlClient
Imports WinFormsEmpleado.Models

Public Class EmpleadoRepository
    Inherits DBTestContext
    Implements IEmpleadoRepository

    Public Function Insert(entity As Empleado) As Boolean Implements IEmpleadoRepository.Insert
        Dim result As Integer = 0
        Using conn = DbConnection()
            conn.Open()

            Dim sql As String = "spInsertEmpleado"
            Using cmd As New SqlCommand(sql, conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.CommandTimeout = 1000

                Dim parameter As New SqlParameter() With {
                    .ParameterName = "@nombreCompleto",
                    .Direction = ParameterDirection.Input,
                    .Value = entity.NombreCompleto
                }
                cmd.Parameters.Add(parameter)

                parameter = New SqlParameter() With {
                    .ParameterName = "@tipoIdentificacion",
                    .Direction = ParameterDirection.Input,
                    .Value = entity.TipoIdentificacion
                }
                cmd.Parameters.Add(parameter)

                parameter = New SqlParameter() With {
                    .ParameterName = "@numeroIdentificacion",
                    .Direction = ParameterDirection.Input,
                    .Value = entity.NumeroIdentificacion
                }
                cmd.Parameters.Add(parameter)

                parameter = New SqlParameter() With {
                    .ParameterName = "@fechaIngreso",
                    .Direction = ParameterDirection.Input,
                    .Value = entity.FechaIngreso
                }
                cmd.Parameters.Add(parameter)


                parameter = New SqlParameter() With {
                    .ParameterName = "@salarioBase",
                    .Direction = ParameterDirection.Input,
                    .Value = entity.SalarioBase
                }
                cmd.Parameters.Add(parameter)

                parameter = New SqlParameter() With {
                    .ParameterName = "@direccion",
                    .Direction = ParameterDirection.Input,
                    .Value = entity.Direccion
                }
                cmd.Parameters.Add(parameter)

                result = cmd.ExecuteNonQuery()
            End Using
            conn.Close()
        End Using
        Return result > 0

    End Function

    Public Function Delete(id As Integer) As Boolean Implements IEmpleadoRepository.Delete
        Dim result As Integer = 0
        Using conn = DbConnection()
            conn.Open()

            Dim sql As String = "spDeleteEmpleado"
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

    Public Function Update(entity As Empleado) As Boolean Implements IEmpleadoRepository.Update

        Dim result As Integer = 0
        Using conn = DbConnection()
            conn.Open()

            Dim sql As String = "spUpdateEmpleado"
            Using cmd As New SqlCommand(sql, conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.CommandTimeout = 1000

                Dim parameter As New SqlParameter() With {
                    .ParameterName = "@id",
                    .Direction = ParameterDirection.Input,
                    .Value = entity.Id
                }
                cmd.Parameters.Add(parameter)

                parameter = New SqlParameter() With {
                    .ParameterName = "@nombreCompleto",
                    .Direction = ParameterDirection.Input,
                    .Value = entity.NombreCompleto
                }
                cmd.Parameters.Add(parameter)

                parameter = New SqlParameter() With {
                    .ParameterName = "@tipoIdentificacion",
                    .Direction = ParameterDirection.Input,
                    .Value = entity.TipoIdentificacion
                }
                cmd.Parameters.Add(parameter)

                parameter = New SqlParameter() With {
                    .ParameterName = "@numeroIdentificacion",
                    .Direction = ParameterDirection.Input,
                    .Value = entity.NumeroIdentificacion
                }
                cmd.Parameters.Add(parameter)

                parameter = New SqlParameter() With {
                    .ParameterName = "@fechaIngreso",
                    .Direction = ParameterDirection.Input,
                    .Value = entity.FechaIngreso
                }
                cmd.Parameters.Add(parameter)

                parameter = New SqlParameter() With {
                    .ParameterName = "@salarioBase",
                    .Direction = ParameterDirection.Input,
                    .Value = entity.SalarioBase
                }
                cmd.Parameters.Add(parameter)

                parameter = New SqlParameter() With {
                    .ParameterName = "@direccion",
                    .Direction = ParameterDirection.Input,
                    .Value = entity.Direccion
                }
                cmd.Parameters.Add(parameter)

                result = cmd.ExecuteNonQuery()
            End Using
            conn.Close()
        End Using
        Return result > 0

    End Function

    Public Function GetAll() As List(Of Empleado) Implements IEmpleadoRepository.GetAll
        Dim list As New List(Of Empleado)()
        Using conn = DbConnection()
            conn.Open()
            Dim sql As String = "spReadEmpleado"
            Using cmd As New SqlCommand(sql, conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.CommandTimeout = 1000

                Dim reader As SqlDataReader = cmd.ExecuteReader()
                While reader.Read()
                    Dim empleado As New Empleado() With {
                    .Id = Convert.ToInt32(reader("Id")),
                    .NombreCompleto = Convert.ToString(reader("NombreCompleto")),
                    .TipoIdentificacion = Convert.ToInt32(reader("TipoIdentificacion")),
                    .NumeroIdentificacion = Convert.ToString(reader("NumeroIdentificacion")),
                    .SalarioBase = Convert.ToDecimal(reader("SalarioBase")),
                    .FechaIngreso = Convert.ToDateTime(reader("FechaIngreso")),
                    .Direccion = Convert.ToString(reader("Direccion"))
                }
                    list.Add(empleado)
                End While
            End Using
            conn.Close()
        End Using
        Return list
    End Function
End Class
