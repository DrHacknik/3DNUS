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
        If My.Settings.cache_state = Nothing Then
            Timer1.Interval = 55
            Label1.Text = "Building Cache..."
            'This is where the Building Cache for Extensions would go. 
            'Basically a Database

            My.Settings.cache_state = "1"
            My.Settings.Save()
        End If
        If My.Settings.cache_state = "1" Then
            Timer1.Interval = 3
            Label1.Text = My.Settings.settings_load_text



        End If
        If My.Settings.cache_state = "0" Then
            Timer1.Interval = 55
            Label1.Text = "Building Cache..."
            'This is where the Building Cache for Extensions would go. 
            'Basically a Database
        End If
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click

    End Sub
End Class
