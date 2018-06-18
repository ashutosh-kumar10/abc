Public Class frmSum
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a, b, s As Double
        a = Convert.ToDouble(TextBox1.Text)
        b = Convert.ToDouble(TextBox2.Text)
        s = a + b
        Label1.Text = "Sum " + s
    End Sub
End Class