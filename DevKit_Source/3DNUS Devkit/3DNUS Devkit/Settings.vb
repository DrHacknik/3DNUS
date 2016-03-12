Imports System.IO

Public Class Settings
    Dim cd = Path.GetDirectoryName(Application.ExecutablePath)
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub ToolStripStatusLabel1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub Settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try


            If My.Settings.settings_dev_mode = "1" Then
                CheckBox1.Checked = True
            Else
                CheckBox1.Checked = False
            End If
            If My.Settings.settings_code_lang = "1" Then
                CheckBox2.Checked = True
            Else
                CheckBox2.Checked = False

            End If
            TextBox1.Text = My.Settings.settings_flags
            ComboBox1.Text = My.Settings.settings_code_lang_sel
        Catch ex As Exception

        End Try
    End Sub

    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        'MessageBox.Show("Uknown Error when Saving Configuration! Config_save Aborted.", "Settings:", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Try
            If CheckBox1.Checked = True Then
                My.Settings.settings_dev_mode = "1"
            Else
                My.Settings.settings_dev_mode = "0"
            End If
            If CheckBox1.Checked = True Then
                My.Settings.settings_code_lang = "1"
            Else
                My.Settings.settings_code_lang = "0"
            End If
            My.Settings.settings_code_lang_sel = ComboBox1.Text
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ReturnToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReturnToolStripMenuItem.Click
        DevKit___What_to_Do.Show()
        Me.Close()
    End Sub
End Class