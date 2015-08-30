Imports System.Data.SqlClient
Imports Microsoft.VisualBasic
Public Class frmConcessionaireSelect
    Private conn As String = "server=devmachine\sqldataserver; initial catalog=RENTAL; user=sa; password=sqldataserver;"

    Private Sub frmConcessionaireSelect_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        frmBillView.txtConcessionaireCode.Text = concessionaireCode
    End Sub

    Private Sub frmConcessionaireSelect_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        If e.KeyChar = ChrW(Keys.Return) Then
            selCode = gvConcessionaires(0, gvConcessionaires.CurrentRow.Index - 1).Value.ToString
            frmBillView.getConcessionaireDetails(selCode)
            Me.Close()
        End If
    End Sub

    Private Sub frmConcessionaireSelect_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        returnConcessionaires()
    End Sub
    Private Function returnConcessionaires()
        Try
            Using dbconn As New SqlConnection(conn)
                Dim dbGet As New SqlDataAdapter("select concessionaireid, concessionairename from concessionaires order by concessionairename asc", dbconn)
                Dim ds As New DataSet
                ds.Clear()
                dbGet.Fill(ds)
                With gvConcessionaires
                    .DataSource = ds.Tables(0).DefaultView
                    .ReadOnly = True
                    .SelectionMode = DataGridViewSelectionMode.FullRowSelect
                    .Columns(0).HeaderText = "Code"
                    .Columns(1).HeaderText = "Concessionaire Name"
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
    Public Property concessionaireCode() As String
        Get
            Return selCode
        End Get
        Set(ByVal value As String)
            selCode = value
        End Set
    End Property

End Class