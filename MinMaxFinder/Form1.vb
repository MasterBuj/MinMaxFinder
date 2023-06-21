Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim finder As Integer() = {CInt(n1.Text), CInt(n2.Text), CInt(n3.Text), CInt(n4.Text)}
        maxLabel.Text = finder.Max
        minLabel.Text = finder.Min
    End Sub

End Class
