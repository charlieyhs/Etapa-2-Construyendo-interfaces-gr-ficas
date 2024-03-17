Public Class FormConversionEscalas

    Private Const escalaFahrenheit As String = "Fahrenheit"
    Private Const escalaKelvin As String = "Kelvin"

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Close
    End Sub

    Private Sub FormConversionEscalas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        escalaHacia.Items.Add(escalaFahrenheit)
        escalaHacia.Items.Add(escalaKelvin)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If escalaHacia.SelectedItem Is Nothing Then
            MessageBox.Show("Primero debe Escala de destino.", "Mensaje de validación")
            Return
        End If

        Dim valor As Double = 0

        Try
            valor = Double.Parse(inputValor.Text)
        Catch ex As FormatException
            MessageBox.Show("Debe digitar un valor correcto.", "Mensaje de validación")
            Return
        End Try


        If escalaHacia.SelectedItem = escalaFahrenheit Then
            labelResultado.Text = (valor * (9 / 5)) + 32
        ElseIf escalaHacia.SelectedItem = escalaKelvin Then
            labelResultado.Text = valor + 273.15
        End If
    End Sub
End Class