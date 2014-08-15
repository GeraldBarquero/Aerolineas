Imports Aerolineas.Entidades
Namespace DAL.LineaArea_Destino

    Public Class DalLineaAerea_Destino
#Region "Variables"
        Private _ejecutar As New Ejecutar.Ejecutar
        Private _mensajeError As String = ""
        Private _sql = ""
#End Region

#Region "Funciones"

        Public Function InsertarLineaAerea_Destino(ByVal xObjLineaAereaDestino As OBJETOS.ObjLineaAreaDestino, ByVal sql As String) As OBJETOS.ObjRespuesta
            Dim objRespuesta As New OBJETOS.ObjRespuesta
            Try
                objRespuesta = _ejecutar.SQL_Ejecuta_SentenciaInsert_Update_Delete(xObjLineaAereaDestino, sql, _mensajeError)
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
