Imports Aerolineas.DAO.DAL.Destino
Imports Aerolineas.Entidades

Namespace Destino


    Public Class BllDestino

#Region "Variables"
        Dim DestinoDao As New DalDestino
        Dim sql As String = ""
#End Region

#Region "Funciones"

        Public Function InsertarDestino(ByVal xObjDestino As OBJETOS.ObjDestino) As OBJETOS.ObjRespuesta
            Dim objRespuesta As New OBJETOS.ObjRespuesta
            sql = "SpDestinoInsertar"
            Try
                objRespuesta = DestinoDao.InsertarDestino(xObjDestino, sql)
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