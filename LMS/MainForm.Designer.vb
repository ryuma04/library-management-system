<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddBooksToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddGroupToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IssueBookToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReturnBookToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BookReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CustomerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddCustomerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewCustomerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AllRentedToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WindowsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseAllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SettingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewProfileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.CustomerToolStripMenuItem, Me.ViewToolStripMenuItem, Me.WindowsToolStripMenuItem, Me.SettingToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(614, 28)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.BackColor = System.Drawing.Color.LightGray
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddBooksToolStripMenuItem, Me.AddGroupToolStripMenuItem, Me.IssueBookToolStripMenuItem, Me.ReturnBookToolStripMenuItem, Me.BookReportToolStripMenuItem, Me.ToolStripSeparator1, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(44, 24)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'AddBooksToolStripMenuItem
        '
        Me.AddBooksToolStripMenuItem.Name = "AddBooksToolStripMenuItem"
        Me.AddBooksToolStripMenuItem.Size = New System.Drawing.Size(160, 24)
        Me.AddBooksToolStripMenuItem.Text = "&Add Books"
        '
        'AddGroupToolStripMenuItem
        '
        Me.AddGroupToolStripMenuItem.Name = "AddGroupToolStripMenuItem"
        Me.AddGroupToolStripMenuItem.Size = New System.Drawing.Size(160, 24)
        Me.AddGroupToolStripMenuItem.Text = "Add &Genre"
        '
        'IssueBookToolStripMenuItem
        '
        Me.IssueBookToolStripMenuItem.Name = "IssueBookToolStripMenuItem"
        Me.IssueBookToolStripMenuItem.Size = New System.Drawing.Size(160, 24)
        Me.IssueBookToolStripMenuItem.Text = "&Issue Book"
        '
        'ReturnBookToolStripMenuItem
        '
        Me.ReturnBookToolStripMenuItem.Name = "ReturnBookToolStripMenuItem"
        Me.ReturnBookToolStripMenuItem.Size = New System.Drawing.Size(160, 24)
        Me.ReturnBookToolStripMenuItem.Text = "&Return Book"
        '
        'BookReportToolStripMenuItem
        '
        Me.BookReportToolStripMenuItem.Name = "BookReportToolStripMenuItem"
        Me.BookReportToolStripMenuItem.Size = New System.Drawing.Size(160, 24)
        Me.BookReportToolStripMenuItem.Text = "&Search Book"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(157, 6)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(160, 24)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'CustomerToolStripMenuItem
        '
        Me.CustomerToolStripMenuItem.BackColor = System.Drawing.Color.LightGray
        Me.CustomerToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddCustomerToolStripMenuItem, Me.ViewCustomerToolStripMenuItem})
        Me.CustomerToolStripMenuItem.Name = "CustomerToolStripMenuItem"
        Me.CustomerToolStripMenuItem.Size = New System.Drawing.Size(84, 24)
        Me.CustomerToolStripMenuItem.Text = "&Customer"
        '
        'AddCustomerToolStripMenuItem
        '
        Me.AddCustomerToolStripMenuItem.Name = "AddCustomerToolStripMenuItem"
        Me.AddCustomerToolStripMenuItem.Size = New System.Drawing.Size(278, 24)
        Me.AddCustomerToolStripMenuItem.Text = "A&dd/Delete/Update Customer"
        '
        'ViewCustomerToolStripMenuItem
        '
        Me.ViewCustomerToolStripMenuItem.Name = "ViewCustomerToolStripMenuItem"
        Me.ViewCustomerToolStripMenuItem.Size = New System.Drawing.Size(278, 24)
        Me.ViewCustomerToolStripMenuItem.Text = "&View Customer"
        '
        'ViewToolStripMenuItem
        '
        Me.ViewToolStripMenuItem.BackColor = System.Drawing.Color.LightGray
        Me.ViewToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AllRentedToolStripMenuItem})
        Me.ViewToolStripMenuItem.Name = "ViewToolStripMenuItem"
        Me.ViewToolStripMenuItem.Size = New System.Drawing.Size(53, 24)
        Me.ViewToolStripMenuItem.Text = "&View"
        '
        'AllRentedToolStripMenuItem
        '
        Me.AllRentedToolStripMenuItem.Name = "AllRentedToolStripMenuItem"
        Me.AllRentedToolStripMenuItem.Size = New System.Drawing.Size(152, 24)
        Me.AllRentedToolStripMenuItem.Text = "All Rented"
        '
        'WindowsToolStripMenuItem
        '
        Me.WindowsToolStripMenuItem.BackColor = System.Drawing.Color.LightGray
        Me.WindowsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CloseAllToolStripMenuItem})
        Me.WindowsToolStripMenuItem.Name = "WindowsToolStripMenuItem"
        Me.WindowsToolStripMenuItem.Size = New System.Drawing.Size(82, 24)
        Me.WindowsToolStripMenuItem.Text = "&Windows"
        '
        'CloseAllToolStripMenuItem
        '
        Me.CloseAllToolStripMenuItem.Name = "CloseAllToolStripMenuItem"
        Me.CloseAllToolStripMenuItem.Size = New System.Drawing.Size(152, 24)
        Me.CloseAllToolStripMenuItem.Text = "Close A&ll"
        '
        'SettingToolStripMenuItem
        '
        Me.SettingToolStripMenuItem.BackColor = System.Drawing.Color.LightGray
        Me.SettingToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ViewProfileToolStripMenuItem})
        Me.SettingToolStripMenuItem.Name = "SettingToolStripMenuItem"
        Me.SettingToolStripMenuItem.Size = New System.Drawing.Size(68, 24)
        Me.SettingToolStripMenuItem.Text = "&Setting"
        '
        'ViewProfileToolStripMenuItem
        '
        Me.ViewProfileToolStripMenuItem.Name = "ViewProfileToolStripMenuItem"
        Me.ViewProfileToolStripMenuItem.Size = New System.Drawing.Size(157, 24)
        Me.ViewProfileToolStripMenuItem.Text = "View Profile"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.BackColor = System.Drawing.Color.LightGray
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(53, 24)
        Me.HelpToolStripMenuItem.Text = "&Help"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 441)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Padding = New System.Windows.Forms.Padding(1, 0, 16, 0)
        Me.StatusStrip1.Size = New System.Drawing.Size(614, 22)
        Me.StatusStrip1.TabIndex = 3
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.LMS.My.Resources.Resources.mainpic
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(614, 463)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Candara", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LIBRARY MANAGEMENT SYSTEM"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddBooksToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IssueBookToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReturnBookToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BookReportToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CustomerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddCustomerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewCustomerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents WindowsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CloseAllToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddGroupToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ColorDialog1 As System.Windows.Forms.ColorDialog
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents ViewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AllRentedToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SettingToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewProfileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
