<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBuilding
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
        Me.picBuilding = New System.Windows.Forms.PictureBox()
        Me.lblBuildingInfo = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.grpType = New System.Windows.Forms.GroupBox()
        Me.radSingleSlope = New System.Windows.Forms.RadioButton()
        Me.radGable = New System.Windows.Forms.RadioButton()
        Me.lblWidth = New System.Windows.Forms.Label()
        Me.txtWidth = New System.Windows.Forms.TextBox()
        Me.txtLength = New System.Windows.Forms.TextBox()
        Me.lblLength = New System.Windows.Forms.Label()
        Me.cboWall = New System.Windows.Forms.ComboBox()
        Me.txtSlope = New System.Windows.Forms.TextBox()
        Me.lblSlope = New System.Windows.Forms.Label()
        Me.lblInformation = New System.Windows.Forms.Label()
        Me.txtHeight = New System.Windows.Forms.TextBox()
        Me.lblHeight = New System.Windows.Forms.Label()
        Me.lblPnlWidth = New System.Windows.Forms.Label()
        Me.lblRoofPnlWidth = New System.Windows.Forms.Label()
        Me.cboRoof = New System.Windows.Forms.ComboBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.lblSideWallInfo = New System.Windows.Forms.Label()
        Me.lblRoofInfo = New System.Windows.Forms.Label()
        Me.lblEndWallInfo = New System.Windows.Forms.Label()
        Me.lblOn12 = New System.Windows.Forms.Label()
        Me.btnImport = New System.Windows.Forms.Button()
        Me.lstBuildings = New System.Windows.Forms.ListBox()
        CType(Me.picBuilding, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpType.SuspendLayout()
        Me.SuspendLayout()
        '
        'picBuilding
        '
        Me.picBuilding.Image = Global.BuildingProject.My.Resources.Resources.metalBuilding
        Me.picBuilding.Location = New System.Drawing.Point(0, -1)
        Me.picBuilding.Name = "picBuilding"
        Me.picBuilding.Size = New System.Drawing.Size(378, 265)
        Me.picBuilding.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBuilding.TabIndex = 0
        Me.picBuilding.TabStop = False
        '
        'lblBuildingInfo
        '
        Me.lblBuildingInfo.AutoSize = True
        Me.lblBuildingInfo.Font = New System.Drawing.Font("Bookman Old Style", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBuildingInfo.Location = New System.Drawing.Point(412, 9)
        Me.lblBuildingInfo.Name = "lblBuildingInfo"
        Me.lblBuildingInfo.Size = New System.Drawing.Size(381, 35)
        Me.lblBuildingInfo.TabIndex = 1
        Me.lblBuildingInfo.Text = "Building Panel Coverage"
        '
        'btnCalculate
        '
        Me.btnCalculate.Font = New System.Drawing.Font("Bookman Old Style", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculate.Location = New System.Drawing.Point(132, 282)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(120, 25)
        Me.btnCalculate.TabIndex = 2
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'grpType
        '
        Me.grpType.BackColor = System.Drawing.Color.LemonChiffon
        Me.grpType.Controls.Add(Me.radSingleSlope)
        Me.grpType.Controls.Add(Me.radGable)
        Me.grpType.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpType.Location = New System.Drawing.Point(646, 220)
        Me.grpType.Name = "grpType"
        Me.grpType.Size = New System.Drawing.Size(142, 87)
        Me.grpType.TabIndex = 4
        Me.grpType.TabStop = False
        Me.grpType.Text = "Type of Building"
        '
        'radSingleSlope
        '
        Me.radSingleSlope.AutoSize = True
        Me.radSingleSlope.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radSingleSlope.Location = New System.Drawing.Point(7, 54)
        Me.radSingleSlope.Name = "radSingleSlope"
        Me.radSingleSlope.Size = New System.Drawing.Size(116, 24)
        Me.radSingleSlope.TabIndex = 1
        Me.radSingleSlope.TabStop = True
        Me.radSingleSlope.Text = "Single Slope"
        Me.radSingleSlope.UseVisualStyleBackColor = True
        '
        'radGable
        '
        Me.radGable.AutoSize = True
        Me.radGable.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radGable.Location = New System.Drawing.Point(7, 28)
        Me.radGable.Name = "radGable"
        Me.radGable.Size = New System.Drawing.Size(70, 24)
        Me.radGable.TabIndex = 0
        Me.radGable.TabStop = True
        Me.radGable.Text = "Gable"
        Me.radGable.UseVisualStyleBackColor = True
        '
        'lblWidth
        '
        Me.lblWidth.AutoSize = True
        Me.lblWidth.Font = New System.Drawing.Font("Courier New", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWidth.Location = New System.Drawing.Point(553, 81)
        Me.lblWidth.Name = "lblWidth"
        Me.lblWidth.Size = New System.Drawing.Size(75, 23)
        Me.lblWidth.TabIndex = 0
        Me.lblWidth.Text = "Width"
        '
        'txtWidth
        '
        Me.txtWidth.Font = New System.Drawing.Font("Courier New", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtWidth.Location = New System.Drawing.Point(557, 107)
        Me.txtWidth.Name = "txtWidth"
        Me.txtWidth.Size = New System.Drawing.Size(100, 31)
        Me.txtWidth.TabIndex = 1
        '
        'txtLength
        '
        Me.txtLength.Font = New System.Drawing.Font("Courier New", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLength.Location = New System.Drawing.Point(682, 107)
        Me.txtLength.Name = "txtLength"
        Me.txtLength.Size = New System.Drawing.Size(100, 31)
        Me.txtLength.TabIndex = 2
        '
        'lblLength
        '
        Me.lblLength.AutoSize = True
        Me.lblLength.Font = New System.Drawing.Font("Courier New", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLength.Location = New System.Drawing.Point(678, 81)
        Me.lblLength.Name = "lblLength"
        Me.lblLength.Size = New System.Drawing.Size(88, 23)
        Me.lblLength.TabIndex = 0
        Me.lblLength.Text = "Length"
        '
        'cboWall
        '
        Me.cboWall.Font = New System.Drawing.Font("Bookman Old Style", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboWall.FormattingEnabled = True
        Me.cboWall.Items.AddRange(New Object() {"12""", "18""", "24""", "30""", "36""", "42"""})
        Me.cboWall.Location = New System.Drawing.Point(416, 236)
        Me.cboWall.Name = "cboWall"
        Me.cboWall.Size = New System.Drawing.Size(121, 28)
        Me.cboWall.TabIndex = 5
        '
        'txtSlope
        '
        Me.txtSlope.Font = New System.Drawing.Font("Courier New", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSlope.Location = New System.Drawing.Point(557, 176)
        Me.txtSlope.Name = "txtSlope"
        Me.txtSlope.Size = New System.Drawing.Size(63, 31)
        Me.txtSlope.TabIndex = 3
        '
        'lblSlope
        '
        Me.lblSlope.AutoSize = True
        Me.lblSlope.Font = New System.Drawing.Font("Courier New", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSlope.Location = New System.Drawing.Point(553, 150)
        Me.lblSlope.Name = "lblSlope"
        Me.lblSlope.Size = New System.Drawing.Size(75, 23)
        Me.lblSlope.TabIndex = 6
        Me.lblSlope.Text = "Slope"
        '
        'lblInformation
        '
        Me.lblInformation.AutoSize = True
        Me.lblInformation.Font = New System.Drawing.Font("Bookman Old Style", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInformation.Location = New System.Drawing.Point(471, 47)
        Me.lblInformation.Name = "lblInformation"
        Me.lblInformation.Size = New System.Drawing.Size(282, 20)
        Me.lblInformation.TabIndex = 8
        Me.lblInformation.Text = "All dimensions are input in Inches"
        '
        'txtHeight
        '
        Me.txtHeight.Font = New System.Drawing.Font("Courier New", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHeight.Location = New System.Drawing.Point(682, 176)
        Me.txtHeight.Name = "txtHeight"
        Me.txtHeight.Size = New System.Drawing.Size(100, 31)
        Me.txtHeight.TabIndex = 4
        '
        'lblHeight
        '
        Me.lblHeight.AutoSize = True
        Me.lblHeight.Font = New System.Drawing.Font("Courier New", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeight.Location = New System.Drawing.Point(678, 150)
        Me.lblHeight.Name = "lblHeight"
        Me.lblHeight.Size = New System.Drawing.Size(88, 23)
        Me.lblHeight.TabIndex = 9
        Me.lblHeight.Text = "Height"
        '
        'lblPnlWidth
        '
        Me.lblPnlWidth.AutoSize = True
        Me.lblPnlWidth.Font = New System.Drawing.Font("Courier New", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPnlWidth.Location = New System.Drawing.Point(412, 210)
        Me.lblPnlWidth.Name = "lblPnlWidth"
        Me.lblPnlWidth.Size = New System.Drawing.Size(218, 23)
        Me.lblPnlWidth.TabIndex = 11
        Me.lblPnlWidth.Text = "Wall Panel Width"
        '
        'lblRoofPnlWidth
        '
        Me.lblRoofPnlWidth.AutoSize = True
        Me.lblRoofPnlWidth.Font = New System.Drawing.Font("Courier New", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRoofPnlWidth.Location = New System.Drawing.Point(412, 267)
        Me.lblRoofPnlWidth.Name = "lblRoofPnlWidth"
        Me.lblRoofPnlWidth.Size = New System.Drawing.Size(218, 23)
        Me.lblRoofPnlWidth.TabIndex = 13
        Me.lblRoofPnlWidth.Text = "Roof Panel Width"
        '
        'cboRoof
        '
        Me.cboRoof.Font = New System.Drawing.Font("Bookman Old Style", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboRoof.FormattingEnabled = True
        Me.cboRoof.Items.AddRange(New Object() {"16""", "24""", "36"""})
        Me.cboRoof.Location = New System.Drawing.Point(416, 293)
        Me.cboRoof.Name = "cboRoof"
        Me.cboRoof.Size = New System.Drawing.Size(121, 28)
        Me.cboRoof.TabIndex = 6
        '
        'btnClear
        '
        Me.btnClear.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClear.Font = New System.Drawing.Font("Bookman Old Style", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(258, 282)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(120, 25)
        Me.btnClear.TabIndex = 14
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'lblSideWallInfo
        '
        Me.lblSideWallInfo.AutoSize = True
        Me.lblSideWallInfo.Font = New System.Drawing.Font("Bookman Old Style", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSideWallInfo.Location = New System.Drawing.Point(12, 372)
        Me.lblSideWallInfo.Name = "lblSideWallInfo"
        Me.lblSideWallInfo.Size = New System.Drawing.Size(561, 24)
        Me.lblSideWallInfo.TabIndex = 15
        Me.lblSideWallInfo.Text = "Total Number of Wall Panels:  XXX at 1000.00 inches"
        '
        'lblRoofInfo
        '
        Me.lblRoofInfo.AutoSize = True
        Me.lblRoofInfo.Font = New System.Drawing.Font("Bookman Old Style", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRoofInfo.Location = New System.Drawing.Point(12, 339)
        Me.lblRoofInfo.Name = "lblRoofInfo"
        Me.lblRoofInfo.Size = New System.Drawing.Size(556, 24)
        Me.lblRoofInfo.TabIndex = 16
        Me.lblRoofInfo.Text = "Total Number of Roof Panels: XXX at 1000.00 inches"
        '
        'lblEndWallInfo
        '
        Me.lblEndWallInfo.AutoSize = True
        Me.lblEndWallInfo.Font = New System.Drawing.Font("Bookman Old Style", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEndWallInfo.Location = New System.Drawing.Point(12, 406)
        Me.lblEndWallInfo.Name = "lblEndWallInfo"
        Me.lblEndWallInfo.Size = New System.Drawing.Size(561, 24)
        Me.lblEndWallInfo.TabIndex = 15
        Me.lblEndWallInfo.Text = "Total Number of Wall Panels:  XXX at 1000.00 inches"
        '
        'lblOn12
        '
        Me.lblOn12.Font = New System.Drawing.Font("Courier New", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOn12.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblOn12.Location = New System.Drawing.Point(617, 179)
        Me.lblOn12.Name = "lblOn12"
        Me.lblOn12.Size = New System.Drawing.Size(50, 23)
        Me.lblOn12.TabIndex = 17
        Me.lblOn12.Text = ":12"
        Me.lblOn12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnImport
        '
        Me.btnImport.Font = New System.Drawing.Font("Bookman Old Style", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnImport.Location = New System.Drawing.Point(6, 282)
        Me.btnImport.Name = "btnImport"
        Me.btnImport.Size = New System.Drawing.Size(120, 25)
        Me.btnImport.TabIndex = 18
        Me.btnImport.Text = "Import"
        Me.btnImport.UseVisualStyleBackColor = True
        '
        'lstBuildings
        '
        Me.lstBuildings.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstBuildings.FormattingEnabled = True
        Me.lstBuildings.ItemHeight = 18
        Me.lstBuildings.Location = New System.Drawing.Point(416, 81)
        Me.lstBuildings.Name = "lstBuildings"
        Me.lstBuildings.Size = New System.Drawing.Size(120, 94)
        Me.lstBuildings.TabIndex = 19
        '
        'frmBuilding
        '
        Me.AcceptButton = Me.btnCalculate
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Khaki
        Me.CancelButton = Me.btnClear
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lstBuildings)
        Me.Controls.Add(Me.btnImport)
        Me.Controls.Add(Me.lblOn12)
        Me.Controls.Add(Me.lblRoofInfo)
        Me.Controls.Add(Me.lblEndWallInfo)
        Me.Controls.Add(Me.lblSideWallInfo)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.lblRoofPnlWidth)
        Me.Controls.Add(Me.cboRoof)
        Me.Controls.Add(Me.lblPnlWidth)
        Me.Controls.Add(Me.txtHeight)
        Me.Controls.Add(Me.lblHeight)
        Me.Controls.Add(Me.lblInformation)
        Me.Controls.Add(Me.txtSlope)
        Me.Controls.Add(Me.lblSlope)
        Me.Controls.Add(Me.cboWall)
        Me.Controls.Add(Me.txtLength)
        Me.Controls.Add(Me.lblWidth)
        Me.Controls.Add(Me.lblLength)
        Me.Controls.Add(Me.txtWidth)
        Me.Controls.Add(Me.grpType)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.lblBuildingInfo)
        Me.Controls.Add(Me.picBuilding)
        Me.Name = "frmBuilding"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Building Panel Coverage"
        CType(Me.picBuilding, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpType.ResumeLayout(False)
        Me.grpType.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picBuilding As PictureBox
    Friend WithEvents lblBuildingInfo As Label
    Friend WithEvents btnCalculate As Button
    Friend WithEvents grpType As GroupBox
    Friend WithEvents radSingleSlope As RadioButton
    Friend WithEvents radGable As RadioButton
    Friend WithEvents lblWidth As Label
    Friend WithEvents txtWidth As TextBox
    Friend WithEvents txtLength As TextBox
    Friend WithEvents lblLength As Label
    Friend WithEvents cboWall As ComboBox
    Friend WithEvents txtSlope As TextBox
    Friend WithEvents lblSlope As Label
    Friend WithEvents lblInformation As Label
    Friend WithEvents txtHeight As TextBox
    Friend WithEvents lblHeight As Label
    Friend WithEvents lblPnlWidth As Label
    Friend WithEvents lblRoofPnlWidth As Label
    Friend WithEvents cboRoof As ComboBox
    Friend WithEvents btnClear As Button
    Friend WithEvents lblSideWallInfo As Label
    Friend WithEvents lblRoofInfo As Label
    Friend WithEvents lblEndWallInfo As Label
    Friend WithEvents lblOn12 As Label
    Friend WithEvents btnImport As Button
    Friend WithEvents lstBuildings As ListBox
End Class
