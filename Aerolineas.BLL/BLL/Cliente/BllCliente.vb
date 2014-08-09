Imports Aerolineas.DAO.DAL.Cliente
Imports Aerolineas.Entidades

Namespace Clientes



    Public Class BllCliente
#Region "Variables"
        Dim ClienteDao As New DalCliente
        Dim sql As String = ""
#End Region


#Region "Funciones"

        Public Function InsertarCliente(ByVal xObjCliente As OBJETOS.ObjCliente) As OBJETOS.ObjRespuesta
            Dim objRespuesta As New OBJETOS.ObjRespuesta
            sql = "SpClienteInsertar"
            Try
                objRespuesta = ClienteDao.InsertarCliente(xObjCliente, sql)
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

                objRespuesta = ClienteDao.Select_Cliente_All(xObjCliente)
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
