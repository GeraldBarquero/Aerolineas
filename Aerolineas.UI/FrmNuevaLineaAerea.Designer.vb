<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmNuevaLineaAerea
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
        Me.Bnt_Add = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Txt_NombreLineaAerea = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Bnt_Add
        '
        Me.Bnt_Add.Location = New System.Drawing.Point(50, 107)
        Me.Bnt_Add.Name = "Bnt_Add"
        Me.Bnt_Add.Size = New System.Drawing.Size(75, 23)
        Me.Bnt_Add.TabIndex = 0
        Me.Bnt_Add.Text = "Aceptar"
        Me.Bnt_Add.UseVisualStyleBackColor = True
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
        'FrmNuevaLineaAerea
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 199)
        Me.Controls.Add(Me.Txt_NombreLineaAerea)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Bnt_Add)
        Me.Name = "FrmNuevaLineaAerea"
        Me.Text = "FrmNuevaLineaAerea"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Bnt_Add As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Txt_NombreLineaAerea As System.Windows.Forms.TextBox
End Class
