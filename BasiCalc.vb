Public Class BasiCalc
    Private Sub Add_Click(sender As Object, e As EventArgs) Handles Add.Click
        Number3.Text = Str(Number1.Value + Number2.Value)
    End Sub

    Private Sub Subtract_Click(sender As Object, e As EventArgs) Handles Subtract.Click
        Number3.Text = Str(Number1.Value - Number2.Value)
    End Sub

    Private Sub Multiply_Click(sender As Object, e As EventArgs) Handles Multiply.Click
        Number3.Text = Str(Number1.Value * Number2.Value)
    End Sub

    Private Sub Divide_Click(sender As Object, e As EventArgs) Handles Divide.Click
        Try
            Number3.Text = Str(Number1.Value / Number2.Value)
        Catch
            Number3.Text = "ERR"
        End Try
    End Sub

    Private Sub BasiCalc_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Number3.Text = "0"
    End Sub
End Class