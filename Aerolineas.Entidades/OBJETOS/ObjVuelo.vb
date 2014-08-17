Namespace OBJETOS
    Public Class ObjVuelo
        Property idVuelo As Integer
        Property salida As Integer
        Property llegada As Integer
        Property idAerolinea As Integer
        Property numeroVuelo As Integer
        Property horaSalida As String
        Property horaLlegada As String
        Property precio As String
        Property camposTotales As Integer
        Property camposDisponibles As Integer

        Sub New()
            idVuelo = Integer.MinValue
            salida = Integer.MinValue
            llegada = Integer.MinValue
            idAerolinea = Integer.MinValue
            numeroVuelo = Integer.MinValue
            horaLlegada = String.Empty
            horaSalida = String.Empty
            precio = Integer.MinValue
            camposDisponibles = Integer.MinValue
            camposTotales = Integer.MinValue
        End Sub

    End Class
End Namespace
