<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPanel
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormPanel))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnFormVacaciones = New System.Windows.Forms.Button()
        Me.btnFormEmpleado = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnFormVacaciones)
        Me.GroupBox1.Controls.Add(Me.btnFormEmpleado)
        Me.GroupBox1.Location = New System.Drawing.Point(41, 42)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(497, 258)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Opciones"
        '
        'btnFormVacaciones
        '
        Me.btnFormVacaciones.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.btnFormVacaciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFormVacaciones.Image = CType(resources.GetObject("btnFormVacaciones.Image"), System.Drawing.Image)
        Me.btnFormVacaciones.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnFormVacaciones.Location = New System.Drawing.Point(275, 104)
        Me.btnFormVacaciones.Name = "btnFormVacaciones"
        Me.btnFormVacaciones.Size = New System.Drawing.Size(150, 50)
        Me.btnFormVacaciones.TabIndex = 1
        Me.btnFormVacaciones.Text = "Administrar Vacaciones"
        Me.btnFormVacaciones.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnFormVacaciones.UseVisualStyleBackColor = True
        '
        'btnFormEmpleado
        '
        Me.btnFormEmpleado.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.btnFormEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFormEmpleado.Image = CType(resources.GetObject("btnFormEmpleado.Image"), System.Drawing.Image)
        Me.btnFormEmpleado.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnFormEmpleado.Location = New System.Drawing.Point(67, 104)
        Me.btnFormEmpleado.Name = "btnFormEmpleado"
        Me.btnFormEmpleado.Size = New System.Drawing.Size(150, 50)
        Me.btnFormEmpleado.TabIndex = 0
        Me.btnFormEmpleado.Text = "Empleados"
        Me.btnFormEmpleado.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnFormEmpleado.UseVisualStyleBackColor = True
        '
        'FormPanel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(605, 358)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FormPanel"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Panel"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnFormVacaciones As Button
    Friend WithEvents btnFormEmpleado As Button
End Class
