Imports System.Drawing.Text

Public Class frmAddText

#Region ""

    Private fontColor As Color
    Private style As FontStyle
    Private fontSize As Decimal
    Private fontFamily As String
    Private IsFontSet As Boolean
    Private isFontColorSet As Boolean

#End Region 'GLOBAL DECLARATIOM

#Region "CODING ARENA"

    Private Sub TextFontLoad()
        Dim Fonts As New InstalledFontCollection
        For Each font As FontFamily In Fonts.Families
            CmbFontFamily.Items.Add(font.Name)
        Next

        isFontColorSet = False
        IsFontSet = False
        fontSize = 14

        AddHandler btnCancel.ClickButtonArea, AddressOf GetCancel
        AddHandler SpinFontSize.ValueChanged, AddressOf NumberFontSize
        AddHandler btnFontColor.ClickButtonArea, AddressOf GetFontColor
        AddHandler btnOK.ClickButtonArea, AddressOf SetTextFontSizeColor
        AddHandler CmbFontFamily.SelectedIndexChanged, AddressOf ComboFontChange
    End Sub

    Private Sub NumberFontSize()
        fontSize = SpinFontSize.Value
    End Sub

    Private Sub ComboFontChange()
        fontFamily = CmbFontFamily.Text
        isFontColorSet = True 'In case user like the color on the color label and don't want to choose another color or click the font color button
        IsFontSet = True
    End Sub

    Private Sub GetFontColor()
        Dim ColorDB As New ColorDialog
        Select ColorDB.ShowDialog() <> DialogResult.Cancel
            Case True
                isFontColorSet = True
                lblColor.BackColor = ColorDB.Color
        End Select
    End Sub

    Private Sub SetTextFontSizeColor()
        If CheckError(IsFontSet, "Set font from the dropdwon") = True Then Return
        If CheckError(isFontColorSet, "No Font color set") = True Then Return

        'Transfer label color to fontcolor
        fontColor = lblColor.BackColor

        style = GetFontStyle(RadioRegular, RadioBold, RadioItalic)

        Dim fontObject As New Font(fontFamily, fontSize, style)

        frmCartoon.theFont = fontObject
        frmCartoon.theFontColor = fontColor
        frmCartoon.theText = TextboxStickFigure.Text

        DialogResult = DialogResult.OK
    End Sub

    Private Sub GetCancel()
        DialogResult = DialogResult.Cancel
    End Sub



#End Region 'CODING ARENA

    Private Sub pnlHeader_MouseDown(sender As Object, e As MouseEventArgs) Handles pnlHeader.MouseDown, btnHeader.MouseDown
        MouseD(Me)
    End Sub

    Private Sub pnlHeader_MouseMove(sender As Object, e As MouseEventArgs) Handles pnlHeader.MouseMove, btnHeader.MouseMove
        MouseM(Me)
    End Sub

    Private Sub pnlHeader_MouseUp(sender As Object, e As MouseEventArgs) Handles pnlHeader.MouseUp, btnHeader.MouseUp
        MouseU()
    End Sub

    Private Sub btnClose_ClickButtonArea(Sender As Object, e As MouseEventArgs) Handles btnClose.ClickButtonArea
        Me.Close()
    End Sub

    Private Sub frmAddText_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextFontLoad()
    End Sub

End Class