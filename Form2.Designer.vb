<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTenCities
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
        Me.lstCities = New System.Windows.Forms.ListBox()
        Me.lstPrices = New System.Windows.Forms.ListBox()
        Me.btnReturn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lstCities
        '
        Me.lstCities.Font = New System.Drawing.Font("Bookman Old Style", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstCities.FormattingEnabled = True
        Me.lstCities.ItemHeight = 21
        Me.lstCities.Location = New System.Drawing.Point(12, 12)
        Me.lstCities.Name = "lstCities"
        Me.lstCities.Size = New System.Drawing.Size(172, 256)
        Me.lstCities.TabIndex = 0
        '
        'lstPrices
        '
        Me.lstPrices.Font = New System.Drawing.Font("Bookman Old Style", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstPrices.FormattingEnabled = True
        Me.lstPrices.ItemHeight = 21
        Me.lstPrices.Location = New System.Drawing.Point(201, 12)
        Me.lstPrices.Name = "lstPrices"
        Me.lstPrices.Size = New System.Drawing.Size(171, 256)
        Me.lstPrices.TabIndex = 1
        '
        'btnReturn
        '
        Me.btnReturn.Font = New System.Drawing.Font("Bookman Old Style", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReturn.Location = New System.Drawing.Point(37, 285)
        Me.btnReturn.Name = "btnReturn"
        Me.btnReturn.Size = New System.Drawing.Size(315, 63)
        Me.btnReturn.TabIndex = 2
        Me.btnReturn.Text = "Return to Rental Cities"
        Me.btnReturn.UseVisualStyleBackColor = True
        '
        'frmTenCities
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(399, 373)
        Me.Controls.Add(Me.btnReturn)
        Me.Controls.Add(Me.lstPrices)
        Me.Controls.Add(Me.lstCities)
        Me.Name = "frmTenCities"
        Me.Text = "City Rentals"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lstCities As ListBox
    Friend WithEvents lstPrices As ListBox
    Friend WithEvents btnReturn As Button
End Class
