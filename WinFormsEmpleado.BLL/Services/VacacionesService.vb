Imports WinFormsEmpleado.DAL
Imports WinFormsEmpleado.Models

Public Class VacacionesService
    Implements IVacacionesService
    Private ReadOnly _repository As IVacacionesRepository
    Public Sub New(repository As IVacacionesRepository)
        _repository = repository
    End Sub

    Public Function Insert(entity As Vacaciones) As Boolean Implements IVacacionesService.Insert
        Return _repository.Insert(entity)
    End Function

    Public Function Delete(id As Integer) As Boolean Implements IVacacionesService.Delete
        Return _repository.Delete(id)
    End Function

    Public Function GetAll(empleadoId As Integer) As List(Of Vacaciones) Implements IVacacionesService.GetAll
        Return _repository.GetAll(empleadoId)
    End Function

    Public Function CalcularVacacionesGeneradas(dateIni As Date, dateEnd As Date) As Decimal Implements IVacacionesService.CalcularVacacionesGeneradas
        Dim mesCount As Int32
        mesCount = ((dateEnd.Year - dateIni.Year) * 12) + dateEnd.Month - dateIni.Month
        Return mesCount * 2.5
    End Function
End Class
