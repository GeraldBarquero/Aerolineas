Namespace OBJETOS
    Public Class ObjUsuario
        Property Username As String
        Property Password As String
        Property TipoUsuario As String

        Sub New()
            Username = String.Empty
            Password = String.Empty
            TipoUsuario = String.Empty
        End Sub
    End Class
End Namespace
