Public Class Jeu_Wanted
    Dim numlist As New Random
    Dim randomnum As Integer = numlist.Next(0, 101)

    Dim coup As Integer

    Private Sub Jeu_Wanted_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = "Indique ton nombre entre 0 à 100"
        Label1.Left = (Me.Width / 2) - (Label1.Width / 2)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        coup += 1
        If TextBox1.Text = randomnum Then
            MsgBox("Bien jouer tu as réussi as trouver le nombre aléatoire ! Tu as fais " & coup & " coup(s).")
            MenuPrincipal.Show()
            Me.Hide()
        Else
            If TextBox1.Text > 100 Then
                Label1.Text = "Oupss, Ton nombre est trop grand, choisi un nombre plus petit ou égale à 100 !"
                Label1.Left = (Me.Width / 2) - (Label1.Width / 2)
            ElseIf TextBox1.Text < 0 Then
                Label1.Text = "Oupss, Ton nombre est trop pe tit, choisi un nombre plus grand ou égale à 0 !"
                Label1.Left = (Me.Width / 2) - (Label1.Width / 2)

            ElseIf TextBox1.Text > randomnum Then
                Label1.Text = "Ton nombre est trop grand, tu y es presque !"
                Label1.Left = (Me.Width / 2) - (Label1.Width / 2)
            ElseIf TextBox1.Text < randomnum Then
                Label1.Text = "Ton nombre est trop petit, tu y es presque !"
                Label1.Left = (Me.Width / 2) - (Label1.Width / 2)
            End If
        End If
        TextBox1.Clear()
    End Sub
End Class