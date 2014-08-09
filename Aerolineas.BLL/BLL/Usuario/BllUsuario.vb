Imports Aerolineas.DAO.DAL.Usuario
Imports Aerolineas.Entidades


Public Class BllUsuario
#Region "Variables"
    Dim UsuarioDao As New DalUsuario
    Dim sql As String = ""
    Public TipoUsuario As String
#End Region

#Region "Procedimientos"
    Public Function ConsultarUsuario(ByVal xObjUsuario As OBJETOS.ObjUsuario) As Boolean
        Dim objRespuesta As New OBJETOS.ObjRespuesta
        Dim resultado As Boolean
        Try
            resultado = UsuarioDao.ConsultarUsuario(xObjUsuario)
            TipoUsuario = UsuarioDao.tipoUsuario
        Catch ex As Exception
            objRespuesta.ResponseCode = 0
            objRespuesta.ResponseMessage = ex.ToString
            objRespuesta.DsResponse = Nothing
        End Try
        Return resultado
    End Function

    Public Function Insertarusuario(ByVal xObjUsuario As OBJETOS.ObjUsuario) As OBJETOS.ObjRespuesta
        Dim objRespuesta As New OBJETOS.ObjRespuesta
        sql = "SpUsuarioInsertar"
        Try
            objRespuesta = UsuarioDao.Insertarusuario(xObjUsuario, sql)
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
            objRespuesta = UsuarioDao.SelectUsuario_All(xObjUsuario)
        Catch ex As Exception
            objRespuesta.ResponseCode = 0
            objRespuesta.ResponseMessage = ex.ToString
            objRespuesta.DsResponse = Nothing
        End Try
        Return objRespuesta
    End Function
#End Region
End Class
