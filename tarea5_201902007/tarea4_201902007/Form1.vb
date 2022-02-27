Public Class Form1
    Private Sub btn_Calcular_Click(sender As Object, e As EventArgs) Handles btn_Calcular.Click
        Try
            Dim a As Integer = Int32.Parse(txt_factor.Text)
            Dim i, j As Long
            Dim indice = 2
            Dim resultado1 As String = ""
            Dim contador As Integer = 0
            j = 1
            For i = 1 To a Step 1
                j = j * i
            Next
            lbl_factorial.Text = j.ToString
            If (0 < j) Then
                While (indice <= j)
                    If (indice Mod 4 = 0) Then
                        resultado1 = resultado1 + indice.ToString + ","
                        contador = contador + 1
                    End If
                    indice = indice + 1
                End While
                lbl_resultado.Text = "Cantidad de multiplos de 4: " + contador.ToString
                lbl_multiplos.Text = resultado1.ToString
            Else
                MsgBox("SOLO NUMEROS POSITIVOS")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class
