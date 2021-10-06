<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.buttonBackup = New System.Windows.Forms.Button()
        Me.textboxHost = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.textboxPassword1 = New System.Windows.Forms.TextBox()
        Me.textboxPassword2 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel()
        Me.textboxBackupDir = New System.Windows.Forms.TextBox()
        Me.buttonPickBackupDir = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.groupBackup = New System.Windows.Forms.GroupBox()
        Me.groupDecrypt = New System.Windows.Forms.GroupBox()
        Me.buttonPickBackupFile = New System.Windows.Forms.Button()
        Me.textboxBackupFile = New System.Windows.Forms.TextBox()
        Me.buttonDecrypt = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.textboxPassword3 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.LinkLabel3 = New System.Windows.Forms.LinkLabel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.LinkLabel4 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel5 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel6 = New System.Windows.Forms.LinkLabel()
        Me.groupBackup.SuspendLayout()
        Me.groupDecrypt.SuspendLayout()
        Me.SuspendLayout()
        '
        'buttonBackup
        '
        Me.buttonBackup.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.buttonBackup.Location = New System.Drawing.Point(311, 129)
        Me.buttonBackup.Name = "buttonBackup"
        Me.buttonBackup.Size = New System.Drawing.Size(75, 23)
        Me.buttonBackup.TabIndex = 0
        Me.buttonBackup.Text = "Backup"
        Me.buttonBackup.UseVisualStyleBackColor = True
        '
        'textboxHost
        '
        Me.textboxHost.Enabled = False
        Me.textboxHost.Location = New System.Drawing.Point(186, 23)
        Me.textboxHost.Name = "textboxHost"
        Me.textboxHost.Size = New System.Drawing.Size(199, 20)
        Me.textboxHost.TabIndex = 1
        Me.textboxHost.TabStop = False
        Me.textboxHost.Text = "https://bitwarden.com"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Host"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.BackColor = System.Drawing.Color.Transparent
        Me.CheckBox1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.CheckBox1.Location = New System.Drawing.Point(368, 26)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox1.TabIndex = 3
        Me.CheckBox1.UseVisualStyleBackColor = False
        '
        'textboxPassword1
        '
        Me.textboxPassword1.Location = New System.Drawing.Point(186, 49)
        Me.textboxPassword1.Name = "textboxPassword1"
        Me.textboxPassword1.Size = New System.Drawing.Size(199, 20)
        Me.textboxPassword1.TabIndex = 4
        '
        'textboxPassword2
        '
        Me.textboxPassword2.Location = New System.Drawing.Point(186, 75)
        Me.textboxPassword2.Name = "textboxPassword2"
        Me.textboxPassword2.Size = New System.Drawing.Size(199, 20)
        Me.textboxPassword2.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(144, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Backup encryption password"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 78)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(142, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Repeat encryption password"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(41, 26)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(13, 13)
        Me.LinkLabel1.TabIndex = 8
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "?"
        '
        'LinkLabel2
        '
        Me.LinkLabel2.AutoSize = True
        Me.LinkLabel2.Location = New System.Drawing.Point(156, 52)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(13, 13)
        Me.LinkLabel2.TabIndex = 9
        Me.LinkLabel2.TabStop = True
        Me.LinkLabel2.Text = "?"
        '
        'textboxBackupDir
        '
        Me.textboxBackupDir.Location = New System.Drawing.Point(186, 102)
        Me.textboxBackupDir.Name = "textboxBackupDir"
        Me.textboxBackupDir.Size = New System.Drawing.Size(169, 20)
        Me.textboxBackupDir.TabIndex = 10
        Me.textboxBackupDir.Text = "backup\"
        '
        'buttonPickBackupDir
        '
        Me.buttonPickBackupDir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.buttonPickBackupDir.Location = New System.Drawing.Point(361, 101)
        Me.buttonPickBackupDir.Name = "buttonPickBackupDir"
        Me.buttonPickBackupDir.Size = New System.Drawing.Size(24, 22)
        Me.buttonPickBackupDir.TabIndex = 11
        Me.buttonPickBackupDir.Text = "..."
        Me.buttonPickBackupDir.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 105)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(87, 13)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Backup directory"
        '
        'FolderBrowserDialog1
        '
        Me.FolderBrowserDialog1.SelectedPath = "backup"
        '
        'groupBackup
        '
        Me.groupBackup.Controls.Add(Me.Label1)
        Me.groupBackup.Controls.Add(Me.Label4)
        Me.groupBackup.Controls.Add(Me.CheckBox1)
        Me.groupBackup.Controls.Add(Me.buttonBackup)
        Me.groupBackup.Controls.Add(Me.buttonPickBackupDir)
        Me.groupBackup.Controls.Add(Me.textboxHost)
        Me.groupBackup.Controls.Add(Me.textboxBackupDir)
        Me.groupBackup.Controls.Add(Me.LinkLabel2)
        Me.groupBackup.Controls.Add(Me.textboxPassword1)
        Me.groupBackup.Controls.Add(Me.LinkLabel1)
        Me.groupBackup.Controls.Add(Me.textboxPassword2)
        Me.groupBackup.Controls.Add(Me.Label3)
        Me.groupBackup.Controls.Add(Me.Label2)
        Me.groupBackup.Location = New System.Drawing.Point(12, 12)
        Me.groupBackup.Name = "groupBackup"
        Me.groupBackup.Size = New System.Drawing.Size(393, 160)
        Me.groupBackup.TabIndex = 13
        Me.groupBackup.TabStop = False
        Me.groupBackup.Text = "Create Backup"
        '
        'groupDecrypt
        '
        Me.groupDecrypt.Controls.Add(Me.Label6)
        Me.groupDecrypt.Controls.Add(Me.textboxPassword3)
        Me.groupDecrypt.Controls.Add(Me.Label5)
        Me.groupDecrypt.Controls.Add(Me.buttonDecrypt)
        Me.groupDecrypt.Controls.Add(Me.buttonPickBackupFile)
        Me.groupDecrypt.Controls.Add(Me.textboxBackupFile)
        Me.groupDecrypt.Location = New System.Drawing.Point(411, 12)
        Me.groupDecrypt.Name = "groupDecrypt"
        Me.groupDecrypt.Size = New System.Drawing.Size(212, 105)
        Me.groupDecrypt.TabIndex = 14
        Me.groupDecrypt.TabStop = False
        Me.groupDecrypt.Text = "Decrypt Backup"
        '
        'buttonPickBackupFile
        '
        Me.buttonPickBackupFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.buttonPickBackupFile.Location = New System.Drawing.Point(181, 45)
        Me.buttonPickBackupFile.Name = "buttonPickBackupFile"
        Me.buttonPickBackupFile.Size = New System.Drawing.Size(24, 22)
        Me.buttonPickBackupFile.TabIndex = 14
        Me.buttonPickBackupFile.Text = "..."
        Me.buttonPickBackupFile.UseVisualStyleBackColor = True
        '
        'textboxBackupFile
        '
        Me.textboxBackupFile.Location = New System.Drawing.Point(65, 46)
        Me.textboxBackupFile.Name = "textboxBackupFile"
        Me.textboxBackupFile.Size = New System.Drawing.Size(110, 20)
        Me.textboxBackupFile.TabIndex = 13
        '
        'buttonDecrypt
        '
        Me.buttonDecrypt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.buttonDecrypt.Location = New System.Drawing.Point(130, 75)
        Me.buttonDecrypt.Name = "buttonDecrypt"
        Me.buttonDecrypt.Size = New System.Drawing.Size(75, 23)
        Me.buttonDecrypt.TabIndex = 13
        Me.buttonDecrypt.Text = "Decrypt"
        Me.buttonDecrypt.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        Me.OpenFileDialog1.Filter = "Portwarden backup|*.portwarden"
        Me.OpenFileDialog1.InitialDirectory = "backup"
        '
        'textboxPassword3
        '
        Me.textboxPassword3.Location = New System.Drawing.Point(65, 23)
        Me.textboxPassword3.Name = "textboxPassword3"
        Me.textboxPassword3.Size = New System.Drawing.Size(140, 20)
        Me.textboxPassword3.TabIndex = 15
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 26)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 13)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Password"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 49)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(44, 13)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Backup"
        '
        'LinkLabel3
        '
        Me.LinkLabel3.AutoSize = True
        Me.LinkLabel3.Location = New System.Drawing.Point(521, 124)
        Me.LinkLabel3.Name = "LinkLabel3"
        Me.LinkLabel3.Size = New System.Drawing.Size(40, 13)
        Me.LinkLabel3.TabIndex = 15
        Me.LinkLabel3.TabStop = True
        Me.LinkLabel3.Text = "GitHub"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(412, 124)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(54, 13)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Bitwarden"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(412, 141)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(61, 13)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Portwarden"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(412, 159)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(83, 13)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "Portwarden GUI"
        '
        'LinkLabel4
        '
        Me.LinkLabel4.AutoSize = True
        Me.LinkLabel4.Location = New System.Drawing.Point(521, 141)
        Me.LinkLabel4.Name = "LinkLabel4"
        Me.LinkLabel4.Size = New System.Drawing.Size(40, 13)
        Me.LinkLabel4.TabIndex = 19
        Me.LinkLabel4.TabStop = True
        Me.LinkLabel4.Text = "GitHub"
        '
        'LinkLabel5
        '
        Me.LinkLabel5.AutoSize = True
        Me.LinkLabel5.Location = New System.Drawing.Point(521, 159)
        Me.LinkLabel5.Name = "LinkLabel5"
        Me.LinkLabel5.Size = New System.Drawing.Size(40, 13)
        Me.LinkLabel5.TabIndex = 20
        Me.LinkLabel5.TabStop = True
        Me.LinkLabel5.Text = "GitHub"
        '
        'LinkLabel6
        '
        Me.LinkLabel6.AutoSize = True
        Me.LinkLabel6.Location = New System.Drawing.Point(567, 124)
        Me.LinkLabel6.Name = "LinkLabel6"
        Me.LinkLabel6.Size = New System.Drawing.Size(30, 13)
        Me.LinkLabel6.TabIndex = 21
        Me.LinkLabel6.TabStop = True
        Me.LinkLabel6.Text = "Web"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(634, 182)
        Me.Controls.Add(Me.LinkLabel6)
        Me.Controls.Add(Me.LinkLabel5)
        Me.Controls.Add(Me.LinkLabel4)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.LinkLabel3)
        Me.Controls.Add(Me.groupDecrypt)
        Me.Controls.Add(Me.groupBackup)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "Portwarden GUI v0.1.0.0                                                          " &
    "                     Bitwarden CLI v1.18.1 | Portwarden v1.0.0"
        Me.groupBackup.ResumeLayout(False)
        Me.groupBackup.PerformLayout()
        Me.groupDecrypt.ResumeLayout(False)
        Me.groupDecrypt.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents buttonBackup As Button
    Friend WithEvents textboxHost As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents textboxPassword1 As TextBox
    Friend WithEvents textboxPassword2 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents LinkLabel2 As LinkLabel
    Friend WithEvents textboxBackupDir As TextBox
    Friend WithEvents buttonPickBackupDir As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents groupBackup As GroupBox
    Friend WithEvents groupDecrypt As GroupBox
    Friend WithEvents buttonDecrypt As Button
    Friend WithEvents buttonPickBackupFile As Button
    Friend WithEvents textboxBackupFile As TextBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents Label6 As Label
    Friend WithEvents textboxPassword3 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents LinkLabel3 As LinkLabel
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents LinkLabel4 As LinkLabel
    Friend WithEvents LinkLabel5 As LinkLabel
    Friend WithEvents LinkLabel6 As LinkLabel
End Class
