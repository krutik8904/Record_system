
Imports System.Data.OleDb

Public Class second
    Sub recordshow()
        Dim con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\vb.net\demoDB.accdb")
        con.Open()
        Dim adp As New OleDbDataAdapter("select * from std", con)
        Dim ds As New DataSet
        adp.Fill(ds, "student")
        DataGridView1.DataSource = ds.Tables("student")
        con.Close()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\vb.net\demoDB.accdb")
        con.Open()
        Dim cmd As New OleDbCommand
        cmd.Connection = con
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "insert into std values(" & mno.Text & ",'" & lname.Text & "', " & dno.Text & ", " & pro.Text & ", '" & shift.Text & "', '" & mt.Text & "')"
        cmd.ExecuteNonQuery()
        con.Close()
        MsgBox("Recoed Added successfully....")
        recordshow()

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\vb.net\demoDB.accdb")
        con.Open()
        Dim cmd As New OleDbCommand
        cmd.Connection = con
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "delete from std where m_no=" & mno.Text & ""
        cmd.ExecuteNonQuery()
        con.Close()
        MsgBox("Recoed deleted successfully....")
        recordshow()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\vb.net\demoDB.accdb")
        con.Open()
        Dim cmd As New OleDbCommand
        cmd.Connection = con
        cmd.CommandType = CommandType.Text
        cmd.CommandText = " update std set l_name='" & lname.Text & "', d_no=" & dno.Text & ", production=" & pro.Text & ", ship='" & shift.Text & "', material='" & mt.Text & "' where m_no=" & mno.Text & " "
        cmd.ExecuteNonQuery()
        con.Close()
        MsgBox("Recoed updated successfully....")
        recordshow()
    End Sub

    Private Sub second_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        recordshow()

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Hide()
        Form3.Show()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Me.Hide()
        Form2.Show()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Me.Hide()
        Form4.Show()
    End Sub
End Class