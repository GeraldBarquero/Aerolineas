
Imports Aerolineas.Entidades
Imports Aerolineas.BLL
Imports Aerolineas.Utilitarios
Imports System.Windows.Forms
Imports System.Data



Public Class FrmNuevaLineaAerea

#Region "Variables"

    '' Bnt_Add_Click
    Private objLineaAerea As New OBJETOS.ObjLineaAerea
    Private _LineaAereaBll As New BLL.LineaAerea.BllLineaAerea
    Public objRespuesta As New OBJETOS.ObjRespuesta
    Private _ds As New DataSet



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
        CargarGridLineasAereas()
    End Sub

    Public Sub CargarGridLineasAereas()
        Dim Objrespuesta As New OBJETOS.ObjRespuesta

        Objrespuesta = _LineaAereaBll.Select_LineaAereas_All(objLineaAerea)

        _ds = Utilitarios.UTL.Utilitarios.Utilitarios.UnzipDataSet(Objrespuesta.ByteResponseObject)
        Dgv_ListaLineasAereas.DataSource = _ds.Tables("Datos")


    End Sub


    Sub datosIniciales()
        Try
            Dim objRespuesta As New OBJETOS.ObjRespuesta
            objRespuesta = _LineaAereaBll.Select_LineaAereas_All(objLineaAerea)
            _ds = Utilitarios.UTL.Utilitarios.Utilitarios.UnzipDataSet(objRespuesta.ByteResponseObject)

            Dgv_ListaLineasAereas.DataSource = _ds.Tables(0)
            objRespuesta = _LineaAereaBll.Select_LineaAereas_All(objLineaAerea)
            _ds = Utilitarios.UTL.Utilitarios.Utilitarios.UnzipDataSet(objRespuesta.ByteResponseObject)
            LsBx_destinos.DataSource = _ds.Tables(0)

        Catch ex As Exception
        End Try
    End Sub

    Private Sub FrmNuevaLineaAerea_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        datosIniciales()
    End Sub
End Class
