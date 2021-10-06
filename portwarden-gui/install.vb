Public Class install
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Not IO.Directory.Exists("warden") Then IO.Directory.CreateDirectory("warden")
        Using wc As New Net.WebClient
            wc.DownloadFile("https://github.com/vwxyzjn/portwarden/releases/download/1.0.0/portwarden_windows_amd64.exe", "warden\portwarden_windows_amd64.exe")
            wc.DownloadFile("https://github.com/bitwarden/cli/releases/download/v1.18.1/bw-windows-1.18.1.zip", "warden\bw.zip")
            If IO.File.Exists("warden\bw.exe") Then IO.File.Delete("warden\bw.exe")
            IO.Compression.ZipFile.ExtractToDirectory("warden\bw.zip", "warden\")
            IO.File.Delete("warden\bw.zip")
        End Using
        Form1.enable(True)
        Close()
    End Sub
End Class