<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormMain
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMain))
        Me.ButtonHotKey = New System.Windows.Forms.Button()
        Me.LabelStatus = New System.Windows.Forms.Label()
        Me.ButtonRegister = New System.Windows.Forms.Button()
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.RestoreToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.GitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CheckAutoReg = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CheckAutoMin = New System.Windows.Forms.CheckBox()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ButtonHotKey
        '
        Me.ButtonHotKey.Location = New System.Drawing.Point(15, 100)
        Me.ButtonHotKey.Name = "ButtonHotKey"
        Me.ButtonHotKey.Size = New System.Drawing.Size(219, 31)
        Me.ButtonHotKey.TabIndex = 9
        Me.ButtonHotKey.Text = "HotKeyHelper"
        Me.ButtonHotKey.UseVisualStyleBackColor = True
        '
        'LabelStatus
        '
        Me.LabelStatus.Location = New System.Drawing.Point(12, 134)
        Me.LabelStatus.Name = "LabelStatus"
        Me.LabelStatus.Size = New System.Drawing.Size(222, 26)
        Me.LabelStatus.TabIndex = 8
        Me.LabelStatus.Text = "Status: Idle."
        Me.LabelStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ButtonRegister
        '
        Me.ButtonRegister.Location = New System.Drawing.Point(15, 63)
        Me.ButtonRegister.Name = "ButtonRegister"
        Me.ButtonRegister.Size = New System.Drawing.Size(219, 31)
        Me.ButtonRegister.TabIndex = 7
        Me.ButtonRegister.Text = "Register"
        Me.ButtonRegister.UseVisualStyleBackColor = True
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), System.Drawing.Icon)
        Me.NotifyIcon1.Text = "SpotiKeys"
        Me.NotifyIcon1.Visible = True
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RestoreToolStripMenuItem, Me.ExitToolStripMenuItem, Me.ToolStripSeparator1, Me.GitToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(134, 76)
        '
        'RestoreToolStripMenuItem
        '
        Me.RestoreToolStripMenuItem.Name = "RestoreToolStripMenuItem"
        Me.RestoreToolStripMenuItem.Size = New System.Drawing.Size(133, 22)
        Me.RestoreToolStripMenuItem.Text = "Restore"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(133, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(130, 6)
        '
        'GitToolStripMenuItem
        '
        Me.GitToolStripMenuItem.Name = "GitToolStripMenuItem"
        Me.GitToolStripMenuItem.Size = New System.Drawing.Size(133, 22)
        Me.GitToolStripMenuItem.Text = "Homepage"
        '
        'CheckAutoReg
        '
        Me.CheckAutoReg.AutoSize = True
        Me.CheckAutoReg.Location = New System.Drawing.Point(15, 19)
        Me.CheckAutoReg.Name = "CheckAutoReg"
        Me.CheckAutoReg.Size = New System.Drawing.Size(90, 17)
        Me.CheckAutoReg.TabIndex = 5
        Me.CheckAutoReg.Text = "Auto-Register"
        Me.CheckAutoReg.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CheckAutoMin)
        Me.GroupBox1.Controls.Add(Me.CheckAutoReg)
        Me.GroupBox1.Location = New System.Drawing.Point(15, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(219, 45)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Statup Options"
        '
        'CheckAutoMin
        '
        Me.CheckAutoMin.AutoSize = True
        Me.CheckAutoMin.Location = New System.Drawing.Point(122, 19)
        Me.CheckAutoMin.Name = "CheckAutoMin"
        Me.CheckAutoMin.Size = New System.Drawing.Size(91, 17)
        Me.CheckAutoMin.TabIndex = 6
        Me.CheckAutoMin.Text = "Auto-Minimize"
        Me.CheckAutoMin.UseVisualStyleBackColor = True
        '
        'FormMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(246, 159)
        Me.Controls.Add(Me.ButtonHotKey)
        Me.Controls.Add(Me.LabelStatus)
        Me.Controls.Add(Me.ButtonRegister)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SpotiKeys"
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ButtonHotKey As Button
    Friend WithEvents LabelStatus As Label
    Friend WithEvents ButtonRegister As Button
    Friend WithEvents NotifyIcon1 As NotifyIcon
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents RestoreToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents GitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CheckAutoReg As CheckBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents CheckAutoMin As CheckBox
End Class
