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

    'examen

    Public Sub examen(c As Vector, p As Vector, r As Vector)
        Dim sum As Integer
        For i = 1 To n
            sum = 0
            Dim ele = v(i)
            For j = 1 To n
                If v(j) = ele Then
                    sum = sum + c.v(j)
                End If
            Next
            If (p.frecuencia(ele) = 0) Then
                p.cargaru(ele)
                r.cargaru(sum)
            End If
        Next
    End Sub


End Class
