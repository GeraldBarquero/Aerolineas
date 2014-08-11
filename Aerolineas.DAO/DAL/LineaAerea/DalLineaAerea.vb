Imports Aerolineas.Entidades

Namespace Dal.LineaAerea


    Public Class DalLineaAerea
#Region "Variables"

        Private _ejecutar As New Ejecutar.Ejecutar
        Private _mensajeError As String = ""

        Private _sql = ""

#End Region

#Region "Funciones"

        Public Function InsertarLineaAerea(ByVal xObjLineaAerea As Object, ByVal sql As String) As OBJETOS.ObjRespuesta
            Dim objRespuesta As New OBJETOS.ObjRespuesta
            Try
                objRespuesta = _ejecutar.SQL_Ejecuta_SentenciaInsert_Update_Delete(xObjLineaAerea, sql, _mensajeError)
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
                _sql = "SpLineaAereaListar"
                objRespuesta = _ejecutar.SQL_Ejecuta_Sentencia(xObjLineaAerea, _sql, _mensajeError)
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