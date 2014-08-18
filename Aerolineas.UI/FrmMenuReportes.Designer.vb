<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMenuReportes
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
        Me.Btn_Aerolineas = New System.Windows.Forms.Button()
        Me.Btn_Destinos = New System.Windows.Forms.Button()
        Me.Btn_Vuelos = New System.Windows.Forms.Button()
        Me.Btn_Usuarios = New System.Windows.Forms.Button()
        Me.Dgv_Reportes = New System.Windows.Forms.DataGridView()
        Me.Btn_Cancelar = New System.Windows.Forms.Button()
        CType(Me.Dgv_Reportes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Btn_Aerolineas
        '
        Me.Btn_Aerolineas.Location = New System.Drawing.Point(13, 19)
        Me.Btn_Aerolineas.Name = "Btn_Aerolineas"
        Me.Btn_Aerolineas.Size = New System.Drawing.Size(75, 23)
        Me.Btn_Aerolineas.TabIndex = 0
        Me.Btn_Aerolineas.Text = "Aerolíneas"
        Me.Btn_Aerolineas.UseVisualStyleBackColor = True
        '
        'Btn_Destinos
        '
        Me.Btn_Destinos.Location = New System.Drawing.Point(13, 68)
        Me.Btn_Destinos.Name = "Btn_Destinos"
        Me.Btn_Destinos.Size = New System.Drawing.Size(75, 23)
        Me.Btn_Destinos.TabIndex = 1
        Me.Btn_Destinos.Text = "Destinos"
        Me.Btn_Destinos.UseVisualStyleBackColor = True
        '
        'Btn_Vuelos
        '
        Me.Btn_Vuelos.Location = New System.Drawing.Point(13, 117)
        Me.Btn_Vuelos.Name = "Btn_Vuelos"
        Me.Btn_Vuelos.Size = New System.Drawing.Size(75, 23)
        Me.Btn_Vuelos.TabIndex = 2
        Me.Btn_Vuelos.Text = "Vuelos"
        Me.Btn_Vuelos.UseVisualStyleBackColor = True
        '
        'Btn_Usuarios
        '
        Me.Btn_Usuarios.Location = New System.Drawing.Point(13, 166)
        Me.Btn_Usuarios.Name = "Btn_Usuarios"
        Me.Btn_Usuarios.Size = New System.Drawing.Size(75, 23)
        Me.Btn_Usuarios.TabIndex = 3
        Me.Btn_Usuarios.Text = "Usuarios"
        Me.Btn_Usuarios.UseVisualStyleBackColor = True
        '
        'Dgv_Reportes
        '
        Me.Dgv_Reportes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.Dgv_Reportes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.Dgv_Reportes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgv_Reportes.Dock = System.Windows.Forms.DockStyle.Right
        Me.Dgv_Reportes.Location = New System.Drawing.Point(136, 0)
        Me.Dgv_Reportes.Name = "Dgv_Reportes"
        Me.Dgv_Reportes.Size = New System.Drawing.Size(617, 262)
        Me.Dgv_Reportes.TabIndex = 4
        '
        'Btn_Cancelar
        '
        Me.Btn_Cancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Btn_Cancelar.Location = New System.Drawing.Point(13, 215)
        Me.Btn_Cancelar.Name = "Btn_Cancelar"
        Me.Btn_Cancelar.Size = New System.Drawing.Size(75, 23)
        Me.Btn_Cancelar.TabIndex = 5
        Me.Btn_Cancelar.Text = "Cancelar"
        Me.Btn_Cancelar.UseVisualStyleBackColor = True
        '
        'FrmMenuReportes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Btn_Cancelar
        Me.ClientSize = New System.Drawing.Size(753, 262)
        Me.Controls.Add(Me.Btn_Cancelar)
        Me.Controls.Add(Me.Dgv_Reportes)
        Me.Controls.Add(Me.Btn_Usuarios)
        Me.Controls.Add(Me.Btn_Vuelos)
        Me.Controls.Add(Me.Btn_Destinos)
        Me.Controls.Add(Me.Btn_Aerolineas)
        Me.Name = "FrmMenuReportes"
        Me.Text = "FrmMenuReportes"
        CType(Me.Dgv_Reportes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Btn_Aerolineas As System.Windows.Forms.Button
    Friend WithEvents Btn_Destinos As System.Windows.Forms.Button
    Friend WithEvents Btn_Vuelos As System.Windows.Forms.Button
    Friend WithEvents Btn_Usuarios As System.Windows.Forms.Button
    Friend WithEvents Dgv_Reportes As System.Windows.Forms.DataGridView
    Friend WithEvents Btn_Cancelar As System.Windows.Forms.Button
End Class
