Public Class VECTOR

    Const MAX = 100
    Private v(MAX) As Integer
    Private n As Integer

    Public Sub vector()
        n = 0

    End Sub

    Public Sub cargar(nele As Integer)
        Dim i As Integer
        n = nele
        For i = 1 To n
            v(i) = InputBox("ingresar elemento", "elemento", "")

        Next
    End Sub

    Public Sub cargar(nele As Integer, a As Integer, b As Integer)
        Dim i As Integer
        n = nele
        For i = 1 To n
            v(i) = a + Rnd() * (b - a)
        Next
    End Sub

    Public Function descargar() As String
        Dim s As String
        Dim i As Integer
        s = ""
        For i = 1 To n
            s = s + Str(v(i)) + ";"
        Next
        Return s
    End Function

    'EXAMEN AQUI VAMOS A SUPONER QUE EL EJERCICIO 6 ES EL EXAMEN

    Public Sub ejercicio6(ByRef v2 As VECTOR, ByRef v3 As VECTOR)
        Dim ne As NENT = New NENT
        v2.n = 0
        v3.n = 0
        For i = 1 To n
            ne.Cargar(v(i))
            If ne.Verif_primo = True Then
                v2.n = v2.n + 1
                v2.v(v2.n) = v(i)
            Else
                v3.n = v3.n + 1
                v3.v(v3.n) = v(i)
            End If
        Next
    End Sub


End Class
