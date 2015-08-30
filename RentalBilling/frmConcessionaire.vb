Option Strict On
Imports System.Data.SqlClient
Imports System.Data

Public Class frmConcessionaire
    Private conn As String = "server=192.168.30.251; initial catalog=RENTAL; user=sa; password=dataserver;"

    Private Sub getConcessionaires(ByVal srcString As String)
        Try
            Using dbconn As New SqlConnection(conn)

                Dim dbCommand As String = String.Empty
                If rbtnConCode.Checked = True Then
                    dbCommand = "select concessionaireid, concessionairename, billinginstructioncode, stopbillflag from concessionairesview where concessionaireid like '%" & srcString & "%'"
                ElseIf rbtnConName.Checked = True Then
                    dbCommand = "select concessionaireid, concessionairename, billinginstructioncode, stopbillflag from concessionairesview where concessionairename like '%" & srcString & "%'"
                End If
                Dim dbGet As New SqlDataAdapter(dbCommand, dbconn)
                Dim ds As New DataSet
                ds.Clear()
                dbGet.Fill(ds)
                With gvConcessionaires
                    .ReadOnly = True
                    .MultiSelect = False
                    .SelectionMode = DataGridViewSelectionMode.FullRowSelect
                    .DataSource = ds.Tables(0).DefaultView
                    .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
                    .Columns(0).Width = 150
                    .Columns(1).Width = 450
                    .Columns(2).Width = 100
                    .Columns(3).Visible = False
                    '.Columns(3).Width = 100
                    .Columns(0).HeaderText = "Concessionaire Code"
                    .Columns(1).HeaderText = "Concessionaire Name"
                    .Columns(2).HeaderText = "Billing Instruction Code"
                    ' .Columns(3).HeaderText = "Stop Billing"
                End With
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

    Private Sub newConcessionaire()
        Dim rowsAffected As Integer = 0
        Dim stopBillFlag As String = String.Empty
        If chkStopBill.Checked = True Then
            stopBillFlag = "Yes"
        ElseIf chkStopBill.Checked = False Then
            stopBillFlag = "No"
        End If
        Try
            Using dbconn As New SqlConnection(conn)
                Dim dbNew As New SqlCommand()
                With dbNew
                    .CommandType = CommandType.StoredProcedure
                    .CommandText = "AddConcessionaire"
                    .Parameters.AddWithValue("@ConcessionaireId", txtConcessionaireCode.Text.ToString.Trim())
                    .Parameters.AddWithValue("@ConcessionaireName", txtConcessionaireName.Text.ToString.Trim())
                    .Parameters.AddWithValue("@BillingInstructionCode", txtStartBill.Text.ToString.Trim())
                    .Parameters.AddWithValue("@StopBillFlag", stopBillFlag.ToString.Trim())
                    .Connection = dbconn
                    dbconn.Open()
                    rowsAffected = .ExecuteNonQuery()
                    dbconn.Close()
                    If rowsAffected > 0 Then
                        MessageBox.Show("Failure")
                    End If
                    getConcessionaires(String.Empty)
                    btnNew.Text = "Add"
                    resetTxt()
                End With
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

    Private Sub frmConcessionaire_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        getConcessionaires(String.Empty)

    End Sub

    Private Sub btnUpdate_Click(sender As System.Object, e As System.EventArgs) Handles btnUpdate.Click
        If btnUpdate.Text = "Update" Then
            btnUpdate.Text = "Save"
            btnNew.Enabled = False
        ElseIf btnUpdate.Text = "Save" Then
            If MessageBox.Show("Update concessionaire information?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                updateConcessionaire()
            End If
        End If
    End Sub
    Private Sub updateConcessionaire()
        Dim rowsAffected As Integer = 0
        Dim stopBillFlag As String = String.Empty
        If chkStopBill.Checked = True Then
            stopBillFlag = "Yes"
        ElseIf chkStopBill.Checked = False Then
            stopBillFlag = "No"
        End If
        Try
            Using dbconn As New SqlConnection(conn)
                Dim dbNew As New SqlCommand()
                With dbNew
                    .CommandType = CommandType.StoredProcedure
                    .CommandText = "UpdateConcessionaire"
                    .Parameters.AddWithValue("@ConcessionaireId", txtConcessionaireCode.Text.ToString.Trim())
                    .Parameters.AddWithValue("@ConcessionaireName", txtConcessionaireName.Text.ToString.Trim())
                    .Parameters.AddWithValue("@BillingInstructionCode", txtStartBill.Text.ToString.Trim())
                    .Parameters.AddWithValue("@StopBillFlag", stopBillFlag.ToString.Trim())
                    .Connection = dbconn
                    dbconn.Open()
                    rowsAffected = .ExecuteNonQuery()
                    dbconn.Close()
                    If rowsAffected > 0 Then
                        MessageBox.Show("Failure")
                    End If
                    resetTxt()
                    getConcessionaires(String.Empty)
                    btnUpdate.Text = "Update"
                    btnNew.Enabled = True
                End With
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

    Private Sub gvConcessionaires_SelectionChanged(sender As Object, e As System.EventArgs) Handles gvConcessionaires.SelectionChanged
        Try
            Dim currRow As Integer = 0
            currRow = gvConcessionaires.CurrentRow.Index
            Dim stopBill As Boolean = False
            With gvConcessionaires
                txtConcessionaireCode.Text = CStr(.Item(0, currRow).Value)
                txtConcessionaireName.Text = CStr(.Item(1, currRow).Value)
                txtStartBill.Text = CStr(.Item(2, currRow).Value)
                If CStr(.Item(3, currRow).Value) = "Yes" Then
                    chkStopBill.Checked = True
                Else
                    chkStopBill.Checked = False
                End If
            End With
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub

    Private Sub txtSearch_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtSearch.TextChanged
        Try
            getConcessionaires(txtSearch.Text.Trim.Replace("'", ""))
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub

    Private Sub resetTxt()
        txtConcessionaireCode.Clear()
        txtConcessionaireName.Clear()
        txtStartBill.Clear()
        chkStopBill.Checked = False
    End Sub
 
    Private returnedCode As String = String.Empty
    Private Function returnCode() As String
        Dim idCodePart As String = String.Empty
        Dim datePart As String = Format(Now, "yyyy-MM-dd")
        Dim timePart As String = Now.ToLongTimeString
        idCodePart = datePart.Replace("-", "").Remove(0, 2) & timePart.Replace(":", "")
        Return idCodePart
    End Function

    Private Sub btnNew_Click(sender As System.Object, e As System.EventArgs) Handles btnNew.Click
        If btnNew.Text = "Add" Then
            resetTxt()
            txtConcessionaireCode.Text = returnCode()
            btnNew.Text = "Save"
        ElseIf btnNew.Text = "Save" Then
            newConcessionaire()
        End If
    End Sub

    Private Sub btnCancel_Click(sender As System.Object, e As System.EventArgs) Handles btnCancel.Click
        btnNew.Text = "Add"
        btnUpdate.Text = "Update"
        resetTxt()
        getConcessionaires(String.Empty)
    End Sub
End Class