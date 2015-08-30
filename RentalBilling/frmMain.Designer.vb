<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CPFGCFToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CommunicationBillingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConcessionaireToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CommunicationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConcessionaireToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConcessionaireBillingListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RentalBillingAdjustmentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.CPFGCFToolStripMenuItem, Me.CommunicationBillingToolStripMenuItem, Me.ConcessionaireToolStripMenuItem, Me.CommunicationToolStripMenuItem, Me.ConcessionaireToolStripMenuItem1})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(963, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'CPFGCFToolStripMenuItem
        '
        Me.CPFGCFToolStripMenuItem.Name = "CPFGCFToolStripMenuItem"
        Me.CPFGCFToolStripMenuItem.Size = New System.Drawing.Size(57, 20)
        Me.CPFGCFToolStripMenuItem.Text = "Update"
        '
        'CommunicationBillingToolStripMenuItem
        '
        Me.CommunicationBillingToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ConcessionaireBillingListToolStripMenuItem, Me.RentalBillingAdjustmentToolStripMenuItem})
        Me.CommunicationBillingToolStripMenuItem.Name = "CommunicationBillingToolStripMenuItem"
        Me.CommunicationBillingToolStripMenuItem.Size = New System.Drawing.Size(88, 20)
        Me.CommunicationBillingToolStripMenuItem.Text = "Rental Billing"
        '
        'ConcessionaireToolStripMenuItem
        '
        Me.ConcessionaireToolStripMenuItem.Name = "ConcessionaireToolStripMenuItem"
        Me.ConcessionaireToolStripMenuItem.Size = New System.Drawing.Size(70, 20)
        Me.ConcessionaireToolStripMenuItem.Text = "CPF/GCF "
        '
        'CommunicationToolStripMenuItem
        '
        Me.CommunicationToolStripMenuItem.Name = "CommunicationToolStripMenuItem"
        Me.CommunicationToolStripMenuItem.Size = New System.Drawing.Size(106, 20)
        Me.CommunicationToolStripMenuItem.Text = "Communication"
        '
        'ConcessionaireToolStripMenuItem1
        '
        Me.ConcessionaireToolStripMenuItem1.Name = "ConcessionaireToolStripMenuItem1"
        Me.ConcessionaireToolStripMenuItem1.Size = New System.Drawing.Size(99, 20)
        Me.ConcessionaireToolStripMenuItem1.Text = "Concessionaire"
        '
        'ConcessionaireBillingListToolStripMenuItem
        '
        Me.ConcessionaireBillingListToolStripMenuItem.Name = "ConcessionaireBillingListToolStripMenuItem"
        Me.ConcessionaireBillingListToolStripMenuItem.Size = New System.Drawing.Size(211, 22)
        Me.ConcessionaireBillingListToolStripMenuItem.Text = "Concessionaire Billing List"
        '
        'RentalBillingAdjustmentToolStripMenuItem
        '
        Me.RentalBillingAdjustmentToolStripMenuItem.Name = "RentalBillingAdjustmentToolStripMenuItem"
        Me.RentalBillingAdjustmentToolStripMenuItem.Size = New System.Drawing.Size(211, 22)
        Me.RentalBillingAdjustmentToolStripMenuItem.Text = "Rental Billing Adjustment"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(963, 385)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Main"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CPFGCFToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CommunicationBillingToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConcessionaireToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CommunicationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConcessionaireToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConcessionaireBillingListToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RentalBillingAdjustmentToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
