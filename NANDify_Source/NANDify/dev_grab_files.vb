Imports System.Net
Imports System.IO
Public Class dev_grab_files
    Dim gt = New WebClient
    Dim cd = Application.StartupPath
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub

    Private Sub dev_grab_files_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Stop()
        If My.Computer.Network.IsAvailable = False Then
            RichTextBox1.Text += "
Network_test: Failed!
Unable to contact server!"
            MessageBox.Show("Error: Unable to connect to the Internet, please try again later!", "NANDify: Network Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End
        End If

        If My.Computer.Network.IsAvailable = True Then
            RichTextBox1.Text += "
Network_test: Passed!
Copied file: _fw_res.bin --> \firmware
Waiting for Server to Respond..."
        End If

        File.Copy(cd + "\nandify\_fw_res.bin", cd + "\nandify\firmware\_fw_res.bin")
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            RichTextBox1.Visible = True
        Else
            RichTextBox1.Visible = False
        End If
    End Sub
End Class