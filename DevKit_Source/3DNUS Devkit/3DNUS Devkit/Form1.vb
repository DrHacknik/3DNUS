Public Class Form1
    Private Sub timer2_Tick(sender As Object, e As EventArgs) Handles timer2.Tick
        'Load Config Files, and apply them. 
        label2.Text = "Found 20 Configs!"
        label2.Visible = True
        timer2.Stop()
        timer1.Start()

    End Sub

    Private Sub timer1_Tick(sender As Object, e As EventArgs) Handles timer1.Tick
        Me.Hide()
        DevKit___What_to_Do.Show()
        timer1.Stop()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
