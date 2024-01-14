Imports WinFormsEmpleado.Models

Public Interface IVacacionesService
    Function Insert(entity As Vacaciones) As Boolean
    Function Delete(id As Int32) As Boolean
    Function GetAll(empleadoId As Int32) As List(Of Vacaciones)
End Interface
