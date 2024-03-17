Public Class FormConversionMonedas

    Private tasasMonedas As New Dictionary(Of String, Double)
    Private Const monedaDolar As String = "Dolares"
    Private Const monedaEuros As String = "Euros"
    Private Const monedaYuan As String = "Yuan"


    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Close
    End Sub

    Private Sub FormConversionMonedas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MonedaHacia.Items.Add(monedaDolar)
        MonedaHacia.Items.Add(monedaEuros)
        MonedaHacia.Items.Add(monedaYuan)

        tasasMonedas.Add(monedaDolar, 3925.16)
        tasasMonedas.Add(monedaEuros, 4235.5)
        tasasMonedas.Add(monedaYuan, 552.34)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If MonedaHacia.SelectedItem Is Nothing Then
            MessageBox.Show("Primero debe seleccionar una moneda de destino.", "Mensaje de validación")
            Return
        End If

        Dim valor As Double = 0

        Try
            valor = Double.Parse(inputValor.Text)
        Catch ex As FormatException
            MessageBox.Show("Debe digitar un valor correcto.", "Mensaje de validación")
            Return
        End Try

        Dim tasa As Double = 1

        Try
            tasa = tasasMonedas(MonedaHacia.SelectedItem)
        Catch ex As KeyNotFoundException
            MessageBox.Show("La moneda seleccionada no tiene una tasa definida.", "Mensaje de validación")
            Return
        End Try


        labelResultado.Text = Math.Round(valor / tasa, 2)

    End Sub

End Class