<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.BtnPerro1 = New System.Windows.Forms.Button()
        Me.BtnPerro2 = New System.Windows.Forms.Button()
        Me.BtnPerro3 = New System.Windows.Forms.Button()
        Me.TxtResultado = New System.Windows.Forms.TextBox()
        Me.TxtResultado2 = New System.Windows.Forms.TextBox()
        Me.TxtResultado3 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'BtnPerro1
        '
        Me.BtnPerro1.Location = New System.Drawing.Point(157, 93)
        Me.BtnPerro1.Name = "BtnPerro1"
        Me.BtnPerro1.Size = New System.Drawing.Size(75, 23)
        Me.BtnPerro1.TabIndex = 0
        Me.BtnPerro1.Text = "Perro 1"
        Me.BtnPerro1.UseVisualStyleBackColor = True
        '
        'BtnPerro2
        '
        Me.BtnPerro2.Location = New System.Drawing.Point(157, 174)
        Me.BtnPerro2.Name = "BtnPerro2"
        Me.BtnPerro2.Size = New System.Drawing.Size(75, 23)
        Me.BtnPerro2.TabIndex = 1
        Me.BtnPerro2.Text = "Perro 2"
        Me.BtnPerro2.UseVisualStyleBackColor = True
        '
        'BtnPerro3
        '
        Me.BtnPerro3.Location = New System.Drawing.Point(157, 257)
        Me.BtnPerro3.Name = "BtnPerro3"
        Me.BtnPerro3.Size = New System.Drawing.Size(75, 23)
        Me.BtnPerro3.TabIndex = 2
        Me.BtnPerro3.Text = "Perro 3"
        Me.BtnPerro3.UseVisualStyleBackColor = True
        '
        'TxtResultado
        '
        Me.TxtResultado.Location = New System.Drawing.Point(12, 331)
        Me.TxtResultado.Name = "TxtResultado"
        Me.TxtResultado.Size = New System.Drawing.Size(380, 20)
        Me.TxtResultado.TabIndex = 3
        '
        'TxtResultado2
        '
        Me.TxtResultado2.Location = New System.Drawing.Point(12, 361)
        Me.TxtResultado2.Name = "TxtResultado2"
        Me.TxtResultado2.Size = New System.Drawing.Size(379, 20)
        Me.TxtResultado2.TabIndex = 4
        '
        'TxtResultado3
        '
        Me.TxtResultado3.Location = New System.Drawing.Point(14, 391)
        Me.TxtResultado3.Name = "TxtResultado3"
        Me.TxtResultado3.Size = New System.Drawing.Size(378, 20)
        Me.TxtResultado3.TabIndex = 5
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(296, 284)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(94, 32)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Salir"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(404, 450)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TxtResultado3)
        Me.Controls.Add(Me.TxtResultado2)
        Me.Controls.Add(Me.TxtResultado)
        Me.Controls.Add(Me.BtnPerro3)
        Me.Controls.Add(Me.BtnPerro2)
        Me.Controls.Add(Me.BtnPerro1)
        Me.Name = "Form1"
        Me.Text = "Ejemplo Clases "
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnPerro1 As Button
    Friend WithEvents BtnPerro2 As Button
    Friend WithEvents BtnPerro3 As Button
    Friend WithEvents TxtResultado As TextBox
    Friend WithEvents TxtResultado2 As TextBox
    Friend WithEvents TxtResultado3 As TextBox
    Friend WithEvents Button1 As Button
End Class
