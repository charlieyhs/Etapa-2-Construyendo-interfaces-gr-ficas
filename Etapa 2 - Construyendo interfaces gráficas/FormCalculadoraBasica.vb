Imports System.Runtime.InteropServices.JavaScript.JSType

Public Class FormCalculadoraBasica
    Private usoPunto As Boolean = True
    Private primerNumero As Double = 0
    Private operacion As String
    Private UsoIgual As Boolean = True
    Private clickCero As Boolean

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles BtnCero.Click
        clickCero = True
        If LabelResultado.Text = BtnCero.Text Then
            Return
        End If

        LabelResultado.Text = LabelResultado.Text + BtnCero.Text
    End Sub

    Private Sub BtnPunto_Click(sender As Object, e As EventArgs) Handles BtnPunto.Click
        If usoPunto = False Then
            Return
        End If
        usoPunto = False
        LabelResultado.Text = LabelResultado.Text + BtnPunto.Text
    End Sub

    Private Sub BtnUno_Click(sender As Object, e As EventArgs) Handles BtnUno.Click
        limpiarCero()
        LabelResultado.Text = LabelResultado.Text + BtnUno.Text
    End Sub

    Private Sub limpiarCero()
        If LabelResultado.Text.Equals(BtnCero.Text) Then
            LabelResultado.Text = ""
        End If
        clickCero = True
    End Sub

    Private Sub BtnSeis_Click(sender As Object, e As EventArgs) Handles BtnSeis.Click
        limpiarCero()
        LabelResultado.Text = LabelResultado.Text + BtnSeis.Text
    End Sub

    Private Sub BtnDos_Click(sender As Object, e As EventArgs) Handles BtnDos.Click
        limpiarCero()
        LabelResultado.Text = LabelResultado.Text + BtnDos.Text
    End Sub

    Private Sub BtnTres_Click(sender As Object, e As EventArgs) Handles BtnTres.Click
        limpiarCero()
        LabelResultado.Text = LabelResultado.Text + BtnTres.Text
    End Sub

    Private Sub BtnCuatro_Click(sender As Object, e As EventArgs) Handles BtnCuatro.Click
        limpiarCero()
        LabelResultado.Text = LabelResultado.Text + BtnCuatro.Text
    End Sub

    Private Sub BtnCinco_Click(sender As Object, e As EventArgs) Handles BtnCinco.Click
        limpiarCero()
        LabelResultado.Text = LabelResultado.Text + BtnCinco.Text
    End Sub

    Private Sub BtnSiete_Click(sender As Object, e As EventArgs) Handles BtnSiete.Click
        limpiarCero()
        LabelResultado.Text = LabelResultado.Text + BtnSiete.Text
    End Sub

    Private Sub BtnOcho_Click(sender As Object, e As EventArgs) Handles BtnOcho.Click
        limpiarCero()
        LabelResultado.Text = LabelResultado.Text + BtnOcho.Text
    End Sub

    Private Sub BtnNueve_Click(sender As Object, e As EventArgs) Handles BtnNueve.Click
        limpiarCero()
        LabelResultado.Text = LabelResultado.Text + BtnNueve.Text
    End Sub

    Private Sub BtnSuma_Click(sender As Object, e As EventArgs) Handles BtnSuma.Click
        lisBotonOperacion(BtnSuma)
    End Sub
    Private Sub lisBotonOperacion(boton As Button)
        If UsoIgual = False Then
            UsoIgual = True
            operacion = boton.Text
            LabelResultado.Text = "0"
            setLabelResultado()
            Return
        End If
        If clickCero = False Then
            operacion = boton.Text
            setLabelResultado()
            Return
        End If
        clickCero = False
        Dim numero As Double = 0
        Try
            numero = Double.Parse(LabelResultado.Text)
        Catch ex As Exception
            MessageBox.Show("Ha ocurrido un error con el numero digitado", "Error de validación")
            Return
        End Try

        If primerNumero <= 0 Then
            primerNumero = numero
        Else
            realizarOperacion(numero)
        End If

        operacion = boton.Text

        setLabelResultado()
        LabelResultado.Text = "0"
        usoPunto = True
        UsoIgual = True
    End Sub
    Private Sub realizarOperacion(numero As Double)
        Select Case operacion
            Case "+"
                primerNumero += numero
            Case "x"
                primerNumero *= numero
            Case "/"
                primerNumero /= numero
            Case "-"
                primerNumero -= numero
        End Select
    End Sub
    Private Sub setLabelResultado()
        LabelOperaciones.Text = primerNumero.ToString() + " " + operacion
    End Sub

    Private Sub BtnMultiplicacion_Click(sender As Object, e As EventArgs) Handles BtnMultiplicacion.Click
        lisBotonOperacion(BtnMultiplicacion)
    End Sub

    Private Sub BtnResta_Click(sender As Object, e As EventArgs) Handles BtnResta.Click
        lisBotonOperacion(BtnResta)
    End Sub

    Private Sub BtnDivision_Click(sender As Object, e As EventArgs) Handles BtnDivision.Click
        lisBotonOperacion(BtnDivision)
    End Sub

    Private Sub BtnResultado_Click(sender As Object, e As EventArgs) Handles BtnResultado.Click
        If primerNumero <= 0 Or UsoIgual = False Then
            Return
        End If

        Dim numero As Double = 0
        Try
            numero = Double.Parse(LabelResultado.Text)
        Catch ex As Exception
            MessageBox.Show("Ha ocurrido un error con el numero digitado", "Error de validación")
            Return
        End Try

        LabelOperaciones.Text = LabelOperaciones.Text + " " + LabelResultado.Text + " ="
        realizarOperacion(numero)
        LabelResultado.Text = primerNumero.ToString()
        usoPunto = True
        UsoIgual = False
    End Sub

    Private Sub BtnBorrar_Click(sender As Object, e As EventArgs) Handles BtnBorrar.Click
        usoPunto = True
        UsoIgual = True
        operacion = ""
        clickCero = False
        primerNumero = 0
        LabelResultado.Text = "0"
        LabelOperaciones.Text = ""
    End Sub
End Class