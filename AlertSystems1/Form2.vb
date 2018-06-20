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
            Me.BackgroundImage = Image.FromFile("C:\Users\120nschnitzer\Downloads\joe1.jpg")
            Me.BackgroundImageLayout = BackgroundImageLayout.Stretch
            Form1.sngCounter = Form1.sngCounter + 1
        ElseIf Form1.sngCounter Mod 15 = 1 Then
            Me.BackgroundImage = Image.FromFile("C:\Users\120nschnitzer\Downloads\joe2.jfif")
            Me.BackgroundImageLayout = BackgroundImageLayout.Stretch
            Form1.sngCounter = Form1.sngCounter + 1
        ElseIf Form1.sngCounter Mod 15 = 2 Then
            Me.BackgroundImage = Image.FromFile("C:\Users\120nschnitzer\Downloads\joe3.jpg")
            Me.BackgroundImageLayout = BackgroundImageLayout.Stretch
            Form1.sngCounter = Form1.sngCounter + 1
        ElseIf Form1.sngCounter Mod 15 = 3 Then
            Me.BackgroundImage = Image.FromFile("C:\Users\120nschnitzer\Downloads\joe4.jpg")
            Me.BackgroundImageLayout = BackgroundImageLayout.Stretch
            Form1.sngCounter = Form1.sngCounter + 1
        ElseIf Form1.sngCounter Mod 15 = 4 Then
            Me.BackgroundImage = Image.FromFile("C:\Users\120nschnitzer\Downloads\joe5.jpg")
            Me.BackgroundImageLayout = BackgroundImageLayout.Stretch
            Form1.sngCounter = Form1.sngCounter + 1
        ElseIf Form1.sngCounter Mod 15 = 5 Then
            Me.BackgroundImage = Image.FromFile("C:\Users\120nschnitzer\Downloads\joe6.jpg")
            Me.BackgroundImageLayout = BackgroundImageLayout.Stretch
            Form1.sngCounter = Form1.sngCounter + 1
        ElseIf Form1.sngCounter Mod 15 = 6 Then
            Me.BackgroundImage = Image.FromFile("C:\Users\120nschnitzer\Downloads\joe7.jpg")
            Me.BackgroundImageLayout = BackgroundImageLayout.Stretch
            Form1.sngCounter = Form1.sngCounter + 1
        ElseIf Form1.sngCounter Mod 15 = 7 Then
            Me.BackgroundImage = Image.FromFile("C:\Users\120nschnitzer\Downloads\joe8.jpg")
            Me.BackgroundImageLayout = BackgroundImageLayout.Stretch
            Form1.sngCounter = Form1.sngCounter + 1
        ElseIf Form1.sngCounter Mod 15 = 8 Then
            Me.BackgroundImage = Image.FromFile("C:\Users\120nschnitzer\Downloads\joe9.jfif")
            Me.BackgroundImageLayout = BackgroundImageLayout.Stretch
            Form1.sngCounter = Form1.sngCounter + 1
        ElseIf Form1.sngCounter Mod 15 = 9 Then
            Me.BackgroundImage = Image.FromFile("C:\Users\120nschnitzer\Downloads\joe10.jpg")
            Me.BackgroundImageLayout = BackgroundImageLayout.Stretch
            Form1.sngCounter = Form1.sngCounter + 1
        ElseIf Form1.sngCounter Mod 15 = 10 Then
            Me.BackgroundImage = Image.FromFile("C:\Users\120nschnitzer\Downloads\joe11.jpg")
            Me.BackgroundImageLayout = BackgroundImageLayout.Stretch
            Form1.sngCounter = Form1.sngCounter + 1
        ElseIf Form1.sngCounter Mod 15 = 11 Then
            Me.BackgroundImage = Image.FromFile("C:\Users\120nschnitzer\Downloads\joe12.jpg")
            Me.BackgroundImageLayout = BackgroundImageLayout.Stretch
            Form1.sngCounter = Form1.sngCounter + 1
        ElseIf Form1.sngCounter Mod 15 = 13 Then
            Me.BackgroundImage = Image.FromFile("C:\Users\120nschnitzer\Downloads\joe13.jpg")
            Me.BackgroundImageLayout = BackgroundImageLayout.Stretch
            Form1.sngCounter = Form1.sngCounter + 1
        Else
            Me.BackgroundImage = Image.FromFile("C:\Users\120nschnitzer\Downloads\joe14.jpg")
            Me.BackgroundImageLayout = BackgroundImageLayout.Stretch
            Form1.sngCounter = Form1.sngCounter + 1
        End If
    End Sub
End Class