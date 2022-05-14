Public Class Form1

    Dim v1, v2, v3 As Vector

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        v1 = New Vector
        v2 = New Vector
        v3 = New Vector
    End Sub
    Private Sub CARGARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CARGARToolStripMenuItem.Click
        v1.cargarmanual(TextBox1.Text)
        TextBox4.Text = v1.descargar
    End Sub

    Private Sub CARGARRNDToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CARGARRNDToolStripMenuItem.Click
        v1.cargar(TextBox1.Text, TextBox2.Text, TextBox3.Text)
        TextBox4.Text = v1.descargar
    End Sub

    Private Sub DESCARGARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DESCARGARToolStripMenuItem.Click
        TextBox4.Text = v1.descargar
    End Sub

    Private Sub PREGUNTA1ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PREGUNTA1ToolStripMenuItem.Click
        TextBox5.Text = v1.ejercicio1
    End Sub






End Class
