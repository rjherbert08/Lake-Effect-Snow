<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.mnuSnowfall = New System.Windows.Forms.MenuStrip()
        Me.mnuFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClear = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnButton = New System.Windows.Forms.Button()
        Me.lstSnowfall = New System.Windows.Forms.ListBox()
        Me.btnEnterSnowfall = New System.Windows.Forms.Button()
        Me.lblTotalSnowfall = New System.Windows.Forms.Label()
        Me.mnuSnowfall.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(74, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(351, 39)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Lake Effect Snowfall"
        '
        'mnuSnowfall
        '
        Me.mnuSnowfall.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFile})
        Me.mnuSnowfall.Location = New System.Drawing.Point(0, 0)
        Me.mnuSnowfall.Name = "mnuSnowfall"
        Me.mnuSnowfall.Size = New System.Drawing.Size(537, 24)
        Me.mnuSnowfall.TabIndex = 1
        Me.mnuSnowfall.Text = "MenuStrip1"
        '
        'mnuFile
        '
        Me.mnuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuClear, Me.mnuExit})
        Me.mnuFile.Name = "mnuFile"
        Me.mnuFile.Size = New System.Drawing.Size(37, 20)
        Me.mnuFile.Text = "&File"
        '
        'mnuClear
        '
        Me.mnuClear.Name = "mnuClear"
        Me.mnuClear.Size = New System.Drawing.Size(101, 22)
        Me.mnuClear.Text = "&Clear"
        '
        'mnuExit
        '
        Me.mnuExit.Name = "mnuExit"
        Me.mnuExit.Size = New System.Drawing.Size(101, 22)
        Me.mnuExit.Text = "&Exit"
        '
        'btnButton
        '
        Me.btnButton.Location = New System.Drawing.Point(216, 392)
        Me.btnButton.Name = "btnButton"
        Me.btnButton.Size = New System.Drawing.Size(75, 23)
        Me.btnButton.TabIndex = 2
        Me.btnButton.Text = "Cancel"
        Me.btnButton.UseVisualStyleBackColor = True
        '
        'lstSnowfall
        '
        Me.lstSnowfall.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstSnowfall.FormattingEnabled = True
        Me.lstSnowfall.ItemHeight = 16
        Me.lstSnowfall.Location = New System.Drawing.Point(231, 174)
        Me.lstSnowfall.Name = "lstSnowfall"
        Me.lstSnowfall.Size = New System.Drawing.Size(42, 132)
        Me.lstSnowfall.TabIndex = 3
        '
        'btnEnterSnowfall
        '
        Me.btnEnterSnowfall.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEnterSnowfall.Location = New System.Drawing.Point(189, 125)
        Me.btnEnterSnowfall.Name = "btnEnterSnowfall"
        Me.btnEnterSnowfall.Size = New System.Drawing.Size(123, 32)
        Me.btnEnterSnowfall.TabIndex = 4
        Me.btnEnterSnowfall.Text = "Enter Snowfall"
        Me.btnEnterSnowfall.UseVisualStyleBackColor = True
        '
        'lblTotalSnowfall
        '
        Me.lblTotalSnowfall.AutoSize = True
        Me.lblTotalSnowfall.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalSnowfall.Location = New System.Drawing.Point(143, 346)
        Me.lblTotalSnowfall.Name = "lblTotalSnowfall"
        Me.lblTotalSnowfall.Size = New System.Drawing.Size(265, 20)
        Me.lblTotalSnowfall.TabIndex = 5
        Me.lblTotalSnowfall.Text = "Total amount of snowfall is XX.X ins."
        Me.lblTotalSnowfall.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Assignment6_RobertHerbert.My.Resources.Resources.snowfall
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(537, 510)
        Me.Controls.Add(Me.lblTotalSnowfall)
        Me.Controls.Add(Me.btnEnterSnowfall)
        Me.Controls.Add(Me.lstSnowfall)
        Me.Controls.Add(Me.btnButton)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.mnuSnowfall)
        Me.MainMenuStrip = Me.mnuSnowfall
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.mnuSnowfall.ResumeLayout(False)
        Me.mnuSnowfall.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents mnuSnowfall As MenuStrip
    Friend WithEvents mnuFile As ToolStripMenuItem
    Friend WithEvents mnuClear As ToolStripMenuItem
    Friend WithEvents mnuExit As ToolStripMenuItem
    Friend WithEvents btnButton As Button
    Friend WithEvents lstSnowfall As ListBox
    Friend WithEvents btnEnterSnowfall As Button
    Friend WithEvents lblTotalSnowfall As Label
End Class
