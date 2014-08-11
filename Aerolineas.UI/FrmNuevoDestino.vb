Imports Aerolineas.Entidades
Imports Aerolineas.BLL
Imports Aerolineas.Utilitarios
Imports System.Windows.Forms
Imports System.Data


Public Class FrmNuevoDestino

    ''Bnt_add_Click
    Private objDestino As New OBJETOS.ObjDestino
    Private _DestinoBll As New BLL.Destino.BllDestino
    Private objRespuesta As New OBJETOS.ObjRespuesta

    ''datosIniciales
    Private _ejecutarBLL As Destino.BllDestino
    Private _ds As New DataSet



    Public modoPantalla As String = ""


    Private Sub Bnt_add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bnt_add.Click
        objDestino.nombreDestino = Txt_NombreDestino.Text
        objDestino.codigoDestino = Txt_CodigoDestino.Text

        _DestinoBll.InsertarDestino(objDestino)

        If objRespuesta.ResponseCode = 1 Then

            MessageBox.Show("Se ha registrado correctamente el destino " & Txt_NombreDestino.Text & " en la base de datos.", "Exitoso")
            Txt_NombreDestino.Text = ""
            Txt_CodigoDestino.Text = ""

        Else
            MessageBox.Show("El destino  " & Txt_NombreDestino.Text & " no se registro correctamente en la base de datos", "Fallido")
        End If
    End Sub



    Sub datosIniciales()
        Try
            Dim objRespuesta As New OBJETOS.ObjRespuesta

            objRespuesta = _ejecutarBLL.Select_Destino_All(objDestino)
            _ds = Utilitarios.UTL.Utilitarios.Utilitarios.UnzipDataSet(objRespuesta.ByteResponseObject)

            Dgv_ListaDestinos.DataSource = _ds.Tables(0)

        Catch ex As Exception
        End Try
    End Sub
End Class