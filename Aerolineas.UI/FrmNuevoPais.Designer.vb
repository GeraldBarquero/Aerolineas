<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmNuevoPais
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
        Me.Dgv_ListaPais = New System.Windows.Forms.DataGridView()
        Me.Lb_Pais = New System.Windows.Forms.Label()
        Me.Txt_Pais = New System.Windows.Forms.TextBox()
        Me.Bt_Aceptar = New System.Windows.Forms.Button()
        Me.BntCancelar = New System.Windows.Forms.Button()
        CType(Me.Dgv_ListaPais, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Dgv_ListaPais
        '
        Me.Dgv_ListaPais.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgv_ListaPais.Location = New System.Drawing.Point(229, 29)
        Me.Dgv_ListaPais.Name = "Dgv_ListaPais"
        Me.Dgv_ListaPais.Size = New System.Drawing.Size(445, 194)
        Me.Dgv_ListaPais.TabIndex = 0
        '
        'Lb_Pais
        '
        Me.Lb_Pais.AutoSize = True
        Me.Lb_Pais.Location = New System.Drawing.Point(12, 60)
        Me.Lb_Pais.Name = "Lb_Pais"
        Me.Lb_Pais.Size = New System.Drawing.Size(47, 13)
        Me.Lb_Pais.TabIndex = 1
        Me.Lb_Pais.Text = "Nombre:"
        '
        'Txt_Pais
        '
        Me.Txt_Pais.Location = New System.Drawing.Point(82, 57)
        Me.Txt_Pais.Name = "Txt_Pais"
        Me.Txt_Pais.Size = New System.Drawing.Size(100, 20)
        Me.Txt_Pais.TabIndex = 2
        '
        'Bt_Aceptar
        '
        Me.Bt_Aceptar.Location = New System.Drawing.Point(26, 106)
        Me.Bt_Aceptar.Name = "Bt_Aceptar"
        Me.Bt_Aceptar.Size = New System.Drawing.Size(75, 23)
        Me.Bt_Aceptar.TabIndex = 3
        Me.Bt_Aceptar.Text = "Insertar"
        Me.Bt_Aceptar.UseVisualStyleBackColor = True
        '
        'BntCancelar
        '
        Me.BntCancelar.Location = New System.Drawing.Point(125, 106)
        Me.BntCancelar.Name = "BntCancelar"
        Me.BntCancelar.Size = New System.Drawing.Size(75, 23)
        Me.BntCancelar.TabIndex = 4
        Me.BntCancelar.Text = "Cancelar "
        Me.BntCancelar.UseVisualStyleBackColor = True
        '
        'FrmNuevoPais
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(695, 262)
        Me.Controls.Add(Me.BntCancelar)
        Me.Controls.Add(Me.Bt_Aceptar)
        Me.Controls.Add(Me.Txt_Pais)
        Me.Controls.Add(Me.Lb_Pais)
        Me.Controls.Add(Me.Dgv_ListaPais)
        Me.Name = "FrmNuevoPais"
        Me.Text = "FrmNuevoPais"
        CType(Me.Dgv_ListaPais, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Dgv_ListaPais As System.Windows.Forms.DataGridView
    Friend WithEvents Lb_Pais As System.Windows.Forms.Label
    Friend WithEvents Txt_Pais As System.Windows.Forms.TextBox
    Friend WithEvents Bt_Aceptar As System.Windows.Forms.Button
    Friend WithEvents BntCancelar As System.Windows.Forms.Button
End Class
