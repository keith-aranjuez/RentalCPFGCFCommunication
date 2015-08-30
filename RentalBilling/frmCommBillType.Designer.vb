<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCommBillType
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
        Me.txtBillSearch = New System.Windows.Forms.TextBox()
        Me.gvBillType = New System.Windows.Forms.DataGridView()
        CType(Me.gvBillType, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtBillSearch
        '
        Me.txtBillSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBillSearch.Location = New System.Drawing.Point(5, 13)
        Me.txtBillSearch.Margin = New System.Windows.Forms.Padding(4)
        Me.txtBillSearch.Name = "txtBillSearch"
        Me.txtBillSearch.Size = New System.Drawing.Size(335, 24)
        Me.txtBillSearch.TabIndex = 0
        '
        'gvBillType
        '
        Me.gvBillType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gvBillType.Location = New System.Drawing.Point(5, 44)
        Me.gvBillType.Name = "gvBillType"
        Me.gvBillType.Size = New System.Drawing.Size(335, 348)
        Me.gvBillType.TabIndex = 1
        '
        'frmCommBillType
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(346, 394)
        Me.Controls.Add(Me.gvBillType)
        Me.Controls.Add(Me.txtBillSearch)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmCommBillType"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.gvBillType, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtBillSearch As System.Windows.Forms.TextBox
    Friend WithEvents gvBillType As System.Windows.Forms.DataGridView
End Class
