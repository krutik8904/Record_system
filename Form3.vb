
Imports System.Data.OleDb


Public Class Form3
    Sub recordshow()
        Dim con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\vb.net\demoDB.accdb")
        con.Open()
        Dim adp As New OleDbDataAdapter("select * from worker", con)
        Dim ds As New DataSet
        adp.Fill(ds, "student")
        DataGridView1.DataSource = ds.Tables("student")
        con.Close()
    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Hide()
        second.Show()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Me.Hide()
        Form2.Show()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Me.Hide()
        Form4.Show()

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\vb.net\demoDB.accdb")
        con.Open()
        Dim cmd As New OleDbCommand
        cmd.Connection = con
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "insert into worker values(" & mno.Text & ",'" & wname.Text & "', " & acno.Text & ", " & slry.Text & "," & upd.Text & ")"
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
        cmd.CommandText = "update worker set w_name='" & wname.Text & "',  ac_no=" & acno.Text & ", salary=" & slry.Text & ", up=" & upd.Text & ", where m_no=" & mno.Text & " "
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
        cmd.CommandText = "delete from worker where m_no=" & mno.Text & ""
        cmd.ExecuteNonQuery()
        con.Close()
        MsgBox("Recoed deleted successfully....")
        recordshow()
    End Sub
End Class