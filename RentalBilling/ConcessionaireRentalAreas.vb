Option Strict Off

Imports System.Data.SqlClient
Imports System.Data

Public Class ConcessionaireRentalAreas
    Private conn As String = "server=devmachine\sqldataserver; initial catalog=RENTAL; user=sa; password=sqldataserver;"

    Private Function returnConcessionaires() As String
        Try
            Using dbconn As New SqlConnection(conn)
                Dim dbGet As New SqlDataAdapter("select concessionaireid, concessionairename from concessionaires", dbconn)
                Dim ds As New DataSet
                ds.Clear()
                dbGet.Fill(ds)
                With cbConcessionaires
                    .DataSource = ds.Tables(0).DefaultView
                    .DisplayMember = "concessionairename"
                    .ValueMember = "concessionaireid"
                End With
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
        Return CStr(0)
    End Function

    Private Function returnRentalAreasMajor() As String
        Try
            Using dbconn As New SqlConnection(conn)
                Dim dbGet As New SqlDataAdapter("select terminalareadescription, terminalareaid from terminalareas", dbconn)
                Dim ds As New DataSet
                ds.Clear()
                dbGet.Fill(ds)
                With cbRentalLocation
                    .DataSource = ds.Tables(0).DefaultView
                    .DisplayMember = "TerminalAreaDescription"
                    .ValueMember = "TerminalAreaId"
                End With
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
        Return CStr(0)
    End Function

    Private Function returnRentalAreasIntermediate() As String
        Try
            Using dbconn As New SqlConnection(conn)
                Dim dbGet As New SqlDataAdapter("select intermediaterentalareaid, areadescription from rentalareasperterminal order by areadescription asc", dbconn)
                Dim ds As New DataSet
                ds.Clear()
                dbGet.Fill(ds)
                With cbRentalLocationArea
                    .DataSource = ds.Tables(0).DefaultView
                    .ValueMember = "IntermediateRentalAreaId"
                    .DisplayMember = "AreaDescription"
                End With
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
        Return CStr(0)
    End Function

    Private Function returnRentalType() As String

        Try
            Using dbconn As New SqlConnection(conn)
                Dim dbGet As New SqlDataAdapter("select rentaltypeid, rentaltype from rentaltype order by rentaltype asc", dbconn)
                Dim ds As New DataSet
                ds.Clear()
                dbGet.Fill(ds)
                With cbRentalType
                    .DataSource = ds.Tables(0).DefaultView
                    .DisplayMember = "RentalType"
                    .ValueMember = "RentalTypeId"
                End With
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
        Return CStr(0)
    End Function

    Private Function loadConcessionaireRentalDetails(ByVal concessionaireId As String) As String
        Try
            Using dbconn As New SqlConnection(conn)
                Dim dbGet As New SqlDataAdapter("select * from concessionrentallist where concessionaireid='" & concessionaireId & "'", dbconn)
                Dim ds As New DataSet
                ds.Clear()
                dbGet.Fill(ds)
                With gvConcessionaireDetails
                    If ds.Tables(0).Rows.Count > 0 Then
                        .DataSource = ds.Tables(0).DefaultView
                        .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
                    Else
                        .DataSource = Nothing
                        .Rows.Clear()
                    End If
                End With
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
        Return CStr(0)
    End Function

    Private concessionDetail As String = String.Empty
    Private Function returnConcessionDetails(ByVal concessionid As String) As String
        If Not IsNothing(concessionid) Then
            Try
                Using dbconn As New SqlConnection(conn)
                    Dim dbGet As New SqlDataAdapter("select concessionaireid, concessionairename from concessionaires where concessionaireid='" & CStr(concessionid).Trim & "'", dbconn)
                    Dim ds As New DataSet
                    ds.Clear()
                    dbGet.Fill(ds)
                    concessionDetail = CStr(ds.Tables(0).DefaultView.Item(0).Item(0)).Trim & "-" & CStr(ds.Tables(0).DefaultView.Item(0).Item(1)).Trim
                End Using
            Catch ex As Exception
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End Try
        Else
            concessionDetail = Nothing
        End If
        Return concessionDetail
    End Function

    Private Sub ConcessionaireRentalAreas_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        returnConcessionaires()
        returnRentalAreasMajor()
        returnRentalAreasIntermediate()
        returnRentalType()
        loadConcessionaireRentalDetails(cbConcessionaires.SelectedValue.ToString)
        cbRentalLocation.SelectedIndex = 0
        cbRentalLocationArea.SelectedIndex = 0
        cbRentalType.SelectedIndex = 0
    End Sub

    Private Sub cbConcessionaires_SelectedValueChanged(sender As Object, e As System.EventArgs) Handles cbConcessionaires.SelectedValueChanged
        Try
            Dim conName As String = returnConcessionDetails(CStr(cbConcessionaires.SelectedValue))
            lblConcessionId.Text = conName.Split(CChar("-"))(0)
            lblConcessionName.Text = conName.Split(CChar("-"))(1)
            loadConcessionaireRentalDetails(CStr(cbConcessionaires.SelectedValue))
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub

    Private rentRateId As String
    Public Property rentalRateperLocationId() As String
        Get
            Return rentRateId
        End Get
        Set(ByVal value As String)
            rentRateId = value
        End Set
    End Property

    Private Sub returnRate(ByVal terminalId, ByVal intermediateAreaid, ByVal rentalTypeId)
        Try
            txtRentalRate.Clear()
            txtRentalUnit.Clear()
            rentRateId = String.Empty
            Dim rentalRate As Decimal = CType(0.0, Decimal)
            Dim returnRateUnit As String = String.Empty
            Using dbconn As New SqlConnection(conn)
                Dim dbGet As New SqlDataAdapter("select locrentalid, rentalamount, rentalunit, rentalfrequency from rentalrateperlocation where terminalareaid= " & terminalId & " and IntermediateRentalAreaId= " & intermediateAreaid & " and rentaltypeid=" & rentalTypeId & "", dbconn)
                Dim ds As New DataSet
                ds.Clear()
                dbGet.Fill(ds)
                rentalRate = CDec(ds.Tables(0).DefaultView.Item(0).Item("rentalamount"))
                returnRateUnit = CStr(ds.Tables(0).DefaultView.Item(0).Item("rentalunit"))
                rentRateId = CInt(ds.Tables(0).DefaultView.Item(0).Item("locrentalid"))
                txtRentalRate.Text = "P " & CStr(rentalRate)
                txtRentalUnit.Text = CStr(returnRateUnit)
            End Using
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub

    Private Sub cbRentalType_SelectedValueChanged(sender As Object, e As System.EventArgs) Handles cbRentalType.SelectedValueChanged
        returnRate(CInt(cbRentalLocation.SelectedValue), CInt(cbRentalLocationArea.SelectedValue), cbRentalType.SelectedValue)
    End Sub

    Private Sub btnAdd_Click(sender As System.Object, e As System.EventArgs) Handles btnAdd.Click
        newConcessionRentBill()
    End Sub

    Private Function newConcessionRentBill()
        Try
            Using dbconn As New SqlConnection(conn)
                Dim dbNewConcessionRental As New SqlCommand
                With dbNewConcessionRental
                    .CommandType = CommandType.StoredProcedure
                    .CommandText = "NewConcessionaireRentalList"
                    .Parameters.AddWithValue("@StartBillCode", txtStartBillCode.Text.Trim.Replace("'", ""))
                    .Parameters.AddWithValue("@CreatedBillDate", Now.ToShortDateString)
                    .Parameters.AddWithValue("@StartBillDate", Now.ToShortDateString)
                    .Parameters.AddWithValue("@StopBillDate", String.Empty)
                    .Parameters.AddWithValue("@ConcessionaireId", cbConcessionaires.SelectedValue.ToString.Trim)
                    .Parameters.AddWithValue("@LocRentalId", rentRateId)
                    .Parameters.AddWithValue("@RentAreaSize", txtConcessionaireRentalArea.Text.Trim.Replace("'", ""))
                    Dim stopBill As String = String.Empty
                    Dim startBill As String = String.Empty
                    If chkStartBilling.Checked = True Then
                        startBill = "No"
                        stopBill = "Yes"
                    Else
                        startBill = "Yes"
                        stopBill = "No"
                    End If
                    .Parameters.AddWithValue("@StartBillFlag", startBill)
                    .Parameters.AddWithValue("@StopBillFlag", stopBill)
                    .Connection = dbconn
                    dbconn.Open()
                    .ExecuteNonQuery()
                    dbconn.Close()
                    MessageBox.Show(Me, "New concessionaire billing detaild added!", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    loadConcessionaireRentalDetails(cbConcessionaires.SelectedValue.ToString)
                End With
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return 0
    End Function
End Class