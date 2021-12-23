<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDir
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
        Me.cmbDept = New System.Windows.Forms.ComboBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ABOUTToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MainMenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoutAndExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BtnContinue = New System.Windows.Forms.Button()
        Me.lstClasses = New System.Windows.Forms.ListBox()
        Me.BtnAddclass = New System.Windows.Forms.Button()
        Me.BtnRemoveclass = New System.Windows.Forms.Button()
        Me.txtClassAdd = New System.Windows.Forms.TextBox()
        Me.lblprompt = New System.Windows.Forms.Label()
        Me.lblClassFormat = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmbDept
        '
        Me.cmbDept.FormattingEnabled = True
        Me.cmbDept.Location = New System.Drawing.Point(14, 28)
        Me.cmbDept.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.cmbDept.Name = "cmbDept"
        Me.cmbDept.Size = New System.Drawing.Size(308, 26)
        Me.cmbDept.TabIndex = 0
        Me.cmbDept.Text = "Department"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ABOUTToolStripMenuItem, Me.MainMenuToolStripMenuItem, Me.LogoutAndExitToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(606, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ABOUTToolStripMenuItem
        '
        Me.ABOUTToolStripMenuItem.Name = "ABOUTToolStripMenuItem"
        Me.ABOUTToolStripMenuItem.Size = New System.Drawing.Size(57, 20)
        Me.ABOUTToolStripMenuItem.Text = "ABOUT"
        '
        'MainMenuToolStripMenuItem
        '
        Me.MainMenuToolStripMenuItem.Name = "MainMenuToolStripMenuItem"
        Me.MainMenuToolStripMenuItem.Size = New System.Drawing.Size(80, 20)
        Me.MainMenuToolStripMenuItem.Text = "Main Menu"
        '
        'LogoutAndExitToolStripMenuItem
        '
        Me.LogoutAndExitToolStripMenuItem.Name = "LogoutAndExitToolStripMenuItem"
        Me.LogoutAndExitToolStripMenuItem.Size = New System.Drawing.Size(102, 20)
        Me.LogoutAndExitToolStripMenuItem.Text = "Logout and Exit"
        '
        'BtnContinue
        '
        Me.BtnContinue.Enabled = False
        Me.BtnContinue.Location = New System.Drawing.Point(379, 28)
        Me.BtnContinue.Name = "BtnContinue"
        Me.BtnContinue.Size = New System.Drawing.Size(170, 34)
        Me.BtnContinue.TabIndex = 2
        Me.BtnContinue.Text = "View Classes"
        Me.BtnContinue.UseVisualStyleBackColor = True
        '
        'lstClasses
        '
        Me.lstClasses.Enabled = False
        Me.lstClasses.FormattingEnabled = True
        Me.lstClasses.ItemHeight = 18
        Me.lstClasses.Location = New System.Drawing.Point(16, 77)
        Me.lstClasses.Name = "lstClasses"
        Me.lstClasses.Size = New System.Drawing.Size(579, 220)
        Me.lstClasses.TabIndex = 3
        '
        'BtnAddclass
        '
        Me.BtnAddclass.Enabled = False
        Me.BtnAddclass.Location = New System.Drawing.Point(227, 442)
        Me.BtnAddclass.Name = "BtnAddclass"
        Me.BtnAddclass.Size = New System.Drawing.Size(130, 29)
        Me.BtnAddclass.TabIndex = 4
        Me.BtnAddclass.Text = "Add a Class"
        Me.BtnAddclass.UseVisualStyleBackColor = True
        '
        'BtnRemoveclass
        '
        Me.BtnRemoveclass.Enabled = False
        Me.BtnRemoveclass.Location = New System.Drawing.Point(405, 303)
        Me.BtnRemoveclass.Name = "BtnRemoveclass"
        Me.BtnRemoveclass.Size = New System.Drawing.Size(189, 29)
        Me.BtnRemoveclass.TabIndex = 5
        Me.BtnRemoveclass.Text = "Remove Class"
        Me.BtnRemoveclass.UseVisualStyleBackColor = True
        '
        'txtClassAdd
        '
        Me.txtClassAdd.Location = New System.Drawing.Point(12, 410)
        Me.txtClassAdd.Name = "txtClassAdd"
        Me.txtClassAdd.Size = New System.Drawing.Size(583, 26)
        Me.txtClassAdd.TabIndex = 6
        '
        'lblprompt
        '
        Me.lblprompt.AutoSize = True
        Me.lblprompt.Location = New System.Drawing.Point(70, 359)
        Me.lblprompt.Name = "lblprompt"
        Me.lblprompt.Size = New System.Drawing.Size(458, 18)
        Me.lblprompt.TabIndex = 7
        Me.lblprompt.Text = "Type the class below in the following format."
        '
        'lblClassFormat
        '
        Me.lblClassFormat.AutoSize = True
        Me.lblClassFormat.Location = New System.Drawing.Point(13, 389)
        Me.lblClassFormat.Name = "lblClassFormat"
        Me.lblClassFormat.Size = New System.Drawing.Size(318, 18)
        Me.lblClassFormat.TabIndex = 8
        Me.lblClassFormat.Text = "Class Name Day/Day Hour to Hour"
        '
        'frmDir
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(606, 483)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblClassFormat)
        Me.Controls.Add(Me.lblprompt)
        Me.Controls.Add(Me.txtClassAdd)
        Me.Controls.Add(Me.BtnRemoveclass)
        Me.Controls.Add(Me.BtnAddclass)
        Me.Controls.Add(Me.lstClasses)
        Me.Controls.Add(Me.BtnContinue)
        Me.Controls.Add(Me.cmbDept)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Name = "frmDir"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Director"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmbDept As System.Windows.Forms.ComboBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ABOUTToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MainMenuToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LogoutAndExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BtnContinue As System.Windows.Forms.Button
    Friend WithEvents lstClasses As System.Windows.Forms.ListBox
    Friend WithEvents BtnAddclass As System.Windows.Forms.Button
    Friend WithEvents BtnRemoveclass As System.Windows.Forms.Button
    Friend WithEvents txtClassAdd As System.Windows.Forms.TextBox
    Friend WithEvents lblprompt As System.Windows.Forms.Label
    Friend WithEvents lblClassFormat As System.Windows.Forms.Label
End Class
