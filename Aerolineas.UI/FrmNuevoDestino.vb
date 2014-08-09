Imports Aerolineas.Entidades
Imports Aerolineas.BLL
Imports Aerolineas.Utilitarios
Imports System.Windows.Forms


Public Class FrmNuevoDestino
    Private objDestino As New OBJETOS.ObjDestino
    Private _DestinoBll As New BLL.Destino.BllDestino
    Private objRespuesta As New OBJETOS.ObjRespuesta


    Public modoPantalla As String = ""


    Private Sub Bnt_add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bnt_add.Click
        objDestino.nombreDestino = Txt_NombreDestino.Text
        objDestino.codigoDestino = Txt_CodigoDestino.Text

        _DestinoBll.InsertarDestino(objDestino)
    End Sub
End Class