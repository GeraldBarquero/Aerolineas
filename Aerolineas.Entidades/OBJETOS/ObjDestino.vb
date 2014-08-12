
Namespace OBJETOS


    Public Class ObjDestino

        Property idDestino As Integer
        Property idPais As Integer
        Property nombreDestino As String
        Property codigoDestino As String
        Property nombreAeropuerto As String

        Sub New()
            idDestino = Integer.MinValue
            idPais = Integer.MinValue
            nombreDestino = String.Empty
            codigoDestino = String.Empty
            nombreAeropuerto = String.Empty
        End Sub


    End Class
End Namespace