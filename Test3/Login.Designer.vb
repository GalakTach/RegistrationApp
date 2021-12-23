<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Me.BtnStu = New System.Windows.Forms.Button()
        Me.BtnDir = New System.Windows.Forms.Button()
        Me.BtnLogout = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'BtnStu
        '
        Me.BtnStu.Location = New System.Drawing.Point(102, 33)
        Me.BtnStu.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.BtnStu.Name = "BtnStu"
        Me.BtnStu.Size = New System.Drawing.Size(125, 32)
        Me.BtnStu.TabIndex = 0
        Me.BtnStu.Text = "Student"
        Me.BtnStu.UseVisualStyleBackColor = True
        '
        'BtnDir
        '
        Me.BtnDir.Location = New System.Drawing.Point(102, 126)
        Me.BtnDir.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.BtnDir.Name = "BtnDir"
        Me.BtnDir.Size = New System.Drawing.Size(125, 32)
        Me.BtnDir.TabIndex = 1
        Me.BtnDir.Text = "Director"
        Me.BtnDir.UseVisualStyleBackColor = True
        '
        'BtnLogout
        '
        Me.BtnLogout.Location = New System.Drawing.Point(102, 226)
        Me.BtnLogout.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.BtnLogout.Name = "BtnLogout"
        Me.BtnLogout.Size = New System.Drawing.Size(125, 32)
        Me.BtnLogout.TabIndex = 2
        Me.BtnLogout.Text = "Logout"
        Me.BtnLogout.UseVisualStyleBackColor = True
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(342, 310)
        Me.ControlBox = False
        Me.Controls.Add(Me.BtnLogout)
        Me.Controls.Add(Me.BtnDir)
        Me.Controls.Add(Me.BtnStu)
        Me.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BtnStu As System.Windows.Forms.Button
    Friend WithEvents BtnDir As System.Windows.Forms.Button
    Friend WithEvents BtnLogout As System.Windows.Forms.Button
End Class
