Public Class FormPanel
    Private ReadOnly _frmEmpleado As FormEmpleado
    Private ReadOnly _frmVacaciones As FormVacaciones
    Public Sub New(frmEmpleado As FormEmpleado,
                   frmVacaciones As FormVacaciones)
        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        _frmEmpleado = frmEmpleado
        _frmVacaciones = frmVacaciones
    End Sub

    Private Sub btnFormEmpleado_Click(sender As Object, e As EventArgs) Handles btnFormEmpleado.Click
        Dim form = _frmEmpleado
        form.ShowDialog(Me)
    End Sub

    Private Sub btnFormVacaciones_Click(sender As Object, e As EventArgs) Handles btnFormVacaciones.Click
        Dim form = _frmVacaciones
        form.ShowDialog(Me)
    End Sub
End Class