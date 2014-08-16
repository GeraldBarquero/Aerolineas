Namespace OBJETOS

    Public Class ObjCliente

        Property IdCliente As Integer
        Property NombreCliente As String
        Property Identification As String
        Property PaisResidencia As String
        Property DireccionExacta As String
        Property Edad As Integer
        Property TelefonoCasa As String
        Property TelefonoCelular As String
        Property Email As String
        Property Password As String

        Sub New()
            IdCliente = Integer.MinValue
            NombreCliente = String.Empty
            Identification = String.Empty
            PaisResidencia = String.Empty
            DireccionExacta = String.Empty
            Edad = Integer.MinValue
            TelefonoCasa = String.Empty
            TelefonoCelular = String.Empty
            Email = String.Empty
            Password = String.Empty

        End Sub

    End Class
End Namespace
