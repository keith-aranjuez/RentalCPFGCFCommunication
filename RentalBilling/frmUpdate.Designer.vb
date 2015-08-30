<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUpdate
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
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbMonth = New System.Windows.Forms.ComboBox()
        Me.cbYear = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.chkRental = New System.Windows.Forms.CheckBox()
        Me.chkCommunication = New System.Windows.Forms.CheckBox()
        Me.chkCPF = New System.Windows.Forms.CheckBox()
        Me.bgWorkerRental = New System.ComponentModel.BackgroundWorker()
        Me.bgWorkerCommunication = New System.ComponentModel.BackgroundWorker()
        Me.SuspendLayout()
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(25, 80)
        Me.btnUpdate.Margin = New System.Windows.Forms.Padding(4)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(102, 81)
        Me.btnUpdate.TabIndex = 0
        Me.btnUpdate.Text = "Update Billing"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 29)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Select Month :"
        '
        'cbMonth
        '
        Me.cbMonth.FormattingEnabled = True
        Me.cbMonth.Location = New System.Drawing.Point(25, 49)
        Me.cbMonth.Name = "cbMonth"
        Me.cbMonth.Size = New System.Drawing.Size(289, 24)
        Me.cbMonth.TabIndex = 2
        '
        'cbYear
        '
        Me.cbYear.FormattingEnabled = True
        Me.cbYear.Location = New System.Drawing.Point(320, 49)
        Me.cbYear.Name = "cbYear"
        Me.cbYear.Size = New System.Drawing.Size(164, 24)
        Me.cbYear.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(317, 29)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 16)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Select Year :"
        '
        'chkRental
        '
        Me.chkRental.AutoSize = True
        Me.chkRental.Location = New System.Drawing.Point(134, 85)
        Me.chkRental.Name = "chkRental"
        Me.chkRental.Size = New System.Drawing.Size(66, 20)
        Me.chkRental.TabIndex = 5
        Me.chkRental.Text = "Rental"
        Me.chkRental.UseVisualStyleBackColor = True
        '
        'chkCommunication
        '
        Me.chkCommunication.AutoSize = True
        Me.chkCommunication.Location = New System.Drawing.Point(134, 111)
        Me.chkCommunication.Name = "chkCommunication"
        Me.chkCommunication.Size = New System.Drawing.Size(119, 20)
        Me.chkCommunication.TabIndex = 6
        Me.chkCommunication.Text = "Communication"
        Me.chkCommunication.UseVisualStyleBackColor = True
        '
        'chkCPF
        '
        Me.chkCPF.AutoSize = True
        Me.chkCPF.Location = New System.Drawing.Point(134, 137)
        Me.chkCPF.Name = "chkCPF"
        Me.chkCPF.Size = New System.Drawing.Size(53, 20)
        Me.chkCPF.TabIndex = 7
        Me.chkCPF.Text = "CPF"
        Me.chkCPF.UseVisualStyleBackColor = True
        '
        'bgWorkerRental
        '
        '
        'bgWorkerCommunication
        '
        '
        'frmUpdate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(509, 180)
        Me.Controls.Add(Me.chkCPF)
        Me.Controls.Add(Me.chkCommunication)
        Me.Controls.Add(Me.chkRental)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cbYear)
        Me.Controls.Add(Me.cbMonth)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnUpdate)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "frmUpdate"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Update Monthly Billing"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cbMonth As System.Windows.Forms.ComboBox
    Friend WithEvents cbYear As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents chkRental As System.Windows.Forms.CheckBox
    Friend WithEvents chkCommunication As System.Windows.Forms.CheckBox
    Friend WithEvents chkCPF As System.Windows.Forms.CheckBox
    Friend WithEvents bgWorkerRental As System.ComponentModel.BackgroundWorker
    Friend WithEvents bgWorkerCommunication As System.ComponentModel.BackgroundWorker
End Class
