<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormVacacionesDetalle
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormVacacionesDetalle))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.lblNombreEmpleado = New System.Windows.Forms.Label()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.txtDiasTomados = New System.Windows.Forms.TextBox()
        Me.txtDiasGenerados = New System.Windows.Forms.TextBox()
        Me.txtSaldo = New System.Windows.Forms.TextBox()
        Me.dateDiaTomado = New System.Windows.Forms.DateTimePicker()
        Me.lblDiasTomados = New System.Windows.Forms.Label()
        Me.lblVacacionesAcumuladas = New System.Windows.Forms.Label()
        Me.lblSaldo = New System.Windows.Forms.Label()
        Me.btnGenerar = New System.Windows.Forms.Button()
        Me.btnReporte = New System.Windows.Forms.Button()
        Me.dateFechaInicio = New System.Windows.Forms.DateTimePicker()
        Me.dateFechaFinal = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.colId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDiaSolicitado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDelete = New System.Windows.Forms.DataGridViewImageColumn()
        Me.colEmpleadoID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnCancelar = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colId, Me.colDiaSolicitado, Me.colDelete, Me.colEmpleadoID})
        Me.DataGridView1.Location = New System.Drawing.Point(12, 160)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(274, 278)
        Me.DataGridView1.TabIndex = 2
        '
        'lblNombreEmpleado
        '
        Me.lblNombreEmpleado.AutoSize = True
        Me.lblNombreEmpleado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombreEmpleado.Location = New System.Drawing.Point(12, 9)
        Me.lblNombreEmpleado.Name = "lblNombreEmpleado"
        Me.lblNombreEmpleado.Size = New System.Drawing.Size(45, 13)
        Me.lblNombreEmpleado.TabIndex = 3
        Me.lblNombreEmpleado.Text = "Label1"
        '
        'btnAgregar
        '
        Me.btnAgregar.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregar.Image = CType(resources.GetObject("btnAgregar.Image"), System.Drawing.Image)
        Me.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAgregar.Location = New System.Drawing.Point(168, 56)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(100, 35)
        Me.btnAgregar.TabIndex = 5
        Me.btnAgregar.Text = "Agregar Día"
        Me.btnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'txtDiasTomados
        '
        Me.txtDiasTomados.Location = New System.Drawing.Point(192, 42)
        Me.txtDiasTomados.Name = "txtDiasTomados"
        Me.txtDiasTomados.ReadOnly = True
        Me.txtDiasTomados.Size = New System.Drawing.Size(100, 20)
        Me.txtDiasTomados.TabIndex = 6
        Me.txtDiasTomados.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtDiasGenerados
        '
        Me.txtDiasGenerados.Location = New System.Drawing.Point(192, 68)
        Me.txtDiasGenerados.Name = "txtDiasGenerados"
        Me.txtDiasGenerados.ReadOnly = True
        Me.txtDiasGenerados.Size = New System.Drawing.Size(100, 20)
        Me.txtDiasGenerados.TabIndex = 7
        Me.txtDiasGenerados.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtSaldo
        '
        Me.txtSaldo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSaldo.Location = New System.Drawing.Point(192, 94)
        Me.txtSaldo.Name = "txtSaldo"
        Me.txtSaldo.ReadOnly = True
        Me.txtSaldo.Size = New System.Drawing.Size(100, 20)
        Me.txtSaldo.TabIndex = 8
        Me.txtSaldo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'DateTimePicker1
        '
        Me.dateDiaTomado.CustomFormat = "dd/MM/yyy"
        Me.dateDiaTomado.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dateDiaTomado.Location = New System.Drawing.Point(6, 27)
        Me.dateDiaTomado.MaxDate = New Date(2024, 12, 31, 0, 0, 0, 0)
        Me.dateDiaTomado.MinDate = New Date(1993, 1, 1, 0, 0, 0, 0)
        Me.dateDiaTomado.Name = "DateTimePicker1"
        Me.dateDiaTomado.Size = New System.Drawing.Size(156, 20)
        Me.dateDiaTomado.TabIndex = 9
        '
        'lblDiasTomados
        '
        Me.lblDiasTomados.AutoSize = True
        Me.lblDiasTomados.Location = New System.Drawing.Point(106, 45)
        Me.lblDiasTomados.Name = "lblDiasTomados"
        Me.lblDiasTomados.Size = New System.Drawing.Size(77, 13)
        Me.lblDiasTomados.TabIndex = 12
        Me.lblDiasTomados.Text = "Días Tomados"
        '
        'lblVacacionesAcumuladas
        '
        Me.lblVacacionesAcumuladas.AutoSize = True
        Me.lblVacacionesAcumuladas.Location = New System.Drawing.Point(60, 71)
        Me.lblVacacionesAcumuladas.Name = "lblVacacionesAcumuladas"
        Me.lblVacacionesAcumuladas.Size = New System.Drawing.Size(123, 13)
        Me.lblVacacionesAcumuladas.TabIndex = 13
        Me.lblVacacionesAcumuladas.Text = "Vacaciones acumuladas"
        '
        'lblSaldo
        '
        Me.lblSaldo.AutoSize = True
        Me.lblSaldo.Location = New System.Drawing.Point(149, 97)
        Me.lblSaldo.Name = "lblSaldo"
        Me.lblSaldo.Size = New System.Drawing.Size(34, 13)
        Me.lblSaldo.TabIndex = 14
        Me.lblSaldo.Text = "Saldo"
        '
        'btnGenerar
        '
        Me.btnGenerar.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.btnGenerar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGenerar.Image = CType(resources.GetObject("btnGenerar.Image"), System.Drawing.Image)
        Me.btnGenerar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGenerar.Location = New System.Drawing.Point(207, 59)
        Me.btnGenerar.Name = "btnGenerar"
        Me.btnGenerar.Size = New System.Drawing.Size(88, 35)
        Me.btnGenerar.TabIndex = 15
        Me.btnGenerar.Text = "Generar..."
        Me.btnGenerar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnGenerar.UseVisualStyleBackColor = True
        '
        'btnReporte
        '
        Me.btnReporte.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.btnReporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReporte.Image = CType(resources.GetObject("btnReporte.Image"), System.Drawing.Image)
        Me.btnReporte.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnReporte.Location = New System.Drawing.Point(462, 403)
        Me.btnReporte.Name = "btnReporte"
        Me.btnReporte.Size = New System.Drawing.Size(85, 35)
        Me.btnReporte.TabIndex = 16
        Me.btnReporte.Text = "Reporte"
        Me.btnReporte.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnReporte.UseVisualStyleBackColor = True
        '
        'dateFechaInicio
        '
        Me.dateFechaInicio.CustomFormat = "dd/MM/yyy"
        Me.dateFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dateFechaInicio.Location = New System.Drawing.Point(56, 30)
        Me.dateFechaInicio.MaxDate = New Date(2024, 12, 31, 0, 0, 0, 0)
        Me.dateFechaInicio.MinDate = New Date(1993, 1, 1, 0, 0, 0, 0)
        Me.dateFechaInicio.Name = "dateFechaInicio"
        Me.dateFechaInicio.Size = New System.Drawing.Size(103, 20)
        Me.dateFechaInicio.TabIndex = 17
        '
        'dateFechaFinal
        '
        Me.dateFechaFinal.CustomFormat = "dd/MM/yyy"
        Me.dateFechaFinal.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dateFechaFinal.Location = New System.Drawing.Point(192, 30)
        Me.dateFechaFinal.MaxDate = New Date(2024, 12, 31, 0, 0, 0, 0)
        Me.dateFechaFinal.MinDate = New Date(1993, 1, 1, 0, 0, 0, 0)
        Me.dateFechaFinal.Name = "dateFechaFinal"
        Me.dateFechaFinal.Size = New System.Drawing.Size(103, 20)
        Me.dateFechaFinal.TabIndex = 18
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dateDiaTomado)
        Me.GroupBox1.Controls.Add(Me.btnAgregar)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 36)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(274, 100)
        Me.GroupBox1.TabIndex = 19
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Agregar vacaciones tomadas"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.dateFechaInicio)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.dateFechaFinal)
        Me.GroupBox2.Controls.Add(Me.btnGenerar)
        Me.GroupBox2.Location = New System.Drawing.Point(328, 36)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(310, 100)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Generar vacaciones acumuladas"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(165, 33)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(21, 13)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "Fin"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(18, 33)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(32, 13)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "Inicio"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtDiasTomados)
        Me.GroupBox3.Controls.Add(Me.txtDiasGenerados)
        Me.GroupBox3.Controls.Add(Me.txtSaldo)
        Me.GroupBox3.Controls.Add(Me.lblDiasTomados)
        Me.GroupBox3.Controls.Add(Me.lblSaldo)
        Me.GroupBox3.Controls.Add(Me.lblVacacionesAcumuladas)
        Me.GroupBox3.Location = New System.Drawing.Point(328, 160)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(310, 144)
        Me.GroupBox3.TabIndex = 20
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Detalle de vacaciones"
        '
        'PrintDocument1
        '
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'colId
        '
        Me.colId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.colId.DataPropertyName = "Id"
        Me.colId.HeaderText = "Id"
        Me.colId.Name = "colId"
        Me.colId.ReadOnly = True
        Me.colId.Width = 41
        '
        'colDiaSolicitado
        '
        Me.colDiaSolicitado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.colDiaSolicitado.DataPropertyName = "DiaSolicitado"
        DataGridViewCellStyle1.Format = "dd/MM/yyyy"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.colDiaSolicitado.DefaultCellStyle = DataGridViewCellStyle1
        Me.colDiaSolicitado.HeaderText = "Dias Tomados"
        Me.colDiaSolicitado.Name = "colDiaSolicitado"
        Me.colDiaSolicitado.ReadOnly = True
        '
        'colDelete
        '
        Me.colDelete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.colDelete.HeaderText = "Eliminar"
        Me.colDelete.Image = CType(resources.GetObject("colDelete.Image"), System.Drawing.Image)
        Me.colDelete.Name = "colDelete"
        Me.colDelete.ReadOnly = True
        Me.colDelete.Width = 49
        '
        'colEmpleadoID
        '
        Me.colEmpleadoID.DataPropertyName = "EmpleadoId"
        Me.colEmpleadoID.HeaderText = "EmpleadoID"
        Me.colEmpleadoID.Name = "colEmpleadoID"
        Me.colEmpleadoID.ReadOnly = True
        Me.colEmpleadoID.Visible = False
        '
        'btnCancelar
        '
        Me.btnCancelar.BackColor = System.Drawing.SystemColors.Control
        Me.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelar.Image = CType(resources.GetObject("btnCancelar.Image"), System.Drawing.Image)
        Me.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancelar.Location = New System.Drawing.Point(553, 403)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(85, 35)
        Me.btnCancelar.TabIndex = 21
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'FormVacacionesDetalle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(666, 450)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnReporte)
        Me.Controls.Add(Me.lblNombreEmpleado)
        Me.Controls.Add(Me.DataGridView1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FormVacacionesDetalle"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Detalle de Vacaciones"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents lblNombreEmpleado As Label
    Friend WithEvents btnAgregar As Button
    Friend WithEvents txtDiasTomados As TextBox
    Friend WithEvents txtDiasGenerados As TextBox
    Friend WithEvents txtSaldo As TextBox
    Friend WithEvents dateDiaTomado As DateTimePicker
    Friend WithEvents lblDiasTomados As Label
    Friend WithEvents lblVacacionesAcumuladas As Label
    Friend WithEvents lblSaldo As Label
    Friend WithEvents btnGenerar As Button
    Friend WithEvents btnReporte As Button
    Friend WithEvents dateFechaInicio As DateTimePicker
    Friend WithEvents dateFechaFinal As DateTimePicker
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintDialog1 As PrintDialog
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents colId As DataGridViewTextBoxColumn
    Friend WithEvents colDiaSolicitado As DataGridViewTextBoxColumn
    Friend WithEvents colDelete As DataGridViewImageColumn
    Friend WithEvents colEmpleadoID As DataGridViewTextBoxColumn
    Friend WithEvents btnCancelar As Button
End Class
