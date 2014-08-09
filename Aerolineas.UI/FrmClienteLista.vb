
Imports Aerolineas.Entidades
Imports Aerolineas.BLL
Imports Aerolineas.Utilitarios
Imports System.Data


Public Class FrmClienteLista

#Region "Variables"
    Private _ejecutarBll As New BLL.Clientes.BllCliente
    Private objCliente As New OBJETOS.ObjCliente
    Private _ds As New DataSet
    Public _codigoCliente As Integer


#End Region
    Private Sub FrmClienteLista_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        datosIniciales()
    End Sub

    Sub datosIniciales()
        Try
            Dim objRespuesta As New OBJETOS.ObjRespuesta
            objRespuesta = _ejecutarBll.Select_Cliente_All(objCliente)
            _ds = Utilitarios.UTL.Utilitarios.Utilitarios.UnzipDataSet(objRespuesta.ByteResponseObject)

            Dgv_ClientesLista.DataSource = _ds.Tables(0)

        Catch ex As Exception

        End Try
    End Sub
    Sub CargarGridCliente()
        Dim Objrespuesta As New OBJETOS.ObjRespuesta

        Objrespuesta = _ejecutarBll.Select_Cliente_All(objCliente)
        _ds = Utilitarios.UTL.Utilitarios.Utilitarios.UnzipDataSet(Objrespuesta.ByteResponseObject)
        Dgv_ClientesLista.DataSource = _ds.Tables("Datos")


    End Sub

    Private Sub Bnt_NuevoCliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bnt_NuevoCliente.Click
        Dim frmNuevoCliente As New FrmNuevoClientes
        Me.Hide()
        frmNuevoCliente.ShowDialog()
    End Sub

    Private Sub Bnt_ModificarCliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bnt_ModificarCliente.Click
        Dim frmModificarCliente As New FrmNuevoClientes
        frmModificarCliente.modoPantalla = "Modificar"
        _codigoCliente = Dgv_ClientesLista.SelectedRows(0).Cells(0).Value
        Me.Hide()
        frmModificarCliente.ShowDialog()
    End Sub
End Class