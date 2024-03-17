<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCalculadoraBasica
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        BtnUno = New Button()
        BtnDos = New Button()
        BtnTres = New Button()
        LabelResultado = New Label()
        BtnMultiplicacion = New Button()
        BtnResultado = New Button()
        BtnCero = New Button()
        BtnPunto = New Button()
        BtnSuma = New Button()
        BtnResta = New Button()
        BtnSeis = New Button()
        BtnCinco = New Button()
        BtnCuatro = New Button()
        BtnDivision = New Button()
        BtnNueve = New Button()
        BtnOcho = New Button()
        BtnSiete = New Button()
        BtnBorrar = New Button()
        LabelOperaciones = New Label()
        SuspendLayout()
        ' 
        ' BtnUno
        ' 
        BtnUno.FlatAppearance.MouseDownBackColor = Color.MediumPurple
        BtnUno.FlatAppearance.MouseOverBackColor = Color.MediumPurple
        BtnUno.FlatStyle = FlatStyle.Flat
        BtnUno.Font = New Font("Segoe UI", 35F)
        BtnUno.ForeColor = Color.White
        BtnUno.Location = New Point(12, 285)
        BtnUno.Name = "BtnUno"
        BtnUno.Size = New Size(103, 90)
        BtnUno.TabIndex = 0
        BtnUno.Text = "1"
        BtnUno.UseVisualStyleBackColor = True
        ' 
        ' BtnDos
        ' 
        BtnDos.FlatAppearance.MouseDownBackColor = Color.MediumPurple
        BtnDos.FlatAppearance.MouseOverBackColor = Color.MediumPurple
        BtnDos.FlatStyle = FlatStyle.Flat
        BtnDos.Font = New Font("Segoe UI", 35F)
        BtnDos.ForeColor = Color.White
        BtnDos.Location = New Point(124, 285)
        BtnDos.Name = "BtnDos"
        BtnDos.Size = New Size(103, 90)
        BtnDos.TabIndex = 2
        BtnDos.Text = "2"
        BtnDos.UseVisualStyleBackColor = True
        ' 
        ' BtnTres
        ' 
        BtnTres.FlatAppearance.MouseDownBackColor = Color.MediumPurple
        BtnTres.FlatAppearance.MouseOverBackColor = Color.MediumPurple
        BtnTres.FlatStyle = FlatStyle.Flat
        BtnTres.Font = New Font("Segoe UI", 35F)
        BtnTres.ForeColor = Color.White
        BtnTres.Location = New Point(236, 285)
        BtnTres.Name = "BtnTres"
        BtnTres.Size = New Size(103, 90)
        BtnTres.TabIndex = 3
        BtnTres.Text = "3"
        BtnTres.UseVisualStyleBackColor = True
        ' 
        ' LabelResultado
        ' 
        LabelResultado.Font = New Font("Segoe UI", 25F)
        LabelResultado.ForeColor = Color.White
        LabelResultado.Location = New Point(12, 37)
        LabelResultado.Name = "LabelResultado"
        LabelResultado.Size = New Size(548, 43)
        LabelResultado.TabIndex = 4
        LabelResultado.Text = "0"
        LabelResultado.TextAlign = ContentAlignment.TopRight
        ' 
        ' BtnMultiplicacion
        ' 
        BtnMultiplicacion.FlatAppearance.MouseDownBackColor = Color.MediumPurple
        BtnMultiplicacion.FlatAppearance.MouseOverBackColor = Color.MediumPurple
        BtnMultiplicacion.FlatStyle = FlatStyle.Flat
        BtnMultiplicacion.Font = New Font("Segoe UI", 35F)
        BtnMultiplicacion.ForeColor = Color.White
        BtnMultiplicacion.Location = New Point(348, 285)
        BtnMultiplicacion.Name = "BtnMultiplicacion"
        BtnMultiplicacion.Size = New Size(103, 90)
        BtnMultiplicacion.TabIndex = 5
        BtnMultiplicacion.Text = "x"
        BtnMultiplicacion.UseVisualStyleBackColor = True
        ' 
        ' BtnResultado
        ' 
        BtnResultado.FlatAppearance.MouseDownBackColor = Color.MediumPurple
        BtnResultado.FlatAppearance.MouseOverBackColor = Color.MediumPurple
        BtnResultado.FlatStyle = FlatStyle.Flat
        BtnResultado.Font = New Font("Segoe UI", 35F)
        BtnResultado.ForeColor = Color.White
        BtnResultado.Location = New Point(457, 189)
        BtnResultado.Name = "BtnResultado"
        BtnResultado.Size = New Size(103, 282)
        BtnResultado.TabIndex = 6
        BtnResultado.Text = "="
        BtnResultado.UseVisualStyleBackColor = True
        ' 
        ' BtnCero
        ' 
        BtnCero.FlatAppearance.MouseDownBackColor = Color.MediumPurple
        BtnCero.FlatAppearance.MouseOverBackColor = Color.MediumPurple
        BtnCero.FlatStyle = FlatStyle.Flat
        BtnCero.Font = New Font("Segoe UI", 35F)
        BtnCero.ForeColor = Color.White
        BtnCero.Location = New Point(12, 381)
        BtnCero.Name = "BtnCero"
        BtnCero.Size = New Size(215, 90)
        BtnCero.TabIndex = 7
        BtnCero.Text = "0"
        BtnCero.UseVisualStyleBackColor = True
        ' 
        ' BtnPunto
        ' 
        BtnPunto.FlatAppearance.MouseDownBackColor = Color.MediumPurple
        BtnPunto.FlatAppearance.MouseOverBackColor = Color.MediumPurple
        BtnPunto.FlatStyle = FlatStyle.Flat
        BtnPunto.Font = New Font("Segoe UI", 35F)
        BtnPunto.ForeColor = Color.White
        BtnPunto.Location = New Point(237, 381)
        BtnPunto.Name = "BtnPunto"
        BtnPunto.Size = New Size(103, 90)
        BtnPunto.TabIndex = 8
        BtnPunto.Text = ","
        BtnPunto.UseVisualStyleBackColor = True
        ' 
        ' BtnSuma
        ' 
        BtnSuma.FlatAppearance.MouseDownBackColor = Color.MediumPurple
        BtnSuma.FlatAppearance.MouseOverBackColor = Color.MediumPurple
        BtnSuma.FlatStyle = FlatStyle.Flat
        BtnSuma.Font = New Font("Segoe UI", 35F)
        BtnSuma.ForeColor = Color.White
        BtnSuma.Location = New Point(348, 381)
        BtnSuma.Name = "BtnSuma"
        BtnSuma.Size = New Size(103, 90)
        BtnSuma.TabIndex = 9
        BtnSuma.Text = "+"
        BtnSuma.UseVisualStyleBackColor = True
        ' 
        ' BtnResta
        ' 
        BtnResta.FlatAppearance.MouseDownBackColor = Color.MediumPurple
        BtnResta.FlatAppearance.MouseOverBackColor = Color.MediumPurple
        BtnResta.FlatStyle = FlatStyle.Flat
        BtnResta.Font = New Font("Segoe UI", 35F)
        BtnResta.ForeColor = Color.White
        BtnResta.Location = New Point(348, 189)
        BtnResta.Name = "BtnResta"
        BtnResta.Size = New Size(103, 90)
        BtnResta.TabIndex = 13
        BtnResta.Text = "-"
        BtnResta.UseVisualStyleBackColor = True
        ' 
        ' BtnSeis
        ' 
        BtnSeis.FlatAppearance.MouseDownBackColor = Color.MediumPurple
        BtnSeis.FlatAppearance.MouseOverBackColor = Color.MediumPurple
        BtnSeis.FlatStyle = FlatStyle.Flat
        BtnSeis.Font = New Font("Segoe UI", 35F)
        BtnSeis.ForeColor = Color.White
        BtnSeis.Location = New Point(236, 189)
        BtnSeis.Name = "BtnSeis"
        BtnSeis.Size = New Size(103, 90)
        BtnSeis.TabIndex = 12
        BtnSeis.Text = "6"
        BtnSeis.UseVisualStyleBackColor = True
        ' 
        ' BtnCinco
        ' 
        BtnCinco.FlatAppearance.MouseDownBackColor = Color.MediumPurple
        BtnCinco.FlatAppearance.MouseOverBackColor = Color.MediumPurple
        BtnCinco.FlatStyle = FlatStyle.Flat
        BtnCinco.Font = New Font("Segoe UI", 35F)
        BtnCinco.ForeColor = Color.White
        BtnCinco.Location = New Point(124, 189)
        BtnCinco.Name = "BtnCinco"
        BtnCinco.Size = New Size(103, 90)
        BtnCinco.TabIndex = 11
        BtnCinco.Text = "5"
        BtnCinco.UseVisualStyleBackColor = True
        ' 
        ' BtnCuatro
        ' 
        BtnCuatro.FlatAppearance.MouseDownBackColor = Color.MediumPurple
        BtnCuatro.FlatAppearance.MouseOverBackColor = Color.MediumPurple
        BtnCuatro.FlatStyle = FlatStyle.Flat
        BtnCuatro.Font = New Font("Segoe UI", 35F)
        BtnCuatro.ForeColor = Color.White
        BtnCuatro.Location = New Point(12, 189)
        BtnCuatro.Name = "BtnCuatro"
        BtnCuatro.Size = New Size(103, 90)
        BtnCuatro.TabIndex = 10
        BtnCuatro.Text = "4"
        BtnCuatro.UseVisualStyleBackColor = True
        ' 
        ' BtnDivision
        ' 
        BtnDivision.FlatAppearance.MouseDownBackColor = Color.MediumPurple
        BtnDivision.FlatAppearance.MouseOverBackColor = Color.MediumPurple
        BtnDivision.FlatStyle = FlatStyle.Flat
        BtnDivision.Font = New Font("Segoe UI", 35F)
        BtnDivision.ForeColor = Color.White
        BtnDivision.Location = New Point(348, 93)
        BtnDivision.Name = "BtnDivision"
        BtnDivision.Size = New Size(103, 90)
        BtnDivision.TabIndex = 17
        BtnDivision.Text = "/"
        BtnDivision.UseVisualStyleBackColor = True
        ' 
        ' BtnNueve
        ' 
        BtnNueve.FlatAppearance.MouseDownBackColor = Color.MediumPurple
        BtnNueve.FlatAppearance.MouseOverBackColor = Color.MediumPurple
        BtnNueve.FlatStyle = FlatStyle.Flat
        BtnNueve.Font = New Font("Segoe UI", 35F)
        BtnNueve.ForeColor = Color.White
        BtnNueve.Location = New Point(236, 93)
        BtnNueve.Name = "BtnNueve"
        BtnNueve.Size = New Size(103, 90)
        BtnNueve.TabIndex = 16
        BtnNueve.Text = "9"
        BtnNueve.UseVisualStyleBackColor = True
        ' 
        ' BtnOcho
        ' 
        BtnOcho.FlatAppearance.MouseDownBackColor = Color.MediumPurple
        BtnOcho.FlatAppearance.MouseOverBackColor = Color.MediumPurple
        BtnOcho.FlatStyle = FlatStyle.Flat
        BtnOcho.Font = New Font("Segoe UI", 35F)
        BtnOcho.ForeColor = Color.White
        BtnOcho.Location = New Point(124, 93)
        BtnOcho.Name = "BtnOcho"
        BtnOcho.Size = New Size(103, 90)
        BtnOcho.TabIndex = 15
        BtnOcho.Text = "8"
        BtnOcho.UseVisualStyleBackColor = True
        ' 
        ' BtnSiete
        ' 
        BtnSiete.FlatAppearance.MouseDownBackColor = Color.MediumPurple
        BtnSiete.FlatAppearance.MouseOverBackColor = Color.MediumPurple
        BtnSiete.FlatStyle = FlatStyle.Flat
        BtnSiete.Font = New Font("Segoe UI", 35F)
        BtnSiete.ForeColor = Color.White
        BtnSiete.Location = New Point(12, 93)
        BtnSiete.Name = "BtnSiete"
        BtnSiete.Size = New Size(103, 90)
        BtnSiete.TabIndex = 14
        BtnSiete.Text = "7"
        BtnSiete.UseVisualStyleBackColor = True
        ' 
        ' BtnBorrar
        ' 
        BtnBorrar.FlatAppearance.MouseDownBackColor = Color.MediumPurple
        BtnBorrar.FlatAppearance.MouseOverBackColor = Color.MediumPurple
        BtnBorrar.FlatStyle = FlatStyle.Flat
        BtnBorrar.Font = New Font("Segoe UI", 35F)
        BtnBorrar.ForeColor = Color.White
        BtnBorrar.Location = New Point(457, 93)
        BtnBorrar.Name = "BtnBorrar"
        BtnBorrar.Size = New Size(103, 90)
        BtnBorrar.TabIndex = 18
        BtnBorrar.Text = "C"
        BtnBorrar.UseVisualStyleBackColor = True
        ' 
        ' LabelOperaciones
        ' 
        LabelOperaciones.Font = New Font("Segoe UI", 10F)
        LabelOperaciones.ForeColor = Color.White
        LabelOperaciones.Location = New Point(12, 11)
        LabelOperaciones.Name = "LabelOperaciones"
        LabelOperaciones.Size = New Size(548, 26)
        LabelOperaciones.TabIndex = 19
        LabelOperaciones.TextAlign = ContentAlignment.TopRight
        ' 
        ' FormCalculadoraBasica
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(2), CByte(30), CByte(45))
        ClientSize = New Size(566, 483)
        Controls.Add(LabelOperaciones)
        Controls.Add(BtnBorrar)
        Controls.Add(BtnDivision)
        Controls.Add(BtnNueve)
        Controls.Add(BtnOcho)
        Controls.Add(BtnSiete)
        Controls.Add(BtnResta)
        Controls.Add(BtnSeis)
        Controls.Add(BtnCinco)
        Controls.Add(BtnCuatro)
        Controls.Add(BtnSuma)
        Controls.Add(BtnPunto)
        Controls.Add(BtnCero)
        Controls.Add(BtnResultado)
        Controls.Add(BtnMultiplicacion)
        Controls.Add(LabelResultado)
        Controls.Add(BtnTres)
        Controls.Add(BtnDos)
        Controls.Add(BtnUno)
        Name = "FormCalculadoraBasica"
        Text = "FormCalculadoraBasica"
        ResumeLayout(False)
    End Sub

    Friend WithEvents BtnUno As Button
    Friend WithEvents BtnDos As Button
    Friend WithEvents BtnTres As Button
    Friend WithEvents LabelResultado As Label
    Friend WithEvents BtnMultiplicacion As Button
    Friend WithEvents BtnResultado As Button
    Friend WithEvents BtnCero As Button
    Friend WithEvents BtnPunto As Button
    Friend WithEvents BtnSuma As Button
    Friend WithEvents BtnResta As Button
    Friend WithEvents BtnSeis As Button
    Friend WithEvents BtnCinco As Button
    Friend WithEvents BtnCuatro As Button
    Friend WithEvents BtnDivision As Button
    Friend WithEvents BtnNueve As Button
    Friend WithEvents BtnOcho As Button
    Friend WithEvents BtnSiete As Button
    Friend WithEvents BtnBorrar As Button
    Friend WithEvents LabelOperaciones As Label
End Class
