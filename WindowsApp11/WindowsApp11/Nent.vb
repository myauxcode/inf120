Public Class Nent

    Private n As Integer
    Public Sub Nent()
        n = 0
    End Sub
    Public Sub cargar(n2 As Integer)
        n = n2
    End Sub
    Public Function descargar()
        Return n
    End Function

    Public Function verifprimo()
        Dim c = 0
        For i = 1 To n
            If (n Mod i = 0) Then
                c += 1
            End If
        Next
        Return c = 2
    End Function


End Class
