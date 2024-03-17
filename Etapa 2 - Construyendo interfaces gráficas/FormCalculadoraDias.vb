Public Class FormCalculadoraDias
    Private Sub BtnCalcular_Click(sender As Object, e As EventArgs) Handles BtnCalcular.Click
        Dim diferencia As TimeSpan = FechaHasta.Value - FechaDesde.Value
        Dim diferenciaEnDias As Integer = CInt(diferencia.TotalDays)
        LabelResultado.Text = diferenciaEnDias.ToString()
    End Sub

    Private Sub FormCalculadoraDias_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FechaDesde.Format = DateTimePickerFormat.Custom
        FechaDesde.CustomFormat = "dd/MM/yyyy"
        FechaHasta.Format = DateTimePickerFormat.Custom
        FechaHasta.CustomFormat = "dd/MM/yyyy"
    End Sub
End Class