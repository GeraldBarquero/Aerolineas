Imports System.Windows.Forms

Module ModValidaDatos
    Public Function SoloLetras(ByVal TECLAS As Integer) As Integer
        Select Case TECLAS
            Case 65 To 90, 97 To 122, 160 To 165, 130, 181, 144, 214, 224, 233, 13, 3, 8, 22, 24, 32, 44, 46, 127
                SoloLetras = TECLAS
                Exit Function
            Case Else
                MessageBox.Show("Solo se admiten letras", "ayuda", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End Select
    End Function

    Public Function SoloNumeros(ByVal TECLAS As Integer) As Integer
        Select Case TECLAS
            Case 48 To 57, 13, 3, 8, 22, 24, 44, 46, 127
                SoloNumeros = TECLAS
                Exit Function
            Case Else
                MessageBox.Show("Solo se admiten Números", "ayuda", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End Select
    End Function
End Module

