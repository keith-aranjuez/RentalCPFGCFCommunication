Imports System.Data.SqlClient
Imports System.Data

Public Class frmUpdate
    Private conn As String = "server=devmachine\sqldataserver; initial catalog=RENTAL; user=sa; password=sqldataserver;"
    REM Update concessionaire list for next month billing (Before actual billing to update list of concessionaire)
    Public Function updateConcessionaireList()
        Try
            'Dim forUpdatestrFirstDate As String = Format(DateSerial(cbYear.SelectedItem, cbMonth.SelectedValue, 1), "MM/dd/yyyy")
            'Dim forUpdatestrLastDate As String = Format(DateSerial(cbYear.SelectedItem, cbMonth.SelectedValue + 1, 0), "MM/dd/yyyy")

            'Dim prevFirstDate As String = Format(DateSerial(cbYear.SelectedItem, cbMonth.SelectedValue - 1, 1), "MM/dd/yyyy")
            'Dim prevLastDate As String = Format(DateSerial(cbYear.SelectedItem, cbMonth.SelectedValue, 0), "MM/dd/yyyy")

            'Dim billDate As String = Format(DateSerial(cbYear.SelectedItem, cbMonth.SelectedValue, 1), "MM/dd/yyyy")
            Dim forUpdatestrFirstDate As String = Format(DateSerial(selcbYear, selcbmonth, 1), "yyyy-MM-dd")
            Dim forUpdatestrLastDate As String = Format(DateSerial(selcbYear, selcbmonth + 1, 0), "yyyy-MM-dd")

            Dim prevFirstDate As String = Format(DateSerial(selcbYear, selcbmonth - 1, 1), "yyyy-MM-dd")
            Dim prevLastDate As String = Format(DateSerial(selcbYear, selcbmonth, 0), "yyyy-MM-dd")

            Dim billDate As String = Format(DateSerial(selcbYear, selcbmonth, 1), "MM/dd/yyyy")
            REM   MessageBox.Show(forUpdatestrFirstDate & " " & forUpdatestrLastDate & vbCrLf & prevFirstDate & " " & prevLastDate & vbCrLf & billDate)
            Using dbconn As New SqlConnection(conn)
                'Select all concessionaires from ConcessionRentalList where StartBillFlag="Yes" and StopBill="No"

                Dim stopLoopCount As Integer
                'REM FOR NORMALIZED DATABASE TABLES
                'Dim dbGet As New SqlDataAdapter("select concessionaireid, locrentalid, rentareasize, rentalamount from viewconcessionrentallist where startBillFlag='Yes' and stopBillFlag='No'", dbconn)

                '   @conc_name varchar(100),
                '@code varchar(50),
                '@concess varchar(100),
                '@class varchar(100),
                '@location varchar(100),
                '@area DECIMAL(10, 2),
                '@rate Decimal(10,2),
                '@loc_code varchar(100),
                '@acct_code varchar(100),
                '@rental decimal(10, 2),
                '@per_From datetime, 
                '@per_To datetime, 
                '@BillDate datetime, 
                '@Descp varchar(100),
                '@Adj1 decimal(10, 2),
                '@Adj2 decimal(10, 2),
                '@Adj3 decimal(10, 2),
                '@Adj4 decimal(10, 2),
                '@Adj5 decimal(10, 2),
                '@Acct1 varchar(100),
                '@Acct2 varchar(100),
                '@Acct3 varchar(100),
                '@Acct4 varchar(100),
                '@Acct5 varchar(100)


                'TODO: Check how stop billing is executed, assign a column for stop flag
                'Removed [Rental] field during billing update. Calculcation is performed at server side using stored proc [updateCurrentBilling]
                'Removed [BillDate] field during billing update. Date insertion performed at server side using updateCurrentBilling
                'Removed [Adj...] field during billing update. Update of [Adj...] value is performed at individual record update
                Dim conc_name As String = String.Empty
                Dim concessionaireId As String = String.Empty
                Dim code As String = String.Empty
                Dim concess As String = String.Empty
                Dim rclass, location, area, rate, loc_code, acct_code, per_from, per_to, descp, acct1, acct2, acct3, acct4, acct5 As String
                Dim stopFlag As Integer = 0
                Dim rentalIdCode As Integer
                Dim rentalRate As Decimal
                Dim rentAreaSize As Decimal
                Dim dbGet As New SqlDataAdapter("select conc_name, code, concess, class, location, area, rate, loc_code, acct_code, per_from, per_to, descp, acct1, acct2, acct3, acct4, acct5, stopflag from currentrental where per_From='" & prevFirstDate & "' and per_To='" & prevLastDate & "'", dbconn)
                Dim ds As New DataSet
                ds.Clear()
                dbGet.Fill(ds)
                stopLoopCount = ds.Tables(0).Rows.Count
                MessageBox.Show(stopLoopCount)
                For cntr = 0 To stopLoopCount - 1
                    TotalRentAmount = 0.0
                    Dim dbUpdateCurrentConcessionaire As New SqlCommand

                    concessionaireId = String.Empty
                    rentalRate = 0.0
                    rentAreaSize = 0.0
                    rentalIdCode = 0
                    With ds.Tables(0).DefaultView

                        'rentalIdCode = .Item(cntr).Item("locrentalid") -> FOR NORMALIZED DATABASE
                        'rentalRate = .Item(cntr).Item("rentalamount")-> FOR NORMALIZED DATABASE
                        'rentAreaSize = .Item(cntr).Item("rentareasize") -> FOR NORMALIZED DATABASE
                        conc_name = .Item(cntr).Item("conc_name")
                        concessionaireId = .Item(cntr).Item("code")
                        concess = .Item(cntr).Item("concess")
                        rclass = .Item(cntr).Item("class")
                        location = .Item(cntr).Item("location")
                        area = .Item(cntr).Item("area")
                        rate = .Item(cntr).Item("rate")
                        loc_code = .Item(cntr).Item("loc_code")
                        acct_code = .Item(cntr).Item("acct_code")
                        per_from = .Item(cntr).Item("per_from")
                        per_to = .Item(cntr).Item("per_to")
                        descp = .Item(cntr).Item("descp")
                        acct1 = .Item(cntr).Item("acct1")
                        acct2 = .Item(cntr).Item("acct2")
                        acct3 = .Item(cntr).Item("acct3")
                        acct4 = .Item(cntr).Item("acct4")
                        acct5 = .Item(cntr).Item("acct5")
                        stopFlag = .Item(cntr).Item("stopflag")
                    End With

                    '@conc_name varchar(100),
                    '@code varchar(50),
                    '@concess varchar(100),
                    '@class varchar(100),
                    '@location varchar(100),
                    '@area DECIMAL(10, 2),
                    '@rate Decimal(10,2),
                    '@loc_code varchar(100),
                    '@acct_code varchar(100),
                    '@per_From datetime, 
                    '@per_To datetime, 
                    '@Descp varchar(100),
                    '@Acct1 varchar(100),
                    '@Acct2 varchar(100),
                    '@Acct3 varchar(100),
                    '@Acct4 varchar(100),
                    '@Acct5 varchar(100),
                    With dbUpdateCurrentConcessionaire
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "UpdateCurrentBilling"
                        .Parameters.AddWithValue("@Month", selcbmonth)
                        .Parameters.AddWithValue("@Year", selcbYear)
                        .Parameters.AddWithValue("@code", concessionaireId)
                        .Parameters.AddWithValue("@conc_name", conc_name)
                        .Parameters.AddWithValue("@concess", concess)
                        .Parameters.AddWithValue("@class", rclass)
                        .Parameters.AddWithValue("@location", location)
                        .Parameters.AddWithValue("@area", area)
                        .Parameters.AddWithValue("@rate", rate)
                        .Parameters.AddWithValue("@loc_code", loc_code)
                        .Parameters.AddWithValue("@acct_code", acct_code)
                        .Parameters.AddWithValue("@per_From", forUpdatestrFirstDate)
                        .Parameters.AddWithValue("@per_To", forUpdatestrLastDate)
                        .Parameters.AddWithValue("@BillDate", billDate)
                        .Parameters.AddWithValue("@Descp", descp)
                        .Parameters.AddWithValue("@Acct1", acct1)
                        .Parameters.AddWithValue("@Acct2", acct2)
                        .Parameters.AddWithValue("@Acct3", acct3)
                        .Parameters.AddWithValue("@Acct4", acct4)
                        .Parameters.AddWithValue("@Acct5", acct5)
                        .Parameters.AddWithValue("@stopFlag", stopFlag)
                        dbconn.Open()
                        .Connection = dbconn
                        .ExecuteNonQuery()
                        dbconn.Close()
                    End With
                Next
                MessageBox.Show("Update complete for selected billing month.", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return 0
    End Function

    Private TotalRentAmount As Decimal = 0.0
    Public Property prTotalRentAmount() As Decimal
        Get
            Return TotalRentAmount
        End Get
        Set(ByVal value As Decimal)
            TotalRentAmount = value
        End Set
    End Property

    Private Function returnRentAmount(ByVal rentArea, ByVal rentRate) As Decimal
        Dim tempTotalAmount As Integer = 0.0
        tempTotalAmount = rentArea * rentRate
        Return tempTotalAmount
    End Function

    'Add year items to [Year Selection] 10 years
    Private Function fillUpYear()
        Dim tempYearNow As Integer = 0
        tempYearNow = Now.Year
        cbYear.Items.Clear()
        For cntr = tempYearNow To tempYearNow + 10
            cbYear.Items.Add(cntr)
        Next

        Dim tblMonth As New DataTable
        tblMonth.Clear()
        tblMonth.Columns.Add("intMonth")
        tblMonth.Columns.Add("stringMonth")

        tblMonth.Rows.Add(1, "January")
        tblMonth.Rows.Add(2, "February")
        tblMonth.Rows.Add(3, "March")
        tblMonth.Rows.Add(4, "April")
        tblMonth.Rows.Add(5, "May")
        tblMonth.Rows.Add(6, "June")
        tblMonth.Rows.Add(7, "July")
        tblMonth.Rows.Add(8, "August")
        tblMonth.Rows.Add(9, "September")
        tblMonth.Rows.Add(10, "October")
        tblMonth.Rows.Add(11, "November")
        tblMonth.Rows.Add(12, "December")

        cbMonth.Items.Clear()
        cbMonth.DataSource = tblMonth
        cbMonth.DisplayMember = "stringMonth"
        cbMonth.ValueMember = "intMonth"

        cbYear.SelectedIndex = 0
        Return 0

    End Function

    Private Sub frmUpdate_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        fillUpYear()
        chkCommunication.Text = "Communication"
        chkRental.Text = "Rental"
        chkCPF.Text = "Concessionaire's Privilege Fee"
    End Sub
    Private selcbYear As String = String.Empty
    Private selcbmonth As Integer = 0
    Private Sub btnUpdate_Click(sender As System.Object, e As System.EventArgs) Handles btnUpdate.Click
        selcbYear = cbYear.SelectedItem
        selcbmonth = cbMonth.SelectedValue
        bgWorkerRental.RunWorkerAsync()
        bgWorkerCommunication.RunWorkerAsync()
    End Sub

    Private Function updateCommunicationList()
        Try
            Dim forUpdatestrFirstDate As String = Format(DateSerial(selcbYear, selcbmonth, 1), "yyyy-MM-dd")
            Dim forUpdatestrLastDate As String = Format(DateSerial(selcbYear, selcbmonth + 1, 0), "yyyy-MM-dd")

            Dim prevFirstDate As String = Format(DateSerial(selcbYear, selcbmonth - 1, 1), "yyyy-MM-dd")
            Dim prevLastDate As String = Format(DateSerial(selcbYear, selcbmonth, 0), "yyyy-MM-dd")

            Dim billDate As String = Format(DateSerial(selcbYear, selcbmonth, 1), "MM/dd/yyyy")

            'MessageBox.Show(forUpdatestrFirstDate & " " & forUpdatestrLastDate & vbCrLf & prevFirstDate & " " & prevLastDate & vbCrLf & billDate)

            'Return 0
            'Exit Function
            Dim loopCounter As Integer = 0
            Dim ds As New DataSet
            Using dbconn As New SqlConnection(conn)
                Dim dbGet As New SqlDataAdapter("select conc_name, code, per_from, per_to, [type], cable, descp, nopair, [lineno], feature, deposit, acct_code, loc_code, location, amount, remark, ramount, eamount, ext, other, adj1, adj2, adj3, adj4, adj5, acct1, acct2, acct3, acct4, acct5, up_ba, stopbill from un_currentCommunicationRental where per_from ='" & prevFirstDate & "' and per_to = '" & prevLastDate & "'", dbconn)
                ds.Clear()
                dbGet.Fill(ds)
                loopCounter = ds.Tables(0).Rows.Count
            End Using
            Dim conc_name, code, per_from, per_to, type, cable, descp, nopair, lineno, feature, deposit, acct_code, loc_code, location As String
            Dim amount, remark, ramount, eamount, ext, other, adj1, adj2, adj3, adj4, adj5, acct1, acct2, acct3, acct4, acct5, up_ba, stopbill As String
            Using dbconn As New SqlConnection(conn)
                For cntr = 0 To loopCounter - 1
                    MessageBox.Show(billDate)
                    With ds.Tables(0).DefaultView
                        conc_name = .Item(cntr).Item("conc_name")
                        code = .Item(cntr).Item("code")
                        per_from = forUpdatestrFirstDate
                        per_to = forUpdatestrLastDate
                        type = .Item(cntr).Item("type")
                        cable = .Item(cntr).Item("cable")
                        descp = .Item(cntr).Item("descp")
                        nopair = .Item(cntr).Item("nopair")
                        lineno = .Item(cntr).Item("lineno")
                        feature = .Item(cntr).Item("feature")
                        deposit = .Item(cntr).Item("deposit")
                        acct_code = .Item(cntr).Item("acct_code")
                        loc_code = .Item(cntr).Item("loc_code")
                        location = .Item(cntr).Item("location")
                        billDate = billDate.Trim
                        amount = .Item(cntr).Item("amount")
                        remark = .Item(cntr).Item("remark")
                        ramount = .Item(cntr).Item("ramount")
                        eamount = .Item(cntr).Item("eamount")
                        ext = .Item(cntr).Item("ext")
                        other = .Item(cntr).Item("other")
                        adj1 = .Item(cntr).Item("adj1")
                        adj2 = .Item(cntr).Item("adj2")
                        adj3 = .Item(cntr).Item("adj3")
                        adj4 = .Item(cntr).Item("adj4")
                        adj5 = .Item(cntr).Item("adj5")
                        acct1 = .Item(cntr).Item("acct1")
                        acct2 = .Item(cntr).Item("acct2")
                        acct3 = .Item(cntr).Item("acct3")
                        acct4 = .Item(cntr).Item("acct4")
                        acct5 = .Item(cntr).Item("acct5")
                        up_ba = .Item(cntr).Item("up_ba")
                        stopbill = .Item(cntr).Item("stopbill")
                    End With
                    Dim dbUdpdate As New SqlCommand
                    With dbUdpdate
                        .Connection = dbconn
                        .CommandText = "UN_UPDATECOMMUNICATION"
                        .CommandType = CommandType.StoredProcedure
                        .Parameters.AddWithValue("@conc_name", conc_name)
                        .Parameters.AddWithValue("@code", code)
                        .Parameters.AddWithValue("@per_from", per_from)
                        .Parameters.AddWithValue("@per_to", per_from)
                        .Parameters.AddWithValue("@type", type)
                        .Parameters.AddWithValue("@cable", cable)
                        .Parameters.AddWithValue("@descp", descp)
                        .Parameters.AddWithValue("@noPair", nopair)
                        .Parameters.AddWithValue("@lineNo", lineno)
                        .Parameters.AddWithValue("@feature", feature)
                        .Parameters.AddWithValue("@deposit", deposit)
                        .Parameters.AddWithValue("@acct_code", acct_code)
                        .Parameters.AddWithValue("@loc_code", loc_code)
                        .Parameters.AddWithValue("@location", location)
                        .Parameters.AddWithValue("@billdate", billDate)
                        .Parameters.AddWithValue("@amount", amount)
                        .Parameters.AddWithValue("@remark", remark)
                        .Parameters.AddWithValue("@ramount", ramount)
                        .Parameters.AddWithValue("@eamount", eamount)
                        .Parameters.AddWithValue("@ext", ext)
                        .Parameters.AddWithValue("@other", other)
                        .Parameters.AddWithValue("@adj1", adj1)
                        .Parameters.AddWithValue("@adj2", 0.0)
                        .Parameters.AddWithValue("@adj3", 0.0)
                        .Parameters.AddWithValue("@adj4", 0.0)
                        .Parameters.AddWithValue("@adj5", 0.0)
                        .Parameters.AddWithValue("@acct1", acct1)
                        .Parameters.AddWithValue("@acct2", "")
                        .Parameters.AddWithValue("@acct3", "")
                        .Parameters.AddWithValue("@acct4", "")
                        .Parameters.AddWithValue("@acct5", "")
                        .Parameters.AddWithValue("@up_ba", "")
                        .Parameters.AddWithValue("@stopbillflag", stopbill)
                        dbconn.Open()
                        .ExecuteNonQuery()
                        dbconn.Close()
                    End With
                Next
            End Using
        Catch ex As Exception
            MessageBox.Show("Communication billing: " & vbCrLf & ex.ToString)
        End Try
        Return 0
    End Function

    Private Sub bgWorkerRental_DoWork(sender As System.Object, e As System.ComponentModel.DoWorkEventArgs) Handles bgWorkerRental.DoWork
        updateConcessionaireList()
    End Sub

    Private Sub bgWorkerRental_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bgWorkerRental.RunWorkerCompleted
        chkRental.Checked = True
        chkRental.Text = "Rental - Updated for bill period " & cbMonth.Text & "  " & cbYear.Text
    End Sub

    Private Sub bgWorkerCommunication_DoWork(sender As System.Object, e As System.ComponentModel.DoWorkEventArgs) Handles bgWorkerCommunication.DoWork
        updateCommunicationList()
    End Sub

    Private Sub bgWorkerCommunication_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bgWorkerCommunication.RunWorkerCompleted
        chkCommunication.Checked = True
        chkCommunication.Text = "Communication - Updated for bill period " & cbMonth.Text & "  " & cbYear.Text
    End Sub
End Class