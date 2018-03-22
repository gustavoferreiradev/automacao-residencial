Public Class frmPrincipal

    Private Sub btnGaragem_Click(sender As Object, e As EventArgs) Handles btnGaragem.Click
        Dim AbrirForm As New frmGaragem

        frmGaragem.Show()





    End Sub

    Private Sub btnSala_Click(sender As Object, e As EventArgs) Handles btnSala.Click
        Dim AbrirForm As New frmSala

        frmSala.Show()

    End Sub

    Private Sub btnQuarto1_Click(sender As Object, e As EventArgs) Handles btnQuarto1.Click

        Dim AbrirForm As New frmQuarto1

        frmQuarto1.Show()

    End Sub

    Private Sub btnQuarto2_Click(sender As Object, e As EventArgs) Handles btnQuarto2.Click
        Dim AbrirForm As New frmQuarto2

        frmQuarto2.Show()
    End Sub

    Private Sub btnQuarto3_Click(sender As Object, e As EventArgs) Handles btnQuarto3.Click
        Dim AbrirForm As New frmQuarto3

        frmQuarto3.Show()
    End Sub

    Private Sub btnCozinha_Click(sender As Object, e As EventArgs) Handles btnCozinha.Click
        Dim AbrirForm As New frmCozinha
        frmCozinha.Show()

    End Sub

    Private Sub btnBanheiro_Click(sender As Object, e As EventArgs) Handles btnBanheiro.Click
        Dim AbrirForm As New frmBanheiro

        frmBanheiro.Show()
    End Sub
End Class
