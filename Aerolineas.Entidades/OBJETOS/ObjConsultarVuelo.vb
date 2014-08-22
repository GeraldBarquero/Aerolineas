Namespace OBJETOS
    Public Class ObjConsultarVuelo
        Property DestinoSalida As Integer
        Property DestinoLlegada As Integer
        Property FechaVuelo As DateTime
        Property PrecioInicio As Integer
        Property PrecioFinal As Integer

        Sub New()
            DestinoSalida = Integer.MinValue
            DestinoLlegada = Integer.MinValue
            FechaVuelo = DateTime.MinValue
            PrecioFinal = Integer.MinValue
            PrecioInicio = Integer.MinValue
        End Sub
    End Class
End Namespace

