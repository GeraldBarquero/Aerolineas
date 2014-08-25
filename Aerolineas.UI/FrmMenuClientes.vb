Imports Aerolineas.Entidades
Imports Aerolineas.BLL
Imports Aerolineas.Utilitarios
Imports System.Windows.Forms
Imports System.Data


Public Class FrmMenuClientes

#Region "Variables"
    Private objCliente As New OBJETOS.ObjCliente
    Private _clienteBll As New BLL.Clientes.BllCliente
    Private objRespuesta As New OBJETOS.ObjRespuesta
    Public modoPantalla As String = ""
    Public _CodigoCliente As Integer = 0
    Private _dsCliente As New DataSet

#End Region
    Private Sub FrmClientes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        datosIniciales()
        If modoPantalla = "Eliminar" Then
            Bnt_Aceptar.Text = "Aceptar"
            Txt_NombreCliente.Enabled = False
            Txt_IdentificacionCliente.Enabled = False
            Rtxt_DireccionCliente.Enabled = False
            Txt_EdadCliente.Enabled = False
            Txt_TelefonoCasaCliente.Enabled = False
            Txt_TelefonoCelularCliente.Enabled = False
            Txt_EmailCliente.Enabled = False
            Txt_PasswordCliente.Enabled = False
            Txt_PaisResidenciaCliente.Enabled = False
            Bnt_ModifcarCliente.Hide()
            Bnt_EliminarCliente.Hide()
            cargarDatos()
        ElseIf modoPantalla = "Actualizar" Then
            Bnt_Aceptar.Text = "Aceptar"
            Bnt_ModifcarCliente.Hide()
            Bnt_EliminarCliente.Hide()
            cargarDatos()
        Else
            Bnt_Aceptar.Text = "Insertar"
        End If
    End Sub
    Sub datosIniciales()
        Try
            objRespuesta = _clienteBll.Select_Cliente_All(objCliente)
            _dsCliente = Utilitarios.UTL.Utilitarios.Utilitarios.UnzipDataSet(objRespuesta.ByteResponseObject)
            Dgv_ListaClientes.DataSource = _dsCliente.Tables(0)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Bnt_Add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bnt_Aceptar.Click

        If modoPantalla = "Eliminar" Then
            objCliente.NombreCliente = Txt_NombreCliente.Text
            objCliente.Identification = Txt_IdentificacionCliente.Text
            objCliente.DireccionExacta = Rtxt_DireccionCliente.Text
            objCliente.Edad = Txt_EdadCliente.Text
            objCliente.TelefonoCasa = Txt_TelefonoCasaCliente.Text
            objCliente.TelefonoCelular = Txt_TelefonoCelularCliente.Text
            objCliente.Email = Txt_EmailCliente.Text
            objCliente.PaisResidencia = Txt_PaisResidenciaCliente.Text
            objCliente.Password = Txt_PasswordCliente.Text
            objRespuesta = _clienteBll.EliminarCliente(objCliente)
            If objRespuesta.ResponseCode = 1 Then
                MessageBox.Show("Se ha Eliminado correctamente el cliente " & Txt_NombreCliente.Text & " en la base de datos.", "Exitoso")
                Me.Close()
                Me.Dispose()
                Dim frmMenuCliente As New FrmMenuClientes
                frmMenuCliente.ShowDialog()
            Else
                MessageBox.Show("El cliente  " & Txt_NombreCliente.Text & " no se Eliminado correctamente en la base de datos", "Fallido")
            End If
        ElseIf modoPantalla = "Actualizar" Then
            objCliente.NombreCliente = Txt_NombreCliente.Text
            objCliente.Identification = Txt_IdentificacionCliente.Text
            objCliente.DireccionExacta = Rtxt_DireccionCliente.Text
            objCliente.Edad = Txt_EdadCliente.Text
            objCliente.TelefonoCasa = Txt_TelefonoCasaCliente.Text
            objCliente.TelefonoCelular = Txt_TelefonoCelularCliente.Text
            objCliente.Email = Txt_EmailCliente.Text
            objCliente.PaisResidencia = Txt_PaisResidenciaCliente.Text
            objCliente.Password = Txt_PasswordCliente.Text
            objRespuesta = _clienteBll.ActualizarCliente(objCliente)
            If objRespuesta.ResponseCode = 1 Then
                MessageBox.Show("Se ha Modificado correctamente el cliente " & Txt_NombreCliente.Text & " en la base de datos.", "Exitoso")
                Me.Close()
                Me.Dispose()
                Dim frmMenuCliente As New FrmMenuClientes
                frmMenuCliente.ShowDialog()
            Else
                MessageBox.Show("El cliente  " & Txt_NombreCliente.Text & " no se Modificado correctamente en la base de datos", "Fallido")
            End If
        Else
            If VerificarCampos() = True Then
                objCliente.NombreCliente = Txt_NombreCliente.Text
                objCliente.Identification = Txt_IdentificacionCliente.Text
                objCliente.DireccionExacta = Rtxt_DireccionCliente.Text
                objCliente.Edad = Txt_EdadCliente.Text
                objCliente.TelefonoCasa = Txt_TelefonoCasaCliente.Text
                objCliente.TelefonoCelular = Txt_TelefonoCelularCliente.Text
                objCliente.Email = Txt_EmailCliente.Text
                objCliente.PaisResidencia = Txt_PaisResidenciaCliente.Text
                objCliente.Password = Txt_PasswordCliente.Text
                objRespuesta = _clienteBll.InsertarCliente(objCliente)
                If objRespuesta.ResponseCode = 1 Then
                    MessageBox.Show("Se ha registrado correctamente el usuario " & Txt_NombreCliente.Text & " en la base de datos.", "Exitoso")
                    Txt_NombreCliente.Text = ""
                    Txt_IdentificacionCliente.Text = ""
                    Rtxt_DireccionCliente.Text = ""
                    Txt_EdadCliente.Text = ""
                    Txt_TelefonoCasaCliente.Text = ""
                    Txt_TelefonoCelularCliente.Text = ""
                    Txt_EmailCliente.Text = ""
                    Txt_PasswordCliente.Text = ""
                    Txt_PaisResidenciaCliente.Text = ""
                Else
                    MessageBox.Show("El usuario " & Txt_NombreCliente.Text & " no se registro correctamente en la base de datos", "Fallido")
                End If
            Else
                Exit Sub
            End If
        End If
        datosIniciales()
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
        If Len(Txt_NombreCliente.Text.Trim) = 0 Then
            MsgBox("Verifica el campo Nombre.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Ayuda")
            Txt_NombreCliente.Focus()
            Return False
            Exit Function
        End If
        If Len(Txt_IdentificacionCliente.Text.Trim) = 0 Then
            MsgBox("Verifica el campo Identificación.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Ayuda")
            Txt_IdentificacionCliente.Focus()
            Return False
            Exit Function
        End If
        If Len(Txt_PasswordCliente.Text.Trim) = 0 Then
            MsgBox("Verifica el campo Password.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Ayuda")
            Txt_PasswordCliente.Focus()
            Return False
            Exit Function
        End If
        If Len(Txt_PaisResidenciaCliente.Text.Trim) = 0 Then
            MsgBox("Verifica el campo Pais de Residencia.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Ayuda")
            Txt_PaisResidenciaCliente.Focus()
            Return False
            Exit Function
        End If
        If Len(Rtxt_DireccionCliente.Text.Trim) = 0 Then
            MsgBox("Verifica el campo Dirección.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Ayuda")
            Rtxt_DireccionCliente.Focus()
            Return False
            Exit Function
        End If
        If Len(Txt_EdadCliente.Text.Trim) = 0 Then
            MsgBox("Verifica el campo Edad.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Ayuda") : Txt_EdadCliente.Focus()
            Return False
            Exit Function
        ElseIf Txt_EdadCliente.Text.Trim > 150 Then
            MsgBox("Verifica el campo Edad, no puede ser mayor a 150 años.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Ayuda") : Txt_EdadCliente.Focus()
            Return False
            Exit Function
        End If
        If Len(Txt_TelefonoCasaCliente.Text.Trim) = 0 Then
            MsgBox("Verifica el campo Teléfono de Casa.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Ayuda") : Txt_TelefonoCasaCliente.Focus()
            Return False
            Exit Function
        End If
        If Len(Txt_TelefonoCelularCliente.Text.Trim) = 0 Then
            MsgBox("Verifica el campo Teléfono Celular.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Ayuda") : Txt_TelefonoCelularCliente.Focus()
            Return False
            Exit Function
        End If
        If Len(Txt_EmailCliente.Text.Trim) = 0 Then
            MsgBox("Verifica el campo Email.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Ayuda") : Txt_EmailCliente.Focus()
            Return False
            Exit Function
        End If
        Return True
    End Function

    Private Sub BntCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BntCancelar.Click
        Txt_NombreCliente.Text = ""
        Txt_IdentificacionCliente.Text = ""
        Rtxt_DireccionCliente.Text = ""
        Txt_EdadCliente.Text = ""
        Txt_TelefonoCasaCliente.Text = ""
        Txt_TelefonoCelularCliente.Text = ""
        Txt_EmailCliente.Text = ""
        Txt_PasswordCliente.Text = ""
        Txt_PaisResidenciaCliente.Text = ""
        Me.Close()
    End Sub


    Private Sub Bnt_EliminarCliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bnt_EliminarCliente.Click
        Dim frmCliente As New FrmMenuClientes
        Try
            If Dgv_ListaClientes.SelectedRows.Count > 0 Then
                frmCliente.modoPantalla = "Eliminar"
                frmCliente._CodigoCliente = Dgv_ListaClientes.SelectedRows(0).Cells(0).Value
                Me.Hide()
                frmCliente.ShowDialog()
            Else
                MessageBox.Show("Debe seleccionar un Cliente para poder eliminarlo de la Base de datos ")
            End If
        Catch ex As Exception
        End Try
        datosIniciales()
    End Sub

    Private Sub Bnt_ModificarCliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bnt_ModifcarCliente.Click
        Dim frmCliente As New FrmMenuClientes
        Try
            If Dgv_ListaClientes.SelectedRows.Count > 0 Then
                frmCliente.modoPantalla = "Actualizar"
                frmCliente._CodigoCliente = Dgv_ListaClientes.SelectedRows(0).Cells(0).Value
                Me.Hide()
                frmCliente.ShowDialog()
            Else
                MessageBox.Show("Debe seleccionar un Cliente para poder modificarlo")
            End If
        Catch ex As Exception
        End Try
        datosIniciales()
    End Sub

    Sub cargarDatos()
        objCliente.IdCliente = _CodigoCliente
        Dim objRespuesta As New OBJETOS.ObjRespuesta
        objRespuesta = _clienteBll.Consultar_Cliente(objCliente)
        _dsCliente = Nothing
        _dsCliente = Utilitarios.UTL.Utilitarios.Utilitarios.UnzipDataSet(objRespuesta.ByteResponseObject)
        Try
            If _dsCliente.Tables(0).Rows.Count > 0 Then
                For Each row In _dsCliente.Tables(0).Rows
                    Txt_NombreCliente.Text = row("NombreCliente")
                    Txt_IdentificacionCliente.Text = row("Identification")
                    Rtxt_DireccionCliente.Text = row("DireccionExacta")
                    Txt_EdadCliente.Text = row("Edad")
                    Txt_TelefonoCasaCliente.Text = row("TelefonoCasa")
                    Txt_TelefonoCelularCliente.Text = row("TelefonoCelular")
                    Txt_EmailCliente.Text = row("Email")
                    Txt_PaisResidenciaCliente.Text = row("PaisResidencia")
                    Txt_PasswordCliente.Text = row("Password")

                Next
            Else
                MessageBox.Show("la consulta no produjo resultados, sin resultados")
            End If
        Catch ex As Exception
        End Try
    End Sub

End Class