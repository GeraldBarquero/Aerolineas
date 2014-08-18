
Public Class FrmMenuPClientes

    Private Sub Btn_Reportes_Click(sender As System.Object, e As System.EventArgs) Handles Btn_Reportes.Click
        Dim frmReportes As New FrmMenuReportes
        Me.Hide()
        frmReportes.ShowDialog()
        Me.Show()
    End Sub

    Private Sub Btn_BuscarVuelo_Click(sender As System.Object, e As System.EventArgs) Handles Btn_BuscarVuelo.Click
        Dim frmBuscarVuelo As New FrmBusquedaVuelos
        Me.Hide()
        frmBuscarVuelo.ShowDialog()
        Me.Show()
    End Sub

    Private Sub Btn_Salir_Click(sender As System.Object, e As System.EventArgs) Handles Btn_Salir.Click
        Me.Close()
    End Sub
End Class