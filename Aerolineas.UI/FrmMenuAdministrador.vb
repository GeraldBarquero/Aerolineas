Public Class FrmMenuAdministrador

#Region "Variables"
    Dim frmNuevoLineaAerea As New FrmNuevaLineaAerea
    Dim frmNuevoDestino As New FrmNuevoDestino
    Dim frmNuevoPais As New FrmNuevoPais
    Dim frmNuevoCliente As New FrmNuevoClientes
    Dim frmNuevoVuelo As New FrmNuevoVuelo
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