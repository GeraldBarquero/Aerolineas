<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMenuPClientes
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Btn_Reportes = New System.Windows.Forms.Button()
        Me.Btn_BuscarVuelo = New System.Windows.Forms.Button()
        Me.Btn_Salir = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(82, 125)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Menú de Clientes"
        '
        'Btn_Reportes
        '
        Me.Btn_Reportes.Location = New System.Drawing.Point(27, 39)
        Me.Btn_Reportes.Name = "Btn_Reportes"
        Me.Btn_Reportes.Size = New System.Drawing.Size(75, 23)
        Me.Btn_Reportes.TabIndex = 2
        Me.Btn_Reportes.Text = "Reportes"
        Me.Btn_Reportes.UseVisualStyleBackColor = True
        '
        'Btn_BuscarVuelo
        '
        Me.Btn_BuscarVuelo.Location = New System.Drawing.Point(170, 39)
        Me.Btn_BuscarVuelo.Name = "Btn_BuscarVuelo"
        Me.Btn_BuscarVuelo.Size = New System.Drawing.Size(102, 23)
        Me.Btn_BuscarVuelo.TabIndex = 3
        Me.Btn_BuscarVuelo.Text = "Buscar Vuelo"
        Me.Btn_BuscarVuelo.UseVisualStyleBackColor = True
        '
        'Btn_Salir
        '
        Me.Btn_Salir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Btn_Salir.Location = New System.Drawing.Point(103, 201)
        Me.Btn_Salir.Name = "Btn_Salir"
        Me.Btn_Salir.Size = New System.Drawing.Size(75, 23)
        Me.Btn_Salir.TabIndex = 4
        Me.Btn_Salir.Text = "Salir"
        Me.Btn_Salir.UseVisualStyleBackColor = True
        '
        'FrmMenuPClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Btn_Salir
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.Btn_Salir)
        Me.Controls.Add(Me.Btn_BuscarVuelo)
        Me.Controls.Add(Me.Btn_Reportes)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmMenuPClientes"
        Me.Text = "FrmMenuClientes"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Btn_Reportes As System.Windows.Forms.Button
    Friend WithEvents Btn_BuscarVuelo As System.Windows.Forms.Button
    Friend WithEvents Btn_Salir As System.Windows.Forms.Button
End Class
