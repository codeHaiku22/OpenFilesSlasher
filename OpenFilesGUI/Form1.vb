Imports System.Management
Public Class frmMain

    Private mstrTargetServer As String
    Private mstrPreviousTarget As String
    Private mblnError As Boolean
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles Me.Load

        radRemote.Checked = True
        radAnd.Checked = True

        chkbxAccessedBy.Checked = False
        chkbxOpenFile.Checked = False

        txtAccessedBy.Enabled = False
        txtOpenFile.Enabled = False

        radOr.Enabled = False
        radAnd.Enabled = False

        grpbxTargetInfo.Visible = False

        lblNameIP.Text = ""
        lblPCManufacturerModel.Text = ""
        lblCPUManufacturerModel.Text = ""
        lblCPUCaption.Text = ""
        lblCPUProcessors.Text = ""
        lblRAM.Text = ""
        lblOSDetails.Text = ""
        lblCount.Text = ""

    End Sub
    Private Sub radLocal_CheckedChanged(sender As Object, e As EventArgs) Handles radLocal.CheckedChanged

        If radLocal.Checked Then
            txtServerName.Text = Environment.MachineName
            txtServerName.Enabled = False
        Else
            txtServerName.Text = ""
            txtServerName.Enabled = True
        End If

    End Sub
    Private Sub chkbxAccessedBy_CheckedChanged(sender As Object, e As EventArgs) Handles chkbxAccessedBy.CheckedChanged

        txtAccessedBy.Enabled = chkbxAccessedBy.Checked

        radOr.Enabled = (chkbxAccessedBy.Checked And chkbxOpenFile.Checked)
        radAnd.Enabled = (chkbxAccessedBy.Checked And chkbxOpenFile.Checked)

    End Sub
    Private Sub chkbxOpenFile_CheckedChanged(sender As Object, e As EventArgs) Handles chkbxOpenFile.CheckedChanged

        txtOpenFile.Enabled = chkbxOpenFile.Checked

        radOr.Enabled = (chkbxAccessedBy.Checked And chkbxOpenFile.Checked)
        radAnd.Enabled = (chkbxAccessedBy.Checked And chkbxOpenFile.Checked)

    End Sub
    Private Sub cmdDisplay_Click(sender As Object, e As EventArgs) Handles cmdDisplay.Click

        Dim strAccessFilter As String
        Dim strOrAnd As String
        Dim strFileFilter As String
        Dim strFullFilter As String

        If Len(txtServerName.Text.Trim) = 0 Then Exit Sub

        mstrPreviousTarget = mstrTargetServer
        mstrTargetServer = txtServerName.Text.Trim

        'Get IP Address and System Information
        If mstrTargetServer <> mstrPreviousTarget Then
            grpbxTargetInfo.Visible = False
            lblNameIP.Text = ""
            lblPCManufacturerModel.Text = ""
            lblCPUManufacturerModel.Text = ""
            lblCPUCaption.Text = ""
            lblCPUProcessors.Text = ""
            lblRAM.Text = ""
            lblOSDetails.Text = ""
            lblCount.Text = ""
            dgvResults.DataSource = Nothing
            dgvResults.Rows.Clear()
            lblCount.Text = "Results: 0"
            lblNameIP.Text = Get_HostName_Or_IPAddress(mstrTargetServer)
            If mblnError Then Exit Sub
            GetSystemInfo()
            If mblnError Then Exit Sub
            Application.DoEvents()
        End If

        If txtAccessedBy.Enabled And Len(txtAccessedBy.Text.Trim) > 0 Then strAccessFilter = "AccessedBy LIKE('%" & txtAccessedBy.Text.Trim & "%')"
        If txtOpenFile.Enabled And Len(txtOpenFile.Text.Trim) > 0 Then strFileFilter = "OpenFile LIKE('%" & txtOpenFile.Text.Trim & "%')"

        If radOr.Enabled And radOr.Checked Then strOrAnd = " OR "
        If radAnd.Enabled And radAnd.Checked Then strOrAnd = " AND "

        'Display open files and folders
        If Len(strAccessFilter) > 0 Or Len(strFileFilter) > 0 Then
            strFullFilter = strAccessFilter & strOrAnd & strFileFilter
            Call Display_Files_Folders(strFullFilter)
        Else
            Call Display_Files_Folders()
        End If

    End Sub
    Private Sub cmdSelectAll_Click(sender As Object, e As EventArgs) Handles cmdSelectAll.Click

        dgvResults.SelectAll()

    End Sub
    Private Sub cmdSelectNone_Click(sender As Object, e As EventArgs) Handles cmdSelectNone.Click

        dgvResults.ClearSelection()

    End Sub
    Private Sub cmdDisconnect_Click(sender As Object, e As EventArgs) Handles cmdDisconnect.Click

        If dgvResults.SelectedRows.Count = 0 Then Exit Sub

        Disconnect_Files_Folders()

    End Sub
    Private Function Get_HostName_Or_IPAddress(ByVal strHostNameorIPAddress As String) As String

        Dim blnIsIPAddress As Boolean
        Dim strHostName As String
        Dim strIPAddress As String
        Dim intError As Integer

        Try
            blnIsIPAddress = IsNumeric(Replace(strHostNameorIPAddress, ".", ""))
            If blnIsIPAddress Then
                strHostName = System.Net.Dns.GetHostEntry(strHostNameorIPAddress).HostName.ToString
                Get_HostName_Or_IPAddress = strHostName
            Else
                For Each ipAddress As System.Net.IPAddress In System.Net.Dns.GetHostAddresses(strHostNameorIPAddress)
                    If ipAddress.AddressFamily.ToString = "InterNetwork" Then
                        strIPAddress = strIPAddress & "/" & ipAddress.ToString
                    End If
                Next
                If strIPAddress.Length > 0 Then strIPAddress = Replace(strIPAddress, "/", "", 1, 1)
                Get_HostName_Or_IPAddress = strIPAddress
            End If
        Catch ex As Exception
            intError = Err.Number
            MsgBox("Error retrieving Host Name and/or IP Address.", vbCritical, "OpenFilesGUI")
        Finally
            mblnError = (intError > 0)
        End Try

    End Function
    Private Sub GetSystemInfo()

        Dim strOSManufacturer As String
        Dim strOSName As String
        Dim strOSVersion As String
        Dim strOSArchitecture As String
        Dim strWindowsDir As String
        Dim strComputerName As String
        Dim strPhysicalMemoryFree As String
        Dim strPhysicalMemoryTotal As String
        Dim sngPhysicalMemoryTotal As Single
        Dim strManufacturer As String
        Dim strModel As String
        Dim strSystemType As String
        Dim strProcessorsPhysical As String
        Dim strCPUManufacturer As String
        Dim strCPUName As String
        Dim strCPUCaption As String
        Dim strCPUClockSpeed As String
        Dim strCPUCores As String
        Dim strCPUProcessorsLogical As String
        Dim intError As Integer

        Try
            Dim strScope As String = "\\" & mstrTargetServer & "\root\cimv2"
            Dim objOS As New ManagementObjectSearcher(strScope, "SELECT * FROM Win32_OperatingSystem")
            Dim objCS As New ManagementObjectSearcher(strScope, "SELECT * FROM Win32_ComputerSystem")
            Dim objCPU As New ManagementObjectSearcher(strScope, "SELECT * FROM Win32_Processor")
            Dim objMgmt As ManagementObject
            For Each objMgmt In objOS.Get
                strOSManufacturer = objMgmt("manufacturer").ToString()
                strOSName = objMgmt("name").ToString()
                strOSVersion = objMgmt("version").ToString()
                strOSArchitecture = objMgmt("osarchitecture")
                strWindowsDir = objMgmt("windowsdirectory").ToString()
                strComputerName = objMgmt("csname").ToString()
                strPhysicalMemoryFree = objMgmt("freephysicalmemory").ToString()
            Next
            For Each objMgmt In objCS.Get
                strPhysicalMemoryTotal = objMgmt("totalphysicalmemory").ToString()
                sngPhysicalMemoryTotal = (Convert.ToInt64(strPhysicalMemoryTotal)) / 1024000000
                strManufacturer = objMgmt("manufacturer").ToString()
                strModel = objMgmt("model").ToString()
                strSystemType = objMgmt("systemtype").ToString
                strProcessorsPhysical = objMgmt("numberofprocessors").ToString
            Next
            For Each objMgmt In objCPU.Get
                strCPUManufacturer = objMgmt("manufacturer").ToString()
                strCPUName = objMgmt("name").ToString()
                strCPUCaption = objMgmt("caption").ToString()
                strCPUClockSpeed = objMgmt("maxclockspeed").ToString()
                strCPUCores = objMgmt("numberofcores").ToString
                strCPUProcessorsLogical = objMgmt("numberoflogicalprocessors").ToString
            Next
            If InStr(strOSName, "|") > 0 Then
                Dim vArray() As String
                vArray = Split(strOSName, "|")
                strOSName = vArray(0)
            End If
            grpbxTargetInfo.Visible = True
            lblPCManufacturerModel.Text = strManufacturer & " " & strModel & " (" & strSystemType & ")"
            lblCPUManufacturerModel.Text = strCPUManufacturer & " " & strCPUName
            lblCPUCaption.Text = strCPUCaption
            lblCPUProcessors.Text = "Processors: " & strCPUProcessorsLogical & " (" & strCPUCores & " Cores) @" & strCPUClockSpeed & " MHz"
            lblRAM.Text = "Total Physical Memory: " & Format(sngPhysicalMemoryTotal, "0.0") & " GB"
            lblOSDetails.Text = strOSManufacturer & " " & strOSName & " " & strOSArchitecture & " (" & strOSVersion & ")"
        Catch ex As Exception
            intError = Err.Number
            MsgBox("Error retrieving WMI information.", vbCritical, "OpenFilesGUI")
        Finally
            mblnError = (intError > 0)
        End Try

    End Sub
    Private Sub Display_Files_Folders(Optional ByVal strSearchFilter As String = "")

        Dim procOpenFiles As New Process
        Dim intError As Integer

        'Create the shell and execute the command
        Try
            With procOpenFiles
                .StartInfo.FileName = "C:\Windows\System32\openfiles.exe"
                .StartInfo.Arguments = "/query /s " & mstrTargetServer & " /v"
                .StartInfo.UseShellExecute = False
                .StartInfo.CreateNoWindow = True
                .StartInfo.RedirectStandardError = True
                .StartInfo.RedirectStandardOutput = True
                .StartInfo.Verb = "runas"
            End With
            procOpenFiles.Start()
            If procOpenFiles.StandardOutput Is Nothing Then Exit Sub
            Dim dtblAllResults As New DataTable
            Dim strOutputLine As String
            Dim objOpenFilesFields(6) As Object
            With dtblAllResults
                .Columns.Add("HostName", GetType(String))
                .Columns.Add("ID", GetType(String))
                .Columns.Add("AccessedBy", GetType(String))
                .Columns.Add("Type", GetType(String))
                .Columns.Add("Locks", GetType(String))
                .Columns.Add("OpenMode", GetType(String))
                .Columns.Add("OpenFile", GetType(String))
            End With
            'Read the first blank line and the header line
            strOutputLine = procOpenFiles.StandardOutput.ReadLine
            strOutputLine = procOpenFiles.StandardOutput.ReadLine
            Do
                strOutputLine = procOpenFiles.StandardOutput.ReadLine
                If Len(strOutputLine) > 0 And InStr(strOutputLine, "=====") = 0 Then
                    objOpenFilesFields(0) = strOutputLine.Substring(0, 15).Trim   'Host Name
                    objOpenFilesFields(1) = strOutputLine.Substring(16, 8).Trim   'ID
                    objOpenFilesFields(2) = strOutputLine.Substring(25, 20).Trim  'Accessed By        
                    objOpenFilesFields(3) = strOutputLine.Substring(46, 10).Trim  'Type
                    objOpenFilesFields(4) = strOutputLine.Substring(57, 10).Trim  'Locks        
                    objOpenFilesFields(5) = strOutputLine.Substring(68, 15).Trim  'Open Mode
                    objOpenFilesFields(6) = strOutputLine.Substring(84).Trim      'Open File
                    dtblAllResults.LoadDataRow(objOpenFilesFields, True)
                End If
            Loop Until strOutputLine Is Nothing
            If Len(strSearchFilter) > 0 Then
                Dim dtrowResults() As DataRow = dtblAllResults.Select(strSearchFilter)
                If dtrowResults.Length = 0 Then Exit Sub
                Dim dtblSomeResults As DataTable = dtblAllResults.Clone
                For Each dtrow As DataRow In dtrowResults
                    dtblSomeResults.ImportRow(dtrow)
                Next
                dgvResults.DataSource = dtblSomeResults
            Else
                dgvResults.DataSource = dtblAllResults
            End If
        Catch ex As Exception
            intError = Err.Number
            MsgBox("Error retrieving and displaying data.", vbCritical, "OpenFilesGUI")
        Finally
            lblCount.Text = "Results: " & dgvResults.RowCount
            mblnError = (intError > 0)
        End Try

    End Sub
    Private Sub Disconnect_Files_Folders()

        Dim strOutputMessages As String
        Dim strErrorMessages As String
        Dim intError As Integer

        For Each dgvrow As DataGridViewRow In dgvResults.SelectedRows
            Dim strID As String = dgvrow.Cells.Item(1).Value
            Dim strAccessedBy As String = dgvrow.Cells.Item(2).Value
            Dim strOpenFile As String = dgvrow.Cells.Item(6).Value
            Dim procOpenFiles As New Process
            With procOpenFiles
                .StartInfo.FileName = "C:\Windows\System32\openfiles.exe"
                .StartInfo.Arguments = "/disconnect /s " & mstrTargetServer & " /a " & strAccessedBy & " /op " & strOpenFile
                '.StartInfo.Arguments = "/disconnect /s " & mstrTargetServer & " /u sacrt-admin0\dgrewal /p " & strPwd & " /id " & strID
                .StartInfo.UseShellExecute = False
                .StartInfo.CreateNoWindow = True
                .StartInfo.RedirectStandardError = True
                .StartInfo.RedirectStandardOutput = True
            End With
            'Create the shell and execute the command
            Try
                procOpenFiles.Start()
                'If procOpenFiles.StandardOutput Is Nothing Then Exit Sub
                Dim strOutputLine As String
                Do
                    strOutputLine = procOpenFiles.StandardOutput.ReadLine
                    If strOutputLine IsNot Nothing Then
                        If Len(strOutputLine.Trim) > 0 Then strOutputMessages = strOutputMessages & strOutputLine & vbCrLf
                    End If
                Loop Until strOutputLine Is Nothing
                Dim strErrorLine As String
                Do
                    strErrorLine = procOpenFiles.StandardError.ReadLine
                    If strErrorLine IsNot Nothing Then
                        If Len(strErrorLine.Trim) > 0 Then strErrorMessages = strErrorMessages & strErrorLine & vbCrLf
                    End If
                Loop Until strErrorLine Is Nothing
            Catch ex As Exception
                intError = Err.Number
                MsgBox("Error while disconnecting files and folders.", vbCritical, "OpenFilesGUI")
            Finally
                mblnError = (intError > 0)
            End Try
        Next

        MsgBox(strOutputMessages & vbCrLf & strErrorMessages, vbInformation, "OpenFilesGUI")

        cmdDisplay_Click(Nothing, Nothing)

    End Sub

End Class
