Public Class Form1
    Public Shared sngTracker As Single = 0
    Public Shared sngCounter As Single = 0
    Dim sngHour As Single
    Dim sngMin As Single
    Dim strMessage As String
    Dim strTime As String
    Dim dtmAlertTime As New System.DateTime()
    Private Sub mnuExit_Click(sender As Object, e As EventArgs) Handles mnuExit.Click
        Me.Close()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Me.lblCurTime.Text = DateTime.Now.ToShortTimeString
        If DateTime.Now.ToShortTimeString = strTime Then
            Dim frm As Form2
            frm = New Form2
            frm.Show()
        End If


    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Me.btnSubmit.Visible = False
        strTime = Me.dtmPicker1.Value.ToShortTimeString
        strMessage = txtMessage.Text
        '  MessageBox.Show(strTime)
        ' sngMin = (txtMin.Text)
        Dim sngYear As Single = Val(DateTime.Now.Year)
        Dim sngMonth As Single = Val(DateTime.Now.Month)
        Dim sngDay As Single = Val(DateTime.Now.Day)
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles dtmPicker1.ValueChanged

    End Sub
End Class
