<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMenuDestino
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
        Me.Lb_NombreDestino = New System.Windows.Forms.Label()
        Me.Txt_NombreDestino = New System.Windows.Forms.TextBox()
        Me.Lb_CodigoDestino = New System.Windows.Forms.Label()
        Me.Txt_CodigoDestino = New System.Windows.Forms.TextBox()
        Me.Dgv_ListaDestinos = New System.Windows.Forms.DataGridView()
        Me.Lb_Pais = New System.Windows.Forms.Label()
        Me.Cmb_Pais = New System.Windows.Forms.ComboBox()
        Me.BntCancelar = New System.Windows.Forms.Button()
        Me.Txt_NombreAeropuerto = New System.Windows.Forms.TextBox()
        Me.Lb_NombreAeropuerto = New System.Windows.Forms.Label()
        Me.Bnt_EliminarDestino = New System.Windows.Forms.Button()
        Me.Bnt_ConsultarDestino = New System.Windows.Forms.Button()
        Me.Bnt_ModificarDestino = New System.Windows.Forms.Button()
        CType(Me.Dgv_ListaDestinos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Bnt_Acceptar
        '
        Me.Bnt_Acceptar.Location = New System.Drawing.Point(40, 217)
        Me.Bnt_Acceptar.Name = "Bnt_Acceptar"
        Me.Bnt_Acceptar.Size = New System.Drawing.Size(75, 23)
        Me.Bnt_Acceptar.TabIndex = 0
        Me.Bnt_Acceptar.Text = "Insertar"
        Me.Bnt_Acceptar.UseVisualStyleBackColor = True
        '
        'Lb_NombreDestino
        '
        Me.Lb_NombreDestino.AutoSize = True
        Me.Lb_NombreDestino.Location = New System.Drawing.Point(29, 73)
        Me.Lb_NombreDestino.Name = "Lb_NombreDestino"
        Me.Lb_NombreDestino.Size = New System.Drawing.Size(86, 13)
        Me.Lb_NombreDestino.TabIndex = 1
        Me.Lb_NombreDestino.Text = "Nombre Destino:"
        '
        'Txt_NombreDestino
        '
        Me.Txt_NombreDestino.Location = New System.Drawing.Point(128, 70)
        Me.Txt_NombreDestino.Name = "Txt_NombreDestino"
        Me.Txt_NombreDestino.Size = New System.Drawing.Size(124, 20)
        Me.Txt_NombreDestino.TabIndex = 2
        '
        'Lb_CodigoDestino
        '
        Me.Lb_CodigoDestino.AutoSize = True
        Me.Lb_CodigoDestino.Location = New System.Drawing.Point(29, 116)
        Me.Lb_CodigoDestino.Name = "Lb_CodigoDestino"
        Me.Lb_CodigoDestino.Size = New System.Drawing.Size(82, 13)
        Me.Lb_CodigoDestino.TabIndex = 3
        Me.Lb_CodigoDestino.Text = "Codigo Destino:"
        '
        'Txt_CodigoDestino
        '
        Me.Txt_CodigoDestino.Location = New System.Drawing.Point(128, 113)
        Me.Txt_CodigoDestino.MaxLength = 3
        Me.Txt_CodigoDestino.Name = "Txt_CodigoDestino"
        Me.Txt_CodigoDestino.Size = New System.Drawing.Size(124, 20)
        Me.Txt_CodigoDestino.TabIndex = 4
        '
        'Dgv_ListaDestinos
        '
        Me.Dgv_ListaDestinos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgv_ListaDestinos.Location = New System.Drawing.Point(275, 26)
        Me.Dgv_ListaDestinos.Name = "Dgv_ListaDestinos"
        Me.Dgv_ListaDestinos.Size = New System.Drawing.Size(434, 187)
        Me.Dgv_ListaDestinos.TabIndex = 5
        '
        'Lb_Pais
        '
        Me.Lb_Pais.AutoSize = True
        Me.Lb_Pais.Location = New System.Drawing.Point(29, 158)
        Me.Lb_Pais.Name = "Lb_Pais"
        Me.Lb_Pais.Size = New System.Drawing.Size(32, 13)
        Me.Lb_Pais.TabIndex = 6
        Me.Lb_Pais.Text = "País:"
        '
        'Cmb_Pais
        '
        Me.Cmb_Pais.FormattingEnabled = True
        Me.Cmb_Pais.Location = New System.Drawing.Point(128, 155)
        Me.Cmb_Pais.Name = "Cmb_Pais"
        Me.Cmb_Pais.Size = New System.Drawing.Size(121, 21)
        Me.Cmb_Pais.TabIndex = 7
        '
        'BntCancelar
        '
        Me.BntCancelar.Location = New System.Drawing.Point(162, 217)
        Me.BntCancelar.Name = "BntCancelar"
        Me.BntCancelar.Size = New System.Drawing.Size(75, 23)
        Me.BntCancelar.TabIndex = 8
        Me.BntCancelar.Text = "Cancelar "
        Me.BntCancelar.UseVisualStyleBackColor = True
        '
        'Txt_NombreAeropuerto
        '
        Me.Txt_NombreAeropuerto.Location = New System.Drawing.Point(128, 33)
        Me.Txt_NombreAeropuerto.Name = "Txt_NombreAeropuerto"
        Me.Txt_NombreAeropuerto.Size = New System.Drawing.Size(124, 20)
        Me.Txt_NombreAeropuerto.TabIndex = 10
        '
        'Lb_NombreAeropuerto
        '
        Me.Lb_NombreAeropuerto.AutoSize = True
        Me.Lb_NombreAeropuerto.Location = New System.Drawing.Point(29, 36)
        Me.Lb_NombreAeropuerto.Name = "Lb_NombreAeropuerto"
        Me.Lb_NombreAeropuerto.Size = New System.Drawing.Size(102, 13)
        Me.Lb_NombreAeropuerto.TabIndex = 9
        Me.Lb_NombreAeropuerto.Text = "Nombre Aeropuerto:"
        '
        'Bnt_EliminarDestino
        '
        Me.Bnt_EliminarDestino.Location = New System.Drawing.Point(40, 275)
        Me.Bnt_EliminarDestino.Name = "Bnt_EliminarDestino"
        Me.Bnt_EliminarDestino.Size = New System.Drawing.Size(75, 23)
        Me.Bnt_EliminarDestino.TabIndex = 11
        Me.Bnt_EliminarDestino.Text = "Eliminar"
        Me.Bnt_EliminarDestino.UseVisualStyleBackColor = True
        '
        'Bnt_ConsultarDestino
        '
        Me.Bnt_ConsultarDestino.Location = New System.Drawing.Point(162, 275)
        Me.Bnt_ConsultarDestino.Name = "Bnt_ConsultarDestino"
        Me.Bnt_ConsultarDestino.Size = New System.Drawing.Size(75, 23)
        Me.Bnt_ConsultarDestino.TabIndex = 12
        Me.Bnt_ConsultarDestino.Text = "Consultar"
        Me.Bnt_ConsultarDestino.UseVisualStyleBackColor = True
        '
        'Bnt_ModificarDestino
        '
        Me.Bnt_ModificarDestino.Location = New System.Drawing.Point(110, 321)
        Me.Bnt_ModificarDestino.Name = "Bnt_ModificarDestino"
        Me.Bnt_ModificarDestino.Size = New System.Drawing.Size(75, 23)
        Me.Bnt_ModificarDestino.TabIndex = 13
        Me.Bnt_ModificarDestino.Text = "Modificar"
        Me.Bnt_ModificarDestino.UseVisualStyleBackColor = True
        '
        'FrmMenuDestino
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(736, 356)
        Me.Controls.Add(Me.Bnt_ModificarDestino)
        Me.Controls.Add(Me.Bnt_ConsultarDestino)
        Me.Controls.Add(Me.Bnt_EliminarDestino)
        Me.Controls.Add(Me.Txt_NombreAeropuerto)
        Me.Controls.Add(Me.Lb_NombreAeropuerto)
        Me.Controls.Add(Me.BntCancelar)
        Me.Controls.Add(Me.Cmb_Pais)
        Me.Controls.Add(Me.Lb_Pais)
        Me.Controls.Add(Me.Dgv_ListaDestinos)
        Me.Controls.Add(Me.Txt_CodigoDestino)
        Me.Controls.Add(Me.Lb_CodigoDestino)
        Me.Controls.Add(Me.Txt_NombreDestino)
        Me.Controls.Add(Me.Lb_NombreDestino)
        Me.Controls.Add(Me.Bnt_Acceptar)
        Me.Name = "FrmMenuDestino"
        Me.Text = "FrmNuevoDestino"
        CType(Me.Dgv_ListaDestinos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Bnt_Acceptar As System.Windows.Forms.Button
    Friend WithEvents Lb_NombreDestino As System.Windows.Forms.Label
    Friend WithEvents Txt_NombreDestino As System.Windows.Forms.TextBox
    Friend WithEvents Lb_CodigoDestino As System.Windows.Forms.Label
    Friend WithEvents Txt_CodigoDestino As System.Windows.Forms.TextBox
    Friend WithEvents Dgv_ListaDestinos As System.Windows.Forms.DataGridView
    Friend WithEvents Lb_Pais As System.Windows.Forms.Label
    Friend WithEvents Cmb_Pais As System.Windows.Forms.ComboBox
    Friend WithEvents BntCancelar As System.Windows.Forms.Button
    Friend WithEvents Txt_NombreAeropuerto As System.Windows.Forms.TextBox
    Friend WithEvents Lb_NombreAeropuerto As System.Windows.Forms.Label
    Friend WithEvents Bnt_EliminarDestino As System.Windows.Forms.Button
    Friend WithEvents Bnt_ConsultarDestino As System.Windows.Forms.Button
    Friend WithEvents Bnt_ModificarDestino As System.Windows.Forms.Button
End Class
