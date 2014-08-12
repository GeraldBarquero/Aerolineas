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
    Private _ds As New DataSet



    Sub datosIniciales()
        Try
            Dim objRespuesta As New OBJETOS.ObjRespuesta

            'objRespuesta = _DestinoBll.Select_Destino_All(objDestino)
            '_ds = Utilitarios.UTL.Utilitarios.Utilitarios.UnzipDataSet(objRespuesta.ByteResponseObject)
            'Dgv_ListaDestinos.DataSource = _ds.Tables(0)
            objRespuesta = _PaisBll.Select_Pais_All(objPais)
            _ds = Utilitarios.UTL.Utilitarios.Utilitarios.UnzipDataSet(objRespuesta.ByteResponseObject)
            Cmb_Pais.ValueMember = _ds.Tables(0).Columns("IdPais").ColumnName
            Cmb_Pais.DisplayMember = _ds.Tables(0).Columns("NombrePais").ColumnName
            Cmb_Pais.DataSource = _ds.Tables("Datos")
        Catch ex As Exception
        End Try
    End Sub

    Private Sub FrmNuevoDestino_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        datosIniciales()
    End Sub

    Private Sub Bnt_add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bnt_add.Click
        objDestino.nombreDestino = Txt_NombreDestino.Text
        objDestino.codigoDestino = Txt_CodigoDestino.Text
        objDestino.idPais = Cmb_Pais.SelectedValue

        _DestinoBll.InsertarDestino(objDestino)

        If objRespuesta.ResponseCode = 1 Then

            MessageBox.Show("Se ha registrado correctamente el destino " & Txt_NombreDestino.Text & " en la base de datos.", "Exitoso")
            Txt_NombreDestino.Text = ""
            Txt_CodigoDestino.Text = ""

        Else
            MessageBox.Show("El destino  " & Txt_NombreDestino.Text & " no se registro correctamente en la base de datos", "Fallido")
        End If
    End Sub

    Private Sub BntCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BntCancelar.Click
        Me.Dispose()
        Me.Close()
        Dim FrmMenuAdmin As New FrmMenuAdministrador
        FrmMenuAdmin.ShowDialog()
    End Sub
End Class