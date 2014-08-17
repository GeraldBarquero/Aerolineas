Imports Aerolineas.Entidades
Imports Aerolineas.BLL
Imports Aerolineas.Utilitarios
Imports System.Windows.Forms
Imports System.Data
Public Class FrmMenuPais

#Region "Variables"


    Private objPais As New OBJETOS.ObjPais
    Private _PaisBll As New BLL.BllPais
    Private objRespuesta As New OBJETOS.ObjRespuesta
    Private _ds As New DataSet
    Public modoPantalla As String = ""
    Public _codigoPais As Integer = 0

#End Region

#Region "Sub"


    Sub datosIniciales()
        Try
            objRespuesta = _PaisBll.Select_Pais_All(objPais)
            _ds = Utilitarios.UTL.Utilitarios.Utilitarios.UnzipDataSet(objRespuesta.ByteResponseObject)
            Dgv_ListaPais.DataSource = _ds.Tables(0)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub FrmNuevoPais_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        datosIniciales()
        If modoPantalla = "Eliminar" Then

            Bt_Aceptar.Text = "Aceptar"
            Lb_MensajeConfimaicion.Text = "¿Seguro que decia eliminar un Pais?"
            Txt_Pais.Text = False
            Bnt_ConsultarPais.Hide()
            Bnt_ModificarPais.Hide()
            Bnt_EliminarPais.Hide()
            Dgv_ListaPais.Hide()
            cargarDatos()
        ElseIf modoPantalla = "Actualizar" Then
            Bt_Aceptar.Text = "Aceptar"
            Bnt_ConsultarPais.Hide()
            Bnt_ModificarPais.Hide()
            Bnt_EliminarPais.Hide()
            cargarDatos()
            'ElseIf modoPantalla = "Modificar" Then
            '    Bt_Aceptar.Text = "Aceptar"
            '    Bnt_ConsultarPais.Hide()
            '    Bnt_ModificarPais.Hide()
            '    Bnt_EliminarPais.Hide()
        Else
            Bt_Aceptar.Text = "Insertar"

        End If

    End Sub


    Private Sub Bt_Aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bt_Aceptar.Click

        If modoPantalla = "Eliminar" Then
            objPais.nombrePais = Txt_Pais.Text
            objRespuesta = _PaisBll.EliminarPais(objPais)

            If objRespuesta.ResponseCode = 1 Then
                MessageBox.Show("Se ha Eliminado correctamente el país " & Txt_Pais.Text & " en la base de datos.", "Exitoso")
                Me.Close()
                Me.Dispose()
                Dim frmMenuPais As New FrmMenuPais
                frmMenuPais.ShowDialog()
            Else
                MessageBox.Show("El país  " & Txt_Pais.Text & " no se Eliminado correctamente en la base de datos", "Fallido")
            End If

        ElseIf modoPantalla = "Actualizar" Then
            objPais.nombrePais = Txt_Pais.Text
            objRespuesta = _PaisBll.ActualizarPais(objPais)
            If objRespuesta.ResponseCode = 1 Then
                MessageBox.Show("Se ha Modificado correctamente el país " & Txt_Pais.Text & " en la base de datos.", "Exitoso")
                Me.Close()
                Me.Dispose()
                Dim frmMenuPais As New FrmMenuPais
                frmMenuPais.ShowDialog()
            Else
                MessageBox.Show("El país  " & Txt_Pais.Text & " no se Modificado correctamente en la base de datos", "Fallido")
            End If


        ElseIf modoPantalla = "Consultar" Then
            'objPais.nombrePais = Txt_Pais.Text
            '''objRespuesta = _PaisBll.Pais(objPais)
            'If objRespuesta.ResponseCode = 1 Then
            '    MessageBox.Show("Se ha Consultar correctamente el país " & Txt_Pais.Text & " en la base de datos.", "Exitoso")
            '    Me.Close()
            '    Me.Dispose()
            '    Dim frmMenuPais As New FrmNuevoPais
            '    frmMenuPais.ShowDialog()
            'Else
            '    MessageBox.Show("El país  " & Txt_Pais.Text & " no se Modificado correctamente en la base de datos", "Fallido")
            'End If
        Else
            objPais.nombrePais = Txt_Pais.Text
            objRespuesta = _PaisBll.InsertarPais(objPais)
            If objRespuesta.ResponseCode = 1 Then
                MessageBox.Show("Se ha registrado correctamente el país " & Txt_Pais.Text & " en la base de datos.", "Exitoso")
                Me.Close()
                Me.Dispose()
                Dim frmMenuPais As New FrmMenuPais
                FrmMenuPais.ShowDialog()
            Else
                MessageBox.Show("El país  " & Txt_Pais.Text & " no se registro correctamente en la base de datos", "Fallido")
            End If
        End If
    End Sub


    Private Sub ValidarLetrasNumeros(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txt_Pais.KeyPress
        e.KeyChar = Chr(SoloLetras(Asc(e.KeyChar)))
    End Sub

    Private Function VerificarCampos() As Boolean
        If Len(Txt_Pais.Text.Trim) = 0 Then
            MsgBox("Verifica el campo Nombre", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Ayuda")
            Txt_Pais.Focus()
            Return False
            Exit Function
        End If
        Return True
    End Function

    Private Sub BntCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BntCancelar.Click
        Me.Dispose()
        Me.Close()
        Dim FrmMenuPais As New FrmMenuPais
        FrmMenuPais.ShowDialog()
    End Sub

    Private Sub Bnt_EliminarPais_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bnt_EliminarPais.Click
        Dim frmMenuPais As New FrmMenuPais
        Try
            If Dgv_ListaPais.SelectedRows.Count > 0 Then
                frmMenuPais.modoPantalla = "Eliminar"
                frmMenuPais._codigoPais = Dgv_ListaPais.SelectedRows(0).Cells(0).Value
                Me.Hide()
                frmMenuPais.ShowDialog()
            End If
            MessageBox.Show("Debe selecciona un pais para poder eliminarlo de la Base de datos ")
        Catch ex As Exception
        End Try
    End Sub


    Private Sub Bnt_ModificarPais_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bnt_ModificarPais.Click
        Dim frmMenuPais As New FrmMenuPais
        Try
            If Dgv_ListaPais.SelectedRows.Count > 0 Then
                frmMenuPais.modoPantalla = "Actualizar"
                frmMenuPais._codigoPais = Dgv_ListaPais.SelectedRows(0).Cells(0).Value
                Me.Hide()
                frmMenuPais.ShowDialog()
            End If
            MessageBox.Show("Debe selecciona un pais para poder 'Modificarlos de la Base de datos ")
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Bnt_ConsultarPais_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bnt_ConsultarPais.Click
        Dim frmMenuPais As New FrmMenuPais
        Try
            frmMenuPais.modoPantalla = "Consultar"
            Me.Hide()
            frmMenuPais.ShowDialog()
            Me.Dispose()
        Catch ex As Exception

        End Try


    End Sub


    Sub cargarDatos()
        objPais.idPais = _codigoPais
        Dim objRespuesta As New OBJETOS.ObjRespuesta
        objRespuesta = _PaisBll.Select_Pais_All(objPais)
        _ds = Nothing
        _ds = Utilitarios.UTL.Utilitarios.Utilitarios.UnzipDataSet(objRespuesta.ByteResponseObject)
        Try
            If _ds.Tables(0).Rows.Count > 0 Then
                For Each row In _ds.Tables(0).Rows
                    Txt_Pais.Text = row("NombrePais")
                Next
            Else
                MessageBox.Show("la consulta o produjo resultados, sin resultados")
            End If
        Catch ex As Exception


        End Try
    End Sub
#End Region

End Class


