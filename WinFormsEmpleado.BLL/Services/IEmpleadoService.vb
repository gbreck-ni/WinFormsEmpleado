Imports WinFormsEmpleado.Models

Public Interface IEmpleadoService
    Function Insert(entity As Empleado) As Boolean
    Function Delete(id As Int32) As Boolean
    Function Update(entity As Empleado) As Boolean
    Function GetAll() As List(Of Empleado)
End Interface
