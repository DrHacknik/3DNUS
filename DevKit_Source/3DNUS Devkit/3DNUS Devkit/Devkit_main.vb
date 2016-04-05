Public Class Devkit_main
    Private Sub ToolStripStatusLabel1_Click(sender As Object, e As EventArgs) Handles ToolStripStatusLabel1.Click

    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs)
        End
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub ExitToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem1.Click
        End
    End Sub

    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs)
        OpenFileDialog1.ShowDialog()


    End Sub

    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs)
        SaveFileDialog1.ShowDialog()

    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs)

        RichTextBox1.LoadFile(OpenFileDialog1.FileName)

    End Sub

    Private Sub SaveFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs)
        Try
            RichTextBox1.SaveFile(OpenFileDialog1.FileName, RichTextBoxStreamType.RichText)
        Catch
        End Try
    End Sub

    Private Sub SaveFileDialog1_FileOk_1(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles SaveFileDialog1.FileOk
        RichTextBox1.SaveFile(SaveFileDialog1.FileName, RichTextBoxStreamType.RichText)
        ToolStripProgressBar1.Value = 100
        Timer1.Start()
    End Sub

    Private Sub OpenFileDialog1_FileOk_1(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk
        Try

            RichTextBox1.LoadFile(OpenFileDialog1.FileName)

        Catch ex As Exception : End Try
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub NewToolStripMenuItem_Click(sender As Object, e As EventArgs)
        RichTextBox1.Clear()
    End Sub

    Private Sub SaveFileDialog2_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles SaveFileDialog2.FileOk
        RichTextBox1.SaveFile(SaveFileDialog2.FileName, RichTextBoxStreamType.TextTextOleObjs)
        ToolStripProgressBar1.Value = 100
        Timer1.Start()

    End Sub

    Private Sub OpenFileDialog2_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog2.FileOk
        Try

            RichTextBox1.LoadFile(OpenFileDialog2.FileName)

        Catch ex As Exception : End Try
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ToolStripProgressBar1.Value = 0
        Timer1.Stop()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs)
        sys_about.Show()
    End Sub

    Private Sub Devkit_main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RichTextBox1.Text = "
EXAMPLE (VB)

Public Class Devkit_main
    Private Sub ToolStripStatusLabel1_Click(sender As Object, e As EventArgs) Handles ToolStripStatusLabel1.Click

    End Sub"
    End Sub

    Private Sub FileToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox3_Click_1(sender As Object, e As EventArgs) Handles PictureBox3.Click
        RichTextBox1.Clear()
    End Sub

    Private Sub PictureBox1_Click_1(sender As Object, e As EventArgs) Handles PictureBox1.Click
        SaveFileDialog1.ShowDialog()
    End Sub

    Private Sub PictureBox2_Click_1(sender As Object, e As EventArgs) Handles PictureBox2.Click
        OpenFileDialog1.ShowDialog()
    End Sub

    Private Sub PictureBox5_Click_1(sender As Object, e As EventArgs) Handles PictureBox5.Click
        OpenFileDialog2.ShowDialog()
    End Sub

    Private Sub PictureBox4_Click_1(sender As Object, e As EventArgs) Handles PictureBox4.Click
        SaveFileDialog2.ShowDialog()
    End Sub

    Private Sub NewToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles NewToolStripMenuItem.Click
        RichTextBox1.Clear()
    End Sub

    Private Sub SaveToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        SaveFileDialog1.ShowDialog()
    End Sub

    Private Sub OpenToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click
        OpenFileDialog1.ShowDialog()
    End Sub

    Private Sub ImportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ImportToolStripMenuItem.Click
        OpenFileDialog2.ShowDialog()
    End Sub

    Private Sub ExportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExportToolStripMenuItem.Click
        SaveFileDialog2.ShowDialog()
    End Sub

    Private Sub ExitToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub

    Private Sub AboutToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        sys_about.Show()
    End Sub

    Private Sub SettingsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SettingsToolStripMenuItem.Click
        Settings.Show()
    End Sub

    Private Sub Devkit_main_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        DevKit___What_to_Do.Show()
        Me.Hide()
    End Sub

    Private Sub ReturnToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReturnToolStripMenuItem.Click
        DevKit___What_to_Do.Show()
        Me.Close()
    End Sub

    Private Sub open_Popup(sender As Object, e As PopupEventArgs) Handles open.Popup

    End Sub

    Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs) Handles RichTextBox1.TextChanged
        Dim words As New List(Of String)
        ' Timer2.Start()
        ' Timer3.Start()
        words.Add("Then")
        words.Add("Sub")
        words.Add("If")
        words.Add("Public")
        words.Add("Class")
        words.Add("Object")
        words.Add("As")
        words.Add("Handles")
        words.Add("Dim")
        words.Add("Integer")
        words.Add("Do")
        words.Add("While")
        words.Add("Loop")
        words.Add("Next")
        words.Add("End")
        words.Add("Stop")
        words.Add("Me")
        words.Add("Form")
        words.Add("Try")
        words.Add("Catch")
        words.Add("Private")
        words.Add("Imports")
        If RichTextBox1.Text.Length > 0 Then

            Dim selectStart As Integer = RichTextBox1.SelectionStart

            RichTextBox1.Select(0, RichTextBox1.Text.Length)

            RichTextBox1.SelectionColor = Color.Black

            RichTextBox1.DeselectAll()

            For Each oneWord As String In words

                Dim pos As Integer = 0

                Do While RichTextBox1.Text.ToUpper.IndexOf(oneWord.ToUpper, pos) >= 0

                    pos = RichTextBox1.Text.ToUpper.IndexOf(oneWord.ToUpper, pos)

                    RichTextBox1.Select(pos, oneWord.Length)

                    RichTextBox1.SelectionColor = Color.Blue

                    pos += 1

                Loop

            Next

            RichTextBox1.SelectionStart = selectStart

        End If


    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Dim words As New List(Of String)
        words.Add("0")
        words.Add("1")
        words.Add("2")
        words.Add("3")
        words.Add("4")
        words.Add("5")
        words.Add("6")
        words.Add("7")
        words.Add("8")
        words.Add("9")
        If RichTextBox1.Text.Length > 0 Then

            Dim selectStart As Integer = RichTextBox1.SelectionStart

            RichTextBox1.Select(0, RichTextBox1.Text.Length)

            RichTextBox1.SelectionColor = Color.Black

            RichTextBox1.DeselectAll()

            For Each oneWord As String In words

                Dim pos As Integer = 0

                Do While RichTextBox1.Text.ToUpper.IndexOf(oneWord.ToUpper, pos) >= 0

                    pos = RichTextBox1.Text.ToUpper.IndexOf(oneWord.ToUpper, pos)

                    RichTextBox1.Select(pos, oneWord.Length)

                    RichTextBox1.SelectionColor = Color.LightGreen

                    pos += 1

                Loop

            Next

            RichTextBox1.SelectionStart = selectStart

        End If
        Timer2.Stop()
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        Dim words As New List(Of String)
        words.Add("Color")
        words.Add("List")
        words.Add("EventArgs")
        words.Add("FormClosingEventArgs")
        words.Add("PopupEventArgs")
        words.Add("Exception")
        If RichTextBox1.Text.Length > 0 Then

            Dim selectStart As Integer = RichTextBox1.SelectionStart

            RichTextBox1.Select(0, RichTextBox1.Text.Length)

            RichTextBox1.SelectionColor = Color.Black

            RichTextBox1.DeselectAll()

            For Each oneWord As String In words

                Dim pos As Integer = 0

                Do While RichTextBox1.Text.ToUpper.IndexOf(oneWord.ToUpper, pos) >= 0

                    pos = RichTextBox1.Text.ToUpper.IndexOf(oneWord.ToUpper, pos)

                    RichTextBox1.Select(pos, oneWord.Length)

                    RichTextBox1.SelectionColor = Color.Cyan

                    pos += 1

                Loop

            Next

            RichTextBox1.SelectionStart = selectStart

        End If
        Timer3.Stop()
    End Sub
End Class