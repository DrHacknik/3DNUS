Public Class Main
    Dim cd = Application.StartupPath
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        End
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Settings.settings_enable_mrkt = "1" Then
            DEVMARKETToolStripMenuItem.Visible = True
        Else
            DEVMARKETToolStripMenuItem.Visible = False
        End If
        Try
            My.Settings.dev_debugger_logged = "
loaded: Settings from Application.Root()
Listening to dev_main"
        Catch ex As Exception
        End Try
        Try

            PictureBox3.Image = Image.FromFile(cd + "\\Extensions\\_ext\\Slot1\\ext_icon.png")
            PictureBox4.Image = Image.FromFile(cd + "\\Extensions\\_ext\\Slot2\\ext_icon.png")
            PictureBox5.Image = Image.FromFile(cd + "\\Extensions\\_ext\\Slot4\\ext_icon.png")
            PictureBox6.Image = Image.FromFile(cd + "\\Extensions\\_ext\\Slot3\\ext_icon.png")
            PictureBox7.Image = Image.FromFile(cd + "\\Extensions\\_ext\\Slot8\\ext_icon.png")
            PictureBox8.Image = Image.FromFile(cd + "\\Extensions\\_ext\\Slot7\\ext_icon.png")
            PictureBox9.Image = Image.FromFile(cd + "\\Extensions\\_ext\\Slot6\\ext_icon.png")
            PictureBox10.Image = Image.FromFile(cd + "\\Extensions\\_ext\\Slot5\\ext_icon.png")
            PictureBox11.Image = Image.FromFile(cd + "\\Extensions\\_ext\\Slot12\\ext_icon.png")
            PictureBox12.Image = Image.FromFile(cd + "\\Extensions\\_ext\\Slot11\\ext_icon.png")
            PictureBox13.Image = Image.FromFile(cd + "\\Extensions\\_ext\\Slot10\\ext_icon.png")
            PictureBox14.Image = Image.FromFile(cd + "\\Extensions\\_ext\\Slot9\\ext_icon.png")
        Catch ex As Exception

        End Try
        Try
            My.Settings.Reload()
            If My.Settings.settings_devmd = "1" Then
                CheckBox1.Checked = True
            Else
                CheckBox2.Checked = False
            End If
            If My.Settings.settings_inst_sgnd = "1" Then
                CheckBox2.Checked = True
            Else
                CheckBox2.Checked = False
            End If
            If My.Settings.settings_inst_chck = "1" Then
                CheckBox3.Checked = True
            Else
                CheckBox3.Checked = False
            End If
            If My.Settings.settings_encrypt = "1" Then
                CheckBox4.Checked = True
            Else
                CheckBox4.Checked = False
            End If
            ComboBox1.Text = My.Settings.settings_encrypt_type
            ComboBox2.Text = My.Settings.settings_def_color
            If My.Settings.settings_enable_mrkt = "1" Then
                CheckBox5.Checked = True
            Else
                CheckBox5.Checked = False
            End If
            TextBox1.Text = My.Settings.settings_load_text
        Catch
        End Try
    End Sub

    Private Sub PictureBox12_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox10_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox9_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox8_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox14_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox13_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox11_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click

    End Sub

    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
        End
    End Sub

    Private Sub EndToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EndToolStripMenuItem.Click
        End
    End Sub

    Private Sub ImportSettingsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ImportSettingsToolStripMenuItem.Click
        OpenFileDialog1.ShowDialog()
    End Sub

    Private Sub ExportSettingsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExportSettingsToolStripMenuItem.Click
        SaveFileDialog1.ShowDialog()
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs)

    End Sub

    Private Sub DebuggerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DebuggerToolStripMenuItem.Click
        dev_console_debug.Show()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        dev_about.Show()
    End Sub

    Private Sub ClearSandboxToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearSandboxToolStripMenuItem.Click
        MessageBox.Show("Sandbox Cache Cleared!", "Extension Manager: Clear Sandbox Cache", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub ResetSandboxToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ResetSandboxToolStripMenuItem.Click
        MessageBox.Show("The Sandbox Settings, and Cache WILL BE Reset. Are you sure you Wish to continue?", "Extension Manager: Reset Sandbox", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
        If vbYes Then
            MessageBox.Show("The Sandbox has been Reset!" + " 
Removed: 20MB's from Cache.", "Extension Manager: Reset Sandbox", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        If vbNo Then
            MessageBox.Show("Reset Canceled!", "Extension Manager: Reset Sandbox", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub PictureBox3_Click_1(sender As Object, e As EventArgs) Handles PictureBox3.Click
        My.Settings.ext_launch = cd + "\Extensions\_ext\Slot1\"
        My.Settings.ext_short = cd + "\Extensions\_ext\Slot1\ext_desc.ini"
        My.Settings.ext_long = cd + "\Extensions\_ext\Slot1\ext_desc_long.ini"
        My.Settings.ext_info = cd + "\Extensions\_ext\Slot1\ext_info.ini"
        My.Settings.ext_icon = cd + "\Extensions\_ext\Slot1\ext_icon.png"
        extension_about.Show()

    End Sub

    Private Sub PictureBox4_Click_1(sender As Object, e As EventArgs) Handles PictureBox4.Click
        My.Settings.ext_launch = cd + "\Extensions\Slot2\"
        My.Settings.ext_launch = cd + "\Extensions\_ext\Slot2\"
        My.Settings.ext_short = cd + "\Extensions\_ext\Slot2\ext_desc.ini"
        My.Settings.ext_long = cd + "\Extensions\_ext\Slot2\ext_desc_long.ini"
        My.Settings.ext_info = cd + "\Extensions\_ext\Slot2\ext_info.ini"
        My.Settings.ext_icon = cd + "\Extensions\_ext\Slot2\ext_icon.png"
        extension_about.Show()
    End Sub

    Private Sub PictureBox6_Click_1(sender As Object, e As EventArgs) Handles PictureBox6.Click
        My.Settings.ext_launch = cd + "\Extensions\Slot3\"
        My.Settings.ext_launch = cd + "\Extensions\_ext\Slot3\"
        My.Settings.ext_short = cd + "\Extensions\_ext\Slot3\ext_desc.ini"
        My.Settings.ext_long = cd + "\Extensions\_ext\Slot3\ext_desc_long.ini"
        My.Settings.ext_info = cd + "\Extensions\_ext\Slot3\ext_info.ini"
        My.Settings.ext_icon = cd + "\Extensions\_ext\Slot3\ext_icon.png"
        extension_about.Show()
    End Sub

    Private Sub PictureBox5_Click_1(sender As Object, e As EventArgs) Handles PictureBox5.Click
        My.Settings.ext_launch = cd + "\Extensions\Slot4\"
        My.Settings.ext_launch = cd + "\Extensions\Slot4\"
        My.Settings.ext_launch = cd + "\Extensions\_ext\Slot4\"
        My.Settings.ext_short = cd + "\Extensions\_ext\Slot4\ext_desc.ini"
        My.Settings.ext_long = cd + "\Extensions\_ext\Slot4\ext_desc_long.ini"
        My.Settings.ext_info = cd + "\Extensions\_ext\Slot4\ext_info.ini"
        My.Settings.ext_icon = cd + "\Extensions\_ext\Slot4\ext_icon.png"
        extension_about.Show()
    End Sub

    Private Sub PictureBox10_Click_1(sender As Object, e As EventArgs) Handles PictureBox10.Click
        My.Settings.ext_launch = cd + "\Extensions\Slot5\"
        My.Settings.ext_launch = cd + "\Extensions\Slot5\"
        My.Settings.ext_launch = cd + "\Extensions\_ext\Slot5\"
        My.Settings.ext_short = cd + "\Extensions\_ext\Slot5\ext_desc.ini"
        My.Settings.ext_long = cd + "\Extensions\_ext\Slot5\ext_desc_long.ini"
        My.Settings.ext_info = cd + "\Extensions\_ext\Slot5\ext_info.ini"
        My.Settings.ext_icon = cd + "\Extensions\_ext\Slot5\ext_icon.png"
        extension_about.Show()
    End Sub

    Private Sub PictureBox11_Click_1(sender As Object, e As EventArgs) Handles PictureBox11.Click
        My.Settings.ext_launch = cd + "\Extensions\Slot12\"
        My.Settings.ext_launch = cd + "\Extensions\Slot12\"
        My.Settings.ext_launch = cd + "\Extensions\_ext\Slot12\"
        My.Settings.ext_short = cd + "\Extensions\_ext\Slot12\ext_desc.ini"
        My.Settings.ext_long = cd + "\Extensions\_ext\Slot12\ext_desc_long.ini"
        My.Settings.ext_info = cd + "\Extensions\_ext\Slot12\ext_info.ini"
        My.Settings.ext_icon = cd + "\Extensions\_ext\Slot12\ext_icon.png"
        extension_about.Show()
    End Sub

    Private Sub PictureBox8_Click_1(sender As Object, e As EventArgs) Handles PictureBox8.Click
        My.Settings.ext_launch = cd + "\Extensions\Slot7\"
        My.Settings.ext_launch = cd + "\Extensions\Slot7\"
        My.Settings.ext_launch = cd + "\Extensions\_ext\Slot7\"
        My.Settings.ext_short = cd + "\Extensions\_ext\Slot7\ext_desc.ini"
        My.Settings.ext_long = cd + "\Extensions\_ext\Slot7\ext_desc_long.ini"
        My.Settings.ext_info = cd + "\Extensions\_ext\Slot7\ext_info.ini"
        My.Settings.ext_icon = cd + "\Extensions\_ext\Slot7\ext_icon.png"
        extension_about.Show()
    End Sub

    Private Sub PictureBox7_Click_1(sender As Object, e As EventArgs) Handles PictureBox7.Click
        My.Settings.ext_launch = cd + "\Extensions\Slot8\"
        My.Settings.ext_launch = cd + "\Extensions\Slot8\"
        My.Settings.ext_launch = cd + "\Extensions\_ext\Slot8\"
        My.Settings.ext_short = cd + "\Extensions\_ext\Slot8\ext_desc.ini"
        My.Settings.ext_long = cd + "\Extensions\_ext\Slot8\ext_desc_long.ini"
        My.Settings.ext_info = cd + "\Extensions\_ext\Slot8\ext_info.ini"
        My.Settings.ext_icon = cd + "\Extensions\_ext\Slot8\ext_icon.png"
        extension_about.Show()
    End Sub

    Private Sub PictureBox14_Click_1(sender As Object, e As EventArgs) Handles PictureBox14.Click
        My.Settings.ext_launch = cd + "\Extensions\Slot9\"
        My.Settings.ext_launch = cd + "\Extensions\Slot9\"
        My.Settings.ext_launch = cd + "\Extensions\_ext\Slot9\"
        My.Settings.ext_short = cd + "\Extensions\_ext\Slot9\ext_desc.ini"
        My.Settings.ext_long = cd + "\Extensions\_ext\Slot9\ext_desc_long.ini"
        My.Settings.ext_info = cd + "\Extensions\_ext\Slot9\ext_info.ini"
        My.Settings.ext_icon = cd + "\Extensions\_ext\Slot9\ext_icon.png"
        extension_about.Show()
    End Sub

    Private Sub PictureBox13_Click_1(sender As Object, e As EventArgs) Handles PictureBox13.Click
        My.Settings.ext_launch = cd + "\Extensions\Slot10\"
        My.Settings.ext_launch = cd + "\Extensions\Slot10\"
        My.Settings.ext_launch = cd + "\Extensions\_ext\Slot10\"
        My.Settings.ext_short = cd + "\Extensions\_ext\Slot10\ext_desc.ini"
        My.Settings.ext_long = cd + "\Extensions\_ext\Slot10\ext_desc_long.ini"
        My.Settings.ext_info = cd + "\Extensions\_ext\Slot10\ext_info.ini"
        My.Settings.ext_icon = cd + "\Extensions\_ext\Slot10\ext_icon.png"
        extension_about.Show()
    End Sub

    Private Sub PictureBox12_Click_1(sender As Object, e As EventArgs) Handles PictureBox12.Click
        My.Settings.ext_launch = cd + "\Extensions\Slot11\"
        My.Settings.ext_launch = cd + "\Extensions\Slot11\"
        My.Settings.ext_launch = cd + "\Extensions\_ext\Slot11\"
        My.Settings.ext_short = cd + "\Extensions\_ext\Slot11\ext_desc.ini"
        My.Settings.ext_long = cd + "\Extensions\_ext\Slot11\ext_desc_long.ini"
        My.Settings.ext_info = cd + "\Extensions\_ext\Slot11\ext_info.ini"
        My.Settings.ext_icon = cd + "\Extensions\_ext\Slot11\ext_icon.png"
        extension_about.Show()
    End Sub

    Private Sub PictureBox9_Click_1(sender As Object, e As EventArgs) Handles PictureBox9.Click
        My.Settings.ext_launch = cd + "\Extensions\Slot6\"
        My.Settings.ext_launch = cd + "\Extensions\Slot6\"
        My.Settings.ext_launch = cd + "\Extensions\_ext\Slot6\"
        My.Settings.ext_short = cd + "\Extensions\_ext\Slot6\ext_desc.ini"
        My.Settings.ext_long = cd + "\Extensions\_ext\Slot6\ext_desc_long.ini"
        My.Settings.ext_info = cd + "\Extensions\_ext\Slot6\ext_info.ini"
        My.Settings.ext_icon = cd + "\Extensions\_ext\Slot6\ext_icon.png"
        extension_about.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            My.Settings.dev_debugger_logged = "
saved: Settings to Application.Root() 
Listening to dev_main"
        Catch ex As Exception
        End Try
        PictureBox15.Visible = True
        Timer1.Start()

        My.Settings.settings_load_text = TextBox1.Text
        If CheckBox1.Checked = True Then
            My.Settings.settings_devmd = "1"
        End If
        If CheckBox1.Checked = False Then
            My.Settings.settings_devmd = "0"
        End If
        If CheckBox2.Checked = True Then
            My.Settings.settings_inst_sgnd = "1"
        End If
        If CheckBox2.Checked = False Then
            My.Settings.settings_inst_sgnd = "0"
        End If
        If CheckBox3.Checked = True Then
            My.Settings.settings_inst_chck = "1"
        End If
        If CheckBox3.Checked = False Then
            My.Settings.settings_inst_chck = "0"
        End If
        If CheckBox4.Checked = True Then
            My.Settings.settings_encrypt = "1"
        End If
        If CheckBox4.Checked = "false" Then
            My.Settings.settings_encrypt = "1"
        End If
        If CheckBox4.Checked = False Then
            My.Settings.settings_encrypt = "0"
        End If
        My.Settings.settings_encrypt_type = ComboBox1.SelectedText
        If CheckBox5.Checked = True Then
            My.Settings.settings_enable_mrkt = "1"
        End If
        If CheckBox5.Checked = False Then
            My.Settings.settings_enable_mrkt = "0"
        End If
        My.Settings.settings_encrypt_type = ComboBox1.Text
        My.Settings.settings_def_color = ComboBox2.Text
        If My.Settings.settings_encrypt_type = Nothing Then
            ComboBox1.Text = "Default"
        End If
        My.Settings.Save()
        Me.Refresh()
    End Sub

    Private Sub Timer1_Tick_1(sender As Object, e As EventArgs) Handles Timer1.Tick
        PictureBox15.Width += 1
        If PictureBox15.Width = 50 Then
            PictureBox15.BackColor = Color.Green
            Timer1.Stop()
            Timer2.Start()
        End If

    End Sub

    Private Sub InstallToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InstallToolStripMenuItem.Click
        Install.ShowDialog()
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        PictureBox15.Width = 1
        PictureBox15.BackColor = Color.DodgerBlue
        PictureBox15.Visible = False
        Timer2.Stop()
    End Sub

    Private Sub DEVMARKETToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DEVMARKETToolStripMenuItem.Click
        My.Settings.dev_debugger_logged = "
loaded: dev_market
Listening to dev_market"
        dev_market.Show()
    End Sub

    Private Sub SaveFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles SaveFileDialog1.FileOk
        My.Computer.FileSystem.WriteAllText(SaveFileDialog1.FileName, My.Settings.settings_def_color + ", " + My.Settings.settings_devmd + ", " + My.Settings.settings_enable_mrkt + ", " + My.Settings.settings_encrypt + ", " + My.Settings.settings_encrypt_type + ", " + My.Settings.settings_inst_chck + ", " + My.Settings.settings_inst_sgnd + ", " + My.Settings.settings_load_text, True)
    End Sub
End Class