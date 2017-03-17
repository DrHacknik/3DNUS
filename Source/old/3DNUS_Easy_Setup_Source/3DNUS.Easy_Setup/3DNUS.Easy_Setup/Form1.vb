Imports Ionic.Zip
Imports System.IO
Public Class Form1
    Dim cd = Application.StartupPath
    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        End
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Button2.Enabled = True
        TextBox1.Enabled = False
        Label3.Visible = False
        Label2.Text = "         Select a Folder to install to"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Directory.CreateDirectory(cd + "\\Temp")
        Catch ex As Exception

        End Try
        Label2.Text = "                Installing, please wait..."
        If RadioButton1.Checked = True Then
            My.Computer.Network.DownloadFile("https://raw.githubusercontent.com/zoltx23/3DNUS/master/3DNUS.Update_x86.zip", cd + "//Temp//3DNUS_Latest_x86.zip")
            Try
                Dim ZipToUnpack As String = cd + "//Temp//3DNUS_Latest_x86.zip"
                Dim TargetDir As String = install_to.SelectedPath

                Using zip1 As ZipFile = ZipFile.Read(ZipToUnpack)
                    Dim f As ZipEntry
                    ' here, we extract every entry, but we could extract    
                    ' based on entry name, size, date, etc.   
                    For Each f In zip1
                        f.Extract(TargetDir, ExtractExistingFileAction.OverwriteSilently)
                    Next
                    MessageBox.Show("The Install has Completed, the First time Setup wizard will now (try to) start.", "Installing 3DNUS: Completed", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Try
                        For Each foundFile As String In My.Computer.FileSystem.GetFiles(
       cd + "\\Temp",
        Microsoft.VisualBasic.FileIO.SearchOption.SearchAllSubDirectories, "*.*")

                            My.Computer.FileSystem.DeleteFile(foundFile,
                        FileIO.UIOption.OnlyErrorDialogs,
                        Microsoft.VisualBasic.FileIO.RecycleOption.DeletePermanently)
                        Next
                    Catch
                        MessageBox.Show("It seems that some Errors have occurred when Deleting the Temporary Files!", "Installing 3DNUS: Error(s)", MessageBoxButtons.OK, MessageBoxIcon.Error)

                    End Try
                    Try
                        Process.Start(install_to.SelectedPath + "\\3DNUS.Update_x86\\dev_first_time_setup.exe")
                        End
                    Catch
                        MessageBox.Show("It seems that some Errors have occurred when trying to Run the First Time Setup Wizard!", "Installing 3DNUS: Error(s)", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End Using
            Catch

            End Try
            '
            '
            '
            '
            '
            '
        End If
        If RadioButton2.Checked = True Then
            My.Computer.Network.DownloadFile("https://raw.githubusercontent.com/zoltx23/3DNUS/master/3DNUS.Update.zip", cd + "//Temp//3DNUS_Latest.zip")
            Try
                Dim ZipToUnpack As String = cd + "//Temp//3DNUS_Latest.zip"
                Dim TargetDir As String = install_to.SelectedPath

                Using zip1 As ZipFile = ZipFile.Read(ZipToUnpack)
                    Dim f As ZipEntry
                    ' here, we extract every entry, but we could extract    
                    ' based on entry name, size, date, etc.   
                    For Each f In zip1
                        f.Extract(TargetDir, ExtractExistingFileAction.OverwriteSilently)
                    Next
                    MessageBox.Show("The Install has Completed, the First time Setup wizard will now (try to) start.", "Installing 3DNUS: Completed", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Try
                        For Each foundFile As String In My.Computer.FileSystem.GetFiles(
       cd + "\\Temp",
        Microsoft.VisualBasic.FileIO.SearchOption.SearchAllSubDirectories, "*.*")

                            My.Computer.FileSystem.DeleteFile(foundFile,
                        FileIO.UIOption.OnlyErrorDialogs,
                        Microsoft.VisualBasic.FileIO.RecycleOption.DeletePermanently)
                        Next
                    Catch
                        MessageBox.Show("It seems that some Errors have occurred when Deleting the Temporary Files!", "Installing 3DNUS: Error(s)", MessageBoxButtons.OK, MessageBoxIcon.Error)

                    End Try
                    Try
                        Process.Start(install_to.SelectedPath + "\\3DNUS.Update\\dev_first_time_setup.exe")
                        End
                    Catch
                        MessageBox.Show("It seems that some Errors have occurred when trying to Run the First Time Setup Wizard!", "Installing 3DNUS: Error(s)", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End Using
            Catch
                'Do Nothing 
            End Try
        End If

        MessageBox.Show("The Install has Failed, please try again.", "Installing 3DNUS: Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        install_to.ShowDialog()
        Button1.Enabled = True
    End Sub

    Private Sub install_to_HelpRequest_1(sender As Object, e As EventArgs) Handles install_to.HelpRequest
        Label2.Text = "        Please Click the Button Install"
        install_to.SelectedPath = TextBox1.Text
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        TextBox1.Text = install_to.SelectedPath
    End Sub
End Class
