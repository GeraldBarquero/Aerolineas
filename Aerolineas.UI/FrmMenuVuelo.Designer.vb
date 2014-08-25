<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMenuVuelo
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
        Me.Lb_NumeroVuelo = New System.Windows.Forms.Label()
        Me.Lb_DestinoLlegada = New System.Windows.Forms.Label()
        Me.Lb_DestinoSalida = New System.Windows.Forms.Label()
        Me.Lb_Aerolinea = New System.Windows.Forms.Label()
        Me.Lb_HoraSalida = New System.Windows.Forms.Label()
        Me.Lb_HoraLlegada = New System.Windows.Forms.Label()
        Me.Lb_Precio = New System.Windows.Forms.Label()
        Me.Lb_CantidadPasajeros = New System.Windows.Forms.Label()
        Me.Txt_NumeroVuelo = New System.Windows.Forms.TextBox()
        Me.Cmb_DestinoLlegada = New System.Windows.Forms.ComboBox()
        Me.Cmb_DestinoSalida = New System.Windows.Forms.ComboBox()
        Me.Cmb_Aerolinea = New System.Windows.Forms.ComboBox()
        Me.Txt_Precio = New System.Windows.Forms.MaskedTextBox()
        Me.Nud_CantidadPasajeros = New System.Windows.Forms.NumericUpDown()
        Me.Btn_Aceptar = New System.Windows.Forms.Button()
        Me.Btn_Cancelar = New System.Windows.Forms.Button()
        Me.Dgv_Vuelos = New System.Windows.Forms.DataGridView()
        Me.Dtp_HoraSalida = New System.Windows.Forms.DateTimePicker()
        Me.Dtp_HoraLlegada = New System.Windows.Forms.DateTimePicker()
        Me.Dtp_FechaVuelo = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Bnt_EliminarVuelo = New System.Windows.Forms.Button()
        Me.Bnt_ModificarVuelo = New System.Windows.Forms.Button()
        Me.Bnt_Consultar = New System.Windows.Forms.Button()
        Me.Lb_Confirmacion = New System.Windows.Forms.Label()
        CType(Me.Nud_CantidadPasajeros, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dgv_Vuelos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Lb_NumeroVuelo
        '
        Me.Lb_NumeroVuelo.AutoSize = True
        Me.Lb_NumeroVuelo.Location = New System.Drawing.Point(28, 69)
        Me.Lb_NumeroVuelo.Name = "Lb_NumeroVuelo"
        Me.Lb_NumeroVuelo.Size = New System.Drawing.Size(92, 13)
        Me.Lb_NumeroVuelo.TabIndex = 0
        Me.Lb_NumeroVuelo.Text = "Número de Vuelo:"
        '
        'Lb_DestinoLlegada
        '
        Me.Lb_DestinoLlegada.AutoSize = True
        Me.Lb_DestinoLlegada.Location = New System.Drawing.Point(28, 143)
        Me.Lb_DestinoLlegada.Name = "Lb_DestinoLlegada"
        Me.Lb_DestinoLlegada.Size = New System.Drawing.Size(102, 13)
        Me.Lb_DestinoLlegada.TabIndex = 1
        Me.Lb_DestinoLlegada.Text = "Destino de Llegada:"
        '
        'Lb_DestinoSalida
        '
        Me.Lb_DestinoSalida.AutoSize = True
        Me.Lb_DestinoSalida.Location = New System.Drawing.Point(28, 180)
        Me.Lb_DestinoSalida.Name = "Lb_DestinoSalida"
        Me.Lb_DestinoSalida.Size = New System.Drawing.Size(93, 13)
        Me.Lb_DestinoSalida.TabIndex = 2
        Me.Lb_DestinoSalida.Text = "Destino de Salida:"
        '
        'Lb_Aerolinea
        '
        Me.Lb_Aerolinea.AutoSize = True
        Me.Lb_Aerolinea.Location = New System.Drawing.Point(28, 106)
        Me.Lb_Aerolinea.Name = "Lb_Aerolinea"
        Me.Lb_Aerolinea.Size = New System.Drawing.Size(54, 13)
        Me.Lb_Aerolinea.TabIndex = 3
        Me.Lb_Aerolinea.Text = "Aerolinea:"
        '
        'Lb_HoraSalida
        '
        Me.Lb_HoraSalida.AutoSize = True
        Me.Lb_HoraSalida.Location = New System.Drawing.Point(28, 244)
        Me.Lb_HoraSalida.Name = "Lb_HoraSalida"
        Me.Lb_HoraSalida.Size = New System.Drawing.Size(80, 13)
        Me.Lb_HoraSalida.TabIndex = 4
        Me.Lb_HoraSalida.Text = "Hora de Salida:"
        '
        'Lb_HoraLlegada
        '
        Me.Lb_HoraLlegada.AutoSize = True
        Me.Lb_HoraLlegada.Location = New System.Drawing.Point(28, 281)
        Me.Lb_HoraLlegada.Name = "Lb_HoraLlegada"
        Me.Lb_HoraLlegada.Size = New System.Drawing.Size(89, 13)
        Me.Lb_HoraLlegada.TabIndex = 5
        Me.Lb_HoraLlegada.Text = "Hora de Llegada:"
        '
        'Lb_Precio
        '
        Me.Lb_Precio.AutoSize = True
        Me.Lb_Precio.Location = New System.Drawing.Point(28, 318)
        Me.Lb_Precio.Name = "Lb_Precio"
        Me.Lb_Precio.Size = New System.Drawing.Size(40, 13)
        Me.Lb_Precio.TabIndex = 6
        Me.Lb_Precio.Text = "Precio:"
        '
        'Lb_CantidadPasajeros
        '
        Me.Lb_CantidadPasajeros.AutoSize = True
        Me.Lb_CantidadPasajeros.Location = New System.Drawing.Point(28, 355)
        Me.Lb_CantidadPasajeros.Name = "Lb_CantidadPasajeros"
        Me.Lb_CantidadPasajeros.Size = New System.Drawing.Size(101, 13)
        Me.Lb_CantidadPasajeros.TabIndex = 7
        Me.Lb_CantidadPasajeros.Text = "Cantidad Pasajeros:"
        '
        'Txt_NumeroVuelo
        '
        Me.Txt_NumeroVuelo.Location = New System.Drawing.Point(130, 66)
        Me.Txt_NumeroVuelo.Name = "Txt_NumeroVuelo"
        Me.Txt_NumeroVuelo.Size = New System.Drawing.Size(121, 20)
        Me.Txt_NumeroVuelo.TabIndex = 9
        '
        'Cmb_DestinoLlegada
        '
        Me.Cmb_DestinoLlegada.FormattingEnabled = True
        Me.Cmb_DestinoLlegada.Location = New System.Drawing.Point(130, 140)
        Me.Cmb_DestinoLlegada.Name = "Cmb_DestinoLlegada"
        Me.Cmb_DestinoLlegada.Size = New System.Drawing.Size(121, 21)
        Me.Cmb_DestinoLlegada.TabIndex = 10
        '
        'Cmb_DestinoSalida
        '
        Me.Cmb_DestinoSalida.FormattingEnabled = True
        Me.Cmb_DestinoSalida.Location = New System.Drawing.Point(130, 177)
        Me.Cmb_DestinoSalida.Name = "Cmb_DestinoSalida"
        Me.Cmb_DestinoSalida.Size = New System.Drawing.Size(121, 21)
        Me.Cmb_DestinoSalida.TabIndex = 11
        '
        'Cmb_Aerolinea
        '
        Me.Cmb_Aerolinea.FormattingEnabled = True
        Me.Cmb_Aerolinea.Location = New System.Drawing.Point(130, 103)
        Me.Cmb_Aerolinea.Name = "Cmb_Aerolinea"
        Me.Cmb_Aerolinea.Size = New System.Drawing.Size(121, 21)
        Me.Cmb_Aerolinea.TabIndex = 12
        '
        'Txt_Precio
        '
        Me.Txt_Precio.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals
        Me.Txt_Precio.Location = New System.Drawing.Point(130, 315)
        Me.Txt_Precio.Mask = "$0000"
        Me.Txt_Precio.Name = "Txt_Precio"
        Me.Txt_Precio.Size = New System.Drawing.Size(121, 20)
        Me.Txt_Precio.TabIndex = 15
        Me.Txt_Precio.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals
        '
        'Nud_CantidadPasajeros
        '
        Me.Nud_CantidadPasajeros.Location = New System.Drawing.Point(130, 353)
        Me.Nud_CantidadPasajeros.Maximum = New Decimal(New Integer() {150, 0, 0, 0})
        Me.Nud_CantidadPasajeros.Name = "Nud_CantidadPasajeros"
        Me.Nud_CantidadPasajeros.Size = New System.Drawing.Size(121, 20)
        Me.Nud_CantidadPasajeros.TabIndex = 16
        Me.Nud_CantidadPasajeros.Value = New Decimal(New Integer() {100, 0, 0, 0})
        '
        'Btn_Aceptar
        '
        Me.Btn_Aceptar.Location = New System.Drawing.Point(44, 401)
        Me.Btn_Aceptar.Name = "Btn_Aceptar"
        Me.Btn_Aceptar.Size = New System.Drawing.Size(75, 23)
        Me.Btn_Aceptar.TabIndex = 17
        Me.Btn_Aceptar.Text = "Insertar"
        Me.Btn_Aceptar.UseVisualStyleBackColor = True
        '
        'Btn_Cancelar
        '
        Me.Btn_Cancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Btn_Cancelar.Location = New System.Drawing.Point(155, 401)
        Me.Btn_Cancelar.Name = "Btn_Cancelar"
        Me.Btn_Cancelar.Size = New System.Drawing.Size(75, 23)
        Me.Btn_Cancelar.TabIndex = 18
        Me.Btn_Cancelar.Text = "Cancelar"
        Me.Btn_Cancelar.UseVisualStyleBackColor = True
        '
        'Dgv_Vuelos
        '
        Me.Dgv_Vuelos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.Dgv_Vuelos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.Dgv_Vuelos.BackgroundColor = System.Drawing.SystemColors.Control
        Me.Dgv_Vuelos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Dgv_Vuelos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgv_Vuelos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Dgv_Vuelos.Dock = System.Windows.Forms.DockStyle.Right
        Me.Dgv_Vuelos.GridColor = System.Drawing.SystemColors.Control
        Me.Dgv_Vuelos.Location = New System.Drawing.Point(314, 0)
        Me.Dgv_Vuelos.Name = "Dgv_Vuelos"
        Me.Dgv_Vuelos.Size = New System.Drawing.Size(560, 510)
        Me.Dgv_Vuelos.TabIndex = 19
        '
        'Dtp_HoraSalida
        '
        Me.Dtp_HoraSalida.CustomFormat = "hh:mm tt"
        Me.Dtp_HoraSalida.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.Dtp_HoraSalida.Location = New System.Drawing.Point(130, 238)
        Me.Dtp_HoraSalida.MaxDate = New Date(2015, 1, 1, 0, 0, 0, 0)
        Me.Dtp_HoraSalida.Name = "Dtp_HoraSalida"
        Me.Dtp_HoraSalida.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Dtp_HoraSalida.ShowUpDown = True
        Me.Dtp_HoraSalida.Size = New System.Drawing.Size(121, 20)
        Me.Dtp_HoraSalida.TabIndex = 22
        Me.Dtp_HoraSalida.Value = New Date(2014, 8, 13, 0, 0, 0, 0)
        '
        'Dtp_HoraLlegada
        '
        Me.Dtp_HoraLlegada.CustomFormat = "hh:mm tt"
        Me.Dtp_HoraLlegada.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.Dtp_HoraLlegada.Location = New System.Drawing.Point(130, 275)
        Me.Dtp_HoraLlegada.MaxDate = New Date(2015, 1, 1, 0, 0, 0, 0)
        Me.Dtp_HoraLlegada.Name = "Dtp_HoraLlegada"
        Me.Dtp_HoraLlegada.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Dtp_HoraLlegada.ShowUpDown = True
        Me.Dtp_HoraLlegada.Size = New System.Drawing.Size(121, 20)
        Me.Dtp_HoraLlegada.TabIndex = 23
        Me.Dtp_HoraLlegada.Value = New Date(2014, 8, 13, 0, 0, 0, 0)
        '
        'Dtp_FechaVuelo
        '
        Me.Dtp_FechaVuelo.CustomFormat = ""
        Me.Dtp_FechaVuelo.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Dtp_FechaVuelo.Location = New System.Drawing.Point(130, 204)
        Me.Dtp_FechaVuelo.MaxDate = New Date(2015, 1, 1, 0, 0, 0, 0)
        Me.Dtp_FechaVuelo.Name = "Dtp_FechaVuelo"
        Me.Dtp_FechaVuelo.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Dtp_FechaVuelo.Size = New System.Drawing.Size(121, 20)
        Me.Dtp_FechaVuelo.TabIndex = 25
        Me.Dtp_FechaVuelo.Value = New Date(2014, 8, 13, 0, 0, 0, 0)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(28, 210)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 13)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Hora de Salida:"
        '
        'Bnt_EliminarVuelo
        '
        Me.Bnt_EliminarVuelo.Location = New System.Drawing.Point(7, 458)
        Me.Bnt_EliminarVuelo.Name = "Bnt_EliminarVuelo"
        Me.Bnt_EliminarVuelo.Size = New System.Drawing.Size(75, 23)
        Me.Bnt_EliminarVuelo.TabIndex = 26
        Me.Bnt_EliminarVuelo.Text = "Eliminar"
        Me.Bnt_EliminarVuelo.UseVisualStyleBackColor = True
        '
        'Bnt_ModificarVuelo
        '
        Me.Bnt_ModificarVuelo.Location = New System.Drawing.Point(236, 458)
        Me.Bnt_ModificarVuelo.Name = "Bnt_ModificarVuelo"
        Me.Bnt_ModificarVuelo.Size = New System.Drawing.Size(75, 23)
        Me.Bnt_ModificarVuelo.TabIndex = 27
        Me.Bnt_ModificarVuelo.Text = "Modificar"
        Me.Bnt_ModificarVuelo.UseVisualStyleBackColor = True
        '
        'Bnt_Consultar
        '
        Me.Bnt_Consultar.Location = New System.Drawing.Point(115, 458)
        Me.Bnt_Consultar.Name = "Bnt_Consultar"
        Me.Bnt_Consultar.Size = New System.Drawing.Size(75, 23)
        Me.Bnt_Consultar.TabIndex = 28
        Me.Bnt_Consultar.Text = "Consultar"
        Me.Bnt_Consultar.UseVisualStyleBackColor = True
        '
        'Lb_Confirmacion
        '
        Me.Lb_Confirmacion.AutoSize = True
        Me.Lb_Confirmacion.Location = New System.Drawing.Point(12, 20)
        Me.Lb_Confirmacion.Name = "Lb_Confirmacion"
        Me.Lb_Confirmacion.Size = New System.Drawing.Size(0, 13)
        Me.Lb_Confirmacion.TabIndex = 29
        '
        'FrmMenuVuelo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.CancelButton = Me.Btn_Cancelar
        Me.ClientSize = New System.Drawing.Size(874, 510)
        Me.Controls.Add(Me.Lb_Confirmacion)
        Me.Controls.Add(Me.Bnt_Consultar)
        Me.Controls.Add(Me.Bnt_ModificarVuelo)
        Me.Controls.Add(Me.Bnt_EliminarVuelo)
        Me.Controls.Add(Me.Dtp_FechaVuelo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Dtp_HoraLlegada)
        Me.Controls.Add(Me.Dtp_HoraSalida)
        Me.Controls.Add(Me.Dgv_Vuelos)
        Me.Controls.Add(Me.Btn_Cancelar)
        Me.Controls.Add(Me.Btn_Aceptar)
        Me.Controls.Add(Me.Nud_CantidadPasajeros)
        Me.Controls.Add(Me.Txt_Precio)
        Me.Controls.Add(Me.Cmb_Aerolinea)
        Me.Controls.Add(Me.Cmb_DestinoSalida)
        Me.Controls.Add(Me.Cmb_DestinoLlegada)
        Me.Controls.Add(Me.Txt_NumeroVuelo)
        Me.Controls.Add(Me.Lb_CantidadPasajeros)
        Me.Controls.Add(Me.Lb_Precio)
        Me.Controls.Add(Me.Lb_HoraLlegada)
        Me.Controls.Add(Me.Lb_HoraSalida)
        Me.Controls.Add(Me.Lb_Aerolinea)
        Me.Controls.Add(Me.Lb_DestinoSalida)
        Me.Controls.Add(Me.Lb_DestinoLlegada)
        Me.Controls.Add(Me.Lb_NumeroVuelo)
        Me.HelpButton = True
        Me.Name = "FrmMenuVuelo"
        Me.Text = "FrmNuevoVuelo"
        CType(Me.Nud_CantidadPasajeros, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dgv_Vuelos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Lb_NumeroVuelo As System.Windows.Forms.Label
    Friend WithEvents Lb_DestinoLlegada As System.Windows.Forms.Label
    Friend WithEvents Lb_DestinoSalida As System.Windows.Forms.Label
    Friend WithEvents Lb_Aerolinea As System.Windows.Forms.Label
    Friend WithEvents Lb_HoraSalida As System.Windows.Forms.Label
    Friend WithEvents Lb_HoraLlegada As System.Windows.Forms.Label
    Friend WithEvents Lb_Precio As System.Windows.Forms.Label
    Friend WithEvents Lb_CantidadPasajeros As System.Windows.Forms.Label
    Friend WithEvents Txt_NumeroVuelo As System.Windows.Forms.TextBox
    Friend WithEvents Cmb_DestinoLlegada As System.Windows.Forms.ComboBox
    Friend WithEvents Cmb_DestinoSalida As System.Windows.Forms.ComboBox
    Friend WithEvents Cmb_Aerolinea As System.Windows.Forms.ComboBox
    Friend WithEvents Txt_Precio As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Nud_CantidadPasajeros As System.Windows.Forms.NumericUpDown
    Friend WithEvents Btn_Aceptar As System.Windows.Forms.Button
    Friend WithEvents Btn_Cancelar As System.Windows.Forms.Button
    Friend WithEvents Dgv_Vuelos As System.Windows.Forms.DataGridView
    Friend WithEvents Dtp_HoraSalida As System.Windows.Forms.DateTimePicker
    Friend WithEvents Dtp_HoraLlegada As System.Windows.Forms.DateTimePicker
    Friend WithEvents Dtp_FechaVuelo As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Bnt_EliminarVuelo As System.Windows.Forms.Button
    Friend WithEvents Bnt_ModificarVuelo As System.Windows.Forms.Button
    Friend WithEvents Bnt_Consultar As System.Windows.Forms.Button
    Friend WithEvents Lb_Confirmacion As System.Windows.Forms.Label
End Class
