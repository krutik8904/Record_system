Imports System.Data.OleDb


Public Class Form4

    Sub recordshow()
        Dim con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\vb.net\demoDB.accdb")
        con.Open()
        Dim adp As New OleDbDataAdapter("select * from selling", con)
        Dim ds As New DataSet
        adp.Fill(ds, "student")
        DataGridView1.DataSource = ds.Tables("student")
        con.Close()

    End Sub

    Private Sub Label6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label6.Click

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
        second.Show()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\vb.net\demoDB.accdb")
        con.Open()
        Dim cmd As New OleDbCommand
        cmd.Connection = con
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "insert into selling values('" & pr.Text & "','" & pname.Text & "', '" & bname.Text & "', " & prc.Text & ",'" & gs.Text & "','" & am.Text & "')"
        cmd.ExecuteNonQuery()
        con.Close()
        MsgBox("Recoed Added successfully....")
        recordshow()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\vb.net\demoDB.accdb")
        con.Open()
        Dim cmd As New OleDbCommand
        cmd.Connection = con
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "update worker set p_name='" & pname.Text & "',  b_name=" & bname.Text & ", price=" & prc.Text & ", gst=" & gs.Text & ", amm=" & am.Text & ", where pro=" & pr.Text & " "
        cmd.ExecuteNonQuery()
        con.Close()
        MsgBox("Recoed updated successfully....")
        recordshow()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\vb.net\demoDB.accdb")
        con.Open()
        Dim cmd As New OleDbCommand
        cmd.Connection = con
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "delete from selling where pro=" & pr.Text & ""
        cmd.ExecuteNonQuery()
        con.Close()
        MsgBox("Recoed deleted successfully....")
        recordshow()
    End Sub
End Class