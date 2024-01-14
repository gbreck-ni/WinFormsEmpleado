Imports WinFormsEmpleado.Models

Public Interface IEmpleadoRepository
    Function Insert(entity As Empleado) As Boolean
    Function Delete(id As Int32) As Boolean
    Function Update(entity As Empleado) As Boolean
    Function GetAll() As List(Of Empleado)
End Interface
