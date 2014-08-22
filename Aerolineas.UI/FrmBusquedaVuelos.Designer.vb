<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmBusquedaVuelos
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
        Me.Dgv_ConsultarVuelo = New System.Windows.Forms.DataGridView()
        Me.Cmb_DestinoSalida = New System.Windows.Forms.ComboBox()
        Me.Cmb_DestinoLlegada = New System.Windows.Forms.ComboBox()
        Me.Dtp_FechaVuelo = New System.Windows.Forms.DateTimePicker()
        Me.Txt_PrecioMayor = New System.Windows.Forms.MaskedTextBox()
        Me.Txt_PrecioMenor = New System.Windows.Forms.MaskedTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Btn_Consultar = New System.Windows.Forms.Button()
        Me.Btn_Cancelar = New System.Windows.Forms.Button()
        Me.Btn_Limpiar = New System.Windows.Forms.Button()
        Me.Btn_RegistroVueloCliente = New System.Windows.Forms.Button()
        CType(Me.Dgv_ConsultarVuelo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Dgv_ConsultarVuelo
        '
        Me.Dgv_ConsultarVuelo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.Dgv_ConsultarVuelo.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.Dgv_ConsultarVuelo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgv_ConsultarVuelo.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Dgv_ConsultarVuelo.Location = New System.Drawing.Point(0, 136)
        Me.Dgv_ConsultarVuelo.Name = "Dgv_ConsultarVuelo"
        Me.Dgv_ConsultarVuelo.Size = New System.Drawing.Size(849, 119)
        Me.Dgv_ConsultarVuelo.TabIndex = 0
        '
        'Cmb_DestinoSalida
        '
        Me.Cmb_DestinoSalida.FormattingEnabled = True
        Me.Cmb_DestinoSalida.Location = New System.Drawing.Point(121, 6)
        Me.Cmb_DestinoSalida.Name = "Cmb_DestinoSalida"
        Me.Cmb_DestinoSalida.Size = New System.Drawing.Size(121, 21)
        Me.Cmb_DestinoSalida.TabIndex = 1
        '
        'Cmb_DestinoLlegada
        '
        Me.Cmb_DestinoLlegada.FormattingEnabled = True
        Me.Cmb_DestinoLlegada.Location = New System.Drawing.Point(121, 54)
        Me.Cmb_DestinoLlegada.Name = "Cmb_DestinoLlegada"
        Me.Cmb_DestinoLlegada.Size = New System.Drawing.Size(121, 21)
        Me.Cmb_DestinoLlegada.TabIndex = 2
        '
        'Dtp_FechaVuelo
        '
        Me.Dtp_FechaVuelo.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Dtp_FechaVuelo.Location = New System.Drawing.Point(388, 6)
        Me.Dtp_FechaVuelo.MaxDate = New Date(2015, 12, 31, 0, 0, 0, 0)
        Me.Dtp_FechaVuelo.MinDate = New Date(2014, 1, 1, 0, 0, 0, 0)
        Me.Dtp_FechaVuelo.Name = "Dtp_FechaVuelo"
        Me.Dtp_FechaVuelo.Size = New System.Drawing.Size(100, 20)
        Me.Dtp_FechaVuelo.TabIndex = 3
        Me.Dtp_FechaVuelo.Value = New Date(2014, 8, 22, 0, 0, 0, 0)
        '
        'Txt_PrecioMayor
        '
        Me.Txt_PrecioMayor.Location = New System.Drawing.Point(590, 54)
        Me.Txt_PrecioMayor.Name = "Txt_PrecioMayor"
        Me.Txt_PrecioMayor.Size = New System.Drawing.Size(100, 20)
        Me.Txt_PrecioMayor.TabIndex = 4
        '
        'Txt_PrecioMenor
        '
        Me.Txt_PrecioMenor.Location = New System.Drawing.Point(388, 54)
        Me.Txt_PrecioMenor.Name = "Txt_PrecioMenor"
        Me.Txt_PrecioMenor.Size = New System.Drawing.Size(100, 20)
        Me.Txt_PrecioMenor.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Destino de Salida"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Destino de Llegada"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(302, 11)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Fecha del Vuelo"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(302, 60)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Precio Menor"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(515, 57)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(69, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Precio Mayor"
        '
        'Btn_Consultar
        '
        Me.Btn_Consultar.Location = New System.Drawing.Point(147, 102)
        Me.Btn_Consultar.Name = "Btn_Consultar"
        Me.Btn_Consultar.Size = New System.Drawing.Size(75, 23)
        Me.Btn_Consultar.TabIndex = 11
        Me.Btn_Consultar.Text = "Consultar"
        Me.Btn_Consultar.UseVisualStyleBackColor = True
        '
        'Btn_Cancelar
        '
        Me.Btn_Cancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Btn_Cancelar.Location = New System.Drawing.Point(302, 101)
        Me.Btn_Cancelar.Name = "Btn_Cancelar"
        Me.Btn_Cancelar.Size = New System.Drawing.Size(75, 23)
        Me.Btn_Cancelar.TabIndex = 12
        Me.Btn_Cancelar.Text = "Cancelar"
        Me.Btn_Cancelar.UseVisualStyleBackColor = True
        '
        'Btn_Limpiar
        '
        Me.Btn_Limpiar.Location = New System.Drawing.Point(457, 100)
        Me.Btn_Limpiar.Name = "Btn_Limpiar"
        Me.Btn_Limpiar.Size = New System.Drawing.Size(75, 23)
        Me.Btn_Limpiar.TabIndex = 13
        Me.Btn_Limpiar.Text = "Limpiar"
        Me.Btn_Limpiar.UseVisualStyleBackColor = True
        '
        'Btn_RegistroVueloCliente
        '
        Me.Btn_RegistroVueloCliente.Location = New System.Drawing.Point(590, 99)
        Me.Btn_RegistroVueloCliente.Name = "Btn_RegistroVueloCliente"
        Me.Btn_RegistroVueloCliente.Size = New System.Drawing.Size(126, 23)
        Me.Btn_RegistroVueloCliente.TabIndex = 14
        Me.Btn_RegistroVueloCliente.Text = "Registrar en el Vuelo"
        Me.Btn_RegistroVueloCliente.UseVisualStyleBackColor = True
        Me.Btn_RegistroVueloCliente.Visible = False
        '
        'FrmBusquedaVuelos
        '
        Me.AcceptButton = Me.Btn_Consultar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Btn_Cancelar
        Me.ClientSize = New System.Drawing.Size(849, 255)
        Me.Controls.Add(Me.Btn_RegistroVueloCliente)
        Me.Controls.Add(Me.Btn_Limpiar)
        Me.Controls.Add(Me.Btn_Cancelar)
        Me.Controls.Add(Me.Btn_Consultar)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Txt_PrecioMenor)
        Me.Controls.Add(Me.Txt_PrecioMayor)
        Me.Controls.Add(Me.Dtp_FechaVuelo)
        Me.Controls.Add(Me.Cmb_DestinoLlegada)
        Me.Controls.Add(Me.Cmb_DestinoSalida)
        Me.Controls.Add(Me.Dgv_ConsultarVuelo)
        Me.Name = "FrmBusquedaVuelos"
        Me.Text = "FrmBusquedaVuelos"
        CType(Me.Dgv_ConsultarVuelo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Dgv_ConsultarVuelo As System.Windows.Forms.DataGridView
    Friend WithEvents Cmb_DestinoSalida As System.Windows.Forms.ComboBox
    Friend WithEvents Cmb_DestinoLlegada As System.Windows.Forms.ComboBox
    Friend WithEvents Dtp_FechaVuelo As System.Windows.Forms.DateTimePicker
    Friend WithEvents Txt_PrecioMayor As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Txt_PrecioMenor As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Btn_Consultar As System.Windows.Forms.Button
    Friend WithEvents Btn_Cancelar As System.Windows.Forms.Button
    Friend WithEvents Btn_Limpiar As System.Windows.Forms.Button
    Friend WithEvents Btn_RegistroVueloCliente As System.Windows.Forms.Button
End Class
