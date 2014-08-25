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
    Public modoPantalla As String = ""
    Public _codigoVuelo As Integer = 0

#End Region
    Private Sub Btn_Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Cancelar.Click
        Me.Close()
    End Sub

    Private Sub FrmMenuVuelo_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        datosIniciales()

        If modoPantalla = "Eliminar" Then

            Btn_Aceptar.Text = "Aceptar"
            Lb_Confirmacion.Text = "¿Seguro que que desea eliminar el vuelo?"
            Cmb_Aerolinea.Enabled = False
            Cmb_DestinoLlegada.Enabled = False
            Cmb_DestinoSalida.Enabled = False
            Dtp_FechaVuelo.Enabled = False
            Dtp_HoraLlegada.Enabled = False
            Dtp_HoraSalida.Enabled = False
            Txt_NumeroVuelo.Enabled = False
            Txt_Precio.Enabled = False
            Nud_CantidadPasajeros.Enabled = False
            Nud_CantidadPasajeros.Enabled = False

            Bnt_Consultar.Hide()
            Bnt_ModificarVuelo.Hide()
            Bnt_EliminarVuelo.Hide()
            Dgv_Vuelos.Hide()
            CargarVuelos()
        ElseIf modoPantalla = "Actualizar" Then
            Lb_Confirmacion.Text = "¿Seguro que que desea Actualizar el Vuelo?"
            Bnt_Consultar.Hide()
            Bnt_ModificarVuelo.Hide()
            Bnt_EliminarVuelo.Hide()
            Dgv_Vuelos.Hide()
            CargarVuelos()
            'ElseIf modoPantalla = "Modificar" Then
            '    Bt_Aceptar.Text = "Aceptar"
            '    Bnt_ConsultarPais.Hide()
            '    Bnt_ModificarPais.Hide()
            '    Bnt_EliminarPais.Hide()
        Else
            Btn_Aceptar.Text = "Insertar"

        End If


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


        If modoPantalla = "Eliminar" Then


            objVuelo.idAerolinea = Cmb_Aerolinea.SelectedValue
            objVuelo.llegada = Cmb_DestinoLlegada.SelectedValue
            objVuelo.salida = Cmb_DestinoSalida.SelectedValue
            objVuelo.fechaVuelo = Dtp_FechaVuelo.Text
            objVuelo.horaLlegada = Dtp_HoraLlegada.Text
            objVuelo.horaSalida = Dtp_HoraSalida.Text
            objVuelo.numeroVuelo = Txt_NumeroVuelo.Text
            objVuelo.precio = Txt_Precio.Text
            objVuelo.camposTotales = Nud_CantidadPasajeros.Value
            objVuelo.camposDisponibles = Nud_CantidadPasajeros.Value
            objRespuesta = _VueloBll.EliminarVuelo(objVuelo)

            If objRespuesta.ResponseCode = 1 Then
                MessageBox.Show("Se ha Eliminado correctamente el vuelo " & Txt_NumeroVuelo.Text & " en la base de datos.", "Exitoso")
                Me.Close()
                Me.Dispose()
                Dim frmMenuVuelo As New FrmMenuVuelo
                frmMenuVuelo.ShowDialog()
            Else
                MessageBox.Show("El país  " & Txt_NumeroVuelo.Text & " no se Eliminado correctamente en la base de datos", "Fallido")
            End If
        ElseIf modoPantalla = "Actualizar" Then


            objVuelo.idAerolinea = Cmb_Aerolinea.SelectedValue
            objVuelo.llegada = Cmb_DestinoLlegada.SelectedValue
            objVuelo.salida = Cmb_DestinoSalida.SelectedValue
            objVuelo.fechaVuelo = Dtp_FechaVuelo.Text
            objVuelo.horaLlegada = Dtp_HoraLlegada.Text
            objVuelo.horaSalida = Dtp_HoraSalida.Text
            objVuelo.numeroVuelo = Txt_NumeroVuelo.Text
            objVuelo.precio = Txt_Precio.Text
            objVuelo.camposTotales = Nud_CantidadPasajeros.Value
            objVuelo.camposDisponibles = Nud_CantidadPasajeros.Value
            objRespuesta = _VueloBll.ActualizarVuelo(objVuelo)
            If objRespuesta.ResponseCode = 1 Then
                MessageBox.Show("Se ha actualizado correctamente el vuelo " & Txt_NumeroVuelo.Text & " en la base de datos.", "Exitoso")
                Me.Close()
                Me.Dispose()
                Dim frmMenuVuelo As New FrmMenuVuelo
                frmMenuVuelo.ShowDialog()
            Else
                MessageBox.Show("El país  " & Txt_NumeroVuelo.Text & " no se actualizado correctamente en la base de datos", "Fallido")
            End If


        Else

            objVuelo.idAerolinea = Cmb_Aerolinea.SelectedValue
            objVuelo.llegada = Cmb_DestinoLlegada.SelectedValue
            objVuelo.salida = Cmb_DestinoSalida.SelectedValue
            objVuelo.fechaVuelo = Dtp_FechaVuelo.Text
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
            '' datosIniciales()

        End If


    End Sub

    Private Sub Bnt_EliminarVuelo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bnt_EliminarVuelo.Click
        Dim frmMenuVuelo As New FrmMenuVuelo
        Try
            If Dgv_Vuelos.SelectedRows.Count > 0 Then
                frmMenuVuelo.modoPantalla = "Eliminar"
                frmMenuVuelo._codigoVuelo = Dgv_Vuelos.SelectedRows(0).Cells(0).Value
                Me.Hide()
                frmMenuVuelo.ShowDialog()
            End If
            MessageBox.Show("Debe selecciona un vuelo para poder eliminarlo en la Base de datos ")
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Bnt_Consultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bnt_Consultar.Click
        Dim frmMenuVuelo As New FrmMenuVuelo
        Try

            frmMenuVuelo.modoPantalla = "Consultar"
            frmMenuVuelo._codigoVuelo = Dgv_Vuelos.SelectedRows(0).Cells(0).Value
            Me.Hide()
            frmMenuVuelo.ShowDialog()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub Bnt_ModificarVuelo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bnt_ModificarVuelo.Click
        Dim frmMenuVuelo As New FrmMenuVuelo
        Try
            If Dgv_Vuelos.SelectedRows.Count > 0 Then
                frmMenuVuelo.modoPantalla = "Actualizar"
                frmMenuVuelo._codigoVuelo = Dgv_Vuelos.SelectedRows(0).Cells(0).Value
                Me.Hide()
                frmMenuVuelo.ShowDialog()
            End If
            MessageBox.Show("Debe selecciona un vuelo para poder actualizarlo en la Base de datos ")
        Catch ex As Exception

        End Try
    End Sub

    Sub CargarVuelos()
        objVuelo.idVuelo = _codigoVuelo
        Dim objRespuesta As New OBJETOS.ObjRespuesta
        objRespuesta = _VueloBll.Select_Vuelo_All(objVuelo)
        _dsVuelo = Nothing
        _dsVuelo = Nothing
        Try
            If _dsVuelo.Tables(0).Rows.Count > 0 Then
                For Each row In _dsVuelo.Tables(0).Rows
                    Txt_NumeroVuelo.Text = row("numeroVuelo")
                    Cmb_Aerolinea.Text = row("idAerolinea")
                    Cmb_DestinoSalida.Text = row("salida")
                    Cmb_DestinoLlegada.Text = row("llegada")
                    Dtp_FechaVuelo.Text = row("fechaVuelo")
                    Dtp_HoraSalida.Text = row("horaSalida")
                    Dtp_HoraLlegada.Text = row("horaLlegada")
                    Txt_Precio.Text = row("precio")
                    Nud_CantidadPasajeros.Value = row("camposTotales")
                Next
            End If
        Catch ex As Exception

        End Try

    End Sub

End Class