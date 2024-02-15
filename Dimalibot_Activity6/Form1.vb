Public Class Form1
    Private Sub btndivide_Click(sender As Object, e As EventArgs) Handles btndivide.Click
        If txtFirstnumber.Text = "" Or txtSecondnumber.Text = "" Then
            MessageBox.Show("Please complete the entry first!")
        Else
            Try
                Dim a, b As Integer
                a = txtFirstnumber.Text
                b = txtSecondnumber.Text
            Catch ex As Exception
                MessageBox.Show(ex.ToString)

            End Try
        End If
    End Sub
End Class
