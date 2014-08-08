Imports System.Data.SqlClient


Namespace DAL.Coneccion
    Public Class DalConeccion
        Private _resultado As Boolean
        Public Cone As New SqlConnection()
        Public Function ConectaDb(ByRef mensajeError As String) As Boolean
            Try
                Cone = New SqlConnection(My.MySettings.Default.Conn)
                Cone.Open()
                mensajeError = ""
                _resultado = True
            Catch ex As Exception
                mensajeError = "Error a la hora de conectar a la base de datos. Info Adicional: " + ex.Message
            End Try
            Return _resultado
        End Function
        Public Function DesconectaDb(ByRef mensajeError As String) As Boolean
            Try
                If Cone.State = System.Data.ConnectionState.Open Then
                    Cone.Close()
                    Cone.Dispose()
                    _resultado = False
                End If
            Catch ex As Exception
                mensajeError = "Error a la hora de cerrar la conexion a la base de datos. Info Adicional: " + ex.Message
            End Try
            Return _resultado
        End Function
    End Class
End Namespace

