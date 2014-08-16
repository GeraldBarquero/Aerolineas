Imports Aerolineas.DAO.DAL.Pais
Imports Aerolineas.Entidades

Public Class BllPais

#Region "Variables"
    Dim PaisDao As New DalPais
    Dim sql As String = ""
#End Region

#Region "Functions"
    Public Function InsertarPais(ByVal xObjPais As OBJETOS.ObjPais) As OBJETOS.ObjRespuesta
        Dim objRespuesta As New OBJETOS.ObjRespuesta
        sql = "SpPaisInsertar"
        Try
            objRespuesta = PaisDao.InsertarPais(xObjPais, sql)
        Catch ex As Exception
            objRespuesta.ResponseCode = 0
            objRespuesta.ResponseMessage = ex.ToString
            objRespuesta.DsResponse = Nothing
        End Try
        Return objRespuesta
    End Function

    Public Function ActualizarPais(ByVal xObjPais As OBJETOS.ObjPais) As OBJETOS.ObjRespuesta
        Dim objRespuesta As New OBJETOS.ObjRespuesta
        sql = "SpPaisActualizar"
        Try
            objRespuesta = PaisDao.ActualizarPais(xObjPais, sql)
        Catch ex As Exception
            objRespuesta.ResponseCode = 0
            objRespuesta.ResponseMessage = ex.ToString
            objRespuesta.DsResponse = Nothing
        End Try
        Return objRespuesta
    End Function


    Public Function EliminarPais(ByVal xObjPais As OBJETOS.ObjPais) As OBJETOS.ObjRespuesta
        Dim objRespuesta As New OBJETOS.ObjRespuesta
        sql = "SpPaisEliminar"
        Try
            objRespuesta = PaisDao.EliminarPais(xObjPais, sql)
        Catch ex As Exception
            objRespuesta.ResponseCode = 0
            objRespuesta.ResponseMessage = ex.ToString
            objRespuesta.DsResponse = Nothing
        End Try
        Return objRespuesta
    End Function

    Public Function Select_Pais_All(ByVal xObjPais As OBJETOS.ObjPais) As OBJETOS.ObjRespuesta
        Dim objRespuesta As New OBJETOS.ObjRespuesta
        Try
            objRespuesta = PaisDao.Select_Pais_All(xObjPais)
        Catch ex As Exception
            objRespuesta.ResponseCode = 0
            objRespuesta.ResponseMessage = ex.ToString
            objRespuesta.DsResponse = Nothing
        End Try
        Return objRespuesta
    End Function
#End Region
End Class
