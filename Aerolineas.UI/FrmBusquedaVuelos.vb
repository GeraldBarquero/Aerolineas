Imports Aerolineas.Entidades
Imports Aerolineas.BLL
Imports Aerolineas.Utilitarios
Imports System.Windows.Forms
Imports System.Data
Public Class FrmBusquedaVuelos
#Region "Variables"
    Public objRespuesta As New OBJETOS.ObjRespuesta
    Private objConsultarVuelo As New OBJETOS.ObjConsultarVuelo
    Private objDestino As New OBJETOS.ObjDestino
    Private objCliente As New OBJETOS.ObjCliente
    Private _VueloBll As New BllVuelo
    Private _DestinoBll As New BLL.Destino.BllDestino
    Private _ClienteBll As New BLL.Clientes.BllCliente
    Private _dsConsultarVuelo As DataSet
    Private _dsDestinos As DataSet
    Private _dsConsultarCliente As DataSet
#End Region

    Private Sub FrmBusquedaVuelos_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        datosIniciales()
    End Sub

    Sub datosIniciales()
        Try
            objRespuesta = _DestinoBll.Select_Destino_All(objDestino)
            _dsDestinos = Utilitarios.UTL.Utilitarios.Utilitarios.UnzipDataSet(objRespuesta.ByteResponseObject)
            Cmb_DestinoSalida.ValueMember = _dsDestinos.Tables(0).Columns("IdDestino").ColumnName
            Cmb_DestinoSalida.DisplayMember = _dsDestinos.Tables(0).Columns("NombreDestino").ColumnName
            Cmb_DestinoSalida.DataSource = _dsDestinos.Tables("Datos")

            objRespuesta = _DestinoBll.Select_Destino_All(objDestino)
            _dsDestinos = Utilitarios.UTL.Utilitarios.Utilitarios.UnzipDataSet(objRespuesta.ByteResponseObject)
            Cmb_DestinoLlegada.ValueMember = _dsDestinos.Tables(0).Columns("IdDestino").ColumnName
            Cmb_DestinoLlegada.DisplayMember = _dsDestinos.Tables(0).Columns("NombreDestino").ColumnName
            Cmb_DestinoLlegada.DataSource = _dsDestinos.Tables("Datos")

            Dtp_FechaVuelo.Value = Date.Now
            Btn_RegistroVueloCliente.Visible = False
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Btn_Limpiar_Click(sender As System.Object, e As System.EventArgs) Handles Btn_Limpiar.Click
        datosIniciales()
        Dtp_FechaVuelo.Value = Date.Now
        Txt_PrecioMayor.Text = ""
        Txt_PrecioMenor.Text = ""
        Dgv_ConsultarVuelo.DataSource = ""
        Btn_RegistroVueloCliente.Visible = False
    End Sub

    Private Sub Btn_Cancelar_Click(sender As System.Object, e As System.EventArgs) Handles Btn_Cancelar.Click
        Me.Dispose()
        Me.Close()
        Dim FrmMenuPrincipalCliente As New FrmMenuPClientes
        FrmMenuPrincipalCliente.ShowDialog()
    End Sub

    Private Sub Btn_Consultar_Click(sender As System.Object, e As System.EventArgs) Handles Btn_Consultar.Click
        objConsultarVuelo.DestinoSalida = Cmb_DestinoSalida.SelectedValue
        objConsultarVuelo.DestinoLlegada = Cmb_DestinoLlegada.SelectedValue
        objConsultarVuelo.FechaVuelo = Dtp_FechaVuelo.Text
        If Txt_PrecioMenor.Text <> "" Then
            objConsultarVuelo.PrecioInicio = Convert.ToInt32(Txt_PrecioMenor.Text)
        End If
        If Txt_PrecioMayor.Text <> "" Then
            objConsultarVuelo.PrecioFinal = Convert.ToInt32(Txt_PrecioMayor.Text)
        End If
        objRespuesta = _VueloBll.Consultar_Vuelo(objConsultarVuelo)
        _dsConsultarVuelo = Utilitarios.UTL.Utilitarios.Utilitarios.UnzipDataSet(objRespuesta.ByteResponseObject)
        Dgv_ConsultarVuelo.DataSource = _dsConsultarVuelo.Tables(0)
        Btn_RegistroVueloCliente.Visible = False
    End Sub

    Private Sub Dgv_ConsultarVuelo_SelectionChanged(sender As Object, e As System.EventArgs) Handles Dgv_ConsultarVuelo.SelectionChanged
        Btn_RegistroVueloCliente.Visible = True
    End Sub

    Private Sub Btn_RegistroVueloCliente_Click(sender As System.Object, e As System.EventArgs) Handles Btn_RegistroVueloCliente.Click
        objCliente.Identification = InputBox("Ingrese el número de Pasaporte: ", "Registrar en el Vuelo")
        objRespuesta = _ClienteBll.Consultar_Cliente(objCliente)
        _dsConsultarCliente = Utilitarios.UTL.Utilitarios.Utilitarios.UnzipDataSet(objRespuesta.ByteResponseObject)
        
        objCliente.IdCliente = _dsConsultarCliente.Tables(0).Rows(0).Item(0)
        objCliente.IdVuelo = Dgv_ConsultarVuelo.SelectedRows(0).Cells(0).Value
        objRespuesta = _ClienteBll.InsertarClienteEnVuelo(objCliente)
        If objRespuesta.ResponseCode = 1 Then
            MessageBox.Show("Se ha registrado correctamente el usuario  en el vuelo ", "Exitoso")
        Else
            MessageBox.Show("No se ha registrado correctamente el usuario  en el vuelo ", "Fallido")
        End If
    End Sub
End Class