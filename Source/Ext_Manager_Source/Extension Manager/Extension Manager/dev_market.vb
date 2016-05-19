Imports System.IO
Public Class dev_market

    Dim cd = Application.StartupPath
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub WebBrowser1_Navigated(sender As Object, e As WebBrowserNavigatedEventArgs)

    End Sub

    Private Sub WebBrowser1_Navigating(sender As Object, e As WebBrowserNavigatingEventArgs)

    End Sub

    Private Sub WebBrowser1_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs)

    End Sub

    Private Sub dev_market_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Download the HTML Files & Save them.
        em_bck_music.URL = cd + "\\sds\\3ds_shop_bck_music.mp3"

        Try
        My.Computer.Network.DownloadFile(
 "https://raw.githubusercontent.com/zoltx23/3DNUS/master/ext_market/packages/updates/@dr_hacknik/citra_emu/upd_info.txt",
 cd + "\ext_upd\citra_upd_info.txt")
            My.Computer.Network.DownloadFile(
 "https://raw.githubusercontent.com/zoltx23/3DNUS/master/ext_market/packages/updates/@dr_hacknik/devkit/upd_info.txt",
 cd + "\ext_upd\devkit_upd_info.txt")
            My.Computer.Network.DownloadFile(
 "https://raw.githubusercontent.com/zoltx23/3DNUS/master/ext_market/packages/updates/@dr_hacknik/nand_tool/upd_info.txt",
 cd + "\ext_upd\nandtool_upd_info.txt")
            My.Computer.Network.DownloadFile(
 "https://raw.githubusercontent.com/zoltx23/3DNUS/master/ext_market/packages/updates/@dr_hacknik/nandify/upd_info.txt",
 cd + "\ext_upd\nandify_upd_info.txt")
            If File.ReadAllText(cd + "\ext_upd\citra_upd_info.txt") = cd + "\Extensions\_ext\Slot1\upd_info.txt" Then
                MessageBox.Show("An Update for: Citra Emu; is Available!", "Update Manager:", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

            If em_bck_music.playState = WMPLib.WMPPlayState.wmppsStopped Then
                em_bck_music.URL = cd + "\\sds\\3ds_shop_bck_music.mp3"
            End If
            If em_bck_music.playState = WMPLib.WMPPlayState.wmppsReady Then
                em_bck_music.URL = cd + "\\sds\\3ds_shop_bck_music.mp3"
            End If

            If My.Computer.Network.IsAvailable = False Then
                Panel6.Visible = True
            Else
                Panel6.Visible = False
            End If
            banner.Image = Image.FromFile(cd + "\featured.png")

        Catch
        End Try
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs)

    End Sub



    Private Sub WebView1_UrlChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub WebView1_IsLoadingChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub WebBrowser1_ProgressChanged(sender As Object, e As WebBrowserProgressChangedEventArgs)

    End Sub

    Private Sub home_Click(sender As Object, e As EventArgs) Handles home.Click

    End Sub

    Private Sub refresh_Click(sender As Object, e As EventArgs) Handles refresh.Click

    End Sub

    Private Sub downloads_Click(sender As Object, e As EventArgs) Handles downloads.Click
        dev_download_manager.Show()
    End Sub

    Private Sub WebBrowser1_DocumentCompleted_2(sender As Object, e As WebBrowserDocumentCompletedEventArgs)

    End Sub

    Private Sub WebBrowser1_ProgressChanged_1(sender As Object, e As WebBrowserProgressChangedEventArgs)
        dl_progress.Width += 1
        If dl_progress.Width = 42 Then
            dl_progress.Width = 1
        End If
    End Sub

    Private Sub WebBrowser1_Navigating_2(sender As Object, e As WebBrowserNavigatingEventArgs)

    End Sub

    Private Sub WebBrowser1_Navigated_2(sender As Object, e As WebBrowserNavigatedEventArgs)

    End Sub

    Private Sub PictureBox21_Click(sender As Object, e As EventArgs) Handles PictureBox21.Click
        Panel6.Visible = True
        pic_error.Visible = False
        Label12.Text = "                Dowloading, please wait..."
        lb_download_status.Text = "1"
        My.Computer.Network.DownloadFile(
   "https://raw.githubusercontent.com/zoltx23/3DNUS/master/ext_market/packages/tools/@dr_hacknik/citra_emu/citra.zip",
   cd + "\Downloads\citra.zip")
        dl_progress.Width = 42
        Timer1.Start()
    End Sub

    Private Sub PictureBox22_Click(sender As Object, e As EventArgs) Handles PictureBox22.Click
        Panel6.Visible = True
        pic_error.Visible = False
        Label12.Text = "                Dowloading, please wait..."
        lb_download_status.Text = "1"
        My.Computer.Network.DownloadFile(
"https://raw.githubusercontent.com/zoltx23/3DNUS/master/ext_market/packages/tools/@dr_hacknik/devkit/devkit.zip",
cd + "\Downloads\devkit.zip")
        dl_progress.Width = 42
        Timer1.Start()
    End Sub

    Private Sub PictureBox23_Click(sender As Object, e As EventArgs) Handles PictureBox23.Click
        Panel6.Visible = True
        pic_error.Visible = False
        Label12.Text = "                Dowloading, please wait..."
        lb_download_status.Text = "1"
        My.Computer.Network.DownloadFile(
"https://raw.githubusercontent.com/zoltx23/3DNUS/master/ext_market/packages/tools/@dr_hacknik/nandify/nandify.zip",
cd + "\Downloads\nandify.zip")
        dl_progress.Width = 42
        Timer1.Start()
    End Sub

    Private Sub PictureBox37_Click(sender As Object, e As EventArgs) Handles PictureBox37.Click
        Panel6.Visible = True
        pic_error.Visible = False
        Label12.Text = "                Dowloading, please wait..."
        lb_download_status.Text = "1"
        My.Computer.Network.DownloadFile(
"https://raw.githubusercontent.com/zoltx23/3DNUS/master/ext_market/packages/tools/@dr_hacknik/nand_tool/nand_tool.zip",
cd + "\Downloads\nand_tool.zip")
        dl_progress.Width = 42
        Timer1.Start()
    End Sub

    Private Sub PictureBox20_Click(sender As Object, e As EventArgs) Handles PictureBox20.Click
        Panel6.Visible = True
        pic_error.Visible = False
        Label12.Text = "                Dowloading, please wait..."
        lb_download_status.Text = "1"
        My.Computer.Network.DownloadFile(
"https://raw.githubusercontent.com/zoltx23/3DNUS/master/ext_market/packages/tools/@dr_hacknik/citra_emu/citra.zip",
cd + "\Downloads\citra.zip")
        dl_progress.Width = 42
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick_1(sender As Object, e As EventArgs) Handles Timer1.Tick
        Panel6.Visible = False
        pic_error.Visible = True

        dl_progress.Width = 1
        Timer1.Stop()
        lb_download_status.Text = "0"
    End Sub

    Private Sub em_check_Tick(sender As Object, e As EventArgs) Handles em_check.Tick
        If em_bck_music.playState = WMPLib.WMPPlayState.wmppsStopped Then
            em_bck_music.URL = cd + "\\sds\\3ds_shop_bck_music.mp3"
        End If
        If em_bck_music.playState = WMPLib.WMPPlayState.wmppsReady Then
            em_bck_music.URL = cd + "\\sds\\3ds_shop_bck_music.mp3"
        End If
    End Sub

    Private Sub PictureBox1_Click_1(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Process.Start("https://github.com/zoltx23/3DNUS")
    End Sub

    Private Sub dev_market_HelpButtonClicked(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles MyBase.HelpButtonClicked

    End Sub

    Private Sub dev_market_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        File.Delete(cd + "\ext_upd\citra_upd_info.txt")
        File.Delete(cd + "\ext_upd\devkit_upd_info.txt")
        File.Delete(cd + "\ext_upd\nandtool_upd_info.txt")
        File.Delete(cd + "\ext_upd\nandify_upd_info.txt")
        Directory.Delete(cd + "\ext_upd")
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        dev_ext_market_about.Show()
    End Sub
End Class