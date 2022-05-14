Public Class Form1
    Dim v1, v2, v3, V4 As Vector

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        v1 = New Vector
        v2 = New Vector
        v3 = New Vector
        V4 = New Vector
    End Sub


    Private Sub CARGARRNDToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CARGARRNDToolStripMenuItem.Click
        v1.cargar(TextBox1.Text, TextBox2.Text, TextBox3.Text)
        TextBox4.Text = v1.descargar
    End Sub


    Private Sub DESCARGARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DESCARGARToolStripMenuItem.Click
        TextBox4.Text = v1.descargar
    End Sub

    '--------------------
    Private Sub CARGARRNDToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles CARGARRNDToolStripMenuItem1.Click
        v2.cargar(TextBox1.Text, TextBox2.Text, TextBox3.Text)
        TextBox5.Text = v2.descargar
    End Sub


    Private Sub DESCARGARToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles DESCARGARToolStripMenuItem1.Click
        TextBox5.Text = v2.descargar
    End Sub



    '---------------------
    Private Sub DESCARGARToolStripMenuItem2_Click(sender As Object, e As EventArgs)
        TextBox6.Text = v3.descargar
    End Sub

    '----------------------

    Private Sub DESCARGARToolStripMenuItem3_Click(sender As Object, e As EventArgs)
        TextBox7.Text = V4.descargar
    End Sub

    Private Sub PREGUNTA1ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PREGUNTA1ToolStripMenuItem.Click
        'enlase del ejercicio del examen 

        v3 = New Vector
        V4 = New Vector
        v1.examen(v2, v3, V4)

        TextBox6.Text = v3.descargar
        TextBox7.Text = V4.descargar


    End Sub




End Class
