Public Class Vector
    Const max = 100
    Private v(max) As Integer
    Private n As Integer
    Public Sub Vector()
        n = 0
    End Sub
    Public Sub cargar(ne As Integer, a As Integer, b As Integer)
        n = ne
        For i = 1 To n
            v(i) = a + Rnd() * (b - a)
        Next
    End Sub
    Public Sub cargarmanual(ne As Integer)
        n = ne
        For i = 1 To n
            v(i) = InputBox("introducir un numero")
        Next
    End Sub
    Public Function descargar()
        Dim s As String = ""
        For i = 1 To n
            s = s + Str(v(i)) + ","
        Next
        Return s
    End Function
    Public Sub cargaru(ele As Integer)
        n = n + 1
        v(n) = ele
    End Sub
    Public Function frecuencia(ele As Integer)
        Dim c = 0
        For i = 1 To n
            If (ele = v(i)) Then
                c = c + 1
            End If
        Next
        Return c
    End Function
    Public Function ejercicio1()
        Dim primos As Vector = New Vector
        Dim ne As Nent = New Nent
        For i = 1 To n
            ne.cargar(v(i))
            If (ne.verifprimo And primos.frecuencia(ne.descargar) = 0) Then
                primos.cargaru(ne.descargar)
            End If
        Next
        Return primos.n
    End Function




End Class
