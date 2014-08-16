Imports System.Data.SqlClient
Imports System.Reflection
Imports Aerolineas.Entidades
Imports Aerolineas.Utilitarios

Namespace DAL.Ejecutar


    Public Class Ejecutar
        Private _conectar As New DAL.Coneccion.DalConeccion
        Private _correcto As Boolean
        Private res As Int32 = 0
        Dim Datos As New DataSet()
        Dim objRespuesta As New OBJETOS.ObjRespuesta
        Public Function SQL_Ejecuta_SentenciaInsert_Update_Delete(ByVal Obj As Object, ByVal SQL As String, ByRef MensajeError As String) As OBJETOS.ObjRespuesta
            Dim n As Int32 = 0
            If Not _conectar.ConectaDb(MensajeError) Then
            Else
                Dim cmd As New SqlCommand()
                cmd.CommandType = CommandType.StoredProcedure
                cmd.CommandText = SQL
                cmd.Connection = _conectar.Cone
                Dim Type As System.Type = Obj.GetType
                Dim Propiedades() As PropertyInfo = Type.GetProperties()
                For Each pi As PropertyInfo In Propiedades
                    Select Case pi.PropertyType.Name
                        Case "Int32"
                            cmd.Parameters.AddWithValue("@" + pi.Name, IIf(pi.GetValue(Obj, Nothing) = Integer.MinValue, DBNull.Value, pi.GetValue(Obj, Nothing)))
                        Case "String"
                            cmd.Parameters.AddWithValue("@" + pi.Name, IIf(pi.GetValue(Obj, Nothing) = String.Empty, DBNull.Value, pi.GetValue(Obj, Nothing)))
                        Case "DateTime"
                            cmd.Parameters.AddWithValue("@" + pi.Name, IIf(pi.GetValue(Obj, Nothing) = Date.MinValue, DBNull.Value, pi.GetValue(Obj, Nothing)))
                        Case "Decimal"
                            cmd.Parameters.AddWithValue("@" + pi.Name, IIf(pi.GetValue(Obj, Nothing) = Decimal.MinValue, DBNull.Value, pi.GetValue(Obj, Nothing)))
                        Case "Double"
                            cmd.Parameters.AddWithValue("@" + pi.Name, IIf(pi.GetValue(Obj, Nothing) = Double.MinValue, DBNull.Value, pi.GetValue(Obj, Nothing)))
                    End Select
                Next
                Try

                    res = Convert.ToInt32(cmd.ExecuteScalar())
                    MensajeError = ""
                    _correcto = True
                    _conectar.DesconectaDb(MensajeError)
                    objRespuesta.ResponseCode = 1
                Catch ex As Exception
                    MensajeError = MensajeError & " Error al Ejecutar Sentencia SQL, Informacion Adicional: " & ex.Message
                    _correcto = False

                End Try
            End If
            Return objRespuesta
        End Function
        Public Function SQL_Ejecuta_Sentencia(ByVal Obj As Object, ByVal SQL As String, ByRef MensajeError As String) As OBJETOS.ObjRespuesta
            Dim n As Int32 = 0
            If Not _conectar.ConectaDb(MensajeError) Then
            Else
                Dim cmd As New SqlCommand()
                cmd.CommandType = CommandType.StoredProcedure
                cmd.CommandText = SQL
                cmd.Connection = _conectar.Cone
                Dim Type As System.Type = Obj.GetType
                Dim Propiedades() As PropertyInfo = Type.GetProperties()
                For Each pi As PropertyInfo In Propiedades
                    Select Case pi.PropertyType.Name
                        Case "Int32"
                            cmd.Parameters.AddWithValue("@" + pi.Name, IIf(pi.GetValue(Obj, Nothing) = Integer.MinValue, DBNull.Value, pi.GetValue(Obj, Nothing)))
                        Case "String"
                            cmd.Parameters.AddWithValue("@" + pi.Name, IIf(pi.GetValue(Obj, Nothing) = String.Empty, DBNull.Value, pi.GetValue(Obj, Nothing)))
                        Case "DateTime"
                            cmd.Parameters.AddWithValue("@" + pi.Name, IIf(pi.GetValue(Obj, Nothing) = Date.MinValue, DBNull.Value, pi.GetValue(Obj, Nothing)))
                        Case "Decimal"
                            cmd.Parameters.AddWithValue("@" + pi.Name, IIf(pi.GetValue(Obj, Nothing) = Decimal.MinValue, DBNull.Value, pi.GetValue(Obj, Nothing)))
                        Case "Double"
                            cmd.Parameters.AddWithValue("@" + pi.Name, IIf(pi.GetValue(Obj, Nothing) = Double.MinValue, DBNull.Value, pi.GetValue(Obj, Nothing)))
                    End Select
                Next
                Try
                    Dim adaptador As New SqlDataAdapter(cmd)
                    adaptador.Fill(Datos, "Datos")
                    objRespuesta.ByteResponseObject = Utilitarios.UTL.Utilitarios.Utilitarios.ZipDataSet(Datos, False)
                    MensajeError = ""
                    _conectar.DesconectaDb(MensajeError)
                Catch ex As Exception
                    MensajeError = MensajeError & " Error al Ejecutar Sentencia SQL, Informacion Adicional: " & ex.Message
                    _correcto = False
                End Try

            End If
            Return objRespuesta

        End Function


    End Class
End Namespace