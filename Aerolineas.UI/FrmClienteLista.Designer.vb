<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmClienteLista
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
        Me.Dgv_ClientesLista = New System.Windows.Forms.DataGridView()
        Me.Bnt_ModificarCliente = New System.Windows.Forms.Button()
        Me.Bnt_NuevoCliente = New System.Windows.Forms.Button()
        CType(Me.Dgv_ClientesLista, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Dgv_ClientesLista
        '
        Me.Dgv_ClientesLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgv_ClientesLista.Location = New System.Drawing.Point(12, 12)
        Me.Dgv_ClientesLista.Name = "Dgv_ClientesLista"
        Me.Dgv_ClientesLista.Size = New System.Drawing.Size(1141, 228)
        Me.Dgv_ClientesLista.TabIndex = 0
        '
        'Bnt_ModificarCliente
        '
        Me.Bnt_ModificarCliente.Location = New System.Drawing.Point(245, 321)
        Me.Bnt_ModificarCliente.Name = "Bnt_ModificarCliente"
        Me.Bnt_ModificarCliente.Size = New System.Drawing.Size(211, 23)
        Me.Bnt_ModificarCliente.TabIndex = 1
        Me.Bnt_ModificarCliente.Text = "Modificar Cliente"
        Me.Bnt_ModificarCliente.UseVisualStyleBackColor = True
        '
        'Bnt_NuevoCliente
        '
        Me.Bnt_NuevoCliente.Location = New System.Drawing.Point(649, 321)
        Me.Bnt_NuevoCliente.Name = "Bnt_NuevoCliente"
        Me.Bnt_NuevoCliente.Size = New System.Drawing.Size(179, 23)
        Me.Bnt_NuevoCliente.TabIndex = 2
        Me.Bnt_NuevoCliente.Text = "Nuevo Cliente"
        Me.Bnt_NuevoCliente.UseVisualStyleBackColor = True
        '
        'FrmClienteLista
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1198, 400)
        Me.Controls.Add(Me.Bnt_NuevoCliente)
        Me.Controls.Add(Me.Bnt_ModificarCliente)
        Me.Controls.Add(Me.Dgv_ClientesLista)
        Me.Name = "FrmClienteLista"
        Me.Text = "FrmClienteLista"
        CType(Me.Dgv_ClientesLista, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Dgv_ClientesLista As System.Windows.Forms.DataGridView
    Friend WithEvents Bnt_ModificarCliente As System.Windows.Forms.Button
    Friend WithEvents Bnt_NuevoCliente As System.Windows.Forms.Button
End Class
