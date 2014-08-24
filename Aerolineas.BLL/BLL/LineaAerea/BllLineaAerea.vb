Imports Aerolineas.DAO.Dal.LineaAerea
Imports Aerolineas.Entidades

Namespace LineaAerea

    Public Class BllLineaAerea
#Region "Variables"

        Dim LineaAereaDao As New DalLineaAerea
        Dim sql As String = ""

#End Region

#Region "Funciones"


        Public Function InsertarLineaAerea(ByVal xObjLineaAerea As Object) As OBJETOS.ObjRespuesta
            Dim objRespuesta As New OBJETOS.ObjRespuesta
            sql = "SpLineaAereaInsertar"
            Try
                objRespuesta = LineaAereaDao.InsertarLineaAerea(xObjLineaAerea, sql)
            Catch ex As Exception
                objRespuesta.ResponseCode = 0
                objRespuesta.ResponseMessage = ex.ToString
                objRespuesta.DsResponse = Nothing
            End Try
            Return objRespuesta


        End Function

        Public Function ActualizarLineaAerea(ByVal xObjLineaAerea As Object) As OBJETOS.ObjRespuesta
            Dim objRespuesta As New OBJETOS.ObjRespuesta
            sql = "SpLineaAereaActualizar"
            Try
                objRespuesta = LineaAereaDao.ActualizarLineaAerea(xObjLineaAerea, sql)
            Catch ex As Exception
                objRespuesta.ResponseCode = 0
                objRespuesta.ResponseMessage = ex.ToString
                objRespuesta.DsResponse = Nothing
            End Try
            Return objRespuesta


        End Function

        Public Function EliminarLineaAerea(ByVal xObjLineaAerea As Object) As OBJETOS.ObjRespuesta
            Dim objRespuesta As New OBJETOS.ObjRespuesta
            sql = "SpLineaAereaEliminar"
            Try
                objRespuesta = LineaAereaDao.EliminarLineaAerea(xObjLineaAerea, sql)
            Catch ex As Exception
                objRespuesta.ResponseCode = 0
                objRespuesta.ResponseMessage = ex.ToString
                objRespuesta.DsResponse = Nothing
            End Try
            Return objRespuesta
        End Function
        Public Function Select_LineaAereas_All(ByVal xObjLineaAerea As OBJETOS.ObjLineaAerea) As OBJETOS.ObjRespuesta
            Dim objRespuesta As New OBJETOS.ObjRespuesta
            Try

                objRespuesta = LineaAereaDao.Select_LineaAereas_All(xObjLineaAerea)
            Catch ex As Exception
                objRespuesta.ResponseCode = 0
                objRespuesta.ResponseMessage = ex.ToString
                objRespuesta.DsResponse = Nothing
            End Try
            Return objRespuesta
        End Function
        Public Function Obtener_LineaAereas(ByVal xObjLineaAerea As OBJETOS.ObjLineaAerea) As OBJETOS.ObjRespuesta
            Dim objRespuesta As New OBJETOS.ObjRespuesta
            Try

                objRespuesta = LineaAereaDao.Obtener_LineaAereas(xObjLineaAerea)
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