Public Class FormPanel
    Private ReadOnly _frmEmpleado As FormEmpleado
    Public Sub New(frmEmpleado As FormEmpleado)
        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        _frmEmpleado = frmEmpleado
    End Sub

    Private Sub btnFormEmpleado_Click(sender As Object, e As EventArgs) Handles btnFormEmpleado.Click
        Dim form = _frmEmpleado
        form.ShowDialog(Me)
    End Sub

    Private Sub btnFormVacaciones_Click(sender As Object, e As EventArgs) Handles btnFormVacaciones.Click
    End Sub
End Class