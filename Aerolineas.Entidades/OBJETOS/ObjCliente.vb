Namespace OBJETOS

    Public Class ObjCliente

        Property idCliente As Integer
        Property NombreCliente As String
        Property identification As String
        Property PaisResidencia As String
        Property direccionExacta As String
        Property Edad As Integer
        Property telefonoCasa As String
        Property telefonoCelular As String
        Property email As String
        Property password As String

        Sub New()
            idCliente = Integer.MinValue
            NombreCliente = String.Empty
            identification = String.Empty
            PaisResidencia = String.Empty
            direccionExacta = String.Empty
            Edad = Integer.MinValue
            telefonoCasa = String.Empty
            telefonoCelular = String.Empty
            email = String.Empty
            password = String.Empty

        End Sub

    End Class
End Namespace
