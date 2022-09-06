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
End Class
