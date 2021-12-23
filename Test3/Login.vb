Public Class Login
    'Programmer Arthur Sulian
    'Visual Basic Final
    Private Sub BtnStu_Click(sender As System.Object, e As System.EventArgs) Handles BtnStu.Click
        'shows student form
        frmReg.Show()
        Me.Hide()
    End Sub

    Private Sub BtnDir_Click(sender As System.Object, e As System.EventArgs) Handles BtnDir.Click
        'shows instructor form
        Me.Hide()
        frmDir.Show()
    End Sub

    Private Sub BtnLogout_Click(sender As System.Object, e As System.EventArgs) Handles BtnLogout.Click
        'closes the program
        Application.Exit()
    End Sub
End Class