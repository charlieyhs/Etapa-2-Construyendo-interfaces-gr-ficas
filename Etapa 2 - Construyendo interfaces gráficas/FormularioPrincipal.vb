Public Class FormularioPrincipal
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        hideSubMenu()
    End Sub

    Private Sub hideSubMenu()
        PanelSeccion1.Visible = False

    End Sub

    Private Sub showSubMenu(submenu As Panel)
        If submenu.Visible = False Then
            hideSubMenu()
            submenu.Visible = True
        Else
            submenu.Visible = False
        End If

    End Sub


    Private Sub btnSeccion1_Click(sender As Object, e As EventArgs) Handles btnSeccion1.Click
        showSubMenu(PanelSeccion1)
    End Sub

    Private Sub BtnConversionMonedas_Click(sender As Object, e As EventArgs) Handles BtnConversionMonedas.Click
        openChildForm(New FormConversionMonedas())
        hideSubMenu()
    End Sub

    Private Sub BtnConversionEscalas_Click(sender As Object, e As EventArgs) Handles BtnConversionEscalas.Click
        openChildForm(New FormConversionEscalas())
        hideSubMenu()
    End Sub

    Private Sub BtnCalculadoraBasica_Click(sender As Object, e As EventArgs) Handles BtnCalculadoraBasica.Click
        openChildForm(New FormCalculadoraBasica())
        hideSubMenu()
    End Sub

    Private Sub BtnCalculadoraDias_Click(sender As Object, e As EventArgs) Handles BtnCalculadoraDias.Click
        openChildForm(New FormCalculadoraDias())
        hideSubMenu()
    End Sub

    Private currentForm As Form = Nothing
    Private Sub openChildForm(childForm As Form)
        If currentForm IsNot Nothing Then currentForm.Close()

        currentForm = childForm
        childForm.TopLevel = False
        childForm.FormBorderStyle = FormBorderStyle.None
        childForm.Dock = DockStyle.Fill

        PanelContenedorHijos.Controls.Add(childForm)
        PanelContenedorHijos.Tag = childForm
        childForm.BringToFront()
        childForm.Show()
    End Sub


End Class
