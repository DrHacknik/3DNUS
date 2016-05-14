Public Class init_config
    Private Sub init_config_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FadeIn()
    End Sub

    Private Sub t_dev_opacity_Tick(sender As Object, e As EventArgs)

    End Sub

    Private Sub init_config_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        fadeout()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub
    Public Sub FadeIn()
        Dim fade As Double
        For fade = 0.0 To 1.1 Step 0.1
            Me.Opacity = fade
            Me.Refresh()
            Threading.Thread.Sleep(100)
        Next
    End Sub

    Public Sub fadeout()
        Dim Fade As Double
        For Fade = 1.1 To 0.0 Step -0.1
            Me.Opacity = Fade
            Me.Refresh()
            Threading.Thread.Sleep(100)
        Next
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        End
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        If vs8.Checked = True Then
            My.Settings.dev_vs = "vs8"
        End If
        If vs10.Checked = True Then
            My.Settings.dev_vs = "vs10"
        End If
        If vs12_13.Checked = True Then
            My.Settings.dev_vs = "vs12_13"
        End If
        If vs15_16.Checked = True Then
            My.Settings.dev_vs = "vs15_16"
        End If
        If vs_no_use.Checked = True Then
            My.Settings.dev_vs = "vs_no_use"
        End If
        If vs_not_installed.Checked = True Then
            My.Settings.dev_vs = "vs_not_installed"
        End If
        My.Settings.dev_init_com = "1"
        My.Settings.Save()
        Me.Close()
        DevKit___What_to_Do.Show()
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Process.Start("https://www.visualstudio.com/en-us/downloads")
    End Sub
End Class