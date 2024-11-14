Public Class Form1
    Private Sub btn_Click(sender As Object, e As EventArgs) Handles btn.Click
        Dim taille = list.SelectedItem.ToString()
        Dim ingredient As String = " "
        If rb1.Checked Then
            ingredient = "croute fine"

        ElseIf rb2.Checked Then
            ingredient = "croute classique"
        ElseIf rb3.Checked Then
            ingredient = "croute epaisse"
        End If

        Dim ingrSupp As String = " "
        If b1.Checked Then
            ingrSupp = ingrSupp + "champigions"
        ElseIf b2.Checked Then
            ingrSupp = ingrSupp + "olives"
        ElseIf b3.Checked Then
            ingrSupp = ingrSupp + "poivrins"
        ElseIf b4.Checked Then
            ingrSupp = ingrSupp + "fromage supplimentaire"
        End If
        Dim msg As String = "Taille :" + taille + "Type de croute : " + ingredient + "ingredient  supplimentaires "
        MessageBox.Show(msg)



    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs)

    End Sub
End Class
