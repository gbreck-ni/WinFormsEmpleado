<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormModelEmpleado
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormModelEmpleado))
        Me.txtNombreCompleto = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cboTipoIdentificacion = New System.Windows.Forms.ComboBox()
        Me.txtNumeroIdentificacion = New System.Windows.Forms.TextBox()
        Me.txtSalarioBase = New System.Windows.Forms.TextBox()
        Me.dateFechaIngreso = New System.Windows.Forms.DateTimePicker()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtNombreCompleto
        '
        Me.txtNombreCompleto.Location = New System.Drawing.Point(143, 54)
        Me.txtNombreCompleto.Name = "txtNombreCompleto"
        Me.txtNombreCompleto.Size = New System.Drawing.Size(332, 20)
        Me.txtNombreCompleto.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(47, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Nombre Completo"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(29, 83)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(109, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Tipo de Identificación"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(65, 110)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Identificación"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(69, 136)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Salario Base"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(48, 165)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(90, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Fecha de Ingreso"
        '
        'cboTipoIdentificacion
        '
        Me.cboTipoIdentificacion.FormattingEnabled = True
        Me.cboTipoIdentificacion.Items.AddRange(New Object() {"Cédula", "Pasaporte"})
        Me.cboTipoIdentificacion.Location = New System.Drawing.Point(275, 80)
        Me.cboTipoIdentificacion.Name = "cboTipoIdentificacion"
        Me.cboTipoIdentificacion.Size = New System.Drawing.Size(200, 21)
        Me.cboTipoIdentificacion.TabIndex = 6
        '
        'txtNumeroIdentificacion
        '
        Me.txtNumeroIdentificacion.Location = New System.Drawing.Point(143, 107)
        Me.txtNumeroIdentificacion.Name = "txtNumeroIdentificacion"
        Me.txtNumeroIdentificacion.Size = New System.Drawing.Size(332, 20)
        Me.txtNumeroIdentificacion.TabIndex = 7
        '
        'txtSalarioBase
        '
        Me.txtSalarioBase.Location = New System.Drawing.Point(143, 133)
        Me.txtSalarioBase.Name = "txtSalarioBase"
        Me.txtSalarioBase.Size = New System.Drawing.Size(332, 20)
        Me.txtSalarioBase.TabIndex = 8
        Me.txtSalarioBase.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'dateFechaIngreso
        '
        Me.dateFechaIngreso.CustomFormat = "dd/MM/yyy"
        Me.dateFechaIngreso.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dateFechaIngreso.Location = New System.Drawing.Point(275, 159)
        Me.dateFechaIngreso.MaxDate = New Date(2024, 12, 31, 0, 0, 0, 0)
        Me.dateFechaIngreso.MinDate = New Date(1993, 1, 1, 0, 0, 0, 0)
        Me.dateFechaIngreso.Name = "dateFechaIngreso"
        Me.dateFechaIngreso.Size = New System.Drawing.Size(200, 20)
        Me.dateFechaIngreso.TabIndex = 9
        '
        'btnGuardar
        '
        Me.btnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardar.Image = CType(resources.GetObject("btnGuardar.Image"), System.Drawing.Image)
        Me.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGuardar.Location = New System.Drawing.Point(299, 230)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(85, 35)
        Me.btnGuardar.TabIndex = 10
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'txtDireccion
        '
        Me.txtDireccion.Location = New System.Drawing.Point(143, 185)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(332, 20)
        Me.txtDireccion.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(83, 188)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(52, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Dirección"
        '
        'btnCancelar
        '
        Me.btnCancelar.BackColor = System.Drawing.SystemColors.Control
        Me.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelar.Image = CType(resources.GetObject("btnCancelar.Image"), System.Drawing.Image)
        Me.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancelar.Location = New System.Drawing.Point(390, 230)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(85, 35)
        Me.btnCancelar.TabIndex = 13
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'FormModelEmpleado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(534, 290)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtDireccion)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.dateFechaIngreso)
        Me.Controls.Add(Me.txtSalarioBase)
        Me.Controls.Add(Me.txtNumeroIdentificacion)
        Me.Controls.Add(Me.cboTipoIdentificacion)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtNombreCompleto)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FormModelEmpleado"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Nuevo Empleado"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtNombreCompleto As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents cboTipoIdentificacion As ComboBox
    Friend WithEvents txtNumeroIdentificacion As TextBox
    Friend WithEvents txtSalarioBase As TextBox
    Friend WithEvents dateFechaIngreso As DateTimePicker
    Friend WithEvents btnGuardar As Button
    Friend WithEvents txtDireccion As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents btnCancelar As Button
End Class
