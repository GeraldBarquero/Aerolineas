Imports Aerolineas.DAO.DAL
Imports Aerolineas.Entidades

Public Class BllVuelo
#Region "Variables"
    Dim VueloDao As New Vuelo.DalVuelo
    Dim sql As String = ""
#End Region

#Region "Procedimientos"

    Public Function Select_Vuelo_All(ByVal xObjVuelo As OBJETOS.ObjVuelo) As OBJETOS.ObjRespuesta
        Dim objRespuesta As New OBJETOS.ObjRespuesta
        Try

            objRespuesta = VueloDao.Select_Vuelo_All(xObjVuelo)
        Catch ex As Exception
            objRespuesta.ResponseCode = 0
            objRespuesta.ResponseMessage = ex.ToString
            objRespuesta.DsResponse = Nothing
        End Try
        Return objRespuesta
    End Function

    Public Function InsertarVuelo(ByVal xObjVuelo As OBJETOS.ObjVuelo) As OBJETOS.ObjRespuesta
        Dim objRespuesta As New OBJETOS.ObjRespuesta
        sql = "SpVueloInsertar"
        Try
            objRespuesta = VueloDao.InsertarVuelo(xObjVuelo, sql)
        Catch ex As Exception
            objRespuesta.ResponseCode = 0
            objRespuesta.ResponseMessage = ex.ToString
            objRespuesta.DsResponse = Nothing

        End Try
        Return objRespuesta


    End Function

    Public Function ActualizarVuelo(ByVal xObjVuelo As OBJETOS.ObjVuelo) As OBJETOS.ObjRespuesta
        Dim objRespuesta As New OBJETOS.ObjRespuesta
        sql = "SpVueloActualizar"
        Try
            objRespuesta = VueloDao.actualizarVuelo(xObjVuelo, sql)
        Catch ex As Exception
            objRespuesta.ResponseCode = 0
            objRespuesta.ResponseMessage = ex.ToString
            objRespuesta.DsResponse = Nothing

        End Try
        Return objRespuesta


    End Function

    Public Function EliminarVuelo(ByVal xObjVuelo As OBJETOS.ObjVuelo) As OBJETOS.ObjRespuesta
        Dim objRespuesta As New OBJETOS.ObjRespuesta
        sql = "SpVueloEliminar"
        Try
            objRespuesta = VueloDao.EliminarVuelo(xObjVuelo, sql)
        Catch ex As Exception
            objRespuesta.ResponseCode = 0
            objRespuesta.ResponseMessage = ex.ToString
            objRespuesta.DsResponse = Nothing

        End Try
        Return objRespuesta
    End Function

    Public Function Consultar_Vuelo(ByVal xObjConsultarVuelo As OBJETOS.ObjConsultarVuelo) As OBJETOS.ObjRespuesta
        Dim objRespuesta As New OBJETOS.ObjRespuesta
        Try

            objRespuesta = VueloDao.Consultar_Vuelo(xObjConsultarVuelo)
        Catch ex As Exception
            objRespuesta.ResponseCode = 0
            objRespuesta.ResponseMessage = ex.ToString
            objRespuesta.DsResponse = Nothing
        End Try
        Return objRespuesta
    End Function
#End Region
End Class
