Imports Aerolineas.Entidades
Imports Aerolineas.BLL
Imports Aerolineas.Utilitarios
Imports System.Windows.Forms
Imports System.Data
Public Class FrmMenuVuelo
#Region "Variables"
    Public objRespuesta As New OBJETOS.ObjRespuesta
    Private objVuelo As New OBJETOS.ObjVuelo
    Private objLineaAereaDestino As New OBJETOS.ObjLineaAereaDestino
    Private objLineaAerea As New OBJETOS.ObjLineaAerea
    Private _VueloBll As New BllVuelo
    Private _LineaAereaDestinoBll As New BLL.LineaArea_Destino.BllLineaAerea_Destino
    Private _LineaAereaBll As New BLL.LineaAerea.BllLineaAerea
    Private _dsVuelo As DataSet
    Private _dsDestinos As DataSet
    Private _dsLineaAerea As DataSet
#End Region
    Private Sub Btn_Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Cancelar.Click
        Me.Close()
    End Sub

    Private Sub FrmMenuVuelo_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        datosIniciales()
    End Sub

    Sub datosIniciales()
        Try

            objRespuesta = _VueloBll.Select_Vuelo_All(objVuelo)
            _dsVuelo = Utilitarios.UTL.Utilitarios.Utilitarios.UnzipDataSet(objRespuesta.ByteResponseObject)
            Dgv_Vuelos.DataSource = _dsVuelo.Tables(0)

            objRespuesta = _LineaAereaBll.Select_LineaAereas_All(objLineaAerea)
            _dsLineaAerea = Utilitarios.UTL.Utilitarios.Utilitarios.UnzipDataSet(objRespuesta.ByteResponseObject)
            Cmb_Aerolinea.ValueMember = _dsLineaAerea.Tables(0).Columns("IdLineaAerea").ColumnName
            Cmb_Aerolinea.DisplayMember = _dsLineaAerea.Tables(0).Columns("NombreLineaAerea").ColumnName
            Cmb_Aerolinea.DataSource = _dsLineaAerea.Tables("Datos")

        Catch ex As Exception
        End Try
    End Sub

    Private Sub Cmb_Aerolinea_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles Cmb_Aerolinea.SelectedIndexChanged

        objLineaAereaDestino.IdLineaAerea = Cmb_Aerolinea.SelectedValue
        objRespuesta = _LineaAereaDestinoBll.Obtener_LineaAerea_Destinos(objLineaAereaDestino)
        _dsDestinos = Utilitarios.UTL.Utilitarios.Utilitarios.UnzipDataSet(objRespuesta.ByteResponseObject)
        Cmb_DestinoLlegada.ValueMember = _dsDestinos.Tables(0).Columns("IdDestino").ColumnName
        Cmb_DestinoLlegada.DisplayMember = _dsDestinos.Tables(0).Columns("CodigoDestino").ColumnName
        Cmb_DestinoLlegada.DataSource = _dsDestinos.Tables("Datos")

        objLineaAereaDestino.IdLineaAerea = Cmb_Aerolinea.SelectedValue
        objRespuesta = _LineaAereaDestinoBll.Obtener_LineaAerea_Destinos(objLineaAereaDestino)
        _dsDestinos = Utilitarios.UTL.Utilitarios.Utilitarios.UnzipDataSet(objRespuesta.ByteResponseObject)
        Cmb_DestinoSalida.ValueMember = _dsDestinos.Tables(0).Columns("IdDestino").ColumnName
        Cmb_DestinoSalida.DisplayMember = _dsDestinos.Tables(0).Columns("CodigoDestino").ColumnName
        Cmb_DestinoSalida.DataSource = _dsDestinos.Tables("Datos")
    End Sub

    Private Sub Btn_Aceptar_Click(sender As System.Object, e As System.EventArgs) Handles Btn_Aceptar.Click
        objVuelo.idAerolinea = Cmb_Aerolinea.SelectedValue
        objVuelo.llegada = Cmb_DestinoLlegada.SelectedValue
        objVuelo.salida = Cmb_DestinoSalida.SelectedValue
        objVuelo.horaLlegada = Dtp_HoraLlegada.Text
        objVuelo.horaSalida = Dtp_HoraSalida.Text
        objVuelo.numeroVuelo = Txt_NumeroVuelo.Text
        objVuelo.precio = Txt_Precio.Text
        objVuelo.camposTotales = Nud_CantidadPasajeros.Value
        objVuelo.camposDisponibles = Nud_CantidadPasajeros.Value

        objRespuesta = _VueloBll.InsertarVuelo(objVuelo)
        If objRespuesta.ResponseCode = 1 Then
            MessageBox.Show("Se ha registrado correctamente el vuelo número " & Txt_NumeroVuelo.Text & " en la base de datos.", "Exitoso")
            Txt_NumeroVuelo.Text = ""
            Txt_Precio.Text = ""
            Nud_CantidadPasajeros.Update()
            Dtp_HoraLlegada.Update()
            Dtp_HoraSalida.Update()
        Else
            MessageBox.Show("El Vuelo  " & Txt_NumeroVuelo.Text & " no se registro correctamente en la base de datos", "Fallido")
        End If
        datosIniciales()
    End Sub
End Class