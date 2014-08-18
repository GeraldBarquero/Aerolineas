Imports Aerolineas.Entidades
Imports Aerolineas.BLL
Imports Aerolineas.Utilitarios
Imports System.Windows.Forms
Imports System.Data
Public Class FrmMenuReportes

#Region "Variables"
    Public objRespuesta As New OBJETOS.ObjRespuesta
    Private objLineaAerea As New OBJETOS.ObjLineaAerea
    Private objDestino As New OBJETOS.ObjDestino
    Private objVuelo As New OBJETOS.ObjVuelo
    Private objUsuario As New OBJETOS.ObjUsuario
    Private _LineaAereaBll As New BLL.LineaAerea.BllLineaAerea
    Private _DestinosBll As New BLL.Destino.BllDestino
    Private _VuelosBll As New BLL.BllVuelo
    Private _UsuariosBll As New BLL.BllUsuario
    Private _dsLineaAerea As New DataSet
    Private _dsDestinos As New DataSet
    Private _dsVuelos As New DataSet
    Private _dsUsuarios As New DataSet
#End Region

    Private Sub Btn_Aerolineas_Click(sender As System.Object, e As System.EventArgs) Handles Btn_Aerolineas.Click
        objRespuesta = _LineaAereaBll.Select_LineaAereas_All(objLineaAerea)
        _dsLineaAerea = Utilitarios.UTL.Utilitarios.Utilitarios.UnzipDataSet(objRespuesta.ByteResponseObject)
        Dgv_Reportes.DataSource = _dsLineaAerea.Tables(0)
    End Sub

    Private Sub Btn_Destinos_Click(sender As System.Object, e As System.EventArgs) Handles Btn_Destinos.Click
        objRespuesta = _DestinosBll.Select_Destino_All(objDestino)
        _dsDestinos = Utilitarios.UTL.Utilitarios.Utilitarios.UnzipDataSet(objRespuesta.ByteResponseObject)
        Dgv_Reportes.DataSource = _dsDestinos.Tables(0)
    End Sub

    Private Sub Btn_Vuelos_Click(sender As System.Object, e As System.EventArgs) Handles Btn_Vuelos.Click
        objRespuesta = _VuelosBll.Select_Vuelo_All(objVuelo)
        _dsVuelos = Utilitarios.UTL.Utilitarios.Utilitarios.UnzipDataSet(objRespuesta.ByteResponseObject)
        Dgv_Reportes.DataSource = _dsVuelos.Tables(0)
    End Sub

    Private Sub Btn_Usuarios_Click(sender As System.Object, e As System.EventArgs) Handles Btn_Usuarios.Click
        objRespuesta = _UsuariosBll.SelectUsuario_All(objUsuario)
        _dsUsuarios = Utilitarios.UTL.Utilitarios.Utilitarios.UnzipDataSet(objRespuesta.ByteResponseObject)
        Dgv_Reportes.DataSource = _dsUsuarios.Tables(0)
    End Sub

    Private Sub Btn_Cancelar_Click(sender As System.Object, e As System.EventArgs) Handles Btn_Cancelar.Click
        Me.Close()
    End Sub
End Class