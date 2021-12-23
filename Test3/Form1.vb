Public Class frmReg
    'Programmer Arthur Sulian
    'Tuesday Evening VB Final
    'Allows the user to type in a name last name and student id to register for classes. if the student exists they will
    'be allowed to add classes. if the student is not in the file they will be prompted if they want to enroll or not.
    'The Instructor is also allowed to modify classes on a different menu than the students use

    Private Sub txtFirstName_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtFirstName.TextChanged
        'enables last name text box
        txtLastName.Enabled = True
    End Sub

    Private Sub txtLastName_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtLastName.TextChanged
        'enables id text box
        txtID.Enabled = True
    End Sub

    Private Sub txtID_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtID.TextChanged
        'makes sure ID is 9 characters long
        If txtID.TextLength = 9 Then 'makes sure that the user types 9 digits for the id number. if it is below 9 the button becomes disabled
            btnSubmit.Enabled = True
        Else
            btnSubmit.Enabled = False
        End If
    End Sub

    Private Sub btnSubmit_Click(sender As System.Object, e As System.EventArgs) Handles btnSubmit.Click
        'checks to see if student is registered, if not asks if they want to register
        Dim Fname As String = txtFirstName.Text
        Dim Lname As String = txtLastName.Text
        Dim ID As String = txtID.Text
        Dim FileIn() As String = IO.File.ReadAllLines("Students.txt")
        Dim StoredName As String
        Dim test As Boolean
        Dim NameInputed As String = Fname.Trim & " " & Lname.Trim & " " & ID
        Dim FWriter As IO.StreamWriter = IO.File.AppendText("Students.txt")
        Dim test2 As Boolean = False
        Dim test3 As Boolean = True


        For x = 0 To FileIn.Length - 1 'checks to see if student is registered.
            StoredName = FileIn(x)
            If StoredName.ToUpper = NameInputed.ToUpper Then 'if the name exists in the file
                test = False 'test is set to false
                test2 = True
                Exit For 'for loop is exited
            Else
                If ID = StoredName.Substring(StoredName.Count - 9, 9) Then
                    test2 = False
                    MsgBox("Student ID already registered", MsgBoxStyle.OkOnly, "Error")
                    Exit For
                Else
                    test = True 'if name not found test is true
                    test2 = True
                End If
            End If
        Next

        If test = True Then 'asks student if they want to register
            Dim result As Integer = MsgBox("Would you like to register?", MsgBoxStyle.YesNo, "Student Not Registered")
            If result = DialogResult.Yes Then
                ' Dim FWriter As IO.StreamWriter = IO.File.AppendText("Students.txt")
                FWriter.WriteLine(NameInputed)
                FWriter.Close()
                test3 = True
            Else
                test3 = False 'form is reset if user selects no
                RdoFall.Enabled = False
                RdoSpring.Enabled = False
                RdoSummer.Enabled = False
                txtFirstName.Clear()
                txtLastName.Clear()
                txtID.Clear()
                txtID.Enabled = False
                txtLastName.Enabled = False
                txtFirstName.Enabled = True
                txtFirstName.Select()

                FWriter.Close() 'close file
            End If
            FWriter.Close() 'close file
        End If
        FWriter.Close()

        If test2 = True And test3 = True Then 'enables next part of the program
            RdoFall.Enabled = True
            RdoSpring.Enabled = True
            RdoSummer.Enabled = True
            txtFirstName.Enabled = False
            txtLastName.Enabled = False
            txtID.Enabled = False
            btnSubmit.Enabled = False
            Dim Dept() As String = IO.File.ReadAllLines("Department.txt")
            For x = 0 To Dept.Length - 1
                cmbboxDepartment.Items.Add(Dept(x))
            Next
        End If

    End Sub

    Private Sub cmbboxDepartment_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbboxDepartment.SelectedIndexChanged
        'Lists courses depending on the discipline selected
        ' reads all data from the file indicated
        ' displays the list on the listbox
        btnComplete.Visible = False
        cmbboxClasses.Items.Clear()
        cmbboxClasses.Text = "Select Course"
        cmbboxClasses.Visible = True
        If cmbboxDepartment.SelectedItem = "Chemistry" Then 'depending on which drop down items they select the drop down list is populated
            Dim Chem() As String = IO.File.ReadAllLines("Chemistry.txt")
            For x = 0 To Chem.Length - 1
                cmbboxClasses.Items.Add(Chem(x))
            Next
        ElseIf cmbboxDepartment.SelectedItem = "Computer Science" Then
            Dim CoSci() As String = IO.File.ReadAllLines("Computer Science.txt")
            For x = 0 To CoSci.Length - 1
                cmbboxClasses.Items.Add(CoSci(x))
            Next
        ElseIf cmbboxDepartment.SelectedItem = "Math" Then
            Dim Math() As String = IO.File.ReadAllLines("Math.txt")
            For x = 0 To Math.Length - 1
                cmbboxClasses.Items.Add(Math(x))
            Next
        ElseIf cmbboxDepartment.SelectedItem = "English" Then
            Dim Eng() As String = IO.File.ReadAllLines("English.txt")
            For x = 0 To Eng.Length - 1
                cmbboxClasses.Items.Add(Eng(x))
            Next
        ElseIf cmbboxDepartment.SelectedItem = "Physical Education" Then
            Dim PE() As String = IO.File.ReadAllLines("Physical Education.txt")
            For x = 0 To PE.Length - 1
                cmbboxClasses.Items.Add(PE(x))
            Next
        ElseIf cmbboxDepartment.SelectedItem = "Biology" Then
            Dim Bio() As String = IO.File.ReadAllLines("Biology.txt")
            For x = 0 To Bio.Length - 1
                cmbboxClasses.Items.Add(Bio(x))
            Next
        ElseIf cmbboxDepartment.SelectedItem = "Music" Then
            Dim Music() As String = IO.File.ReadAllLines("Music.txt")
            For x = 0 To Music.Length - 1
                cmbboxClasses.Items.Add(Music(x))
            Next
        End If
    End Sub

    Private Sub cmbboxClasses_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cmbboxClasses.SelectedIndexChanged
        ' button complete is not visible unless a class has been selected
        btnComplete.Visible = True
    End Sub

    Private Sub btnComplete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnComplete.Click
        'adds the selected class to the schedule
        Dim semTest As Boolean = True 'used to make sure that a semester is selected from the radio buttons
        If RdoFall.Checked = False And RdoSpring.Checked = False And RdoSummer.Checked = False Then
            semTest = False
        End If
        If semTest = True Then
            RdoFall.Enabled = False
            RdoSpring.Enabled = False
            RdoSummer.Enabled = False
            btnChangeSem.Visible = True
            lstSchedule.Enabled = True
            btnChangeStu.Visible = True
            Dim test4 As Boolean = True
            If RdoFall.Checked = True Then
                lblSemester.Text = "Fall Schedule" 'checks to see if class is added. if not adds the class. if yes gives error
            End If
            If RdoSpring.Checked = True Then
                lblSemester.Text = "Spring Schedule" 'checks to see if class is added. if not adds the class. if yes gives error
            End If
            If RdoSummer.Checked = True Then
                lblSemester.Text = "Summer Schedule" 'checks to see if class is added. if not adds the class. if yes gives error
            End If
            For x = 0 To lstSchedule.Items.Count - 1
                If cmbboxDepartment.SelectedItem & " --- " & cmbboxClasses.SelectedItem = lstSchedule.Items(x) Then
                    MsgBox("That class is already added.", MsgBoxStyle.OkOnly, "Error")
                    test4 = False
                End If
            Next
            If test4 = True Then
                MsgBox(cmbboxClasses.SelectedItem & " Successfully Added", MsgBoxStyle.OkCancel, "Success")
                lstSchedule.Items.Add(cmbboxDepartment.SelectedItem & " --- " & cmbboxClasses.SelectedItem)
            End If
        End If
        If semTest = False Then
            MsgBox("Please select a semester", MsgBoxStyle.OkOnly, "Error")
        End If
    End Sub

    Private Sub btnChangeSem_Click(sender As System.Object, e As System.EventArgs) Handles btnChangeSem.Click
        'allows user to change semester
        lblSemester.Text = ""
        lstSchedule.Items.Clear() 'allows user to change semester without allowing them to mix 2 or more different semesters
        RdoFall.Enabled = True
        RdoSpring.Enabled = True
        RdoSummer.Enabled = True
        cmbboxDepartment.Enabled = False
        cmbboxClasses.Visible = False
        btnComplete.Visible = False
    End Sub

    Private Sub btnChangeStu_Click(sender As System.Object, e As System.EventArgs) Handles btnChangeStu.Click
        'allows user to change student
        lblSemester.Text = "" 'resets the form when the user clicks change student button
        lstSchedule.Items.Clear()
        RdoFall.Enabled = False
        RdoSpring.Enabled = False
        RdoSummer.Enabled = False
        RdoFall.Checked = False
        RdoSpring.Checked = False
        RdoSummer.Checked = False
        cmbboxDepartment.Enabled = False
        cmbboxClasses.Visible = False
        btnComplete.Visible = False
        btnChangeSem.Visible = False
        btnSubmit.Enabled = False
        btnChangeStu.Visible = False
        lstSchedule.Enabled = False
        txtFirstName.Text = ""
        txtLastName.Text = ""
        txtID.Text = ""
        txtFirstName.Enabled = True
        txtLastName.Enabled = False
        txtID.Enabled = False
        txtFirstName.Focus()
    End Sub

    Private Sub RdoFall_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles RdoFall.MouseClick
        'unchecks other radio buttons
        RdoSpring.Checked = False
        RdoSummer.Checked = False
        cmbboxDepartment.Enabled = True
    End Sub

    Private Sub RdoSpring_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles RdoSpring.MouseClick
        'unchecks other radio buttons
        RdoFall.Checked = False
        RdoSummer.Checked = False
        cmbboxDepartment.Enabled = True
    End Sub

    Private Sub RdoSummer_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles RdoSummer.MouseClick
        'unchecks other radio buttons
        RdoFall.Checked = False
        RdoSpring.Checked = False
        cmbboxDepartment.Enabled = True
    End Sub

    Private Sub ABOUTToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ABOUTToolStripMenuItem.Click
        'message box about me the creator
        MsgBox("This Program was created by Arthur Sulian", MsgBoxStyle.OkOnly, "THE CREATOR")
    End Sub

    Private Sub MainMenuToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles MainMenuToolStripMenuItem.Click
        'resets program
        Application.Restart()
    End Sub

    Private Sub LogoutAndExitToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles LogoutAndExitToolStripMenuItem.Click
        'exits program
        Application.Exit()
    End Sub
End Class
