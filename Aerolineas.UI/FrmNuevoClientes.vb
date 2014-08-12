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
        If VerificarCampos() = True Then
            objCliente.NombreCliente = Txt_NombreCliente.Text
            objCliente.identification = Txt_IdentificacionCliente.Text
            objCliente.direccionExacta = Rtxt_DireccionCliente.Text
            objCliente.Edad = Txt_EdadCliente.Text
            objCliente.telefonoCasa = Txt_TelefonoCasaCliente.Text
            objCliente.telefonoCelular = Txt_TelefonoCelularCliente.Text
            objCliente.email = Txt_EmailCliente.Text
            objCliente.PaisResidencia = Txt_PaisResidenciaCliente.Text
            objCliente.password = Txt_PasswordCliente.Text
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
        Else
            Exit Sub
        End If
    End Sub
    Private Sub ValidarLetrasNumeros(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txt_EdadCliente.KeyPress, Txt_IdentificacionCliente.KeyPress, Txt_NombreCliente.KeyPress, Txt_PaisResidenciaCliente.KeyPress, Txt_TelefonoCasaCliente.KeyPress, Txt_TelefonoCelularCliente.KeyPress
        Select Case sender.name
            Case "Txt_NombreCliente", "Txt_PaisResidenciaCliente"
                e.KeyChar = Chr(SoloLetras(Asc(e.KeyChar)))
            Case "Txt_EdadCliente", "Txt_TelefonoCasaCliente", "Txt_TelefonoCelularCliente"
                e.KeyChar = Chr(SoloNumeros(Asc(e.KeyChar)))
        End Select
    End Sub
    Private Function VerificarCampos() As Boolean
        If Len(Txt_NombreCliente.Text.Trim) = 0 Then MsgBox("Verifica el campo Nombre", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Ayuda") : Txt_NombreCliente.Focus() : Exit Function
        If Len(Txt_IdentificacionCliente.Text.Trim) = 0 Then MsgBox("Verifica el campo Identificación", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Ayuda") : Txt_IdentificacionCliente.Focus() : Exit Function
        If Len(Txt_PasswordCliente.Text.Trim) = 0 Then MsgBox("Verifica el campo Password", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Ayuda") : Txt_PasswordCliente.Focus() : Exit Function
        If Len(Txt_PaisResidenciaCliente.Text.Trim) = 0 Then MsgBox("Verifica el campo Pais de Residencia", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Ayuda") : Txt_PaisResidenciaCliente.Focus() : Exit Function
        If Len(Rtxt_DireccionCliente.Text.Trim) = 0 Then MsgBox("Verifica el campo Dirección", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Ayuda") : Rtxt_DireccionCliente.Focus() : Exit Function
        If Len(Txt_EdadCliente.Text.Trim) = 0 Then MsgBox("Verifica el campo Edad", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Ayuda") : Txt_EdadCliente.Focus() : Exit Function
        If Len(Txt_TelefonoCasaCliente.Text.Trim) = 0 Then MsgBox("Verifica el campo Teléfono de Casa", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Ayuda") : Txt_TelefonoCasaCliente.Focus() : Exit Function
        If Len(Txt_TelefonoCelularCliente.Text.Trim) = 0 Then MsgBox("Verifica el campo Teléfono Celular", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Ayuda") : Txt_TelefonoCelularCliente.Focus() : Exit Function
        If Len(Txt_EmailCliente.Text.Trim) = 0 Then MsgBox("Verifica el campo Email", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Ayuda") : Txt_EmailCliente.Focus() : Exit Function
        Return True
    End Function

    Private Sub BntCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BntCancelar.Click
        Me.Dispose()
        Me.Close()
        Dim FrmMenuAdmin As New FrmMenuAdministrador
        FrmMenuAdmin.ShowDialog()
    End Sub
End Class