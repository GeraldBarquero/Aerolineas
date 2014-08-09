Imports Aerolineas.BLL
Imports Aerolineas.Entidades
Imports Aerolineas.Utilitarios
Imports System.Windows.Forms

Public Class FrmLogin
#Region "Variables"
    Private _usuarioBll As New BllUsuario
    Private objUsuario As New OBJETOS.ObjUsuario
    Dim objRespuesta As New OBJETOS.ObjRespuesta

#End Region
    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Try
            Dim resultado As Boolean
            Dim tipoUsuario As String
            Dim frmAdminstracion As New FrmMenuAdministrador
            Dim frmClientes As New FrmMenuClientes
            objUsuario.Username = Txt_Username.Text
            objUsuario.Password = Txt_Password.Text
            resultado = _usuarioBll.ConsultarUsuario(objUsuario)
            If resultado = True Then
                MessageBox.Show("Se ha logueado correctamente ", "Exitoso")
                tipoUsuario = _usuarioBll.TipoUsuario
                If tipoUsuario = "A" Then
                    Me.Hide()
                    frmAdminstracion.ShowDialog()
                ElseIf tipoUsuario = "C" Then
                    Me.Hide()
                    frmClientes.ShowDialog()
                End If
            Else
                MessageBox.Show("Datos incorrectos", "Fallido")
            End If
            'Me.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Dim FormCliente As New FrmNuevoClientes
        Me.Hide()
        FormCliente.ShowDialog()
    End Sub
End Class
