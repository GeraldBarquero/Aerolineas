Imports Aerolineas.DAO.DAL.LineaArea_Destino
Imports Aerolineas.Entidades

Namespace LineaArea_Destino
    Public Class BllLineaAerea_Destino
#Region "Variables"

        Dim LineaAereaDestinoDao As New DalLineaAerea_Destino
        Dim sql As String = ""

#End Region

#Region "Procedimientos"
        Public Function InsertarLineaAerea(ByVal xObjLineaAereaDestino As Object) As OBJETOS.ObjRespuesta
            Dim objRespuesta As New OBJETOS.ObjRespuesta
            sql = "SpLineaAerea_DestinoInsertar"
            Try
                objRespuesta = LineaAereaDestinoDao.InsertarLineaAerea_Destino(xObjLineaAereaDestino, sql)
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
