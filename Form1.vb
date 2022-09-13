Imports System.Data
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports Npgsql

Public Class Form1
    Dim lv As ListViewItem
    Dim selected As String


    Private Sub PopListView()
        lv1.Clear()

        With lv1
            .View = View.Details
            .GridLines = True
            .Columns.Add("ID", 48)
            .Columns.Add("Last Name", 110)
            .Columns.Add("First Name", 110)
            .Columns.Add("Position", 110)


        End With
        openCon()
        sql = "Select * from tbl_empinfo"
        cmd = New NpgsqlCommand(sql, cn)
        dr = cmd.ExecuteReader()

        Do While dr.Read() = True
            lv = New ListViewItem(dr("empno").ToString)
            lv.SubItems.Add(dr("emplastname"))
            lv.SubItems.Add(dr("empfirstname"))
            lv.SubItems.Add(dr("empposition"))
            lv1.Items.Add(lv)


        Loop
        cn.Close()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PopListView()
    End Sub

    Private Sub cmdsave_Click(sender As Object, e As EventArgs) Handles cmdsave.Click
        If MsgBox("Are you sure to save this record?", vbQuestion + vbYesNo) = vbYes Then
            openCon()
            sql = "INSERT INTO tbl_empinfo (empno, emplastname, empfirstname, empmidinitial, empaddress, empgender, empcontact, empposition)" _
            & "VALUES ('" & (Me.txtempno.Text) & "', '" & Me.txtlastname.Text & "', '" & Me.txtfirstname.Text & "', '" & Me.txtmi.Text & "', '" & Me.txtaddress.Text & "', '" & Me.cmbgender.Text & "', '" & Me.txtcontact.Text & "', '" & Me.cmbposition.Text & "')"
            cmd = New NpgsqlCommand(sql, cn)
            cmd.ExecuteNonQuery()
            cn.Close()


        End If
        PopListView()

    End Sub

    Private Sub lv1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lv1.SelectedIndexChanged
        Dim i As Integer
        For i = 0 To lv1.SelectedItems.Count - 1

            selected = lv1.SelectedItems(i).Text
            openCon()
            sql = "Select * from tbl_empinfo where empno = '" & selected & "'"
            cmd = New NpgsqlCommand(sql, cn)
            dr = cmd.ExecuteReader

            dr.Read()
            Me.txtempno.Text = dr("empno")
            Me.txtlastname.Text = dr("emplastname")
            Me.txtfirstname.Text = dr("empfirstname")
            Me.txtmi.Text = dr("empmidinitial")
            Me.txtaddress.Text = dr("empaddress")
            Me.cmbgender.Text = dr("empgender")
            Me.txtcontact.Text = dr("empcontact")
            Me.cmbposition.Text = dr("empposition")
            cn.Close()

        Next
    End Sub

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        If MsgBox("Are you sure to delete this record?", vbQuestion + vbYesNo) = vbYes Then
            openCon()
            sql = "DELETE FROM tbl_empinfo where empno = '" & selected & "'"
            cmd = New NpgsqlCommand(sql, cn)
            cmd.ExecuteNonQuery()
            cn.Close()


        End If
        PopListView()
    End Sub
End Class
