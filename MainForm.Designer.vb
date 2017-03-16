<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.Notify = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.ContextMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.MenuPort = New System.Windows.Forms.ToolStripMenuItem()
        Me.PortsList = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Separator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.MenuAbout = New System.Windows.Forms.ToolStripMenuItem()
        Me.Separator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.MenuExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.LabelName = New System.Windows.Forms.Label()
        Me.LabelCprt = New System.Windows.Forms.Label()
        Me.BoxLogo = New System.Windows.Forms.PictureBox()
        Me.ContextMenu.SuspendLayout()
        Me.PortsList.SuspendLayout()
        CType(Me.BoxLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Notify
        '
        Me.Notify.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.Notify.BalloonTipText = "Here is~"
        Me.Notify.BalloonTipTitle = "NSDN-Keypad Host"
        Me.Notify.ContextMenuStrip = Me.ContextMenu
        Me.Notify.Icon = CType(resources.GetObject("Notify.Icon"), System.Drawing.Icon)
        Me.Notify.Text = "NSDN-Keypad Host"
        Me.Notify.Visible = True
        '
        'ContextMenu
        '
        Me.ContextMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuPort, Me.Separator1, Me.MenuAbout, Me.Separator2, Me.MenuExit})
        Me.ContextMenu.Name = "ContextMenu"
        Me.ContextMenu.Size = New System.Drawing.Size(112, 82)
        '
        'MenuPort
        '
        Me.MenuPort.DropDown = Me.PortsList
        Me.MenuPort.Name = "MenuPort"
        Me.MenuPort.Size = New System.Drawing.Size(111, 22)
        Me.MenuPort.Text = "Ports"
        '
        'PortsList
        '
        Me.PortsList.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1})
        Me.PortsList.Name = "PortsList"
        Me.PortsList.OwnerItem = Me.MenuPort
        Me.PortsList.Size = New System.Drawing.Size(133, 26)
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(132, 22)
        Me.ToolStripMenuItem1.Text = "PortsItem"
        '
        'Separator1
        '
        Me.Separator1.Name = "Separator1"
        Me.Separator1.Size = New System.Drawing.Size(108, 6)
        '
        'MenuAbout
        '
        Me.MenuAbout.Name = "MenuAbout"
        Me.MenuAbout.Size = New System.Drawing.Size(111, 22)
        Me.MenuAbout.Text = "About"
        '
        'Separator2
        '
        Me.Separator2.Name = "Separator2"
        Me.Separator2.Size = New System.Drawing.Size(108, 6)
        '
        'MenuExit
        '
        Me.MenuExit.Name = "MenuExit"
        Me.MenuExit.Size = New System.Drawing.Size(111, 22)
        Me.MenuExit.Text = "Exit"
        '
        'LabelName
        '
        Me.LabelName.AutoSize = True
        Me.LabelName.Location = New System.Drawing.Point(77, 90)
        Me.LabelName.Name = "LabelName"
        Me.LabelName.Size = New System.Drawing.Size(101, 12)
        Me.LabelName.TabIndex = 2
        Me.LabelName.Text = "NSDN-Keypad Host"
        '
        'LabelCprt
        '
        Me.LabelCprt.AutoSize = True
        Me.LabelCprt.Location = New System.Drawing.Point(41, 107)
        Me.LabelCprt.Name = "LabelCprt"
        Me.LabelCprt.Size = New System.Drawing.Size(173, 12)
        Me.LabelCprt.TabIndex = 3
        Me.LabelCprt.Text = "Copyright © NSDN 2014 - 2017"
        '
        'BoxLogo
        '
        Me.BoxLogo.ErrorImage = Nothing
        Me.BoxLogo.Image = CType(resources.GetObject("BoxLogo.Image"), System.Drawing.Image)
        Me.BoxLogo.InitialImage = Nothing
        Me.BoxLogo.Location = New System.Drawing.Point(95, 12)
        Me.BoxLogo.Name = "BoxLogo"
        Me.BoxLogo.Size = New System.Drawing.Size(64, 64)
        Me.BoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BoxLogo.TabIndex = 4
        Me.BoxLogo.TabStop = False
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(256, 128)
        Me.Controls.Add(Me.BoxLogo)
        Me.Controls.Add(Me.LabelCprt)
        Me.Controls.Add(Me.LabelName)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MainForm"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Keypad Host"
        Me.WindowState = System.Windows.Forms.FormWindowState.Minimized
        Me.ContextMenu.ResumeLayout(False)
        Me.PortsList.ResumeLayout(False)
        CType(Me.BoxLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Notify As NotifyIcon
    Friend WithEvents ContextMenu As ContextMenuStrip
    Friend WithEvents MenuAbout As ToolStripMenuItem
    Friend WithEvents MenuExit As ToolStripMenuItem
    Friend WithEvents MenuPort As ToolStripMenuItem
    Friend WithEvents Separator1 As ToolStripSeparator
    Friend WithEvents Separator2 As ToolStripSeparator
    Friend WithEvents PortsList As ContextMenuStrip
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents LabelName As Label
    Friend WithEvents LabelCprt As Label
    Friend WithEvents BoxLogo As PictureBox
End Class
