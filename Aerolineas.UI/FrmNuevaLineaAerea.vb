
Imports Aerolineas.Entidades
Imports Aerolineas.BLL
Imports Aerolineas.Utilitarios
Imports System.Windows.Forms


Public Class FrmNuevaLineaAerea

#Region "Variables"
    Private objLineaAerea As New OBJETOS.ObjLineaAerea
    Private _LineaAereaBll As New BLL.LineaAerea.BllLineaAerea
    Private objRespuesta As New OBJETOS.ObjRespuesta

    Public modoPantalla As String = ""

#End Region


    Private Sub Bnt_Add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bnt_Add.Click
        objLineaAerea.NombreLineaArea = Txt_NombreLineaAerea.Text


        _LineaAereaBll.InsertarLineaAerea(objLineaAerea)

        If objRespuesta.ResponseCode = 1 Then

            MessageBox.Show("Se ha registrado correctamente la linea Aerea " & Txt_NombreLineaAerea.Text & " en la base de datos.", "Exitoso")
            Txt_NombreLineaAerea.Text = ""

        Else
            MessageBox.Show("La linea Aerea " & Txt_NombreLineaAerea.Text & " no se registro correctamente en la base de datos", "Fallido")
        End If
    End Sub
End Class
