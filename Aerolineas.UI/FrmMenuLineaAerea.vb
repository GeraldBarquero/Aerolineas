Imports Aerolineas.Entidades
Imports Aerolineas.BLL
Imports Aerolineas.Utilitarios
Imports System.Windows.Forms
Imports System.Data

Public Class FrmMenuLineaAerea

#Region "Variables"

    Public objRespuesta As New OBJETOS.ObjRespuesta
    Private objLineaAerea As New OBJETOS.ObjLineaAerea
    Private objDestino As New OBJETOS.ObjDestino
    Private objLineaAreaDestino As New OBJETOS.ObjLineaAereaDestino
    Private _LineaAereaBll As New BLL.LineaAerea.BllLineaAerea
    Private _DestinosBll As New BLL.Destino.BllDestino
    Private _LineaAreaDestinoBll As New BLL.LineaArea_Destino.BllLineaAerea_Destino
    Private _dsLineaAerea As New DataSet
    Private _dsDestinos As New DataSet
    Public modoPantalla As String = ""
    Private _idLineaArea As Integer = 0
#End Region

    Private Sub Bnt_Acceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bnt_Acceptar.Click

        If modoPantalla = "Eliminar" Then
            objLineaAerea.NombreLineaAerea = Txt_NombreLineaAerea.Text
            objRespuesta = _LineaAereaBll.EliminarLineaAerea(objLineaAerea)
            If objRespuesta.ResponseCode = 1 Then
                MessageBox.Show("Se ha Eliminado correctamente la Linea Aerea " & Txt_NombreLineaAerea.Text & " en la base de datos.", "Exitoso")
                Me.Close()
                Me.Dispose()
                Dim frmMenuLineaAerea As New FrmMenuLineaAerea
                frmMenuLineaAerea.ShowDialog()
            Else
                MessageBox.Show("La Aerolinea Aerea  " & Txt_NombreLineaAerea.Text & " no se Eliminado correctamente en la base de datos", "Fallido")
            End If
        ElseIf modoPantalla = "Actualizar" Then
            objLineaAerea.NombreLineaAerea = Txt_NombreLineaAerea.Text
            objRespuesta = _LineaAereaBll.ActualizarLineaAerea(objLineaAerea)
            If objRespuesta.ResponseCode = 1 Then
                MessageBox.Show("Se ha Modificado correctamente la Linea Aerea " & Txt_NombreLineaAerea.Text & " en la base de datos.", "Exitoso")
                Me.Close()
                Me.Dispose()
                Dim frmMenuPais As New FrmMenuPais
                frmMenuPais.ShowDialog()
            Else
                MessageBox.Show("la Linea Aerea " & Txt_NombreLineaAerea.Text & " no se Modificado correctamente en la base de datos", "Fallido")
            End If
        Else
            objLineaAerea.NombreLineaAerea = Txt_NombreLineaAerea.Text
            If LsBx_destinos.SelectedItems.Count > 0 Then
                objRespuesta = _LineaAereaBll.InsertarLineaAerea(objLineaAerea)
                objLineaAreaDestino.IdLineaAerea = objRespuesta._IdResultado
                For Each elemento In LsBx_destinos.SelectedItems
                    objLineaAreaDestino.IdDestino = Convert.ToInt32(elemento.Item(0))
                    objRespuesta = _LineaAreaDestinoBll.InsertarLineaAerea(objLineaAreaDestino)
                Next elemento
                Txt_NombreLineaAerea.Text = ""
                If objRespuesta.ResponseCode = 1 Then
                    MessageBox.Show("Se ha registrado correctamente la linea Aerea " & Txt_NombreLineaAerea.Text & " en la base de datos.", "Exitoso")
                Else
                    MessageBox.Show("La linea Aerea " & Txt_NombreLineaAerea.Text & " no se registro correctamente en la base de datos", "Fallido")
                End If
            End If
        End If
    End Sub


    Sub datosIniciales()
        Try
            objRespuesta = _LineaAereaBll.Select_LineaAereas_All(objLineaAerea)
            _dsLineaAerea = Utilitarios.UTL.Utilitarios.Utilitarios.UnzipDataSet(objRespuesta.ByteResponseObject)
            Dgv_ListaLineasAereas.DataSource = _dsLineaAerea.Tables(0)
            objRespuesta = _DestinosBll.Select_Destino_All(objDestino)
            _dsDestinos = Utilitarios.UTL.Utilitarios.Utilitarios.UnzipDataSet(objRespuesta.ByteResponseObject)
            LsBx_destinos.ValueMember = _dsDestinos.Tables(0).Columns("IdDestino").ColumnName
            LsBx_destinos.DisplayMember = _dsDestinos.Tables(0).Columns("CodigoDestino").ColumnName
            LsBx_destinos.DataSource = _dsDestinos.Tables("Datos")
        Catch ex As Exception
        End Try
    End Sub

    Private Sub FrmNuevaLineaAerea_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        datosIniciales()
        If modoPantalla = "Eliminar" Then
            Bnt_Acceptar.Text = "Aceptar"
            Txt_NombreLineaAerea.Enabled = False
            Bnt_ModificarLineaAerea.Hide()
            Bnt_EliminarLineaAerea.Hide()
            cargarDatos()
        ElseIf modoPantalla = "Actualizar" Then
            Bnt_Acceptar.Text = "Aceptar"
            Txt_NombreLineaAerea.Enabled = False
            Bnt_ModificarLineaAerea.Hide()
            Bnt_EliminarLineaAerea.Hide()
            cargarDatos()
        Else
            Bnt_Acceptar.Text = "Insertar"
        End If
    End Sub
    Private Sub ValidarLetrasNumeros(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txt_NombreLineaAerea.KeyPress
        e.KeyChar = Chr(SoloLetras(Asc(e.KeyChar)))
    End Sub
    Private Function VerificarCampos() As Boolean
        If Len(Txt_NombreLineaAerea.Text.Trim) = 0 Then
            MsgBox("Verifica el campo Nombre", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Ayuda")
            Txt_NombreLineaAerea.Focus()
            Return False
            Exit Function
        End If
        Return True
    End Function

    Private Sub BntCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bnt_Cancelar.Click
        Me.Dispose()
        Me.Close()
        Dim FrmMenuLineaAerea As New FrmMenuLineaAerea
        FrmMenuLineaAerea.ShowDialog()
    End Sub


    Private Sub Bnt_EliminarLineaAerea_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bnt_EliminarLineaAerea.Click
        Dim frmMenuLineaAerea As New FrmMenuLineaAerea
        Try
            If Dgv_ListaLineasAereas.SelectedRows.Count > 0 Then
                frmMenuLineaAerea.modoPantalla = "Eliminar"
                frmMenuLineaAerea._idLineaArea = Dgv_ListaLineasAereas.SelectedRows(0).Cells(0).Value
                Me.Hide()
                frmMenuLineaAerea.ShowDialog()
            Else
                MessageBox.Show("Debe seleccionar una Linea Aerea para poder eliminarla de la Base de datos ")
            End If

        Catch ex As Exception
        End Try
    End Sub

    Private Sub Bnt_ModificarLineaAerea_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bnt_ModificarLineaAerea.Click
        Dim frmMenuLineaAerea As New FrmMenuLineaAerea
        Try
            If Dgv_ListaLineasAereas.SelectedRows.Count > 0 Then
                frmMenuLineaAerea.modoPantalla = "Actualizar"
                frmMenuLineaAerea._idLineaArea = Dgv_ListaLineasAereas.SelectedRows(0).Cells(0).Value
                Me.Hide()
                frmMenuLineaAerea.ShowDialog()
            Else
                MessageBox.Show("Debe seleccionar una Linea Aerea para poder modificarla")
            End If
        Catch ex As Exception
        End Try
    End Sub

    Sub cargarDatos()
        objLineaAerea.idLineaAerea = _idLineaArea
        Dim objRespuesta As New OBJETOS.ObjRespuesta
        objRespuesta = _LineaAereaBll.Obtener_LineaAereas(objLineaAerea)
        _dsLineaAerea = Nothing
        _dsLineaAerea = Utilitarios.UTL.Utilitarios.Utilitarios.UnzipDataSet(objRespuesta.ByteResponseObject)
        Try
            If _dsLineaAerea.Tables(0).Rows.Count > 0 Then
                For Each row In _dsLineaAerea.Tables(0).Rows
                    Txt_NombreLineaAerea.Text = row("NombreLineaAerea")
                Next
            Else
                MessageBox.Show("la consulta no produjo resultados, sin resultados")
            End If
        Catch ex As Exception
        End Try
    End Sub
End Class
