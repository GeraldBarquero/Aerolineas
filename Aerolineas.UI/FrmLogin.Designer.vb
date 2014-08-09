<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
<Global.System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1726")> _
Partial Class FrmLogin
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
    Friend WithEvents Pb_Logo As System.Windows.Forms.PictureBox
    Friend WithEvents Lb_Username As System.Windows.Forms.Label
    Friend WithEvents Lb_Password As System.Windows.Forms.Label
    Friend WithEvents Txt_Username As System.Windows.Forms.TextBox
    Friend WithEvents Txt_Password As System.Windows.Forms.TextBox
    Friend WithEvents OK As System.Windows.Forms.Button
    Friend WithEvents Cancel As System.Windows.Forms.Button

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Pb_Logo = New System.Windows.Forms.PictureBox()
        Me.Lb_Username = New System.Windows.Forms.Label()
        Me.Lb_Password = New System.Windows.Forms.Label()
        Me.Txt_Username = New System.Windows.Forms.TextBox()
        Me.Txt_Password = New System.Windows.Forms.TextBox()
        Me.OK = New System.Windows.Forms.Button()
        Me.Cancel = New System.Windows.Forms.Button()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        CType(Me.Pb_Logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Pb_Logo
        '
        Me.Pb_Logo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Pb_Logo.BackColor = System.Drawing.SystemColors.Control
        Me.Pb_Logo.Image = Global.Aerolineas.UI.My.Resources.Resources.AirportLogo
        Me.Pb_Logo.Location = New System.Drawing.Point(0, 22)
        Me.Pb_Logo.Name = "Pb_Logo"
        Me.Pb_Logo.Size = New System.Drawing.Size(252, 132)
        Me.Pb_Logo.TabIndex = 0
        Me.Pb_Logo.TabStop = False
        '
        'Lb_Username
        '
        Me.Lb_Username.Location = New System.Drawing.Point(256, 24)
        Me.Lb_Username.Name = "Lb_Username"
        Me.Lb_Username.Size = New System.Drawing.Size(220, 23)
        Me.Lb_Username.TabIndex = 0
        Me.Lb_Username.Text = "&Nombre de usuario"
        Me.Lb_Username.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Lb_Password
        '
        Me.Lb_Password.Location = New System.Drawing.Point(256, 80)
        Me.Lb_Password.Name = "Lb_Password"
        Me.Lb_Password.Size = New System.Drawing.Size(220, 23)
        Me.Lb_Password.TabIndex = 2
        Me.Lb_Password.Text = "&Contraseña"
        Me.Lb_Password.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Txt_Username
        '
        Me.Txt_Username.Location = New System.Drawing.Point(258, 44)
        Me.Txt_Username.Name = "Txt_Username"
        Me.Txt_Username.Size = New System.Drawing.Size(220, 20)
        Me.Txt_Username.TabIndex = 1
        '
        'Txt_Password
        '
        Me.Txt_Password.Location = New System.Drawing.Point(258, 100)
        Me.Txt_Password.Name = "Txt_Password"
        Me.Txt_Password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Txt_Password.Size = New System.Drawing.Size(220, 20)
        Me.Txt_Password.TabIndex = 3
        '
        'OK
        '
        Me.OK.Location = New System.Drawing.Point(281, 161)
        Me.OK.Name = "OK"
        Me.OK.Size = New System.Drawing.Size(94, 23)
        Me.OK.TabIndex = 4
        Me.OK.Text = "&Aceptar"
        '
        'Cancel
        '
        Me.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel.Location = New System.Drawing.Point(384, 161)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(94, 23)
        Me.Cancel.TabIndex = 5
        Me.Cancel.Text = "&Cancelar"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(258, 131)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(60, 13)
        Me.LinkLabel1.TabIndex = 6
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Registrarse"
        '
        'FrmLogin
        '
        Me.AcceptButton = Me.OK
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel
        Me.ClientSize = New System.Drawing.Size(514, 191)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.Cancel)
        Me.Controls.Add(Me.OK)
        Me.Controls.Add(Me.Txt_Password)
        Me.Controls.Add(Me.Txt_Username)
        Me.Controls.Add(Me.Lb_Password)
        Me.Controls.Add(Me.Lb_Username)
        Me.Controls.Add(Me.Pb_Logo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmLogin"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Inicio de Sesión"
        CType(Me.Pb_Logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel

End Class
