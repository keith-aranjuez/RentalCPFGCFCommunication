<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConcessionaireSelect
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtConcSearch = New System.Windows.Forms.TextBox()
        Me.gvConcessionaires = New System.Windows.Forms.DataGridView()
        CType(Me.gvConcessionaires, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Search"
        '
        'txtConcSearch
        '
        Me.txtConcSearch.Location = New System.Drawing.Point(73, 26)
        Me.txtConcSearch.Name = "txtConcSearch"
        Me.txtConcSearch.Size = New System.Drawing.Size(408, 24)
        Me.txtConcSearch.TabIndex = 1
        '
        'gvConcessionaires
        '
        Me.gvConcessionaires.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gvConcessionaires.Location = New System.Drawing.Point(12, 56)
        Me.gvConcessionaires.Name = "gvConcessionaires"
        Me.gvConcessionaires.Size = New System.Drawing.Size(469, 511)
        Me.gvConcessionaires.TabIndex = 2
        '
        'frmConcessionaireSelect
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(493, 579)
        Me.Controls.Add(Me.gvConcessionaires)
        Me.Controls.Add(Me.txtConcSearch)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmConcessionaireSelect"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Select Concessionaire"
        CType(Me.gvConcessionaires, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtConcSearch As System.Windows.Forms.TextBox
    Friend WithEvents gvConcessionaires As System.Windows.Forms.DataGridView
End Class
