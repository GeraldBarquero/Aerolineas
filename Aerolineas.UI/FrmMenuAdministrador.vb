Public Class FrmMenuAdministrador

    Private Sub FrmMenuAdministrador_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Bnt_LineaAereaAdmin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bnt_LineaAereaAdmin.Click

        Dim frmNuevoLineaAerea As New FrmNuevaLineaAerea
        Me.Hide()
        frmNuevoLineaAerea.ShowDialog()

    End Sub

    Private Sub Bnt_DestinoAdmin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bnt_DestinoAdmin.Click
        Dim frmNuevoDestino As New FrmNuevoDestino
        Me.Hide()
        frmNuevoDestino.ShowDialog()

    End Sub

    Private Sub Bnt_PaisAdmin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bnt_PaisAdmin.Click
        Dim frmNuevoPais As New FrmNuevoPais
        Me.Hide()
        frmNuevoPais.ShowDialog()
    End Sub

    Private Sub Bt_Cliente_Click(sender As System.Object, e As System.EventArgs) Handles Bt_Cliente.Click
        Dim frmNuevoCliente As New FrmNuevoClientes
        Me.Hide()
        frmNuevoCliente.ShowDialog()
    End Sub
End Class