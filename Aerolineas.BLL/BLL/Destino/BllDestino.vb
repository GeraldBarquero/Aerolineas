Imports Aerolineas.DAO.DAL.Destino
Imports Aerolineas.Entidades

Namespace Destino


    Public Class BllDestino

#Region "Variables"

        ''InsertarDestino
        Dim DestinoDao As New DalDestino
        Dim sql As String = ""

        ''Select_LineaAereas_All
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

        Public Function ActualizarDestino(ByVal xObjDestino As OBJETOS.ObjDestino) As OBJETOS.ObjRespuesta
            Dim objRespuesta As New OBJETOS.ObjRespuesta
            sql = "SpDestinoActualizar"
            Try
                objRespuesta = DestinoDao.actualizarDestino(xObjDestino, sql)
            Catch ex As Exception
                objRespuesta.ResponseCode = 0
                objRespuesta.ResponseMessage = ex.ToString
                objRespuesta.DsResponse = Nothing

            End Try
            Return objRespuesta


        End Function

        Public Function EliminarDestino(ByVal xObjDestino As OBJETOS.ObjDestino) As OBJETOS.ObjRespuesta
            Dim objRespuesta As New OBJETOS.ObjRespuesta
            sql = "SpDestinoEliminar"
            Try
                objRespuesta = DestinoDao.EliminarDestino(xObjDestino, sql)
            Catch ex As Exception
                objRespuesta.ResponseCode = 0
                objRespuesta.ResponseMessage = ex.ToString
                objRespuesta.DsResponse = Nothing

            End Try
            Return objRespuesta


        End Function

        Public Function Select_Destino_All(ByVal xObjDestino As OBJETOS.ObjDestino) As OBJETOS.ObjRespuesta
            Dim objRespuesta As New OBJETOS.ObjRespuesta
            Try

                objRespuesta = DestinoDao.Select_Destino_All(xObjDestino)
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