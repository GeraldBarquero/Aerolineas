Imports Aerolineas.Entidades
Imports Aerolineas.BLL
Imports Aerolineas.Utilitarios
Imports System.Windows.Forms
Imports System.Data


Public Class FrmNuevoDestino

    ''Bnt_add_Click
    Private objDestino As New OBJETOS.ObjDestino
    Private _DestinoBll As New BLL.Destino.BllDestino
    Private objPais As New OBJETOS.ObjPais
    Private _PaisBll As New BLL.BllPais
    Private objRespuesta As New OBJETOS.ObjRespuesta
    Private _dsDestinos As New DataSet
    Private _dsPaises As New DataSet



    Sub datosIniciales()
        Try
            Dim objRespuesta As New OBJETOS.ObjRespuesta

            objRespuesta = _DestinoBll.Select_Destino_All(objDestino)
            _dsDestinos = Utilitarios.UTL.Utilitarios.Utilitarios.UnzipDataSet(objRespuesta.ByteResponseObject)
            Dgv_ListaDestinos.DataSource = _dsDestinos.Tables(0)
            objRespuesta = _PaisBll.Select_Pais_All(objPais)
            _dsPaises = Utilitarios.UTL.Utilitarios.Utilitarios.UnzipDataSet(objRespuesta.ByteResponseObject)
            Cmb_Pais.ValueMember = _dsPaises.Tables(0).Columns("IdPais").ColumnName
            Cmb_Pais.DisplayMember = _dsPaises.Tables(0).Columns("NombrePais").ColumnName
            Cmb_Pais.DataSource = _dsPaises.Tables("Datos")
        Catch ex As Exception
        End Try
    End Sub

    Private Sub FrmNuevoDestino_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        datosIniciales()
    End Sub

    Private Sub Bnt_add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bnt_add.Click
        objDestino.nombreAeropuerto = Txt_NombreAeropuerto.Text
        objDestino.nombreDestino = Txt_NombreDestino.Text
        objDestino.codigoDestino = Txt_CodigoDestino.Text
        objDestino.idPais = Cmb_Pais.SelectedValue

        objRespuesta = _DestinoBll.InsertarDestino(objDestino)

        If objRespuesta.ResponseCode = 1 Then
            MessageBox.Show("Se ha registrado correctamente el destino " & Txt_NombreDestino.Text & " en la base de datos.", "Exitoso")
            Txt_NombreDestino.Text = ""
            Txt_CodigoDestino.Text = ""
        Else
            MessageBox.Show("El destino  " & Txt_NombreDestino.Text & " no se registro correctamente en la base de datos", "Fallido")
        End If
        datosIniciales()
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
        Dim FrmMenuAdmin As New FrmMenuAdministrador
        FrmMenuAdmin.ShowDialog()
    End Sub
End Class