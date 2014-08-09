Imports Aerolineas.Entidades
Namespace Dal.Cliente
    Public Class DalCliente


#Region "Variables"

        Private _ejecutar As New Ejecutar.Ejecutar
        Private _mensajeError As String = ""


#End Region

#Region "Funciones"



        Public Function InsertarCliente(ByVal xObjcliente As Object, ByVal sql As String) As OBJETOS.ObjRespuesta
            Dim objRespuesta As New OBJETOS.ObjRespuesta

            Try

                objRespuesta = _ejecutar.SQL_Ejecuta_SentenciaInsert_Update_Delete(xObjcliente, sql, _mensajeError)

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

