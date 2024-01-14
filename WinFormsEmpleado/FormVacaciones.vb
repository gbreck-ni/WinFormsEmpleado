Imports System.ComponentModel
Imports WinFormsEmpleado.BLL
Imports WinFormsEmpleado.Models

Public Class FormVacaciones
    Private ReadOnly _empleadoService As IEmpleadoService
    Private ReadOnly _vacacionesService As IVacacionesService
    Private ReadOnly _frmVacacionesDetalle As FormVacacionesDetalle

    Public Sub New(empleadoService As IEmpleadoService,
                   vacacionesService As IVacacionesService,
                   frmVacacionesDetalle As FormVacacionesDetalle)
        InitializeComponent()
        CenterToScreen()
        _empleadoService = empleadoService
        _vacacionesService = vacacionesService
        _frmVacacionesDetalle = frmVacacionesDetalle
    End Sub

    Private Sub ReadEmpleado()
        Dim bindingList As New BindingList(Of Empleado)(_empleadoService.GetAll())
        Dim bindingSource As New BindingSource(bindingList, Nothing)
        DataGridView1.DataSource = bindingSource
    End Sub

    Private Sub FormVacaciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridView1.AutoGenerateColumns = False
        ReadEmpleado()
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        ' Detalle Vacaciones
        If e.ColumnIndex = DataGridView1.Columns("colVacaciones").Index Then
            If DataGridView1.Rows.Count = 0 Then
                Return
            End If

            Dim index As Integer = DataGridView1.CurrentCell.RowIndex
            Dim focusedRow As DataGridViewRow = DataGridView1.Rows(index)

            Dim empleadoId = Convert.ToInt32(focusedRow.Cells("colId").Value)
            Dim form = _frmVacacionesDetalle
            form._empleado = TryCast(focusedRow.DataBoundItem, Empleado)
            Form.ShowDialog(Me)
        End If
    End Sub
End Class