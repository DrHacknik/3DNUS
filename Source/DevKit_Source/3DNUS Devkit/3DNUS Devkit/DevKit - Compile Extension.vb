Imports System.IO.Compression
Imports System.Threading.Tasks
Imports Ionic.Zip
Imports System.IO
Imports Microsoft.SqlServer

Public Class DevKit___Compile_Extension
    Dim cd = Path.GetDirectoryName(Application.ExecutablePath)

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Source_Sel.ShowDialog()
    End Sub

    Private Sub Output_HelpRequest(sender As Object, e As EventArgs) Handles Output.HelpRequest

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Output.ShowDialog()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            TextBox2.Enabled = False
            Label7.Text = "Copying Files..."
            Directory.CreateDirectory(cd + "\\Temp")
            My.Computer.FileSystem.WriteAllText(cd + "\\Temp\\ext_info.ini", TextBox2.Text, True)
            My.Computer.FileSystem.CopyDirectory(Source_Sel.SelectedPath, cd + "\\Temp", True)
            RichTextBox1.SaveFile(cd + "\\Temp\\" + "\\Source_dir.txt", RichTextBoxStreamType.PlainText)
            'My.Computer.FileSystem.CreateDirectory(cd + "\\Temp\\" + TextBox2.Text)
            Dim FileToCopy As String
            Dim NewCopy As String

            FileToCopy = Icon_Sel.FileName
            NewCopy = cd + "\\Temp\\" + "\\ext_icon.png"

            If System.IO.File.Exists(FileToCopy) = True Then

                System.IO.File.Copy(FileToCopy, NewCopy)

            End If
            FileToCopy = Short_Desc.FileName
            NewCopy = cd + "\\Temp\\" + "\\ext_desc.ini"

            If System.IO.File.Exists(FileToCopy) = True Then

                System.IO.File.Copy(FileToCopy, NewCopy)

            End If
            FileToCopy = Long_Desc.FileName
            NewCopy = cd + "\\Temp\\" + "\\ext_desc_long.ini"

            If System.IO.File.Exists(FileToCopy) = True Then

                System.IO.File.Copy(FileToCopy, NewCopy)

            End If

            Label7.Text = "Compiling .ZIP...."
            ' ZIP ALL FILES IN THE FOLDER.
            Using zip As New Ionic.Zip.ZipFile()

                ' CREATE A FILE USING A STRING.
                ' THE FILE WILL BE STORED INSIDE THE ZIP FILE.

                ' ZIP THE FOLDER WITH THE FILES IN IT.
                zip.AddFiles(cd + "\\Temp")

                zip.Save(cd + "\\" + TextBox2.Text + ".zip")           ' SAVE THE ZIP FILE.
                Label7.Text = "All Done!"
            End Using

            ' My.Computer.FileSystem.RenameFile(cd + "False", TextBox2.Text + ".zip")
        Catch ex1 As Exception
            TextBox2.Enabled = True
            Label7.Text = "Zip --Fail"
            MessageBox.Show("There was an Error When trying To Compress the Files. Try Zipping them Yourself (The Temp Dir) ", "Zip Manager v3", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub DevKit___Compile_Extension_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        DevKit___What_to_Do.Show()
        Me.Close()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Icon_Sel.ShowDialog()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Short_Desc.ShowDialog()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Long_Desc.ShowDialog()
    End Sub

    Private Sub Icon_Sel_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles Icon_Sel.FileOk
        TextBox3.Text = Icon_Sel.FileName
        PictureBox1.BackgroundImage = Image.FromFile(Icon_Sel.FileName)
    End Sub

    Private Sub Short_Desc_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles Short_Desc.FileOk
        Try

            RichTextBox1.LoadFile(Short_Desc.FileName)

        Catch ex As Exception : End Try
        TextBox4.Text = Short_Desc.FileName
    End Sub

    Private Sub Long_Desc_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles Long_Desc.FileOk
        Try

            RichTextBox1.LoadFile(Long_Desc.FileName)

        Catch ex As Exception : End Try
        TextBox5.Text = Long_Desc.FileName
    End Sub

    Private Sub Source_HelpRequest(sender As Object, e As EventArgs)

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        TextBox1.Text = Source_Sel.SelectedPath

    End Sub

    Private Sub Source_Sel_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs)

    End Sub
End Class