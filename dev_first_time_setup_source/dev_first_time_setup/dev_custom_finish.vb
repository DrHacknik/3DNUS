Imports System.IO

Public Class dev_custom_finish
    Dim cd = Application.StartupPath
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Try
            My.Computer.FileSystem.WriteAllText(cd + "\\Config\\setup_completed.cfg", "1", True)
            Process.Start(cd + "\\3DNUS.exe")
            End
        Catch
            MessageBox.Show("There was a Problem when Trying to load 3DNUS, make sure it's still there!", "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Try
            Process.Start(cd + "\\3DNUS.exe")
            End
        Catch
            MessageBox.Show("There was a Problem when Trying to load 3DNUS, make sure it's still there!", "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub dev_custom_finish_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Settings.lang_selected = "Spanish, MX (Español)" Then
            Label2.Text = "¡Vamonos!"
            Label2.Location = New Point(134, 205)
        End If
        If My.Settings.lang_selected = "Spanish, US (Español)" Then
            Label2.Text = "¡Vamonos!"
            Label2.Location = New Point(134, 205)
        End If
        If My.Settings.lang_selected = "Spanish, UK (Español)" Then
            Label2.Text = "¡Vamonos!"
            Label2.Location = New Point(134, 205)
        End If
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        End
    End Sub
End Class