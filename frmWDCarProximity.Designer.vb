<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCarProximity
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCarProximity))
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.lblLastReceived = New System.Windows.Forms.Label()
        Me.tReceive = New System.Windows.Forms.Timer(Me.components)
        Me.tSend = New System.Windows.Forms.Timer(Me.components)
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cbCOMPort = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tOccupied = New System.Windows.Forms.Timer(Me.components)
        Me.House_OccupiedLabel1 = New System.Windows.Forms.Label()
        Me.Event_Current_StateBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.WatchdogDataSet = New WDCarProximity2.WatchdogDataSet()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.btnStop = New System.Windows.Forms.Button()
        Me.Event_Current_StateTableAdapter = New WDCarProximity2.WatchdogDataSetTableAdapters.Event_Current_StateTableAdapter()
        Me.TableAdapterManager = New WDCarProximity2.WatchdogDataSetTableAdapters.TableAdapterManager()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblLastChecked = New System.Windows.Forms.Label()
        CType(Me.Event_Current_StateBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WatchdogDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SerialPort1
        '
        Me.SerialPort1.PortName = "COM27"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 65)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Status:"
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.Location = New System.Drawing.Point(74, 65)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(56, 13)
        Me.lblStatus.TabIndex = 3
        Me.lblStatus.Text = "Sleeping"
        '
        'lblLastReceived
        '
        Me.lblLastReceived.AutoSize = True
        Me.lblLastReceived.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLastReceived.Location = New System.Drawing.Point(93, 89)
        Me.lblLastReceived.Name = "lblLastReceived"
        Me.lblLastReceived.Size = New System.Drawing.Size(110, 13)
        Me.lblLastReceived.TabIndex = 5
        Me.lblLastReceived.Text = "12/30/2000 12:00 AM"
        '
        'tReceive
        '
        Me.tReceive.Interval = 1000
        '
        'tSend
        '
        Me.tSend.Interval = 1000
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(29, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Port:"
        '
        'cbCOMPort
        '
        Me.cbCOMPort.FormattingEnabled = True
        Me.cbCOMPort.Location = New System.Drawing.Point(51, 6)
        Me.cbCOMPort.Name = "cbCOMPort"
        Me.cbCOMPort.Size = New System.Drawing.Size(89, 21)
        Me.cbCOMPort.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 41)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Occupied:"
        '
        'tOccupied
        '
        Me.tOccupied.Interval = 30000
        '
        'House_OccupiedLabel1
        '
        Me.House_OccupiedLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Event_Current_StateBindingSource, "House_Occupied", True))
        Me.House_OccupiedLabel1.Location = New System.Drawing.Point(74, 41)
        Me.House_OccupiedLabel1.Name = "House_OccupiedLabel1"
        Me.House_OccupiedLabel1.Size = New System.Drawing.Size(58, 13)
        Me.House_OccupiedLabel1.TabIndex = 17
        '
        'Event_Current_StateBindingSource
        '
        Me.Event_Current_StateBindingSource.DataMember = "Event_Current_State"
        Me.Event_Current_StateBindingSource.DataSource = Me.WatchdogDataSet
        '
        'WatchdogDataSet
        '
        Me.WatchdogDataSet.DataSetName = "WatchdogDataSet"
        Me.WatchdogDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 89)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 13)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Last Detected:"
        '
        'btnStart
        '
        Me.btnStart.Enabled = False
        Me.btnStart.Location = New System.Drawing.Point(15, 110)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(81, 29)
        Me.btnStart.TabIndex = 19
        Me.btnStart.Text = "Start"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'btnStop
        '
        Me.btnStop.Location = New System.Drawing.Point(119, 110)
        Me.btnStop.Name = "btnStop"
        Me.btnStop.Size = New System.Drawing.Size(81, 29)
        Me.btnStop.TabIndex = 20
        Me.btnStop.Text = "Stop"
        Me.btnStop.UseVisualStyleBackColor = True
        '
        'Event_Current_StateTableAdapter
        '
        Me.Event_Current_StateTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Event_Current_StateTableAdapter = Me.Event_Current_StateTableAdapter
        Me.TableAdapterManager.Event_HistoryTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = WDCarProximity2.WatchdogDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 145)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 13)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Last Checked:"
        '
        'lblLastChecked
        '
        Me.lblLastChecked.AutoSize = True
        Me.lblLastChecked.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLastChecked.Location = New System.Drawing.Point(93, 145)
        Me.lblLastChecked.Name = "lblLastChecked"
        Me.lblLastChecked.Size = New System.Drawing.Size(110, 13)
        Me.lblLastChecked.TabIndex = 22
        Me.lblLastChecked.Text = "12/30/2000 12:00 AM"
        '
        'frmCarProximity
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(212, 166)
        Me.Controls.Add(Me.lblLastChecked)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnStop)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.House_OccupiedLabel1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cbCOMPort)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblLastReceived)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmCarProximity"
        Me.Text = "WDCarProximity"
        CType(Me.Event_Current_StateBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WatchdogDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SerialPort1 As System.IO.Ports.SerialPort
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblStatus As System.Windows.Forms.Label
    Friend WithEvents lblLastReceived As System.Windows.Forms.Label
    Friend WithEvents tReceive As System.Windows.Forms.Timer
    Friend WithEvents tSend As System.Windows.Forms.Timer
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cbCOMPort As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents tOccupied As System.Windows.Forms.Timer
    Friend WithEvents WatchdogDataSet As WDCarProximity2.WatchdogDataSet
    Friend WithEvents Event_Current_StateBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Event_Current_StateTableAdapter As WDCarProximity2.WatchdogDataSetTableAdapters.Event_Current_StateTableAdapter
    Friend WithEvents TableAdapterManager As WDCarProximity2.WatchdogDataSetTableAdapters.TableAdapterManager
    Friend WithEvents House_OccupiedLabel1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnStart As System.Windows.Forms.Button
    Friend WithEvents btnStop As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblLastChecked As System.Windows.Forms.Label

End Class
