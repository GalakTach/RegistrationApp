<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReg
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
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.lblFirst = New System.Windows.Forms.Label()
        Me.lblLast = New System.Windows.Forms.Label()
        Me.lblID = New System.Windows.Forms.Label()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.cmbboxDepartment = New System.Windows.Forms.ComboBox()
        Me.cmbboxClasses = New System.Windows.Forms.ComboBox()
        Me.btnComplete = New System.Windows.Forms.Button()
        Me.lstSchedule = New System.Windows.Forms.ListBox()
        Me.lblSemester = New System.Windows.Forms.Label()
        Me.btnChangeSem = New System.Windows.Forms.Button()
        Me.btnChangeStu = New System.Windows.Forms.Button()
        Me.RdoFall = New System.Windows.Forms.RadioButton()
        Me.RdoSpring = New System.Windows.Forms.RadioButton()
        Me.RdoSummer = New System.Windows.Forms.RadioButton()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ABOUTToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MainMenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoutAndExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtFirstName
        '
        Me.txtFirstName.Location = New System.Drawing.Point(131, 46)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(205, 26)
        Me.txtFirstName.TabIndex = 0
        '
        'lblFirst
        '
        Me.lblFirst.AutoSize = True
        Me.lblFirst.Location = New System.Drawing.Point(5, 46)
        Me.lblFirst.Name = "lblFirst"
        Me.lblFirst.Size = New System.Drawing.Size(108, 18)
        Me.lblFirst.TabIndex = 3
        Me.lblFirst.Text = "First Name"
        '
        'lblLast
        '
        Me.lblLast.AutoSize = True
        Me.lblLast.Location = New System.Drawing.Point(5, 90)
        Me.lblLast.Name = "lblLast"
        Me.lblLast.Size = New System.Drawing.Size(98, 18)
        Me.lblLast.TabIndex = 4
        Me.lblLast.Text = "Last Name"
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.Location = New System.Drawing.Point(5, 136)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(108, 18)
        Me.lblID.TabIndex = 5
        Me.lblID.Text = "Student ID"
        '
        'btnSubmit
        '
        Me.btnSubmit.Enabled = False
        Me.btnSubmit.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubmit.Location = New System.Drawing.Point(86, 202)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(108, 33)
        Me.btnSubmit.TabIndex = 3
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'txtLastName
        '
        Me.txtLastName.Enabled = False
        Me.txtLastName.Location = New System.Drawing.Point(132, 90)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(204, 26)
        Me.txtLastName.TabIndex = 1
        '
        'txtID
        '
        Me.txtID.Enabled = False
        Me.txtID.Location = New System.Drawing.Point(132, 136)
        Me.txtID.MaxLength = 9
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(204, 26)
        Me.txtID.TabIndex = 2
        '
        'cmbboxDepartment
        '
        Me.cmbboxDepartment.Enabled = False
        Me.cmbboxDepartment.FormattingEnabled = True
        Me.cmbboxDepartment.Location = New System.Drawing.Point(579, 63)
        Me.cmbboxDepartment.Name = "cmbboxDepartment"
        Me.cmbboxDepartment.Size = New System.Drawing.Size(213, 26)
        Me.cmbboxDepartment.TabIndex = 7
        Me.cmbboxDepartment.Text = "Department"
        '
        'cmbboxClasses
        '
        Me.cmbboxClasses.FormattingEnabled = True
        Me.cmbboxClasses.Location = New System.Drawing.Point(392, 154)
        Me.cmbboxClasses.Name = "cmbboxClasses"
        Me.cmbboxClasses.Size = New System.Drawing.Size(481, 26)
        Me.cmbboxClasses.TabIndex = 6
        Me.cmbboxClasses.Text = "Select Course"
        Me.cmbboxClasses.Visible = False
        '
        'btnComplete
        '
        Me.btnComplete.Location = New System.Drawing.Point(559, 201)
        Me.btnComplete.Name = "btnComplete"
        Me.btnComplete.Size = New System.Drawing.Size(212, 34)
        Me.btnComplete.TabIndex = 7
        Me.btnComplete.Text = "Complete"
        Me.btnComplete.UseVisualStyleBackColor = True
        Me.btnComplete.Visible = False
        '
        'lstSchedule
        '
        Me.lstSchedule.Enabled = False
        Me.lstSchedule.FormattingEnabled = True
        Me.lstSchedule.ItemHeight = 18
        Me.lstSchedule.Location = New System.Drawing.Point(150, 330)
        Me.lstSchedule.Name = "lstSchedule"
        Me.lstSchedule.Size = New System.Drawing.Size(591, 148)
        Me.lstSchedule.TabIndex = 10
        '
        'lblSemester
        '
        Me.lblSemester.AutoSize = True
        Me.lblSemester.Location = New System.Drawing.Point(335, 309)
        Me.lblSemester.Name = "lblSemester"
        Me.lblSemester.Size = New System.Drawing.Size(0, 18)
        Me.lblSemester.TabIndex = 12
        '
        'btnChangeSem
        '
        Me.btnChangeSem.Location = New System.Drawing.Point(747, 336)
        Me.btnChangeSem.Name = "btnChangeSem"
        Me.btnChangeSem.Size = New System.Drawing.Size(126, 54)
        Me.btnChangeSem.TabIndex = 8
        Me.btnChangeSem.Text = "Change Semester"
        Me.btnChangeSem.UseVisualStyleBackColor = True
        Me.btnChangeSem.Visible = False
        '
        'btnChangeStu
        '
        Me.btnChangeStu.Location = New System.Drawing.Point(15, 330)
        Me.btnChangeStu.Name = "btnChangeStu"
        Me.btnChangeStu.Size = New System.Drawing.Size(129, 66)
        Me.btnChangeStu.TabIndex = 9
        Me.btnChangeStu.Text = "Change Student"
        Me.btnChangeStu.UseVisualStyleBackColor = True
        Me.btnChangeStu.Visible = False
        '
        'RdoFall
        '
        Me.RdoFall.AutoSize = True
        Me.RdoFall.Enabled = False
        Me.RdoFall.Location = New System.Drawing.Point(399, 48)
        Me.RdoFall.Name = "RdoFall"
        Me.RdoFall.Size = New System.Drawing.Size(66, 22)
        Me.RdoFall.TabIndex = 4
        Me.RdoFall.TabStop = True
        Me.RdoFall.Text = "Fall"
        Me.RdoFall.UseVisualStyleBackColor = True
        '
        'RdoSpring
        '
        Me.RdoSpring.AutoSize = True
        Me.RdoSpring.Enabled = False
        Me.RdoSpring.Location = New System.Drawing.Point(399, 77)
        Me.RdoSpring.Name = "RdoSpring"
        Me.RdoSpring.Size = New System.Drawing.Size(86, 22)
        Me.RdoSpring.TabIndex = 5
        Me.RdoSpring.TabStop = True
        Me.RdoSpring.Text = "Spring"
        Me.RdoSpring.UseVisualStyleBackColor = True
        '
        'RdoSummer
        '
        Me.RdoSummer.AutoSize = True
        Me.RdoSummer.Enabled = False
        Me.RdoSummer.Location = New System.Drawing.Point(399, 106)
        Me.RdoSummer.Name = "RdoSummer"
        Me.RdoSummer.Size = New System.Drawing.Size(86, 22)
        Me.RdoSummer.TabIndex = 6
        Me.RdoSummer.TabStop = True
        Me.RdoSummer.Text = "Summer"
        Me.RdoSummer.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ABOUTToolStripMenuItem, Me.MainMenuToolStripMenuItem, Me.LogoutAndExitToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(885, 24)
        Me.MenuStrip1.TabIndex = 13
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ABOUTToolStripMenuItem
        '
        Me.ABOUTToolStripMenuItem.Name = "ABOUTToolStripMenuItem"
        Me.ABOUTToolStripMenuItem.Size = New System.Drawing.Size(58, 20)
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
        Me.LogoutAndExitToolStripMenuItem.Size = New System.Drawing.Size(101, 20)
        Me.LogoutAndExitToolStripMenuItem.Text = "Logout and Exit"
        '
        'frmReg
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(885, 490)
        Me.ControlBox = False
        Me.Controls.Add(Me.RdoSummer)
        Me.Controls.Add(Me.RdoSpring)
        Me.Controls.Add(Me.RdoFall)
        Me.Controls.Add(Me.btnChangeStu)
        Me.Controls.Add(Me.btnChangeSem)
        Me.Controls.Add(Me.lblSemester)
        Me.Controls.Add(Me.lstSchedule)
        Me.Controls.Add(Me.btnComplete)
        Me.Controls.Add(Me.cmbboxClasses)
        Me.Controls.Add(Me.cmbboxDepartment)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.lblID)
        Me.Controls.Add(Me.lblLast)
        Me.Controls.Add(Me.lblFirst)
        Me.Controls.Add(Me.txtLastName)
        Me.Controls.Add(Me.txtFirstName)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Name = "frmReg"
        Me.Text = "Student Registration"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtFirstName As System.Windows.Forms.TextBox
    Friend WithEvents lblFirst As System.Windows.Forms.Label
    Friend WithEvents lblLast As System.Windows.Forms.Label
    Friend WithEvents lblID As System.Windows.Forms.Label
    Friend WithEvents btnSubmit As System.Windows.Forms.Button
    Friend WithEvents txtLastName As System.Windows.Forms.TextBox
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Friend WithEvents cmbboxDepartment As System.Windows.Forms.ComboBox
    Friend WithEvents cmbboxClasses As System.Windows.Forms.ComboBox
    Friend WithEvents btnComplete As System.Windows.Forms.Button
    Friend WithEvents lstSchedule As System.Windows.Forms.ListBox
    Friend WithEvents lblSemester As System.Windows.Forms.Label
    Friend WithEvents btnChangeSem As System.Windows.Forms.Button
    Friend WithEvents btnChangeStu As System.Windows.Forms.Button
    Friend WithEvents RdoFall As System.Windows.Forms.RadioButton
    Friend WithEvents RdoSpring As System.Windows.Forms.RadioButton
    Friend WithEvents RdoSummer As System.Windows.Forms.RadioButton
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ABOUTToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MainMenuToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LogoutAndExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
