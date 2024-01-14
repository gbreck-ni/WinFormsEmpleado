<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormVacaciones
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormVacaciones))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.colId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colNombreCompleto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colNumeroIdentificacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colSalarioBase = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colFechaIngreso = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colVacaciones = New System.Windows.Forms.DataGridViewImageColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colId, Me.colNombreCompleto, Me.colNumeroIdentificacion, Me.colSalarioBase, Me.colFechaIngreso, Me.colVacaciones})
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DataGridView1.Location = New System.Drawing.Point(0, 65)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(800, 385)
        Me.DataGridView1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(290, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(175, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "ADMINISTRAR VACACIONES"
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
        '
        'colVacaciones
        '
        Me.colVacaciones.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.colVacaciones.HeaderText = "Ver Vacaciones"
        Me.colVacaciones.Image = CType(resources.GetObject("colVacaciones.Image"), System.Drawing.Image)
        Me.colVacaciones.Name = "colVacaciones"
        Me.colVacaciones.ReadOnly = True
        Me.colVacaciones.Width = 88
        '
        'FormVacaciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "FormVacaciones"
        Me.Text = "Administrar Vacaciones"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents colId As DataGridViewTextBoxColumn
    Friend WithEvents colNombreCompleto As DataGridViewTextBoxColumn
    Friend WithEvents colNumeroIdentificacion As DataGridViewTextBoxColumn
    Friend WithEvents colSalarioBase As DataGridViewTextBoxColumn
    Friend WithEvents colFechaIngreso As DataGridViewTextBoxColumn
    Friend WithEvents colVacaciones As DataGridViewImageColumn
End Class
