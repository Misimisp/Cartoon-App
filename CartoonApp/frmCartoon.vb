#Region "Namespaces"

Imports System.Drawing
Imports System.Drawing.Imaging
Imports System.Drawing.Drawing2D

#End Region

Public Class frmCartoon

#Region "Global Declaration"

    Private drawingPen As Pen
    Public Shared theFont As Font
    Private bitmapObject As Bitmap
    Public Shared theText As String
    Private graphicsObject As Graphics
    Public Shared theFontColor As Color
    Private drawStickWoman As Boolean = False
    ReadOnly UndoStack As New Stack(Of Bitmap)
    ReadOnly RedoStack As New Stack(Of Bitmap)
    Private drawStickManArmsUp As Boolean = False
    Private drawStickManStraight As Boolean = False
    Private drawStickManArmsDown As Boolean = False
    Private mouseX, mouseY, mouseX1, mouseY1 As Integer

#End Region

#Region "Coding Area"

    Private Sub FMLoad()
        drawingPen = New Pen(Color.Black) With {
                                            .DashStyle = Drawing2D.DashStyle.Solid,
                                            .Width = TrackBrushSize.Value}

        PbSurface.Cursor = Cursors.Cross
        bitmapObject = New Bitmap(PbSurface.Width, PbSurface.Height)
        graphicsObject = Graphics.FromImage(bitmapObject)

        'ACTIVATE ONLY ARMS STRAUGHT BUTTONS
        GetArmsStraight()

        For Each inbuiltColor As KnownColor In [Enum].GetValues(GetType(KnownColor))
            Dim loadColor As Color = Color.FromKnownColor(inbuiltColor)
            Select Case loadColor.IsSystemColor = False
                Case True
                    Select Case loadColor.Name <> "Transparent"
                        Case True
                            cmbColors.Items.Add(loadColor.Name)
                    End Select
            End Select
        Next

        AddHandler RadioSolid.Click, AddressOf GetSolidColorPen
        AddHandler RadioDashed.Click, AddressOf GetDashColorPen
        AddHandler btnRed.ClickButtonArea, AddressOf GetColorRed
        AddHandler btnArmsUp.ClickButtonArea, AddressOf GetArmsUp
        AddHandler btnGray.ClickButtonArea, AddressOf GetColorGray
        AddHandler btnBlue.ClickButtonArea, AddressOf GetColorBlue
        AddHandler btnSave.ClickButtonArea, AddressOf SaveImageDraw
        AddHandler btnUndo.ClickButtonArea, AddressOf UndoDrawImage
        AddHandler btnRedo.ClickButtonArea, AddressOf RedoDrawImage
        AddHandler btnBlack.ClickButtonArea, AddressOf GetColorBlack
        AddHandler btnWhite.ClickButtonArea, AddressOf GetColorWhite
        AddHandler btnGreen.ClickButtonArea, AddressOf GetColorGreen
        AddHandler btnClear.ClickButtonArea, AddressOf ClearImageDraw
        AddHandler btnArmsDown.ClickButtonArea, AddressOf GetArmsDown
        AddHandler TrackBrushSize.Scroll, AddressOf GetTrackBrushSize
        AddHandler btnYellow.ClickButtonArea, AddressOf GetColorYellow
        AddHandler btnLoadBGImage.ClickButtonArea, AddressOf LoadBGImage
        AddHandler btnStickWoman.ClickButtonArea, AddressOf GetStickWoman
        AddHandler cmbColors.SelectedIndexChanged, AddressOf GetBackground
        AddHandler btnCustomColor.ClickButtonArea, AddressOf CustomizeColorB
        AddHandler btnArmsStraight.ClickButtonArea, AddressOf GetArmsStraight


    End Sub 'Get all form objects active

    Private Sub GetBackground()
        lblPenColor.BackColor = Color.FromName(cmbColors.Text)
        drawingPen.Color = Color.FromName(cmbColors.Text)
    End Sub 'Get background color of the picture

    Private Sub CustomizeColorB()
        Dim ColorDB As New ColorDialog
        Select Case ColorDB.ShowDialog() <> DialogResult.Cancel
            Case True
                If rbPenColor.Checked Then
                    lblPenColor.BackColor = ColorDB.Color
                    drawingPen.Color = ColorDB.Color
                ElseIf rbBGColor.Checked Then
                    PbSurface.BackColor = ColorDB.Color
                    lblBGColor.BackColor = ColorDB.Color
                End If
        End Select
    End Sub 'Get color from custom color

    Private Sub DrawImageMove(e As MouseEventArgs)
        Select Case e.Button = MouseButtons.Left
            Case True
                mouseX1 = e.X
                mouseY1 = e.Y
                graphicsObject.SmoothingMode = SmoothingMode.AntiAlias

                Select Case drawStickWoman
                    Case True
                        DrawStickLady()
                    Case Else
                        DrawStickMan()
                End Select
                PbSurface.Invalidate()
        End Select
    End Sub 'Drawing image part

    Private Sub DrawImageDown(e As MouseEventArgs)
        If e.Button = MouseButtons.Right Then
            Dim rightClickX As Integer = e.X
            Dim rightClickY As Integer = e.Y

            Select Case frmAddText.ShowDialog() = DialogResult.OK
                Case True
                    UndoStack.Push(bitmapObject.Clone)
                    RedoStack.Clear()

                    Dim chosenFont As Font = New Font(theFont.FontFamily, theFont.Size, theFont.Style)
                    Dim chosenBrush As SolidBrush = New SolidBrush(theFontColor)

                    graphicsObject.TextRenderingHint = Drawing.Text.TextRenderingHint.AntiAlias
                    graphicsObject.DrawString(theText, chosenFont, chosenBrush, rightClickX, rightClickY)
                    PbSurface.Invalidate()
                    frmAddText.Dispose()
            End Select
        ElseIf e.Button = MouseButtons.Left Then
            mouseX = e.X
            mouseY = e.Y
            UndoStack.Push(bitmapObject.Clone)
            RedoStack.Clear()
        End If
    End Sub

    Private Sub DrawStickMan()
        Dim size As New StickFigureDimensions(mouseY, mouseY1)

        'Draw Head
        graphicsObject.DrawEllipse(drawingPen, mouseX, mouseY, size.HeadDiameter, size.HeadDiameter)

        'Draw Body
        graphicsObject.DrawLine(drawingPen, mouseX + size.HeadRadius, mouseY + size.HeadDiameter, mouseX + size.HeadRadius, mouseY + size.HeadDiameter + size.BodySize)

        'Draw right leg
        graphicsObject.DrawLine(drawingPen, mouseX + size.HeadRadius, mouseY + (size.HeadDiameter + size.BodySize), mouseX + (size.HeadRadius + size.BaseUnit * 2), mouseY + (size.HeadDiameter + size.BodySize + size.LegSize))

        'Draw left leg
        graphicsObject.DrawLine(drawingPen, mouseX + size.HeadRadius, mouseY + (size.HeadDiameter + size.BodySize), mouseX + (size.HeadRadius - size.BaseUnit * 2), mouseY + (size.HeadDiameter + size.BodySize + size.LegSize))

        '========================================
        '       Code to raise arms
        '----------------------------------------
        'x1 = mouseX + size.HeadDiameter 
        'y1 = size.MidBody - size.BaseUnit * 2
        '=========================================

        If drawStickManStraight Then
            'Draw left arm
            graphicsObject.DrawLine(drawingPen, mouseX, size.MidBody, mouseX + size.HeadRadius, size.MidBody)

            'Draw right arm
            graphicsObject.DrawLine(drawingPen, mouseX + size.HeadRadius, size.MidBody, mouseX + size.HeadDiameter, size.MidBody)
        ElseIf drawStickManArmsUp Then
            'Draw left arm
            graphicsObject.DrawLine(drawingPen, mouseX, size.MidBody - (size.BaseUnit * 2), mouseX + size.HeadRadius, size.MidBody)

            'Draw right arm
            graphicsObject.DrawLine(drawingPen, mouseX + size.HeadRadius, size.MidBody, mouseX + size.HeadDiameter, size.MidBody - (size.BaseUnit * 2))
        ElseIf drawStickManArmsDown Then
            'Draw left arm
            graphicsObject.DrawLine(drawingPen, mouseX, size.MidBody + (size.BaseUnit * 2), mouseX + size.HeadRadius, size.MidBody)

            'Draw right arm
            graphicsObject.DrawLine(drawingPen, mouseX + size.HeadRadius, size.MidBody, mouseX + size.HeadDiameter, size.MidBody + (size.BaseUnit * 2))
        End If
    End Sub 'Drawing male stick figure

    Private Sub DrawStickLady()
        Dim size As New StickFigureDimensions(mouseY, mouseY1)
        Dim polygonPoints(2) As Point

        polygonPoints(0) = New Point(0, 0)
        polygonPoints(1) = New Point(0, 0)
        polygonPoints(2) = New Point(0, 0)

        polygonPoints(0).X = mouseX + size.HeadRadius
        polygonPoints(0).Y = mouseY + (size.HeadDiameter + drawingPen.Width)
        polygonPoints(1).X = mouseX + size.HeadDiameter
        polygonPoints(1).Y = mouseY + size.HeadDiameter + size.BodySize
        polygonPoints(2).X = mouseX
        polygonPoints(2).Y = mouseY + size.HeadDiameter + size.BodySize

        'Head
        graphicsObject.DrawEllipse(drawingPen, mouseX, mouseY, size.HeadDiameter, size.HeadDiameter)

        'Body
        graphicsObject.DrawPolygon(drawingPen, polygonPoints)

        'Left Arm
        graphicsObject.DrawLine(drawingPen, mouseX, size.MidBody, CInt(mouseX + (size.HeadRadius / 2)), size.MidBody)

        'Right Arm
        graphicsObject.DrawLine(drawingPen, CInt(mouseX + (size.HeadDiameter * 0.75)), size.MidBody, mouseX + size.HeadDiameter, size.MidBody)

        'Left Leg
        graphicsObject.DrawLine(drawingPen, CInt(mouseX + (size.HeadRadius / 2)), mouseY + size.HeadDiameter + size.BodySize, CInt(mouseX + (size.HeadRadius / 2)), mouseY + size.HeadDiameter + size.BodySize + size.LegSize)

        'Right Leg
        graphicsObject.DrawLine(drawingPen, CInt(mouseX + (size.HeadDiameter * 0.75)), mouseY + size.HeadDiameter + size.BodySize, CInt(mouseX + (size.HeadDiameter * 0.75)), mouseY + size.HeadDiameter + size.BodySize + size.LegSize)

    End Sub 'Drawing female stick figure

    Private Sub UndoDrawImage()
        Select Case UndoStack.Count > 0
            Case True
                RedoStack.Push(bitmapObject.Clone)
                bitmapObject = UndoStack.Pop()
                graphicsObject = Graphics.FromImage(bitmapObject)
                PbSurface.Invalidate()
            Case Else
                MessageBox.Show("Nothing to Undo", "Cartoon Application", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Select
    End Sub 'Undo drawn image(s)

    Private Sub RedoDrawImage()
        Select Case RedoStack.Count > 0
            Case True
                UndoStack.Push(bitmapObject.Clone)
                bitmapObject = RedoStack.Pop()
                graphicsObject = Graphics.FromImage(bitmapObject)
                PbSurface.Invalidate()
            Case Else
                MessageBox.Show("Nothing to Undo", "Cartoon Application", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Select
    End Sub 'Redo drawn image(s)

    Private Sub GetColorBlue()
        If rbPenColor.Checked Then
            drawingPen.Color = Color.Blue
            lblPenColor.BackColor = Color.Blue
        ElseIf rbBGColor.Checked Then
            PbSurface.BackColor = Color.Blue
            lblBGColor.BackColor = Color.Blue
            'BGSolidSave(PbSurface.Width, PbSurface.Height)
        End If
    End Sub 'Get color blue

    Private Sub GetColorRed()
        If rbPenColor.Checked Then
            drawingPen.Color = Color.Red
            lblPenColor.BackColor = Color.Red
        ElseIf rbBGColor.Checked Then
            PbSurface.BackColor = Color.Red
            lblBGColor.BackColor = Color.Red
            'BGSolidSave(PbSurface.Width, PbSurface.Height)
        End If
    End Sub 'Get color red

    Private Sub GetColorGreen()
        If rbPenColor.Checked Then
            drawingPen.Color = Color.Green
            lblPenColor.BackColor = Color.Green
        ElseIf rbBGColor.Checked Then
            PbSurface.BackColor = Color.Green
            lblBGColor.BackColor = Color.Green
            'BGSolidSave(PbSurface.Width, PbSurface.Height)
        End If
    End Sub 'Get color green

    Private Sub GetColorYellow()
        If rbPenColor.Checked Then
            drawingPen.Color = Color.Yellow
            lblPenColor.BackColor = Color.Yellow
        ElseIf rbBGColor.Checked Then
            PbSurface.BackColor = Color.Yellow
            lblBGColor.BackColor = Color.Yellow
            'BGSolidSave(PbSurface.Width, PbSurface.Height)
        End If
    End Sub 'Get color yellow

    Private Sub GetColorBlack()
        If rbPenColor.Checked Then
            drawingPen.Color = Color.Black
            lblPenColor.BackColor = Color.Black
        ElseIf rbBGColor.Checked Then
            PbSurface.BackColor = Color.Black
            lblBGColor.BackColor = Color.Black
            'BGSolidSave(PbSurface.Width, PbSurface.Height)
        End If
    End Sub 'Get color black

    Private Sub GetColorGray()
        If rbPenColor.Checked Then
            drawingPen.Color = Color.Gray
            lblPenColor.BackColor = Color.Gray
        ElseIf rbBGColor.Checked Then
            PbSurface.BackColor = Color.Gray
            lblBGColor.BackColor = Color.Gray
            'BGSolidSave(PbSurface.Width, PbSurface.Height)
        End If
    End Sub 'Get color gray

    Private Sub GetColorWhite()
        If rbPenColor.Checked Then
            drawingPen.Color = Color.White
            lblPenColor.BackColor = Color.White
        ElseIf rbBGColor.Checked Then
            PbSurface.BackColor = Color.White
            lblBGColor.BackColor = Color.White
            'BGSolidSave(PbSurface.Width, PbSurface.Height)
        End If
    End Sub 'Get color white

    Private Sub GetArmsStraight()
        drawStickWoman = False
        drawStickManArmsUp = False
        drawStickManStraight = True
        drawStickManArmsDown = False
    End Sub 'Get straight arms

    Private Sub GetArmsUp()
        drawStickWoman = False
        drawStickManArmsUp = True
        drawStickManStraight = False
        drawStickManArmsDown = False
    End Sub 'Get Arms up

    Private Sub GetArmsDown()
        drawStickWoman = False
        drawStickManArmsUp = False
        drawStickManArmsDown = True
        drawStickManStraight = False
    End Sub 'Get arms down

    Private Sub GetStickWoman()
        drawStickWoman = True
        drawStickManArmsUp = False
        drawStickManArmsDown = False
        drawStickManStraight = False
    End Sub 'Get stick female

    Private Sub SaveImageDraw()
        Dim SaveDB As New SaveFileDialog With {
                                    .InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
                                    .DefaultExt = "png",
                                    .Filter = " Png|*.png."}

        Select Case SaveDB.ShowDialog() <> DialogResult.Cancel
            Case True
                Dim savePath As String = SaveDB.FileName
                Dim bmpImage As Bitmap = New Bitmap(bitmapObject)
                bmpImage.Save(savePath, ImageFormat.Png)
                bmpImage.Dispose()
        End Select
    End Sub 'Save image draw

    Private Sub ClearImageDraw()
        Dim stackCount As Integer = UndoStack.Count
        Dim loopCount As Integer = 0

        Select Case UndoStack.Count > 0
            Case True
                Do
                    bitmapObject = UndoStack.Pop()
                    graphicsObject = Graphics.FromImage(bitmapObject)
                    PbSurface.Invalidate()
                    loopCount += 1
                Loop While loopCount < stackCount
        End Select
    End Sub 'Clear image draw

    Private Sub GetTrackBrushSize()
        drawingPen.Width = TrackBrushSize.Value
    End Sub 'Get track value for pen size

    Private Sub GetSolidColorPen()
        drawingPen.DashStyle = DashStyle.Solid
    End Sub 'Get solid pen style 

    Private Sub GetDashColorPen()
        drawingPen.DashStyle = DashStyle.Dash
    End Sub 'Get dash pen style 

    Private Sub LoadBGImage()
        Dim OpenFD As New OpenFileDialog With {
                                        .InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures),
                                        .Title = "Open an Image",
                                        .Filter = "jpegs|*.jpg|gifs|*.gif|Bitmaps|*.bmp",
                                        .Multiselect = False}
        Select Case OpenFD.ShowDialog() <> DialogResult.Cancel
            Case True
                UndoStack.Push(bitmapObject.Clone)
                RedoStack.Clear()
                Dim ImgPath As String = OpenFD.FileName
                Dim img As Image = Image.FromFile(ImgPath)
                bitmapObject = New Bitmap(img)
                graphicsObject = Graphics.FromImage(bitmapObject)
                OpenFD.Reset()
        End Select
    End Sub

    Private Sub BGSolidSave(bbmp As Bitmap)
        UndoStack.Push(bitmapObject.Clone)
        RedoStack.Clear()
        bitmapObject = New Bitmap(bbmp.Width, bbmp.Height)
        graphicsObject = Graphics.FromImage(bitmapObject)
    End Sub

#End Region 'Coding arena




#Region "Activities Area"

    Private Sub pnlHeader_MouseDown(sender As Object, e As MouseEventArgs) Handles pnlHeader.MouseDown
        MouseD(Me)
    End Sub

    Private Sub pnlHeader_MouseMove(sender As Object, e As MouseEventArgs) Handles pnlHeader.MouseMove
        MouseM(Me)
    End Sub

    Private Sub pnlHeader_MouseUp(sender As Object, e As MouseEventArgs) Handles pnlHeader.MouseUp
        MouseU()
    End Sub

    Private Sub btnClose_ClickButtonArea(Sender As Object, e As MouseEventArgs) Handles btnClose.ClickButtonArea
        End
    End Sub

    Private Sub frmCartoon_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FMLoad()
    End Sub

    Private Sub PbSurface_MouseDown(sender As Object, e As MouseEventArgs) Handles PbSurface.MouseDown
        DrawImageDown(e)
    End Sub

    Private Sub PbSurface_MouseUp(sender As Object, e As MouseEventArgs) Handles PbSurface.MouseUp
        DrawImageMove(e)
    End Sub

    Private Sub PbSurface_Paint(sender As Object, e As PaintEventArgs) Handles PbSurface.Paint
        e.Graphics.DrawImage(bitmapObject, 0, 0)
    End Sub

#End Region
End Class
