Imports System.ComponentModel
Imports WinFormsEmpleado.BLL
Imports WinFormsEmpleado.Models

Public Class FormVacacionesDetalle
    Private ReadOnly _vacacionesService As IVacacionesService
    Public _empleado As Empleado
    Private _vacaciones As Vacaciones

    Public Sub New(vacacionesService As IVacacionesService)
        InitializeComponent()
        CenterToScreen()
        _vacacionesService = vacacionesService
        _vacaciones = New Vacaciones()
    End Sub
    Private Sub DetalleVacaciones()
        Dim tomadas As Decimal
        Dim generadas As Decimal
        Dim saldo As Decimal

        tomadas = Convert.ToDecimal(txtDiasTomados.Text)
        If (String.IsNullOrEmpty(txtDiasGenerados.Text)) Then
            generadas = 0
        Else
            generadas = Convert.ToDecimal(txtDiasGenerados.Text)
        End If

        saldo = generadas - tomadas

        txtSaldo.Text = saldo
    End Sub

    Private Sub ClearInput()
        _vacaciones = New Vacaciones()
    End Sub
    Private Sub Create()
        _vacaciones.EmpleadoId = _empleado.Id
        _vacaciones.DiaSolicitado = dateDiaTomado.Value.Date
        _vacacionesService.Insert(_vacaciones)
    End Sub
    Private Sub Read()
        Dim bindingList As New BindingList(Of Vacaciones)(_vacacionesService.GetAll(_empleado.Id))
        Dim bindingSource As New BindingSource(bindingList, Nothing)
        DataGridView1.DataSource = bindingSource
        txtDiasTomados.Text = bindingList.Count
    End Sub

    Private Function Delete() As Boolean
        Dim index As Integer = DataGridView1.CurrentCell.RowIndex
        Dim focusedRow As DataGridViewRow = DataGridView1.Rows(index)

        _vacaciones = TryCast(focusedRow.DataBoundItem, Vacaciones)

        Dim result As Boolean = _vacacionesService.Delete(_vacaciones.Id)
        Return result
    End Function

    Private Sub FormVacacionesDetalle_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridView1.AutoGenerateColumns = False

        lblNombreEmpleado.Text = _empleado.NombreCompleto
        dateDiaTomado.Value = DateTime.Today
        dateFechaInicio.Value = DateTime.Today
        dateFechaFinal.Value = DateTime.Today
        txtDiasGenerados.Text = String.Empty

        Read()
    End Sub
    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Create()
        ClearInput()
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
                MessageBox.Show($"Ningún cambio realizado", "Vacaciones", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            Dim diaTomado = Convert.ToDateTime(focusedRow.Cells("colDiaSolicitado").Value)

            If MessageBox.Show($"Desea eliminar el día: {diaTomado.Date.ToShortDateString() }", "Vacaciones", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = DialogResult.OK Then
                If Delete() Then
                    MessageBox.Show($"Borrado!", "Vacaciones", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If

                ClearInput()
                Read()
            End If
        End If
    End Sub

    Private Sub txtDiasTomados_TextChanged(sender As Object, e As EventArgs) Handles txtDiasTomados.TextChanged
        DetalleVacaciones()
    End Sub
    Private Sub txtDiasGenerados_TextChanged(sender As Object, e As EventArgs) Handles txtDiasGenerados.TextChanged
        DetalleVacaciones()
    End Sub
    Private Sub btnGenerar_Click(sender As Object, e As EventArgs) Handles btnGenerar.Click
        If (dateFechaInicio.Value.Date >= dateFechaFinal.Value.Date) Then
            MessageBox.Show($"La fecha de inicio no debe ser mayor que la de final", "Vacaciones", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        txtDiasGenerados.Text = _vacacionesService.CalcularVacacionesGeneradas(dateFechaInicio.Value, dateFechaFinal.Value).ToString()
    End Sub

    Private Sub dateFechaInicio_ValueChanged(sender As Object, e As EventArgs) Handles dateFechaInicio.ValueChanged
        txtDiasGenerados.Text = String.Empty
    End Sub

    Private Sub dateFechaFinal_ValueChanged(sender As Object, e As EventArgs) Handles dateFechaFinal.ValueChanged
        txtDiasGenerados.Text = String.Empty
    End Sub

    Private Sub btnReporte_Click(sender As Object, e As EventArgs) Handles btnReporte.Click
        PrintDialog1.Document = PrintDocument1

        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.WindowState = FormWindowState.Maximized
        PrintPreviewDialog1.ShowDialog()
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim FuenteTitulo As New Font("Microsoft San Serif", 22)
        Dim FuenteSubTitulo As New Font("Microsoft San Serif", 16)
        Dim FuenteNegrita As New Font("Microsoft San Serif", 9, Drawing.FontStyle.Bold)
        Dim FuenteDetalle As New Font("Microsoft San Serif", 9)

        'Reporte simple
        Dim y As Single
        Dim x As Single
        Dim heigth As Single

        heigth = 40
        y = 100
        x = 120

        e.Graphics.DrawString(Me.Text, FuenteTitulo, Brushes.Black, x, y)
        y += heigth
        e.Graphics.DrawString(lblNombreEmpleado.Text, FuenteSubTitulo, Brushes.Black, x, y + 5)

        y += heigth
        e.Graphics.DrawString($"{lblDiasTomados.Text}", FuenteSubTitulo, Brushes.Black, x, y)

        y += heigth
        Using redPen As New Pen(Color.Black)
            e.Graphics.DrawLine(redPen, x, y, x * 6, y)
        End Using

        heigth = 30

        Dim printLine As Int32
        Do While printLine < DataGridView1.RowCount
            y += heigth
            e.Graphics.DrawString($"Día {printLine + 1} - {Convert.ToDateTime(DataGridView1.Rows(printLine).Cells("colDiaSolicitado").Value).ToString("dd/MM/yyyy")}", FuenteDetalle, Brushes.Black, x * 5, y)
            printLine += 1
        Loop

        y += heigth
        Using redPen As New Pen(Color.Black)
            e.Graphics.DrawLine(redPen, x, y, x * 6, y)
        End Using

        y += heigth
        e.Graphics.DrawString($"{lblDiasTomados.Text}:", FuenteNegrita, Brushes.Black, x, y)
        e.Graphics.DrawString($"{txtDiasTomados.Text}", FuenteDetalle, Brushes.Black, x * 3, y)

        y += heigth
        e.Graphics.DrawString($"{lblVacacionesAcumuladas.Text}:", FuenteNegrita, Brushes.Black, x, y)
        e.Graphics.DrawString($"{txtDiasGenerados.Text}", FuenteDetalle, Brushes.Black, x * 3, y)

        y += heigth
        e.Graphics.DrawString($"{lblSaldo.Text}:", FuenteNegrita, Brushes.Black, x, y)
        e.Graphics.DrawString($"{txtSaldo.Text}", FuenteDetalle, Brushes.Black, x * 3, y)

    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub
End Class