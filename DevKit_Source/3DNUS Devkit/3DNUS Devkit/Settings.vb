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


            If (File.ReadAllText(cd + "Config\\dev_mode_cfg.cfg") = ("1")) Then
                CheckBox1.Checked = True
            End If
            If (File.ReadAllText(cd + "Config\\dev_mode_cfg.cfg") = ("0")) Then
                CheckBox1.Checked = False
            End If
            If (File.ReadAllText(cd + "Config\\dev_mode_cfg.cfg") = ("")) Then
                CheckBox1.Checked = False
            End If
            If (File.ReadAllText(cd + "Config\\code_lang.cfg") = ("default")) Then
                ComboBox1.Text = "Default"
            End If
            If (File.ReadAllText(cd + "Config\\code_lang.cfg") = ("C")) Then
                ComboBox1.Text = "C"
            End If
            If (File.ReadAllText(cd + "Config\\code_lang.cfg") = ("C++")) Then
                ComboBox1.Text = "C++"
            End If
            If (File.ReadAllText(cd + "Config\\code_lang.cfg") = ("C#")) Then
                ComboBox1.Text = "C#"
            End If
            If (File.ReadAllText(cd + "Config\\code_lang.cfg") = ("F")) Then
                ComboBox1.Text = "F"
            End If
            If (File.ReadAllText(cd + "Config\\code_lang.cfg") = ("C++")) Then
                ComboBox1.Text = "F++"
            End If
            If (File.ReadAllText(cd + "Config\\code_lang.cfg") = ("C#")) Then
                ComboBox1.Text = "F#"
            End If
            If (File.ReadAllText(cd + "Config\\code_lang.cfg") = ("basic")) Then
                ComboBox1.Text = "BASIC"
            End If
            If (File.ReadAllText(cd + "Config\\code_lang.cfg") = ("adv_basic")) Then
                ComboBox1.Text = "ADV-BASIC"
            End If
            If (File.ReadAllText(cd + "Config\\code_lang.cfg") = ("java")) Then
                ComboBox1.Text = "Java"
            End If
            If (File.ReadAllText(cd + "Config\\code_lang.cfg") = ("java_script")) Then
                ComboBox1.Text = "Java-Script"
            End If
            If (File.ReadAllText(cd + "Config\\code_lang.cfg") = ("html")) Then
                ComboBox1.Text = "HTML"
            End If
            If (File.ReadAllText(cd + "Config\\code_lang.cfg") = ("css")) Then
                ComboBox1.Text = "CSS"
            End If
            If (File.ReadAllText(cd + "Config\\code_lang.cfg") = ("php")) Then
                ComboBox1.Text = "PHP"
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        MessageBox.Show("Uknown Error when Saving Configuration! Config_save Aborted.", "Settings:", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Try
            Dim code_def As String() = {ComboBox1.Text}
            File.WriteAllLines(cd + "Config\\code_lang.cfg", code_def)
            If CheckBox1.Checked = True Then
                Dim dev_md As String() = {CheckBox1.CheckState}
                File.WriteAllLines(cd + "Config\\dev_mode.cfg", code_def)
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ReturnToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReturnToolStripMenuItem.Click
        DevKit___What_to_Do.Show()
        Me.Close()
    End Sub
End Class