Public Class dev_begin
    Dim cd = Application.StartupPath
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        End
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Timer1.Start()
        My.Settings.lang_selected = ComboBox1.Text
        My.Settings.Save()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        dev_eula.Show()
        Me.Hide()
        Timer1.Stop()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub dev_begin_Load(sender As Object, e As EventArgs)

    End Sub

    Private Sub dev_begin_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load
        AxWindowsMediaPlayer1.URL = cd + "\\sds\\upd_bck_music.mp3"
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs)

    End Sub
End Class
