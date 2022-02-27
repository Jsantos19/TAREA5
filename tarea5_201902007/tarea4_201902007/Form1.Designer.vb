<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.btn_Calcular = New System.Windows.Forms.Button()
        Me.txt_factor = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbl_resultado = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lbl_factorial = New System.Windows.Forms.Label()
        Me.lbl_multiplos = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btn_Calcular
        '
        Me.btn_Calcular.Font = New System.Drawing.Font("Impact", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btn_Calcular.Location = New System.Drawing.Point(351, 160)
        Me.btn_Calcular.Name = "btn_Calcular"
        Me.btn_Calcular.Size = New System.Drawing.Size(160, 46)
        Me.btn_Calcular.TabIndex = 1
        Me.btn_Calcular.Text = "CALCULAR"
        Me.btn_Calcular.UseVisualStyleBackColor = True
        '
        'txt_factor
        '
        Me.txt_factor.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txt_factor.Location = New System.Drawing.Point(374, 106)
        Me.txt_factor.Name = "txt_factor"
        Me.txt_factor.Size = New System.Drawing.Size(123, 35)
        Me.txt_factor.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(216, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(452, 30)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Cálculo factorial de un número y multiplos de 4"
        '
        'lbl_resultado
        '
        Me.lbl_resultado.AutoSize = True
        Me.lbl_resultado.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbl_resultado.Location = New System.Drawing.Point(12, 217)
        Me.lbl_resultado.Name = "lbl_resultado"
        Me.lbl_resultado.Size = New System.Drawing.Size(104, 30)
        Me.lbl_resultado.TabIndex = 4
        Me.lbl_resultado.Text = "Resultado"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(390, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(121, 30)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "201902007"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(136, 269)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(0, 15)
        Me.Label3.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(12, 269)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(101, 30)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Factorial: "
        '
        'lbl_factorial
        '
        Me.lbl_factorial.AutoSize = True
        Me.lbl_factorial.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbl_factorial.Location = New System.Drawing.Point(112, 269)
        Me.lbl_factorial.Name = "lbl_factorial"
        Me.lbl_factorial.Size = New System.Drawing.Size(265, 30)
        Me.lbl_factorial.TabIndex = 8
        Me.lbl_factorial.Text = "____________________________"
        '
        'lbl_multiplos
        '
        Me.lbl_multiplos.AutoSize = True
        Me.lbl_multiplos.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbl_multiplos.Location = New System.Drawing.Point(12, 332)
        Me.lbl_multiplos.Name = "lbl_multiplos"
        Me.lbl_multiplos.Size = New System.Drawing.Size(110, 30)
        Me.lbl_multiplos.TabIndex = 9
        Me.lbl_multiplos.Text = "Multiplos: "
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(928, 494)
        Me.Controls.Add(Me.lbl_multiplos)
        Me.Controls.Add(Me.lbl_factorial)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lbl_resultado)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_factor)
        Me.Controls.Add(Me.btn_Calcular)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_Calcular As Button
    Friend WithEvents txt_factor As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lbl_resultado As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lbl_factorial As Label
    Friend WithEvents lbl_multiplos As Label
End Class
