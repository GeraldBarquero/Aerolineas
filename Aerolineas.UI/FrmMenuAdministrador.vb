Public Class FrmMenuAdministrador

#Region "Variables"
    Dim frmNuevoLineaAerea As New FrmMenuLineaAerea
    Dim frmNuevoDestino As New FrmMenuDestino
    Dim frmNuevoPais As New FrmMenuPais
    Dim frmNuevoCliente As New FrmMenuClientes
    Dim frmNuevoVuelo As New FrmMenuVuelo
#End Region

    Private Sub Bnt_LineaAereaAdmin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bnt_LineaAereaAdmin.Click
        Me.Hide()
        frmNuevoLineaAerea.ShowDialog()
        Me.Show()
    End Sub

    Private Sub Bnt_DestinoAdmin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bnt_DestinoAdmin.Click
        Me.Hide()
        frmNuevoDestino.ShowDialog()
        Me.Show()
    End Sub

    Private Sub Bnt_PaisAdmin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bnt_PaisAdmin.Click
        Me.Hide()
        frmNuevoPais.ShowDialog()
        Me.Show()
    End Sub

    Private Sub Bt_Cliente_Click(sender As System.Object, e As System.EventArgs) Handles Bt_Cliente.Click
        Me.Hide()
        frmNuevoCliente.ShowDialog()
        Me.Show()
    End Sub

    Private Sub Bnt_Vuelo_Click(sender As System.Object, e As System.EventArgs) Handles Bnt_Vuelo.Click
        Me.Hide()
        frmNuevoVuelo.ShowDialog()
        Me.Show()
    End Sub
End Class