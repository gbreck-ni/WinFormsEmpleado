Imports System.ComponentModel
Imports WinFormsEmpleado.BLL
Imports WinFormsEmpleado.Models

Public Class FormEmpleado

    Private ReadOnly _empleadoService As IEmpleadoService
    Private _empleado As Empleado

    Public Sub New(empleadoService As IEmpleadoService)
        InitializeComponent()
        CenterToScreen()
        _empleadoService = empleadoService
        _empleado = New Empleado()
    End Sub

    Private Sub ClearInput()
        _empleado = New Empleado()

    End Sub
    Private Sub Create()
        _empleadoService.Insert(_empleado)
    End Sub

    Private Sub Read()
        Dim bindingList As New BindingList(Of Empleado)(_empleadoService.GetAll())
        Dim bindingSource As New BindingSource(bindingList, Nothing)
        DataGridView1.DataSource = bindingSource
    End Sub

    Private Function UpdateRecord() As Boolean
        Dim respuesta As Boolean = _empleadoService.Update(_empleado)
        Return respuesta
    End Function

    Private Function Delete() As Boolean
        Dim index As Integer = DataGridView1.CurrentCell.RowIndex
        Dim focusedRow As DataGridViewRow = DataGridView1.Rows(index)

        _empleado = TryCast(focusedRow.DataBoundItem, Empleado)

        Dim result As Boolean = _empleadoService.Delete(_empleado.Id)
        Return result
    End Function



    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridView1.AutoGenerateColumns = False

        Read()
    End Sub


    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        ' Delete
        If e.ColumnIndex = DataGridView1.Columns("colDelete").Index Then
            If DataGridView1.Rows.Count = 0 Then
                Return
            End If

            Dim index As Integer = DataGridView1.CurrentCell.RowIndex
            Dim focusedRow As DataGridViewRow = DataGridView1.Rows(index)

            If focusedRow Is Nothing Then
                MessageBox.Show($"Ningún cambio realizado", "Empleados", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            If MessageBox.Show($"Desea eliminar a {focusedRow.Cells("colNombreCompleto").Value.ToString().ToUpper()}", "Empleados", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = DialogResult.OK Then
                If Delete() Then
                    MessageBox.Show($"Borrado!", "Empleados", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If

                ClearInput()
                Read()
            End If
        End If

        ' Edit
        If e.ColumnIndex = DataGridView1.Columns("colUpdate").Index Then
            If DataGridView1.Rows.Count = 0 Then
                Return
            End If

            Dim index As Integer = DataGridView1.CurrentCell.RowIndex
            Dim focusedRow As DataGridViewRow = DataGridView1.Rows(index)

            Dim empleadoId = Convert.ToInt32(focusedRow.Cells("colId").Value)
            Dim form = New FormModelEmpleado()
            form.nuevoEmpleado = TryCast(focusedRow.DataBoundItem, Empleado)
            If form.ShowDialog(Me) = DialogResult.OK Then
                _empleado = form.nuevoEmpleado
                UpdateRecord()
                ClearInput()
                Read()
            End If
        End If
    End Sub

    Private Sub DataGridView1_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellValueChanged
        ' Update
        If DataGridView1.Rows.Count = 0 Then Return

        Dim index As Integer = DataGridView1.CurrentCell.RowIndex
        Dim focusedRow As DataGridViewRow = DataGridView1.Rows(index)

        If focusedRow Is Nothing Then
            MessageBox.Show($"Ningún cambio realizado", "Empleados", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If MessageBox.Show($"Desea actualizar a {focusedRow.Cells("colNombreCompleto").Value.ToString().ToUpper()}", "Empleado", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = DialogResult.OK Then
            UpdateRecord()

            ClearInput()
            Read()
        End If
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Dim form As New FormModelEmpleado()
        form.ShowDialog(Me)

        If form.nuevoEmpleado.NombreCompleto Is Nothing Then
            Return
        End If

        _empleado = form.nuevoEmpleado

        Create()
        ClearInput()
        Read()
    End Sub
End Class
