Imports System.Data.OleDb
Public Class acars
    Dim provider As String
    Dim dataFile As String
    Dim connString As String
    Dim time As New DateTime

    Dim conn As OleDbConnection = New OleDbConnection
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        provider = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source ="
        'Change the following to your access database location
        dataFile = "C:\VisStudioProj\wav login Desktop App23\wav login Desktop App23\BIN\DEBUG\willairwayvirtualDatabase.accdb"
        connString = provider & dataFile
        conn.ConnectionString = connString
        'check status of connection string
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        Else
            conn.Close()
        End If

        Dim dt As New DataTable
        Dim ds As New DataSet
        ds.Tables.Add(dt)
        Dim da As New OleDbDataAdapter

        da = New OleDbDataAdapter("Select * from acars where fltnum Like '%" & TextBox1.Text & "%'", conn)
        da.Fill(dt)

        DataGridView1.DataSource = dt.DefaultView
    End Sub

    Private Sub StFlight_Click(sender As Object, e As System.EventArgs) Handles StFlight.Click
        If Timer1.Enabled = True Then
            Timer1.Stop()

        Else
            time = DateTime.Now
            Timer1.Start()

        End If


    End Sub

    Private Sub timer1_tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Dim difference As TimeSpan = DateTime.Now.Subtract(time)
        lblTimer.Text = difference.Hours.ToString & ":" &
            difference.Minutes.ToString & ":" &
            difference.Seconds.ToString
    End Sub

    Private Sub compflight_Click(sender As Object, e As EventArgs) Handles CompFlight.Click
        Timer1.Stop()

    End Sub


End Class
