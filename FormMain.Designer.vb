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
        Me.ButtonRegister = New System.Windows.Forms.Button()
        Me.LabelStatus = New System.Windows.Forms.Label()
        Me.ButtonHotKey = New System.Windows.Forms.Button()
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.RestoreToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ButtonRegister
        '
        Me.ButtonRegister.Location = New System.Drawing.Point(15, 12)
        Me.ButtonRegister.Name = "ButtonRegister"
        Me.ButtonRegister.Size = New System.Drawing.Size(219, 31)
        Me.ButtonRegister.TabIndex = 0
        Me.ButtonRegister.Text = "Register"
        Me.ButtonRegister.UseVisualStyleBackColor = True
        '
        'LabelStatus
        '
        Me.LabelStatus.Location = New System.Drawing.Point(12, 83)
        Me.LabelStatus.Name = "LabelStatus"
        Me.LabelStatus.Size = New System.Drawing.Size(222, 26)
        Me.LabelStatus.TabIndex = 3
        Me.LabelStatus.Text = "Status: Idle."
        Me.LabelStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ButtonHotKey
        '
        Me.ButtonHotKey.Location = New System.Drawing.Point(15, 49)
        Me.ButtonHotKey.Name = "ButtonHotKey"
        Me.ButtonHotKey.Size = New System.Drawing.Size(219, 31)
        Me.ButtonHotKey.TabIndex = 4
        Me.ButtonHotKey.Text = "HotKeyHelper"
        Me.ButtonHotKey.UseVisualStyleBackColor = True
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
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(157, 88)
        '
        'RestoreToolStripMenuItem
        '
        Me.RestoreToolStripMenuItem.Name = "RestoreToolStripMenuItem"
        Me.RestoreToolStripMenuItem.Size = New System.Drawing.Size(180, 26)
        Me.RestoreToolStripMenuItem.Text = "Restore"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(180, 26)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'GitToolStripMenuItem
        '
        Me.GitToolStripMenuItem.Name = "GitToolStripMenuItem"
        Me.GitToolStripMenuItem.Size = New System.Drawing.Size(180, 26)
        Me.GitToolStripMenuItem.Text = "Homepage"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(177, 6)
        '
        'FormMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(246, 115)
        Me.Controls.Add(Me.ButtonHotKey)
        Me.Controls.Add(Me.LabelStatus)
        Me.Controls.Add(Me.ButtonRegister)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(262, 155)
        Me.MinimumSize = New System.Drawing.Size(262, 155)
        Me.Name = "FormMain"
        Me.Text = "SpotiKeys"
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ButtonRegister As Button
    Friend WithEvents LabelStatus As Label
    Friend WithEvents ButtonHotKey As Button
    Friend WithEvents NotifyIcon1 As NotifyIcon
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents RestoreToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
End Class
