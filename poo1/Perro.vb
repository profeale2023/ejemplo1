Public Class Perro
    Inherits animal

    'propiedades
    Public nombre As String
    Public raza As String
    Public altura As String

    'constructor
    Public Sub New()

    End Sub

    Public Sub New(nombreR As String, razaR As String, alturaR As String)
        Me.nombre = nombreR
        Me.raza = razaR
        Me.altura = alturaR
    End Sub

    'metodos
    Public Sub dormir()

    End Sub

    Public Function ladrar(ladra As String) As String
        Return Me.nombre & ":es de raza:" & Me.raza & ":mide:" & Me.altura & ":y ladra:" & ladra
    End Function

    Public Function comer(comida As String) As String
        Return Me.nombre & ":es de raza:" & Me.raza & ":mide:" & Me.altura & ":y comerá:" & comida
    End Function
End Class
