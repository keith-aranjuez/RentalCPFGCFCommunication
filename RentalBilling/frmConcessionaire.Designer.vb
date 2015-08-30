<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConcessionaire
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
        Me.gvConcessionaires = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtConcessionaireCode = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtConcessionaireName = New System.Windows.Forms.TextBox()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.chkStopBill = New System.Windows.Forms.CheckBox()
        Me.txtStartBill = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.rbtnConName = New System.Windows.Forms.RadioButton()
        Me.rbtnConCode = New System.Windows.Forms.RadioButton()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        CType(Me.gvConcessionaires, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'gvConcessionaires
        '
        Me.gvConcessionaires.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gvConcessionaires.Location = New System.Drawing.Point(13, 171)
        Me.gvConcessionaires.Name = "gvConcessionaires"
        Me.gvConcessionaires.Size = New System.Drawing.Size(868, 478)
        Me.gvConcessionaires.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(135, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(105, 16)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Concessionaire:"
        '
        'txtConcessionaireCode
        '
        Me.txtConcessionaireCode.Location = New System.Drawing.Point(10, 38)
        Me.txtConcessionaireCode.Name = "txtConcessionaireCode"
        Me.txtConcessionaireCode.ReadOnly = True
        Me.txtConcessionaireCode.Size = New System.Drawing.Size(122, 22)
        Me.txtConcessionaireCode.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Code:"
        '
        'txtConcessionaireName
        '
        Me.txtConcessionaireName.Location = New System.Drawing.Point(138, 37)
        Me.txtConcessionaireName.Name = "txtConcessionaireName"
        Me.txtConcessionaireName.Size = New System.Drawing.Size(473, 22)
        Me.txtConcessionaireName.TabIndex = 4
        '
        'btnNew
        '
        Me.btnNew.Location = New System.Drawing.Point(10, 67)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(88, 30)
        Me.btnNew.TabIndex = 5
        Me.btnNew.Text = "Add"
        Me.btnNew.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(104, 66)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(88, 30)
        Me.btnUpdate.TabIndex = 6
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(198, 66)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(88, 30)
        Me.btnCancel.TabIndex = 7
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'chkStopBill
        '
        Me.chkStopBill.AutoSize = True
        Me.chkStopBill.Location = New System.Drawing.Point(795, 39)
        Me.chkStopBill.Name = "chkStopBill"
        Me.chkStopBill.Size = New System.Drawing.Size(76, 20)
        Me.chkStopBill.TabIndex = 8
        Me.chkStopBill.Text = "Stop Bill"
        Me.chkStopBill.UseVisualStyleBackColor = True
        Me.chkStopBill.Visible = False
        '
        'txtStartBill
        '
        Me.txtStartBill.Location = New System.Drawing.Point(617, 37)
        Me.txtStartBill.Name = "txtStartBill"
        Me.txtStartBill.Size = New System.Drawing.Size(169, 22)
        Me.txtStartBill.TabIndex = 10
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(614, 18)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(172, 16)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Start Billing Instruction Code"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtStartBill)
        Me.GroupBox1.Controls.Add(Me.chkStopBill)
        Me.GroupBox1.Controls.Add(Me.btnCancel)
        Me.GroupBox1.Controls.Add(Me.btnUpdate)
        Me.GroupBox1.Controls.Add(Me.btnNew)
        Me.GroupBox1.Controls.Add(Me.txtConcessionaireName)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtConcessionaireCode)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(7, 60)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(882, 104)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Concessionaire Details"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rbtnConName)
        Me.GroupBox2.Controls.Add(Me.rbtnConCode)
        Me.GroupBox2.Controls.Add(Me.txtSearch)
        Me.GroupBox2.Location = New System.Drawing.Point(13, 2)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(876, 50)
        Me.GroupBox2.TabIndex = 11
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Search Concessionaire"
        '
        'rbtnConName
        '
        Me.rbtnConName.AutoSize = True
        Me.rbtnConName.Location = New System.Drawing.Point(552, 23)
        Me.rbtnConName.Name = "rbtnConName"
        Me.rbtnConName.Size = New System.Drawing.Size(160, 20)
        Me.rbtnConName.TabIndex = 7
        Me.rbtnConName.TabStop = True
        Me.rbtnConName.Text = "Concessionaire Name"
        Me.rbtnConName.UseVisualStyleBackColor = True
        '
        'rbtnConCode
        '
        Me.rbtnConCode.AutoSize = True
        Me.rbtnConCode.Checked = True
        Me.rbtnConCode.Location = New System.Drawing.Point(379, 23)
        Me.rbtnConCode.Name = "rbtnConCode"
        Me.rbtnConCode.Size = New System.Drawing.Size(156, 20)
        Me.rbtnConCode.TabIndex = 6
        Me.rbtnConCode.TabStop = True
        Me.rbtnConCode.Text = "Concessionaire Code"
        Me.rbtnConCode.UseVisualStyleBackColor = True
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(7, 22)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(366, 22)
        Me.txtSearch.TabIndex = 2
        '
        'frmConcessionaire
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(900, 660)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.gvConcessionaires)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmConcessionaire"
        Me.Text = "frmConcessionaire"
        CType(Me.gvConcessionaires, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gvConcessionaires As System.Windows.Forms.DataGridView
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtConcessionaireCode As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtConcessionaireName As System.Windows.Forms.TextBox
    Friend WithEvents btnNew As System.Windows.Forms.Button
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents chkStopBill As System.Windows.Forms.CheckBox
    Friend WithEvents txtStartBill As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents rbtnConCode As System.Windows.Forms.RadioButton
    Friend WithEvents rbtnConName As System.Windows.Forms.RadioButton
End Class
