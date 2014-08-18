<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMenuLineaAerea
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Bnt_Acceptar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Txt_NombreLineaAerea = New System.Windows.Forms.TextBox()
        Me.Dgv_ListaLineasAereas = New System.Windows.Forms.DataGridView()
        Me.Lb_Destinos = New System.Windows.Forms.Label()
        Me.Bnt_Cancelar = New System.Windows.Forms.Button()
        Me.LsBx_destinos = New System.Windows.Forms.ListBox()
        Me.Bnt_EliminarLineaAerea = New System.Windows.Forms.Button()
        Me.Bnt_ConsultarLineaAerea = New System.Windows.Forms.Button()
        Me.Bnt_ModificarLineaAerea = New System.Windows.Forms.Button()
        CType(Me.Dgv_ListaLineasAereas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Bnt_Acceptar
        '
        Me.Bnt_Acceptar.Location = New System.Drawing.Point(55, 199)
        Me.Bnt_Acceptar.Name = "Bnt_Acceptar"
        Me.Bnt_Acceptar.Size = New System.Drawing.Size(75, 23)
        Me.Bnt_Acceptar.TabIndex = 0
        Me.Bnt_Acceptar.Text = "Insertar"
        Me.Bnt_Acceptar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Linea Aerea:"
        '
        'Txt_NombreLineaAerea
        '
        Me.Txt_NombreLineaAerea.Location = New System.Drawing.Point(102, 42)
        Me.Txt_NombreLineaAerea.Name = "Txt_NombreLineaAerea"
        Me.Txt_NombreLineaAerea.Size = New System.Drawing.Size(170, 20)
        Me.Txt_NombreLineaAerea.TabIndex = 2
        '
        'Dgv_ListaLineasAereas
        '
        Me.Dgv_ListaLineasAereas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgv_ListaLineasAereas.Dock = System.Windows.Forms.DockStyle.Right
        Me.Dgv_ListaLineasAereas.Location = New System.Drawing.Point(308, 0)
        Me.Dgv_ListaLineasAereas.Name = "Dgv_ListaLineasAereas"
        Me.Dgv_ListaLineasAereas.Size = New System.Drawing.Size(388, 314)
        Me.Dgv_ListaLineasAereas.TabIndex = 3
        '
        'Lb_Destinos
        '
        Me.Lb_Destinos.AutoSize = True
        Me.Lb_Destinos.Location = New System.Drawing.Point(15, 83)
        Me.Lb_Destinos.Name = "Lb_Destinos"
        Me.Lb_Destinos.Size = New System.Drawing.Size(51, 13)
        Me.Lb_Destinos.TabIndex = 5
        Me.Lb_Destinos.Text = "Destinos:"
        '
        'Bnt_Cancelar
        '
        Me.Bnt_Cancelar.Location = New System.Drawing.Point(197, 199)
        Me.Bnt_Cancelar.Name = "Bnt_Cancelar"
        Me.Bnt_Cancelar.Size = New System.Drawing.Size(75, 23)
        Me.Bnt_Cancelar.TabIndex = 6
        Me.Bnt_Cancelar.Text = "Cancelar "
        Me.Bnt_Cancelar.UseVisualStyleBackColor = True
        '
        'LsBx_destinos
        '
        Me.LsBx_destinos.FormattingEnabled = True
        Me.LsBx_destinos.Location = New System.Drawing.Point(102, 83)
        Me.LsBx_destinos.Name = "LsBx_destinos"
        Me.LsBx_destinos.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.LsBx_destinos.Size = New System.Drawing.Size(170, 95)
        Me.LsBx_destinos.Sorted = True
        Me.LsBx_destinos.TabIndex = 8
        '
        'Bnt_EliminarLineaAerea
        '
        Me.Bnt_EliminarLineaAerea.Location = New System.Drawing.Point(55, 238)
        Me.Bnt_EliminarLineaAerea.Name = "Bnt_EliminarLineaAerea"
        Me.Bnt_EliminarLineaAerea.Size = New System.Drawing.Size(75, 23)
        Me.Bnt_EliminarLineaAerea.TabIndex = 9
        Me.Bnt_EliminarLineaAerea.Text = "Eliminar"
        Me.Bnt_EliminarLineaAerea.UseVisualStyleBackColor = True
        '
        'Bnt_ConsultarLineaAerea
        '
        Me.Bnt_ConsultarLineaAerea.Location = New System.Drawing.Point(197, 238)
        Me.Bnt_ConsultarLineaAerea.Name = "Bnt_ConsultarLineaAerea"
        Me.Bnt_ConsultarLineaAerea.Size = New System.Drawing.Size(75, 23)
        Me.Bnt_ConsultarLineaAerea.TabIndex = 10
        Me.Bnt_ConsultarLineaAerea.Text = "Consultar"
        Me.Bnt_ConsultarLineaAerea.UseVisualStyleBackColor = True
        '
        'Bnt_ModificarLineaAerea
        '
        Me.Bnt_ModificarLineaAerea.Location = New System.Drawing.Point(130, 280)
        Me.Bnt_ModificarLineaAerea.Name = "Bnt_ModificarLineaAerea"
        Me.Bnt_ModificarLineaAerea.Size = New System.Drawing.Size(75, 23)
        Me.Bnt_ModificarLineaAerea.TabIndex = 11
        Me.Bnt_ModificarLineaAerea.Text = "Modificar"
        Me.Bnt_ModificarLineaAerea.UseVisualStyleBackColor = True
        '
        'FrmMenuLineaAerea
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(696, 314)
        Me.Controls.Add(Me.Bnt_ModificarLineaAerea)
        Me.Controls.Add(Me.Bnt_ConsultarLineaAerea)
        Me.Controls.Add(Me.Bnt_EliminarLineaAerea)
        Me.Controls.Add(Me.LsBx_destinos)
        Me.Controls.Add(Me.Bnt_Cancelar)
        Me.Controls.Add(Me.Lb_Destinos)
        Me.Controls.Add(Me.Dgv_ListaLineasAereas)
        Me.Controls.Add(Me.Txt_NombreLineaAerea)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Bnt_Acceptar)
        Me.Name = "FrmMenuLineaAerea"
        Me.Text = "FrmNuevaLineaAerea"
        CType(Me.Dgv_ListaLineasAereas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Bnt_Acceptar As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Txt_NombreLineaAerea As System.Windows.Forms.TextBox
    Friend WithEvents Dgv_ListaLineasAereas As System.Windows.Forms.DataGridView
    Friend WithEvents Lb_Destinos As System.Windows.Forms.Label
    Friend WithEvents Bnt_Cancelar As System.Windows.Forms.Button
    Friend WithEvents LsBx_destinos As System.Windows.Forms.ListBox
    Friend WithEvents Bnt_EliminarLineaAerea As System.Windows.Forms.Button
    Friend WithEvents Bnt_ConsultarLineaAerea As System.Windows.Forms.Button
    Friend WithEvents Bnt_ModificarLineaAerea As System.Windows.Forms.Button
End Class
