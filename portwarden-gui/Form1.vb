Public Class Form1
    Private installstate As Boolean

    Sub enable(state As Boolean)
        installstate = state
        If state Then
            groupBackup.Enabled = True
            groupDecrypt.Enabled = True
        Else
            groupBackup.Enabled = False
            groupDecrypt.Enabled = False
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not IO.File.Exists("warden\bw.exe") Or Not IO.File.Exists("warden\portwarden_windows_amd64.exe") Then
            install.Show()
            enable(False)
        Else
            enable(True)
        End If

        textboxBackupDir.Text = Application.StartupPath + "\backup\"
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            MessageBox.Show("Only change the host if you know what you are doing." + vbNewLine + vbNewLine + "In most cases theres no need to change this.")
            textboxHost.Enabled = True
        Else
            textboxHost.Enabled = False
        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        MessageBox.Show("Enter the bitwarden URL" + vbNewLine + vbNewLine + "If you aren't hosting bitwarden or vaultwarden (bitwarden_rs) yourself, keep it unchanged")
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        MessageBox.Show("This password will be used to encrypt your backup file." + vbNewLine + vbNewLine + "Make sure to remember this password, you backup will be inaccessible if you lose it.")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles buttonPickBackupDir.Click
        FolderBrowserDialog1.ShowDialog()
        textboxBackupDir.Text = FolderBrowserDialog1.SelectedPath
        If Not textboxBackupDir.Text.EndsWith("\") Then textboxBackupDir.Text += "\"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles buttonBackup.Click
        textboxPassword1.PasswordChar = "*"
        textboxPassword2.PasswordChar = "*"
        If textboxPassword1.Text = textboxPassword2.Text And Not textboxPassword1.Text = "" Then
            Dim bwsinf As New ProcessStartInfo With {
                .FileName = "bw.exe",
                .WorkingDirectory = "warden",
                .Arguments = "bw config server " + textboxHost.Text,
                .CreateNoWindow = True,
                .WindowStyle = ProcessWindowStyle.Hidden
            }

            Dim bwp As New Process
            bwp.StartInfo = bwsinf
            bwp.Start()

            Do Until bwp.HasExited
                Threading.Thread.Sleep(10) : Application.DoEvents()
            Loop

            'MessageBox.Show("A new window will open, prompting you to login using your bitwarden account." + vbNewLine + vbNewLine + "Your backup is done ones that window closes.")

            If Not IO.Directory.Exists(textboxBackupDir.Text) Then
                Try
                    IO.Directory.CreateDirectory(textboxBackupDir.Text)
                Catch ex As Exception
                    MessageBox.Show("Can't access backup directory")
                    Exit Sub
                End Try
            End If

            Dim dt As DateTime = DateTime.Now

            Dim proc As New ProcessStartInfo With {
                .Arguments = "--passphrase """ + textboxPassword1.Text + """ --filename """ + textboxBackupDir.Text + dt.ToString("yyyy-MM-dd_HH-mm-ss") + ".portwarden"" encrypt",
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
                Dim result As DialogResult = MessageBox.Show("You backup has been created under:" + vbNewLine + textboxBackupDir.Text + dt.ToString("yyyy-MM-dd_HH-mm-ss") + ".portwarden" + vbNewLine + vbNewLine + "Open directory now?", "Backup successful", MessageBoxButtons.YesNo)
                If result = DialogResult.Yes Then
                    Process.Start("explorer.exe", """" + textboxBackupDir.Text + """")
                End If
            Else
                MessageBox.Show("There was an error creating your backup")
            End If
        Else
            MessageBox.Show("Your passwords don't match or they are empty")
        End If
        textboxPassword1.PasswordChar = ""
        textboxPassword2.PasswordChar = ""
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles buttonPickBackupFile.Click
        OpenFileDialog1.ShowDialog()
        textboxBackupFile.Text = OpenFileDialog1.FileName
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles buttonDecrypt.Click
        textboxPassword3.PasswordChar = "*"
        If IO.File.Exists(textboxBackupFile.Text) Then
            Dim proc As New ProcessStartInfo With {
                .FileName = "portwarden_windows_amd64.exe",
                .WorkingDirectory = "warden",
                .Arguments = "--passphrase """ + textboxPassword3.Text + """ --filename """ + textboxBackupFile.Text + """ decrypt"
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
                    Process.Start("explorer.exe", """" + IO.Path.GetDirectoryName(textboxBackupFile.Text) + """")
                End If
            Else
                MessageBox.Show("There was an error decrypting your backup")
            End If
        End If
        textboxPassword3.PasswordChar = ""
    End Sub

    Private Sub LinkLabel3_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel3.LinkClicked
        Process.Start("https://github.com/bitwarden/")
    End Sub

    Private Sub LinkLabel4_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel4.LinkClicked
        Process.Start("https://github.com/vwxyzjn/portwarden")
    End Sub

    Private Sub LinkLabel5_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel5.LinkClicked
        Process.Start("https://github.com/mxve/portwarden-gui")
    End Sub

    Private Sub LinkLabel6_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel6.LinkClicked
        Process.Start("https://bitwarden.com/")
    End Sub
End Class
