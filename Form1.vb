Public Class Form1

    Dim x, y, ans As Double
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        x = Val(TextBox1.Text)
        y = Val(TextBox2.Text)

        ans = x + y
        TextBoxSum.Text = ans

        ans = x * y
        TextBoxProduct.Text = ans

        ans = x - y
        TextBoxDifference.Text = ans

        ans = x / y
        TextBoxQuotient.Text = ans
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        TextBox1.Text = " "
        TextBox2.Text = " "
        TextBoxSum.Text = " "
        TextBoxProduct.Text = " "
        TextBoxDifference.Text = " "
        TextBoxQuotient.Text = " "

    End Sub

    Private Sub TextBox1_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles TextBox1.MaskInputRejected

    End Sub


    Private Sub MaskedTextBox1_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles TextBoxQuotient.MaskInputRejected

    End Sub
End Class
