<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ConcessionaireRentalAreas
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtStartBillCode = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.chkStartBilling = New System.Windows.Forms.CheckBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.txtRentalUnit = New System.Windows.Forms.TextBox()
        Me.txtConcessionaireRentalArea = New System.Windows.Forms.TextBox()
        Me.txtRentalRate = New System.Windows.Forms.TextBox()
        Me.cbRentalType = New System.Windows.Forms.ComboBox()
        Me.cbRentalLocationArea = New System.Windows.Forms.ComboBox()
        Me.cbRentalLocation = New System.Windows.Forms.ComboBox()
        Me.cbConcessionaires = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lblConcessionName = New System.Windows.Forms.Label()
        Me.lblConcessionId = New System.Windows.Forms.Label()
        Me.gvConcessionaireDetails = New System.Windows.Forms.DataGridView()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.gvConcessionaireDetails, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.GroupBox1.Controls.Add(Me.txtStartBillCode)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.chkStartBilling)
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.btnAdd)
        Me.GroupBox1.Controls.Add(Me.txtRentalUnit)
        Me.GroupBox1.Controls.Add(Me.txtConcessionaireRentalArea)
        Me.GroupBox1.Controls.Add(Me.txtRentalRate)
        Me.GroupBox1.Controls.Add(Me.cbRentalType)
        Me.GroupBox1.Controls.Add(Me.cbRentalLocationArea)
        Me.GroupBox1.Controls.Add(Me.cbRentalLocation)
        Me.GroupBox1.Controls.Add(Me.cbConcessionaires)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(333, 637)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Concessionaire Details"
        '
        'txtStartBillCode
        '
        Me.txtStartBillCode.Location = New System.Drawing.Point(6, 52)
        Me.txtStartBillCode.Name = "txtStartBillCode"
        Me.txtStartBillCode.Size = New System.Drawing.Size(239, 22)
        Me.txtStartBillCode.TabIndex = 18
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(4, 31)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(92, 16)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Start Bill Code"
        '
        'chkStartBilling
        '
        Me.chkStartBilling.AutoSize = True
        Me.chkStartBilling.Location = New System.Drawing.Point(252, 54)
        Me.chkStartBilling.Name = "chkStartBilling"
        Me.chkStartBilling.Size = New System.Drawing.Size(76, 20)
        Me.chkStartBilling.TabIndex = 16
        Me.chkStartBilling.Text = "Stop Bill"
        Me.chkStartBilling.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(223, 407)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(98, 32)
        Me.Button3.TabIndex = 15
        Me.Button3.Text = "Button3"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(119, 407)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(98, 32)
        Me.Button2.TabIndex = 14
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(15, 407)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(98, 32)
        Me.btnAdd.TabIndex = 13
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'txtRentalUnit
        '
        Me.txtRentalUnit.Location = New System.Drawing.Point(180, 373)
        Me.txtRentalUnit.Name = "txtRentalUnit"
        Me.txtRentalUnit.ReadOnly = True
        Me.txtRentalUnit.Size = New System.Drawing.Size(110, 22)
        Me.txtRentalUnit.TabIndex = 12
        '
        'txtConcessionaireRentalArea
        '
        Me.txtConcessionaireRentalArea.Location = New System.Drawing.Point(7, 373)
        Me.txtConcessionaireRentalArea.Name = "txtConcessionaireRentalArea"
        Me.txtConcessionaireRentalArea.Size = New System.Drawing.Size(167, 22)
        Me.txtConcessionaireRentalArea.TabIndex = 11
        '
        'txtRentalRate
        '
        Me.txtRentalRate.Location = New System.Drawing.Point(6, 317)
        Me.txtRentalRate.Name = "txtRentalRate"
        Me.txtRentalRate.ReadOnly = True
        Me.txtRentalRate.Size = New System.Drawing.Size(167, 22)
        Me.txtRentalRate.TabIndex = 10
        '
        'cbRentalType
        '
        Me.cbRentalType.FormattingEnabled = True
        Me.cbRentalType.Location = New System.Drawing.Point(7, 261)
        Me.cbRentalType.Name = "cbRentalType"
        Me.cbRentalType.Size = New System.Drawing.Size(321, 24)
        Me.cbRentalType.TabIndex = 9
        '
        'cbRentalLocationArea
        '
        Me.cbRentalLocationArea.FormattingEnabled = True
        Me.cbRentalLocationArea.Location = New System.Drawing.Point(6, 204)
        Me.cbRentalLocationArea.Name = "cbRentalLocationArea"
        Me.cbRentalLocationArea.Size = New System.Drawing.Size(321, 24)
        Me.cbRentalLocationArea.TabIndex = 8
        '
        'cbRentalLocation
        '
        Me.cbRentalLocation.FormattingEnabled = True
        Me.cbRentalLocation.Location = New System.Drawing.Point(6, 152)
        Me.cbRentalLocation.Name = "cbRentalLocation"
        Me.cbRentalLocation.Size = New System.Drawing.Size(321, 24)
        Me.cbRentalLocation.TabIndex = 7
        '
        'cbConcessionaires
        '
        Me.cbConcessionaires.FormattingEnabled = True
        Me.cbConcessionaires.Location = New System.Drawing.Point(6, 101)
        Me.cbConcessionaires.Name = "cbConcessionaires"
        Me.cbConcessionaires.Size = New System.Drawing.Size(321, 24)
        Me.cbConcessionaires.TabIndex = 0
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(177, 354)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(31, 16)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Unit"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(4, 354)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(119, 16)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Rental Space Size"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(3, 298)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(128, 16)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Rental Rate per Unit"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(4, 242)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 16)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Rental Type"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 185)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Location Area"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 133)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Rental Location"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 82)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Concessionaire"
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.lblConcessionName)
        Me.GroupBox2.Controls.Add(Me.lblConcessionId)
        Me.GroupBox2.Controls.Add(Me.gvConcessionaireDetails)
        Me.GroupBox2.Location = New System.Drawing.Point(351, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(828, 637)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Concessionaire Rental Summary"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(7, 58)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(108, 16)
        Me.Label11.TabIndex = 16
        Me.Label11.Text = "Concessionaire :"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(7, 31)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(122, 16)
        Me.Label10.TabIndex = 16
        Me.Label10.Text = "Concessionaire Id :"
        '
        'lblConcessionName
        '
        Me.lblConcessionName.AutoSize = True
        Me.lblConcessionName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConcessionName.Location = New System.Drawing.Point(132, 55)
        Me.lblConcessionName.Name = "lblConcessionName"
        Me.lblConcessionName.Size = New System.Drawing.Size(0, 20)
        Me.lblConcessionName.TabIndex = 17
        '
        'lblConcessionId
        '
        Me.lblConcessionId.AutoSize = True
        Me.lblConcessionId.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConcessionId.Location = New System.Drawing.Point(132, 27)
        Me.lblConcessionId.Name = "lblConcessionId"
        Me.lblConcessionId.Size = New System.Drawing.Size(0, 20)
        Me.lblConcessionId.TabIndex = 16
        '
        'gvConcessionaireDetails
        '
        Me.gvConcessionaireDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gvConcessionaireDetails.Location = New System.Drawing.Point(6, 89)
        Me.gvConcessionaireDetails.Name = "gvConcessionaireDetails"
        Me.gvConcessionaireDetails.Size = New System.Drawing.Size(815, 542)
        Me.gvConcessionaireDetails.TabIndex = 0
        '
        'ConcessionaireRentalAreas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1184, 661)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "ConcessionaireRentalAreas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ConcessionaireRentalAreas"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.gvConcessionaireDetails, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtRentalUnit As System.Windows.Forms.TextBox
    Friend WithEvents txtConcessionaireRentalArea As System.Windows.Forms.TextBox
    Friend WithEvents txtRentalRate As System.Windows.Forms.TextBox
    Friend WithEvents cbRentalType As System.Windows.Forms.ComboBox
    Friend WithEvents cbRentalLocationArea As System.Windows.Forms.ComboBox
    Friend WithEvents cbRentalLocation As System.Windows.Forms.ComboBox
    Friend WithEvents cbConcessionaires As System.Windows.Forms.ComboBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents gvConcessionaireDetails As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents lblConcessionName As System.Windows.Forms.Label
    Friend WithEvents lblConcessionId As System.Windows.Forms.Label
    Friend WithEvents chkStartBilling As System.Windows.Forms.CheckBox
    Friend WithEvents txtStartBillCode As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
End Class
