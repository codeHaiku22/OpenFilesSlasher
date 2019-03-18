<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.grpbxTarget = New System.Windows.Forms.GroupBox()
        Me.txtServerName = New System.Windows.Forms.TextBox()
        Me.lblServerName = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.radRemote = New System.Windows.Forms.RadioButton()
        Me.radLocal = New System.Windows.Forms.RadioButton()
        Me.dgvResults = New System.Windows.Forms.DataGridView()
        Me.grpbxFilter = New System.Windows.Forms.GroupBox()
        Me.txtOpenFile = New System.Windows.Forms.TextBox()
        Me.txtAccessedBy = New System.Windows.Forms.TextBox()
        Me.chkbxOpenFile = New System.Windows.Forms.CheckBox()
        Me.radAnd = New System.Windows.Forms.RadioButton()
        Me.radOr = New System.Windows.Forms.RadioButton()
        Me.chkbxAccessedBy = New System.Windows.Forms.CheckBox()
        Me.lblCount = New System.Windows.Forms.Label()
        Me.cmdDisconnect = New System.Windows.Forms.Button()
        Me.cmdSelectNone = New System.Windows.Forms.Button()
        Me.cmdSelectAll = New System.Windows.Forms.Button()
        Me.cmdDisplay = New System.Windows.Forms.Button()
        Me.grpbxTargetInfo = New System.Windows.Forms.GroupBox()
        Me.lblPCManufacturerModel = New System.Windows.Forms.Label()
        Me.lblCPUManufacturerModel = New System.Windows.Forms.Label()
        Me.lblCPUCaption = New System.Windows.Forms.Label()
        Me.lblCPUProcessors = New System.Windows.Forms.Label()
        Me.lblOSDetails = New System.Windows.Forms.Label()
        Me.lblRAM = New System.Windows.Forms.Label()
        Me.lblNameIP = New System.Windows.Forms.Label()
        Me.grpbxTarget.SuspendLayout()
        CType(Me.dgvResults, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpbxFilter.SuspendLayout()
        Me.grpbxTargetInfo.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpbxTarget
        '
        Me.grpbxTarget.Controls.Add(Me.lblNameIP)
        Me.grpbxTarget.Controls.Add(Me.txtServerName)
        Me.grpbxTarget.Controls.Add(Me.lblServerName)
        Me.grpbxTarget.Controls.Add(Me.Label2)
        Me.grpbxTarget.Controls.Add(Me.radRemote)
        Me.grpbxTarget.Controls.Add(Me.radLocal)
        Me.grpbxTarget.Location = New System.Drawing.Point(16, 18)
        Me.grpbxTarget.Name = "grpbxTarget"
        Me.grpbxTarget.Size = New System.Drawing.Size(291, 101)
        Me.grpbxTarget.TabIndex = 0
        Me.grpbxTarget.TabStop = False
        Me.grpbxTarget.Text = "Target"
        '
        'txtServerName
        '
        Me.txtServerName.Location = New System.Drawing.Point(94, 57)
        Me.txtServerName.Name = "txtServerName"
        Me.txtServerName.Size = New System.Drawing.Size(178, 20)
        Me.txtServerName.TabIndex = 4
        '
        'lblServerName
        '
        Me.lblServerName.AutoSize = True
        Me.lblServerName.Location = New System.Drawing.Point(13, 59)
        Me.lblServerName.Name = "lblServerName"
        Me.lblServerName.Size = New System.Drawing.Size(75, 13)
        Me.lblServerName.TabIndex = 3
        Me.lblServerName.Text = "HostName/IP:"
        Me.lblServerName.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(54, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Type:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'radRemote
        '
        Me.radRemote.AutoSize = True
        Me.radRemote.Location = New System.Drawing.Point(94, 30)
        Me.radRemote.Name = "radRemote"
        Me.radRemote.Size = New System.Drawing.Size(96, 17)
        Me.radRemote.TabIndex = 1
        Me.radRemote.TabStop = True
        Me.radRemote.Text = "Remote Server"
        Me.radRemote.UseVisualStyleBackColor = True
        '
        'radLocal
        '
        Me.radLocal.AutoSize = True
        Me.radLocal.Location = New System.Drawing.Point(196, 30)
        Me.radLocal.Name = "radLocal"
        Me.radLocal.Size = New System.Drawing.Size(76, 17)
        Me.radLocal.TabIndex = 2
        Me.radLocal.TabStop = True
        Me.radLocal.Text = "Local Host"
        Me.radLocal.UseVisualStyleBackColor = True
        '
        'dgvResults
        '
        Me.dgvResults.AllowUserToAddRows = False
        Me.dgvResults.AllowUserToDeleteRows = False
        Me.dgvResults.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvResults.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvResults.Location = New System.Drawing.Point(16, 145)
        Me.dgvResults.Name = "dgvResults"
        Me.dgvResults.ReadOnly = True
        Me.dgvResults.Size = New System.Drawing.Size(1390, 635)
        Me.dgvResults.TabIndex = 4
        '
        'grpbxFilter
        '
        Me.grpbxFilter.Controls.Add(Me.txtOpenFile)
        Me.grpbxFilter.Controls.Add(Me.txtAccessedBy)
        Me.grpbxFilter.Controls.Add(Me.chkbxOpenFile)
        Me.grpbxFilter.Controls.Add(Me.radAnd)
        Me.grpbxFilter.Controls.Add(Me.radOr)
        Me.grpbxFilter.Controls.Add(Me.chkbxAccessedBy)
        Me.grpbxFilter.Location = New System.Drawing.Point(320, 18)
        Me.grpbxFilter.Name = "grpbxFilter"
        Me.grpbxFilter.Size = New System.Drawing.Size(392, 101)
        Me.grpbxFilter.TabIndex = 1
        Me.grpbxFilter.TabStop = False
        Me.grpbxFilter.Text = "Filter"
        '
        'txtOpenFile
        '
        Me.txtOpenFile.Location = New System.Drawing.Point(110, 55)
        Me.txtOpenFile.Name = "txtOpenFile"
        Me.txtOpenFile.Size = New System.Drawing.Size(178, 20)
        Me.txtOpenFile.TabIndex = 3
        '
        'txtAccessedBy
        '
        Me.txtAccessedBy.Location = New System.Drawing.Point(110, 30)
        Me.txtAccessedBy.Name = "txtAccessedBy"
        Me.txtAccessedBy.Size = New System.Drawing.Size(178, 20)
        Me.txtAccessedBy.TabIndex = 1
        '
        'chkbxOpenFile
        '
        Me.chkbxOpenFile.AutoSize = True
        Me.chkbxOpenFile.Location = New System.Drawing.Point(13, 57)
        Me.chkbxOpenFile.Name = "chkbxOpenFile"
        Me.chkbxOpenFile.Size = New System.Drawing.Size(74, 17)
        Me.chkbxOpenFile.TabIndex = 2
        Me.chkbxOpenFile.Text = "Open File:"
        Me.chkbxOpenFile.UseVisualStyleBackColor = True
        '
        'radAnd
        '
        Me.radAnd.AutoSize = True
        Me.radAnd.Location = New System.Drawing.Point(302, 45)
        Me.radAnd.Name = "radAnd"
        Me.radAnd.Size = New System.Drawing.Size(44, 17)
        Me.radAnd.TabIndex = 4
        Me.radAnd.TabStop = True
        Me.radAnd.Text = "And"
        Me.radAnd.UseVisualStyleBackColor = True
        '
        'radOr
        '
        Me.radOr.AutoSize = True
        Me.radOr.Location = New System.Drawing.Point(347, 45)
        Me.radOr.Name = "radOr"
        Me.radOr.Size = New System.Drawing.Size(36, 17)
        Me.radOr.TabIndex = 5
        Me.radOr.TabStop = True
        Me.radOr.Text = "Or"
        Me.radOr.UseVisualStyleBackColor = True
        '
        'chkbxAccessedBy
        '
        Me.chkbxAccessedBy.AutoSize = True
        Me.chkbxAccessedBy.Location = New System.Drawing.Point(13, 32)
        Me.chkbxAccessedBy.Name = "chkbxAccessedBy"
        Me.chkbxAccessedBy.Size = New System.Drawing.Size(91, 17)
        Me.chkbxAccessedBy.TabIndex = 0
        Me.chkbxAccessedBy.Text = "Accessed By:"
        Me.chkbxAccessedBy.UseVisualStyleBackColor = True
        '
        'lblCount
        '
        Me.lblCount.Location = New System.Drawing.Point(13, 129)
        Me.lblCount.Name = "lblCount"
        Me.lblCount.Size = New System.Drawing.Size(125, 13)
        Me.lblCount.TabIndex = 3
        Me.lblCount.Text = "lblCount"
        '
        'cmdDisconnect
        '
        Me.cmdDisconnect.Image = Global.OpenFilesSlasher.My.Resources.Resources.sickle
        Me.cmdDisconnect.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdDisconnect.Location = New System.Drawing.Point(1255, 796)
        Me.cmdDisconnect.Name = "cmdDisconnect"
        Me.cmdDisconnect.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.cmdDisconnect.Size = New System.Drawing.Size(151, 48)
        Me.cmdDisconnect.TabIndex = 7
        Me.cmdDisconnect.Text = "Slash"
        Me.cmdDisconnect.UseVisualStyleBackColor = True
        '
        'cmdSelectNone
        '
        Me.cmdSelectNone.Image = Global.OpenFilesSlasher.My.Resources.Resources.checkbox_unchecked
        Me.cmdSelectNone.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdSelectNone.Location = New System.Drawing.Point(188, 796)
        Me.cmdSelectNone.Name = "cmdSelectNone"
        Me.cmdSelectNone.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.cmdSelectNone.Size = New System.Drawing.Size(151, 48)
        Me.cmdSelectNone.TabIndex = 6
        Me.cmdSelectNone.Text = "Select None"
        Me.cmdSelectNone.UseVisualStyleBackColor = True
        '
        'cmdSelectAll
        '
        Me.cmdSelectAll.Image = Global.OpenFilesSlasher.My.Resources.Resources.checkbox
        Me.cmdSelectAll.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdSelectAll.Location = New System.Drawing.Point(16, 796)
        Me.cmdSelectAll.Name = "cmdSelectAll"
        Me.cmdSelectAll.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.cmdSelectAll.Size = New System.Drawing.Size(151, 48)
        Me.cmdSelectAll.TabIndex = 5
        Me.cmdSelectAll.Text = "Select All"
        Me.cmdSelectAll.UseVisualStyleBackColor = True
        '
        'cmdDisplay
        '
        Me.cmdDisplay.Image = Global.OpenFilesSlasher.My.Resources.Resources.magnifying_glass
        Me.cmdDisplay.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdDisplay.Location = New System.Drawing.Point(726, 44)
        Me.cmdDisplay.Name = "cmdDisplay"
        Me.cmdDisplay.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.cmdDisplay.Size = New System.Drawing.Size(151, 48)
        Me.cmdDisplay.TabIndex = 2
        Me.cmdDisplay.Text = "      Display Results"
        Me.cmdDisplay.UseVisualStyleBackColor = True
        '
        'grpbxTargetInfo
        '
        Me.grpbxTargetInfo.Controls.Add(Me.lblRAM)
        Me.grpbxTargetInfo.Controls.Add(Me.lblOSDetails)
        Me.grpbxTargetInfo.Controls.Add(Me.lblCPUProcessors)
        Me.grpbxTargetInfo.Controls.Add(Me.lblCPUCaption)
        Me.grpbxTargetInfo.Controls.Add(Me.lblCPUManufacturerModel)
        Me.grpbxTargetInfo.Controls.Add(Me.lblPCManufacturerModel)
        Me.grpbxTargetInfo.Location = New System.Drawing.Point(890, 18)
        Me.grpbxTargetInfo.Name = "grpbxTargetInfo"
        Me.grpbxTargetInfo.Size = New System.Drawing.Size(516, 101)
        Me.grpbxTargetInfo.TabIndex = 6
        Me.grpbxTargetInfo.TabStop = False
        Me.grpbxTargetInfo.Text = "Target Information"
        '
        'lblPCManufacturerModel
        '
        Me.lblPCManufacturerModel.AutoSize = True
        Me.lblPCManufacturerModel.Location = New System.Drawing.Point(13, 16)
        Me.lblPCManufacturerModel.Name = "lblPCManufacturerModel"
        Me.lblPCManufacturerModel.Size = New System.Drawing.Size(123, 13)
        Me.lblPCManufacturerModel.TabIndex = 0
        Me.lblPCManufacturerModel.Text = "lblPCManufacturerModel"
        '
        'lblCPUManufacturerModel
        '
        Me.lblCPUManufacturerModel.AutoSize = True
        Me.lblCPUManufacturerModel.Location = New System.Drawing.Point(13, 29)
        Me.lblCPUManufacturerModel.Name = "lblCPUManufacturerModel"
        Me.lblCPUManufacturerModel.Size = New System.Drawing.Size(131, 13)
        Me.lblCPUManufacturerModel.TabIndex = 0
        Me.lblCPUManufacturerModel.Text = "lblCPUManufacturerModel"
        '
        'lblCPUCaption
        '
        Me.lblCPUCaption.AutoSize = True
        Me.lblCPUCaption.Location = New System.Drawing.Point(13, 42)
        Me.lblCPUCaption.Name = "lblCPUCaption"
        Me.lblCPUCaption.Size = New System.Drawing.Size(75, 13)
        Me.lblCPUCaption.TabIndex = 1
        Me.lblCPUCaption.Text = "lblCPUCaption"
        '
        'lblCPUProcessors
        '
        Me.lblCPUProcessors.AutoSize = True
        Me.lblCPUProcessors.Location = New System.Drawing.Point(13, 55)
        Me.lblCPUProcessors.Name = "lblCPUProcessors"
        Me.lblCPUProcessors.Size = New System.Drawing.Size(91, 13)
        Me.lblCPUProcessors.TabIndex = 2
        Me.lblCPUProcessors.Text = "lblCPUProcessors"
        '
        'lblOSDetails
        '
        Me.lblOSDetails.AutoSize = True
        Me.lblOSDetails.Location = New System.Drawing.Point(13, 81)
        Me.lblOSDetails.Name = "lblOSDetails"
        Me.lblOSDetails.Size = New System.Drawing.Size(64, 13)
        Me.lblOSDetails.TabIndex = 3
        Me.lblOSDetails.Text = "lblOSDetails"
        '
        'lblRAM
        '
        Me.lblRAM.AutoSize = True
        Me.lblRAM.Location = New System.Drawing.Point(13, 68)
        Me.lblRAM.Name = "lblRAM"
        Me.lblRAM.Size = New System.Drawing.Size(41, 13)
        Me.lblRAM.TabIndex = 4
        Me.lblRAM.Text = "lblRAM"
        '
        'lblNameIP
        '
        Me.lblNameIP.AutoSize = True
        Me.lblNameIP.Location = New System.Drawing.Point(94, 80)
        Me.lblNameIP.Name = "lblNameIP"
        Me.lblNameIP.Size = New System.Drawing.Size(55, 13)
        Me.lblNameIP.TabIndex = 5
        Me.lblNameIP.Text = "lblNameIP"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1424, 861)
        Me.Controls.Add(Me.grpbxTargetInfo)
        Me.Controls.Add(Me.cmdDisconnect)
        Me.Controls.Add(Me.cmdSelectNone)
        Me.Controls.Add(Me.cmdSelectAll)
        Me.Controls.Add(Me.lblCount)
        Me.Controls.Add(Me.cmdDisplay)
        Me.Controls.Add(Me.grpbxFilter)
        Me.Controls.Add(Me.dgvResults)
        Me.Controls.Add(Me.grpbxTarget)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmMain"
        Me.Text = "Open Files Slasher"
        Me.grpbxTarget.ResumeLayout(False)
        Me.grpbxTarget.PerformLayout()
        CType(Me.dgvResults, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpbxFilter.ResumeLayout(False)
        Me.grpbxFilter.PerformLayout()
        Me.grpbxTargetInfo.ResumeLayout(False)
        Me.grpbxTargetInfo.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grpbxTarget As GroupBox
    Friend WithEvents radRemote As RadioButton
    Friend WithEvents radLocal As RadioButton
    Friend WithEvents Label2 As Label
    Friend WithEvents lblServerName As Label
    Friend WithEvents txtServerName As TextBox
    Friend WithEvents dgvResults As DataGridView
    Friend WithEvents grpbxFilter As GroupBox
    Friend WithEvents txtOpenFile As TextBox
    Friend WithEvents txtAccessedBy As TextBox
    Friend WithEvents chkbxOpenFile As CheckBox
    Friend WithEvents radOr As RadioButton
    Friend WithEvents chkbxAccessedBy As CheckBox
    Friend WithEvents radAnd As RadioButton
    Friend WithEvents cmdDisplay As Button
    Friend WithEvents lblCount As Label
    Friend WithEvents cmdSelectAll As Button
    Friend WithEvents cmdSelectNone As Button
    Friend WithEvents cmdDisconnect As Button
    Friend WithEvents grpbxTargetInfo As GroupBox
    Friend WithEvents lblRAM As Label
    Friend WithEvents lblOSDetails As Label
    Friend WithEvents lblCPUProcessors As Label
    Friend WithEvents lblCPUCaption As Label
    Friend WithEvents lblCPUManufacturerModel As Label
    Friend WithEvents lblPCManufacturerModel As Label
    Friend WithEvents lblNameIP As Label
End Class
