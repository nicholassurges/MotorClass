Public Class MainForm

    Public Shared motors(9) As Motor                'Array of Motor Objects
    Public Shared intMotorCount As Integer = 0      'Number of objects stored


    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Initialize Array
        For i As Integer = 0 To 9
            motors(i) = New Motor()
        Next
    End Sub

    Private Sub UpdateListBox()

        'Update list box contents
        Dim i As Integer
        Dim str As String = ""

        'Clear list box
        lstMotorids.Items.Clear()

        'Load the ID number in Array
        'into the list box
        For i = 0 To intMotorCount - 1
            str = "ID: " & motors(i).MotorId & "," &
                motors(i).Description & ", " & motors(i).RPM & " RPM, " &
                motors(i).Voltage & " volts, status = " & motors(i).Status
            lstMotorids.Items.Add(str)
        Next
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        'Display Add Form

        Dim frmAdd As New AddForm()
        frmAdd.ShowDialog()
        UpdateListBox()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
