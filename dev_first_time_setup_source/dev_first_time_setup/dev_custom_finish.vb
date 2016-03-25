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
End Class