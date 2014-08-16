
Namespace OBJETOS


    Public Class ObjDestino

        Property idDestino As Integer
        Property NombreDestino As String
        Property CodigoDestino As String
        Property NombreAeropuerto As String
        Property idPais As Integer

        Sub New()
            idDestino = Integer.MinValue
            NombreDestino = String.Empty
            codigoDestino = String.Empty
            idPais = Integer.MinValue
            NombreAeropuerto = String.Empty
        End Sub


    End Class
End Namespace