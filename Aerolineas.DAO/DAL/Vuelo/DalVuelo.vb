Imports Aerolineas.Entidades
Namespace DAL.Vuelo
    Public Class DalVuelo
#Region "Variables"
        Private _ejecutar As New Ejecutar.Ejecutar
        Private _mensajeError As String = ""
        Private _sql = ""
#End Region

#Region "Funciones"
        Public Function Select_Vuelo_All(ByVal xObjVuelo As OBJETOS.ObjVuelo) As OBJETOS.ObjRespuesta
            Dim objRespuesta As New OBJETOS.ObjRespuesta
            Try
                _sql = "SpVueloListar"
                objRespuesta = _ejecutar.SQL_Ejecuta_Sentencia(xObjVuelo, _sql, _mensajeError)
            Catch ex As Exception
                objRespuesta.ResponseCode = 0
                objRespuesta.ResponseMessage = ex.ToString
                objRespuesta.DsResponse = Nothing
            End Try
            Return objRespuesta
        End Function

        Public Function InsertarVuelo(ByVal xObjVuelo As Object, ByVal sql As String) As OBJETOS.ObjRespuesta
            Dim objRespuesta As New OBJETOS.ObjRespuesta
            Try
                objRespuesta = _ejecutar.SQL_Ejecuta_SentenciaInsert_Update_Delete(xObjVuelo, sql, _mensajeError)
            Catch ex As Exception
                objRespuesta.ResponseCode = 0
                objRespuesta.ResponseMessage = ex.ToString
                objRespuesta.DsResponse = Nothing
            End Try
            Return objRespuesta
        End Function

        Public Function actualizarVuelo(ByVal xObjVuelo As Object, ByVal sql As String) As OBJETOS.ObjRespuesta
            Dim objRespuesta As New OBJETOS.ObjRespuesta
            Try
                objRespuesta = _ejecutar.SQL_Ejecuta_SentenciaInsert_Update_Delete(xObjVuelo, sql, _mensajeError)
            Catch ex As Exception
                objRespuesta.ResponseCode = 0
                objRespuesta.ResponseMessage = ex.ToString
                objRespuesta.DsResponse = Nothing
            End Try
            Return objRespuesta
        End Function


        Public Function EliminarVuelo(ByVal xObjVuelo As Object, ByVal sql As String) As OBJETOS.ObjRespuesta
            Dim objRespuesta As New OBJETOS.ObjRespuesta
            Try
                objRespuesta = _ejecutar.SQL_Ejecuta_SentenciaInsert_Update_Delete(xObjVuelo, sql, _mensajeError)
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
                _sql = "SpConsultarVuelo"
                objRespuesta = _ejecutar.SQL_Ejecuta_Sentencia(xObjConsultarVuelo, _sql, _mensajeError)
            Catch ex As Exception
                objRespuesta.ResponseCode = 0
                objRespuesta.ResponseMessage = ex.ToString
                objRespuesta.DsResponse = Nothing
            End Try
            Return objRespuesta
        End Function

        Public Function Obtener_Vuelo(ByVal xObjVuelo As OBJETOS.ObjVuelo) As OBJETOS.ObjRespuesta
            Dim objRespuesta As New OBJETOS.ObjRespuesta
            Try
                _sql = "SpVueloObtener"
                objRespuesta = _ejecutar.SQL_Ejecuta_Sentencia(xObjVuelo, _sql, _mensajeError)
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


