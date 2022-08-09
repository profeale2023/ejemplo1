Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnPerro1.Click
        Dim perrito As Perro = New Perro()
        perrito.nombre = "Mora"
        perrito.raza = "Labrador"
        perrito.altura = "0.70 cm"
        perrito.tipo = "horareño"

        Me.TxtResultado.Text = perrito.comer("Pollo")
        Me.TxtResultado2.Text = perrito.ladrar("A veces")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles BtnPerro2.Click
        Dim perrito As Perro = New Perro()
        perrito.nombre = "Pompon"
        perrito.raza = "Caniche"
        perrito.altura = "0.50 cm"
        Me.TxtResultado.Text = perrito.comer("Carne Vaca")
        Me.TxtResultado2.Text = perrito.ladrar("Siempre")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles BtnPerro3.Click
        Dim perrito As Perro = New Perro("Wendy", "Mini Pincher", "0.20 cm")
        Me.TxtResultado.Text = perrito.comer("Balanceada")
        Me.TxtResultado2.Text = perrito.ladrar("Poco")
        'Me.TxtResultado3.Text = perrito.ladrar("Poco")
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        End
    End Sub
End Class
