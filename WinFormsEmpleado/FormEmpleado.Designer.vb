<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormEmpleado
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormEmpleado))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.colId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colNombreCompleto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colNumeroIdentificacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colSalarioBase = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDireccion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colFechaIngreso = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colTipoIdentificacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colUpdate = New System.Windows.Forms.DataGridViewImageColumn()
        Me.colDelete = New System.Windows.Forms.DataGridViewImageColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colId, Me.colNombreCompleto, Me.colNumeroIdentificacion, Me.colSalarioBase, Me.colDireccion, Me.colFechaIngreso, Me.colTipoIdentificacion, Me.colUpdate, Me.colDelete})
        Me.DataGridView1.Location = New System.Drawing.Point(12, 53)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(776, 385)
        Me.DataGridView1.TabIndex = 0
        '
        'btnNuevo
        '
        Me.btnNuevo.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNuevo.Image = CType(resources.GetObject("btnNuevo.Image"), System.Drawing.Image)
        Me.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNuevo.Location = New System.Drawing.Point(12, 12)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(124, 35)
        Me.btnNuevo.TabIndex = 1
        Me.btnNuevo.Text = "Nuevo Empleado"
        Me.btnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnNuevo.UseVisualStyleBackColor = False
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
        'colNombreCompleto
        '
        Me.colNombreCompleto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.colNombreCompleto.DataPropertyName = "NombreCompleto"
        Me.colNombreCompleto.HeaderText = "Nombre Completo"
        Me.colNombreCompleto.Name = "colNombreCompleto"
        Me.colNombreCompleto.ReadOnly = True
        Me.colNombreCompleto.Width = 116
        '
        'colNumeroIdentificacion
        '
        Me.colNumeroIdentificacion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.colNumeroIdentificacion.DataPropertyName = "NumeroIdentificacion"
        Me.colNumeroIdentificacion.HeaderText = "Identificación"
        Me.colNumeroIdentificacion.Name = "colNumeroIdentificacion"
        Me.colNumeroIdentificacion.ReadOnly = True
        Me.colNumeroIdentificacion.Width = 95
        '
        'colSalarioBase
        '
        Me.colSalarioBase.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.colSalarioBase.DataPropertyName = "SalarioBase"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle1.Format = "N2"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.colSalarioBase.DefaultCellStyle = DataGridViewCellStyle1
        Me.colSalarioBase.HeaderText = "Salario Base"
        Me.colSalarioBase.Name = "colSalarioBase"
        Me.colSalarioBase.ReadOnly = True
        Me.colSalarioBase.Width = 91
        '
        'colDireccion
        '
        Me.colDireccion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.colDireccion.DataPropertyName = "Direccion"
        Me.colDireccion.HeaderText = "Dirección"
        Me.colDireccion.Name = "colDireccion"
        Me.colDireccion.ReadOnly = True
        Me.colDireccion.Width = 77
        '
        'colFechaIngreso
        '
        Me.colFechaIngreso.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.colFechaIngreso.DataPropertyName = "FechaIngreso"
        DataGridViewCellStyle2.Format = "dd/MM/yyyy"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.colFechaIngreso.DefaultCellStyle = DataGridViewCellStyle2
        Me.colFechaIngreso.HeaderText = "Fecha Ingreso"
        Me.colFechaIngreso.Name = "colFechaIngreso"
        Me.colFechaIngreso.ReadOnly = True
        Me.colFechaIngreso.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.colFechaIngreso.Width = 81
        '
        'colTipoIdentificacion
        '
        Me.colTipoIdentificacion.DataPropertyName = "TipoIdentificacion"
        Me.colTipoIdentificacion.HeaderText = "Tipo Identificacion"
        Me.colTipoIdentificacion.Name = "colTipoIdentificacion"
        Me.colTipoIdentificacion.ReadOnly = True
        Me.colTipoIdentificacion.Visible = False
        '
        'colUpdate
        '
        Me.colUpdate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.colUpdate.HeaderText = "Editar"
        Me.colUpdate.Image = CType(resources.GetObject("colUpdate.Image"), System.Drawing.Image)
        Me.colUpdate.Name = "colUpdate"
        Me.colUpdate.Width = 40
        '
        'colDelete
        '
        Me.colDelete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.colDelete.HeaderText = "Eliminar"
        Me.colDelete.Image = CType(resources.GetObject("colDelete.Image"), System.Drawing.Image)
        Me.colDelete.Name = "colDelete"
        Me.colDelete.Width = 49
        '
        'FormEmpleado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "FormEmpleado"
        Me.Text = "Empleados"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnNuevo As Button
    Friend WithEvents colId As DataGridViewTextBoxColumn
    Friend WithEvents colNombreCompleto As DataGridViewTextBoxColumn
    Friend WithEvents colNumeroIdentificacion As DataGridViewTextBoxColumn
    Friend WithEvents colSalarioBase As DataGridViewTextBoxColumn
    Friend WithEvents colDireccion As DataGridViewTextBoxColumn
    Friend WithEvents colFechaIngreso As DataGridViewTextBoxColumn
    Friend WithEvents colTipoIdentificacion As DataGridViewTextBoxColumn
    Friend WithEvents colUpdate As DataGridViewImageColumn
    Friend WithEvents colDelete As DataGridViewImageColumn
End Class
