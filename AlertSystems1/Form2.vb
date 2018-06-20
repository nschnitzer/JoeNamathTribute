Public Class Form2
    Dim sngNum As Single
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        sngNum = Rnd()
        If (sngNum < 0.3) Then
            Me.BackColor = Color.LimeGreen
        ElseIf sngNum < 0.5 Then
            Me.BackColor = Color.Red
        Else
            Me.BackColor = Color.Cyan
        End If
        Dim frm As Form2
        frm = New Form2
        frm.Timer1.Enabled = True
        frm.Show()
    End Sub

    Private Sub btnInstall_Click(sender As Object, e As EventArgs) Handles btnAdmit.Click
        Dim frm As Form2
        frm = New Form2
        frm.Height = 350
        frm.Width = 250
        frm.Show()
        frm.Timer1.Start()
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        StartPosition = FormStartPosition.Manual
        Location = New Point(Rnd() * 5000, Rnd() * 1000)
        If Form1.sngCounter Mod 15 = 0 Then
            Me.BackgroundImage = AlertSystems1.My.Resources.joe1
            Me.BackgroundImageLayout = BackgroundImageLayout.Stretch
            Form1.sngCounter = Form1.sngCounter + 1
        ElseIf Form1.sngCounter Mod 15 = 1 Then
            Me.BackgroundImage = AlertSystems1.My.Resources.joe3
            Me.BackgroundImageLayout = BackgroundImageLayout.Stretch
            Form1.sngCounter = Form1.sngCounter + 1
        ElseIf Form1.sngCounter Mod 15 = 2 Then
            Me.BackgroundImage = AlertSystems1.My.Resources.joe4
            Me.BackgroundImageLayout = BackgroundImageLayout.Stretch
            Form1.sngCounter = Form1.sngCounter + 1
        ElseIf Form1.sngCounter Mod 15 = 3 Then
            Me.BackgroundImage = AlertSystems1.My.Resources.joe5
            Me.BackgroundImageLayout = BackgroundImageLayout.Stretch
            Form1.sngCounter = Form1.sngCounter + 1
        ElseIf Form1.sngCounter Mod 15 = 4 Then
            Me.BackgroundImage = AlertSystems1.My.Resources.joe6
            Me.BackgroundImageLayout = BackgroundImageLayout.Stretch
            Form1.sngCounter = Form1.sngCounter + 1
        ElseIf Form1.sngCounter Mod 15 = 5 Then
            Me.BackgroundImage = AlertSystems1.My.Resources.joe7
            Me.BackgroundImageLayout = BackgroundImageLayout.Stretch
            Form1.sngCounter = Form1.sngCounter + 1
        ElseIf Form1.sngCounter Mod 15 = 6 Then
            Me.BackgroundImage = AlertSystems1.My.Resources.joe8
            Me.BackgroundImageLayout = BackgroundImageLayout.Stretch
            Form1.sngCounter = Form1.sngCounter + 1
        ElseIf Form1.sngCounter Mod 15 = 7 Then
            Me.BackgroundImage = AlertSystems1.My.Resources.joe10
            Me.BackgroundImageLayout = BackgroundImageLayout.Stretch
            Form1.sngCounter = Form1.sngCounter + 1
        ElseIf Form1.sngCounter Mod 15 = 8 Then
            Me.BackgroundImage = AlertSystems1.My.Resources.joe11
            Me.BackgroundImageLayout = BackgroundImageLayout.Stretch
            Form1.sngCounter = Form1.sngCounter + 1
        ElseIf Form1.sngCounter Mod 15 = 9 Then
            Me.BackgroundImage = AlertSystems1.My.Resources.joe12
            Me.BackgroundImageLayout = BackgroundImageLayout.Stretch
            Form1.sngCounter = Form1.sngCounter + 1
        ElseIf Form1.sngCounter Mod 15 = 10 Then
            Me.BackgroundImage = AlertSystems1.My.Resources.joe13
            Me.BackgroundImageLayout = BackgroundImageLayout.Stretch
            Form1.sngCounter = Form1.sngCounter + 1
        Else
            Me.BackgroundImage = AlertSystems1.My.Resources.joe14
            Me.BackgroundImageLayout = BackgroundImageLayout.Stretch
            Form1.sngCounter = Form1.sngCounter + 1
        End If
    End Sub
End Class