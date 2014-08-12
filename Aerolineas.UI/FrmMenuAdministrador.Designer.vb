<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMenuAdministrador
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
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripDropDownButton1 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripTextBox1 = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripTextBox2 = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Bnt_PaisAdmin = New System.Windows.Forms.Button()
        Me.Bnt_DestinoAdmin = New System.Windows.Forms.Button()
        Me.Bnt_LineaAereaAdmin = New System.Windows.Forms.Button()
        Me.Bt_Cliente = New System.Windows.Forms.Button()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(149, 107)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Menú de Administración"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripDropDownButton1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(441, 25)
        Me.ToolStrip1.TabIndex = 1
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripDropDownButton1
        '
        Me.ToolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripDropDownButton1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.ToolStripMenuItem2})
        Me.ToolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripDropDownButton1.Name = "ToolStripDropDownButton1"
        Me.ToolStripDropDownButton1.Size = New System.Drawing.Size(107, 22)
        Me.ToolStripDropDownButton1.Text = "Mantenimientos"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripTextBox1, Me.ToolStripTextBox2})
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(116, 22)
        Me.ToolStripMenuItem1.Text = "Clientes"
        '
        'ToolStripTextBox1
        '
        Me.ToolStripTextBox1.Name = "ToolStripTextBox1"
        Me.ToolStripTextBox1.Size = New System.Drawing.Size(100, 23)
        Me.ToolStripTextBox1.Text = "Registro"
        '
        'ToolStripTextBox2
        '
        Me.ToolStripTextBox2.Name = "ToolStripTextBox2"
        Me.ToolStripTextBox2.Size = New System.Drawing.Size(100, 23)
        Me.ToolStripTextBox2.Text = "Lista"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(116, 22)
        Me.ToolStripMenuItem2.Text = "Vuelos"
        '
        'Bnt_PaisAdmin
        '
        Me.Bnt_PaisAdmin.Location = New System.Drawing.Point(326, 180)
        Me.Bnt_PaisAdmin.Name = "Bnt_PaisAdmin"
        Me.Bnt_PaisAdmin.Size = New System.Drawing.Size(75, 23)
        Me.Bnt_PaisAdmin.TabIndex = 4
        Me.Bnt_PaisAdmin.Text = "Pais"
        Me.Bnt_PaisAdmin.UseVisualStyleBackColor = True
        '
        'Bnt_DestinoAdmin
        '
        Me.Bnt_DestinoAdmin.Location = New System.Drawing.Point(49, 180)
        Me.Bnt_DestinoAdmin.Name = "Bnt_DestinoAdmin"
        Me.Bnt_DestinoAdmin.Size = New System.Drawing.Size(75, 23)
        Me.Bnt_DestinoAdmin.TabIndex = 5
        Me.Bnt_DestinoAdmin.Text = "Destinos"
        Me.Bnt_DestinoAdmin.UseVisualStyleBackColor = True
        '
        'Bnt_LineaAereaAdmin
        '
        Me.Bnt_LineaAereaAdmin.Location = New System.Drawing.Point(49, 65)
        Me.Bnt_LineaAereaAdmin.Name = "Bnt_LineaAereaAdmin"
        Me.Bnt_LineaAereaAdmin.Size = New System.Drawing.Size(75, 23)
        Me.Bnt_LineaAereaAdmin.TabIndex = 6
        Me.Bnt_LineaAereaAdmin.Text = "Linea Aerea"
        Me.Bnt_LineaAereaAdmin.UseVisualStyleBackColor = True
        '
        'Bt_Cliente
        '
        Me.Bt_Cliente.Location = New System.Drawing.Point(326, 64)
        Me.Bt_Cliente.Name = "Bt_Cliente"
        Me.Bt_Cliente.Size = New System.Drawing.Size(75, 23)
        Me.Bt_Cliente.TabIndex = 7
        Me.Bt_Cliente.Text = "Cliente"
        Me.Bt_Cliente.UseVisualStyleBackColor = True
        '
        'FrmMenuAdministrador
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(441, 261)
        Me.Controls.Add(Me.Bt_Cliente)
        Me.Controls.Add(Me.Bnt_LineaAereaAdmin)
        Me.Controls.Add(Me.Bnt_DestinoAdmin)
        Me.Controls.Add(Me.Bnt_PaisAdmin)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmMenuAdministrador"
        Me.Text = "FrmMenuAdministrador"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripDropDownButton1 As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripTextBox1 As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripTextBox2 As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Bnt_PaisAdmin As System.Windows.Forms.Button
    Friend WithEvents Bnt_DestinoAdmin As System.Windows.Forms.Button
    Friend WithEvents Bnt_LineaAereaAdmin As System.Windows.Forms.Button
    Friend WithEvents Bt_Cliente As System.Windows.Forms.Button
End Class
