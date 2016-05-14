Public Class DevKit___What_to_Do
    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Devkit_main.Show()
        Me.Close()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Settings.Show()
        Me.Close()
    End Sub

    Private Sub DevKit___What_to_Do_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        End
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        DevKit___Compile_Extension.Show()
        Me.Close()
    End Sub

    Private Sub DevKit___What_to_Do_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Settings.dev_init_com = Nothing Then
            Me.Close()
            init_config.Show()

        Else

        End If
    End Sub
End Class