Imports WinFormsEmpleado.Models

Public Interface IVacacionesRepository
    Function Insert(entity As Vacaciones) As Boolean
    Function Delete(id As Int32) As Boolean
    Function GetAll(empleadoId As Int32) As List(Of Vacaciones)
End Interface
