
Imports Aerolineas.Entidades
Imports Aerolineas.BLL
Imports Aerolineas.Utilitarios
Imports System.Windows.Forms
Imports System.Data



Public Class FrmNuevaLineaAerea

#Region "Variables"

    '' Bnt_Add_Click
    Private objLineaAerea As New OBJETOS.ObjLineaAerea
    Private objDestino As New OBJETOS.ObjDestino
    Private _LineaAereaBll As New BLL.LineaAerea.BllLineaAerea
    Private _DestinosBll As New BLL.Destino.BllDestino
    Public objRespuesta As New OBJETOS.ObjRespuesta
    Private _dsLineaAerea As New DataSet
    Private _dsDestinos As New DataSet
    Public modoPantalla As String = ""

#End Region

    Private Sub Bnt_Add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bnt_Add.Click
        objLineaAerea.NombreLineaArea = Txt_NombreLineaAerea.Text
        objDestino.idDestino = LsBx_destinos.SelectedItem

        _LineaAereaBll.InsertarLineaAerea(objLineaAerea)

        If objRespuesta.ResponseCode = 1 Then

            MessageBox.Show("Se ha registrado correctamente la linea Aerea " & Txt_NombreLineaAerea.Text & " en la base de datos.", "Exitoso")
            Txt_NombreLineaAerea.Text = ""

        Else
            MessageBox.Show("La linea Aerea " & Txt_NombreLineaAerea.Text & " no se registro correctamente en la base de datos", "Fallido")
        End If
        CargarGridLineasAereas()
    End Sub

    Public Sub CargarGridLineasAereas()
        Dim Objrespuesta As New OBJETOS.ObjRespuesta

        Objrespuesta = _LineaAereaBll.Select_LineaAereas_All(objLineaAerea)

        _dsLineaAerea = Utilitarios.UTL.Utilitarios.Utilitarios.UnzipDataSet(Objrespuesta.ByteResponseObject)
        Dgv_ListaLineasAereas.DataSource = _dsLineaAerea.Tables("Datos")


    End Sub


    Sub datosIniciales()
        Try
            Dim objRespuesta As New OBJETOS.ObjRespuesta
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

    Private Sub BntCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BntCancelar.Click
        Me.Dispose()
        Me.Close()
        Dim FrmMenuAdmin As New FrmMenuAdministrador
        FrmMenuAdmin.ShowDialog()
    End Sub
End Class
