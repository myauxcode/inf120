Public Class Form1
    Dim v1 As VECTOR
    Dim v2 As VECTOR
    Dim v3 As VECTOR
    Dim n1 As NENT

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        v1 = New VECTOR
        v2 = New VECTOR
        v3 = New VECTOR
        n1 = New NENT

    End Sub

    'CARGAR
    Private Sub CargarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CargarToolStripMenuItem.Click
        v1.cargar(TextBox1.Text)
    End Sub

    Private Sub CargarRndToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CargarRndToolStripMenuItem.Click
        v1.cargar(TextBox1.Text, TextBox2.Text, TextBox3.Text)
    End Sub

    Private Sub DescargarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DescargarToolStripMenuItem.Click
        TextBox5.Text = v1.descargar
    End Sub

    'CARGAR

    Private Sub CargarToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles CargarToolStripMenuItem1.Click
        v2.cargar(TextBox1.Text)
    End Sub

    Private Sub CargarRndToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles CargarRndToolStripMenuItem1.Click
        v2.cargar(TextBox1.Text, TextBox2.Text, TextBox3.Text)
    End Sub

    Private Sub DescargarToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles DescargarToolStripMenuItem1.Click
        TextBox6.Text = v2.descargar
    End Sub

    'CARGAR
    Private Sub CargarToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles CargarToolStripMenuItem3.Click
        v3.cargar(TextBox1.Text)
    End Sub

    Private Sub DescargarToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles DescargarToolStripMenuItem3.Click
        v3.cargar(TextBox1.Text, TextBox2.Text, TextBox3.Text)
    End Sub

    Private Sub DescargarToolStripMenuItem4_Click(sender As Object, e As EventArgs) Handles DescargarToolStripMenuItem4.Click
        TextBox7.Text = v3.descargar
    End Sub

    'EXAMEN

    Private Sub EXAMENToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EXAMENToolStripMenuItem.Click

        'ENLACE
        v1.ejercicio6(v2, v3)
    End Sub





End Class
