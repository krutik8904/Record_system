﻿Public Class Form1
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim user As String
        Dim pass As String
        user = usid.Text
        pass = uspass.Text

        If (user.Equals("Admin") And pass.Equals("Admin@123")) Then
            Me.Hide()
            second.Show()

        Else
            MsgBox("login error")
        End If

    End Sub

   
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
