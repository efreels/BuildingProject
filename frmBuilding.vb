Imports System.IO

Public Class frmBuilding
    Dim decDiagonal As Decimal
    Dim decDistanceToRidge As Decimal
    Dim decRise As Decimal
    Dim intNumRoofPnl As Integer
    Dim intNumSideWallPnl As Integer
    Dim intNumEndWallPnl As Integer
    Dim decSideWallPnlLength As Decimal
    Dim decEndWallPnlLength As Decimal
    Dim objReader As IO.StreamReader
    Dim _intArraySize As Integer = 4
    Dim _decWidth(_intArraySize) As Decimal
    Dim _decLength(_intArraySize) As Decimal
    Dim _decSlope(_intArraySize) As Decimal
    Dim _decHeight(_intArraySize) As Decimal
    Dim _strRoof(_intArraySize) As String
    Dim _strWall(_intArraySize) As String
    Dim _strType(_intArraySize) As String

    Private Sub ClearForm()
        'Clears the form to be ready for manual input or to import a new file
        lstBuildings.Items.Clear()
        radGable.Checked = True
        radSingleSlope.Checked = False
        txtWidth.Clear()
        txtHeight.Clear()
        txtLength.Clear()
        txtSlope.Clear()
        cboRoof.Text = "Panel Width"
        cboWall.Text = "Panel Width"
        btnCalculate.Enabled = False
        lblRoofInfo.Visible = False
        lblSideWallInfo.Visible = False
        lblEndWallInfo.Visible = False
        txtWidth.Focus()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ClearForm()
    End Sub

    Private Sub frmBuilding_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnClear.PerformClick()
    End Sub

    Private Sub txtWidth_TextChanged(sender As Object, e As EventArgs) Handles txtWidth.TextChanged
        If txtWidth.Text <> "" Then
            If IsNumeric(txtWidth.Text) Then
                If Convert.ToDecimal(txtWidth.Text) > 0 Then
                    EnableButton()
                Else
                    MsgBox("Please enter width as a positive numeric value in decimal inches",, "ERROR:  Negative Number!")
                End If
            Else
                MsgBox("Please enter width in decimal inches",, "ERROR:  Non-numeric value!")
            End If
        End If
    End Sub

    Private Sub EnableButton()
        'The Calculate button will not be enabled until all fields are filled out.  All fields are checking if they are all filled out.
        If txtWidth.Text <> "" And txtHeight.Text <> "" And txtLength.Text <> "" And txtSlope.Text <> "" And cboRoof.SelectedIndex > -1 And cboWall.SelectedIndex > -1 Then
            btnCalculate.Enabled = True
        End If
    End Sub

    Private Sub txtLength_TextChanged(sender As Object, e As EventArgs) Handles txtLength.TextChanged
        If txtLength.Text <> "" Then
            If IsNumeric(txtLength.Text) Then
                If Convert.ToDecimal(txtLength.Text) > 0 Then
                    EnableButton()
                Else
                    MsgBox("Please enter length as a positive numeric value in decimal inches",, "ERROR:  Negative Number!")
                End If
            Else
                MsgBox("Please enter length in decimal inches",, "ERROR:  Non-numeric value!")
            End If
        End If
    End Sub

    Private Sub txtSlope_TextChanged(sender As Object, e As EventArgs) Handles txtSlope.TextChanged
        If txtSlope.Text <> "" Then
            If IsNumeric(txtSlope.Text) Then
                If Convert.ToDecimal(txtSlope.Text) > 0 Then
                    EnableButton()
                Else
                    MsgBox("Please enter slope as a positive numeric value in decimal inches",, "ERROR:  Negative Number!")
                End If
            Else
                MsgBox("Please enter slope in decimal inches",, "ERROR:  Non-numeric value!")
            End If
        End If
    End Sub

    Private Sub txtHeight_TextChanged(sender As Object, e As EventArgs) Handles txtHeight.TextChanged
        If txtHeight.Text <> "" Then
            If IsNumeric(txtHeight.Text) Then
                If Convert.ToDecimal(txtHeight.Text) > 0 Then
                    EnableButton()
                Else
                    MsgBox("Please enter height as a positive numeric value in decimal inches",, "ERROR:  Negative Number!")
                End If
            Else
                MsgBox("Please enter height in decimal inches",, "ERROR:  Non-numeric value!")
            End If
        End If
    End Sub

    Private Sub cboWall_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboWall.SelectedIndexChanged
        EnableButton()
    End Sub

    Private Sub cboRoof_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboRoof.SelectedIndexChanged
        EnableButton()
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        'Calculates all panel lengths and number of panels
        CalculateRoofLength()
        NumberOfRoofPanels()
        lblRoofInfo.Text = "Total Number of Roof Panels:  " + intNumRoofPnl.ToString() + " at " + decDiagonal.ToString() + " inches"
        NumberOfWallPanels()
        CalculateWallPanelLength()
        lblSideWallInfo.Text = "Total Number of Wall Panels on Side Walls:  " + intNumSideWallPnl.ToString() + " at " + decSideWallPnlLength.ToString() + " inches"
        lblEndWallInfo.Text = "Total Number of Wall Panels on End Walls:  " + intNumEndWallPnl.ToString() + " at " + decEndWallPnlLength.ToString() + " inches (on average)"
        lblRoofInfo.Visible = True
        lblSideWallInfo.Visible = True
        lblEndWallInfo.Visible = True
    End Sub

    Private Sub CalculateRoofLength()
        'Calculates the diagonal of the roof by determining the distance to the ridge and then calculates the panel length using the rise (slope)
        If radGable.Checked Then
            decDistanceToRidge = Convert.ToDecimal(txtWidth.Text) / 2
        Else
            decDistanceToRidge = Convert.ToDecimal(txtWidth.Text)
        End If

        decRise = decDistanceToRidge / 12 * Convert.ToDecimal(txtSlope.Text)
        decDiagonal = Math.Round(Math.Sqrt(decDistanceToRidge * decDistanceToRidge + decRise * decRise), 3)
    End Sub

    Private Sub NumberOfRoofPanels()
        'Gets the number of roof panels that are needed to cover the roof (rounding to the nearest whole number)
        intNumRoofPnl = Math.Ceiling(Convert.ToDecimal(txtLength.Text) / Convert.ToInt32(cboRoof.SelectedItem.ToString.Substring(0, 2)))
    End Sub

    Private Sub NumberOfWallPanels()
        'Gets the number of wall panels that are needed to cover the 4 walls (2 end walls and 2 side walls) rounding to the nearest whole number for each wall
        intNumSideWallPnl = Math.Ceiling(Convert.ToDecimal(txtLength.Text) / Convert.ToInt32(cboWall.SelectedItem.ToString.Substring(0, 2))) * 2
        intNumEndWallPnl = Math.Ceiling(Convert.ToDecimal(txtWidth.Text) / Convert.ToInt32(cboWall.SelectedItem.ToString.Substring(0, 2))) * 2
    End Sub

    Private Sub CalculateWallPanelLength()
        'Calculates the wall panel lengths (sidewall is just the panel height while end wall will be the average panel length)
        decSideWallPnlLength = Math.Round(Convert.ToDecimal(txtHeight.Text), 3)
        decEndWallPnlLength = Math.Round(Convert.ToDecimal(txtHeight.Text) + decRise / 2, 3)
    End Sub

    Private Sub lstBuildings_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstBuildings.SelectedIndexChanged
        'Loads all fields depending on which building is selected in the list
        txtWidth.Text = _decWidth(lstBuildings.SelectedIndex).ToString()
        txtLength.Text = _decLength(lstBuildings.SelectedIndex).ToString()
        txtSlope.Text = _decSlope(lstBuildings.SelectedIndex).ToString()
        txtHeight.Text = _decHeight(lstBuildings.SelectedIndex).ToString()
        cboRoof.SelectedItem = _strRoof(lstBuildings.SelectedIndex)
        cboWall.SelectedItem = _strWall(lstBuildings.SelectedIndex)
        If _strType(lstBuildings.SelectedIndex) = "Gable" Then
            radGable.Checked = True
        Else
            radSingleSlope.Checked = True
        End If
    End Sub

    Private Sub btnImport_Click(sender As Object, e As EventArgs) Handles btnImport.Click
        'Imports up to 5 buildings from a file.  If the file is not found, an error message is displayed
        Try
            Dim intCount = 0
            objReader = IO.File.OpenText("C:\VB\buildings.txt")
            Do While objReader.Peek <> -1
                lstBuildings.Items.Add(objReader.ReadLine())
                _decWidth(intCount) = objReader.ReadLine()
                _decLength(intCount) = objReader.ReadLine()
                _decSlope(intCount) = objReader.ReadLine()
                _decHeight(intCount) = objReader.ReadLine()
                _strWall(intCount) = objReader.ReadLine()
                _strRoof(intCount) = objReader.ReadLine()
                _strType(intCount) = objReader.ReadLine()
                intCount += 1
            Loop
            objReader.Close()
        Catch ex As FileNotFoundException
            MsgBox("The file is not available.  Please check the file and restart the program",, "Error")
            Close()
        End Try
    End Sub
End Class
