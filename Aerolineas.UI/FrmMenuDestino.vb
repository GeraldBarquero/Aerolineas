Imports Aerolineas.Entidades
Imports Aerolineas.BLL
Imports Aerolineas.Utilitarios
Imports System.Windows.Forms
Imports System.Data

Public Class FrmMenuDestino


#Region "Variables"
    ''Bnt_add_Click
    Private objDestino As New OBJETOS.ObjDestino
    Private _DestinoBll As New BLL.Destino.BllDestino
    Private objRespuesta As New OBJETOS.ObjRespuesta
    Private _dsPaises As New DataSet
    Public modoPantalla As String = ""
    Private objPais As New OBJETOS.ObjPais
    Private _PaisBll As New BLL.BllPais
    Public _IdDestino As Integer = 0
    Dim _dsDestinos As New DataSet

#End Region

    Sub datosIniciales()
        Try
            ''_dsDestinos.Tables.Clear()
            objRespuesta = _DestinoBll.Select_Destino_All(objDestino)
            _dsDestinos = Utilitarios.UTL.Utilitarios.Utilitarios.UnzipDataSet(objRespuesta.ByteResponseObject)
            Dgv_ListaDestinos.DataSource = _dsDestinos.Tables(0)

            objRespuesta = _PaisBll.Select_Pais_All(objPais)
            _dsPaises = Utilitarios.UTL.Utilitarios.Utilitarios.UnzipDataSet(objRespuesta.ByteResponseObject)
            Cmb_Pais.ValueMember = _dsPaises.Tables(0).Columns("IdPais").ColumnName
            Cmb_Pais.DisplayMember = _dsPaises.Tables(0).Columns("NombrePais").ColumnName
            Cmb_Pais.DataSource = _dsPaises.Tables("Datos")

            If modoPantalla = "Eliminar" Then
                Bnt_Acceptar.Text = "Aceptar"

                Txt_NombreAeropuerto.Text = False
                Txt_NombreDestino.Text = False
                Txt_CodigoDestino.Text = False
                Cmb_Pais.SelectedValue = False

                Bnt_ConsultarDestino.Hide()
                Bnt_ModificarDestino.Hide()
                Bnt_EliminarDestino.Hide()
                cargarDatos()

            ElseIf modoPantalla = "Actualizar" Then
                Bnt_Acceptar.Text = "Aceptar"
                Bnt_ConsultarDestino.Hide()
                Bnt_ModificarDestino.Hide()
                Bnt_EliminarDestino.Hide()
                cargarDatos()
                'ElseIf modoPantalla = "Modificar" Then
                '    Bnt_Acceptar.Text = "Aceptar"
                '    Bnt_ConsultarDestino.Hide()
                '    Bnt_ModificarDestino.Hide()
                '    Bnt_EliminarDestino.Hide()
            Else
                Bnt_Acceptar.Text = "Insertar"
            End If


        Catch ex As Exception
        End Try
    End Sub

    Private Sub FrmMenuDestino_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        datosIniciales()
    End Sub

    Private Sub Bnt_Acceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bnt_Acceptar.Click

        If modoPantalla = "Eliminar" Then
            objDestino.NombreAeropuerto = Txt_NombreAeropuerto.Text
            objDestino.NombreDestino = Txt_NombreDestino.Text
            objDestino.CodigoDestino = Txt_CodigoDestino.Text
            objDestino.idPais = Cmb_Pais.SelectedValue
            objRespuesta = _DestinoBll.EliminarDestino(objDestino)

            If objRespuesta.ResponseCode = 1 Then
                MessageBox.Show("Se ha Eliminado correctamente el destino " & Txt_NombreDestino.Text & " en la base de datos.", "Exitoso")
                Me.Close()
                Me.Dispose()
                Dim frmNuevoDestino As New FrmMenuDestino
                frmNuevoDestino.ShowDialog()
            Else
                MessageBox.Show("El Destino  " & Txt_NombreDestino.Text & " no se Eliminado correctamente en la base de datos", "Fallido")
            End If

        ElseIf modoPantalla = "Actualizar" Then
            objDestino.NombreAeropuerto = Txt_NombreAeropuerto.Text
            objDestino.NombreDestino = Txt_NombreDestino.Text
            objDestino.CodigoDestino = Txt_CodigoDestino.Text
            objDestino.idPais = Cmb_Pais.SelectedValue
            objRespuesta = _DestinoBll.ActualizarDestino(objDestino)

            If objRespuesta.ResponseCode = 1 Then
                MessageBox.Show("Se ha Modificado correctamente el destino " & Txt_NombreDestino.Text & " en la base de datos.", "Exitoso")
                Me.Close()
                Me.Dispose()
                Dim frmNuevoDestino As New FrmMenuDestino
                frmNuevoDestino.ShowDialog()
            Else
                MessageBox.Show("El Destino  " & Txt_NombreDestino.Text & " no se Modifico correctamente en la base de datos", "Fallido")
            End If

        ElseIf modoPantalla = "Consultar" Then
            'objDestino.NombreAeropuerto = Txt_NombreAeropuerto.Text
            'objDestino.NombreDestino = Txt_NombreDestino.Text
            'objDestino.CodigoDestino = Txt_CodigoDestino.Text
            'objDestino.idPais = Cmb_Pais.SelectedValue


            'If objRespuesta.ResponseCode = 1 Then
            '    MessageBox.Show("Se ha Modificado correctamente el destino " & Txt_NombreDestino.Text & " en la base de datos.", "Exitoso")
            '    Me.Close()
            '    Me.Dispose()
            '    Dim frmNuevoDestino As New FrmMenuDestino
            '    frmNuevoDestino.ShowDialog()
            'End If

        Else
            objDestino.NombreAeropuerto = Txt_NombreAeropuerto.Text
            objDestino.NombreDestino = Txt_NombreDestino.Text
            objDestino.CodigoDestino = Txt_CodigoDestino.Text
            objDestino.idPais = Cmb_Pais.SelectedValue

            objRespuesta = _DestinoBll.InsertarDestino(objDestino)

            If objRespuesta.ResponseCode = 1 Then
                MessageBox.Show("Se ha registrado correctamente el destino " & Txt_NombreDestino.Text & " en la base de datos.", "Exitoso")
                Txt_NombreDestino.Text = ""
                Txt_CodigoDestino.Text = ""
                Txt_NombreAeropuerto.Text = ""
            Else
                MessageBox.Show("El destino  " & Txt_NombreDestino.Text & " no se registro correctamente en la base de datos", "Fallido")
            End If
            datosIniciales()

        End If
    End Sub

    Private Sub ValidarLetrasNumeros(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txt_CodigoDestino.KeyPress, Txt_NombreDestino.KeyPress, Txt_NombreAeropuerto.KeyPress
        e.KeyChar = Chr(SoloLetras(Asc(e.KeyChar)))
    End Sub

    Private Function VerificarCampos() As Boolean
        If Len(Txt_NombreAeropuerto.Text.Trim) = 0 Then
            MsgBox("Verifica el campo Nombre del Aeropuerto", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Ayuda")
            Txt_NombreAeropuerto.Focus()
            Return False
            Exit Function
        End If
        If Len(Txt_NombreDestino.Text.Trim) = 0 Then
            MsgBox("Verifica el campo Nombre del Destino", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Ayuda")
            Txt_NombreDestino.Focus()
            Return False
            Exit Function
        End If
        If Len(Txt_CodigoDestino.Text.Trim) = 0 Then
            MsgBox("Verifica el campo Codigo", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Ayuda")
            Txt_CodigoDestino.Focus()
            Return False
            Exit Function
        End If
        Return True
    End Function

    Private Sub BntCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BntCancelar.Click
        Me.Dispose()
        Me.Close()
        Dim FrmMenuDestino As New FrmMenuDestino
        FrmMenuDestino.ShowDialog()
    End Sub


    Private Sub Bnt_EliminarDestino_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bnt_EliminarDestino.Click
        Dim frmMenuDestino As New FrmMenuDestino
        Try
            If Dgv_ListaDestinos.SelectedRows.Count > 0 Then
                frmMenuDestino.modoPantalla = "Eliminar"
                frmMenuDestino._IdDestino = Dgv_ListaDestinos.SelectedRows(0).Cells(0).Value
                Me.Hide()
                frmMenuDestino.ShowDialog()
            End If
            MessageBox.Show("Debe selecciona un Destino para poder Eliminarlo de la Base de datos ")
        Catch ex As Exception

        End Try
    End Sub


    Private Sub Bnt_ModificarDestino_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bnt_ModificarDestino.Click
        Dim frmMenuDestino As New FrmMenuDestino
        Try
            If Dgv_ListaDestinos.SelectedRows.Count > 0 Then
                frmMenuDestino.modoPantalla = "Actualizar"
                frmMenuDestino._IdDestino = Dgv_ListaDestinos.SelectedRows(0).Cells(0).Value
                Me.Hide()
                frmMenuDestino.ShowDialog()
            End If
            MessageBox.Show("Debe selecciona un Destino para poder Modificarlo de la Base de datos ")
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Bnt_ConsultarDestino_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bnt_ConsultarDestino.Click
        Dim frmMenuDestino As New FrmMenuDestino
        Try
            frmMenuDestino.modoPantalla = "Consultar"
            Me.Hide()
            frmMenuDestino.ShowDialog()
            Me.Dispose()
        Catch ex As Exception

        End Try
    End Sub


    Sub cargarDatos()
        objDestino.idDestino = _IdDestino
        Dim objRespuesta As New OBJETOS.ObjRespuesta
        objRespuesta = _DestinoBll.Select_Destino_All(objDestino)
        _dsDestinos = Nothing
        _dsDestinos = Utilitarios.UTL.Utilitarios.Utilitarios.UnzipDataSet(objRespuesta.ByteResponseObject)
        Try
            If _dsDestinos.Tables(0).Rows.Count > 0 Then
                For Each row In _dsDestinos.Tables(0).Rows
                    Txt_NombreDestino.Text = row("NombreDestino")
                    Txt_CodigoDestino = row("CodigoDestino")
                    Txt_NombreAeropuerto = row("NombreAeropuerto")
                Next
            Else
                MessageBox.Show("la consulta o produjo resultados, sin resultados")
            End If
        Catch ex As Exception

        End Try
    End Sub
End Class