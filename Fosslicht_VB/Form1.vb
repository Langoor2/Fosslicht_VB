Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.BackColor = Color.Red
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.BackColor = Color.Orange
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.BackColor = Color.Green
    End Sub
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Do
            Me.BackColor = Color.Green
            Delay(4)
            Me.BackColor = Color.Orange
            Delay(2)
            Me.BackColor = Color.Red
            Delay(2)
        Loop
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        If Me.BackColor = Color.LightSkyBlue Then
            Me.BackColor = Color.Red
        ElseIf Me.BackColor = Color.Red Then
            Me.BackColor = Color.Green
        ElseIf Me.BackColor = Color.Green Then
            Me.BackColor = Color.Orange
        ElseIf Me.BackColor = Color.Orange Then
            Me.BackColor = Color.Red
        End If
    End Sub
    Sub Delay(ByVal dblSecs As Double)

        Const OneSec As Double = 1.0# / (1440.0# * 60.0#)
        Dim dblWaitTil As Date
        Now.AddSeconds(OneSec)
        dblWaitTil = Now.AddSeconds(OneSec).AddSeconds(dblSecs)
        Do Until Now > dblWaitTil
            Application.DoEvents()
        Loop

    End Sub
End Class

