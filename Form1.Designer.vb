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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DisplayTopTenCitiesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.picMain = New System.Windows.Forms.PictureBox()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblSelect = New System.Windows.Forms.Label()
        Me.lstCities = New System.Windows.Forms.ListBox()
        Me.lblSelectedCost = New System.Windows.Forms.Label()
        Me.lblAvgCost = New System.Windows.Forms.Label()
        Me.btnComputeAverage = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.picMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DisplayTopTenCitiesToolStripMenuItem, Me.ClearToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'DisplayTopTenCitiesToolStripMenuItem
        '
        Me.DisplayTopTenCitiesToolStripMenuItem.Name = "DisplayTopTenCitiesToolStripMenuItem"
        Me.DisplayTopTenCitiesToolStripMenuItem.Size = New System.Drawing.Size(273, 22)
        Me.DisplayTopTenCitiesToolStripMenuItem.Text = "Display Top Ten Cities and Rental Cost"
        '
        'ClearToolStripMenuItem
        '
        Me.ClearToolStripMenuItem.Name = "ClearToolStripMenuItem"
        Me.ClearToolStripMenuItem.Size = New System.Drawing.Size(273, 22)
        Me.ClearToolStripMenuItem.Text = "Clear"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(273, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'picMain
        '
        Me.picMain.Image = CType(resources.GetObject("picMain.Image"), System.Drawing.Image)
        Me.picMain.Location = New System.Drawing.Point(40, 90)
        Me.picMain.Name = "picMain"
        Me.picMain.Size = New System.Drawing.Size(332, 277)
        Me.picMain.TabIndex = 1
        Me.picMain.TabStop = False
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Bookman Old Style", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(55, 24)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(691, 38)
        Me.lblTitle.TabIndex = 2
        Me.lblTitle.Text = "Two-Bedroom Median Apartment Rental"
        '
        'lblSelect
        '
        Me.lblSelect.AutoSize = True
        Me.lblSelect.Font = New System.Drawing.Font("Bookman Old Style", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSelect.Location = New System.Drawing.Point(427, 90)
        Me.lblSelect.Name = "lblSelect"
        Me.lblSelect.Size = New System.Drawing.Size(109, 21)
        Me.lblSelect.TabIndex = 3
        Me.lblSelect.Text = "Select City"
        '
        'lstCities
        '
        Me.lstCities.Font = New System.Drawing.Font("Bookman Old Style", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstCities.FormattingEnabled = True
        Me.lstCities.ItemHeight = 21
        Me.lstCities.Location = New System.Drawing.Point(431, 114)
        Me.lstCities.Name = "lstCities"
        Me.lstCities.Size = New System.Drawing.Size(189, 256)
        Me.lstCities.TabIndex = 4
        '
        'lblSelectedCost
        '
        Me.lblSelectedCost.Font = New System.Drawing.Font("Bookman Old Style", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSelectedCost.Location = New System.Drawing.Point(12, 386)
        Me.lblSelectedCost.Name = "lblSelectedCost"
        Me.lblSelectedCost.Size = New System.Drawing.Size(776, 38)
        Me.lblSelectedCost.TabIndex = 5
        Me.lblSelectedCost.Text = "The selected city rental's median cost of $"
        Me.lblSelectedCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblSelectedCost.Visible = False
        '
        'lblAvgCost
        '
        Me.lblAvgCost.Font = New System.Drawing.Font("Bookman Old Style", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAvgCost.Location = New System.Drawing.Point(12, 482)
        Me.lblAvgCost.Name = "lblAvgCost"
        Me.lblAvgCost.Size = New System.Drawing.Size(776, 38)
        Me.lblAvgCost.TabIndex = 6
        Me.lblAvgCost.Text = "Average Rental City Cost: "
        Me.lblAvgCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblAvgCost.Visible = False
        '
        'btnComputeAverage
        '
        Me.btnComputeAverage.Font = New System.Drawing.Font("Bookman Old Style", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnComputeAverage.Location = New System.Drawing.Point(274, 427)
        Me.btnComputeAverage.Name = "btnComputeAverage"
        Me.btnComputeAverage.Size = New System.Drawing.Size(238, 45)
        Me.btnComputeAverage.TabIndex = 7
        Me.btnComputeAverage.Text = "Compute Average Rental"
        Me.btnComputeAverage.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 548)
        Me.Controls.Add(Me.btnComputeAverage)
        Me.Controls.Add(Me.lblAvgCost)
        Me.Controls.Add(Me.lblSelectedCost)
        Me.Controls.Add(Me.lstCities)
        Me.Controls.Add(Me.lblSelect)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.picMain)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmMain"
        Me.Text = "Apartment Rentals by City"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.picMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DisplayTopTenCitiesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClearToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents picMain As PictureBox
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblSelect As Label
    Friend WithEvents lstCities As ListBox
    Friend WithEvents lblSelectedCost As Label
    Friend WithEvents lblAvgCost As Label
    Friend WithEvents btnComputeAverage As Button
End Class
