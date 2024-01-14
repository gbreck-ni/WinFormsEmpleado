Imports WinFormsEmpleado.DAL
Imports WinFormsEmpleado.Models

Public Class EmpleadoService
    Implements IEmpleadoService
    Private ReadOnly _repository As IEmpleadoRepository

    Public Sub New(repository As IEmpleadoRepository)
        _repository = repository
    End Sub

    Public Function Insert(entity As Empleado) As Boolean Implements IEmpleadoService.Insert
        Return _repository.Insert(entity)
    End Function

    Public Function Delete(id As Integer) As Boolean Implements IEmpleadoService.Delete
        Return _repository.Delete(id)
    End Function

    Public Function Update(entity As Empleado) As Boolean Implements IEmpleadoService.Update
        Return _repository.Update(entity)
    End Function

    Public Function GetAll() As List(Of Empleado) Implements IEmpleadoService.GetAll
        Return _repository.GetAll()
    End Function
End Class
