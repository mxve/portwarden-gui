Public Class Form1
    Private installstate As Boolean

    Sub enable(state As Boolean)
        installstate = state
        If state Then
            GroupBox1.Enabled = True
            GroupBox2.Enabled = True
        Else
            GroupBox1.Enabled = False
            GroupBox2.Enabled = False
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not IO.File.Exists("warden\bw.exe") Or Not IO.File.Exists("warden\portwarden_windows_amd64.exe") Then
            install.Show()
            enable(False)
        Else
            enable(True)
        End If

        TextBox4.Text = Application.StartupPath + "\backup\"
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            MessageBox.Show("Only change the host if you know what you are doing." + vbNewLine + vbNewLine + "In most cases theres no need to change this.")
            TextBox1.Enabled = True
        Else
            TextBox1.Enabled = False
        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        MessageBox.Show("Enter the bitwarden URL" + vbNewLine + vbNewLine + "If you aren't hosting bitwarden or vaultwarden (bitwarden_rs) yourself, keep it unchanged")
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        MessageBox.Show("This password will be used to encrypt your backup file." + vbNewLine + vbNewLine + "Make sure to remember this password, you backup will be inaccessible if you lose it.")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        FolderBrowserDialog1.ShowDialog()
        TextBox4.Text = FolderBrowserDialog1.SelectedPath
        If Not TextBox4.Text.EndsWith("\") Then TextBox4.Text += "\"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox2.PasswordChar = "*"
        TextBox3.PasswordChar = "*"
        If TextBox2.Text = TextBox3.Text And Not TextBox2.Text = "" Then
            Dim bwsinf As New ProcessStartInfo With {
                .FileName = "bw.exe",
                .WorkingDirectory = "warden",
                .Arguments = "bw config server " + TextBox1.Text,
                .CreateNoWindow = True,
                .WindowStyle = ProcessWindowStyle.Hidden
            }

            Dim bwp As New Process
            bwp.StartInfo = bwsinf
            bwp.Start()

            Do Until bwp.HasExited
                Threading.Thread.Sleep(10) : Application.DoEvents()
            Loop

            MessageBox.Show("A new window will open, prompting you to login using your bitwarden account." + vbNewLine + vbNewLine + "Your backup is done ones that window closes.")

            If Not IO.Directory.Exists(TextBox4.Text) Then
                Try
                    IO.Directory.CreateDirectory(TextBox4.Text)
                Catch ex As Exception
                    MessageBox.Show("Can't access backup directory")
                    Exit Sub
                End Try
            End If

            Dim dt As DateTime = DateTime.Now

            Dim proc As New ProcessStartInfo With {
                .Arguments = "--passphrase """ + TextBox2.Text + """ --filename """ + TextBox4.Text + dt.ToString("yyyy-MM-dd_HH-mm-ss") + ".portwarden"" encrypt",
                .FileName = "portwarden_windows_amd64.exe",
                .WorkingDirectory = "warden"
            }

            Dim p As New Process()
            p.StartInfo = proc
            p.Start()

            enable(False)

            Do Until p.HasExited
                Threading.Thread.Sleep(10) : Application.DoEvents()
            Loop

            enable(True)

            If p.ExitCode = 0 Then
                Dim result As DialogResult = MessageBox.Show("You backup has been created under:" + vbNewLine + TextBox4.Text + dt.ToString("yyyy-MM-dd_HH-mm-ss") + ".portwarden" + vbNewLine + vbNewLine + "Open directory now?", "Backup successful", MessageBoxButtons.YesNo)
                If result = DialogResult.Yes Then
                    Process.Start("explorer.exe", """" + TextBox4.Text + """")
                End If
            Else
                MessageBox.Show("There was an error creating your backup")
            End If
        Else
            MessageBox.Show("Your passwords don't match or they are empty")
        End If
        TextBox2.PasswordChar = ""
        TextBox3.PasswordChar = ""
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        OpenFileDialog1.ShowDialog()
        TextBox5.Text = OpenFileDialog1.FileName
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        TextBox6.PasswordChar = "*"
        If IO.File.Exists(TextBox5.Text) Then
            Dim proc As New ProcessStartInfo With {
                .FileName = "portwarden_windows_amd64.exe",
                .WorkingDirectory = "warden",
                .Arguments = "--passphrase """ + TextBox6.Text + """ --filename """ + TextBox5.Text + """ decrypt"
            }

            Dim p As New Process
            p.StartInfo = proc
            p.Start()

            Do Until p.HasExited
                Threading.Thread.Sleep(10) : Application.DoEvents()
            Loop

            If p.ExitCode = 0 Then
                Dim result As DialogResult = MessageBox.Show("You backup has been decrypted." + vbNewLine + vbNewLine + "Open directory now?", "Backup decrypted", MessageBoxButtons.YesNo)
                If result = DialogResult.Yes Then
                    Process.Start("explorer.exe", """" + IO.Path.GetDirectoryName(TextBox5.Text) + """")
                End If
            Else
                MessageBox.Show("There was an error decrypting your backup")
            End If
        End If
        TextBox6.PasswordChar = ""
    End Sub
End Class
