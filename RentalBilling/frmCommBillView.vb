Imports System.Data.SqlClient
Imports System.Data
Imports Microsoft.VisualBasic

'TODO : UPDATE BILLDATE WHEN FINISHED SETTING UP BILLSELECTION COMBOBOX
'TODO : Revise storedproc to setup billdate where billdate=selected combobox value
Public Class frmCommBillView
    Private conn As String = "server=devmachine\sqldataserver; initial catalog=RENTAL; user=sa; password=sqldataserver;"
    Private concessionId As String = String.Empty
    Public Property ConcessionaireId() As String
        Get
            Return concessionId
        End Get
        Set(ByVal value As String)
            concessionId = value
        End Set
    End Property

    Private currStopFlag As Integer
    Public Property recordStopFlag() As Integer
        Get
            Return currStopFlag
        End Get
        Set(ByVal value As Integer)
            currStopFlag = value
        End Set
    End Property

    Private currentRentRecordNo As String
    Public Property currentRentRecordId() As String
        Get
            Return currentRentRecordNo
        End Get
        Set(ByVal value As String)
            currentRentRecordNo = value
        End Set
    End Property

    Private rentId As Integer = 0
    Public Property concessionaireRentalId() As Integer
        Get
            Return rentId
        End Get
        Set(ByVal value As Integer)
            rentId = value
        End Set
    End Property


    Private currentCounter As Integer
    Public Property currentIndex() As String
        Get
            Return currentCounter
        End Get
        Set(ByVal value As String)
            currentCounter = value
        End Set
    End Property

    Private onloadMaxRows As Integer
    Private ds As DataSet
    Private Function getCurrentConcessionaireData(Optional ByVal indexCounter As Integer = 0, Optional ByVal SearchString As String = "")
        Dim noOfRecords As Integer = 0
        Try
            Using dbconn As New SqlConnection(conn)
                'For normalized database 
                'Dim dbGet As New SqlDataAdapter("select locrentalid, concessionaireid, concessionairename, rentaltype, terminalareadescription + ' ' + areadescription as locationdescription, rentsizearea, rentalrate, rentfrom, rentto, rentalamount, rentaladjustmentamount, adjustmentnote from viewcurrentconcessionaires", dbconn)
                'For unnormalized database 
                Dim sqlString As String = String.Empty
                'sqlString = "select recordno, conc_name, code, concess, class, location, area, rate, loc_code, acct_code, rental, per_from, per_to, billdate, descp, adj1, stopflag from currentrental order by conc_name where billdate='" & cbBillDate.SelectedValue.ToString.Trim & "'"
                If cbSearchSelector.Text = "Starts with" Then
                    sqlString = "SELECT RecordNo, Conc_Name, Code, Per_From ,Per_To, Type, Cable, Descp, NoPair, [LineNo], Feature, Deposit, Acct_Code, Loc_Code, Location, BillDate, Amount, Remark, RAmount, EAmount, Ext, Other, Adj1, Adj2, Adj3, Adj4 ,Adj5, Acct1, Acct2, Acct3, Acct4, Acct5, Up_Ba, StopBill FROM un_currentCommunicationRental where conc_name like '" & txtSearch.Text.Trim.Replace("'", "") & "%' and billdate like '" & cbBillDate.Text.ToString.Trim & "' order by conc_name "
                ElseIf cbSearchSelector.Text = "Contains" Then
                    sqlString = "SELECT RecordNo, Conc_Name, Code, Per_From ,Per_To, Type, Cable, Descp, NoPair, [LineNo], Feature, Deposit, Acct_Code, Loc_Code, Location, BillDate, Amount, Remark, RAmount, EAmount, Ext, Other, Adj1, Adj2, Adj3, Adj4 ,Adj5, Acct1, Acct2, Acct3, Acct4, Acct5, Up_Ba, StopBill FROM un_currentCommunicationRental where conc_name like '%" & txtSearch.Text.Trim.Replace("'", "") & "%' and billdate like '" & cbBillDate.Text.ToString.Trim & "' order by conc_name "
                ElseIf cbSearchSelector.Text = "Ends with" Then
                    sqlString = "SELECT RecordNo, Conc_Name, Code, Per_From ,Per_To, Type, Cable, Descp, NoPair, [LineNo], Feature, Deposit, Acct_Code, Loc_Code, Location, BillDate, Amount, Remark, RAmount, EAmount, Ext, Other, Adj1, Adj2, Adj3, Adj4 ,Adj5, Acct1, Acct2, Acct3, Acct4, Acct5, Up_Ba, StopBill FROM un_currentCommunicationRental where conc_name like '%" & txtSearch.Text.Trim.Replace("'", "") & "' and billdate like '" & cbBillDate.Text.ToString.Trim & "' order by conc_name "
                End If
                Dim dbGet As New SqlDataAdapter(sqlString, dbconn)
                ds = New DataSet
                ds.Clear()
                dbGet.Fill(ds)
                onloadMaxRows = ds.Tables(0).Rows.Count
                If ds.Tables(0).Rows.Count > 0 Then
                    With ds.Tables(0).DefaultView
                        currentRentRecordNo = .Item(indexCounter).Item("recordno")
                        lblConcessionaireName.Text = .Item(indexCounter).Item("conc_name")
                        txtConcessionaireCode.Text = .Item(indexCounter).Item("code")
                        lblRentalLocation.Text = .Item(indexCounter).Item("location")
                        lblPeriodFrom.Text = .Item(indexCounter).Item("per_from")
                        lblPeriodTo.Text = .Item(indexCounter).Item("per_to")
                        txtType.Text = .Item(indexCounter).Item("Type")
                        selectedRate = .Item(indexCounter).Item("ramount")
                        txtNoOfItems.Text = .Item(indexCounter).Item("NoPair")
                        txtCable.Text = .Item(indexCounter).Item("cable")
                        txtFeatures.Text = .Item(indexCounter).Item("feature")
                        txtDescription.Text = .Item(indexCounter).Item("descp")
                        txtRemarks.Text = .Item(indexCounter).Item("remark")
                        txtLineNumber.Text = .Item(indexCounter).Item("lineno")
                        txtDeposit.Text = .Item(indexCounter).Item("deposit")








                    End With
                Else
                    MessageBox.Show(ds.Tables(0).Rows.Count)
                    Return 0
                    Exit Function
                End If
            End Using
        Catch ex As Exception
            'MessageBox.Show(ex.ToString)
            Return 0
            Exit Function
        End Try

        Return 0
    End Function

    Private Sub frmBillView_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F2 Then
            btnAddBilling.PerformClick()
        ElseIf e.KeyCode = Keys.F3 Then
            btnUpdateBilling.PerformClick()
        ElseIf e.KeyCode = Keys.F4 Then
            btnStopBill.PerformClick()
        ElseIf e.KeyCode = Keys.Home Then
            btnFirst.PerformClick()
        ElseIf e.KeyCode = Keys.End Then
            btnLast.PerformClick()
        ElseIf e.KeyCode = Keys.PageUp Then
            btnNext.PerformClick()
        ElseIf e.KeyCode = Keys.PageDown Then
            btnPrevious.PerformClick()
        End If
    End Sub

    Private Sub frmBillView_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        disableTxtInGroup()
        returnUniqueBillingDates()
        loadSelector()
        cbSearchSelector.SelectedIndex = 0
        clear()
        getCurrentConcessionaireData(0)
        currentCounter = 0
        checkStopFlag()
    End Sub

    REM Check StopFlag
    Private Sub checkStopFlag()
        Dim recNo As Integer = 0
        recNo = recordStopFlag
        If recNo = 0 Then
            btnStopBill.Text = "F4 - Delete"
            lblStopFlag.Text = "[UNDELETED]"
        ElseIf recNo = 1 Then
            lblStopFlag.Text = "[DELETED]"
            btnStopBill.Text = "F4 - Undelete"
        End If
    End Sub

    Private Sub btnNext_Click(sender As System.Object, e As System.EventArgs) Handles btnNext.Click
        If currentCounter = onloadMaxRows - 1 Then
            MessageBox.Show("No next record!", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            REM For normalized database schema  updateAdjustment()
            currentCounter += 1
            clear()
            getCurrentConcessionaireData(currentCounter)
            checkStopFlag()
        End If
    End Sub

    Private Sub btnFirst_Click(sender As System.Object, e As System.EventArgs) Handles btnFirst.Click
        REM For normalized database schema updateAdjustment()
        clear()
        currentCounter = 0
        getCurrentConcessionaireData(0)
        checkStopFlag()
    End Sub

    Private Sub btnPrevious_Click(sender As System.Object, e As System.EventArgs) Handles btnPrevious.Click
        If currentCounter = 0 Then
            MessageBox.Show("No previous record!", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            REM For normalized database schema updateAdjustment()
            currentCounter -= 1
            clear()
            getCurrentConcessionaireData(currentCounter)
            checkStopFlag()
        End If
    End Sub


    Private Sub btnLast_Click(sender As System.Object, e As System.EventArgs) Handles btnLast.Click
        REM For normalized database schema updateAdjustment()
        currentCounter = onloadMaxRows - 1
        getCurrentConcessionaireData(currentCounter)
        'MessageBox.Show(currentRentRecordId)
        checkStopFlag()
    End Sub

    Private Sub clear()
        lblConcessionaireName.Text = String.Empty
        '  lblPeriodFrom.Text = String.Empty
        ' lblPeriodTo.Text = String.Empty
        txtType.Text = String.Empty
        txtRemarks.Clear()
        lblAccountCode.Text = String.Empty
        txtConcessionaireCode.Clear()
        txtAdjustmentCode.Clear()
    End Sub

    REM For normalized database schema
    'Update rental adjustment and rental adjustment note if any
    'Update current record [UpdateAdjustment] before proceeding to [First], [Previous], [Next], [Last]
    Private Function updateAdjustment()
        REM Dim billDate As String = Format(DateSerial(Today.Year, Today.Month + 1, 1), "MM/dd/yyyy")
        Dim billDate As String = cbBillDate.SelectedValue.ToString
        Try
            Using dbconn As New SqlConnection(conn)
                Dim dbUpdate As New SqlCommand
                With dbUpdate
                    .CommandType = CommandType.StoredProcedure
                    REM For normalized schema .CommandText = "updateCurrentRentalAdjustment"
                    .CommandText = "unUpdateCurrentBillingInformation"
                    .Connection = dbconn
                    REM For normalized database schema
                    '.Parameters.AddWithValue("@DateFrom", lblPeriodFrom.Text.Trim)
                    '.Parameters.AddWithValue("@DateTo", lblPeriodTo.Text.Trim)
                    '.Parameters.AddWithValue("@ConcessionaireId", ConcessionaireId)
                    '.Parameters.AddWithValue("@RentalLocationId", concessionaireRentalId)
                    '.Parameters.AddWithValue("@TotalRentAmountWithoutAdjustment", lblRentCharge.Text)
                    '.Parameters.AddWithValue("@RentalAdjustment", txtAdjustmentAmount.Text.Trim.Replace("'", ""))
                    REM END 
                    .Parameters.AddWithValue("@recordno", currentRentRecordId)
                    dbconn.Open()
                    .ExecuteNonQuery()
                    dbconn.Close()
                    MessageBox.Show("Record updated!", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End With
                checkStopFlag()
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
        Return 0
    End Function

    Private Sub txtSearch_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtSearch.TextChanged
        clear()
        getCurrentConcessionaireData(0)
        onloadMaxRows = ds.Tables(0).Rows.Count
        'MessageBox.Show(onloadMaxRows)

    End Sub

    Private Sub loadSelector()
        With cbSearchSelector
            .Items.Add("Starts with")
            .Items.Add("Contains")
            .Items.Add("Ends with")
        End With
    End Sub

    Private Sub btnUpdateBilling_Click(sender As System.Object, e As System.EventArgs) Handles btnUpdateBilling.Click
        If btnUpdateBilling.Text = "F3 - Change" Then
            enableTxtInGroup()
            btnAddBilling.Enabled = False
            btnStopBill.Enabled = False
            btnUpdateBilling.Text = "F3 - Save"
        ElseIf btnUpdateBilling.Text = "F3 - Save" Then
            updateAdjustment()
            disableTxtInGroup()
            btnAddBilling.Enabled = True
            btnStopBill.Enabled = True
            btnUpdateBilling.Text = "F3 - Change"
        End If
    End Sub

    Private Sub btnStopBill_Click(sender As System.Object, e As System.EventArgs) Handles btnStopBill.Click
        Try
            Using dbconn As New SqlConnection(conn)
                Dim dbUpdate As New SqlCommand
                With dbUpdate
                    .CommandType = CommandType.StoredProcedure
                    .CommandText = "updateStopBillingFlag"
                    .Connection = dbconn
                    .Parameters.AddWithValue("@RecordNo", currentRentRecordId)
                    .Parameters.AddWithValue("@ConcessionCode", txtConcessionaireCode.Text.Trim.Replace("'", ""))
                    .Parameters.AddWithValue("@ConcessionName", lblConcessionaireName.Text.Trim.Replace("'", ""))
                    .Parameters.AddWithValue("@Per_From", lblPeriodFrom.Text.Trim)
                    .Parameters.AddWithValue("@Per_To", lblPeriodTo.Text.Trim)
                    If recordStopFlag = 1 Then
                        .Parameters.AddWithValue("@StopFlag", 0)
                    ElseIf recordStopFlag = 0 Then
                        .Parameters.AddWithValue("@StopFlag", 1)
                    End If
                    dbconn.Open()
                    .ExecuteNonQuery()
                    dbconn.Close()
                    getCurrentConcessionaireData(currentCounter)
                    checkStopFlag()
                End With
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub
    Private Function returnUniqueBillingDates()
        Try
            Using dbconn As New SqlConnection(conn)
                Dim dbGet As New SqlDataAdapter("select distinct billdate from un_currentcommunicationrental order by billdate", dbconn)
                Dim ds As New DataSet
                ds.Clear()
                dbGet.Fill(ds)
                With cbBillDate
                    .DataSource = ds.Tables(0).DefaultView
                    .DisplayMember = "BillDate"
                    .ValueMember = "BillDate"
                End With
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return 0
    End Function

    Public Sub ClearTextBox(parent As Control)
        For Each child As Control In parent.Controls
            ClearTextBox(child)
        Next
        If TryCast(parent, TextBox) IsNot Nothing Then
            TryCast(parent, TextBox).Text = [String].Empty
        End If
    End Sub

    Sub disableTxtInGroup()
        For Each c As Control In Me.GroupBox1.Controls
            If TypeOf (c) Is TextBox Then
                c.Enabled = False
            End If
        Next
    End Sub

    Sub enableTxtInGroup()
        For Each c As Control In Me.GroupBox1.Controls
            If TypeOf (c) Is TextBox Then
                c.Enabled = True
            End If
        Next
    End Sub

    Private Sub btnAddBilling_Click(sender As System.Object, e As System.EventArgs) Handles btnAddBilling.Click
        'TODO : ADD NEW RENTAL FROM CONCESSIONAIRE 
        REM SELECTABLE FIELDS =CONCESSIONAIRE USING CONCESSIONAIRECODE TEXTBOX
        REM SELECTABLE FIELDS =ACCOUNT NUMBER USING ACCOUNTTEXTBOX
        If btnAddBilling.Text = "F2 - Add" Then
            REM Clear textboxes for editing
            Dim conBillDate As DateTime = Convert.ToDateTime(cbBillDate.Text)
            Dim endOfBillDate As DateTime = conBillDate.AddDays(-(conBillDate.Day - 1)).AddMonths(1).AddDays(-1)
            lblPeriodFrom.Text = conBillDate
            lblPeriodTo.Text = endOfBillDate
            btnAddBilling.Text = "F2 - Save"
        ElseIf btnAddBilling.Text = "F2 - Save" Then
            REM Save new concessionaire
            Dim billDate As String = Format(DateSerial(Today.Year, Today.Month + 1, 1), "MM/dd/yyyy")
            ' Exit Sub
            Try
                Using dbconn As New SqlConnection(conn)
                    Dim dbUpdate As New SqlCommand
                    With dbUpdate
                        .CommandType = CommandType.StoredProcedure
                        REM For normalized schema .CommandText = "updateCurrentRentalAdjustment"
                        .CommandText = "newconcessionaire"
                        .Connection = dbconn
                        REM For normalized database schema
                        '.Parameters.AddWithValue("@DateFrom", lblPeriodFrom.Text.Trim)
                        '.Parameters.AddWithValue("@DateTo", lblPeriodTo.Text.Trim)
                        '.Parameters.AddWithValue("@ConcessionaireId", ConcessionaireId)
                        '.Parameters.AddWithValue("@RentalLocationId", concessionaireRentalId)
                        '.Parameters.AddWithValue("@TotalRentAmountWithoutAdjustment", lblRentCharge.Text)
                        '.Parameters.AddWithValue("@RentalAdjustment", txtAdjustmentAmount.Text.Trim.Replace("'", ""))
                        REM END 
                        Dim totalRent As Decimal = 0
                        .Parameters.AddWithValue("@Conc_Name", lblConcessionaireName.Text.Trim.Replace("'", ""))
                        .Parameters.AddWithValue("@Code", txtConcessionaireCode.Text.Trim.Replace("'", ""))

                        .Parameters.AddWithValue("@Adj1", txtRemarks.Text.Trim.Replace("'", ""))
                        .Parameters.AddWithValue("@Adj2", 0.0)
                        .Parameters.AddWithValue("@Adj3", 0.0)
                        .Parameters.AddWithValue("@Adj4", 0.0)
                        .Parameters.AddWithValue("@Adj5", 0.0)
                        .Parameters.AddWithValue("@Acct1", txtAdjustmentCode.Text.Trim.Replace("'", ""))
                        .Parameters.AddWithValue("@Acct2", "")
                        .Parameters.AddWithValue("@Acct3", "")
                        .Parameters.AddWithValue("@Acct4", "")
                        .Parameters.AddWithValue("@Acct5", "")
                        dbconn.Open()
                        ' .ExecuteNonQuery()
                        dbconn.Close()
                        MessageBox.Show("New concessionaire information added.", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End With
                    checkStopFlag()
                    disableTxtInGroup()
                    btnAddBilling.Text = "F2 - Add"
                    btnUpdateBilling.Enabled = True
                    btnStopBill.Enabled = True
                End Using
            Catch ex As Exception
                MessageBox.Show(ex.ToString)
            End Try

        End If
    End Sub

    Public selectedConcCode As String
    Public Property selectedNewConCode() As String
        Get
            Return selectedConcCode
        End Get
        Set(ByVal value As String)
            selectedConcCode = value
        End Set
    End Property

    Private Sub frmBillView_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress

        If txtConcessionaireCode.Focused = True Then
            If e.KeyChar = ChrW(Keys.Return) Then
                frmConcessionaireSelect.ShowDialog()
            End If
        ElseIf lblAccountCode.Focused = True Then
            If e.KeyChar = ChrW(Keys.Return) Then
                frmAccounts.ShowDialog()
            End If
        ElseIf txtAdjustmentCode.Focused = True Then
            If e.KeyChar = ChrW(Keys.Return) Then
                frmAccounts.ShowDialog()
            End If
        ElseIf txtType.Focused = True Then
            If e.KeyChar = ChrW(Keys.Return) Or e.KeyChar = ChrW(Keys.Enter) Then
                frmCommBillType.ShowDialog()
            End If
        End If

    End Sub

    Public Sub getConcessionaireDetails(ByVal concessionaireid As String)
        Try
            Using dbconn As New SqlConnection(conn)
                Dim dbGet As New SqlDataAdapter("select concessionairename from concessionaires where concessionaireid='" & concessionaireid.Trim.Replace("'", "") & "'", dbconn)
                Dim ds As New DataSet
                ds.Clear()
                dbGet.Fill(ds)
                With ds.Tables(0).DefaultView
                    lblConcessionaireName.Text = .Item(0).Item("concessionairename")
                End With
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Function calcRental(ByVal rate As String, ByVal area As String) As String
        Dim tempTotal As Decimal = 0
        Try
            tempTotal = Convert.ToDecimal(rate) * Convert.ToDecimal(area)
        Catch ex As Exception
            Return 0
            Exit Function
        End Try
        Return tempTotal
    End Function

    Private Sub lblRentalArea_TextChanged(sender As System.Object, e As System.EventArgs)
        ' lblRentCharge.Text = calcRental(lblRentalArea.Text, lblRentalRate.Text.Trim)
    End Sub

    Private Sub lblRentalRate_TextChanged(sender As System.Object, e As System.EventArgs)
        'txtType.Text = calcRental(lblRentalArea.Text, lblRentalRate.Text.Trim)
    End Sub

    Private Sub cbBillDate_SelectedValueChanged(sender As Object, e As System.EventArgs) Handles cbBillDate.SelectedValueChanged
        btnAddBilling.Text = "F2 - Add"
        clear()
        disableTxtInGroup()
        getCurrentConcessionaireData()
        checkStopFlag()
    End Sub

    Private billRate As Decimal = 0.0
    Public Property selectedRate() As Decimal
        Get
            Return billRate
        End Get
        Set(ByVal value As Decimal)
            billRate = value
        End Set
    End Property

    Private selType As String
    Public Property selectedBillType() As String
        Get
            Return selType
        End Get
        Set(ByVal value As String)
            selType = value
        End Set
    End Property


End Class