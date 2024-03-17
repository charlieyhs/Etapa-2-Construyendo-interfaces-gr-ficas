<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCalculadoraDias
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
        FechaDesde = New DateTimePicker()
        Label1 = New Label()
        Label2 = New Label()
        FechaHasta = New DateTimePicker()
        Label3 = New Label()
        BtnCalcular = New Button()
        LabelResultado = New Label()
        SuspendLayout()
        ' 
        ' FechaDesde
        ' 
        FechaDesde.Location = New Point(243, 126)
        FechaDesde.Name = "FechaDesde"
        FechaDesde.Size = New Size(200, 23)
        FechaDesde.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 20F)
        Label1.ForeColor = Color.White
        Label1.Location = New Point(131, 116)
        Label1.Name = "Label1"
        Label1.Size = New Size(91, 37)
        Label1.TabIndex = 1
        Label1.Text = "Desde"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 20F)
        Label2.ForeColor = Color.White
        Label2.Location = New Point(131, 182)
        Label2.Name = "Label2"
        Label2.Size = New Size(84, 37)
        Label2.TabIndex = 3
        Label2.Text = "Hasta"
        ' 
        ' FechaHasta
        ' 
        FechaHasta.Location = New Point(243, 194)
        FechaHasta.Name = "FechaHasta"
        FechaHasta.Size = New Size(200, 23)
        FechaHasta.TabIndex = 2
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 20F)
        Label3.ForeColor = Color.White
        Label3.Location = New Point(131, 338)
        Label3.Name = "Label3"
        Label3.Size = New Size(134, 37)
        Label3.TabIndex = 4
        Label3.Text = "Resultado"
        ' 
        ' BtnCalcular
        ' 
        BtnCalcular.FlatAppearance.MouseDownBackColor = Color.MediumPurple
        BtnCalcular.FlatAppearance.MouseOverBackColor = Color.MediumPurple
        BtnCalcular.FlatStyle = FlatStyle.Flat
        BtnCalcular.Font = New Font("Segoe UI", 20F)
        BtnCalcular.ForeColor = Color.White
        BtnCalcular.Location = New Point(131, 268)
        BtnCalcular.Name = "BtnCalcular"
        BtnCalcular.Size = New Size(312, 44)
        BtnCalcular.TabIndex = 5
        BtnCalcular.Text = "Calcular"
        BtnCalcular.UseVisualStyleBackColor = True
        ' 
        ' LabelResultado
        ' 
        LabelResultado.AutoSize = True
        LabelResultado.Font = New Font("Segoe UI", 20F)
        LabelResultado.ForeColor = Color.White
        LabelResultado.Location = New Point(271, 338)
        LabelResultado.Name = "LabelResultado"
        LabelResultado.Size = New Size(32, 37)
        LabelResultado.TabIndex = 6
        LabelResultado.Text = "0"
        ' 
        ' FormCalculadoraDias
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(2), CByte(30), CByte(45))
        ClientSize = New Size(566, 483)
        Controls.Add(LabelResultado)
        Controls.Add(BtnCalcular)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(FechaHasta)
        Controls.Add(Label1)
        Controls.Add(FechaDesde)
        Name = "FormCalculadoraDias"
        Text = "FormCalculadoraDias"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents FechaDesde As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents FechaHasta As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents BtnCalcular As Button
    Friend WithEvents LabelResultado As Label
End Class
