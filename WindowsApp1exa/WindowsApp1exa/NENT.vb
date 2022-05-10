Public Class NENT





    Private n As Integer

    Public Sub NENT()
        n = 0
    End Sub

    Public Sub Cargar(dato As Integer)
        n = dato
    End Sub

    Public Sub Cargar(a As Integer, b As Integer)

        n = a + Rnd() * (b - a)

    End Sub
    Public Function Descargar() As Integer
        Return n
    End Function


    '3

    Public Function Veri_par() As Boolean
        Return n Mod 2 = 0

    End Function

    '4
    Public Function Verif_num_mult(num As Integer) As Boolean

        Return n Mod num = 0

    End Function

    '5
    Public Function Verif_num_submul(num As Integer) As Boolean
        Return num Mod n = 0

    End Function

    '6
    Public Function Verif_primo() As Boolean
        Dim na, c As Integer
        Dim b As Boolean = True

        na = n
        c = 2

        If na <= 1 Then
            b = False
        End If

        While (c <= (na / 2)) And (b = True)

            If (na Mod c = 0) Then
                b = False

            End If

            c = c + 1

        End While

        Return b

    End Function




End Class
