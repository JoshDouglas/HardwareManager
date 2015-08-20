''' <summary>
''' Author: Josh Douglas
''' </summary>
''' <remarks></remarks>

Public Class frmMain

    Private Username As String
    Private boolValidated As Boolean
    Private AdminActionMode As String
    Private d1 As New DB

#Region "Navigation"

    ''' <summary>
    ''' Exits the application.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    ''' <summary>
    ''' Exits the application.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub

    ''' <summary>
    ''' Navigates to view hardware tab.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnViewHW_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnViewHW.Click
        tcMain.TabPages.Remove(tcMain.SelectedTab)
        tcMain.TabPages.Add(tabViewHW)
    End Sub

    ''' <summary>
    ''' Navigates to edit hardware tab.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnEditHW_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditHW.Click
        tcMain.TabPages.Remove(tcMain.SelectedTab)
        tcMain.TabPages.Add(tabEditHW)
    End Sub

    ''' <summary>
    ''' Navigates to add hardware tab.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnAddHW_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddHW.Click
        tcMain.TabPages.Remove(tcMain.SelectedTab)
        tcMain.TabPages.Add(tabAddHW)
    End Sub

    ''' <summary>
    ''' Navigates to remove hardware tab.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnRemoveHW_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemoveHW.Click
        tcMain.TabPages.Remove(tcMain.SelectedTab)
        tcMain.TabPages.Add(tabRemoveHW)
    End Sub

    ''' <summary>
    ''' Navigates to the administration tab.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnAdministration_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdministration.Click
        tcMain.TabPages.Remove(tcMain.SelectedTab)
        tcMain.TabPages.Add(tabAdministration)
    End Sub

    ''' <summary>
    ''' Displays about information for the program.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        frmAbout.ShowDialog()
    End Sub

    ''' <summary>
    ''' Clears all input controls on the tab when the selected tab changes.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub ResetTab(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ControlEventArgs) Handles tcMain.ControlRemoved
        Try
            'Wipe the content of controls on the tabpage.
            If TypeOf e.Control Is TabPage Then
                ResetControls(e.Control)
            End If

            'On the view and remove pages make sure serial number entry is allowed.
            txtViewSerialNumber.ReadOnly = False
            txtRemoveSerialNumber.ReadOnly = False
            txtEditSerialNumber.ReadOnly = False
            'This might have some poor modular use and might be changed in the future.
            HardwareEditEnabled(False)
        Catch ex As Exception
            MessageBox.Show("An error occured during transition. " & Err.Description, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ''' <summary>
    ''' Resets all text input, items, and checked input for all controls on the passed control.
    ''' </summary>
    ''' <param name="c"></param>
    ''' <remarks></remarks>
    Private Sub ResetControls(ByVal c As Control)
        Try
            For Each c In c.Controls
                If TypeOf c Is TextBox Then
                    Dim tmpTextBox As TextBox = c
                    tmpTextBox.Clear()
                End If

                If TypeOf c Is ComboBox Then
                    Dim tmpComboBox As ComboBox = c
                    tmpComboBox.Items.Clear()
                    tmpComboBox.Text = ""
                End If

                If TypeOf c Is CheckBox Then
                    Dim tmpCheckBox As CheckBox = c
                    tmpCheckBox.Checked = False
                End If

                If TypeOf c Is GroupBox Then
                    ResetControls(c)
                End If

                If TypeOf c Is DateTimePicker Then
                    Dim tmpDTP As DateTimePicker = c
                    tmpDTP.ResetText()
                End If
            Next
        Catch ex As Exception
            MessageBox.Show("An error occured during transition. " & Err.Description, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

#End Region

#Region "Login"

    ''' <summary>
    ''' Sets all the proper visual displays, tooltips, and begins login for the program.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            'Hide tabs.
            tcMain.TabPages.Remove(tabEditHW)
            tcMain.TabPages.Remove(tabAddHW)
            tcMain.TabPages.Remove(tabRemoveHW)
            tcMain.TabPages.Remove(tabAdministration)

            'Get admin to login.
            frmLogin.ShowDialog()

            'Validate the login was successful.
            If boolValidated = False Then
                Me.Close() 'To prevent the form from popping up before closing.
                Application.Exit()
            End If

        Catch ex As Exception
            MessageBox.Show("An erorr occured loading the application. " & Err.Description, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ''' <summary>
    ''' Gets the admin login details.
    ''' </summary>
    ''' <param name="User"></param>
    ''' <param name="Validated"></param>
    ''' <remarks></remarks>
    Public Sub SetSecurity(ByVal User As String, ByVal Validated As Integer)
        Try
            Username = User

            If Validated = 1 Then
                boolValidated = True
            Else
                boolValidated = False
            End If

            TSSLUser.Text = "Admin Logged In: " & Username
        Catch ex As Exception
            MessageBox.Show("An error occured during login. " & Err.Description, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ''' <summary>
    ''' Restarts the application for new user to login.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub tsbLogout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbLogout.Click
        Application.Restart()
    End Sub

#End Region

#Region "Hardware"

#Region "Input Validation"

    Private Function ValidateHardwareInput(ByVal Mode As String) As Boolean
        Try
            Select Case Mode
                Case "Add"
                    'Check serial number.
                    If txtAddSerialNumber.Text.Trim = "" Then
                        MessageBox.Show("A serial number must be entered.", "Add Hardware", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        txtAddSerialNumber.Focus()
                        Return False
                    End If

                    'Check user.
                    If cboAddUser.Text.Trim = "" Then
                        MessageBox.Show("A user must be selected.", "Add Hardware", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        cboAddUser.Focus()
                        Return False
                    End If

                    'Check notes.
                    If txtAddNotes.Text.Trim = "" Then
                        MessageBox.Show("Notes must be entered.", "Add Hardware", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        txtAddNotes.Focus()
                        Return False
                    End If

                    'Check model.
                    If cboAddModel.Text.Trim = "" Then
                        MessageBox.Show("A model must be selected.", "Add Hardware", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        cboAddModel.Focus()
                        Return False
                    End If

                    'Check all lease.
                    If chkAddLease.Checked = True Then
                        If txtAddAsset.Text.Trim = "" Then
                            MessageBox.Show("A asset tag must be entered.", "Add Hardware", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                            txtAddAsset.Focus()
                            Return False
                        End If

                        If txtAddReplacedAsset.Text.Trim = "" Then
                            MessageBox.Show("A replaced asset must be entered (enter N/A for nothing to replace).", "Add Hardware", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                            txtAddReplacedAsset.Focus()
                            Return False
                        End If

                        If dtpAddStartDate.Value > dtpAddEndDate.Value Then
                            MessageBox.Show("Lease start date must be earlier than lease end date.", "Add Hardware", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                            Return False
                        End If
                    End If

                    'If all checks pass, return true.
                    Return True

                Case "Edit"
                    'Check serial number.
                    If txtEditSerialNumber.Text.Trim = "" Then
                        MessageBox.Show("A serial number must be entered.", "Edit Hardware", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        txtEditSerialNumber.Focus()
                        Return False
                    End If

                    'Check user.
                    If cboEditUser.Text.Trim = "" Then
                        MessageBox.Show("A user must be selected.", "Edit Hardware", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        cboEditUser.Focus()
                        Return False
                    End If

                    'Check notes.
                    If txtEditNotes.Text.Trim = "" Then
                        MessageBox.Show("Notes must be entered.", "Edit Hardware", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        txtEditNotes.Focus()
                        Return False
                    End If

                    'Check model.
                    If cboEditModel.Text.Trim = "" Then
                        MessageBox.Show("A model must be selected.", "Edit Hardware", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        cboEditModel.Focus()
                        Return False
                    End If

                    'Check all lease.
                    If chkEditLease.Checked = True Then
                        If txtEditAsset.Text.Trim = "" Then
                            MessageBox.Show("A asset tag must be entered.", "Edit Hardware", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                            txtEditAsset.Focus()
                            Return False
                        End If

                        If txtEditReplacedAsset.Text.Trim = "" Then
                            MessageBox.Show("A replaced asset must be entered (enter N/A for nothing to replace).", "Edit Hardware", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                            txtEditReplacedAsset.Focus()
                            Return False
                        End If

                        If dtpEditStartDate.Value > dtpEditEndDate.Value Then
                            MessageBox.Show("Lease start date must be earlier than lease end date.", "Edit Hardware", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                            Return False
                        End If
                    End If

                    'If all checks pass, return true.
                    Return True
            End Select
        Catch ex As Exception
            MessageBox.Show("An error occured validating the page. " & Err.Description, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Function

#End Region
    
#Region "View"

    Private Sub txtViewSerialNumber_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtViewSerialNumber.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                txtViewSerialNumber.Text = txtViewSerialNumber.Text.ToUpper

                Dim tmpDT As New DataTable
                tmpDT = d1.GetHardware(txtViewSerialNumber.Text.Trim)

                If tmpDT.Rows.Count > 0 Then
                    txtViewSerialNumber.ReadOnly = True

                    txtViewUser.Text = tmpDT.Rows(0).Item("LoginName").ToString
                    txtViewLocation.Text = tmpDT.Rows(0).Item("LDescription").ToString
                    txtViewNotes.Text = tmpDT.Rows(0).Item("Notes").ToString
                    txtViewModel.Text = tmpDT.Rows(0).Item("ModelName").ToString
                    txtViewCompany.Text = tmpDT.Rows(0).Item("CompanyName").ToString
                    chkViewLease.Checked = tmpDT.Rows(0).Item("IsLeased").ToString

                    If chkViewLease.Checked = True Then
                        txtViewAsset.Text = tmpDT.Rows(0).Item("AssetTag").ToString
                        txtViewStartDate.Text = tmpDT.Rows(0).Item("StartDate").ToString
                        txtViewEndDate.Text = tmpDT.Rows(0).Item("EndDate").ToString
                        txtViewReplacedAsset.Text = tmpDT.Rows(0).Item("ReplacedAsset").ToString
                    Else
                        txtViewAsset.Text = "N/A"
                        txtViewStartDate.Text = "N/A"
                        txtViewEndDate.Text = "N/A"
                        txtViewReplacedAsset.Text = "N/A"
                    End If

                Else
                    MessageBox.Show("No hardware exists with that serial number.", "View Hardware", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    txtViewSerialNumber.Clear()
                    txtViewSerialNumber.Focus()
                    Exit Sub
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("An error occured retrieving the hardware information. " & Err.Description, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnViewClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnViewClear.Click
        Try
            Dim c As Control = sender
            ResetControls(c.Parent)

            txtViewSerialNumber.ReadOnly = False
            txtViewSerialNumber.Focus()
        Catch ex As Exception
            MessageBox.Show("An error occured clearing the page. " & Err.Description, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

#End Region

#Region "Add"

    Private Sub btnAddCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddCancel.Click
        Try
            If MessageBox.Show("Cancel this entry?", "Cancel Add", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = Windows.Forms.DialogResult.Yes Then
                'Clear the controls on the tab.
                Dim c As Control = sender
                ResetControls(c.Parent)

                'Set focus
                txtAddSerialNumber.Focus()
            End If
        Catch ex As Exception
            MessageBox.Show("An error occured clearing the page. " & Err.Description, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnAddSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddSave.Click
        Try
            'Validate the input.
            If ValidateHardwareInput("Add") = True Then
                'Insert the hardware.
                If chkAddLease.Checked = True Then
                    d1.InsertHardware(txtAddSerialNumber.Text.Trim, cboAddUser.Text.Trim, txtAddNotes.Text.Trim, cboAddModel.Text.Trim, chkAddLease.Checked, txtAddAsset.Text.Trim, dtpAddStartDate.Value, dtpAddEndDate.Value, txtAddReplacedAsset.Text.Trim)
                Else
                    d1.InsertHardware(txtAddSerialNumber.Text.Trim, cboAddUser.Text.Trim, txtAddNotes.Text.Trim, cboAddModel.Text.Trim, chkAddLease.Checked, "N/A", dtpAddStartDate.Value, dtpAddEndDate.Value, "N/A")
                End If

                MessageBox.Show("Hardware added successfully.", "Add Hardware", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ResetControls(tabAddHW)
                txtAddSerialNumber.Focus()
            End If
        Catch ex As Exception
            MessageBox.Show("An error occured saving the hardware. " & Err.Description, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub cboAddModel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboAddModel.Click
        Try
            'Clear previous items.
            cboAddModel.Items.Clear()

            Dim tmpDT As New DataTable
            tmpDT = d1.GetAllModelNames

            Dim i As Integer = 0

            'Populate.
            If tmpDT.Rows.Count > 0 Then
                For i = 0 To tmpDT.Rows.Count - 1
                    cboAddModel.Items.Add(tmpDT.Rows(i).Item(0).ToString)
                Next
            End If
        Catch ex As Exception
            MessageBox.Show("An error occured retrieving model information. " & Err.Description, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub cboAddUser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboAddUser.Click
        Try
            'Clear previous items.
            cboAddUser.Items.Clear()

            Dim tmpDT As New DataTable
            tmpDT = d1.GetAllUsers()

            Dim i As Integer = 0

            'Populate
            If tmpDT.Rows.Count > 0 Then
                For i = 0 To tmpDT.Rows.Count - 1
                    cboAddUser.Items.Add(tmpDT.Rows(i).Item(0).ToString)
                Next
            End If
        Catch ex As Exception
            MessageBox.Show("An error occured retrieving user information. " & Err.Description, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub cboAddUser_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboAddUser.SelectedIndexChanged
        Try
            Dim tmpDT As New DataTable
            tmpDT = d1.GetUser(cboAddUser.Text.Trim)

            If tmpDT.Rows.Count > 0 Then
                txtAddLocation.Text = tmpDT.Rows(0).Item("LDescription").ToString
            End If
        Catch ex As Exception
            MessageBox.Show("An error occured loading user information. " & Err.Description, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub cboAddModel_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboAddModel.SelectedIndexChanged
        Try
            Dim tmpDT As New DataTable
            tmpDT = d1.GetModel(cboAddModel.Text.Trim)

            If tmpDT.Rows.Count > 0 Then
                txtAddCompany.Text = tmpDT.Rows(0).Item("CompanyName").ToString
            End If
        Catch ex As Exception
            MessageBox.Show("An error occured loading model information. " & Err.Description, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

#End Region

#Region "Edit"

    Private Sub txtEditSerialNumber_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtEditSerialNumber.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                txtEditSerialNumber.Text = txtEditSerialNumber.Text.ToUpper

                Dim tmpDT As New DataTable
                tmpDT = d1.GetHardware(txtEditSerialNumber.Text.Trim)

                If tmpDT.Rows.Count > 0 Then
                    txtEditSerialNumber.ReadOnly = True
                    HardwareEditEnabled(True)

                    cboEditUser.Items.Clear()
                    cboEditUser.Items.Add(tmpDT.Rows(0).Item("LoginName").ToString)
                    cboEditUser.SelectedIndex = 0

                    txtEditLocation.Text = tmpDT.Rows(0).Item("LDescription").ToString
                    txtEditNotes.Text = tmpDT.Rows(0).Item("Notes").ToString

                    cboEditModel.Items.Clear()
                    cboEditModel.Items.Add(tmpDT.Rows(0).Item("ModelName").ToString)
                    cboEditModel.SelectedIndex = 0

                    txtEditCompany.Text = tmpDT.Rows(0).Item("CompanyName").ToString
                    chkEditLease.Checked = tmpDT.Rows(0).Item("IsLeased").ToString

                    If chkEditLease.Checked = True Then
                        txtEditAsset.Text = tmpDT.Rows(0).Item("AssetTag").ToString
                        dtpEditStartDate.Text = tmpDT.Rows(0).Item("StartDate").ToString
                        dtpEditEndDate.Text = tmpDT.Rows(0).Item("EndDate").ToString
                        txtEditReplacedAsset.Text = tmpDT.Rows(0).Item("ReplacedAsset").ToString
                    Else
                        txtEditAsset.Text = "N/A"
                        txtEditReplacedAsset.Text = "N/A"
                    End If

                Else
                    MessageBox.Show("No hardware exists with that serial number.", "Edit Hardware", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    txtEditSerialNumber.Clear()
                    txtEditSerialNumber.Focus()
                    Exit Sub
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("An error occured loading the hardware information. " & Err.Description, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnEditCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditCancel.Click
        Try
            If MessageBox.Show("Cancel this entry?", "Cancel Add", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = Windows.Forms.DialogResult.Yes Then
                'Clear the controls on the tab.
                Dim c As Control = sender
                ResetControls(c.Parent)

                'Set focus
                txtEditSerialNumber.Focus()
                txtEditSerialNumber.ReadOnly = False
                HardwareEditEnabled(False)
            End If
        Catch ex As Exception
            MessageBox.Show("An error occured during cancellation. " & Err.Description, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub cboEditUser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboEditUser.Click
        Try
            'Clear previous items.
            cboEditUser.Items.Clear()

            Dim tmpDT As New DataTable
            tmpDT = d1.GetAllUsers()

            Dim i As Integer = 0

            'Populate
            If tmpDT.Rows.Count > 0 Then
                For i = 0 To tmpDT.Rows.Count - 1
                    cboEditUser.Items.Add(tmpDT.Rows(i).Item(0).ToString)
                Next
            End If
        Catch ex As Exception
            MessageBox.Show("An error occured retrieving user information. " & Err.Description, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub cboEditModel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboEditModel.Click
        Try
            'Clear previous items.
            cboEditModel.Items.Clear()

            Dim tmpDT As New DataTable
            tmpDT = d1.GetAllModelNames

            Dim i As Integer = 0

            'Populate.
            If tmpDT.Rows.Count > 0 Then
                For i = 0 To tmpDT.Rows.Count - 1
                    cboEditModel.Items.Add(tmpDT.Rows(i).Item(0).ToString)
                Next
            End If
        Catch ex As Exception
            MessageBox.Show("An error occured retrieving model information. " & Err.Description, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub cboEditUser_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboEditUser.SelectedIndexChanged
        Try
            Dim tmpDT As New DataTable
            tmpDT = d1.GetUser(cboEditUser.Text.Trim)

            If tmpDT.Rows.Count > 0 Then
                txtEditLocation.Text = tmpDT.Rows(0).Item("LDescription").ToString
            End If
        Catch ex As Exception
            MessageBox.Show("An error occured loading user information. " & Err.Description, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub cboEditModel_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboEditModel.SelectedIndexChanged
        Try
            Dim tmpDT As New DataTable
            tmpDT = d1.GetModel(cboEditModel.Text.Trim)

            If tmpDT.Rows.Count > 0 Then
                txtEditCompany.Text = tmpDT.Rows(0).Item("CompanyName").ToString
            End If
        Catch ex As Exception
            MessageBox.Show("An error occured loading model information. " & Err.Description, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub HardwareEditEnabled(ByVal State As Boolean)
        Try
            Select Case State
                Case True
                    cboEditUser.Enabled = True
                    txtEditLocation.Enabled = True
                    txtEditNotes.Enabled = True
                    cboEditModel.Enabled = True
                    txtEditCompany.Enabled = True
                    chkEditLease.Enabled = True
                    txtEditAsset.Enabled = True
                    dtpEditStartDate.Enabled = True
                    dtpEditEndDate.Enabled = True
                    txtEditReplacedAsset.Enabled = True
                Case False
                    cboEditUser.Enabled = False
                    txtEditLocation.Enabled = False
                    txtEditNotes.Enabled = False
                    cboEditModel.Enabled = False
                    txtEditCompany.Enabled = False
                    chkEditLease.Enabled = False
                    txtEditAsset.Enabled = False
                    dtpEditStartDate.Enabled = False
                    dtpEditEndDate.Enabled = False
                    txtEditReplacedAsset.Enabled = False
            End Select
        Catch ex As Exception
            MessageBox.Show("An error occured changing page state. " & Err.Description, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnEditSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditSave.Click
        Try
            'Validate the input.
            If ValidateHardwareInput("Edit") = True Then
                'Update the hardware.
                If chkEditLease.Checked = True Then
                    d1.UpdateHardware(txtEditSerialNumber.Text.Trim, cboEditUser.Text.Trim, txtEditNotes.Text.Trim, cboEditModel.Text.Trim, chkEditLease.Checked, txtEditAsset.Text.Trim, dtpEditStartDate.Value, dtpEditEndDate.Value, txtEditReplacedAsset.Text.Trim)
                Else
                    d1.UpdateHardware(txtEditSerialNumber.Text.Trim, cboEditUser.Text.Trim, txtEditNotes.Text.Trim, cboEditModel.Text.Trim, chkEditLease.Checked, "N/A", dtpEditStartDate.Value, dtpEditEndDate.Value, "N/A")
                End If

                MessageBox.Show("Hardware updated successfully.", "Edit Hardware", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ResetControls(tabEditHW)
                txtEditSerialNumber.Focus()
                txtEditSerialNumber.ReadOnly = False
                HardwareEditEnabled(False)
            End If
        Catch ex As Exception
            MessageBox.Show("An error occured updating the hardware. " & Err.Description, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

#End Region

#Region "Remove"

    Private Sub btnRemoveCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemoveCancel.Click
        Try
            'Clear the controls on the tab.
            Dim c As Control = sender
            ResetControls(c.Parent)

            'Set focus
            txtRemoveSerialNumber.Focus()

            txtRemoveSerialNumber.ReadOnly = False
        Catch ex As Exception
            MessageBox.Show("An error occured during cancellation. " & Err.Description, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtRemoveSerialNumber_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtRemoveSerialNumber.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                txtRemoveSerialNumber.Text = txtRemoveSerialNumber.Text.ToUpper

                Dim tmpDT As New DataTable
                tmpDT = d1.GetHardware(txtRemoveSerialNumber.Text.Trim)

                If tmpDT.Rows.Count > 0 Then
                    txtRemoveSerialNumber.ReadOnly = True

                    txtRemoveUser.Text = tmpDT.Rows(0).Item("LoginName").ToString
                    txtRemoveLocation.Text = tmpDT.Rows(0).Item("LDescription").ToString
                    txtRemoveNotes.Text = tmpDT.Rows(0).Item("Notes").ToString
                    txtRemoveModel.Text = tmpDT.Rows(0).Item("ModelName").ToString
                    txtRemoveCompany.Text = tmpDT.Rows(0).Item("CompanyName").ToString
                    chkRemoveLease.Checked = tmpDT.Rows(0).Item("IsLeased").ToString

                    If chkRemoveLease.Checked = True Then
                        txtRemoveAsset.Text = tmpDT.Rows(0).Item("AssetTag").ToString
                        txtRemoveStartDate.Text = tmpDT.Rows(0).Item("StartDate").ToString
                        txtRemoveEndDate.Text = tmpDT.Rows(0).Item("EndDate").ToString
                        txtRemoveReplacedAsset.Text = tmpDT.Rows(0).Item("ReplacedAsset").ToString
                    Else
                        txtRemoveAsset.Text = "N/A"
                        txtRemoveStartDate.Text = "N/A"
                        txtRemoveEndDate.Text = "N/A"
                        txtRemoveReplacedAsset.Text = "N/A"
                    End If

                Else
                    MessageBox.Show("No hardware exists with that serial number.", "Remove Hardware", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation)
                    txtRemoveSerialNumber.Clear()
                    txtRemoveSerialNumber.Focus()
                    Exit Sub
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("An error occured loading the hardware. " & Err.Description, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnRemoveSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemoveSave.Click
        Try
            'Validate input.
            If txtRemoveSerialNumber.Text.Trim = "" Then
                MessageBox.Show("Please enter a hardware serial number to remove it.", "Remove Hardware", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If

            'Get user confirmation.
            If MessageBox.Show("Delete the Hardware?", "Remove Hardware", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = Windows.Forms.DialogResult.Yes Then
                'Delete the hardware from the database.
                d1.DeleteHardware(txtRemoveSerialNumber.Text.Trim)
                MessageBox.Show("Hardware has been removed.", "Remove HardwareA", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ResetControls(tabRemoveHW)
                txtRemoveSerialNumber.ReadOnly = False
                txtRemoveSerialNumber.Focus()
            End If
        Catch ex As Exception
            MessageBox.Show("An error occured removing the hardware. " & Err.Description, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

#End Region

#End Region

#Region "Administration"

#Region "Admins"

    Private Sub btnAdminsCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdminsCancel.Click
        Try
            If MessageBox.Show("Cancel this entry?", "Cancel Add", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = Windows.Forms.DialogResult.Yes Then
                'Clear the controls on the tab.
                Dim c As Control = sender
                ResetControls(c.Parent)

                'Set focus
                btnAdminsView.Focus()

                AdminActionMode = "Inactive"
                SetAdminsTab(AdminActionMode)
            End If
        Catch ex As Exception
            MessageBox.Show("An error occured during cancellation. " & Err.Description, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnAdminsView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdminsView.Click
        Try
            AdminActionMode = "View"
            SetAdminsTab(AdminActionMode)
        Catch ex As Exception
            MessageBox.Show("An error occured during transition. " & Err.Description, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnAdminsAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdminsAdd.Click
        Try
            AdminActionMode = "Add"
            SetAdminsTab(AdminActionMode)
        Catch ex As Exception
            MessageBox.Show("An error occured during transition. " & Err.Description, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnAdminsRemove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdminsRemove.Click
        Try
            AdminActionMode = "Remove"
            SetAdminsTab(AdminActionMode)
        Catch ex As Exception
            MessageBox.Show("An error occured during transition. " & Err.Description, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub SetAdminsTab(ByVal State As String)
        Try
            Select Case State
                Case "View"
                    cboAdminsUserName.Visible = True
                    cboAdminsUserName.Enabled = True
                    cboAdminsUserName.DropDownStyle = ComboBoxStyle.DropDownList
                    btnAdminsSave.Visible = True
                    btnAdminsCancel.Visible = True
                    txtAdminsPassword.ReadOnly = True
                    btnAdminsAdd.Enabled = False
                    btnAdminsRemove.Enabled = False
                    btnAdminsSave.Enabled = False
                    cboAdminsUserName.Focus()
                Case "Add"
                    cboAdminsUserName.Visible = True
                    cboAdminsUserName.Enabled = True
                    cboAdminsUserName.DropDownStyle = ComboBoxStyle.DropDown
                    btnAdminsSave.Visible = True
                    btnAdminsCancel.Visible = True
                    txtAdminsPassword.ReadOnly = False
                    btnAdminsView.Enabled = False
                    btnAdminsRemove.Enabled = False
                    btnAdminsSave.Enabled = True
                    cboAdminsUserName.Focus()
                Case "Remove"
                    cboAdminsUserName.Visible = True
                    cboAdminsUserName.Enabled = True
                    cboAdminsUserName.DropDownStyle = ComboBoxStyle.DropDownList
                    btnAdminsSave.Visible = True
                    btnAdminsCancel.Visible = True
                    txtAdminsPassword.ReadOnly = True
                    btnAdminsAdd.Enabled = False
                    btnAdminsView.Enabled = False
                    btnAdminsSave.Enabled = True
                    cboAdminsUserName.Focus()
                Case "Inactive"
                    cboAdminsUserName.Visible = True
                    cboAdminsUserName.Enabled = False
                    cboAdminsUserName.DropDownStyle = ComboBoxStyle.DropDownList
                    txtAdminsPassword.ReadOnly = True
                    btnAdminsSave.Visible = False
                    btnAdminsCancel.Visible = False
                    btnAdminsAdd.Enabled = True
                    btnAdminsView.Enabled = True
                    btnAdminsRemove.Enabled = True
                    btnAdminsSave.Enabled = True
            End Select
        Catch ex As Exception
            MessageBox.Show("An error occured during transition. " & Err.Description, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnAdminsSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdminsSave.Click
        Try
            Select Case AdminActionMode
                Case "Add"
                    'Make sure an admin is chosen.
                    If cboAdminsUserName.Text.Trim = "" Or txtAdminsPassword.Text.Trim = "" Then
                        MessageBox.Show("Please fill out all fields.", "Empty Fields", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        Exit Sub
                    End If

                    'Save the admin.
                    If d1.InsertAdmin(cboAdminsUserName.Text.Trim, txtAdminsPassword.Text.Trim) = 1 Then
                        MessageBox.Show("Admin was added successfully.", "Admin Added", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        MessageBox.Show("Admin was not added. Either the admin exists or an error occured.", "Admin Not Added", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                    ResetControls(tabAdmins)
                    AdminActionMode = "Inactive"
                    SetAdminsTab(AdminActionMode)

                Case "Remove"
                    'Make sure an admin is chosen.
                    If cboAdminsUserName.Text.Trim = "" Then
                        MessageBox.Show("Select the admin to remove.", "Remove Admin", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        Exit Sub
                    End If

                    'Delete the admin.
                    If MessageBox.Show("Remove this admin?", "Remove Admin", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = Windows.Forms.DialogResult.Yes Then
                        d1.DeleteAdmin(cboAdminsUserName.Text.Trim)
                        ResetControls(tabAdmins)
                        AdminActionMode = "Inactive"
                        SetAdminsTab(AdminActionMode)
                        MessageBox.Show("Admin has been removed.", "Remove Admin", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
            End Select
        Catch ex As Exception
            MessageBox.Show("An error occured during save. " & Err.Description, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub cboAdminsUserName_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboAdminsUserName.Click
        Try
            'Only populate when viewing and removing.
            If AdminActionMode = "View" Or AdminActionMode = "Remove" Then
                'Clear previous.
                cboAdminsUserName.Items.Clear()

                'Get the usernames.
                Dim tmpDT As New DataTable
                tmpDT = d1.GetAdmins()

                'Populate the items.
                Dim i As Integer = 0

                If tmpDT.Rows.Count > 0 Then
                    For i = 0 To tmpDT.Rows.Count - 1
                        cboAdminsUserName.Items.Add(tmpDT.Rows(i).Item(0).ToString)
                    Next
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Error occured retrieving users. " & Err.Description, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub cboAdminsUserName_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboAdminsUserName.SelectedIndexChanged
        'Once a user is selected just populate a junk 10 character password into the field.
        txtAdminsPassword.Text = "1234567890"
    End Sub

#End Region

#Region "Manufacturer"

    Private Sub btnManufacturersCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnManufacturersCancel.Click
        Try
            If MessageBox.Show("Cancel this entry?", "Cancel Add", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = Windows.Forms.DialogResult.Yes Then
                'Clear the controls on the tab.
                Dim c As Control = sender
                ResetControls(c.Parent)

                'Set focus
                btnManufacturersView.Focus()

                'TODO: Reset tab state.
                AdminActionMode = "Inactive"
                SetManufacturerTab(AdminActionMode)
            End If
        Catch ex As Exception
            MessageBox.Show("An error occured during cancellation. " & Err.Description, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub SetManufacturerTab(ByVal State As String)
        Try
            Select Case State
                Case "View"
                    cboManufacturersCompany.Enabled = True
                    cboManufacturersCompany.DropDownStyle = ComboBoxStyle.DropDownList
                    txtManufacturersAddress.ReadOnly = True
                    txtManufactureresPhone.ReadOnly = True
                    txtManufacturersInstructions.ReadOnly = True
                    btnManufacturersSave.Visible = True
                    btnManufacturersSave.Enabled = False
                    btnManufacturersCancel.Visible = True
                    btnManufacturersRemove.Enabled = False
                    btnManufacturersAdd.Enabled = False
                    cboManufacturersCompany.Focus()
                Case "Add"
                    cboManufacturersCompany.Enabled = True
                    cboManufacturersCompany.DropDownStyle = ComboBoxStyle.DropDown
                    txtManufacturersAddress.ReadOnly = False
                    txtManufactureresPhone.ReadOnly = False
                    txtManufacturersInstructions.ReadOnly = False
                    btnManufacturersSave.Visible = True
                    btnManufacturersCancel.Visible = True
                    btnManufacturersView.Enabled = False
                    btnManufacturersRemove.Enabled = False
                    cboManufacturersCompany.Focus()
                Case "Remove"
                    cboManufacturersCompany.Enabled = True
                    cboManufacturersCompany.DropDownStyle = ComboBoxStyle.DropDownList
                    txtManufacturersAddress.ReadOnly = True
                    txtManufactureresPhone.ReadOnly = True
                    txtManufacturersInstructions.ReadOnly = True
                    btnManufacturersSave.Visible = True
                    btnManufacturersCancel.Visible = True
                    btnManufacturersAdd.Enabled = False
                    btnManufacturersView.Enabled = False
                    cboManufacturersCompany.Focus()
                Case "Inactive"
                    cboManufacturersCompany.Enabled = False
                    cboManufacturersCompany.DropDownStyle = ComboBoxStyle.DropDownList
                    txtManufacturersAddress.ReadOnly = True
                    txtManufactureresPhone.ReadOnly = True
                    txtManufacturersInstructions.ReadOnly = True
                    btnManufacturersSave.Visible = False
                    btnManufacturersSave.Enabled = True
                    btnManufacturersCancel.Visible = False
                    btnManufacturersView.Enabled = True
                    btnManufacturersAdd.Enabled = True
                    btnManufacturersRemove.Enabled = True
            End Select
        Catch ex As Exception
            MessageBox.Show("An error occured during transition. " & Err.Description, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnManufacturersView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnManufacturersView.Click
        Try
            AdminActionMode = "View"
            SetManufacturerTab(AdminActionMode)
        Catch ex As Exception
            MessageBox.Show("An error occured during transition. " & Err.Description, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnManufacturersAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnManufacturersAdd.Click
        Try
            AdminActionMode = "Add"
            SetManufacturerTab(AdminActionMode)
        Catch ex As Exception
            MessageBox.Show("An error occured during transition. " & Err.Description, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnManufacturersRemove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnManufacturersRemove.Click
        Try
            AdminActionMode = "Remove"
            SetManufacturerTab(AdminActionMode)
        Catch ex As Exception
            MessageBox.Show("An error occured during transition. " & Err.Description, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnManufacturersSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnManufacturersSave.Click
        Try
            Select Case AdminActionMode
                Case "Add"
                    'Make sure all input is valid.
                    If cboManufacturersCompany.Text.Trim = "" Or txtManufacturersAddress.Text.Trim = "" Or txtManufactureresPhone.Text.Trim = "" Or txtManufacturersInstructions.Text.Trim = "" Then
                        MessageBox.Show("All fields must be filled out.", "Add Manufacturer", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        Exit Sub
                    End If

                    'Save the manufacturer.
                    If d1.InsertManufacturer(cboManufacturersCompany.Text.Trim, txtManufacturersAddress.Text.Trim, txtManufactureresPhone.Text.Trim, txtManufacturersInstructions.Text.Trim) = 1 Then
                        MessageBox.Show("Manufacturer Added.", "Add Manufacturer", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        MessageBox.Show("Manufacturer was not added. Either the manufacturer exists or an error occured.", "Add Manufacturer", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                    ResetControls(tabManufacturers)
                    AdminActionMode = "Inactive"
                    SetManufacturerTab(AdminActionMode)


                Case "Remove"
                    'Make sure a manufacturer is selected.
                    If cboManufacturersCompany.Text.Trim = "" Then
                        MessageBox.Show("A manufacturer must be selected before removal.", "Remove Manufacturer", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    End If

                    'Delete the manufacturer.
                    If MessageBox.Show("Remove this manufactuer?", "Remove Manufacturer", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = Windows.Forms.DialogResult.Yes Then
                        d1.DeleteManufacturer(cboManufacturersCompany.Text.Trim)
                        ResetControls(tabManufacturers)
                        AdminActionMode = "Inactive"
                        SetManufacturerTab(AdminActionMode)
                        MessageBox.Show("Manufacturer has been removed.", "Remove Manufacturer", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
            End Select
        Catch ex As Exception
            MessageBox.Show("An error occured during save. " & Err.Description, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub cboManufacturersCompany_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboManufacturersCompany.Click
        Try
            If AdminActionMode = "View" Or AdminActionMode = "Remove" Then
                'Clear previous items.
                cboManufacturersCompany.Items.Clear()

                Dim tmpDT As New DataTable
                tmpDT = d1.GetAllManufacturerNames()

                Dim i As Integer = 0

                If tmpDT.Rows.Count > 0 Then
                    For i = 0 To tmpDT.Rows.Count - 1
                        cboManufacturersCompany.Items.Add(tmpDT.Rows(i).Item(0).ToString)
                    Next
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("An error occured retrieving manufacturers. " & Err.Description, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub cboManufacturersCompany_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboManufacturersCompany.SelectedIndexChanged
        Try
            'Display the manufacturer info for the selected company.
            Dim tmpDT As New DataTable
            tmpDT = d1.GetManufacturer(cboManufacturersCompany.Text.Trim)

            txtManufacturersAddress.Text = tmpDT.Rows(0).Item("ReturnAddress")
            txtManufactureresPhone.Text = tmpDT.Rows(0).Item("PhoneNum")
            txtManufacturersInstructions.Text = tmpDT.Rows(0).Item("ReturnInstructions")
        Catch ex As Exception
            MessageBox.Show("An error occured retreiving manufacturer info. " & Err.Description, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

#End Region

#Region "Models"

    Private Sub SetModelsTab(ByVal State As String)
        Try
            Select Case State
                Case "View"
                    cboModelsName.Enabled = True
                    cboModelsName.DropDownStyle = ComboBoxStyle.DropDownList
                    cboModelsManufacturer.Enabled = True
                    cboModelsManufacturer.DropDownStyle = ComboBoxStyle.DropDownList
                    btnModelsSave.Enabled = False
                    btnModelsSave.Visible = True
                    btnModelsCancel.Visible = True
                    btnModelsAdd.Enabled = False
                    btnModelsRemove.Enabled = False
                    txtModelsDescription.ReadOnly = True
                    txtModelsPart.ReadOnly = True
                    cboModelsName.Focus()
                Case "Add"
                    cboModelsName.Enabled = True
                    cboModelsName.DropDownStyle = ComboBoxStyle.DropDown
                    cboModelsManufacturer.Enabled = True
                    cboModelsManufacturer.DropDownStyle = ComboBoxStyle.DropDownList
                    btnModelsSave.Enabled = True
                    btnModelsSave.Visible = True
                    btnModelsCancel.Visible = True
                    btnModelsView.Enabled = False
                    btnModelsRemove.Enabled = False
                    txtModelsDescription.ReadOnly = False
                    txtModelsPart.ReadOnly = False
                    cboModelsName.Focus()
                Case "Remove"
                    cboModelsName.Enabled = True
                    cboModelsName.DropDownStyle = ComboBoxStyle.DropDownList
                    cboModelsManufacturer.Enabled = True
                    cboModelsManufacturer.DropDownStyle = ComboBoxStyle.DropDownList
                    btnModelsSave.Enabled = True
                    btnModelsSave.Visible = True
                    btnModelsCancel.Visible = True
                    btnModelsView.Enabled = False
                    btnModelsAdd.Enabled = False
                    txtModelsDescription.ReadOnly = True
                    txtModelsPart.ReadOnly = True
                    cboModelsName.Focus()
                Case "Inactive"
                    cboModelsName.Enabled = False
                    cboModelsName.DropDownStyle = ComboBoxStyle.DropDownList
                    cboModelsManufacturer.Enabled = False
                    cboModelsManufacturer.DropDownStyle = ComboBoxStyle.DropDownList
                    btnModelsSave.Enabled = True
                    btnModelsSave.Visible = False
                    btnModelsCancel.Visible = False
                    btnModelsView.Enabled = True
                    btnModelsAdd.Enabled = True
                    btnModelsRemove.Enabled = True
                    txtModelsDescription.ReadOnly = True
                    txtModelsPart.ReadOnly = True
            End Select
        Catch ex As Exception
            MessageBox.Show("An error occured during transition. " & Err.Description, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnModelsView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModelsView.Click
        Try
            AdminActionMode = "View"
            SetModelsTab(AdminActionMode)
        Catch ex As Exception
            MessageBox.Show("An error occured during transition. " & Err.Description, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnModelsAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModelsAdd.Click
        Try
            AdminActionMode = "Add"
            SetModelsTab(AdminActionMode)
        Catch ex As Exception
            MessageBox.Show("An error occured during transition. " & Err.Description, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnModelsRemove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModelsRemove.Click
        Try
            AdminActionMode = "Remove"
            SetModelsTab(AdminActionMode)
        Catch ex As Exception
            MessageBox.Show("An error occured during transition. " & Err.Description, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnModelsCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModelsCancel.Click
        Try
            If MessageBox.Show("Cancel this entry?", "Cancel Add", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = Windows.Forms.DialogResult.Yes Then
                'Clear the controls on the tab.
                Dim c As Control = sender
                ResetControls(c.Parent)

                'Set focus
                btnModelsView.Focus()

                AdminActionMode = "Inactive"
                SetModelsTab(AdminActionMode)
            End If
        Catch ex As Exception
            MessageBox.Show("An error occured during cancellation. " & Err.Description, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub cboModelsManufacturer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboModelsManufacturer.Click
        Try
            If AdminActionMode = "Add" Then
                'Clear previous items.
                cboModelsManufacturer.Items.Clear()

                Dim tmpDT As New DataTable
                tmpDT = d1.GetAllManufacturerNames()

                Dim i As Integer = 0

                If tmpDT.Rows.Count > 0 Then
                    For i = 0 To tmpDT.Rows.Count - 1
                        cboModelsManufacturer.Items.Add(tmpDT.Rows(i).Item(0).ToString)
                    Next
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("An error occured retrieving manufacturers. " & Err.Description, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub cboModelsName_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboModelsName.Click
        Try
            If AdminActionMode = "View" Or AdminActionMode = "Remove" Then
                'Clear previous items.
                cboModelsName.Items.Clear()

                Dim tmpDT As New DataTable
                tmpDT = d1.GetAllModelNames()

                Dim i As Integer = 0

                If tmpDT.Rows.Count > 0 Then
                    For i = 0 To tmpDT.Rows.Count - 1
                        cboModelsName.Items.Add(tmpDT.Rows(i).Item(0).ToString)
                    Next
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("An error occured retrieving model information. " & Err.Description, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub cboModelsName_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboModelsName.SelectedIndexChanged
        Try
            'Display the model info for the selected model.
            Dim tmpDT As New DataTable
            tmpDT = d1.GetModel(cboModelsName.Text.Trim)

            txtModelsPart.Text = tmpDT.Rows(0).Item("PartNumber")
            cboModelsManufacturer.Items.Clear()
            cboModelsManufacturer.Items.Add(tmpDT.Rows(0).Item("CompanyName"))
            cboModelsManufacturer.SelectedIndex = 0
            txtModelsDescription.Text = tmpDT.Rows(0).Item("Description")
        Catch ex As Exception
            MessageBox.Show("An error occured retreiving model information. " & Err.Description, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnModelsSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModelsSave.Click
        Try
            Select Case AdminActionMode
                Case "Add"
                    'Validate input.
                    If cboModelsName.Text.Trim = "" Or txtModelsPart.Text.Trim = "" Or cboModelsManufacturer.Text.Trim = "" Or txtModelsDescription.Text.Trim = "" Then
                        MessageBox.Show("All fields must be filled in.", "Add Model", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        Exit Sub
                    End If

                    'Save the model.
                    If d1.InsertModel(cboModelsManufacturer.Text.Trim, txtModelsDescription.Text.Trim, cboModelsName.Text.Trim, txtModelsPart.Text.Trim) = 1 Then
                        MessageBox.Show("Model Added Successfully.", "Add Model", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        MessageBox.Show("Unable to Add Model. Either the Model exists or an error occured.", "Add Model", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                    ResetControls(tabModels)
                    AdminActionMode = "Inactive"
                    SetModelsTab(AdminActionMode)

                Case "Remove"
                    'Validate input.
                    If cboModelsName.Text.Trim = "" Then
                        MessageBox.Show("Please select a Model to remove.", "Remove Model", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        Exit Sub
                    End If

                    If MessageBox.Show("Remove the Model?", "Remove Model", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = Windows.Forms.DialogResult.Yes Then
                        'Delete the model.
                        d1.DeleteModel(cboModelsName.Text.Trim)
                        ResetControls(tabModels)
                        AdminActionMode = "Inactive"
                        SetModelsTab(AdminActionMode)
                        MessageBox.Show("Model was removed.", "Remove Model", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If

            End Select
        Catch ex As Exception
            MessageBox.Show("An error occured during save. " & Err.Description, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

#End Region

#Region "Locations"

    Private Sub SetLocationsTab(ByVal State As String)
        Try
            Select Case State
                Case "View"
                    cboLocationsLocation.Enabled = True
                    cboLocationsLocation.DropDownStyle = ComboBoxStyle.DropDownList
                    txtLocationsNotes.ReadOnly = True
                    btnLocationsSave.Enabled = False
                    btnLocationsSave.Visible = True
                    btnLocationsCancel.Visible = True
                    btnLocationsAdd.Enabled = False
                    btnLocationsRemove.Enabled = False
                    cboLocationsLocation.Focus()
                Case "Add"
                    cboLocationsLocation.Enabled = True
                    cboLocationsLocation.DropDownStyle = ComboBoxStyle.DropDown
                    txtLocationsNotes.ReadOnly = False
                    btnLocationsSave.Enabled = True
                    btnLocationsSave.Visible = True
                    btnLocationsCancel.Visible = True
                    btnLocationsView.Enabled = False
                    btnLocationsRemove.Enabled = False
                    cboLocationsLocation.Focus()
                Case "Remove"
                    cboLocationsLocation.Enabled = True
                    cboLocationsLocation.DropDownStyle = ComboBoxStyle.DropDownList
                    txtLocationsNotes.ReadOnly = True
                    btnLocationsSave.Enabled = True
                    btnLocationsSave.Visible = True
                    btnLocationsCancel.Visible = True
                    btnLocationsView.Enabled = False
                    btnLocationsAdd.Enabled = False
                    cboLocationsLocation.Focus()
                Case "Inactive"
                    cboLocationsLocation.Enabled = False
                    cboLocationsLocation.DropDownStyle = ComboBoxStyle.DropDownList
                    txtLocationsNotes.ReadOnly = True
                    btnLocationsSave.Enabled = True
                    btnLocationsSave.Visible = False
                    btnLocationsCancel.Visible = False
                    btnLocationsView.Enabled = True
                    btnLocationsAdd.Enabled = True
                    btnLocationsRemove.Enabled = True
            End Select
        Catch ex As Exception
            MessageBox.Show("An error occured during transition. " & Err.Description, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnLocationsCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLocationsCancel.Click
        Try
            If MessageBox.Show("Cancel this entry?", "Cancel Add", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = Windows.Forms.DialogResult.Yes Then
                'Clear the controls on the tab.
                Dim c As Control = sender
                ResetControls(c.Parent)

                'Set focus
                btnLocationsView.Focus()

                AdminActionMode = "Inactive"
                SetLocationsTab(AdminActionMode)
            End If
        Catch ex As Exception
            MessageBox.Show("An error occured during cancellation. " & Err.Description, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnLocationsView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLocationsView.Click
        Try
            AdminActionMode = "View"
            SetLocationsTab(AdminActionMode)
        Catch ex As Exception
            MessageBox.Show("An error occured during transition. " & Err.Description, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnLocationsAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLocationsAdd.Click
        Try
            AdminActionMode = "Add"
            SetLocationsTab(AdminActionMode)
        Catch ex As Exception
            MessageBox.Show("An error occured during transition. " & Err.Description, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnLocationsRemove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLocationsRemove.Click
        Try
            AdminActionMode = "Remove"
            SetLocationsTab(AdminActionMode)
        Catch ex As Exception
            MessageBox.Show("An error occured during transition. " & Err.Description, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub cboLocationsLocation_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboLocationsLocation.Click
        Try
            If AdminActionMode = "View" Or AdminActionMode = "Remove" Then
                'Clear previous items.
                cboLocationsLocation.Items.Clear()

                Dim tmpDT As New DataTable
                tmpDT = d1.GetAllLocationNames

                Dim i As Integer = 0

                If tmpDT.Rows.Count > 0 Then
                    For i = 0 To tmpDT.Rows.Count - 1
                        cboLocationsLocation.Items.Add(tmpDT.Rows(i).Item(0).ToString)
                    Next
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("An error occured retrieving locations. " & Err.Description, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub cboLocationsLocation_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboLocationsLocation.SelectedIndexChanged
        Try
            Dim tmpDT As New DataTable
            tmpDT = d1.GetLocation(cboLocationsLocation.Text.Trim)

            txtLocationsNotes.Text = tmpDT.Rows(0).Item("Notes").ToString
        Catch ex As Exception
            MessageBox.Show("An error occured loading location. " & Err.Description, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnLocationsSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLocationsSave.Click
        Try
            Select Case AdminActionMode
                Case "Add"
                    'Validate input.
                    If cboLocationsLocation.Text.Trim = "" Or txtLocationsNotes.Text.Trim = "" Then
                        MessageBox.Show("All fields must be filled in.", "Add Location", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        Exit Sub
                    End If

                    'Insert location into the database and set state.
                    If d1.InsertLocation(cboLocationsLocation.Text.Trim, txtLocationsNotes.Text.Trim) = 1 Then
                        MessageBox.Show("Location Added Successfully.", "Add Location", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        MessageBox.Show("Location not added. Either the Location exists or an error occured.", "Add Location", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                    ResetControls(tabLocations)
                    AdminActionMode = "Inactive"
                    SetLocationsTab(AdminActionMode)

                Case "Remove"
                    'Validate input.
                    If cboLocationsLocation.Text.Trim = "" Then
                        MessageBox.Show("Select a Location to remove.", "Remove Location", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        Exit Sub
                    End If

                    'Delete the location and set state.
                    If MessageBox.Show("Are you sure you want to remove this Location?", "Remove Location", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = Windows.Forms.DialogResult.Yes Then
                        d1.DeleteLocation(cboLocationsLocation.Text.Trim)
                        ResetControls(tabLocations)
                        AdminActionMode = "Inactive"
                        SetLocationsTab(AdminActionMode)
                        MessageBox.Show("Location was removed.", "Remove Location", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
            End Select
        Catch ex As Exception
            MessageBox.Show("An error occured during save. " & Err.Description, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

#End Region

#Region "Users"

    Private Sub SetUsersTab(ByVal State As String)
        Try
            Select Case State
                Case "View"
                    cboUsersLogin.Enabled = True
                    cboUsersLocation.Enabled = True
                    cboUsersPurpose.Enabled = True
                    cboUsersLogin.DropDownStyle = ComboBoxStyle.DropDownList
                    cboUsersLocation.DropDownStyle = ComboBoxStyle.DropDownList
                    cboUsersPurpose.DropDownStyle = ComboBoxStyle.DropDownList
                    txtUsersFirst.ReadOnly = True
                    txtUsersLast.ReadOnly = True
                    txtUsersPhone.ReadOnly = True
                    btnUsersSave.Visible = True
                    btnUsersCancel.Visible = True
                    btnUsersSave.Enabled = False
                    btnUsersAdd.Enabled = False
                    btnUsersEdit.Enabled = False
                    btnUsersRemove.Enabled = False
                    cboUsersLogin.Focus()
                Case "Add"
                    cboUsersLogin.Enabled = True
                    cboUsersLocation.Enabled = True
                    cboUsersPurpose.Enabled = True
                    cboUsersLogin.DropDownStyle = ComboBoxStyle.DropDown
                    cboUsersLocation.DropDownStyle = ComboBoxStyle.DropDownList
                    cboUsersPurpose.DropDownStyle = ComboBoxStyle.DropDownList
                    txtUsersFirst.ReadOnly = False
                    txtUsersLast.ReadOnly = False
                    txtUsersPhone.ReadOnly = False
                    btnUsersSave.Visible = True
                    btnUsersSave.Enabled = True
                    btnUsersCancel.Visible = True
                    btnUsersView.Enabled = False
                    btnUsersRemove.Enabled = False
                    btnUsersEdit.Enabled = False
                    cboUsersLogin.Focus()
                Case "Edit"
                    cboUsersLogin.Enabled = True
                    cboUsersLocation.Enabled = True
                    cboUsersPurpose.Enabled = True
                    cboUsersLogin.DropDownStyle = ComboBoxStyle.DropDownList
                    cboUsersLocation.DropDownStyle = ComboBoxStyle.DropDownList
                    cboUsersPurpose.DropDownStyle = ComboBoxStyle.DropDownList
                    txtUsersFirst.ReadOnly = False
                    txtUsersLast.ReadOnly = False
                    txtUsersPhone.ReadOnly = False
                    btnUsersSave.Visible = True
                    btnUsersSave.Enabled = True
                    btnUsersCancel.Visible = True
                    btnUsersAdd.Enabled = False
                    btnUsersRemove.Enabled = False
                    btnUsersView.Enabled = False
                    cboUsersLogin.Focus()
                Case "Remove"
                    cboUsersLogin.Enabled = True
                    cboUsersLocation.Enabled = True
                    cboUsersPurpose.Enabled = True
                    cboUsersLogin.DropDownStyle = ComboBoxStyle.DropDownList
                    cboUsersLocation.DropDownStyle = ComboBoxStyle.DropDownList
                    cboUsersPurpose.DropDownStyle = ComboBoxStyle.DropDownList
                    txtUsersFirst.ReadOnly = True
                    txtUsersLast.ReadOnly = True
                    txtUsersPhone.ReadOnly = True
                    btnUsersSave.Visible = True
                    btnUsersSave.Enabled = True
                    btnUsersCancel.Visible = True
                    btnUsersAdd.Enabled = False
                    btnUsersView.Enabled = False
                    btnUsersEdit.Enabled = False
                    cboUsersLogin.Focus()
                Case "Inactive"
                    cboUsersLogin.Enabled = False
                    cboUsersLocation.Enabled = False
                    cboUsersPurpose.Enabled = False
                    cboUsersLogin.DropDownStyle = ComboBoxStyle.DropDownList
                    cboUsersLocation.DropDownStyle = ComboBoxStyle.DropDownList
                    cboUsersPurpose.DropDownStyle = ComboBoxStyle.DropDownList
                    txtUsersFirst.ReadOnly = True
                    txtUsersLast.ReadOnly = True
                    txtUsersPhone.ReadOnly = True
                    btnUsersSave.Visible = False
                    btnUsersCancel.Visible = False
                    btnUsersSave.Enabled = True
                    btnUsersAdd.Enabled = True
                    btnUsersRemove.Enabled = True
                    btnUsersEdit.Enabled = True
                    btnUsersView.Enabled = True
            End Select
        Catch ex As Exception
            MessageBox.Show("An error occured during transition. " & Err.Description, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnUsersCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUsersCancel.Click
        Try
            If MessageBox.Show("Cancel this entry?", "Cancel Add", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = Windows.Forms.DialogResult.Yes Then
                'Clear the controls on the tab.
                Dim c As Control = sender
                ResetControls(c.Parent)

                'Set focus
                btnUsersView.Focus()

                AdminActionMode = "Inactive"
                SetUsersTab(AdminActionMode)
            End If
        Catch ex As Exception
            MessageBox.Show("An error occured during cancellation. " & Err.Description, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnUsersView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUsersView.Click
        Try
            AdminActionMode = "View"
            SetUsersTab(AdminActionMode)
        Catch ex As Exception
            MessageBox.Show("An error occured during transition. " & Err.Description, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnUsersEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUsersEdit.Click
        Try
            AdminActionMode = "Edit"
            SetUsersTab(AdminActionMode)
        Catch ex As Exception
            MessageBox.Show("An error occured during transition. " & Err.Description, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnUsersAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUsersAdd.Click
        Try
            AdminActionMode = "Add"
            SetUsersTab(AdminActionMode)
        Catch ex As Exception
            MessageBox.Show("An error occured during transition. " & Err.Description, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnUsersRemove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUsersRemove.Click
        Try
            AdminActionMode = "Remove"
            SetUsersTab(AdminActionMode)
        Catch ex As Exception
            MessageBox.Show("An error occured during transition. " & Err.Description, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub cboUsersLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboUsersLogin.Click
        Try
            If AdminActionMode = "View" Or AdminActionMode = "Remove" Or AdminActionMode = "Edit" Then
                'Clear previous items.
                cboUsersLogin.Items.Clear()

                Dim tmpDT As New DataTable
                tmpDT = d1.GetAllUsers

                Dim i As Integer = 0

                If tmpDT.Rows.Count > 0 Then
                    For i = 0 To tmpDT.Rows.Count - 1
                        cboUsersLogin.Items.Add(tmpDT.Rows(i).Item(0).ToString)
                    Next
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("An error occured retreiving users. " & Err.Description, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub cboUsersLocation_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboUsersLocation.Click
        Try
            If AdminActionMode = "Add" Or AdminActionMode = "Edit" Then
                'Clear previous items.
                cboUsersLocation.Items.Clear()

                Dim tmpDT As New DataTable
                tmpDT = d1.GetAllLocationNames

                Dim i As Integer = 0

                If tmpDT.Rows.Count > 0 Then
                    For i = 0 To tmpDT.Rows.Count - 1
                        cboUsersLocation.Items.Add(tmpDT.Rows(i).Item(0).ToString)
                    Next
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("An error occured retrieving locations. " & Err.Description, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub cboUsersPurpose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboUsersPurpose.Click
        Try
            If AdminActionMode = "Add" Or AdminActionMode = "Edit" Then
                'Clear previous items.
                cboUsersPurpose.Items.Clear()

                Dim tmpDT As New DataTable
                tmpDT = d1.GetAllPurpose

                Dim i As Integer = 0

                If tmpDT.Rows.Count > 0 Then
                    For i = 0 To tmpDT.Rows.Count - 1
                        cboUsersPurpose.Items.Add(tmpDT.Rows(i).Item(0).ToString)
                    Next
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("An error occured retreiving purposes. " & Err.Description, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub cboUsersLogin_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboUsersLogin.SelectedIndexChanged
        Try
            Dim tmpDT As New DataTable
            tmpDT = d1.GetUser(cboUsersLogin.Text.Trim)

            txtUsersFirst.Text = tmpDT.Rows(0).Item("FirstName")
            txtUsersLast.Text = tmpDT.Rows(0).Item("LastName")
            txtUsersPhone.Text = tmpDT.Rows(0).Item("PhoneNumber")

            cboUsersLocation.Items.Clear()
            cboUsersLocation.Items.Add(tmpDT.Rows(0).Item("LDescription"))
            cboUsersLocation.SelectedIndex = 0

            cboUsersPurpose.Items.Clear()
            cboUsersPurpose.Items.Add(tmpDT.Rows(0).Item("PDescription"))
            cboUsersPurpose.SelectedIndex = 0
        Catch ex As Exception
            MessageBox.Show("An error occured loading user. " & Err.Description, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnUsersSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUsersSave.Click
        Try
            Select Case AdminActionMode
                Case "Add"
                    'Validate input.
                    If cboUsersLogin.Text.Trim = "" Or txtUsersFirst.Text.Trim = "" Or txtUsersLast.Text.Trim = "" Or txtUsersPhone.Text.Trim = "" Or cboUsersLocation.Text.Trim = "" Or cboUsersPurpose.Text.Trim = "" Then
                        MessageBox.Show("All fields must be filled out.", "Add User", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        Exit Sub
                    End If

                    'Insert the user.
                    If d1.InsertUser(txtUsersFirst.Text.Trim, txtUsersLast.Text.Trim, txtUsersPhone.Text.Trim, cboUsersLogin.Text.Trim, cboUsersLocation.Text.Trim, cboUsersPurpose.Text.Trim) = 1 Then
                        MessageBox.Show("Users added successfully.", "Add User", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        MessageBox.Show("User was not added. The user may exist or an error occured.", "Add User", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If

                    ResetControls(tabUsers)
                    AdminActionMode = "Inactive"
                    SetUsersTab(AdminActionMode)

                Case "Edit"
                    'Validate input.
                    If cboUsersLogin.Text.Trim = "" Or txtUsersFirst.Text.Trim = "" Or txtUsersLast.Text.Trim = "" Or txtUsersPhone.Text.Trim = "" Or cboUsersLocation.Text.Trim = "" Or cboUsersPurpose.Text.Trim = "" Then
                        MessageBox.Show("All fields must be filled out.", "Edit User", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        Exit Sub
                    End If

                    'Update the user.
                    If d1.UpdateUser(txtUsersFirst.Text.Trim, txtUsersLast.Text.Trim, txtUsersPhone.Text.Trim, cboUsersLogin.Text.Trim, cboUsersLocation.Text.Trim, cboUsersPurpose.Text.Trim) = 1 Then
                        MessageBox.Show("User updated successfully.", "Edit User", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        MessageBox.Show("User was not updated. An error occured.", "Edit User", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If

                    ResetControls(tabUsers)
                    AdminActionMode = "Inactive"
                    SetUsersTab(AdminActionMode)

                Case "Remove"
                    'Validate input.
                    If cboUsersLogin.Text.Trim = "" Then
                        MessageBox.Show("Please select the user to remove.", "Remove User", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        Exit Sub
                    End If

                    'Delete the uesr.
                    If d1.DeleteUser(cboUsersLogin.Text.Trim) = 1 Then
                        MessageBox.Show("The user was removed successfully.", "Remove User", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        MessageBox.Show("The user was not removed. An error occured.", "Remove User", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If

                    ResetControls(tabUsers)
                    AdminActionMode = "Inactive"
                    SetUsersTab(AdminActionMode)
            End Select
        Catch ex As Exception
            MessageBox.Show("An error occured during save. " & Err.Description, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

#End Region

#End Region

End Class
