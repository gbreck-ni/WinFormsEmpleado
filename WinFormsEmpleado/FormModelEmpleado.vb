Imports WinFormsEmpleado.Models

Public Class FormModelEmpleado
    Public nuevoEmpleado As New Empleado

    Private Function InputValidatorControl(sender As Object) As Boolean
        Dim textInput As TextBox = TryCast(sender, TextBox)
        If String.IsNullOrEmpty(textInput.Text.Trim()) Then
            MessageBox.Show("El campo no puede ser vacío.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            textInput.Focus()
            Return False
        End If
        Return True
    End Function
    Private Function InputValidatorControl(combo As ComboBox) As Boolean
        If combo.SelectedIndex < 0 Then
            MessageBox.Show("Seleccione un elemento de la lista.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            combo.Focus()
            Return False
        End If
        Return True
    End Function
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        '
        ' Validaciones
        '
        If Not InputValidatorControl(txtNombreCompleto) Then
            Return
        End If
        If Not InputValidatorControl(cboTipoIdentificacion) Then
            Return
        End If
        If Not InputValidatorControl(txtNumeroIdentificacion) Then
            Return
        End If
        If Not InputValidatorControl(txtSalarioBase) Then
            Return
        End If
        If Not InputValidatorControl(txtDireccion) Then
            Return
        End If
        '
        ' Fin validaciones
        '
        nuevoEmpleado.NombreCompleto = txtNombreCompleto.Text
        nuevoEmpleado.TipoIdentificacion = cboTipoIdentificacion.SelectedIndex
        nuevoEmpleado.NumeroIdentificacion = txtNumeroIdentificacion.Text
        nuevoEmpleado.SalarioBase = txtSalarioBase.Text
        nuevoEmpleado.FechaIngreso = dateFechaIngreso.Value
        nuevoEmpleado.Direccion = txtDireccion.Text

        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub txtSalarioBase_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSalarioBase.KeyPress
        ' Solo Decimales
        If (Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> "."c) Or
        (e.KeyChar = "."c AndAlso (sender.Text.Contains(".") Or sender.Text.Length = 0)) Then
            e.Handled = True ' Ignore the key press
        End If
    End Sub

    Private Sub FormModelEmpleado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If nuevoEmpleado.Id > 0 Then
            txtNombreCompleto.Text = nuevoEmpleado.NombreCompleto
            cboTipoIdentificacion.SelectedIndex = nuevoEmpleado.TipoIdentificacion
            txtNumeroIdentificacion.Text = nuevoEmpleado.NumeroIdentificacion
            txtDireccion.Text = nuevoEmpleado.Direccion
            txtSalarioBase.Text = nuevoEmpleado.SalarioBase
            dateFechaIngreso.Value = nuevoEmpleado.FechaIngreso
        End If
    End Sub
End Class