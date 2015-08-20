<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.MenuStrip = New System.Windows.Forms.MenuStrip
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.StatusStrip = New System.Windows.Forms.StatusStrip
        Me.TSSLUser = New System.Windows.Forms.ToolStripStatusLabel
        Me.ToolStrip = New System.Windows.Forms.ToolStrip
        Me.tsbLogin = New System.Windows.Forms.ToolStripButton
        Me.tsbLogout = New System.Windows.Forms.ToolStripButton
        Me.TLPMain = New System.Windows.Forms.TableLayoutPanel
        Me.pnlButtons = New System.Windows.Forms.Panel
        Me.btnExit = New System.Windows.Forms.Button
        Me.btnAdministration = New System.Windows.Forms.Button
        Me.btnRemoveHW = New System.Windows.Forms.Button
        Me.btnEditHW = New System.Windows.Forms.Button
        Me.btnViewHW = New System.Windows.Forms.Button
        Me.btnAddHW = New System.Windows.Forms.Button
        Me.tcMain = New System.Windows.Forms.TabControl
        Me.tabViewHW = New System.Windows.Forms.TabPage
        Me.btnViewClear = New System.Windows.Forms.Button
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.chkViewLease = New System.Windows.Forms.CheckBox
        Me.txtViewReplacedAsset = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.txtViewAsset = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.txtViewEndDate = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.txtViewStartDate = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtViewCompany = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtViewModel = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.gbUserInfoView = New System.Windows.Forms.GroupBox
        Me.txtViewLocation = New System.Windows.Forms.TextBox
        Me.Label45 = New System.Windows.Forms.Label
        Me.txtViewNotes = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtViewUser = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtViewSerialNumber = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.tabAddHW = New System.Windows.Forms.TabPage
        Me.btnAddCancel = New System.Windows.Forms.Button
        Me.btnAddSave = New System.Windows.Forms.Button
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.dtpAddEndDate = New System.Windows.Forms.DateTimePicker
        Me.dtpAddStartDate = New System.Windows.Forms.DateTimePicker
        Me.chkAddLease = New System.Windows.Forms.CheckBox
        Me.txtAddReplacedAsset = New System.Windows.Forms.TextBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.txtAddAsset = New System.Windows.Forms.TextBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.cboAddModel = New System.Windows.Forms.ComboBox
        Me.Label18 = New System.Windows.Forms.Label
        Me.txtAddCompany = New System.Windows.Forms.TextBox
        Me.Label19 = New System.Windows.Forms.Label
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.cboAddUser = New System.Windows.Forms.ComboBox
        Me.txtAddNotes = New System.Windows.Forms.TextBox
        Me.Label20 = New System.Windows.Forms.Label
        Me.Label21 = New System.Windows.Forms.Label
        Me.txtAddSerialNumber = New System.Windows.Forms.TextBox
        Me.Label22 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.tabEditHW = New System.Windows.Forms.TabPage
        Me.btnEditCancel = New System.Windows.Forms.Button
        Me.btnEditSave = New System.Windows.Forms.Button
        Me.GroupBox6 = New System.Windows.Forms.GroupBox
        Me.dtpEditEndDate = New System.Windows.Forms.DateTimePicker
        Me.dtpEditStartDate = New System.Windows.Forms.DateTimePicker
        Me.chkEditLease = New System.Windows.Forms.CheckBox
        Me.txtEditReplacedAsset = New System.Windows.Forms.TextBox
        Me.Label23 = New System.Windows.Forms.Label
        Me.txtEditAsset = New System.Windows.Forms.TextBox
        Me.Label24 = New System.Windows.Forms.Label
        Me.Label25 = New System.Windows.Forms.Label
        Me.Label26 = New System.Windows.Forms.Label
        Me.GroupBox7 = New System.Windows.Forms.GroupBox
        Me.cboEditModel = New System.Windows.Forms.ComboBox
        Me.Label27 = New System.Windows.Forms.Label
        Me.txtEditCompany = New System.Windows.Forms.TextBox
        Me.Label28 = New System.Windows.Forms.Label
        Me.GroupBox8 = New System.Windows.Forms.GroupBox
        Me.cboEditUser = New System.Windows.Forms.ComboBox
        Me.txtEditNotes = New System.Windows.Forms.TextBox
        Me.Label29 = New System.Windows.Forms.Label
        Me.Label30 = New System.Windows.Forms.Label
        Me.txtEditSerialNumber = New System.Windows.Forms.TextBox
        Me.Label31 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.tabRemoveHW = New System.Windows.Forms.TabPage
        Me.btnRemoveCancel = New System.Windows.Forms.Button
        Me.btnRemoveSave = New System.Windows.Forms.Button
        Me.GroupBox9 = New System.Windows.Forms.GroupBox
        Me.txtRemoveReplacedAsset = New System.Windows.Forms.TextBox
        Me.Label32 = New System.Windows.Forms.Label
        Me.txtRemoveAsset = New System.Windows.Forms.TextBox
        Me.Label33 = New System.Windows.Forms.Label
        Me.txtRemoveEndDate = New System.Windows.Forms.TextBox
        Me.Label34 = New System.Windows.Forms.Label
        Me.txtRemoveStartDate = New System.Windows.Forms.TextBox
        Me.Label35 = New System.Windows.Forms.Label
        Me.GroupBox10 = New System.Windows.Forms.GroupBox
        Me.txtRemoveModel = New System.Windows.Forms.TextBox
        Me.Label36 = New System.Windows.Forms.Label
        Me.txtRemoveCompany = New System.Windows.Forms.TextBox
        Me.Label37 = New System.Windows.Forms.Label
        Me.GroupBox11 = New System.Windows.Forms.GroupBox
        Me.txtRemoveUser = New System.Windows.Forms.TextBox
        Me.txtRemoveNotes = New System.Windows.Forms.TextBox
        Me.Label38 = New System.Windows.Forms.Label
        Me.Label39 = New System.Windows.Forms.Label
        Me.txtRemoveSerialNumber = New System.Windows.Forms.TextBox
        Me.Label40 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.tabAdministration = New System.Windows.Forms.TabPage
        Me.tcAdmin = New System.Windows.Forms.TabControl
        Me.tabUsers = New System.Windows.Forms.TabPage
        Me.Label60 = New System.Windows.Forms.Label
        Me.btnUsersCancel = New System.Windows.Forms.Button
        Me.btnUsersSave = New System.Windows.Forms.Button
        Me.btnUsersRemove = New System.Windows.Forms.Button
        Me.GroupBox14 = New System.Windows.Forms.GroupBox
        Me.cboUsersPurpose = New System.Windows.Forms.ComboBox
        Me.Label47 = New System.Windows.Forms.Label
        Me.GroupBox13 = New System.Windows.Forms.GroupBox
        Me.cboUsersLocation = New System.Windows.Forms.ComboBox
        Me.Label46 = New System.Windows.Forms.Label
        Me.btnUsersView = New System.Windows.Forms.Button
        Me.btnUsersEdit = New System.Windows.Forms.Button
        Me.btnUsersAdd = New System.Windows.Forms.Button
        Me.GroupBox12 = New System.Windows.Forms.GroupBox
        Me.cboUsersLogin = New System.Windows.Forms.ComboBox
        Me.Label41 = New System.Windows.Forms.Label
        Me.txtUsersFirst = New System.Windows.Forms.TextBox
        Me.Label42 = New System.Windows.Forms.Label
        Me.txtUsersPhone = New System.Windows.Forms.TextBox
        Me.Label43 = New System.Windows.Forms.Label
        Me.txtUsersLast = New System.Windows.Forms.TextBox
        Me.Label44 = New System.Windows.Forms.Label
        Me.tabLocations = New System.Windows.Forms.TabPage
        Me.Label61 = New System.Windows.Forms.Label
        Me.btnLocationsCancel = New System.Windows.Forms.Button
        Me.btnLocationsSave = New System.Windows.Forms.Button
        Me.btnLocationsAdd = New System.Windows.Forms.Button
        Me.btnLocationsView = New System.Windows.Forms.Button
        Me.btnLocationsRemove = New System.Windows.Forms.Button
        Me.GroupBox15 = New System.Windows.Forms.GroupBox
        Me.txtLocationsNotes = New System.Windows.Forms.TextBox
        Me.Label49 = New System.Windows.Forms.Label
        Me.cboLocationsLocation = New System.Windows.Forms.ComboBox
        Me.Label48 = New System.Windows.Forms.Label
        Me.tabManufacturers = New System.Windows.Forms.TabPage
        Me.Label62 = New System.Windows.Forms.Label
        Me.btnManufacturersCancel = New System.Windows.Forms.Button
        Me.btnManufacturersSave = New System.Windows.Forms.Button
        Me.btnManufacturersRemove = New System.Windows.Forms.Button
        Me.btnManufacturersView = New System.Windows.Forms.Button
        Me.btnManufacturersAdd = New System.Windows.Forms.Button
        Me.GroupBox17 = New System.Windows.Forms.GroupBox
        Me.cboManufacturersCompany = New System.Windows.Forms.ComboBox
        Me.txtManufacturersInstructions = New System.Windows.Forms.TextBox
        Me.Label50 = New System.Windows.Forms.Label
        Me.Label52 = New System.Windows.Forms.Label
        Me.txtManufactureresPhone = New System.Windows.Forms.TextBox
        Me.Label54 = New System.Windows.Forms.Label
        Me.txtManufacturersAddress = New System.Windows.Forms.TextBox
        Me.Label55 = New System.Windows.Forms.Label
        Me.tabModels = New System.Windows.Forms.TabPage
        Me.Label63 = New System.Windows.Forms.Label
        Me.btnModelsCancel = New System.Windows.Forms.Button
        Me.btnModelsSave = New System.Windows.Forms.Button
        Me.btnModelsRemove = New System.Windows.Forms.Button
        Me.btnModelsView = New System.Windows.Forms.Button
        Me.btnModelsAdd = New System.Windows.Forms.Button
        Me.GroupBox18 = New System.Windows.Forms.GroupBox
        Me.cboModelsName = New System.Windows.Forms.ComboBox
        Me.cboModelsManufacturer = New System.Windows.Forms.ComboBox
        Me.txtModelsDescription = New System.Windows.Forms.TextBox
        Me.Label56 = New System.Windows.Forms.Label
        Me.Label57 = New System.Windows.Forms.Label
        Me.Label58 = New System.Windows.Forms.Label
        Me.txtModelsPart = New System.Windows.Forms.TextBox
        Me.Label59 = New System.Windows.Forms.Label
        Me.tabAdmins = New System.Windows.Forms.TabPage
        Me.Label64 = New System.Windows.Forms.Label
        Me.btnAdminsCancel = New System.Windows.Forms.Button
        Me.btnAdminsSave = New System.Windows.Forms.Button
        Me.GroupBox16 = New System.Windows.Forms.GroupBox
        Me.cboAdminsUserName = New System.Windows.Forms.ComboBox
        Me.Label51 = New System.Windows.Forms.Label
        Me.Label53 = New System.Windows.Forms.Label
        Me.txtAdminsPassword = New System.Windows.Forms.TextBox
        Me.btnAdminsRemove = New System.Windows.Forms.Button
        Me.btnAdminsView = New System.Windows.Forms.Button
        Me.btnAdminsAdd = New System.Windows.Forms.Button
        Me.txtAddLocation = New System.Windows.Forms.TextBox
        Me.Label65 = New System.Windows.Forms.Label
        Me.txtEditLocation = New System.Windows.Forms.TextBox
        Me.Label66 = New System.Windows.Forms.Label
        Me.txtRemoveLocation = New System.Windows.Forms.TextBox
        Me.Label67 = New System.Windows.Forms.Label
        Me.chkRemoveLease = New System.Windows.Forms.CheckBox
        Me.MenuStrip.SuspendLayout()
        Me.StatusStrip.SuspendLayout()
        Me.ToolStrip.SuspendLayout()
        Me.TLPMain.SuspendLayout()
        Me.pnlButtons.SuspendLayout()
        Me.tcMain.SuspendLayout()
        Me.tabViewHW.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.gbUserInfoView.SuspendLayout()
        Me.tabAddHW.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.tabEditHW.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        Me.tabRemoveHW.SuspendLayout()
        Me.GroupBox9.SuspendLayout()
        Me.GroupBox10.SuspendLayout()
        Me.GroupBox11.SuspendLayout()
        Me.tabAdministration.SuspendLayout()
        Me.tcAdmin.SuspendLayout()
        Me.tabUsers.SuspendLayout()
        Me.GroupBox14.SuspendLayout()
        Me.GroupBox13.SuspendLayout()
        Me.GroupBox12.SuspendLayout()
        Me.tabLocations.SuspendLayout()
        Me.GroupBox15.SuspendLayout()
        Me.tabManufacturers.SuspendLayout()
        Me.GroupBox17.SuspendLayout()
        Me.tabModels.SuspendLayout()
        Me.GroupBox18.SuspendLayout()
        Me.tabAdmins.SuspendLayout()
        Me.GroupBox16.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip
        '
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(1016, 24)
        Me.MenuStrip.TabIndex = 0
        Me.MenuStrip.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Image = CType(resources.GetObject("ExitToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(92, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Image = CType(resources.GetObject("AboutToolStripMenuItem.Image"), System.Drawing.Image)
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'StatusStrip
        '
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TSSLUser})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 712)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Size = New System.Drawing.Size(1016, 22)
        Me.StatusStrip.TabIndex = 1
        Me.StatusStrip.Text = "StatusStrip1"
        '
        'TSSLUser
        '
        Me.TSSLUser.Name = "TSSLUser"
        Me.TSSLUser.Size = New System.Drawing.Size(0, 17)
        '
        'ToolStrip
        '
        Me.ToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbLogin, Me.tsbLogout})
        Me.ToolStrip.Location = New System.Drawing.Point(0, 24)
        Me.ToolStrip.Name = "ToolStrip"
        Me.ToolStrip.Size = New System.Drawing.Size(1016, 25)
        Me.ToolStrip.TabIndex = 2
        Me.ToolStrip.Text = "ToolStrip1"
        '
        'tsbLogin
        '
        Me.tsbLogin.Enabled = False
        Me.tsbLogin.Image = Global.HardwareBrowser.My.Resources.Resources.accept
        Me.tsbLogin.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbLogin.Name = "tsbLogin"
        Me.tsbLogin.Size = New System.Drawing.Size(57, 22)
        Me.tsbLogin.Text = "Login"
        '
        'tsbLogout
        '
        Me.tsbLogout.Image = Global.HardwareBrowser.My.Resources.Resources.reject
        Me.tsbLogout.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbLogout.Name = "tsbLogout"
        Me.tsbLogout.Size = New System.Drawing.Size(65, 22)
        Me.tsbLogout.Text = "Logout"
        '
        'TLPMain
        '
        Me.TLPMain.AutoSize = True
        Me.TLPMain.BackColor = System.Drawing.SystemColors.Control
        Me.TLPMain.ColumnCount = 2
        Me.TLPMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.91339!))
        Me.TLPMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 82.08662!))
        Me.TLPMain.Controls.Add(Me.pnlButtons, 0, 0)
        Me.TLPMain.Controls.Add(Me.tcMain, 1, 0)
        Me.TLPMain.Location = New System.Drawing.Point(0, 49)
        Me.TLPMain.Name = "TLPMain"
        Me.TLPMain.RowCount = 1
        Me.TLPMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TLPMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TLPMain.Size = New System.Drawing.Size(1016, 663)
        Me.TLPMain.TabIndex = 3
        '
        'pnlButtons
        '
        Me.pnlButtons.BackColor = System.Drawing.SystemColors.Control
        Me.pnlButtons.Controls.Add(Me.btnExit)
        Me.pnlButtons.Controls.Add(Me.btnAdministration)
        Me.pnlButtons.Controls.Add(Me.btnRemoveHW)
        Me.pnlButtons.Controls.Add(Me.btnEditHW)
        Me.pnlButtons.Controls.Add(Me.btnViewHW)
        Me.pnlButtons.Controls.Add(Me.btnAddHW)
        Me.pnlButtons.Location = New System.Drawing.Point(3, 3)
        Me.pnlButtons.Name = "pnlButtons"
        Me.pnlButtons.Size = New System.Drawing.Size(175, 657)
        Me.pnlButtons.TabIndex = 0
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"), System.Drawing.Image)
        Me.btnExit.Location = New System.Drawing.Point(26, 514)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(121, 80)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "Exit Application"
        Me.btnExit.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnAdministration
        '
        Me.btnAdministration.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdministration.Image = CType(resources.GetObject("btnAdministration.Image"), System.Drawing.Image)
        Me.btnAdministration.Location = New System.Drawing.Point(26, 414)
        Me.btnAdministration.Name = "btnAdministration"
        Me.btnAdministration.Size = New System.Drawing.Size(121, 80)
        Me.btnAdministration.TabIndex = 4
        Me.btnAdministration.Text = "Administration"
        Me.btnAdministration.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnAdministration.UseVisualStyleBackColor = True
        '
        'btnRemoveHW
        '
        Me.btnRemoveHW.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRemoveHW.Image = CType(resources.GetObject("btnRemoveHW.Image"), System.Drawing.Image)
        Me.btnRemoveHW.Location = New System.Drawing.Point(26, 314)
        Me.btnRemoveHW.Name = "btnRemoveHW"
        Me.btnRemoveHW.Size = New System.Drawing.Size(121, 80)
        Me.btnRemoveHW.TabIndex = 3
        Me.btnRemoveHW.Text = "Remove Hardware"
        Me.btnRemoveHW.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnRemoveHW.UseVisualStyleBackColor = True
        '
        'btnEditHW
        '
        Me.btnEditHW.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditHW.Image = CType(resources.GetObject("btnEditHW.Image"), System.Drawing.Image)
        Me.btnEditHW.Location = New System.Drawing.Point(26, 114)
        Me.btnEditHW.Name = "btnEditHW"
        Me.btnEditHW.Size = New System.Drawing.Size(121, 80)
        Me.btnEditHW.TabIndex = 1
        Me.btnEditHW.Text = "Edit Hardware"
        Me.btnEditHW.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnEditHW.UseVisualStyleBackColor = True
        '
        'btnViewHW
        '
        Me.btnViewHW.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnViewHW.Image = CType(resources.GetObject("btnViewHW.Image"), System.Drawing.Image)
        Me.btnViewHW.Location = New System.Drawing.Point(26, 14)
        Me.btnViewHW.Name = "btnViewHW"
        Me.btnViewHW.Size = New System.Drawing.Size(121, 80)
        Me.btnViewHW.TabIndex = 0
        Me.btnViewHW.Text = "View Hardware"
        Me.btnViewHW.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnViewHW.UseVisualStyleBackColor = True
        '
        'btnAddHW
        '
        Me.btnAddHW.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddHW.Image = CType(resources.GetObject("btnAddHW.Image"), System.Drawing.Image)
        Me.btnAddHW.Location = New System.Drawing.Point(26, 214)
        Me.btnAddHW.Name = "btnAddHW"
        Me.btnAddHW.Size = New System.Drawing.Size(121, 80)
        Me.btnAddHW.TabIndex = 2
        Me.btnAddHW.Text = "Add Hardware"
        Me.btnAddHW.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnAddHW.UseVisualStyleBackColor = True
        '
        'tcMain
        '
        Me.tcMain.Controls.Add(Me.tabViewHW)
        Me.tcMain.Controls.Add(Me.tabAddHW)
        Me.tcMain.Controls.Add(Me.tabEditHW)
        Me.tcMain.Controls.Add(Me.tabRemoveHW)
        Me.tcMain.Controls.Add(Me.tabAdministration)
        Me.tcMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tcMain.Location = New System.Drawing.Point(185, 3)
        Me.tcMain.Name = "tcMain"
        Me.tcMain.SelectedIndex = 0
        Me.tcMain.Size = New System.Drawing.Size(828, 657)
        Me.tcMain.TabIndex = 0
        Me.tcMain.TabStop = False
        '
        'tabViewHW
        '
        Me.tabViewHW.BackColor = System.Drawing.Color.Gainsboro
        Me.tabViewHW.Controls.Add(Me.btnViewClear)
        Me.tabViewHW.Controls.Add(Me.GroupBox2)
        Me.tabViewHW.Controls.Add(Me.GroupBox1)
        Me.tabViewHW.Controls.Add(Me.gbUserInfoView)
        Me.tabViewHW.Controls.Add(Me.Label2)
        Me.tabViewHW.Controls.Add(Me.txtViewSerialNumber)
        Me.tabViewHW.Controls.Add(Me.Label1)
        Me.tabViewHW.Location = New System.Drawing.Point(4, 22)
        Me.tabViewHW.Name = "tabViewHW"
        Me.tabViewHW.Padding = New System.Windows.Forms.Padding(3)
        Me.tabViewHW.Size = New System.Drawing.Size(820, 631)
        Me.tabViewHW.TabIndex = 1
        Me.tabViewHW.Text = "View Hardware"
        '
        'btnViewClear
        '
        Me.btnViewClear.Image = CType(resources.GetObject("btnViewClear.Image"), System.Drawing.Image)
        Me.btnViewClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnViewClear.Location = New System.Drawing.Point(144, 559)
        Me.btnViewClear.Name = "btnViewClear"
        Me.btnViewClear.Size = New System.Drawing.Size(160, 50)
        Me.btnViewClear.TabIndex = 4
        Me.btnViewClear.Text = "Clear"
        Me.btnViewClear.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.chkViewLease)
        Me.GroupBox2.Controls.Add(Me.txtViewReplacedAsset)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.txtViewAsset)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.txtViewEndDate)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.txtViewStartDate)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Location = New System.Drawing.Point(144, 389)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(535, 164)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Lease Info"
        '
        'chkViewLease
        '
        Me.chkViewLease.AutoCheck = False
        Me.chkViewLease.AutoSize = True
        Me.chkViewLease.Location = New System.Drawing.Point(107, 24)
        Me.chkViewLease.Name = "chkViewLease"
        Me.chkViewLease.Size = New System.Drawing.Size(77, 17)
        Me.chkViewLease.TabIndex = 0
        Me.chkViewLease.Text = "Has Lease"
        Me.chkViewLease.UseVisualStyleBackColor = True
        '
        'txtViewReplacedAsset
        '
        Me.txtViewReplacedAsset.BackColor = System.Drawing.SystemColors.Window
        Me.txtViewReplacedAsset.Location = New System.Drawing.Point(107, 125)
        Me.txtViewReplacedAsset.MaxLength = 50
        Me.txtViewReplacedAsset.Name = "txtViewReplacedAsset"
        Me.txtViewReplacedAsset.ReadOnly = True
        Me.txtViewReplacedAsset.Size = New System.Drawing.Size(134, 20)
        Me.txtViewReplacedAsset.TabIndex = 3
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(16, 128)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(85, 13)
        Me.Label13.TabIndex = 8
        Me.Label13.Text = "Replaced Asset:"
        '
        'txtViewAsset
        '
        Me.txtViewAsset.BackColor = System.Drawing.SystemColors.Window
        Me.txtViewAsset.Location = New System.Drawing.Point(107, 47)
        Me.txtViewAsset.MaxLength = 50
        Me.txtViewAsset.Name = "txtViewAsset"
        Me.txtViewAsset.ReadOnly = True
        Me.txtViewAsset.Size = New System.Drawing.Size(134, 20)
        Me.txtViewAsset.TabIndex = 0
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(43, 50)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(58, 13)
        Me.Label12.TabIndex = 6
        Me.Label12.Text = "Asset Tag:"
        '
        'txtViewEndDate
        '
        Me.txtViewEndDate.BackColor = System.Drawing.SystemColors.Window
        Me.txtViewEndDate.Location = New System.Drawing.Point(107, 99)
        Me.txtViewEndDate.MaxLength = 50
        Me.txtViewEndDate.Name = "txtViewEndDate"
        Me.txtViewEndDate.ReadOnly = True
        Me.txtViewEndDate.Size = New System.Drawing.Size(134, 20)
        Me.txtViewEndDate.TabIndex = 2
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(46, 102)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(55, 13)
        Me.Label10.TabIndex = 4
        Me.Label10.Text = "End Date:"
        '
        'txtViewStartDate
        '
        Me.txtViewStartDate.BackColor = System.Drawing.SystemColors.Window
        Me.txtViewStartDate.Location = New System.Drawing.Point(107, 73)
        Me.txtViewStartDate.MaxLength = 50
        Me.txtViewStartDate.Name = "txtViewStartDate"
        Me.txtViewStartDate.ReadOnly = True
        Me.txtViewStartDate.Size = New System.Drawing.Size(134, 20)
        Me.txtViewStartDate.TabIndex = 1
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(43, 76)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(58, 13)
        Me.Label11.TabIndex = 2
        Me.Label11.Text = "Start Date:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtViewCompany)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txtViewModel)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Location = New System.Drawing.Point(144, 278)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(535, 105)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Manufacturer Info"
        '
        'txtViewCompany
        '
        Me.txtViewCompany.BackColor = System.Drawing.SystemColors.Window
        Me.txtViewCompany.Location = New System.Drawing.Point(107, 55)
        Me.txtViewCompany.MaxLength = 50
        Me.txtViewCompany.Name = "txtViewCompany"
        Me.txtViewCompany.ReadOnly = True
        Me.txtViewCompany.Size = New System.Drawing.Size(134, 20)
        Me.txtViewCompany.TabIndex = 1
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(47, 58)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(54, 13)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "Company:"
        '
        'txtViewModel
        '
        Me.txtViewModel.BackColor = System.Drawing.SystemColors.Window
        Me.txtViewModel.Location = New System.Drawing.Point(107, 29)
        Me.txtViewModel.MaxLength = 50
        Me.txtViewModel.Name = "txtViewModel"
        Me.txtViewModel.ReadOnly = True
        Me.txtViewModel.Size = New System.Drawing.Size(134, 20)
        Me.txtViewModel.TabIndex = 0
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(62, 32)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(39, 13)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "Model:"
        '
        'gbUserInfoView
        '
        Me.gbUserInfoView.Controls.Add(Me.txtViewLocation)
        Me.gbUserInfoView.Controls.Add(Me.Label45)
        Me.gbUserInfoView.Controls.Add(Me.txtViewNotes)
        Me.gbUserInfoView.Controls.Add(Me.Label7)
        Me.gbUserInfoView.Controls.Add(Me.txtViewUser)
        Me.gbUserInfoView.Controls.Add(Me.Label6)
        Me.gbUserInfoView.Location = New System.Drawing.Point(144, 101)
        Me.gbUserInfoView.Name = "gbUserInfoView"
        Me.gbUserInfoView.Size = New System.Drawing.Size(535, 171)
        Me.gbUserInfoView.TabIndex = 1
        Me.gbUserInfoView.TabStop = False
        Me.gbUserInfoView.Text = "User Info"
        '
        'txtViewLocation
        '
        Me.txtViewLocation.BackColor = System.Drawing.SystemColors.Window
        Me.txtViewLocation.Location = New System.Drawing.Point(261, 32)
        Me.txtViewLocation.MaxLength = 50
        Me.txtViewLocation.Name = "txtViewLocation"
        Me.txtViewLocation.ReadOnly = True
        Me.txtViewLocation.Size = New System.Drawing.Size(134, 20)
        Me.txtViewLocation.TabIndex = 1
        '
        'Label45
        '
        Me.Label45.AutoSize = True
        Me.Label45.Location = New System.Drawing.Point(204, 35)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(51, 13)
        Me.Label45.TabIndex = 6
        Me.Label45.Text = "Location:"
        '
        'txtViewNotes
        '
        Me.txtViewNotes.BackColor = System.Drawing.SystemColors.Window
        Me.txtViewNotes.Location = New System.Drawing.Point(18, 80)
        Me.txtViewNotes.MaxLength = 500
        Me.txtViewNotes.Multiline = True
        Me.txtViewNotes.Name = "txtViewNotes"
        Me.txtViewNotes.ReadOnly = True
        Me.txtViewNotes.Size = New System.Drawing.Size(499, 72)
        Me.txtViewNotes.TabIndex = 2
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(15, 64)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(38, 13)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Notes:"
        '
        'txtViewUser
        '
        Me.txtViewUser.BackColor = System.Drawing.SystemColors.Window
        Me.txtViewUser.Location = New System.Drawing.Point(50, 32)
        Me.txtViewUser.MaxLength = 50
        Me.txtViewUser.Name = "txtViewUser"
        Me.txtViewUser.ReadOnly = True
        Me.txtViewUser.Size = New System.Drawing.Size(134, 20)
        Me.txtViewUser.TabIndex = 0
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 35)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(32, 13)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "User:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(324, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(173, 26)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "View Hardware"
        '
        'txtViewSerialNumber
        '
        Me.txtViewSerialNumber.Location = New System.Drawing.Point(223, 63)
        Me.txtViewSerialNumber.MaxLength = 50
        Me.txtViewSerialNumber.Name = "txtViewSerialNumber"
        Me.txtViewSerialNumber.Size = New System.Drawing.Size(134, 20)
        Me.txtViewSerialNumber.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(141, 66)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Serial Number:"
        '
        'tabAddHW
        '
        Me.tabAddHW.BackColor = System.Drawing.Color.Gainsboro
        Me.tabAddHW.Controls.Add(Me.btnAddCancel)
        Me.tabAddHW.Controls.Add(Me.btnAddSave)
        Me.tabAddHW.Controls.Add(Me.GroupBox3)
        Me.tabAddHW.Controls.Add(Me.GroupBox4)
        Me.tabAddHW.Controls.Add(Me.GroupBox5)
        Me.tabAddHW.Controls.Add(Me.txtAddSerialNumber)
        Me.tabAddHW.Controls.Add(Me.Label22)
        Me.tabAddHW.Controls.Add(Me.Label3)
        Me.tabAddHW.Location = New System.Drawing.Point(4, 22)
        Me.tabAddHW.Name = "tabAddHW"
        Me.tabAddHW.Padding = New System.Windows.Forms.Padding(3)
        Me.tabAddHW.Size = New System.Drawing.Size(820, 631)
        Me.tabAddHW.TabIndex = 0
        Me.tabAddHW.Text = "Add Hardware"
        '
        'btnAddCancel
        '
        Me.btnAddCancel.Image = CType(resources.GetObject("btnAddCancel.Image"), System.Drawing.Image)
        Me.btnAddCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAddCancel.Location = New System.Drawing.Point(310, 545)
        Me.btnAddCancel.Name = "btnAddCancel"
        Me.btnAddCancel.Size = New System.Drawing.Size(160, 50)
        Me.btnAddCancel.TabIndex = 5
        Me.btnAddCancel.Text = "Cancel"
        Me.btnAddCancel.UseVisualStyleBackColor = True
        '
        'btnAddSave
        '
        Me.btnAddSave.Image = CType(resources.GetObject("btnAddSave.Image"), System.Drawing.Image)
        Me.btnAddSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAddSave.Location = New System.Drawing.Point(144, 545)
        Me.btnAddSave.Name = "btnAddSave"
        Me.btnAddSave.Size = New System.Drawing.Size(160, 50)
        Me.btnAddSave.TabIndex = 4
        Me.btnAddSave.Text = "Save"
        Me.btnAddSave.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.dtpAddEndDate)
        Me.GroupBox3.Controls.Add(Me.dtpAddStartDate)
        Me.GroupBox3.Controls.Add(Me.chkAddLease)
        Me.GroupBox3.Controls.Add(Me.txtAddReplacedAsset)
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Controls.Add(Me.txtAddAsset)
        Me.GroupBox3.Controls.Add(Me.Label15)
        Me.GroupBox3.Controls.Add(Me.Label16)
        Me.GroupBox3.Controls.Add(Me.Label17)
        Me.GroupBox3.Location = New System.Drawing.Point(144, 389)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(535, 150)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Lease Info"
        '
        'dtpAddEndDate
        '
        Me.dtpAddEndDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpAddEndDate.Location = New System.Drawing.Point(107, 94)
        Me.dtpAddEndDate.Name = "dtpAddEndDate"
        Me.dtpAddEndDate.Size = New System.Drawing.Size(134, 20)
        Me.dtpAddEndDate.TabIndex = 2
        '
        'dtpAddStartDate
        '
        Me.dtpAddStartDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpAddStartDate.Location = New System.Drawing.Point(107, 68)
        Me.dtpAddStartDate.Name = "dtpAddStartDate"
        Me.dtpAddStartDate.Size = New System.Drawing.Size(134, 20)
        Me.dtpAddStartDate.TabIndex = 1
        '
        'chkAddLease
        '
        Me.chkAddLease.AutoSize = True
        Me.chkAddLease.Location = New System.Drawing.Point(107, 19)
        Me.chkAddLease.Name = "chkAddLease"
        Me.chkAddLease.Size = New System.Drawing.Size(77, 17)
        Me.chkAddLease.TabIndex = 0
        Me.chkAddLease.Text = "Has Lease"
        Me.chkAddLease.UseVisualStyleBackColor = True
        '
        'txtAddReplacedAsset
        '
        Me.txtAddReplacedAsset.Location = New System.Drawing.Point(107, 120)
        Me.txtAddReplacedAsset.MaxLength = 50
        Me.txtAddReplacedAsset.Name = "txtAddReplacedAsset"
        Me.txtAddReplacedAsset.Size = New System.Drawing.Size(134, 20)
        Me.txtAddReplacedAsset.TabIndex = 3
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(16, 123)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(85, 13)
        Me.Label14.TabIndex = 8
        Me.Label14.Text = "Replaced Asset:"
        '
        'txtAddAsset
        '
        Me.txtAddAsset.Location = New System.Drawing.Point(107, 42)
        Me.txtAddAsset.MaxLength = 50
        Me.txtAddAsset.Name = "txtAddAsset"
        Me.txtAddAsset.Size = New System.Drawing.Size(134, 20)
        Me.txtAddAsset.TabIndex = 0
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(43, 45)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(58, 13)
        Me.Label15.TabIndex = 6
        Me.Label15.Text = "Asset Tag:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(46, 97)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(55, 13)
        Me.Label16.TabIndex = 4
        Me.Label16.Text = "End Date:"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(43, 71)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(58, 13)
        Me.Label17.TabIndex = 2
        Me.Label17.Text = "Start Date:"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.cboAddModel)
        Me.GroupBox4.Controls.Add(Me.Label18)
        Me.GroupBox4.Controls.Add(Me.txtAddCompany)
        Me.GroupBox4.Controls.Add(Me.Label19)
        Me.GroupBox4.Location = New System.Drawing.Point(144, 278)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(535, 105)
        Me.GroupBox4.TabIndex = 2
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Manufacturer Info"
        '
        'cboAddModel
        '
        Me.cboAddModel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboAddModel.FormattingEnabled = True
        Me.cboAddModel.Location = New System.Drawing.Point(107, 28)
        Me.cboAddModel.Name = "cboAddModel"
        Me.cboAddModel.Size = New System.Drawing.Size(134, 21)
        Me.cboAddModel.TabIndex = 0
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(50, 58)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(51, 13)
        Me.Label18.TabIndex = 4
        Me.Label18.Text = "Company"
        '
        'txtAddCompany
        '
        Me.txtAddCompany.BackColor = System.Drawing.SystemColors.Window
        Me.txtAddCompany.Location = New System.Drawing.Point(107, 55)
        Me.txtAddCompany.MaxLength = 50
        Me.txtAddCompany.Name = "txtAddCompany"
        Me.txtAddCompany.ReadOnly = True
        Me.txtAddCompany.Size = New System.Drawing.Size(134, 20)
        Me.txtAddCompany.TabIndex = 1
        Me.txtAddCompany.TabStop = False
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(62, 31)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(39, 13)
        Me.Label19.TabIndex = 2
        Me.Label19.Text = "Model:"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.txtAddLocation)
        Me.GroupBox5.Controls.Add(Me.Label65)
        Me.GroupBox5.Controls.Add(Me.cboAddUser)
        Me.GroupBox5.Controls.Add(Me.txtAddNotes)
        Me.GroupBox5.Controls.Add(Me.Label20)
        Me.GroupBox5.Controls.Add(Me.Label21)
        Me.GroupBox5.Location = New System.Drawing.Point(144, 101)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(535, 171)
        Me.GroupBox5.TabIndex = 1
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "User Info"
        '
        'cboAddUser
        '
        Me.cboAddUser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboAddUser.FormattingEnabled = True
        Me.cboAddUser.Location = New System.Drawing.Point(46, 32)
        Me.cboAddUser.Name = "cboAddUser"
        Me.cboAddUser.Size = New System.Drawing.Size(134, 21)
        Me.cboAddUser.TabIndex = 0
        '
        'txtAddNotes
        '
        Me.txtAddNotes.Location = New System.Drawing.Point(18, 80)
        Me.txtAddNotes.MaxLength = 500
        Me.txtAddNotes.Multiline = True
        Me.txtAddNotes.Name = "txtAddNotes"
        Me.txtAddNotes.Size = New System.Drawing.Size(499, 72)
        Me.txtAddNotes.TabIndex = 1
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(15, 64)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(38, 13)
        Me.Label20.TabIndex = 4
        Me.Label20.Text = "Notes:"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(12, 35)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(32, 13)
        Me.Label21.TabIndex = 2
        Me.Label21.Text = "User:"
        '
        'txtAddSerialNumber
        '
        Me.txtAddSerialNumber.Location = New System.Drawing.Point(223, 63)
        Me.txtAddSerialNumber.MaxLength = 50
        Me.txtAddSerialNumber.Name = "txtAddSerialNumber"
        Me.txtAddSerialNumber.Size = New System.Drawing.Size(134, 20)
        Me.txtAddSerialNumber.TabIndex = 0
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(141, 66)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(76, 13)
        Me.Label22.TabIndex = 6
        Me.Label22.Text = "Serial Number:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(329, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(163, 26)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Add Hardware"
        '
        'tabEditHW
        '
        Me.tabEditHW.BackColor = System.Drawing.Color.Gainsboro
        Me.tabEditHW.Controls.Add(Me.btnEditCancel)
        Me.tabEditHW.Controls.Add(Me.btnEditSave)
        Me.tabEditHW.Controls.Add(Me.GroupBox6)
        Me.tabEditHW.Controls.Add(Me.GroupBox7)
        Me.tabEditHW.Controls.Add(Me.GroupBox8)
        Me.tabEditHW.Controls.Add(Me.txtEditSerialNumber)
        Me.tabEditHW.Controls.Add(Me.Label31)
        Me.tabEditHW.Controls.Add(Me.Label4)
        Me.tabEditHW.Location = New System.Drawing.Point(4, 22)
        Me.tabEditHW.Name = "tabEditHW"
        Me.tabEditHW.Size = New System.Drawing.Size(820, 631)
        Me.tabEditHW.TabIndex = 2
        Me.tabEditHW.Text = "Edit Hardware"
        '
        'btnEditCancel
        '
        Me.btnEditCancel.Image = CType(resources.GetObject("btnEditCancel.Image"), System.Drawing.Image)
        Me.btnEditCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEditCancel.Location = New System.Drawing.Point(310, 545)
        Me.btnEditCancel.Name = "btnEditCancel"
        Me.btnEditCancel.Size = New System.Drawing.Size(160, 50)
        Me.btnEditCancel.TabIndex = 5
        Me.btnEditCancel.Text = "Cancel"
        Me.btnEditCancel.UseVisualStyleBackColor = True
        '
        'btnEditSave
        '
        Me.btnEditSave.Image = CType(resources.GetObject("btnEditSave.Image"), System.Drawing.Image)
        Me.btnEditSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEditSave.Location = New System.Drawing.Point(144, 545)
        Me.btnEditSave.Name = "btnEditSave"
        Me.btnEditSave.Size = New System.Drawing.Size(160, 50)
        Me.btnEditSave.TabIndex = 4
        Me.btnEditSave.Text = "Save"
        Me.btnEditSave.UseVisualStyleBackColor = True
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.dtpEditEndDate)
        Me.GroupBox6.Controls.Add(Me.dtpEditStartDate)
        Me.GroupBox6.Controls.Add(Me.chkEditLease)
        Me.GroupBox6.Controls.Add(Me.txtEditReplacedAsset)
        Me.GroupBox6.Controls.Add(Me.Label23)
        Me.GroupBox6.Controls.Add(Me.txtEditAsset)
        Me.GroupBox6.Controls.Add(Me.Label24)
        Me.GroupBox6.Controls.Add(Me.Label25)
        Me.GroupBox6.Controls.Add(Me.Label26)
        Me.GroupBox6.Location = New System.Drawing.Point(144, 389)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(535, 150)
        Me.GroupBox6.TabIndex = 3
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Lease Info"
        '
        'dtpEditEndDate
        '
        Me.dtpEditEndDate.Enabled = False
        Me.dtpEditEndDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpEditEndDate.Location = New System.Drawing.Point(107, 94)
        Me.dtpEditEndDate.Name = "dtpEditEndDate"
        Me.dtpEditEndDate.Size = New System.Drawing.Size(134, 20)
        Me.dtpEditEndDate.TabIndex = 2
        '
        'dtpEditStartDate
        '
        Me.dtpEditStartDate.Enabled = False
        Me.dtpEditStartDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpEditStartDate.Location = New System.Drawing.Point(107, 68)
        Me.dtpEditStartDate.Name = "dtpEditStartDate"
        Me.dtpEditStartDate.Size = New System.Drawing.Size(134, 20)
        Me.dtpEditStartDate.TabIndex = 1
        '
        'chkEditLease
        '
        Me.chkEditLease.AutoSize = True
        Me.chkEditLease.Enabled = False
        Me.chkEditLease.Location = New System.Drawing.Point(107, 19)
        Me.chkEditLease.Name = "chkEditLease"
        Me.chkEditLease.Size = New System.Drawing.Size(77, 17)
        Me.chkEditLease.TabIndex = 0
        Me.chkEditLease.Text = "Has Lease"
        Me.chkEditLease.UseVisualStyleBackColor = True
        '
        'txtEditReplacedAsset
        '
        Me.txtEditReplacedAsset.BackColor = System.Drawing.SystemColors.Window
        Me.txtEditReplacedAsset.Enabled = False
        Me.txtEditReplacedAsset.Location = New System.Drawing.Point(107, 120)
        Me.txtEditReplacedAsset.MaxLength = 50
        Me.txtEditReplacedAsset.Name = "txtEditReplacedAsset"
        Me.txtEditReplacedAsset.Size = New System.Drawing.Size(134, 20)
        Me.txtEditReplacedAsset.TabIndex = 3
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(16, 123)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(85, 13)
        Me.Label23.TabIndex = 8
        Me.Label23.Text = "Replaced Asset:"
        '
        'txtEditAsset
        '
        Me.txtEditAsset.BackColor = System.Drawing.SystemColors.Window
        Me.txtEditAsset.Enabled = False
        Me.txtEditAsset.Location = New System.Drawing.Point(107, 42)
        Me.txtEditAsset.MaxLength = 50
        Me.txtEditAsset.Name = "txtEditAsset"
        Me.txtEditAsset.Size = New System.Drawing.Size(134, 20)
        Me.txtEditAsset.TabIndex = 0
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(43, 45)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(58, 13)
        Me.Label24.TabIndex = 6
        Me.Label24.Text = "Asset Tag:"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(46, 97)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(55, 13)
        Me.Label25.TabIndex = 4
        Me.Label25.Text = "End Date:"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(43, 71)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(58, 13)
        Me.Label26.TabIndex = 2
        Me.Label26.Text = "Start Date:"
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.cboEditModel)
        Me.GroupBox7.Controls.Add(Me.Label27)
        Me.GroupBox7.Controls.Add(Me.txtEditCompany)
        Me.GroupBox7.Controls.Add(Me.Label28)
        Me.GroupBox7.Location = New System.Drawing.Point(144, 278)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(535, 105)
        Me.GroupBox7.TabIndex = 2
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Manufacturer Info"
        '
        'cboEditModel
        '
        Me.cboEditModel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboEditModel.Enabled = False
        Me.cboEditModel.FormattingEnabled = True
        Me.cboEditModel.Location = New System.Drawing.Point(107, 28)
        Me.cboEditModel.Name = "cboEditModel"
        Me.cboEditModel.Size = New System.Drawing.Size(134, 21)
        Me.cboEditModel.TabIndex = 0
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(50, 58)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(51, 13)
        Me.Label27.TabIndex = 4
        Me.Label27.Text = "Company"
        '
        'txtEditCompany
        '
        Me.txtEditCompany.BackColor = System.Drawing.SystemColors.Window
        Me.txtEditCompany.Enabled = False
        Me.txtEditCompany.Location = New System.Drawing.Point(107, 55)
        Me.txtEditCompany.MaxLength = 50
        Me.txtEditCompany.Name = "txtEditCompany"
        Me.txtEditCompany.ReadOnly = True
        Me.txtEditCompany.Size = New System.Drawing.Size(134, 20)
        Me.txtEditCompany.TabIndex = 1
        Me.txtEditCompany.TabStop = False
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(62, 31)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(39, 13)
        Me.Label28.TabIndex = 2
        Me.Label28.Text = "Model:"
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.txtEditLocation)
        Me.GroupBox8.Controls.Add(Me.Label66)
        Me.GroupBox8.Controls.Add(Me.cboEditUser)
        Me.GroupBox8.Controls.Add(Me.txtEditNotes)
        Me.GroupBox8.Controls.Add(Me.Label29)
        Me.GroupBox8.Controls.Add(Me.Label30)
        Me.GroupBox8.Location = New System.Drawing.Point(144, 101)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(535, 171)
        Me.GroupBox8.TabIndex = 1
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "User Info"
        '
        'cboEditUser
        '
        Me.cboEditUser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboEditUser.Enabled = False
        Me.cboEditUser.FormattingEnabled = True
        Me.cboEditUser.Location = New System.Drawing.Point(46, 32)
        Me.cboEditUser.Name = "cboEditUser"
        Me.cboEditUser.Size = New System.Drawing.Size(134, 21)
        Me.cboEditUser.TabIndex = 0
        '
        'txtEditNotes
        '
        Me.txtEditNotes.BackColor = System.Drawing.SystemColors.Window
        Me.txtEditNotes.Enabled = False
        Me.txtEditNotes.Location = New System.Drawing.Point(18, 80)
        Me.txtEditNotes.MaxLength = 500
        Me.txtEditNotes.Multiline = True
        Me.txtEditNotes.Name = "txtEditNotes"
        Me.txtEditNotes.Size = New System.Drawing.Size(499, 72)
        Me.txtEditNotes.TabIndex = 1
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(15, 64)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(38, 13)
        Me.Label29.TabIndex = 4
        Me.Label29.Text = "Notes:"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(12, 35)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(32, 13)
        Me.Label30.TabIndex = 2
        Me.Label30.Text = "User:"
        '
        'txtEditSerialNumber
        '
        Me.txtEditSerialNumber.Location = New System.Drawing.Point(223, 63)
        Me.txtEditSerialNumber.MaxLength = 50
        Me.txtEditSerialNumber.Name = "txtEditSerialNumber"
        Me.txtEditSerialNumber.Size = New System.Drawing.Size(134, 20)
        Me.txtEditSerialNumber.TabIndex = 0
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Location = New System.Drawing.Point(141, 66)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(76, 13)
        Me.Label31.TabIndex = 13
        Me.Label31.Text = "Serial Number:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(329, 21)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(163, 26)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Edit Hardware"
        '
        'tabRemoveHW
        '
        Me.tabRemoveHW.BackColor = System.Drawing.Color.Gainsboro
        Me.tabRemoveHW.Controls.Add(Me.btnRemoveCancel)
        Me.tabRemoveHW.Controls.Add(Me.btnRemoveSave)
        Me.tabRemoveHW.Controls.Add(Me.GroupBox9)
        Me.tabRemoveHW.Controls.Add(Me.GroupBox10)
        Me.tabRemoveHW.Controls.Add(Me.GroupBox11)
        Me.tabRemoveHW.Controls.Add(Me.txtRemoveSerialNumber)
        Me.tabRemoveHW.Controls.Add(Me.Label40)
        Me.tabRemoveHW.Controls.Add(Me.Label5)
        Me.tabRemoveHW.Location = New System.Drawing.Point(4, 22)
        Me.tabRemoveHW.Name = "tabRemoveHW"
        Me.tabRemoveHW.Size = New System.Drawing.Size(820, 631)
        Me.tabRemoveHW.TabIndex = 3
        Me.tabRemoveHW.Text = "Remove Hardware"
        '
        'btnRemoveCancel
        '
        Me.btnRemoveCancel.Image = CType(resources.GetObject("btnRemoveCancel.Image"), System.Drawing.Image)
        Me.btnRemoveCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRemoveCancel.Location = New System.Drawing.Point(310, 545)
        Me.btnRemoveCancel.Name = "btnRemoveCancel"
        Me.btnRemoveCancel.Size = New System.Drawing.Size(160, 50)
        Me.btnRemoveCancel.TabIndex = 5
        Me.btnRemoveCancel.Text = "Cancel"
        Me.btnRemoveCancel.UseVisualStyleBackColor = True
        '
        'btnRemoveSave
        '
        Me.btnRemoveSave.Image = CType(resources.GetObject("btnRemoveSave.Image"), System.Drawing.Image)
        Me.btnRemoveSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRemoveSave.Location = New System.Drawing.Point(144, 545)
        Me.btnRemoveSave.Name = "btnRemoveSave"
        Me.btnRemoveSave.Size = New System.Drawing.Size(160, 50)
        Me.btnRemoveSave.TabIndex = 4
        Me.btnRemoveSave.Text = "Remove"
        Me.btnRemoveSave.UseVisualStyleBackColor = True
        '
        'GroupBox9
        '
        Me.GroupBox9.Controls.Add(Me.chkRemoveLease)
        Me.GroupBox9.Controls.Add(Me.txtRemoveReplacedAsset)
        Me.GroupBox9.Controls.Add(Me.Label32)
        Me.GroupBox9.Controls.Add(Me.txtRemoveAsset)
        Me.GroupBox9.Controls.Add(Me.Label33)
        Me.GroupBox9.Controls.Add(Me.txtRemoveEndDate)
        Me.GroupBox9.Controls.Add(Me.Label34)
        Me.GroupBox9.Controls.Add(Me.txtRemoveStartDate)
        Me.GroupBox9.Controls.Add(Me.Label35)
        Me.GroupBox9.Location = New System.Drawing.Point(144, 389)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Size = New System.Drawing.Size(535, 150)
        Me.GroupBox9.TabIndex = 3
        Me.GroupBox9.TabStop = False
        Me.GroupBox9.Text = "Lease Info"
        '
        'txtRemoveReplacedAsset
        '
        Me.txtRemoveReplacedAsset.BackColor = System.Drawing.SystemColors.Window
        Me.txtRemoveReplacedAsset.Location = New System.Drawing.Point(107, 118)
        Me.txtRemoveReplacedAsset.MaxLength = 50
        Me.txtRemoveReplacedAsset.Name = "txtRemoveReplacedAsset"
        Me.txtRemoveReplacedAsset.ReadOnly = True
        Me.txtRemoveReplacedAsset.Size = New System.Drawing.Size(134, 20)
        Me.txtRemoveReplacedAsset.TabIndex = 4
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Location = New System.Drawing.Point(16, 121)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(85, 13)
        Me.Label32.TabIndex = 8
        Me.Label32.Text = "Replaced Asset:"
        '
        'txtRemoveAsset
        '
        Me.txtRemoveAsset.BackColor = System.Drawing.SystemColors.Window
        Me.txtRemoveAsset.Location = New System.Drawing.Point(107, 40)
        Me.txtRemoveAsset.MaxLength = 50
        Me.txtRemoveAsset.Name = "txtRemoveAsset"
        Me.txtRemoveAsset.ReadOnly = True
        Me.txtRemoveAsset.Size = New System.Drawing.Size(134, 20)
        Me.txtRemoveAsset.TabIndex = 1
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Location = New System.Drawing.Point(43, 43)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(58, 13)
        Me.Label33.TabIndex = 6
        Me.Label33.Text = "Asset Tag:"
        '
        'txtRemoveEndDate
        '
        Me.txtRemoveEndDate.BackColor = System.Drawing.SystemColors.Window
        Me.txtRemoveEndDate.Location = New System.Drawing.Point(107, 92)
        Me.txtRemoveEndDate.MaxLength = 50
        Me.txtRemoveEndDate.Name = "txtRemoveEndDate"
        Me.txtRemoveEndDate.ReadOnly = True
        Me.txtRemoveEndDate.Size = New System.Drawing.Size(134, 20)
        Me.txtRemoveEndDate.TabIndex = 3
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Location = New System.Drawing.Point(46, 95)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(55, 13)
        Me.Label34.TabIndex = 4
        Me.Label34.Text = "End Date:"
        '
        'txtRemoveStartDate
        '
        Me.txtRemoveStartDate.BackColor = System.Drawing.SystemColors.Window
        Me.txtRemoveStartDate.Location = New System.Drawing.Point(107, 66)
        Me.txtRemoveStartDate.MaxLength = 50
        Me.txtRemoveStartDate.Name = "txtRemoveStartDate"
        Me.txtRemoveStartDate.ReadOnly = True
        Me.txtRemoveStartDate.Size = New System.Drawing.Size(134, 20)
        Me.txtRemoveStartDate.TabIndex = 2
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Location = New System.Drawing.Point(43, 69)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(58, 13)
        Me.Label35.TabIndex = 2
        Me.Label35.Text = "Start Date:"
        '
        'GroupBox10
        '
        Me.GroupBox10.Controls.Add(Me.txtRemoveModel)
        Me.GroupBox10.Controls.Add(Me.Label36)
        Me.GroupBox10.Controls.Add(Me.txtRemoveCompany)
        Me.GroupBox10.Controls.Add(Me.Label37)
        Me.GroupBox10.Location = New System.Drawing.Point(144, 278)
        Me.GroupBox10.Name = "GroupBox10"
        Me.GroupBox10.Size = New System.Drawing.Size(535, 105)
        Me.GroupBox10.TabIndex = 2
        Me.GroupBox10.TabStop = False
        Me.GroupBox10.Text = "Manufacturer Info"
        '
        'txtRemoveModel
        '
        Me.txtRemoveModel.BackColor = System.Drawing.SystemColors.Window
        Me.txtRemoveModel.Location = New System.Drawing.Point(107, 28)
        Me.txtRemoveModel.MaxLength = 50
        Me.txtRemoveModel.Name = "txtRemoveModel"
        Me.txtRemoveModel.ReadOnly = True
        Me.txtRemoveModel.Size = New System.Drawing.Size(134, 20)
        Me.txtRemoveModel.TabIndex = 0
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Location = New System.Drawing.Point(50, 58)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(51, 13)
        Me.Label36.TabIndex = 4
        Me.Label36.Text = "Company"
        '
        'txtRemoveCompany
        '
        Me.txtRemoveCompany.BackColor = System.Drawing.SystemColors.Window
        Me.txtRemoveCompany.Location = New System.Drawing.Point(107, 55)
        Me.txtRemoveCompany.MaxLength = 50
        Me.txtRemoveCompany.Name = "txtRemoveCompany"
        Me.txtRemoveCompany.ReadOnly = True
        Me.txtRemoveCompany.Size = New System.Drawing.Size(134, 20)
        Me.txtRemoveCompany.TabIndex = 1
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Location = New System.Drawing.Point(62, 31)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(39, 13)
        Me.Label37.TabIndex = 2
        Me.Label37.Text = "Model:"
        '
        'GroupBox11
        '
        Me.GroupBox11.Controls.Add(Me.txtRemoveLocation)
        Me.GroupBox11.Controls.Add(Me.Label67)
        Me.GroupBox11.Controls.Add(Me.txtRemoveUser)
        Me.GroupBox11.Controls.Add(Me.txtRemoveNotes)
        Me.GroupBox11.Controls.Add(Me.Label38)
        Me.GroupBox11.Controls.Add(Me.Label39)
        Me.GroupBox11.Location = New System.Drawing.Point(144, 101)
        Me.GroupBox11.Name = "GroupBox11"
        Me.GroupBox11.Size = New System.Drawing.Size(535, 171)
        Me.GroupBox11.TabIndex = 1
        Me.GroupBox11.TabStop = False
        Me.GroupBox11.Text = "User Info"
        '
        'txtRemoveUser
        '
        Me.txtRemoveUser.BackColor = System.Drawing.SystemColors.Window
        Me.txtRemoveUser.Location = New System.Drawing.Point(50, 32)
        Me.txtRemoveUser.MaxLength = 50
        Me.txtRemoveUser.Name = "txtRemoveUser"
        Me.txtRemoveUser.ReadOnly = True
        Me.txtRemoveUser.Size = New System.Drawing.Size(134, 20)
        Me.txtRemoveUser.TabIndex = 0
        '
        'txtRemoveNotes
        '
        Me.txtRemoveNotes.BackColor = System.Drawing.SystemColors.Window
        Me.txtRemoveNotes.Location = New System.Drawing.Point(18, 80)
        Me.txtRemoveNotes.MaxLength = 500
        Me.txtRemoveNotes.Multiline = True
        Me.txtRemoveNotes.Name = "txtRemoveNotes"
        Me.txtRemoveNotes.ReadOnly = True
        Me.txtRemoveNotes.Size = New System.Drawing.Size(499, 72)
        Me.txtRemoveNotes.TabIndex = 2
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Location = New System.Drawing.Point(15, 64)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(38, 13)
        Me.Label38.TabIndex = 4
        Me.Label38.Text = "Notes:"
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.Location = New System.Drawing.Point(12, 35)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(32, 13)
        Me.Label39.TabIndex = 2
        Me.Label39.Text = "User:"
        '
        'txtRemoveSerialNumber
        '
        Me.txtRemoveSerialNumber.Location = New System.Drawing.Point(223, 63)
        Me.txtRemoveSerialNumber.MaxLength = 50
        Me.txtRemoveSerialNumber.Name = "txtRemoveSerialNumber"
        Me.txtRemoveSerialNumber.Size = New System.Drawing.Size(134, 20)
        Me.txtRemoveSerialNumber.TabIndex = 0
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.Location = New System.Drawing.Point(141, 66)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(76, 13)
        Me.Label40.TabIndex = 20
        Me.Label40.Text = "Serial Number:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(306, 21)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(209, 26)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Remove Hardware"
        '
        'tabAdministration
        '
        Me.tabAdministration.BackColor = System.Drawing.Color.Gainsboro
        Me.tabAdministration.Controls.Add(Me.tcAdmin)
        Me.tabAdministration.Location = New System.Drawing.Point(4, 22)
        Me.tabAdministration.Name = "tabAdministration"
        Me.tabAdministration.Size = New System.Drawing.Size(820, 631)
        Me.tabAdministration.TabIndex = 4
        Me.tabAdministration.Text = "Administration"
        '
        'tcAdmin
        '
        Me.tcAdmin.Controls.Add(Me.tabUsers)
        Me.tcAdmin.Controls.Add(Me.tabLocations)
        Me.tcAdmin.Controls.Add(Me.tabManufacturers)
        Me.tcAdmin.Controls.Add(Me.tabModels)
        Me.tcAdmin.Controls.Add(Me.tabAdmins)
        Me.tcAdmin.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tcAdmin.Location = New System.Drawing.Point(0, 0)
        Me.tcAdmin.Name = "tcAdmin"
        Me.tcAdmin.SelectedIndex = 0
        Me.tcAdmin.Size = New System.Drawing.Size(820, 631)
        Me.tcAdmin.TabIndex = 0
        '
        'tabUsers
        '
        Me.tabUsers.BackColor = System.Drawing.Color.Gainsboro
        Me.tabUsers.Controls.Add(Me.Label60)
        Me.tabUsers.Controls.Add(Me.btnUsersCancel)
        Me.tabUsers.Controls.Add(Me.btnUsersSave)
        Me.tabUsers.Controls.Add(Me.btnUsersRemove)
        Me.tabUsers.Controls.Add(Me.GroupBox14)
        Me.tabUsers.Controls.Add(Me.GroupBox13)
        Me.tabUsers.Controls.Add(Me.btnUsersView)
        Me.tabUsers.Controls.Add(Me.btnUsersEdit)
        Me.tabUsers.Controls.Add(Me.btnUsersAdd)
        Me.tabUsers.Controls.Add(Me.GroupBox12)
        Me.tabUsers.Location = New System.Drawing.Point(4, 22)
        Me.tabUsers.Name = "tabUsers"
        Me.tabUsers.Padding = New System.Windows.Forms.Padding(3)
        Me.tabUsers.Size = New System.Drawing.Size(812, 605)
        Me.tabUsers.TabIndex = 0
        Me.tabUsers.Text = "Manage Users"
        '
        'Label60
        '
        Me.Label60.AutoSize = True
        Me.Label60.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label60.Location = New System.Drawing.Point(369, 24)
        Me.Label60.Name = "Label60"
        Me.Label60.Size = New System.Drawing.Size(74, 26)
        Me.Label60.TabIndex = 15
        Me.Label60.Text = "Users"
        '
        'btnUsersCancel
        '
        Me.btnUsersCancel.Image = CType(resources.GetObject("btnUsersCancel.Image"), System.Drawing.Image)
        Me.btnUsersCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUsersCancel.Location = New System.Drawing.Point(409, 460)
        Me.btnUsersCancel.Name = "btnUsersCancel"
        Me.btnUsersCancel.Size = New System.Drawing.Size(160, 50)
        Me.btnUsersCancel.TabIndex = 8
        Me.btnUsersCancel.Text = "Cancel"
        Me.btnUsersCancel.UseVisualStyleBackColor = True
        Me.btnUsersCancel.Visible = False
        '
        'btnUsersSave
        '
        Me.btnUsersSave.Image = CType(resources.GetObject("btnUsersSave.Image"), System.Drawing.Image)
        Me.btnUsersSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUsersSave.Location = New System.Drawing.Point(243, 460)
        Me.btnUsersSave.Name = "btnUsersSave"
        Me.btnUsersSave.Size = New System.Drawing.Size(160, 50)
        Me.btnUsersSave.TabIndex = 7
        Me.btnUsersSave.Text = "Save"
        Me.btnUsersSave.UseVisualStyleBackColor = True
        Me.btnUsersSave.Visible = False
        '
        'btnUsersRemove
        '
        Me.btnUsersRemove.Location = New System.Drawing.Point(498, 71)
        Me.btnUsersRemove.Name = "btnUsersRemove"
        Me.btnUsersRemove.Size = New System.Drawing.Size(83, 23)
        Me.btnUsersRemove.TabIndex = 3
        Me.btnUsersRemove.Text = "Remove User"
        Me.btnUsersRemove.UseVisualStyleBackColor = True
        '
        'GroupBox14
        '
        Me.GroupBox14.Controls.Add(Me.cboUsersPurpose)
        Me.GroupBox14.Controls.Add(Me.Label47)
        Me.GroupBox14.Location = New System.Drawing.Point(243, 371)
        Me.GroupBox14.Name = "GroupBox14"
        Me.GroupBox14.Size = New System.Drawing.Size(326, 83)
        Me.GroupBox14.TabIndex = 6
        Me.GroupBox14.TabStop = False
        Me.GroupBox14.Text = "Purpose"
        '
        'cboUsersPurpose
        '
        Me.cboUsersPurpose.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboUsersPurpose.Enabled = False
        Me.cboUsersPurpose.FormattingEnabled = True
        Me.cboUsersPurpose.Location = New System.Drawing.Point(115, 37)
        Me.cboUsersPurpose.Name = "cboUsersPurpose"
        Me.cboUsersPurpose.Size = New System.Drawing.Size(134, 21)
        Me.cboUsersPurpose.TabIndex = 0
        '
        'Label47
        '
        Me.Label47.AutoSize = True
        Me.Label47.Location = New System.Drawing.Point(60, 40)
        Me.Label47.Name = "Label47"
        Me.Label47.Size = New System.Drawing.Size(49, 13)
        Me.Label47.TabIndex = 8
        Me.Label47.Text = "Purpose:"
        '
        'GroupBox13
        '
        Me.GroupBox13.Controls.Add(Me.cboUsersLocation)
        Me.GroupBox13.Controls.Add(Me.Label46)
        Me.GroupBox13.Location = New System.Drawing.Point(243, 282)
        Me.GroupBox13.Name = "GroupBox13"
        Me.GroupBox13.Size = New System.Drawing.Size(326, 83)
        Me.GroupBox13.TabIndex = 5
        Me.GroupBox13.TabStop = False
        Me.GroupBox13.Text = "Location Info"
        '
        'cboUsersLocation
        '
        Me.cboUsersLocation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboUsersLocation.Enabled = False
        Me.cboUsersLocation.FormattingEnabled = True
        Me.cboUsersLocation.Location = New System.Drawing.Point(115, 34)
        Me.cboUsersLocation.Name = "cboUsersLocation"
        Me.cboUsersLocation.Size = New System.Drawing.Size(134, 21)
        Me.cboUsersLocation.TabIndex = 0
        '
        'Label46
        '
        Me.Label46.AutoSize = True
        Me.Label46.Location = New System.Drawing.Point(58, 37)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(51, 13)
        Me.Label46.TabIndex = 8
        Me.Label46.Text = "Location:"
        '
        'btnUsersView
        '
        Me.btnUsersView.Location = New System.Drawing.Point(231, 71)
        Me.btnUsersView.Name = "btnUsersView"
        Me.btnUsersView.Size = New System.Drawing.Size(83, 23)
        Me.btnUsersView.TabIndex = 0
        Me.btnUsersView.Text = "View User"
        Me.btnUsersView.UseVisualStyleBackColor = True
        '
        'btnUsersEdit
        '
        Me.btnUsersEdit.Location = New System.Drawing.Point(320, 71)
        Me.btnUsersEdit.Name = "btnUsersEdit"
        Me.btnUsersEdit.Size = New System.Drawing.Size(83, 23)
        Me.btnUsersEdit.TabIndex = 1
        Me.btnUsersEdit.Text = "Edit User"
        Me.btnUsersEdit.UseVisualStyleBackColor = True
        '
        'btnUsersAdd
        '
        Me.btnUsersAdd.Location = New System.Drawing.Point(409, 71)
        Me.btnUsersAdd.Name = "btnUsersAdd"
        Me.btnUsersAdd.Size = New System.Drawing.Size(83, 23)
        Me.btnUsersAdd.TabIndex = 2
        Me.btnUsersAdd.Text = "Add User"
        Me.btnUsersAdd.UseVisualStyleBackColor = True
        '
        'GroupBox12
        '
        Me.GroupBox12.Controls.Add(Me.cboUsersLogin)
        Me.GroupBox12.Controls.Add(Me.Label41)
        Me.GroupBox12.Controls.Add(Me.txtUsersFirst)
        Me.GroupBox12.Controls.Add(Me.Label42)
        Me.GroupBox12.Controls.Add(Me.txtUsersPhone)
        Me.GroupBox12.Controls.Add(Me.Label43)
        Me.GroupBox12.Controls.Add(Me.txtUsersLast)
        Me.GroupBox12.Controls.Add(Me.Label44)
        Me.GroupBox12.Location = New System.Drawing.Point(243, 100)
        Me.GroupBox12.Name = "GroupBox12"
        Me.GroupBox12.Size = New System.Drawing.Size(326, 176)
        Me.GroupBox12.TabIndex = 4
        Me.GroupBox12.TabStop = False
        Me.GroupBox12.Text = "User Info"
        '
        'cboUsersLogin
        '
        Me.cboUsersLogin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboUsersLogin.Enabled = False
        Me.cboUsersLogin.FormattingEnabled = True
        Me.cboUsersLogin.Location = New System.Drawing.Point(115, 37)
        Me.cboUsersLogin.MaxLength = 50
        Me.cboUsersLogin.Name = "cboUsersLogin"
        Me.cboUsersLogin.Size = New System.Drawing.Size(134, 21)
        Me.cboUsersLogin.TabIndex = 0
        '
        'Label41
        '
        Me.Label41.AutoSize = True
        Me.Label41.Location = New System.Drawing.Point(59, 40)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(50, 13)
        Me.Label41.TabIndex = 16
        Me.Label41.Text = "Login ID:"
        '
        'txtUsersFirst
        '
        Me.txtUsersFirst.Location = New System.Drawing.Point(115, 64)
        Me.txtUsersFirst.MaxLength = 50
        Me.txtUsersFirst.Name = "txtUsersFirst"
        Me.txtUsersFirst.ReadOnly = True
        Me.txtUsersFirst.Size = New System.Drawing.Size(134, 20)
        Me.txtUsersFirst.TabIndex = 1
        '
        'Label42
        '
        Me.Label42.AutoSize = True
        Me.Label42.Location = New System.Drawing.Point(49, 67)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(60, 13)
        Me.Label42.TabIndex = 14
        Me.Label42.Text = "First Name:"
        '
        'txtUsersPhone
        '
        Me.txtUsersPhone.Location = New System.Drawing.Point(115, 116)
        Me.txtUsersPhone.MaxLength = 20
        Me.txtUsersPhone.Name = "txtUsersPhone"
        Me.txtUsersPhone.ReadOnly = True
        Me.txtUsersPhone.Size = New System.Drawing.Size(134, 20)
        Me.txtUsersPhone.TabIndex = 3
        '
        'Label43
        '
        Me.Label43.AutoSize = True
        Me.Label43.Location = New System.Drawing.Point(28, 119)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(81, 13)
        Me.Label43.TabIndex = 12
        Me.Label43.Text = "Phone Number:"
        '
        'txtUsersLast
        '
        Me.txtUsersLast.Location = New System.Drawing.Point(115, 90)
        Me.txtUsersLast.MaxLength = 50
        Me.txtUsersLast.Name = "txtUsersLast"
        Me.txtUsersLast.ReadOnly = True
        Me.txtUsersLast.Size = New System.Drawing.Size(134, 20)
        Me.txtUsersLast.TabIndex = 2
        '
        'Label44
        '
        Me.Label44.AutoSize = True
        Me.Label44.Location = New System.Drawing.Point(48, 93)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(61, 13)
        Me.Label44.TabIndex = 10
        Me.Label44.Text = "Last Name:"
        '
        'tabLocations
        '
        Me.tabLocations.BackColor = System.Drawing.Color.Gainsboro
        Me.tabLocations.Controls.Add(Me.Label61)
        Me.tabLocations.Controls.Add(Me.btnLocationsCancel)
        Me.tabLocations.Controls.Add(Me.btnLocationsSave)
        Me.tabLocations.Controls.Add(Me.btnLocationsAdd)
        Me.tabLocations.Controls.Add(Me.btnLocationsView)
        Me.tabLocations.Controls.Add(Me.btnLocationsRemove)
        Me.tabLocations.Controls.Add(Me.GroupBox15)
        Me.tabLocations.Location = New System.Drawing.Point(4, 22)
        Me.tabLocations.Name = "tabLocations"
        Me.tabLocations.Padding = New System.Windows.Forms.Padding(3)
        Me.tabLocations.Size = New System.Drawing.Size(812, 605)
        Me.tabLocations.TabIndex = 1
        Me.tabLocations.Text = "Manage Locations"
        '
        'Label61
        '
        Me.Label61.AutoSize = True
        Me.Label61.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label61.Location = New System.Drawing.Point(349, 24)
        Me.Label61.Name = "Label61"
        Me.Label61.Size = New System.Drawing.Size(114, 26)
        Me.Label61.TabIndex = 17
        Me.Label61.Text = "Locations"
        '
        'btnLocationsCancel
        '
        Me.btnLocationsCancel.Image = CType(resources.GetObject("btnLocationsCancel.Image"), System.Drawing.Image)
        Me.btnLocationsCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLocationsCancel.Location = New System.Drawing.Point(296, 277)
        Me.btnLocationsCancel.Name = "btnLocationsCancel"
        Me.btnLocationsCancel.Size = New System.Drawing.Size(160, 50)
        Me.btnLocationsCancel.TabIndex = 5
        Me.btnLocationsCancel.Text = "Cancel"
        Me.btnLocationsCancel.UseVisualStyleBackColor = True
        Me.btnLocationsCancel.Visible = False
        '
        'btnLocationsSave
        '
        Me.btnLocationsSave.Image = CType(resources.GetObject("btnLocationsSave.Image"), System.Drawing.Image)
        Me.btnLocationsSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLocationsSave.Location = New System.Drawing.Point(130, 277)
        Me.btnLocationsSave.Name = "btnLocationsSave"
        Me.btnLocationsSave.Size = New System.Drawing.Size(160, 50)
        Me.btnLocationsSave.TabIndex = 4
        Me.btnLocationsSave.Text = "Save"
        Me.btnLocationsSave.UseVisualStyleBackColor = True
        Me.btnLocationsSave.Visible = False
        '
        'btnLocationsAdd
        '
        Me.btnLocationsAdd.Location = New System.Drawing.Point(354, 71)
        Me.btnLocationsAdd.Name = "btnLocationsAdd"
        Me.btnLocationsAdd.Size = New System.Drawing.Size(104, 23)
        Me.btnLocationsAdd.TabIndex = 1
        Me.btnLocationsAdd.Text = "Add Location"
        Me.btnLocationsAdd.UseVisualStyleBackColor = True
        '
        'btnLocationsView
        '
        Me.btnLocationsView.Location = New System.Drawing.Point(244, 71)
        Me.btnLocationsView.Name = "btnLocationsView"
        Me.btnLocationsView.Size = New System.Drawing.Size(104, 23)
        Me.btnLocationsView.TabIndex = 0
        Me.btnLocationsView.Text = "View Location"
        Me.btnLocationsView.UseVisualStyleBackColor = True
        '
        'btnLocationsRemove
        '
        Me.btnLocationsRemove.Location = New System.Drawing.Point(464, 71)
        Me.btnLocationsRemove.Name = "btnLocationsRemove"
        Me.btnLocationsRemove.Size = New System.Drawing.Size(104, 23)
        Me.btnLocationsRemove.TabIndex = 2
        Me.btnLocationsRemove.Text = "Remove Location"
        Me.btnLocationsRemove.UseVisualStyleBackColor = True
        '
        'GroupBox15
        '
        Me.GroupBox15.Controls.Add(Me.txtLocationsNotes)
        Me.GroupBox15.Controls.Add(Me.Label49)
        Me.GroupBox15.Controls.Add(Me.cboLocationsLocation)
        Me.GroupBox15.Controls.Add(Me.Label48)
        Me.GroupBox15.Location = New System.Drawing.Point(130, 100)
        Me.GroupBox15.Name = "GroupBox15"
        Me.GroupBox15.Size = New System.Drawing.Size(552, 171)
        Me.GroupBox15.TabIndex = 3
        Me.GroupBox15.TabStop = False
        Me.GroupBox15.Text = "Location Info"
        '
        'txtLocationsNotes
        '
        Me.txtLocationsNotes.Location = New System.Drawing.Point(32, 83)
        Me.txtLocationsNotes.MaxLength = 200
        Me.txtLocationsNotes.Multiline = True
        Me.txtLocationsNotes.Name = "txtLocationsNotes"
        Me.txtLocationsNotes.ReadOnly = True
        Me.txtLocationsNotes.Size = New System.Drawing.Size(499, 72)
        Me.txtLocationsNotes.TabIndex = 1
        '
        'Label49
        '
        Me.Label49.AutoSize = True
        Me.Label49.Location = New System.Drawing.Point(29, 67)
        Me.Label49.Name = "Label49"
        Me.Label49.Size = New System.Drawing.Size(38, 13)
        Me.Label49.TabIndex = 10
        Me.Label49.Text = "Notes:"
        '
        'cboLocationsLocation
        '
        Me.cboLocationsLocation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboLocationsLocation.Enabled = False
        Me.cboLocationsLocation.FormattingEnabled = True
        Me.cboLocationsLocation.Location = New System.Drawing.Point(86, 31)
        Me.cboLocationsLocation.MaxLength = 50
        Me.cboLocationsLocation.Name = "cboLocationsLocation"
        Me.cboLocationsLocation.Size = New System.Drawing.Size(134, 21)
        Me.cboLocationsLocation.TabIndex = 0
        '
        'Label48
        '
        Me.Label48.AutoSize = True
        Me.Label48.Location = New System.Drawing.Point(29, 34)
        Me.Label48.Name = "Label48"
        Me.Label48.Size = New System.Drawing.Size(51, 13)
        Me.Label48.TabIndex = 8
        Me.Label48.Text = "Location:"
        '
        'tabManufacturers
        '
        Me.tabManufacturers.BackColor = System.Drawing.Color.Gainsboro
        Me.tabManufacturers.Controls.Add(Me.Label62)
        Me.tabManufacturers.Controls.Add(Me.btnManufacturersCancel)
        Me.tabManufacturers.Controls.Add(Me.btnManufacturersSave)
        Me.tabManufacturers.Controls.Add(Me.btnManufacturersRemove)
        Me.tabManufacturers.Controls.Add(Me.btnManufacturersView)
        Me.tabManufacturers.Controls.Add(Me.btnManufacturersAdd)
        Me.tabManufacturers.Controls.Add(Me.GroupBox17)
        Me.tabManufacturers.Location = New System.Drawing.Point(4, 22)
        Me.tabManufacturers.Name = "tabManufacturers"
        Me.tabManufacturers.Size = New System.Drawing.Size(812, 605)
        Me.tabManufacturers.TabIndex = 3
        Me.tabManufacturers.Text = "Manage Manufacturer"
        '
        'Label62
        '
        Me.Label62.AutoSize = True
        Me.Label62.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label62.Location = New System.Drawing.Point(325, 24)
        Me.Label62.Name = "Label62"
        Me.Label62.Size = New System.Drawing.Size(163, 26)
        Me.Label62.TabIndex = 17
        Me.Label62.Text = "Manufacturers"
        '
        'btnManufacturersCancel
        '
        Me.btnManufacturersCancel.Image = CType(resources.GetObject("btnManufacturersCancel.Image"), System.Drawing.Image)
        Me.btnManufacturersCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnManufacturersCancel.Location = New System.Drawing.Point(212, 355)
        Me.btnManufacturersCancel.Name = "btnManufacturersCancel"
        Me.btnManufacturersCancel.Size = New System.Drawing.Size(160, 50)
        Me.btnManufacturersCancel.TabIndex = 5
        Me.btnManufacturersCancel.Text = "Cancel"
        Me.btnManufacturersCancel.UseVisualStyleBackColor = True
        Me.btnManufacturersCancel.Visible = False
        '
        'btnManufacturersSave
        '
        Me.btnManufacturersSave.Image = CType(resources.GetObject("btnManufacturersSave.Image"), System.Drawing.Image)
        Me.btnManufacturersSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnManufacturersSave.Location = New System.Drawing.Point(46, 355)
        Me.btnManufacturersSave.Name = "btnManufacturersSave"
        Me.btnManufacturersSave.Size = New System.Drawing.Size(160, 50)
        Me.btnManufacturersSave.TabIndex = 4
        Me.btnManufacturersSave.Text = "Save"
        Me.btnManufacturersSave.UseVisualStyleBackColor = True
        Me.btnManufacturersSave.Visible = False
        '
        'btnManufacturersRemove
        '
        Me.btnManufacturersRemove.Location = New System.Drawing.Point(476, 71)
        Me.btnManufacturersRemove.Name = "btnManufacturersRemove"
        Me.btnManufacturersRemove.Size = New System.Drawing.Size(128, 23)
        Me.btnManufacturersRemove.TabIndex = 2
        Me.btnManufacturersRemove.Text = "Remove Manufacturer"
        Me.btnManufacturersRemove.UseVisualStyleBackColor = True
        '
        'btnManufacturersView
        '
        Me.btnManufacturersView.Location = New System.Drawing.Point(208, 71)
        Me.btnManufacturersView.Name = "btnManufacturersView"
        Me.btnManufacturersView.Size = New System.Drawing.Size(128, 23)
        Me.btnManufacturersView.TabIndex = 0
        Me.btnManufacturersView.Text = "View Manufacturer"
        Me.btnManufacturersView.UseVisualStyleBackColor = True
        '
        'btnManufacturersAdd
        '
        Me.btnManufacturersAdd.Location = New System.Drawing.Point(342, 71)
        Me.btnManufacturersAdd.Name = "btnManufacturersAdd"
        Me.btnManufacturersAdd.Size = New System.Drawing.Size(128, 23)
        Me.btnManufacturersAdd.TabIndex = 1
        Me.btnManufacturersAdd.Text = "Add Manufacturer"
        Me.btnManufacturersAdd.UseVisualStyleBackColor = True
        '
        'GroupBox17
        '
        Me.GroupBox17.Controls.Add(Me.cboManufacturersCompany)
        Me.GroupBox17.Controls.Add(Me.txtManufacturersInstructions)
        Me.GroupBox17.Controls.Add(Me.Label50)
        Me.GroupBox17.Controls.Add(Me.Label52)
        Me.GroupBox17.Controls.Add(Me.txtManufactureresPhone)
        Me.GroupBox17.Controls.Add(Me.Label54)
        Me.GroupBox17.Controls.Add(Me.txtManufacturersAddress)
        Me.GroupBox17.Controls.Add(Me.Label55)
        Me.GroupBox17.Location = New System.Drawing.Point(46, 100)
        Me.GroupBox17.Name = "GroupBox17"
        Me.GroupBox17.Size = New System.Drawing.Size(720, 249)
        Me.GroupBox17.TabIndex = 3
        Me.GroupBox17.TabStop = False
        Me.GroupBox17.Text = "User Info"
        '
        'cboManufacturersCompany
        '
        Me.cboManufacturersCompany.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboManufacturersCompany.Enabled = False
        Me.cboManufacturersCompany.FormattingEnabled = True
        Me.cboManufacturersCompany.Location = New System.Drawing.Point(155, 34)
        Me.cboManufacturersCompany.MaxLength = 50
        Me.cboManufacturersCompany.Name = "cboManufacturersCompany"
        Me.cboManufacturersCompany.Size = New System.Drawing.Size(135, 21)
        Me.cboManufacturersCompany.TabIndex = 0
        '
        'txtManufacturersInstructions
        '
        Me.txtManufacturersInstructions.Location = New System.Drawing.Point(67, 135)
        Me.txtManufacturersInstructions.MaxLength = 500
        Me.txtManufacturersInstructions.Multiline = True
        Me.txtManufacturersInstructions.Name = "txtManufacturersInstructions"
        Me.txtManufacturersInstructions.ReadOnly = True
        Me.txtManufacturersInstructions.Size = New System.Drawing.Size(624, 85)
        Me.txtManufacturersInstructions.TabIndex = 3
        '
        'Label50
        '
        Me.Label50.AutoSize = True
        Me.Label50.Location = New System.Drawing.Point(64, 119)
        Me.Label50.Name = "Label50"
        Me.Label50.Size = New System.Drawing.Size(99, 13)
        Me.Label50.TabIndex = 16
        Me.Label50.Text = "Return Instructions:"
        '
        'Label52
        '
        Me.Label52.AutoSize = True
        Me.Label52.Location = New System.Drawing.Point(64, 38)
        Me.Label52.Name = "Label52"
        Me.Label52.Size = New System.Drawing.Size(85, 13)
        Me.Label52.TabIndex = 14
        Me.Label52.Text = "Company Name:"
        '
        'txtManufactureresPhone
        '
        Me.txtManufactureresPhone.Location = New System.Drawing.Point(155, 87)
        Me.txtManufactureresPhone.MaxLength = 50
        Me.txtManufactureresPhone.Name = "txtManufactureresPhone"
        Me.txtManufactureresPhone.ReadOnly = True
        Me.txtManufactureresPhone.Size = New System.Drawing.Size(134, 20)
        Me.txtManufactureresPhone.TabIndex = 2
        '
        'Label54
        '
        Me.Label54.AutoSize = True
        Me.Label54.Location = New System.Drawing.Point(68, 90)
        Me.Label54.Name = "Label54"
        Me.Label54.Size = New System.Drawing.Size(81, 13)
        Me.Label54.TabIndex = 12
        Me.Label54.Text = "Phone Number:"
        '
        'txtManufacturersAddress
        '
        Me.txtManufacturersAddress.Location = New System.Drawing.Point(155, 61)
        Me.txtManufacturersAddress.MaxLength = 100
        Me.txtManufacturersAddress.Name = "txtManufacturersAddress"
        Me.txtManufacturersAddress.ReadOnly = True
        Me.txtManufacturersAddress.Size = New System.Drawing.Size(134, 20)
        Me.txtManufacturersAddress.TabIndex = 1
        '
        'Label55
        '
        Me.Label55.AutoSize = True
        Me.Label55.Location = New System.Drawing.Point(66, 64)
        Me.Label55.Name = "Label55"
        Me.Label55.Size = New System.Drawing.Size(83, 13)
        Me.Label55.TabIndex = 10
        Me.Label55.Text = "Return Address:"
        '
        'tabModels
        '
        Me.tabModels.BackColor = System.Drawing.Color.Gainsboro
        Me.tabModels.Controls.Add(Me.Label63)
        Me.tabModels.Controls.Add(Me.btnModelsCancel)
        Me.tabModels.Controls.Add(Me.btnModelsSave)
        Me.tabModels.Controls.Add(Me.btnModelsRemove)
        Me.tabModels.Controls.Add(Me.btnModelsView)
        Me.tabModels.Controls.Add(Me.btnModelsAdd)
        Me.tabModels.Controls.Add(Me.GroupBox18)
        Me.tabModels.Location = New System.Drawing.Point(4, 22)
        Me.tabModels.Name = "tabModels"
        Me.tabModels.Size = New System.Drawing.Size(812, 605)
        Me.tabModels.TabIndex = 4
        Me.tabModels.Text = "Manage Models"
        '
        'Label63
        '
        Me.Label63.AutoSize = True
        Me.Label63.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label63.Location = New System.Drawing.Point(362, 24)
        Me.Label63.Name = "Label63"
        Me.Label63.Size = New System.Drawing.Size(88, 26)
        Me.Label63.TabIndex = 23
        Me.Label63.Text = "Models"
        '
        'btnModelsCancel
        '
        Me.btnModelsCancel.Image = CType(resources.GetObject("btnModelsCancel.Image"), System.Drawing.Image)
        Me.btnModelsCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnModelsCancel.Location = New System.Drawing.Point(235, 360)
        Me.btnModelsCancel.Name = "btnModelsCancel"
        Me.btnModelsCancel.Size = New System.Drawing.Size(160, 50)
        Me.btnModelsCancel.TabIndex = 5
        Me.btnModelsCancel.Text = "Cancel"
        Me.btnModelsCancel.UseVisualStyleBackColor = True
        Me.btnModelsCancel.Visible = False
        '
        'btnModelsSave
        '
        Me.btnModelsSave.Image = CType(resources.GetObject("btnModelsSave.Image"), System.Drawing.Image)
        Me.btnModelsSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnModelsSave.Location = New System.Drawing.Point(69, 360)
        Me.btnModelsSave.Name = "btnModelsSave"
        Me.btnModelsSave.Size = New System.Drawing.Size(160, 50)
        Me.btnModelsSave.TabIndex = 4
        Me.btnModelsSave.Text = "Save"
        Me.btnModelsSave.UseVisualStyleBackColor = True
        Me.btnModelsSave.Visible = False
        '
        'btnModelsRemove
        '
        Me.btnModelsRemove.Location = New System.Drawing.Point(476, 71)
        Me.btnModelsRemove.Name = "btnModelsRemove"
        Me.btnModelsRemove.Size = New System.Drawing.Size(128, 23)
        Me.btnModelsRemove.TabIndex = 2
        Me.btnModelsRemove.Text = "Remove Model"
        Me.btnModelsRemove.UseVisualStyleBackColor = True
        '
        'btnModelsView
        '
        Me.btnModelsView.Location = New System.Drawing.Point(208, 71)
        Me.btnModelsView.Name = "btnModelsView"
        Me.btnModelsView.Size = New System.Drawing.Size(128, 23)
        Me.btnModelsView.TabIndex = 0
        Me.btnModelsView.Text = "View Model"
        Me.btnModelsView.UseVisualStyleBackColor = True
        '
        'btnModelsAdd
        '
        Me.btnModelsAdd.Location = New System.Drawing.Point(342, 71)
        Me.btnModelsAdd.Name = "btnModelsAdd"
        Me.btnModelsAdd.Size = New System.Drawing.Size(128, 23)
        Me.btnModelsAdd.TabIndex = 1
        Me.btnModelsAdd.Text = "Add Model"
        Me.btnModelsAdd.UseVisualStyleBackColor = True
        '
        'GroupBox18
        '
        Me.GroupBox18.Controls.Add(Me.cboModelsName)
        Me.GroupBox18.Controls.Add(Me.cboModelsManufacturer)
        Me.GroupBox18.Controls.Add(Me.txtModelsDescription)
        Me.GroupBox18.Controls.Add(Me.Label56)
        Me.GroupBox18.Controls.Add(Me.Label57)
        Me.GroupBox18.Controls.Add(Me.Label58)
        Me.GroupBox18.Controls.Add(Me.txtModelsPart)
        Me.GroupBox18.Controls.Add(Me.Label59)
        Me.GroupBox18.Location = New System.Drawing.Point(69, 100)
        Me.GroupBox18.Name = "GroupBox18"
        Me.GroupBox18.Size = New System.Drawing.Size(674, 254)
        Me.GroupBox18.TabIndex = 3
        Me.GroupBox18.TabStop = False
        Me.GroupBox18.Text = "User Info"
        '
        'cboModelsName
        '
        Me.cboModelsName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboModelsName.Enabled = False
        Me.cboModelsName.FormattingEnabled = True
        Me.cboModelsName.Location = New System.Drawing.Point(117, 33)
        Me.cboModelsName.MaxLength = 50
        Me.cboModelsName.Name = "cboModelsName"
        Me.cboModelsName.Size = New System.Drawing.Size(134, 21)
        Me.cboModelsName.TabIndex = 0
        '
        'cboModelsManufacturer
        '
        Me.cboModelsManufacturer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboModelsManufacturer.Enabled = False
        Me.cboModelsManufacturer.FormattingEnabled = True
        Me.cboModelsManufacturer.Location = New System.Drawing.Point(117, 85)
        Me.cboModelsManufacturer.Name = "cboModelsManufacturer"
        Me.cboModelsManufacturer.Size = New System.Drawing.Size(134, 21)
        Me.cboModelsManufacturer.TabIndex = 2
        '
        'txtModelsDescription
        '
        Me.txtModelsDescription.Location = New System.Drawing.Point(41, 131)
        Me.txtModelsDescription.MaxLength = 500
        Me.txtModelsDescription.Multiline = True
        Me.txtModelsDescription.Name = "txtModelsDescription"
        Me.txtModelsDescription.ReadOnly = True
        Me.txtModelsDescription.Size = New System.Drawing.Size(592, 102)
        Me.txtModelsDescription.TabIndex = 3
        '
        'Label56
        '
        Me.Label56.AutoSize = True
        Me.Label56.Location = New System.Drawing.Point(38, 115)
        Me.Label56.Name = "Label56"
        Me.Label56.Size = New System.Drawing.Size(63, 13)
        Me.Label56.TabIndex = 16
        Me.Label56.Text = "Description:"
        '
        'Label57
        '
        Me.Label57.AutoSize = True
        Me.Label57.Location = New System.Drawing.Point(41, 36)
        Me.Label57.Name = "Label57"
        Me.Label57.Size = New System.Drawing.Size(70, 13)
        Me.Label57.TabIndex = 14
        Me.Label57.Text = "Model Name:"
        '
        'Label58
        '
        Me.Label58.AutoSize = True
        Me.Label58.Location = New System.Drawing.Point(38, 88)
        Me.Label58.Name = "Label58"
        Me.Label58.Size = New System.Drawing.Size(73, 13)
        Me.Label58.TabIndex = 12
        Me.Label58.Text = "Manufacturer:"
        '
        'txtModelsPart
        '
        Me.txtModelsPart.Location = New System.Drawing.Point(117, 59)
        Me.txtModelsPart.MaxLength = 50
        Me.txtModelsPart.Name = "txtModelsPart"
        Me.txtModelsPart.ReadOnly = True
        Me.txtModelsPart.Size = New System.Drawing.Size(134, 20)
        Me.txtModelsPart.TabIndex = 1
        '
        'Label59
        '
        Me.Label59.AutoSize = True
        Me.Label59.Location = New System.Drawing.Point(42, 62)
        Me.Label59.Name = "Label59"
        Me.Label59.Size = New System.Drawing.Size(69, 13)
        Me.Label59.TabIndex = 10
        Me.Label59.Text = "Part Number:"
        '
        'tabAdmins
        '
        Me.tabAdmins.BackColor = System.Drawing.Color.Gainsboro
        Me.tabAdmins.Controls.Add(Me.Label64)
        Me.tabAdmins.Controls.Add(Me.btnAdminsCancel)
        Me.tabAdmins.Controls.Add(Me.btnAdminsSave)
        Me.tabAdmins.Controls.Add(Me.GroupBox16)
        Me.tabAdmins.Controls.Add(Me.btnAdminsRemove)
        Me.tabAdmins.Controls.Add(Me.btnAdminsView)
        Me.tabAdmins.Controls.Add(Me.btnAdminsAdd)
        Me.tabAdmins.Location = New System.Drawing.Point(4, 22)
        Me.tabAdmins.Name = "tabAdmins"
        Me.tabAdmins.Size = New System.Drawing.Size(812, 605)
        Me.tabAdmins.TabIndex = 2
        Me.tabAdmins.Text = "Manage Admins"
        '
        'Label64
        '
        Me.Label64.AutoSize = True
        Me.Label64.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label64.Location = New System.Drawing.Point(360, 24)
        Me.Label64.Name = "Label64"
        Me.Label64.Size = New System.Drawing.Size(92, 26)
        Me.Label64.TabIndex = 19
        Me.Label64.Text = "Admins"
        '
        'btnAdminsCancel
        '
        Me.btnAdminsCancel.Image = CType(resources.GetObject("btnAdminsCancel.Image"), System.Drawing.Image)
        Me.btnAdminsCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAdminsCancel.Location = New System.Drawing.Point(409, 239)
        Me.btnAdminsCancel.Name = "btnAdminsCancel"
        Me.btnAdminsCancel.Size = New System.Drawing.Size(160, 50)
        Me.btnAdminsCancel.TabIndex = 5
        Me.btnAdminsCancel.Text = "Cancel"
        Me.btnAdminsCancel.UseVisualStyleBackColor = True
        Me.btnAdminsCancel.Visible = False
        '
        'btnAdminsSave
        '
        Me.btnAdminsSave.Image = CType(resources.GetObject("btnAdminsSave.Image"), System.Drawing.Image)
        Me.btnAdminsSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAdminsSave.Location = New System.Drawing.Point(243, 239)
        Me.btnAdminsSave.Name = "btnAdminsSave"
        Me.btnAdminsSave.Size = New System.Drawing.Size(160, 50)
        Me.btnAdminsSave.TabIndex = 4
        Me.btnAdminsSave.Text = "Save"
        Me.btnAdminsSave.UseVisualStyleBackColor = True
        Me.btnAdminsSave.Visible = False
        '
        'GroupBox16
        '
        Me.GroupBox16.Controls.Add(Me.cboAdminsUserName)
        Me.GroupBox16.Controls.Add(Me.Label51)
        Me.GroupBox16.Controls.Add(Me.Label53)
        Me.GroupBox16.Controls.Add(Me.txtAdminsPassword)
        Me.GroupBox16.Location = New System.Drawing.Point(243, 100)
        Me.GroupBox16.Name = "GroupBox16"
        Me.GroupBox16.Size = New System.Drawing.Size(326, 133)
        Me.GroupBox16.TabIndex = 3
        Me.GroupBox16.TabStop = False
        Me.GroupBox16.Text = "Admin Info"
        '
        'cboAdminsUserName
        '
        Me.cboAdminsUserName.Enabled = False
        Me.cboAdminsUserName.FormattingEnabled = True
        Me.cboAdminsUserName.Location = New System.Drawing.Point(109, 42)
        Me.cboAdminsUserName.MaxLength = 50
        Me.cboAdminsUserName.Name = "cboAdminsUserName"
        Me.cboAdminsUserName.Size = New System.Drawing.Size(161, 21)
        Me.cboAdminsUserName.TabIndex = 0
        '
        'Label51
        '
        Me.Label51.AutoSize = True
        Me.Label51.Location = New System.Drawing.Point(45, 45)
        Me.Label51.Name = "Label51"
        Me.Label51.Size = New System.Drawing.Size(58, 13)
        Me.Label51.TabIndex = 14
        Me.Label51.Text = "Username:"
        '
        'Label53
        '
        Me.Label53.AutoSize = True
        Me.Label53.Location = New System.Drawing.Point(47, 71)
        Me.Label53.Name = "Label53"
        Me.Label53.Size = New System.Drawing.Size(56, 13)
        Me.Label53.TabIndex = 10
        Me.Label53.Text = "Password:"
        '
        'txtAdminsPassword
        '
        Me.txtAdminsPassword.BackColor = System.Drawing.SystemColors.Window
        Me.txtAdminsPassword.Location = New System.Drawing.Point(109, 68)
        Me.txtAdminsPassword.MaxLength = 50
        Me.txtAdminsPassword.Name = "txtAdminsPassword"
        Me.txtAdminsPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtAdminsPassword.ReadOnly = True
        Me.txtAdminsPassword.Size = New System.Drawing.Size(161, 20)
        Me.txtAdminsPassword.TabIndex = 1
        '
        'btnAdminsRemove
        '
        Me.btnAdminsRemove.Location = New System.Drawing.Point(458, 71)
        Me.btnAdminsRemove.Name = "btnAdminsRemove"
        Me.btnAdminsRemove.Size = New System.Drawing.Size(92, 23)
        Me.btnAdminsRemove.TabIndex = 2
        Me.btnAdminsRemove.Text = "Remove Admin"
        Me.btnAdminsRemove.UseVisualStyleBackColor = True
        '
        'btnAdminsView
        '
        Me.btnAdminsView.Location = New System.Drawing.Point(262, 71)
        Me.btnAdminsView.Name = "btnAdminsView"
        Me.btnAdminsView.Size = New System.Drawing.Size(92, 23)
        Me.btnAdminsView.TabIndex = 0
        Me.btnAdminsView.Text = "View Admin"
        Me.btnAdminsView.UseVisualStyleBackColor = True
        '
        'btnAdminsAdd
        '
        Me.btnAdminsAdd.Location = New System.Drawing.Point(360, 71)
        Me.btnAdminsAdd.Name = "btnAdminsAdd"
        Me.btnAdminsAdd.Size = New System.Drawing.Size(92, 23)
        Me.btnAdminsAdd.TabIndex = 1
        Me.btnAdminsAdd.Text = "Add Admin"
        Me.btnAdminsAdd.UseVisualStyleBackColor = True
        '
        'txtAddLocation
        '
        Me.txtAddLocation.BackColor = System.Drawing.SystemColors.Window
        Me.txtAddLocation.Location = New System.Drawing.Point(279, 33)
        Me.txtAddLocation.MaxLength = 50
        Me.txtAddLocation.Name = "txtAddLocation"
        Me.txtAddLocation.ReadOnly = True
        Me.txtAddLocation.Size = New System.Drawing.Size(134, 20)
        Me.txtAddLocation.TabIndex = 7
        Me.txtAddLocation.TabStop = False
        '
        'Label65
        '
        Me.Label65.AutoSize = True
        Me.Label65.Location = New System.Drawing.Point(222, 36)
        Me.Label65.Name = "Label65"
        Me.Label65.Size = New System.Drawing.Size(51, 13)
        Me.Label65.TabIndex = 8
        Me.Label65.Text = "Location:"
        '
        'txtEditLocation
        '
        Me.txtEditLocation.BackColor = System.Drawing.SystemColors.Window
        Me.txtEditLocation.Enabled = False
        Me.txtEditLocation.Location = New System.Drawing.Point(279, 33)
        Me.txtEditLocation.MaxLength = 50
        Me.txtEditLocation.Name = "txtEditLocation"
        Me.txtEditLocation.ReadOnly = True
        Me.txtEditLocation.Size = New System.Drawing.Size(134, 20)
        Me.txtEditLocation.TabIndex = 14
        Me.txtEditLocation.TabStop = False
        '
        'Label66
        '
        Me.Label66.AutoSize = True
        Me.Label66.Location = New System.Drawing.Point(222, 36)
        Me.Label66.Name = "Label66"
        Me.Label66.Size = New System.Drawing.Size(51, 13)
        Me.Label66.TabIndex = 15
        Me.Label66.Text = "Location:"
        '
        'txtRemoveLocation
        '
        Me.txtRemoveLocation.BackColor = System.Drawing.SystemColors.Window
        Me.txtRemoveLocation.Location = New System.Drawing.Point(279, 33)
        Me.txtRemoveLocation.MaxLength = 50
        Me.txtRemoveLocation.Name = "txtRemoveLocation"
        Me.txtRemoveLocation.ReadOnly = True
        Me.txtRemoveLocation.Size = New System.Drawing.Size(134, 20)
        Me.txtRemoveLocation.TabIndex = 1
        '
        'Label67
        '
        Me.Label67.AutoSize = True
        Me.Label67.Location = New System.Drawing.Point(222, 36)
        Me.Label67.Name = "Label67"
        Me.Label67.Size = New System.Drawing.Size(51, 13)
        Me.Label67.TabIndex = 8
        Me.Label67.Text = "Location:"
        '
        'chkRemoveLease
        '
        Me.chkRemoveLease.AutoCheck = False
        Me.chkRemoveLease.AutoSize = True
        Me.chkRemoveLease.Location = New System.Drawing.Point(107, 17)
        Me.chkRemoveLease.Name = "chkRemoveLease"
        Me.chkRemoveLease.Size = New System.Drawing.Size(77, 17)
        Me.chkRemoveLease.TabIndex = 0
        Me.chkRemoveLease.Text = "Has Lease"
        Me.chkRemoveLease.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1016, 734)
        Me.Controls.Add(Me.TLPMain)
        Me.Controls.Add(Me.ToolStrip)
        Me.Controls.Add(Me.StatusStrip)
        Me.Controls.Add(Me.MenuStrip)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip
        Me.MinimumSize = New System.Drawing.Size(1024, 768)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Hardware Manager"
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.ToolStrip.ResumeLayout(False)
        Me.ToolStrip.PerformLayout()
        Me.TLPMain.ResumeLayout(False)
        Me.pnlButtons.ResumeLayout(False)
        Me.tcMain.ResumeLayout(False)
        Me.tabViewHW.ResumeLayout(False)
        Me.tabViewHW.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.gbUserInfoView.ResumeLayout(False)
        Me.gbUserInfoView.PerformLayout()
        Me.tabAddHW.ResumeLayout(False)
        Me.tabAddHW.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.tabEditHW.ResumeLayout(False)
        Me.tabEditHW.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout()
        Me.tabRemoveHW.ResumeLayout(False)
        Me.tabRemoveHW.PerformLayout()
        Me.GroupBox9.ResumeLayout(False)
        Me.GroupBox9.PerformLayout()
        Me.GroupBox10.ResumeLayout(False)
        Me.GroupBox10.PerformLayout()
        Me.GroupBox11.ResumeLayout(False)
        Me.GroupBox11.PerformLayout()
        Me.tabAdministration.ResumeLayout(False)
        Me.tcAdmin.ResumeLayout(False)
        Me.tabUsers.ResumeLayout(False)
        Me.tabUsers.PerformLayout()
        Me.GroupBox14.ResumeLayout(False)
        Me.GroupBox14.PerformLayout()
        Me.GroupBox13.ResumeLayout(False)
        Me.GroupBox13.PerformLayout()
        Me.GroupBox12.ResumeLayout(False)
        Me.GroupBox12.PerformLayout()
        Me.tabLocations.ResumeLayout(False)
        Me.tabLocations.PerformLayout()
        Me.GroupBox15.ResumeLayout(False)
        Me.GroupBox15.PerformLayout()
        Me.tabManufacturers.ResumeLayout(False)
        Me.tabManufacturers.PerformLayout()
        Me.GroupBox17.ResumeLayout(False)
        Me.GroupBox17.PerformLayout()
        Me.tabModels.ResumeLayout(False)
        Me.tabModels.PerformLayout()
        Me.GroupBox18.ResumeLayout(False)
        Me.GroupBox18.PerformLayout()
        Me.tabAdmins.ResumeLayout(False)
        Me.tabAdmins.PerformLayout()
        Me.GroupBox16.ResumeLayout(False)
        Me.GroupBox16.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents TLPMain As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents tcMain As System.Windows.Forms.TabControl
    Friend WithEvents tabAddHW As System.Windows.Forms.TabPage
    Friend WithEvents tabViewHW As System.Windows.Forms.TabPage
    Friend WithEvents tabEditHW As System.Windows.Forms.TabPage
    Friend WithEvents tabRemoveHW As System.Windows.Forms.TabPage
    Friend WithEvents tabAdministration As System.Windows.Forms.TabPage
    Friend WithEvents pnlButtons As System.Windows.Forms.Panel
    Friend WithEvents btnAddHW As System.Windows.Forms.Button
    Friend WithEvents btnAdministration As System.Windows.Forms.Button
    Friend WithEvents btnRemoveHW As System.Windows.Forms.Button
    Friend WithEvents btnEditHW As System.Windows.Forms.Button
    Friend WithEvents btnViewHW As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsbLogin As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbLogout As System.Windows.Forms.ToolStripButton
    Friend WithEvents txtViewSerialNumber As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents gbUserInfoView As System.Windows.Forms.GroupBox
    Friend WithEvents txtViewNotes As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtViewUser As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtViewAsset As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtViewEndDate As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtViewStartDate As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtViewCompany As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtViewModel As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtViewReplacedAsset As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents txtAddReplacedAsset As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtAddAsset As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents txtAddCompany As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents txtAddNotes As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents txtAddSerialNumber As System.Windows.Forms.TextBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents cboAddUser As System.Windows.Forms.ComboBox
    Friend WithEvents cboAddModel As System.Windows.Forms.ComboBox
    Friend WithEvents btnAddCancel As System.Windows.Forms.Button
    Friend WithEvents btnAddSave As System.Windows.Forms.Button
    Friend WithEvents btnEditCancel As System.Windows.Forms.Button
    Friend WithEvents btnEditSave As System.Windows.Forms.Button
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents txtEditReplacedAsset As System.Windows.Forms.TextBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents txtEditAsset As System.Windows.Forms.TextBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents cboEditModel As System.Windows.Forms.ComboBox
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents txtEditCompany As System.Windows.Forms.TextBox
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents GroupBox8 As System.Windows.Forms.GroupBox
    Friend WithEvents cboEditUser As System.Windows.Forms.ComboBox
    Friend WithEvents txtEditNotes As System.Windows.Forms.TextBox
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents txtEditSerialNumber As System.Windows.Forms.TextBox
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents btnRemoveCancel As System.Windows.Forms.Button
    Friend WithEvents btnRemoveSave As System.Windows.Forms.Button
    Friend WithEvents GroupBox9 As System.Windows.Forms.GroupBox
    Friend WithEvents txtRemoveReplacedAsset As System.Windows.Forms.TextBox
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents txtRemoveAsset As System.Windows.Forms.TextBox
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents txtRemoveEndDate As System.Windows.Forms.TextBox
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents txtRemoveStartDate As System.Windows.Forms.TextBox
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents GroupBox10 As System.Windows.Forms.GroupBox
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents txtRemoveCompany As System.Windows.Forms.TextBox
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents GroupBox11 As System.Windows.Forms.GroupBox
    Friend WithEvents txtRemoveNotes As System.Windows.Forms.TextBox
    Friend WithEvents Label38 As System.Windows.Forms.Label
    Friend WithEvents Label39 As System.Windows.Forms.Label
    Friend WithEvents txtRemoveSerialNumber As System.Windows.Forms.TextBox
    Friend WithEvents Label40 As System.Windows.Forms.Label
    Friend WithEvents tcAdmin As System.Windows.Forms.TabControl
    Friend WithEvents tabUsers As System.Windows.Forms.TabPage
    Friend WithEvents tabLocations As System.Windows.Forms.TabPage
    Friend WithEvents btnViewClear As System.Windows.Forms.Button
    Friend WithEvents tabAdmins As System.Windows.Forms.TabPage
    Friend WithEvents tabManufacturers As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox12 As System.Windows.Forms.GroupBox
    Friend WithEvents txtViewLocation As System.Windows.Forms.TextBox
    Friend WithEvents Label45 As System.Windows.Forms.Label
    Friend WithEvents GroupBox14 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox13 As System.Windows.Forms.GroupBox
    Friend WithEvents btnUsersView As System.Windows.Forms.Button
    Friend WithEvents btnUsersEdit As System.Windows.Forms.Button
    Friend WithEvents btnUsersAdd As System.Windows.Forms.Button
    Friend WithEvents Label41 As System.Windows.Forms.Label
    Friend WithEvents txtUsersFirst As System.Windows.Forms.TextBox
    Friend WithEvents Label42 As System.Windows.Forms.Label
    Friend WithEvents txtUsersPhone As System.Windows.Forms.TextBox
    Friend WithEvents Label43 As System.Windows.Forms.Label
    Friend WithEvents txtUsersLast As System.Windows.Forms.TextBox
    Friend WithEvents Label44 As System.Windows.Forms.Label
    Friend WithEvents txtRemoveModel As System.Windows.Forms.TextBox
    Friend WithEvents cboUsersPurpose As System.Windows.Forms.ComboBox
    Friend WithEvents Label47 As System.Windows.Forms.Label
    Friend WithEvents cboUsersLocation As System.Windows.Forms.ComboBox
    Friend WithEvents Label46 As System.Windows.Forms.Label
    Friend WithEvents btnUsersRemove As System.Windows.Forms.Button
    Friend WithEvents btnUsersCancel As System.Windows.Forms.Button
    Friend WithEvents btnUsersSave As System.Windows.Forms.Button
    Friend WithEvents btnLocationsAdd As System.Windows.Forms.Button
    Friend WithEvents btnLocationsView As System.Windows.Forms.Button
    Friend WithEvents btnLocationsRemove As System.Windows.Forms.Button
    Friend WithEvents GroupBox15 As System.Windows.Forms.GroupBox
    Friend WithEvents cboLocationsLocation As System.Windows.Forms.ComboBox
    Friend WithEvents Label48 As System.Windows.Forms.Label
    Friend WithEvents btnLocationsCancel As System.Windows.Forms.Button
    Friend WithEvents btnLocationsSave As System.Windows.Forms.Button
    Friend WithEvents txtLocationsNotes As System.Windows.Forms.TextBox
    Friend WithEvents Label49 As System.Windows.Forms.Label
    Friend WithEvents txtAdminsPassword As System.Windows.Forms.TextBox
    Friend WithEvents btnAdminsCancel As System.Windows.Forms.Button
    Friend WithEvents btnAdminsSave As System.Windows.Forms.Button
    Friend WithEvents GroupBox16 As System.Windows.Forms.GroupBox
    Friend WithEvents Label51 As System.Windows.Forms.Label
    Friend WithEvents Label53 As System.Windows.Forms.Label
    Friend WithEvents btnAdminsRemove As System.Windows.Forms.Button
    Friend WithEvents btnAdminsView As System.Windows.Forms.Button
    Friend WithEvents btnAdminsAdd As System.Windows.Forms.Button
    Friend WithEvents tabModels As System.Windows.Forms.TabPage
    Friend WithEvents btnManufacturersCancel As System.Windows.Forms.Button
    Friend WithEvents btnManufacturersSave As System.Windows.Forms.Button
    Friend WithEvents btnManufacturersRemove As System.Windows.Forms.Button
    Friend WithEvents btnManufacturersView As System.Windows.Forms.Button
    Friend WithEvents btnManufacturersAdd As System.Windows.Forms.Button
    Friend WithEvents GroupBox17 As System.Windows.Forms.GroupBox
    Friend WithEvents txtManufacturersInstructions As System.Windows.Forms.TextBox
    Friend WithEvents Label50 As System.Windows.Forms.Label
    Friend WithEvents Label52 As System.Windows.Forms.Label
    Friend WithEvents txtManufactureresPhone As System.Windows.Forms.TextBox
    Friend WithEvents Label54 As System.Windows.Forms.Label
    Friend WithEvents txtManufacturersAddress As System.Windows.Forms.TextBox
    Friend WithEvents Label55 As System.Windows.Forms.Label
    Friend WithEvents btnModelsCancel As System.Windows.Forms.Button
    Friend WithEvents btnModelsSave As System.Windows.Forms.Button
    Friend WithEvents btnModelsRemove As System.Windows.Forms.Button
    Friend WithEvents btnModelsView As System.Windows.Forms.Button
    Friend WithEvents btnModelsAdd As System.Windows.Forms.Button
    Friend WithEvents GroupBox18 As System.Windows.Forms.GroupBox
    Friend WithEvents txtModelsDescription As System.Windows.Forms.TextBox
    Friend WithEvents Label56 As System.Windows.Forms.Label
    Friend WithEvents Label57 As System.Windows.Forms.Label
    Friend WithEvents Label58 As System.Windows.Forms.Label
    Friend WithEvents txtModelsPart As System.Windows.Forms.TextBox
    Friend WithEvents Label59 As System.Windows.Forms.Label
    Friend WithEvents cboModelsManufacturer As System.Windows.Forms.ComboBox
    Friend WithEvents txtRemoveUser As System.Windows.Forms.TextBox
    Friend WithEvents chkAddLease As System.Windows.Forms.CheckBox
    Friend WithEvents TSSLUser As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label60 As System.Windows.Forms.Label
    Friend WithEvents Label61 As System.Windows.Forms.Label
    Friend WithEvents Label62 As System.Windows.Forms.Label
    Friend WithEvents Label63 As System.Windows.Forms.Label
    Friend WithEvents Label64 As System.Windows.Forms.Label
    Friend WithEvents chkViewLease As System.Windows.Forms.CheckBox
    Friend WithEvents chkEditLease As System.Windows.Forms.CheckBox
    Friend WithEvents cboAdminsUserName As System.Windows.Forms.ComboBox
    Friend WithEvents cboManufacturersCompany As System.Windows.Forms.ComboBox
    Friend WithEvents cboModelsName As System.Windows.Forms.ComboBox
    Friend WithEvents cboUsersLogin As System.Windows.Forms.ComboBox
    Friend WithEvents dtpAddStartDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpAddEndDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpEditEndDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpEditStartDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtAddLocation As System.Windows.Forms.TextBox
    Friend WithEvents Label65 As System.Windows.Forms.Label
    Friend WithEvents txtEditLocation As System.Windows.Forms.TextBox
    Friend WithEvents Label66 As System.Windows.Forms.Label
    Friend WithEvents txtRemoveLocation As System.Windows.Forms.TextBox
    Friend WithEvents Label67 As System.Windows.Forms.Label
    Friend WithEvents chkRemoveLease As System.Windows.Forms.CheckBox

End Class
