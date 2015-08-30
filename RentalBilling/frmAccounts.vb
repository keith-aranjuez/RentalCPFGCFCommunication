Imports System.Data.SqlClient
Imports Microsoft.VisualBasic
Public Class frmAccounts
    Private conn As String = "server=devmachine\sqldataserver; initial catalog=RENTAL; user=sa; password=sqldataserver;"

    Private Sub frmConcessionaireSelect_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        frmBillView.lblAccountCode.Text = accountCode
    End Sub

    Private Sub frmAccountsSelect_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        If e.KeyChar = ChrW(Keys.Return) Then
            selCode = gvConcessionaires(0, gvConcessionaires.CurrentRow.Index - 1).Value.ToString
            Me.Close()
        End If
    End Sub

    Private Sub frmAccountsSelect_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        returnAccounts()
    End Sub
    Private Function returnAccounts()
        Try
            Using dbconn As New SqlConnection(conn)
                Dim dbGet As New SqlDataAdapter("select accountcode, accounttitle from accounts order by accounttitle asc", dbconn)
                Dim ds As New DataSet
                ds.Clear()
                dbGet.Fill(ds)
                With gvConcessionaires
                    .DataSource = ds.Tables(0).DefaultView
                    .ReadOnly = True
                    .SelectionMode = DataGridViewSelectionMode.FullRowSelect
                    .Columns(0).HeaderText = "Code"
                    .Columns(1).HeaderText = "Account Title"
                    .CurrentCell = gvConcessionaires(0, 0)
                    .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
                End With
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return 0
    End Function

    Private selCode As String
    Public Property accountCode() As String
        Get
            Return selCode
        End Get
        Set(ByVal value As String)
            selCode = value
        End Set
    End Property

End Class