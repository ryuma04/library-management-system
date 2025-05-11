Public Class Form1
    Private Sub ProgressBar1_Click(sender As Object, e As EventArgs) Handles ProgressBar1.Click

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(1)
        perc.Text = Convert.ToString(ProgressBar1.Value) + "%"
        If ProgressBar1.Value = 100 Then
            Me.Hide()
            'Dim log = New login'
            'Log.show()'
        End If

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()

    End Sub
End Class
