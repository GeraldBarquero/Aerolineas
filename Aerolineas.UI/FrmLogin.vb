﻿Imports Aerolineas.BLL
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
            objUsuario.Username = Txt_Username.Text
            objUsuario.Password = Txt_Password.Text
            resultado = _usuarioBll.ConsultarUsuario(objUsuario)
            If resultado = True Then
                MessageBox.Show("Se ha logueado correctamente ", "Exitoso")
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
End Class
