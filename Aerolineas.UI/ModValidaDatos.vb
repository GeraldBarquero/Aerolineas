Imports System.Windows.Forms

Module ModValidaDatos
    Public Function SoloLetras(ByVal TECLAS As Integer) As Integer
        Select Case TECLAS
            Case 65 To 90, 97 To 122, 164, 13, 6, 8, 32, 44, 46
                SoloLetras = TECLAS
                Exit Function
            Case Else
                MessageBox.Show("Solo se admiten letras", "ayuda", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End Select
    End Function

    Public Function SoloNumeros(ByVal TECLAS As Integer) As Integer
        Select Case TECLAS
            Case 48 To 57, 13, 8, 46
                SoloNumeros = TECLAS
                Exit Function
            Case Else
                MessageBox.Show("Solo se admiten Números", "ayuda", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End Select
    End Function
End Module

