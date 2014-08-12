<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmNuevoClientes
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
        Me.bnt_Add = New System.Windows.Forms.Button()
        Me.Lb_NombreCliente = New System.Windows.Forms.Label()
        Me.Lb_IdentificacionCiente = New System.Windows.Forms.Label()
        Me.Lb_DireccionCliente = New System.Windows.Forms.Label()
        Me.Lb_Edad = New System.Windows.Forms.Label()
        Me.LbTelefonoCasaCliente = New System.Windows.Forms.Label()
        Me.Lb_TelefonoCelularCliente = New System.Windows.Forms.Label()
        Me.Lb_EmailCliente = New System.Windows.Forms.Label()
        Me.Txt_NombreCliente = New System.Windows.Forms.TextBox()
        Me.Txt_EdadCliente = New System.Windows.Forms.TextBox()
        Me.Txt_TelefonoCasaCliente = New System.Windows.Forms.TextBox()
        Me.Txt_TelefonoCelularCliente = New System.Windows.Forms.TextBox()
        Me.Txt_EmailCliente = New System.Windows.Forms.TextBox()
        Me.Txt_IdentificacionCliente = New System.Windows.Forms.TextBox()
        Me.Rtxt_DireccionCliente = New System.Windows.Forms.RichTextBox()
        Me.Lb_PaisResidenciaCliente = New System.Windows.Forms.Label()
        Me.Txt_PaisResidenciaCliente = New System.Windows.Forms.TextBox()
        Me.Lb_PaswordCliente = New System.Windows.Forms.Label()
        Me.Txt_PasswordCliente = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'bnt_Add
        '
        Me.bnt_Add.Location = New System.Drawing.Point(46, 457)
        Me.bnt_Add.Name = "bnt_Add"
        Me.bnt_Add.Size = New System.Drawing.Size(75, 23)
        Me.bnt_Add.TabIndex = 0
        Me.bnt_Add.Text = "Insertar"
        Me.bnt_Add.UseVisualStyleBackColor = True
        '
        'Lb_NombreCliente
        '
        Me.Lb_NombreCliente.AutoSize = True
        Me.Lb_NombreCliente.Location = New System.Drawing.Point(12, 39)
        Me.Lb_NombreCliente.Name = "Lb_NombreCliente"
        Me.Lb_NombreCliente.Size = New System.Drawing.Size(82, 13)
        Me.Lb_NombreCliente.TabIndex = 1
        Me.Lb_NombreCliente.Text = "Nombre Cliente:"
        '
        'Lb_IdentificacionCiente
        '
        Me.Lb_IdentificacionCiente.AutoSize = True
        Me.Lb_IdentificacionCiente.Location = New System.Drawing.Point(12, 82)
        Me.Lb_IdentificacionCiente.Name = "Lb_IdentificacionCiente"
        Me.Lb_IdentificacionCiente.Size = New System.Drawing.Size(70, 13)
        Me.Lb_IdentificacionCiente.TabIndex = 2
        Me.Lb_IdentificacionCiente.Text = "Identificacion"
        '
        'Lb_DireccionCliente
        '
        Me.Lb_DireccionCliente.AutoSize = True
        Me.Lb_DireccionCliente.Location = New System.Drawing.Point(12, 242)
        Me.Lb_DireccionCliente.Name = "Lb_DireccionCliente"
        Me.Lb_DireccionCliente.Size = New System.Drawing.Size(55, 13)
        Me.Lb_DireccionCliente.TabIndex = 5
        Me.Lb_DireccionCliente.Text = "Direccion:"
        '
        'Lb_Edad
        '
        Me.Lb_Edad.AutoSize = True
        Me.Lb_Edad.Location = New System.Drawing.Point(17, 322)
        Me.Lb_Edad.Name = "Lb_Edad"
        Me.Lb_Edad.Size = New System.Drawing.Size(35, 13)
        Me.Lb_Edad.TabIndex = 6
        Me.Lb_Edad.Text = "Edad:"
        '
        'LbTelefonoCasaCliente
        '
        Me.LbTelefonoCasaCliente.AutoSize = True
        Me.LbTelefonoCasaCliente.Location = New System.Drawing.Point(14, 350)
        Me.LbTelefonoCasaCliente.Name = "LbTelefonoCasaCliente"
        Me.LbTelefonoCasaCliente.Size = New System.Drawing.Size(79, 13)
        Me.LbTelefonoCasaCliente.TabIndex = 7
        Me.LbTelefonoCasaCliente.Text = "Telefono Casa:"
        '
        'Lb_TelefonoCelularCliente
        '
        Me.Lb_TelefonoCelularCliente.AutoSize = True
        Me.Lb_TelefonoCelularCliente.Location = New System.Drawing.Point(14, 384)
        Me.Lb_TelefonoCelularCliente.Name = "Lb_TelefonoCelularCliente"
        Me.Lb_TelefonoCelularCliente.Size = New System.Drawing.Size(87, 13)
        Me.Lb_TelefonoCelularCliente.TabIndex = 8
        Me.Lb_TelefonoCelularCliente.Text = "Telefono Celular:"
        '
        'Lb_EmailCliente
        '
        Me.Lb_EmailCliente.AutoSize = True
        Me.Lb_EmailCliente.Location = New System.Drawing.Point(14, 418)
        Me.Lb_EmailCliente.Name = "Lb_EmailCliente"
        Me.Lb_EmailCliente.Size = New System.Drawing.Size(38, 13)
        Me.Lb_EmailCliente.TabIndex = 9
        Me.Lb_EmailCliente.Text = "E-mail:"
        '
        'Txt_NombreCliente
        '
        Me.Txt_NombreCliente.Location = New System.Drawing.Point(118, 36)
        Me.Txt_NombreCliente.Name = "Txt_NombreCliente"
        Me.Txt_NombreCliente.Size = New System.Drawing.Size(300, 20)
        Me.Txt_NombreCliente.TabIndex = 10
        '
        'Txt_EdadCliente
        '
        Me.Txt_EdadCliente.Location = New System.Drawing.Point(118, 315)
        Me.Txt_EdadCliente.Name = "Txt_EdadCliente"
        Me.Txt_EdadCliente.Size = New System.Drawing.Size(51, 20)
        Me.Txt_EdadCliente.TabIndex = 15
        '
        'Txt_TelefonoCasaCliente
        '
        Me.Txt_TelefonoCasaCliente.Location = New System.Drawing.Point(118, 347)
        Me.Txt_TelefonoCasaCliente.Name = "Txt_TelefonoCasaCliente"
        Me.Txt_TelefonoCasaCliente.Size = New System.Drawing.Size(169, 20)
        Me.Txt_TelefonoCasaCliente.TabIndex = 16
        '
        'Txt_TelefonoCelularCliente
        '
        Me.Txt_TelefonoCelularCliente.Location = New System.Drawing.Point(118, 381)
        Me.Txt_TelefonoCelularCliente.Name = "Txt_TelefonoCelularCliente"
        Me.Txt_TelefonoCelularCliente.Size = New System.Drawing.Size(169, 20)
        Me.Txt_TelefonoCelularCliente.TabIndex = 17
        '
        'Txt_EmailCliente
        '
        Me.Txt_EmailCliente.Location = New System.Drawing.Point(118, 418)
        Me.Txt_EmailCliente.Name = "Txt_EmailCliente"
        Me.Txt_EmailCliente.Size = New System.Drawing.Size(302, 20)
        Me.Txt_EmailCliente.TabIndex = 18
        '
        'Txt_IdentificacionCliente
        '
        Me.Txt_IdentificacionCliente.Location = New System.Drawing.Point(118, 75)
        Me.Txt_IdentificacionCliente.Name = "Txt_IdentificacionCliente"
        Me.Txt_IdentificacionCliente.Size = New System.Drawing.Size(167, 20)
        Me.Txt_IdentificacionCliente.TabIndex = 11
        '
        'Rtxt_DireccionCliente
        '
        Me.Rtxt_DireccionCliente.Location = New System.Drawing.Point(118, 200)
        Me.Rtxt_DireccionCliente.Name = "Rtxt_DireccionCliente"
        Me.Rtxt_DireccionCliente.Size = New System.Drawing.Size(300, 96)
        Me.Rtxt_DireccionCliente.TabIndex = 14
        Me.Rtxt_DireccionCliente.Text = ""
        '
        'Lb_PaisResidenciaCliente
        '
        Me.Lb_PaisResidenciaCliente.AutoSize = True
        Me.Lb_PaisResidenciaCliente.Location = New System.Drawing.Point(12, 164)
        Me.Lb_PaisResidenciaCliente.Name = "Lb_PaisResidenciaCliente"
        Me.Lb_PaisResidenciaCliente.Size = New System.Drawing.Size(86, 13)
        Me.Lb_PaisResidenciaCliente.TabIndex = 4
        Me.Lb_PaisResidenciaCliente.Text = "Pais Residencia:"
        '
        'Txt_PaisResidenciaCliente
        '
        Me.Txt_PaisResidenciaCliente.Location = New System.Drawing.Point(118, 161)
        Me.Txt_PaisResidenciaCliente.Name = "Txt_PaisResidenciaCliente"
        Me.Txt_PaisResidenciaCliente.Size = New System.Drawing.Size(169, 20)
        Me.Txt_PaisResidenciaCliente.TabIndex = 13
        '
        'Lb_PaswordCliente
        '
        Me.Lb_PaswordCliente.AutoSize = True
        Me.Lb_PaswordCliente.Location = New System.Drawing.Point(12, 121)
        Me.Lb_PaswordCliente.Name = "Lb_PaswordCliente"
        Me.Lb_PaswordCliente.Size = New System.Drawing.Size(56, 13)
        Me.Lb_PaswordCliente.TabIndex = 3
        Me.Lb_PaswordCliente.Text = "Password:"
        '
        'Txt_PasswordCliente
        '
        Me.Txt_PasswordCliente.Location = New System.Drawing.Point(118, 118)
        Me.Txt_PasswordCliente.Name = "Txt_PasswordCliente"
        Me.Txt_PasswordCliente.Size = New System.Drawing.Size(167, 20)
        Me.Txt_PasswordCliente.TabIndex = 12
        Me.Txt_PasswordCliente.UseSystemPasswordChar = True
        '
        'FrmNuevoClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(459, 492)
        Me.Controls.Add(Me.Txt_PasswordCliente)
        Me.Controls.Add(Me.Lb_PaswordCliente)
        Me.Controls.Add(Me.Txt_PaisResidenciaCliente)
        Me.Controls.Add(Me.Lb_PaisResidenciaCliente)
        Me.Controls.Add(Me.Rtxt_DireccionCliente)
        Me.Controls.Add(Me.Txt_IdentificacionCliente)
        Me.Controls.Add(Me.Txt_EmailCliente)
        Me.Controls.Add(Me.Txt_TelefonoCelularCliente)
        Me.Controls.Add(Me.Txt_TelefonoCasaCliente)
        Me.Controls.Add(Me.Txt_EdadCliente)
        Me.Controls.Add(Me.Txt_NombreCliente)
        Me.Controls.Add(Me.Lb_EmailCliente)
        Me.Controls.Add(Me.Lb_TelefonoCelularCliente)
        Me.Controls.Add(Me.LbTelefonoCasaCliente)
        Me.Controls.Add(Me.Lb_Edad)
        Me.Controls.Add(Me.Lb_DireccionCliente)
        Me.Controls.Add(Me.Lb_IdentificacionCiente)
        Me.Controls.Add(Me.Lb_NombreCliente)
        Me.Controls.Add(Me.bnt_Add)
        Me.Name = "FrmNuevoClientes"
        Me.Text = "FrmClientes"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents bnt_Add As System.Windows.Forms.Button
    Friend WithEvents Lb_NombreCliente As System.Windows.Forms.Label
    Friend WithEvents Lb_IdentificacionCiente As System.Windows.Forms.Label
    Friend WithEvents Lb_DireccionCliente As System.Windows.Forms.Label
    Friend WithEvents Lb_Edad As System.Windows.Forms.Label
    Friend WithEvents LbTelefonoCasaCliente As System.Windows.Forms.Label
    Friend WithEvents Lb_TelefonoCelularCliente As System.Windows.Forms.Label
    Friend WithEvents Lb_EmailCliente As System.Windows.Forms.Label
    Friend WithEvents Txt_NombreCliente As System.Windows.Forms.TextBox
    Friend WithEvents Txt_EdadCliente As System.Windows.Forms.TextBox
    Friend WithEvents Txt_TelefonoCasaCliente As System.Windows.Forms.TextBox
    Friend WithEvents Txt_TelefonoCelularCliente As System.Windows.Forms.TextBox
    Friend WithEvents Txt_EmailCliente As System.Windows.Forms.TextBox
    Friend WithEvents Txt_IdentificacionCliente As System.Windows.Forms.TextBox
    Friend WithEvents Rtxt_DireccionCliente As System.Windows.Forms.RichTextBox
    Friend WithEvents Lb_PaisResidenciaCliente As System.Windows.Forms.Label
    Friend WithEvents Txt_PaisResidenciaCliente As System.Windows.Forms.TextBox
    Friend WithEvents Lb_PaswordCliente As System.Windows.Forms.Label
    Friend WithEvents Txt_PasswordCliente As System.Windows.Forms.TextBox
End Class
