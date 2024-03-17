<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormConversionMonedas
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
        Label1 = New Label()
        Label2 = New Label()
        MonedaHacia = New ComboBox()
        Label3 = New Label()
        inputValor = New TextBox()
        Label4 = New Label()
        Button2 = New Button()
        Label5 = New Label()
        labelResultado = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 20F)
        Label1.ForeColor = Color.White
        Label1.Location = New Point(123, 127)
        Label1.Name = "Label1"
        Label1.Size = New Size(78, 37)
        Label1.TabIndex = 1
        Label1.Text = "Valor"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 20F)
        Label2.ForeColor = Color.White
        Label2.Location = New Point(123, 68)
        Label2.Name = "Label2"
        Label2.Size = New Size(91, 37)
        Label2.TabIndex = 2
        Label2.Text = "Desde"
        ' 
        ' MonedaHacia
        ' 
        MonedaHacia.FormattingEnabled = True
        MonedaHacia.Location = New Point(237, 206)
        MonedaHacia.Name = "MonedaHacia"
        MonedaHacia.Size = New Size(121, 23)
        MonedaHacia.TabIndex = 3
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 20F)
        Label3.ForeColor = Color.White
        Label3.Location = New Point(237, 68)
        Label3.Name = "Label3"
        Label3.Size = New Size(248, 37)
        Label3.TabIndex = 4
        Label3.Text = "Pesos Colombianos"
        ' 
        ' inputValor
        ' 
        inputValor.Location = New Point(237, 141)
        inputValor.Name = "inputValor"
        inputValor.Size = New Size(121, 23)
        inputValor.TabIndex = 5
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 20F)
        Label4.ForeColor = Color.White
        Label4.Location = New Point(123, 192)
        Label4.Name = "Label4"
        Label4.Size = New Size(83, 37)
        Label4.TabIndex = 6
        Label4.Text = "Hacia"
        ' 
        ' Button2
        ' 
        Button2.FlatAppearance.BorderColor = Color.White
        Button2.FlatAppearance.MouseDownBackColor = Color.MediumPurple
        Button2.FlatAppearance.MouseOverBackColor = Color.MediumPurple
        Button2.FlatStyle = FlatStyle.Flat
        Button2.ForeColor = Color.White
        Button2.Location = New Point(123, 263)
        Button2.Name = "Button2"
        Button2.Size = New Size(362, 23)
        Button2.TabIndex = 7
        Button2.Text = "Convertir"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 20F)
        Label5.ForeColor = Color.White
        Label5.Location = New Point(123, 325)
        Label5.Name = "Label5"
        Label5.Size = New Size(134, 37)
        Label5.TabIndex = 8
        Label5.Text = "Resultado"
        ' 
        ' labelResultado
        ' 
        labelResultado.AutoSize = True
        labelResultado.Font = New Font("Segoe UI", 20F)
        labelResultado.ForeColor = Color.White
        labelResultado.Location = New Point(287, 325)
        labelResultado.Name = "labelResultado"
        labelResultado.Size = New Size(32, 37)
        labelResultado.TabIndex = 9
        labelResultado.Text = "0"
        ' 
        ' FormConversionMonedas
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(2), CByte(30), CByte(45))
        ClientSize = New Size(550, 444)
        Controls.Add(labelResultado)
        Controls.Add(Label5)
        Controls.Add(Button2)
        Controls.Add(Label4)
        Controls.Add(inputValor)
        Controls.Add(Label3)
        Controls.Add(MonedaHacia)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "FormConversionMonedas"
        Text = "FormConversionMonedas"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents MonedaHacia As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents inputValor As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents labelResultado As Label
End Class
