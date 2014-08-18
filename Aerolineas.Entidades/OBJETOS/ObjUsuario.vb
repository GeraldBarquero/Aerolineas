Namespace OBJETOS
    Public Class ObjUsuario
        Property IdUsername As Integer
        Property Username As String
        Property Password As String
        Property TipoUsuario As String

        Sub New()
            IdUsername = Integer.MinValue
            Username = String.Empty
            Password = String.Empty
            TipoUsuario = String.Empty
        End Sub
    End Class
End Namespace
