<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBillView
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
        Me.btnFirst = New System.Windows.Forms.Button()
        Me.btnPrevious = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnLast = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.cbSearchSelector = New System.Windows.Forms.ComboBox()
        Me.btnAddBilling = New System.Windows.Forms.Button()
        Me.btnUpdateBilling = New System.Windows.Forms.Button()
        Me.btnStopBill = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtAdjustmentAmount = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblConcessionaireName = New System.Windows.Forms.TextBox()
        Me.txtConcessionaireCode = New System.Windows.Forms.TextBox()
        Me.lblRentalType = New System.Windows.Forms.TextBox()
        Me.lblRentalLocation = New System.Windows.Forms.TextBox()
        Me.lblClass = New System.Windows.Forms.TextBox()
        Me.lblRentalArea = New System.Windows.Forms.TextBox()
        Me.txtDescp = New System.Windows.Forms.TextBox()
        Me.lblRentalRate = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtAdjustmentCode = New System.Windows.Forms.TextBox()
        Me.lblAccountCode = New System.Windows.Forms.TextBox()
        Me.lblRentCharge = New System.Windows.Forms.TextBox()
        Me.lblPeriodTo = New System.Windows.Forms.TextBox()
        Me.lblPeriodFrom = New System.Windows.Forms.TextBox()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape3 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape5 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cbBillDate = New System.Windows.Forms.ComboBox()
        Me.lblStopFlag = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnFirst
        '
        Me.btnFirst.Location = New System.Drawing.Point(21, 94)
        Me.btnFirst.Name = "btnFirst"
        Me.btnFirst.Size = New System.Drawing.Size(116, 45)
        Me.btnFirst.TabIndex = 1
        Me.btnFirst.Text = "[Home] First"
        Me.btnFirst.UseVisualStyleBackColor = True
        '
        'btnPrevious
        '
        Me.btnPrevious.Location = New System.Drawing.Point(136, 94)
        Me.btnPrevious.Name = "btnPrevious"
        Me.btnPrevious.Size = New System.Drawing.Size(116, 45)
        Me.btnPrevious.TabIndex = 2
        Me.btnPrevious.Text = "[PgDwn] Previous"
        Me.btnPrevious.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.Location = New System.Drawing.Point(251, 94)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(116, 45)
        Me.btnNext.TabIndex = 3
        Me.btnNext.Text = "[PgUp]" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Next"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'btnLast
        '
        Me.btnLast.Location = New System.Drawing.Point(365, 94)
        Me.btnLast.Name = "btnLast"
        Me.btnLast.Size = New System.Drawing.Size(116, 45)
        Me.btnLast.TabIndex = 4
        Me.btnLast.Text = "[End] - Last"
        Me.btnLast.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(24, 142)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(171, 18)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Search Concessionaire :"
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(165, 173)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(527, 24)
        Me.txtSearch.TabIndex = 22
        '
        'cbSearchSelector
        '
        Me.cbSearchSelector.FormattingEnabled = True
        Me.cbSearchSelector.Location = New System.Drawing.Point(26, 173)
        Me.cbSearchSelector.Name = "cbSearchSelector"
        Me.cbSearchSelector.Size = New System.Drawing.Size(132, 26)
        Me.cbSearchSelector.TabIndex = 23
        '
        'btnAddBilling
        '
        Me.btnAddBilling.Location = New System.Drawing.Point(21, 58)
        Me.btnAddBilling.Name = "btnAddBilling"
        Me.btnAddBilling.Size = New System.Drawing.Size(116, 30)
        Me.btnAddBilling.TabIndex = 26
        Me.btnAddBilling.Text = "F2 - Add"
        Me.btnAddBilling.UseVisualStyleBackColor = True
        '
        'btnUpdateBilling
        '
        Me.btnUpdateBilling.Location = New System.Drawing.Point(136, 58)
        Me.btnUpdateBilling.Name = "btnUpdateBilling"
        Me.btnUpdateBilling.Size = New System.Drawing.Size(116, 30)
        Me.btnUpdateBilling.TabIndex = 27
        Me.btnUpdateBilling.Text = "F3 - Change"
        Me.btnUpdateBilling.UseVisualStyleBackColor = True
        '
        'btnStopBill
        '
        Me.btnStopBill.Location = New System.Drawing.Point(251, 58)
        Me.btnStopBill.Name = "btnStopBill"
        Me.btnStopBill.Size = New System.Drawing.Size(116, 30)
        Me.btnStopBill.TabIndex = 28
        Me.btnStopBill.Text = "F4 - Delete"
        Me.btnStopBill.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Concessionaire :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 18)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Code :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(8, 115)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 18)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Location :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(8, 150)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(92, 18)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Rental Area :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(456, 150)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(93, 18)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Rental Rate :"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(9, 219)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(99, 18)
        Me.Label10.TabIndex = 10
        Me.Label10.Text = "Period From :"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(375, 219)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(81, 18)
        Me.Label11.TabIndex = 11
        Me.Label11.Text = "Period To :"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(9, 278)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(103, 18)
        Me.Label14.TabIndex = 14
        Me.Label14.Text = "Rent Charge : "
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(9, 322)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(144, 18)
        Me.Label16.TabIndex = 16
        Me.Label16.Text = "Adjustment Amount :"
        '
        'txtAdjustmentAmount
        '
        Me.txtAdjustmentAmount.Location = New System.Drawing.Point(159, 319)
        Me.txtAdjustmentAmount.Name = "txtAdjustmentAmount"
        Me.txtAdjustmentAmount.Size = New System.Drawing.Size(161, 24)
        Me.txtAdjustmentAmount.TabIndex = 17
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(456, 115)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 18)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "Code :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(375, 278)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(70, 18)
        Me.Label7.TabIndex = 23
        Me.Label7.Text = "Account :"
        '
        'lblConcessionaireName
        '
        Me.lblConcessionaireName.Location = New System.Drawing.Point(126, 24)
        Me.lblConcessionaireName.Name = "lblConcessionaireName"
        Me.lblConcessionaireName.Size = New System.Drawing.Size(551, 24)
        Me.lblConcessionaireName.TabIndex = 25
        '
        'txtConcessionaireCode
        '
        Me.txtConcessionaireCode.Location = New System.Drawing.Point(66, 55)
        Me.txtConcessionaireCode.Name = "txtConcessionaireCode"
        Me.txtConcessionaireCode.Size = New System.Drawing.Size(174, 24)
        Me.txtConcessionaireCode.TabIndex = 26
        '
        'lblRentalType
        '
        Me.lblRentalType.Location = New System.Drawing.Point(246, 55)
        Me.lblRentalType.Name = "lblRentalType"
        Me.lblRentalType.Size = New System.Drawing.Size(431, 24)
        Me.lblRentalType.TabIndex = 27
        '
        'lblRentalLocation
        '
        Me.lblRentalLocation.Location = New System.Drawing.Point(85, 112)
        Me.lblRentalLocation.Name = "lblRentalLocation"
        Me.lblRentalLocation.Size = New System.Drawing.Size(365, 24)
        Me.lblRentalLocation.TabIndex = 28
        '
        'lblClass
        '
        Me.lblClass.Location = New System.Drawing.Point(555, 112)
        Me.lblClass.Name = "lblClass"
        Me.lblClass.Size = New System.Drawing.Size(122, 24)
        Me.lblClass.TabIndex = 29
        '
        'lblRentalArea
        '
        Me.lblRentalArea.Location = New System.Drawing.Point(97, 147)
        Me.lblRentalArea.Name = "lblRentalArea"
        Me.lblRentalArea.Size = New System.Drawing.Size(143, 24)
        Me.lblRentalArea.TabIndex = 30
        '
        'txtDescp
        '
        Me.txtDescp.Location = New System.Drawing.Point(246, 147)
        Me.txtDescp.Name = "txtDescp"
        Me.txtDescp.Size = New System.Drawing.Size(204, 24)
        Me.txtDescp.TabIndex = 31
        '
        'lblRentalRate
        '
        Me.lblRentalRate.Location = New System.Drawing.Point(555, 147)
        Me.lblRentalRate.Name = "lblRentalRate"
        Me.lblRentalRate.Size = New System.Drawing.Size(122, 24)
        Me.lblRentalRate.TabIndex = 32
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.txtAdjustmentCode)
        Me.GroupBox1.Controls.Add(Me.lblAccountCode)
        Me.GroupBox1.Controls.Add(Me.lblRentCharge)
        Me.GroupBox1.Controls.Add(Me.lblPeriodTo)
        Me.GroupBox1.Controls.Add(Me.lblPeriodFrom)
        Me.GroupBox1.Controls.Add(Me.lblRentalRate)
        Me.GroupBox1.Controls.Add(Me.txtDescp)
        Me.GroupBox1.Controls.Add(Me.lblRentalArea)
        Me.GroupBox1.Controls.Add(Me.lblClass)
        Me.GroupBox1.Controls.Add(Me.lblRentalLocation)
        Me.GroupBox1.Controls.Add(Me.lblRentalType)
        Me.GroupBox1.Controls.Add(Me.txtConcessionaireCode)
        Me.GroupBox1.Controls.Add(Me.lblConcessionaireName)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtAdjustmentAmount)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.ShapeContainer1)
        Me.GroupBox1.Location = New System.Drawing.Point(15, 218)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(681, 363)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Rental Space Billing"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(375, 322)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(147, 18)
        Me.Label12.TabIndex = 38
        Me.Label12.Text = "Adjustment Account :"
        '
        'txtAdjustmentCode
        '
        Me.txtAdjustmentCode.Location = New System.Drawing.Point(525, 319)
        Me.txtAdjustmentCode.Name = "txtAdjustmentCode"
        Me.txtAdjustmentCode.Size = New System.Drawing.Size(152, 24)
        Me.txtAdjustmentCode.TabIndex = 37
        '
        'lblAccountCode
        '
        Me.lblAccountCode.Location = New System.Drawing.Point(451, 275)
        Me.lblAccountCode.Name = "lblAccountCode"
        Me.lblAccountCode.Size = New System.Drawing.Size(226, 24)
        Me.lblAccountCode.TabIndex = 36
        '
        'lblRentCharge
        '
        Me.lblRentCharge.Location = New System.Drawing.Point(117, 275)
        Me.lblRentCharge.Name = "lblRentCharge"
        Me.lblRentCharge.Size = New System.Drawing.Size(203, 24)
        Me.lblRentCharge.TabIndex = 35
        '
        'lblPeriodTo
        '
        Me.lblPeriodTo.Location = New System.Drawing.Point(459, 216)
        Me.lblPeriodTo.Name = "lblPeriodTo"
        Me.lblPeriodTo.Size = New System.Drawing.Size(218, 24)
        Me.lblPeriodTo.TabIndex = 34
        '
        'lblPeriodFrom
        '
        Me.lblPeriodFrom.Location = New System.Drawing.Point(117, 216)
        Me.lblPeriodFrom.Name = "lblPeriodFrom"
        Me.lblPeriodFrom.Size = New System.Drawing.Size(203, 24)
        Me.lblPeriodFrom.TabIndex = 33
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(4, 21)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape1, Me.LineShape3, Me.LineShape5})
        Me.ShapeContainer1.Size = New System.Drawing.Size(673, 338)
        Me.ShapeContainer1.TabIndex = 3
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape1
        '
        Me.LineShape1.BorderWidth = 5
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 4
        Me.LineShape1.X2 = 661
        Me.LineShape1.Y1 = 72
        Me.LineShape1.Y2 = 72
        '
        'LineShape3
        '
        Me.LineShape3.BorderWidth = 5
        Me.LineShape3.Name = "LineShape3"
        Me.LineShape3.X1 = 5
        Me.LineShape3.X2 = 662
        Me.LineShape3.Y1 = 167
        Me.LineShape3.Y2 = 167
        '
        'LineShape5
        '
        Me.LineShape5.BorderWidth = 5
        Me.LineShape5.Name = "LineShape5"
        Me.LineShape5.X1 = 5
        Me.LineShape5.X2 = 662
        Me.LineShape5.Y1 = 235
        Me.LineShape5.Y2 = 235
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(23, 18)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(131, 18)
        Me.Label9.TabIndex = 29
        Me.Label9.Text = "Select Biling Date :"
        '
        'cbBillDate
        '
        Me.cbBillDate.FormattingEnabled = True
        Me.cbBillDate.Location = New System.Drawing.Point(160, 15)
        Me.cbBillDate.Name = "cbBillDate"
        Me.cbBillDate.Size = New System.Drawing.Size(199, 26)
        Me.cbBillDate.TabIndex = 30
        '
        'lblStopFlag
        '
        Me.lblStopFlag.AutoSize = True
        Me.lblStopFlag.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStopFlag.ForeColor = System.Drawing.Color.Red
        Me.lblStopFlag.Location = New System.Drawing.Point(373, 64)
        Me.lblStopFlag.Name = "lblStopFlag"
        Me.lblStopFlag.Size = New System.Drawing.Size(204, 20)
        Me.lblStopFlag.TabIndex = 31
        Me.lblStopFlag.Text = "Search Concessionaire :"
        '
        'frmBillView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(713, 592)
        Me.Controls.Add(Me.lblStopFlag)
        Me.Controls.Add(Me.cbBillDate)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.btnStopBill)
        Me.Controls.Add(Me.btnUpdateBilling)
        Me.Controls.Add(Me.btnAddBilling)
        Me.Controls.Add(Me.cbSearchSelector)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnLast)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.btnPrevious)
        Me.Controls.Add(Me.btnFirst)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmBillView"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Billing View"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnFirst As System.Windows.Forms.Button
    Friend WithEvents btnPrevious As System.Windows.Forms.Button
    Friend WithEvents btnNext As System.Windows.Forms.Button
    Friend WithEvents btnLast As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents cbSearchSelector As System.Windows.Forms.ComboBox
    Friend WithEvents btnAddBilling As System.Windows.Forms.Button
    Friend WithEvents btnUpdateBilling As System.Windows.Forms.Button
    Friend WithEvents btnStopBill As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txtAdjustmentAmount As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lblConcessionaireName As System.Windows.Forms.TextBox
    Friend WithEvents txtConcessionaireCode As System.Windows.Forms.TextBox
    Friend WithEvents lblRentalType As System.Windows.Forms.TextBox
    Friend WithEvents lblRentalLocation As System.Windows.Forms.TextBox
    Friend WithEvents lblClass As System.Windows.Forms.TextBox
    Friend WithEvents lblRentalArea As System.Windows.Forms.TextBox
    Friend WithEvents txtDescp As System.Windows.Forms.TextBox
    Friend WithEvents lblRentalRate As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape3 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape5 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents lblRentCharge As System.Windows.Forms.TextBox
    Friend WithEvents lblPeriodTo As System.Windows.Forms.TextBox
    Friend WithEvents lblPeriodFrom As System.Windows.Forms.TextBox
    Friend WithEvents lblAccountCode As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents cbBillDate As System.Windows.Forms.ComboBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtAdjustmentCode As System.Windows.Forms.TextBox
    Friend WithEvents lblStopFlag As System.Windows.Forms.Label
End Class
