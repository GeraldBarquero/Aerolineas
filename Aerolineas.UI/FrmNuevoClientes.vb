Imports Aerolineas.Entidades
Imports Aerolineas.BLL
Imports Aerolineas.Utilitarios
Imports System.Windows.Forms


Public Class FrmNuevoClientes

#Region "Variables"
    Private objCliente As New OBJETOS.ObjCliente
    Private _clienteBll As New BLL.Clientes.BllCliente
    Private objRespuesta As New OBJETOS.ObjRespuesta

    Public modoPantalla As String = ""

#End Region
    Private Sub FrmClientes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub bnt_Add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bnt_Add.Click
        objCliente.NombreCliente = Txt_NombreCliente.Text
        objCliente.identification = Txt_IdentificacionCliente.Text
        objCliente.direccionExacta = Rtxt_DireccionCliente.Text
        objCliente.Edad = Txt_EdadCliente.Text
        objCliente.telefonoCasa = Txt_TelefonoCasaCliente.Text
        objCliente.telefonoCelular = Txt_TelefonoCelularCliente.Text
        objCliente.email = Txt_EmailCliente.Text
        objCliente.PaisResidencia = "Costa Rica"
        objCliente.password = "123456"

        _clienteBll.InsertarCliente(objCliente)

        If objRespuesta.ResponseCode = 1 Then

            MessageBox.Show("Se ha registrado correctamente el usuario " & Txt_NombreCliente.Text & " en la base de datos.", "Exitoso")
            Txt_NombreCliente.Text = ""
            Txt_IdentificacionCliente.Text = ""
            Rtxt_DireccionCliente.Text = ""
            Txt_EdadCliente.Text = ""
            Txt_TelefonoCasaCliente.Text = ""
            Txt_TelefonoCelularCliente.Text = ""
            Txt_EmailCliente.Text = ""
        Else
            MessageBox.Show("El usuario " & Txt_NombreCliente.Text & " no se registro correctamente en la base de datos", "Fallido")
        End If


    End Sub
End Class