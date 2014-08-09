Imports Aerolineas.Entidades
Imports System.Data
Imports System.Data.SqlClient

Namespace DAL.Usuario

    Public Class DalUsuario

#Region "Variables"
        Private _conectar As New DAL.Coneccion.DalConeccion
        Private _mensajeError As String = ""
        Private _sql As String = ""
        Private _ejecutar As New Ejecutar.Ejecutar
        Public tipoUsuario As String
#End Region

#Region "Funciones"

        Public Function ConsultarUsuario(ByVal xObjUsuario As OBJETOS.ObjUsuario) As Boolean
            Dim objRespuesta As New OBJETOS.ObjRespuesta

            Try
                _conectar.ConectaDb(_mensajeError)
                _sql = "SpUsuarioObtener"
                Dim cmd As New SqlCommand(_sql, _conectar.Cone)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@Username", xObjUsuario.Username)
                cmd.Parameters.AddWithValue("@Password", xObjUsuario.Password)
                'Dim myType As Type = GetType(OBJETOS.ObjUsuario)
                Dim dr As SqlDataReader
                dr = cmd.ExecuteReader()
                While dr.Read()
                    tipoUsuario = dr.Item("TipoUsuario")
                End While
                If dr.HasRows = True Then
                    Return True
                Else
                    Return False
                End If
            Catch ex As Exception
                objRespuesta.ResponseCode = 0
                objRespuesta.ResponseMessage = ex.ToString
                objRespuesta.DsResponse = Nothing
                Return False
            End Try
        End Function

        Public Function Insertarusuario(ByVal xObjUsuario As Object, ByVal sql As String) As OBJETOS.ObjRespuesta
            Dim objRespuesta As New OBJETOS.ObjRespuesta

            Try
                objRespuesta = _ejecutar.SQL_Ejecuta_SentenciaInsert_Update_Delete(xObjUsuario, sql, _mensajeError)
            Catch ex As Exception
                objRespuesta.ResponseCode = 0
                objRespuesta.ResponseMessage = ex.ToString
                objRespuesta.DsResponse = Nothing

            End Try
            Return objRespuesta
        End Function

        Public Function SelectUsuario_All(ByVal xObjUsuario As OBJETOS.ObjUsuario) As OBJETOS.ObjRespuesta
            Dim objRespuesta As New OBJETOS.ObjRespuesta
            Try
                _sql = "SpUsuarioListar"
                objRespuesta = _ejecutar.SQL_Ejecuta_Sentencia(xObjUsuario, _sql, _mensajeError)
            Catch ex As Exception
                objRespuesta.ResponseCode = 0
                objRespuesta.ResponseMessage = ex.ToString
                objRespuesta.DsResponse = Nothing
            End Try
            Return objRespuesta
        End Function
#End Region
    End Class
End Namespace