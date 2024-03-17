<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormularioPrincipal
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        PanelMenuLateral = New Panel()
        PanelSeccion1 = New Panel()
        BtnCalculadoraDias = New Button()
        BtnCalculadoraBasica = New Button()
        BtnConversionEscalas = New Button()
        BtnConversionMonedas = New Button()
        btnSeccion1 = New Button()
        PanelLogo = New Panel()
        Label1 = New Label()
        PanelContenedorHijos = New Panel()
        PanelMenuLateral.SuspendLayout()
        PanelSeccion1.SuspendLayout()
        PanelLogo.SuspendLayout()
        SuspendLayout()
        ' 
        ' PanelMenuLateral
        ' 
        PanelMenuLateral.AutoScroll = True
        PanelMenuLateral.BackColor = Color.FromArgb(CByte(17), CByte(7), CByte(17))
        PanelMenuLateral.Controls.Add(PanelSeccion1)
        PanelMenuLateral.Controls.Add(btnSeccion1)
        PanelMenuLateral.Controls.Add(PanelLogo)
        PanelMenuLateral.Dock = DockStyle.Left
        PanelMenuLateral.Location = New Point(0, 0)
        PanelMenuLateral.Name = "PanelMenuLateral"
        PanelMenuLateral.Size = New Size(250, 480)
        PanelMenuLateral.TabIndex = 0
        ' 
        ' PanelSeccion1
        ' 
        PanelSeccion1.BackColor = Color.FromArgb(CByte(5), CByte(32), CByte(39))
        PanelSeccion1.Controls.Add(BtnCalculadoraDias)
        PanelSeccion1.Controls.Add(BtnCalculadoraBasica)
        PanelSeccion1.Controls.Add(BtnConversionEscalas)
        PanelSeccion1.Controls.Add(BtnConversionMonedas)
        PanelSeccion1.Dock = DockStyle.Top
        PanelSeccion1.Location = New Point(0, 145)
        PanelSeccion1.Name = "PanelSeccion1"
        PanelSeccion1.Size = New Size(250, 162)
        PanelSeccion1.TabIndex = 2
        ' 
        ' BtnCalculadoraDias
        ' 
        BtnCalculadoraDias.Dock = DockStyle.Top
        BtnCalculadoraDias.FlatAppearance.BorderSize = 0
        BtnCalculadoraDias.FlatAppearance.MouseDownBackColor = Color.MediumPurple
        BtnCalculadoraDias.FlatAppearance.MouseOverBackColor = Color.MediumPurple
        BtnCalculadoraDias.FlatStyle = FlatStyle.Flat
        BtnCalculadoraDias.ForeColor = SystemColors.ButtonHighlight
        BtnCalculadoraDias.Location = New Point(0, 120)
        BtnCalculadoraDias.Name = "BtnCalculadoraDias"
        BtnCalculadoraDias.Padding = New Padding(35, 0, 0, 0)
        BtnCalculadoraDias.Size = New Size(250, 40)
        BtnCalculadoraDias.TabIndex = 3
        BtnCalculadoraDias.Text = "Calculadora dias"
        BtnCalculadoraDias.TextAlign = ContentAlignment.MiddleLeft
        BtnCalculadoraDias.UseVisualStyleBackColor = True
        ' 
        ' BtnCalculadoraBasica
        ' 
        BtnCalculadoraBasica.Dock = DockStyle.Top
        BtnCalculadoraBasica.FlatAppearance.BorderSize = 0
        BtnCalculadoraBasica.FlatAppearance.MouseDownBackColor = Color.MediumPurple
        BtnCalculadoraBasica.FlatAppearance.MouseOverBackColor = Color.MediumPurple
        BtnCalculadoraBasica.FlatStyle = FlatStyle.Flat
        BtnCalculadoraBasica.ForeColor = SystemColors.ButtonHighlight
        BtnCalculadoraBasica.Location = New Point(0, 80)
        BtnCalculadoraBasica.Name = "BtnCalculadoraBasica"
        BtnCalculadoraBasica.Padding = New Padding(35, 0, 0, 0)
        BtnCalculadoraBasica.Size = New Size(250, 40)
        BtnCalculadoraBasica.TabIndex = 2
        BtnCalculadoraBasica.Text = "Calculadora Basica"
        BtnCalculadoraBasica.TextAlign = ContentAlignment.MiddleLeft
        BtnCalculadoraBasica.UseVisualStyleBackColor = True
        ' 
        ' BtnConversionEscalas
        ' 
        BtnConversionEscalas.Dock = DockStyle.Top
        BtnConversionEscalas.FlatAppearance.BorderSize = 0
        BtnConversionEscalas.FlatAppearance.MouseDownBackColor = Color.MediumPurple
        BtnConversionEscalas.FlatAppearance.MouseOverBackColor = Color.MediumPurple
        BtnConversionEscalas.FlatStyle = FlatStyle.Flat
        BtnConversionEscalas.ForeColor = SystemColors.ButtonHighlight
        BtnConversionEscalas.Location = New Point(0, 40)
        BtnConversionEscalas.Name = "BtnConversionEscalas"
        BtnConversionEscalas.Padding = New Padding(35, 0, 0, 0)
        BtnConversionEscalas.Size = New Size(250, 40)
        BtnConversionEscalas.TabIndex = 1
        BtnConversionEscalas.Text = "Conversion Escalas"
        BtnConversionEscalas.TextAlign = ContentAlignment.MiddleLeft
        BtnConversionEscalas.UseVisualStyleBackColor = True
        ' 
        ' BtnConversionMonedas
        ' 
        BtnConversionMonedas.Dock = DockStyle.Top
        BtnConversionMonedas.FlatAppearance.BorderSize = 0
        BtnConversionMonedas.FlatAppearance.MouseDownBackColor = Color.MediumPurple
        BtnConversionMonedas.FlatAppearance.MouseOverBackColor = Color.MediumPurple
        BtnConversionMonedas.FlatStyle = FlatStyle.Flat
        BtnConversionMonedas.ForeColor = SystemColors.ButtonHighlight
        BtnConversionMonedas.Location = New Point(0, 0)
        BtnConversionMonedas.Name = "BtnConversionMonedas"
        BtnConversionMonedas.Padding = New Padding(35, 0, 0, 0)
        BtnConversionMonedas.Size = New Size(250, 40)
        BtnConversionMonedas.TabIndex = 0
        BtnConversionMonedas.Text = "Conversión Moneda"
        BtnConversionMonedas.TextAlign = ContentAlignment.MiddleLeft
        BtnConversionMonedas.UseVisualStyleBackColor = True
        ' 
        ' btnSeccion1
        ' 
        btnSeccion1.Dock = DockStyle.Top
        btnSeccion1.FlatAppearance.BorderSize = 0
        btnSeccion1.FlatAppearance.MouseDownBackColor = Color.MediumPurple
        btnSeccion1.FlatAppearance.MouseOverBackColor = Color.MediumPurple
        btnSeccion1.FlatStyle = FlatStyle.Flat
        btnSeccion1.ForeColor = SystemColors.ButtonHighlight
        btnSeccion1.Location = New Point(0, 100)
        btnSeccion1.Name = "btnSeccion1"
        btnSeccion1.Padding = New Padding(10, 0, 0, 0)
        btnSeccion1.Size = New Size(250, 45)
        btnSeccion1.TabIndex = 1
        btnSeccion1.Text = "Sección 1"
        btnSeccion1.TextAlign = ContentAlignment.MiddleLeft
        btnSeccion1.UseVisualStyleBackColor = True
        ' 
        ' PanelLogo
        ' 
        PanelLogo.Controls.Add(Label1)
        PanelLogo.Dock = DockStyle.Top
        PanelLogo.Location = New Point(0, 0)
        PanelLogo.Name = "PanelLogo"
        PanelLogo.Size = New Size(250, 100)
        PanelLogo.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Dock = DockStyle.Bottom
        Label1.Font = New Font("Segoe UI", 22F)
        Label1.ForeColor = SystemColors.ButtonHighlight
        Label1.Location = New Point(0, 18)
        Label1.Name = "Label1"
        Label1.Size = New Size(252, 41)
        Label1.TabIndex = 0
        Label1.Text = "Carlos Hernández"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' PanelContenedorHijos
        ' 
        PanelContenedorHijos.BackColor = Color.FromArgb(CByte(2), CByte(30), CByte(45))
        PanelContenedorHijos.Dock = DockStyle.Fill
        PanelContenedorHijos.Location = New Point(250, 0)
        PanelContenedorHijos.Name = "PanelContenedorHijos"
        PanelContenedorHijos.Size = New Size(580, 480)
        PanelContenedorHijos.TabIndex = 1
        ' 
        ' FormularioPrincipal
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(830, 480)
        Controls.Add(PanelContenedorHijos)
        Controls.Add(PanelMenuLateral)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Name = "FormularioPrincipal"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form1"
        PanelMenuLateral.ResumeLayout(False)
        PanelSeccion1.ResumeLayout(False)
        PanelLogo.ResumeLayout(False)
        PanelLogo.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents PanelMenuLateral As Panel
    Friend WithEvents PanelSeccion1 As Panel
    Friend WithEvents BtnConversionMonedas As Button
    Friend WithEvents btnSeccion1 As Button
    Friend WithEvents PanelLogo As Panel
    Friend WithEvents BtnCalculadoraDias As Button
    Friend WithEvents BtnCalculadoraBasica As Button
    Friend WithEvents BtnConversionEscalas As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents PanelContenedorHijos As Panel

End Class
