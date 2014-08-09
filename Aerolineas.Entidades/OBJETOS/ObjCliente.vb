Namespace OBJETOS

    Public Class ObjCliente

        Property idCliente As Integer
        Property idPais As Integer
        Property NombreCliente As String
        Property identificacion As String
        Property direccionExacta As String
        Property Edad As Integer
        Property telefonoCasa As String
        Property telefonoCelular As String
        Property email As String

        Sub New()
            idCliente = Integer.MinValue
            idPais = Integer.MinValue
            NombreCliente = String.Empty
            identificacion = String.Empty
            direccionExacta = String.Empty
            Edad = Integer.MinValue
            telefonoCasa = String.Empty
            telefonoCelular = String.Empty
            email = String.Empty

        End Sub

    End Class
End Namespace
