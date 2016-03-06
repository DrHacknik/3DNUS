Public Class Form1
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        PictureBox1.Width += 1
        If PictureBox1.Width = 304 Then
            Timer1.Stop()
            Label1.Location = New Point(133, 27)
            Label1.Text = "All Done!"
            Main.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = My.Settings.settings_load_text
        If My.Settings.settings_load_text = Nothing Then
            Label1.Text = "Brewing your Coffee, Please wait..."
        End If
    End Sub
End Class
