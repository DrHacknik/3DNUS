Public Class dev_console_debug
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub PushToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PushToolStripMenuItem.Click
        If TextBox1.Text = "" Then
            RichTextBox1.Text += "
Error: Uknown Command!"
        End If
        If TextBox1.Text = "exit" Then
            Me.Close()
        End If
        If TextBox1.Text = "clear" Then
            RichTextBox1.Text = ""
        End If
        If TextBox1.Text = "help" Then
            RichTextBox1.Text += "
  alias    Create an alias •
  apropos  Search Help manual pages (man -k)
  ext-get  Search for and install software packages (3DNUS/2.5+)
  extitude Search for and install software packages (3DNUS/2.5+)
  aspell   Spell Checker
  awk      Find and Replace text, database sort/validate/index
b
  basename Strip directory and suffix from filenames
  bash     GNU Bourne-Again SHell 
  bc       Arbitrary precision calculator language 
  bg       Send to background
  break    Exit from a loop •
  builtin  Run a shell builtin
  bzip2    Compress or decompress named file(s)
c
  cal      Display a calendar
  case     Conditionally perform a command
  cat      Concatenate and print (display) the content of files
  cd       Change Directory
  chgrp    Change group ownership
  chmod    Change access permissions
  chown    Change file owner and group
  chroot   Run a command with a different root directory
  chkconfig System services (runlevel)
  cksum    Print CRC checksum and byte counts
  clear    Clear terminal screen
  cmp      Compare two files
  comm     Compare two sorted files line by line
  command  Run a command - ignoring shell functions •
  continue Resume the next iteration of a loop •
  cp       Copy one or more files to another location
  cron     Daemon to execute scheduled commands
  crontab  Schedule a command to run at a later time
  csplit   Split a file into context-determined pieces
  color    Change the Background Color
  curl     Transfer data  from or to a server
  cut      Divide a file into several parts
d
  date     Display or change the date & time
  dc       Desk Calculator
  dd       Convert and copy a file, write disk headers, boot records
  declare  Declare variables and give them attributes •
  df       Display free disk space
  diff     Display the differences between two files
  diff3    Show differences among three files
  dig      DNS lookup
  dir      Briefly list directory contents
  dircolors Colour setup for `ls'
  dirname  Convert a full pathname to just a path
  dirs     Display list of remembered directories
  dmesg    Print kernel & driver messages 
  du       Estimate file space usage
e
  echo     Display message on screen •
  egrep    Search file(s) for lines that match an extended expression
  eject    Eject removable media
  enable   Enable and disable builtin shell commands •
  env      Environment variables
  ethtool  Ethernet card settings
  eval     Evaluate several commands/arguments
  exec     Execute a command
  exit     Exit the shell
  expect   Automate arbitrary applications accessed over a terminal
  expand   Convert tabs to spaces
  export   Set an environment variable
  expr     Evaluate expressions
t
  time     Shows the Current Time
v
  ver      Display the Current Version of 3DNUS and Ext_manager
"
        End If
        If TextBox1.Text = "echo" Then
            RichTextBox1.Text += "
The Console is now Listening to Logs."
        End If
        If TextBox1.Text = "dmesg" Then
            RichTextBox1.Text += "
The Console is will print all Logs."
        End If
        If TextBox1.Text = "time" Then
            RichTextBox1.Text += "
" + TimeOfDay
        End If
        If TextBox1.Text = "date" Then
            RichTextBox1.Text += "
" + DateTime.Now
        End If
        If TextBox1.Text = "ver" Then
            RichTextBox1.Text += "
Extension Manager: 1.1.0 | 3DNUS 2.5 x86 - Base | " + My.Computer.Info.OSFullName + " " + My.Computer.Info.OSVersion
        End If
        If TextBox1.Text = "ext-get" Then
            RichTextBox1.Text += "
Please specify the Extension to get; Syntax: ext-get http://thatsite.net/ext_name.zip -install"
        End If
        If TextBox1.Text = "extitude" Then
            RichTextBox1.Text += "
Error: Unable to find Extension Description file(s). Please try again later."
        End If
        If TextBox1.Text = "color" Then
            RichTextBox1.Text += "
Please specify the Color to set; Syntax: color-black
Supported Colors: Black, White, Green, Blue, Red, Orange, Purple, Pink, and Yellow.
NOTE: Font Color will NOT be Changed, only for White and Black."
        End If
        If TextBox1.Text = "color-black" Then
            RichTextBox1.BackColor = Color.Black
            RichTextBox1.ForeColor = Color.White
            TextBox1.BackColor = Color.Black
            TextBox1.ForeColor = Color.White
        End If
        If TextBox1.Text = "color-white" Then
            RichTextBox1.BackColor = Color.White
            RichTextBox1.ForeColor = Color.Black
            TextBox1.BackColor = Color.White
            TextBox1.ForeColor = Color.Black
        End If
        If TextBox1.Text = "color-green" Then
            RichTextBox1.BackColor = Color.Green
            TextBox1.BackColor = Color.Green
        End If
        If TextBox1.Text = "color-blue" Then
            RichTextBox1.BackColor = Color.Blue
            TextBox1.BackColor = Color.Blue
        End If
        If TextBox1.Text = "color-red" Then
            RichTextBox1.BackColor = Color.Red
            TextBox1.BackColor = Color.Red
        End If
        If TextBox1.Text = "color-orange" Then
            RichTextBox1.BackColor = Color.Orange
            TextBox1.BackColor = Color.Orange
        End If
        If TextBox1.Text = "color-purple" Then
            RichTextBox1.BackColor = Color.Purple
            TextBox1.BackColor = Color.Purple
        End If
        If TextBox1.Text = "color-pink" Then
            RichTextBox1.BackColor = Color.Pink
            TextBox1.BackColor = Color.Pink
        End If
        If TextBox1.Text = "color-yellow" Then
            RichTextBox1.BackColor = Color.Yellow
            TextBox1.BackColor = Color.Yellow
        End If
        TextBox1.Text = ""
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        RichTextBox1.Text += My.Settings.dev_debugger_logged
        Timer1.Stop()
        My.Settings.dev_debugger_logged = ""
        Timer1.Start()
    End Sub

    Private Sub dev_console_debug_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Settings.settings_def_color = "Black" Then
            RichTextBox1.BackColor = Color.Black
            RichTextBox1.ForeColor = Color.White
            TextBox1.BackColor = Color.Black
            TextBox1.ForeColor = Color.White
        End If
        If My.Settings.settings_def_color = "White" Then
            RichTextBox1.BackColor = Color.White
            RichTextBox1.ForeColor = Color.Black
            TextBox1.BackColor = Color.White
            TextBox1.ForeColor = Color.Black
        End If
    End Sub
End Class