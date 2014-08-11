Imports Aerolineas.Entidades
Imports System.Data
Imports System.Data.SqlClient
Namespace DAL.Cliente
    Public Class DalCliente


#Region "Variables"

        Private _ejecutar As New Ejecutar.Ejecutar
        Private _mensajeError As String = ""
        Private _sql As String = ""






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


        Public Function Select_Cliente_All(ByVal xObjCliente As OBJETOS.ObjCliente) As OBJETOS.ObjRespuesta
            Dim objRespuesta As New OBJETOS.ObjRespuesta
            Try
                _sql = "SpClienteListar"
                objRespuesta = _ejecutar.SQL_Ejecuta_Sentencia(xObjCliente, _sql, _mensajeError)
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

