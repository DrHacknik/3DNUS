Imports System.IO
Imports Ionic
Imports Ionic.Zip

'The following code, grabs (Downloads) the latest .zip files of the Preloaded extensions.
'Then installs them to their Default slots. This is done by using My.Computer.Network.DownloadFile. 
'Then it saves them to "ROOT\Extensions\_ext\Temp"; then proceedes to Extract them. 
'You can change the URL's, and the Directorys. 
'This Program use's Ionic.zip to Extract the Archvies (This supports: .zip, .tar, .tar.gz, and .rar)
'If the Ionic.zip .dll fails to Extract an Archive to the Path specified, the Code will change the text of the Status label to:
'"Installation has Failed! --dev_all.fail" or "An Extension has Failed to Install! --zip.fail". 
Public Class dev_grabbing_files
    Dim cd = Application.StartupPath
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        End
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click
        dev_begin.Close()
    End Sub

    Private Sub dev_grabbing_files_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Computer.Network.IsAvailable = False Then
            MessageBox.Show("Error: No Network connection Detected! --network.download.fail --zip.fail", "", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Else
            Directory.CreateDirectory(cd + "\\Extensions\\_ext\\Temp")
            Directory.CreateDirectory(cd + "\\Extensions\\_ext\\Slot1")
            Directory.CreateDirectory(cd + "\\Extensions\\_ext\\Slot2")
            Directory.CreateDirectory(cd + "\\Extensions\\_ext\\Slot3")
            Directory.CreateDirectory(cd + "\\Extensions\\_ext\\Slot4")

            My.Computer.Network.DownloadFile("https://raw.githubusercontent.com/zoltx23/3DNUS/master/ext_market/packages/tools/%40dr_hacknik/citra_emu/citra.zip", cd + "\\Extensions\\_ext\\Temp\\citra.zip")
            My.Computer.Network.DownloadFile("https://raw.githubusercontent.com/zoltx23/3DNUS/master/ext_market/packages/tools/%40dr_hacknik/devkit/devkit.zip", cd + "\\Extensions\\_ext\\Temp\\devkit.zip")
            My.Computer.Network.DownloadFile("https://raw.githubusercontent.com/zoltx23/3DNUS/master/ext_market/packages/tools/%40dr_hacknik/nand_tool/nand_tool.zip", cd + "\\Extensions\\_ext\\Temp\\nand_tool.zip")
            My.Computer.Network.DownloadFile("https://raw.githubusercontent.com/zoltx23/3DNUS/master/ext_market/packages/tools/%40dr_hacknik/nandify/nandify.zip", cd + "\\Extensions\\_ext\\Temp\\nandify.zip")
            Label2.Text = "Download Complete...Installing Extensions"

            '  Catch

            'MessageBox.Show("Error: An Unknown Error has Ocurred! One of the Following may be the Cause; --IO.Create_Directory --network.download.fail --zip.fail", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            'Label2.Text = "Installation has Failed! --dev_all.fail"
            'Label2.ForeColor = Color.Red

            ' End Try

            Try
                Dim ZipToUnpack As String = cd + "\\Extensions\\_ext\\Temp\\citra.zip"
                Dim TargetDir As String = Application.StartupPath + "\\Extensions\\_ext\\Slot1"

                Using zip1 As ZipFile = ZipFile.Read(ZipToUnpack)
                    Dim f As ZipEntry
                    ' here, we extract every entry, but we could extract    
                    ' based on entry name, size, date, etc.   
                    For Each f In zip1
                        f.Extract(TargetDir, ExtractExistingFileAction.OverwriteSilently)

                    Next
                    Label2.Text = "Installation Completed!"
                End Using
            Catch
                Label2.Text = "An Extension has Failed to Install! --zip.fail"
                Label2.ForeColor = Color.Red
            End Try
            Try
                Dim ZipToUnpack As String = cd + "\\Extensions\\_ext\\Temp\\devkit.zip"
                Dim TargetDir As String = Application.StartupPath + "\\Extensions\\_ext\\Slot2"

                Using zip1 As ZipFile = ZipFile.Read(ZipToUnpack)
                    Dim f As ZipEntry
                    ' here, we extract every entry, but we could extract    
                    ' based on entry name, size, date, etc.   
                    For Each f In zip1
                        f.Extract(TargetDir, ExtractExistingFileAction.OverwriteSilently)

                    Next
                    Label2.Text = "Installation Completed!"
                End Using
            Catch
                Label2.Text = "An Extension has Failed to Install! --zip.fail"
                Label2.ForeColor = Color.Red
            End Try
            Try
                Dim ZipToUnpack As String = cd + "\\Extensions\\_ext\\Temp\\nand_tool.zip"
                Dim TargetDir As String = Application.StartupPath + "\\Extensions\\_ext\\Slot4"

                Using zip1 As ZipFile = ZipFile.Read(ZipToUnpack)
                    Dim f As ZipEntry
                    ' here, we extract every entry, but we could extract    
                    ' based on entry name, size, date, etc.   
                    For Each f In zip1
                        f.Extract(TargetDir, ExtractExistingFileAction.OverwriteSilently)

                    Next
                    Label2.Text = "Installation Completed!"
                End Using
            Catch
                Label2.Text = "An Extension has Failed to Install! --zip.fail"
                Label2.ForeColor = Color.Red
            End Try
            Try
                Dim ZipToUnpack As String = cd + "\\Extensions\\_ext\\Temp\\nandify.zip"
                Dim TargetDir As String = Application.StartupPath + "\\Extensions\\_ext\\Slot3"

                Using zip1 As ZipFile = ZipFile.Read(ZipToUnpack)
                    Dim f As ZipEntry
                    ' here, we extract every entry, but we could extract    
                    ' based on entry name, size, date, etc.   
                    For Each f In zip1
                        f.Extract(TargetDir, ExtractExistingFileAction.OverwriteSilently)

                    Next
                    Label2.Text = "Installation Completed!"
                End Using
            Catch
                Label2.Text = "An Extension has Failed to Install! --zip.fail"
                Label2.ForeColor = Color.Red
            End Try
            File.Delete(cd + "\\Extensions\\_ext\\Temp\\citra.zip")
            File.Delete(cd + "\\Extensions\\_ext\\Temp\\devkit.zip")
            File.Delete(cd + "\\Extensions\\_ext\\Temp\\nand_tool.zip")
            File.Delete(cd + "\\Extensions\\_ext\\Temp\\nandify.zip")
            Directory.Delete(cd + "\\Extensions\\_ext\\Temp")
            dev_custom_finish.Show()
            Me.Close()
        End If


    End Sub
End Class
