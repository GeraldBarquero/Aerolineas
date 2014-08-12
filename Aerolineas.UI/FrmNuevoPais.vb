Imports Aerolineas.Entidades
Imports Aerolineas.BLL
Imports Aerolineas.Utilitarios
Imports System.Windows.Forms
Imports System.Data
Public Class FrmNuevoPais

    Private objPais As New OBJETOS.ObjPais
    Private _PaisBll As New BLL.BllPais
    Private objRespuesta As New OBJETOS.ObjRespuesta
    Private _ds As New DataSet

    Sub datosIniciales()
        Try
            Dim objRespuesta As New OBJETOS.ObjRespuesta
            objRespuesta = _PaisBll.Select_Pais_All(objPais)
            _ds = Utilitarios.UTL.Utilitarios.Utilitarios.UnzipDataSet(objRespuesta.ByteResponseObject)
            Dgv_ListaPais.DataSource = _ds.Tables(0)
        Catch ex As Exception
        End Try
    End Sub
    Private Sub FrmPais_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        datosIniciales()
    End Sub

    Private Sub Bt_Aceptar_Click(sender As System.Object, e As System.EventArgs) Handles Bt_Aceptar.Click
        objPais.nombrePais = Txt_Pais.Text
        objRespuesta = _PaisBll.InsertarPais(objPais)
        If objRespuesta.ResponseCode = 1 Then
            MessageBox.Show("Se ha registrado correctamente el país " & Txt_Pais.Text & " en la base de datos.", "Exitoso")
            Txt_Pais.Text = ""
            datosIniciales()
        Else
            MessageBox.Show("El país  " & Txt_Pais.Text & " no se registro correctamente en la base de datos", "Fallido")
        End If

    End Sub
End Class