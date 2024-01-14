Imports Microsoft.Extensions.DependencyInjection
Imports WinFormsEmpleado.BLL
Imports WinFormsEmpleado.DAL

Module Program
    Public Sub Main()
        '
        ' Dependency Injection
        '
        Dim services = New ServiceCollection()
        SetServiceContainer(services)

        Dim serviceProvider As ServiceProvider = services.BuildServiceProvider()
        Dim initForm = serviceProvider.GetRequiredService(Of FormPanel)()
        Application.Run(initForm)

    End Sub

    Private Sub SetServiceContainer(services As ServiceCollection)
        services.AddScoped(Of FormPanel)()
        services.AddScoped(Of FormEmpleado)()

        services.AddSingleton(Of DBTestContext)()

        services.AddScoped(Of IEmpleadoService, EmpleadoService)()
        services.AddScoped(Of IEmpleadoRepository, EmpleadoRepository)()

        services.AddScoped(Of IVacacionesService, VacacionesService)()
        services.AddScoped(Of IVacacionesRepository, VacacionesRepository)()
    End Sub
End Module
