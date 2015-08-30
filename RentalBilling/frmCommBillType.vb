Imports System.Data.SqlClient
Imports Microsoft.VisualBasic

Public Class frmCommBillType
    Private conn As String = "server=devmachine\sqldataserver; initial catalog=RENTAL; user=sa; password=sqldataserver;"
    Private Function returnCommRates(ByVal searchString As String)
        Try
            Using dbconn As New SqlConnection(conn)
                Dim dbGet As New SqlDataAdapter("select recordno, billamount, billtype from un_communicationbilling where billtype like '" & searchString.Trim.Replace("'", "") & "%'", dbconn)
                Dim ds As New DataSet
                ds.Clear()
                dbGet.Fill(ds)
                If ds.Tables(0).Rows.Count > 0 Then
                    With gvBillType
                        .DataSource = ds.Tables(0).DefaultView
                        .SelectionMode = DataGridViewSelectionMode.FullRowSelect
                        .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
                        .Columns(0).Visible = False
                        .Columns(1).HeaderText = "Rate"
                        .Columns(2).HeaderText = "Description"
                    End With
                Else
                    gvBillType.DataSource = Nothing
                    gvBillType.Rows.Clear()
                    Return 0
                    Exit Function
                End If

            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return 0
    End Function

    Private billRate As Decimal
    Public Property selectedBillRate() As Decimal
        Get
            Return billRate
        End Get
        Set(ByVal value As Decimal)
            billRate = value
        End Set
    End Property

    Private Sub frmCommBillType_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        frmCommBillView.selectedRate = billRate
        frmCommBillView.txtType.Text = Me.selectedBillType & " " & billRate
    End Sub

    Private Sub frmCommBillType_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Return Then
            billRate = gvBillType(1, gvBillType.CurrentRow.Index).Value
            Me.Close()
        End If
    End Sub

    Private Sub frmCommBillType_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        returnCommRates(txtBillSearch.Text.Trim.Replace("'", ""))
    End Sub

    Private selBillTYpe As String
    Public Property selectedBillType() As String
        Get
            Return selBillTYpe
        End Get
        Set(ByVal value As String)
            selBillTYpe = value
        End Set
    End Property
End Class