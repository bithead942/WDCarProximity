Public Class frmCarProximity

    Dim cLastSent As Char
    Dim bLastOccupedState As Boolean = True
    Dim bLastConnectState As Boolean = False
    Friend WithEvents Event_HistoryTableAdapter As New WatchdogDataSetTableAdapters.Event_HistoryTableAdapter

    Sub XbeeOpen()
        SerialPort1.PortName = cbCOMPort.Text
        'Wake up port
        SerialPort1.Open()
        If SerialPort1.IsOpen Then
            lblStatus.Text = "Open"
            cLastSent = "A"
            tReceive.Interval = 500   'Set so tReceive is off-set from tSend
            tReceive.Start()
            tSend.Start()
        End If
    End Sub

    Sub XbeeClose()
        tReceive.Stop()
        tSend.Stop()
        'put port to sleep
        SerialPort1.Close()
        lblStatus.Text = "Sleeping"

    End Sub

#Region "Timers"

    Private Sub tReceive_Tick(sender As System.Object, e As System.EventArgs) Handles tReceive.Tick
        Dim myBuffer As Char() = {"", ""}
        Dim iBytes As Integer

        tReceive.Interval = 1000
        Try
            iBytes = SerialPort1.BytesToRead
            If iBytes > 0 Then
                'If iBytes = 2 Then
                'SerialPort1.Read(myBuffer, 0, 2)
                SerialPort1.DiscardInBuffer()
                lblStatus.Text = "Car in range"
                lblLastReceived.Text = Now.ToString
                If bLastConnectState = False Then
                    'Just acquired signal - prepare house
                    Event_HistoryTableAdapter.InsertQuery("5059")
                    Event_Current_StateTableAdapter.SetGeoFence()
                    XbeeClose()
                End If
            Else
                lblStatus.Text = "Car out of range"
                SerialPort1.DiscardInBuffer()
            End If

        Catch ex As Exception
            lblStatus.Text = "X"
            SerialPort1.DiscardInBuffer()
        End Try
    End Sub

    Private Sub tSend_Tick(sender As System.Object, e As System.EventArgs) Handles tSend.Tick

        If SerialPort1.IsOpen Then
            cLastSent = ChrW(AscW(cLastSent) + 1)
            If cLastSent = "z" Then
                cLastSent = "A"
            End If
            SerialPort1.Write(cLastSent)

        End If
    End Sub

    Private Sub tOccupied_Tick(sender As System.Object, e As System.EventArgs) Handles tOccupied.Tick
        lblLastChecked.Text = Now.ToString
        Me.Event_Current_StateTableAdapter.Fill(Me.WatchdogDataSet.Event_Current_State)

        If House_OccupiedLabel1.Text = "1" And Not bLastOccupedState Then
            'Just got home and didn't receive a signal
            XbeeClose()
        ElseIf House_OccupiedLabel1.Text = "0" And bLastOccupedState Then
            'Just left
            Thread.Sleep(300000)  'Give an extra 5 minutes to get out of range
            XbeeOpen()
            Event_HistoryTableAdapter.InsertQuery("5060")
        End If

        If House_OccupiedLabel1.Text = "1" Then
            bLastOccupedState = True
        Else
            bLastOccupedState = False
        End If
    End Sub

#End Region

    Private Sub Form1_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Event_HistoryTableAdapter.InsertQuery("9026")
    End Sub

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim ports As String() = SerialPort.GetPortNames()
        Dim badChars As Char() = New Char() {"c"}

        Event_HistoryTableAdapter.InsertQuery("9025")
        lblLastReceived.Text = ""
        lblLastChecked.Text = ""
        lblStatus.Text = "Sleeping"

        For Each port In ports
            ' .NET Framework has a bug where COM ports are
            ' sometimes appended with a 'c' characeter!
            If port.IndexOfAny(badChars) <> -1 Then
                cbCOMPort.Items.Add(port.Substring(0, port.Length - 1))
            Else
                cbCOMPort.Items.Add(port)
            End If
            cbCOMPort.Text = port
        Next
        If cbCOMPort.Items.Count = 0 Then
            cbCOMPort.Text = ""
        Else
            cbCOMPort.Text = "COM27"
        End If

        Try
            SerialPort1.PortName = cbCOMPort.Text
            SerialPort1.Open()
            If SerialPort1.IsOpen Then
                SerialPort1.Close()
                btnStart.Enabled = False
                btnStop.Enabled = True
                tOccupied.Start()
            Else
                MsgBox("Error opening COM Port: " & cbCOMPort.Text)
                btnStart.Enabled = True
                btnStop.Enabled = False
            End If
        Catch ex As Exception
            MsgBox("Error opening COM Port: " & cbCOMPort.Text)
            btnStart.Enabled = True
            btnStop.Enabled = False
        End Try

    End Sub

    Private Sub btnStart_Click(sender As System.Object, e As System.EventArgs) Handles btnStart.Click
        Try
            SerialPort1.PortName = cbCOMPort.Text
            SerialPort1.Open()
            If SerialPort1.IsOpen Then
                SerialPort1.Close()
                btnStart.Enabled = False
                btnStop.Enabled = True
                tOccupied.Start()
            Else
                MsgBox("Error opening COM Port: " & cbCOMPort.Text)
                btnStart.Enabled = True
                btnStop.Enabled = False
            End If
        Catch ex As Exception
            MsgBox("Error opening COM Port: " & cbCOMPort.Text)
            btnStart.Enabled = True
            btnStop.Enabled = False
        End Try

    End Sub

    Private Sub btnStop_Click(sender As System.Object, e As System.EventArgs) Handles btnStop.Click
        tOccupied.Stop()
        btnStart.Enabled = True
        btnStop.Enabled = False
    End Sub
End Class
