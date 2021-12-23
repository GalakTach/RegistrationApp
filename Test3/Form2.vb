Public Class frmDir
    'Programmer Arthur Sulian
    'Visual Basic Final
    Private Sub frmDir_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'loads departments from text file
        Dim Dept() As String = IO.File.ReadAllLines("Department.txt")
        For x = 0 To Dept.Length - 1
            cmbDept.Items.Add(Dept(x))
        Next
    End Sub

    Private Sub ABOUTToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ABOUTToolStripMenuItem.Click
        'gives information about me(the creator)
        MsgBox("This Program was created by Arthur Sulian", MsgBoxStyle.OkOnly, "THE CREATOR")
    End Sub

    Private Sub MainMenuToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles MainMenuToolStripMenuItem.Click
        'resets the program
        Application.Restart()
    End Sub

    Private Sub LogoutAndExitToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles LogoutAndExitToolStripMenuItem.Click
        'closes program
        Application.Exit()
    End Sub

    Private Sub cmbDept_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cmbDept.SelectedIndexChanged
        'enables button
        BtnContinue.Enabled = True
    End Sub

    Private Sub BtnContinue_Click(sender As System.Object, e As System.EventArgs) Handles BtnContinue.Click
        'shows list of classes for department selected
        lstClasses.Enabled = True
        BtnAddclass.Enabled = True
        BtnRemoveclass.Enabled = True
        Dim dep As String = cmbDept.SelectedItem
        dep = dep & ".txt"
        lstClasses.Items.Clear()
        Dim Classes() As String = IO.File.ReadAllLines(dep)
        For x = 0 To Classes.Length - 1
            lstClasses.Items.Add(Classes(x))
        Next
    End Sub

    Private Sub BtnAddclass_Click(sender As System.Object, e As System.EventArgs) Handles BtnAddclass.Click
        'allows adding of classes
        lstClasses.Items.Add(txtClassAdd.Text)
        Dim dep As String = cmbDept.SelectedItem
        dep = dep & ".txt"
        Dim fCreate As IO.StreamWriter = IO.File.CreateText(dep)
        fCreate.Close()
        Dim fWriter As IO.StreamWriter = IO.File.AppendText(dep)
        For x = 0 To lstClasses.Items.Count - 1
            fWriter.WriteLine(lstClasses.Items(x))
        Next
        fWriter.Close()
        txtClassAdd.Text = ""
        MsgBox("Class Added", MsgBoxStyle.OkOnly, "Action Complete")
    End Sub

    Private Sub BtnRemoveclass_Click(sender As System.Object, e As System.EventArgs) Handles BtnRemoveclass.Click
        'allows removal of classes
        If lstClasses.SelectedIndex <> -1 Then
            Dim listItem As Integer = lstClasses.SelectedIndex
            lstClasses.Items.RemoveAt(listItem)
            Dim dep As String = cmbDept.SelectedItem
            dep = dep & ".txt"
            Dim fCreate As IO.StreamWriter = IO.File.CreateText(dep)
            fCreate.Close()
            Dim fWriter As IO.StreamWriter = IO.File.AppendText(dep)
            For x = 0 To lstClasses.Items.Count - 1
                fWriter.WriteLine(lstClasses.Items(x))
            Next
            fWriter.Close()
            MsgBox("Class Removed", MsgBoxStyle.OkOnly, "Action Complete")
        Else
            MsgBox("Please Select a class to remove", MsgBoxStyle.OkOnly, "Error")
        End If
    End Sub

    Private Sub lstClasses_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstClasses.SelectedIndexChanged

    End Sub
End Class