Imports System.Net
Imports System.IO
Imports System.IO.Compression
Imports System.ComponentModel
Imports Ionic.Zip

Public Class dev_grab_files
    Dim gt = New WebClient
    Dim cd = Application.StartupPath
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub

    Private Sub dev_grab_files_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim client As WebClient = New WebClient

        AddHandler client.DownloadProgressChanged, AddressOf client_ProgressChanged

        AddHandler client.DownloadFileCompleted, AddressOf client_DownloadCompleted

        client.DownloadFileAsync(New Uri("https://github.com/zoltx23/3DNUS/raw/master/3DNUS.Update_x86.zip"), cd + "\\firmware.zip")

        Label3.Text = "Download in Progress..."


    End Sub


    Private Sub client_ProgressChanged(ByVal sender As Object, ByVal e As DownloadProgressChangedEventArgs)

        Dim bytesIn As Double = Double.Parse(e.BytesReceived.ToString())

        Dim totalBytes As Double = Double.Parse(e.TotalBytesToReceive.ToString())

        Dim percentage As Double = bytesIn / totalBytes * 100



        ProgressBar1.Value = Int32.Parse(Math.Truncate(percentage).ToString())

    End Sub




    Private Sub client_DownloadCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.AsyncCompletedEventArgs)
        Label3.Text = "Download Completed!"
        RichTextBox1.Text += "
Preparing to unzip..."

        Dim ZipToUnpack As String = "firmware.zip"
        Dim TargetDir As String = cd + "\\nandify\\firmware"
        Console.WriteLine("Extracting file {0} to {1}", ZipToUnpack, TargetDir)
        Using zip1 As ZipFile = ZipFile.Read(ZipToUnpack)

            Dim f As ZipEntry
            ' here, we extract every entry, but we could extract    
            ' based on entry name, size, date, etc.   
            For Each f In zip1
                f.Extract(TargetDir, ExtractExistingFileAction.OverwriteSilently)
            Next
            Label3.Text = "All Done!"
            RichTextBox1.Text += "
Extraction Completed!"
            Button1.Enabled = True

        End Using
    End Sub




    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        RichTextBox1.Text += "
Grabbing Content from Server...."
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

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            RichTextBox1.Visible = True
        Else
            RichTextBox1.Visible = False
        End If
    End Sub
End Class