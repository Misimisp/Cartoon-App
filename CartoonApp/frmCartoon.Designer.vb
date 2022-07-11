<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCartoon
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
        Me.components = New System.ComponentModel.Container()
        Dim CBlendItems1 As CButtonLib.cBlendItems = New CButtonLib.cBlendItems()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCartoon))
        Dim CBlendItems2 As CButtonLib.cBlendItems = New CButtonLib.cBlendItems()
        Dim CBlendItems3 As CButtonLib.cBlendItems = New CButtonLib.cBlendItems()
        Dim CBlendItems4 As CButtonLib.cBlendItems = New CButtonLib.cBlendItems()
        Dim CBlendItems5 As CButtonLib.cBlendItems = New CButtonLib.cBlendItems()
        Dim CBlendItems6 As CButtonLib.cBlendItems = New CButtonLib.cBlendItems()
        Dim CBlendItems7 As CButtonLib.cBlendItems = New CButtonLib.cBlendItems()
        Dim CBlendItems8 As CButtonLib.cBlendItems = New CButtonLib.cBlendItems()
        Dim CBlendItems10 As CButtonLib.cBlendItems = New CButtonLib.cBlendItems()
        Dim CBlendItems11 As CButtonLib.cBlendItems = New CButtonLib.cBlendItems()
        Dim CBlendItems12 As CButtonLib.cBlendItems = New CButtonLib.cBlendItems()
        Dim CBlendItems13 As CButtonLib.cBlendItems = New CButtonLib.cBlendItems()
        Dim CBlendItems14 As CButtonLib.cBlendItems = New CButtonLib.cBlendItems()
        Dim CBlendItems9 As CButtonLib.cBlendItems = New CButtonLib.cBlendItems()
        Me.CButton2 = New CButtonLib.CButton()
        Me.btnClose = New CButtonLib.CButton()
        Me.pnlHeader = New System.Windows.Forms.Panel()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.RadioDashed = New System.Windows.Forms.RadioButton()
        Me.RadioSolid = New System.Windows.Forms.RadioButton()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.btnClear = New CButtonLib.CButton()
        Me.btnSave = New CButtonLib.CButton()
        Me.btnRedo = New CButtonLib.CButton()
        Me.btnUndo = New CButtonLib.CButton()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GLabel5 = New gLabel.gLabel()
        Me.GLabel4 = New gLabel.gLabel()
        Me.GLabel3 = New gLabel.gLabel()
        Me.TrackBrushSize = New System.Windows.Forms.TrackBar()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnWhite = New CButtonLib.CButton()
        Me.btnLoadBGImage = New CButtonLib.CButton()
        Me.rbBGColor = New System.Windows.Forms.RadioButton()
        Me.rbPenColor = New System.Windows.Forms.RadioButton()
        Me.lblBGColor = New gLabel.gLabel()
        Me.lblPenColor = New gLabel.gLabel()
        Me.btnCustomColor = New CButtonLib.CButton()
        Me.btnGray = New CButtonLib.CButton()
        Me.btnGreen = New CButtonLib.CButton()
        Me.btnBlack = New CButtonLib.CButton()
        Me.btnRed = New CButtonLib.CButton()
        Me.btnYellow = New CButtonLib.CButton()
        Me.cmbColors = New System.Windows.Forms.ComboBox()
        Me.btnBlue = New CButtonLib.CButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnArmNeck = New CButtonLib.CButton()
        Me.btnStickWoman = New CButtonLib.CButton()
        Me.btnArmsDown = New CButtonLib.CButton()
        Me.btnArmsUp = New CButtonLib.CButton()
        Me.btnArmsStraight = New CButtonLib.CButton()
        Me.PbSurface = New System.Windows.Forms.PictureBox()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.btnAgryMan = New CButtonLib.CButton()
        Me.pnlHeader.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.TrackBrushSize, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PbSurface, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CButton2
        '
        Me.CButton2.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        CBlendItems1.iColor = New System.Drawing.Color() {System.Drawing.Color.White, System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))}
        CBlendItems1.iPoint = New Single() {0.0!, 0.2469136!, 1.0!}
        Me.CButton2.ColorFillBlend = CBlendItems1
        Me.CButton2.ColorFillSolid = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.CButton2.Corners.All = 15
        Me.CButton2.Corners.LowerLeft = 15
        Me.CButton2.Corners.LowerRight = 15
        Me.CButton2.Corners.UpperLeft = 15
        Me.CButton2.Corners.UpperRight = 15
        Me.CButton2.DesignerSelected = False
        Me.CButton2.FillType = CButtonLib.CButton.eFillType.Solid
        Me.CButton2.ImageIndex = 0
        Me.CButton2.Location = New System.Drawing.Point(3, 3)
        Me.CButton2.Name = "CButton2"
        Me.CButton2.SideImage = CType(resources.GetObject("CButton2.SideImage"), System.Drawing.Image)
        Me.CButton2.SideImageSize = New System.Drawing.Size(32, 32)
        Me.CButton2.Size = New System.Drawing.Size(152, 31)
        Me.CButton2.TabIndex = 2
        Me.CButton2.Text = "Stick Figure Draw"
        Me.CButton2.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.CButton2.TextShadow = System.Drawing.Color.Gray
        '
        'btnClose
        '
        Me.btnClose.BorderColor = System.Drawing.Color.Red
        CBlendItems2.iColor = New System.Drawing.Color() {System.Drawing.Color.White, System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))}
        CBlendItems2.iPoint = New Single() {0.0!, 0.3240741!, 1.0!}
        Me.btnClose.ColorFillBlend = CBlendItems2
        Me.btnClose.DesignerSelected = False
        Me.btnClose.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnClose.FillType = CButtonLib.CButton.eFillType.GradientPath
        Me.btnClose.ImageIndex = 0
        Me.btnClose.Location = New System.Drawing.Point(833, 0)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(45, 37)
        Me.btnClose.TabIndex = 0
        Me.btnClose.Text = "X"
        Me.btnClose.TextShadow = System.Drawing.Color.Maroon
        '
        'pnlHeader
        '
        Me.pnlHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.pnlHeader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlHeader.Controls.Add(Me.CButton2)
        Me.pnlHeader.Controls.Add(Me.btnClose)
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
        Me.pnlHeader.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(880, 39)
        Me.pnlHeader.TabIndex = 1
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.RadioDashed)
        Me.GroupBox5.Controls.Add(Me.RadioSolid)
        Me.GroupBox5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.GroupBox5.Location = New System.Drawing.Point(392, 532)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(269, 76)
        Me.GroupBox5.TabIndex = 14
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Line Style"
        '
        'RadioDashed
        '
        Me.RadioDashed.AutoSize = True
        Me.RadioDashed.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RadioDashed.Location = New System.Drawing.Point(160, 29)
        Me.RadioDashed.Name = "RadioDashed"
        Me.RadioDashed.Size = New System.Drawing.Size(62, 17)
        Me.RadioDashed.TabIndex = 1
        Me.RadioDashed.Text = "Dashed"
        Me.RadioDashed.UseVisualStyleBackColor = True
        '
        'RadioSolid
        '
        Me.RadioSolid.AutoSize = True
        Me.RadioSolid.Checked = True
        Me.RadioSolid.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RadioSolid.Location = New System.Drawing.Point(52, 29)
        Me.RadioSolid.Name = "RadioSolid"
        Me.RadioSolid.Size = New System.Drawing.Size(48, 17)
        Me.RadioSolid.TabIndex = 0
        Me.RadioSolid.TabStop = True
        Me.RadioSolid.Text = "Solid"
        Me.RadioSolid.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.btnClear)
        Me.GroupBox4.Controls.Add(Me.btnSave)
        Me.GroupBox4.Controls.Add(Me.btnRedo)
        Me.GroupBox4.Controls.Add(Me.btnUndo)
        Me.GroupBox4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.GroupBox4.Location = New System.Drawing.Point(667, 429)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(188, 179)
        Me.GroupBox4.TabIndex = 13
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Actions"
        '
        'btnClear
        '
        Me.btnClear.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        CBlendItems3.iColor = New System.Drawing.Color() {System.Drawing.Color.White, System.Drawing.Color.Black, System.Drawing.Color.Black}
        CBlendItems3.iPoint = New Single() {0.0!, 0.4166667!, 1.0!}
        Me.btnClear.ColorFillBlend = CBlendItems3
        Me.btnClear.Corners.LowerLeft = 13
        Me.btnClear.Corners.UpperLeft = 13
        Me.btnClear.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClear.DesignerSelected = False
        Me.btnClear.FillType = CButtonLib.CButton.eFillType.GradientPath
        Me.btnClear.Font = New System.Drawing.Font("Comic Sans MS", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnClear.ImageIndex = 0
        Me.btnClear.Location = New System.Drawing.Point(23, 128)
        Me.btnClear.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(142, 27)
        Me.btnClear.TabIndex = 2
        Me.btnClear.Text = "Clear"
        Me.btnClear.TextShadow = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        '
        'btnSave
        '
        Me.btnSave.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        CBlendItems4.iColor = New System.Drawing.Color() {System.Drawing.Color.White, System.Drawing.Color.Black, System.Drawing.Color.Black}
        CBlendItems4.iPoint = New Single() {0.0!, 0.4166667!, 1.0!}
        Me.btnSave.ColorFillBlend = CBlendItems4
        Me.btnSave.Corners.LowerLeft = 13
        Me.btnSave.Corners.UpperLeft = 13
        Me.btnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSave.DesignerSelected = False
        Me.btnSave.FillType = CButtonLib.CButton.eFillType.GradientPath
        Me.btnSave.Font = New System.Drawing.Font("Comic Sans MS", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnSave.ImageIndex = 0
        Me.btnSave.Location = New System.Drawing.Point(23, 95)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(142, 27)
        Me.btnSave.TabIndex = 3
        Me.btnSave.Text = "Save"
        Me.btnSave.TextShadow = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        '
        'btnRedo
        '
        Me.btnRedo.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        CBlendItems5.iColor = New System.Drawing.Color() {System.Drawing.Color.White, System.Drawing.Color.Black, System.Drawing.Color.Black}
        CBlendItems5.iPoint = New Single() {0.0!, 0.4166667!, 1.0!}
        Me.btnRedo.ColorFillBlend = CBlendItems5
        Me.btnRedo.Corners.LowerLeft = 13
        Me.btnRedo.Corners.UpperLeft = 13
        Me.btnRedo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRedo.DesignerSelected = False
        Me.btnRedo.FillType = CButtonLib.CButton.eFillType.GradientPath
        Me.btnRedo.Font = New System.Drawing.Font("Comic Sans MS", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnRedo.ImageIndex = 0
        Me.btnRedo.Location = New System.Drawing.Point(23, 62)
        Me.btnRedo.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnRedo.Name = "btnRedo"
        Me.btnRedo.Size = New System.Drawing.Size(142, 27)
        Me.btnRedo.TabIndex = 1
        Me.btnRedo.Text = "Redo"
        Me.btnRedo.TextShadow = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        '
        'btnUndo
        '
        Me.btnUndo.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        CBlendItems6.iColor = New System.Drawing.Color() {System.Drawing.Color.White, System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))}
        CBlendItems6.iPoint = New Single() {0.0!, 0.4166667!, 1.0!}
        Me.btnUndo.ColorFillBlend = CBlendItems6
        Me.btnUndo.Corners.LowerLeft = 13
        Me.btnUndo.Corners.UpperLeft = 13
        Me.btnUndo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUndo.DesignerSelected = False
        Me.btnUndo.FillType = CButtonLib.CButton.eFillType.GradientPath
        Me.btnUndo.Font = New System.Drawing.Font("Comic Sans MS", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnUndo.ImageIndex = 0
        Me.btnUndo.Location = New System.Drawing.Point(23, 29)
        Me.btnUndo.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnUndo.Name = "btnUndo"
        Me.btnUndo.Size = New System.Drawing.Size(142, 27)
        Me.btnUndo.TabIndex = 1
        Me.btnUndo.Text = "Undo"
        Me.btnUndo.TextShadow = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.GLabel5)
        Me.GroupBox3.Controls.Add(Me.GLabel4)
        Me.GroupBox3.Controls.Add(Me.GLabel3)
        Me.GroupBox3.Controls.Add(Me.TrackBrushSize)
        Me.GroupBox3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.GroupBox3.Location = New System.Drawing.Point(392, 429)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(269, 97)
        Me.GroupBox3.TabIndex = 12
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Brush Size"
        '
        'GLabel5
        '
        Me.GLabel5.Font = New System.Drawing.Font("Comic Sans MS", 10.0!)
        Me.GLabel5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.GLabel5.GlowColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GLabel5.Location = New System.Drawing.Point(232, 67)
        Me.GLabel5.Name = "GLabel5"
        Me.GLabel5.Size = New System.Drawing.Size(31, 21)
        Me.GLabel5.TabIndex = 13
        Me.GLabel5.Text = "20"
        '
        'GLabel4
        '
        Me.GLabel4.Font = New System.Drawing.Font("Comic Sans MS", 10.0!)
        Me.GLabel4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.GLabel4.GlowColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GLabel4.Location = New System.Drawing.Point(121, 67)
        Me.GLabel4.Name = "GLabel4"
        Me.GLabel4.Size = New System.Drawing.Size(31, 21)
        Me.GLabel4.TabIndex = 14
        Me.GLabel4.Text = "10"
        '
        'GLabel3
        '
        Me.GLabel3.Font = New System.Drawing.Font("Comic Sans MS", 10.0!)
        Me.GLabel3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.GLabel3.GlowColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GLabel3.Location = New System.Drawing.Point(6, 67)
        Me.GLabel3.Name = "GLabel3"
        Me.GLabel3.Size = New System.Drawing.Size(31, 21)
        Me.GLabel3.TabIndex = 15
        Me.GLabel3.Text = "1"
        '
        'TrackBrushSize
        '
        Me.TrackBrushSize.Cursor = System.Windows.Forms.Cursors.Hand
        Me.TrackBrushSize.Location = New System.Drawing.Point(6, 21)
        Me.TrackBrushSize.Maximum = 20
        Me.TrackBrushSize.Minimum = 1
        Me.TrackBrushSize.Name = "TrackBrushSize"
        Me.TrackBrushSize.Size = New System.Drawing.Size(257, 45)
        Me.TrackBrushSize.TabIndex = 0
        Me.TrackBrushSize.Value = 5
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnWhite)
        Me.GroupBox2.Controls.Add(Me.btnLoadBGImage)
        Me.GroupBox2.Controls.Add(Me.rbBGColor)
        Me.GroupBox2.Controls.Add(Me.rbPenColor)
        Me.GroupBox2.Controls.Add(Me.lblBGColor)
        Me.GroupBox2.Controls.Add(Me.lblPenColor)
        Me.GroupBox2.Controls.Add(Me.btnCustomColor)
        Me.GroupBox2.Controls.Add(Me.btnGray)
        Me.GroupBox2.Controls.Add(Me.btnGreen)
        Me.GroupBox2.Controls.Add(Me.btnBlack)
        Me.GroupBox2.Controls.Add(Me.btnRed)
        Me.GroupBox2.Controls.Add(Me.btnYellow)
        Me.GroupBox2.Controls.Add(Me.cmbColors)
        Me.GroupBox2.Controls.Add(Me.btnBlue)
        Me.GroupBox2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.GroupBox2.Location = New System.Drawing.Point(26, 429)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(360, 179)
        Me.GroupBox2.TabIndex = 11
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Colors"
        '
        'btnWhite
        '
        Me.btnWhite.BackColor = System.Drawing.Color.White
        Me.btnWhite.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnWhite.ColorFillSolid = System.Drawing.Color.White
        Me.btnWhite.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnWhite.DesignerSelected = False
        Me.btnWhite.FillType = CButtonLib.CButton.eFillType.Solid
        Me.btnWhite.ImageIndex = 0
        Me.btnWhite.Location = New System.Drawing.Point(161, 31)
        Me.btnWhite.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnWhite.Name = "btnWhite"
        Me.btnWhite.Size = New System.Drawing.Size(20, 20)
        Me.btnWhite.TabIndex = 19
        Me.btnWhite.Text = "  "
        '
        'btnLoadBGImage
        '
        Me.btnLoadBGImage.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        CBlendItems7.iColor = New System.Drawing.Color() {System.Drawing.Color.White, System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))}
        CBlendItems7.iPoint = New Single() {0.0!, 0.3611111!, 1.0!}
        Me.btnLoadBGImage.ColorFillBlend = CBlendItems7
        Me.btnLoadBGImage.Corners.All = 12
        Me.btnLoadBGImage.Corners.LowerLeft = 12
        Me.btnLoadBGImage.Corners.LowerRight = 12
        Me.btnLoadBGImage.Corners.UpperLeft = 12
        Me.btnLoadBGImage.Corners.UpperRight = 12
        Me.btnLoadBGImage.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLoadBGImage.DesignerSelected = False
        Me.btnLoadBGImage.FillType = CButtonLib.CButton.eFillType.GradientPath
        Me.btnLoadBGImage.Font = New System.Drawing.Font("Comic Sans MS", 7.0!, System.Drawing.FontStyle.Bold)
        Me.btnLoadBGImage.ImageIndex = 0
        Me.btnLoadBGImage.Location = New System.Drawing.Point(17, 100)
        Me.btnLoadBGImage.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnLoadBGImage.Name = "btnLoadBGImage"
        Me.btnLoadBGImage.Size = New System.Drawing.Size(140, 26)
        Me.btnLoadBGImage.TabIndex = 18
        Me.btnLoadBGImage.Text = "BG Image"
        '
        'rbBGColor
        '
        Me.rbBGColor.AutoSize = True
        Me.rbBGColor.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rbBGColor.Location = New System.Drawing.Point(277, 29)
        Me.rbBGColor.Name = "rbBGColor"
        Me.rbBGColor.Size = New System.Drawing.Size(67, 17)
        Me.rbBGColor.TabIndex = 16
        Me.rbBGColor.Text = "BG Color"
        Me.rbBGColor.UseVisualStyleBackColor = True
        '
        'rbPenColor
        '
        Me.rbPenColor.AutoSize = True
        Me.rbPenColor.Checked = True
        Me.rbPenColor.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rbPenColor.Location = New System.Drawing.Point(201, 29)
        Me.rbPenColor.Name = "rbPenColor"
        Me.rbPenColor.Size = New System.Drawing.Size(71, 17)
        Me.rbPenColor.TabIndex = 15
        Me.rbPenColor.TabStop = True
        Me.rbPenColor.Text = "Pen Color"
        Me.rbPenColor.UseVisualStyleBackColor = True
        '
        'lblBGColor
        '
        Me.lblBGColor.BackColor = System.Drawing.Color.White
        Me.lblBGColor.Font = New System.Drawing.Font("Comic Sans MS", 30.0!)
        Me.lblBGColor.Location = New System.Drawing.Point(279, 56)
        Me.lblBGColor.Name = "lblBGColor"
        Me.lblBGColor.Size = New System.Drawing.Size(50, 50)
        Me.lblBGColor.TabIndex = 13
        Me.lblBGColor.Text = "  "
        '
        'lblPenColor
        '
        Me.lblPenColor.BackColor = System.Drawing.Color.Black
        Me.lblPenColor.Font = New System.Drawing.Font("Comic Sans MS", 30.0!)
        Me.lblPenColor.Location = New System.Drawing.Point(203, 56)
        Me.lblPenColor.Name = "lblPenColor"
        Me.lblPenColor.Size = New System.Drawing.Size(50, 50)
        Me.lblPenColor.TabIndex = 11
        Me.lblPenColor.Text = "  "
        '
        'btnCustomColor
        '
        Me.btnCustomColor.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        CBlendItems8.iColor = New System.Drawing.Color() {System.Drawing.Color.White, System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))}
        CBlendItems8.iPoint = New Single() {0.0!, 0.3611111!, 1.0!}
        Me.btnCustomColor.ColorFillBlend = CBlendItems8
        Me.btnCustomColor.Corners.All = 12
        Me.btnCustomColor.Corners.LowerLeft = 12
        Me.btnCustomColor.Corners.LowerRight = 12
        Me.btnCustomColor.Corners.UpperLeft = 12
        Me.btnCustomColor.Corners.UpperRight = 12
        Me.btnCustomColor.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCustomColor.DesignerSelected = False
        Me.btnCustomColor.FillType = CButtonLib.CButton.eFillType.GradientPath
        Me.btnCustomColor.Font = New System.Drawing.Font("Comic Sans MS", 8.0!, System.Drawing.FontStyle.Bold)
        Me.btnCustomColor.ImageIndex = 0
        Me.btnCustomColor.Location = New System.Drawing.Point(17, 62)
        Me.btnCustomColor.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnCustomColor.Name = "btnCustomColor"
        Me.btnCustomColor.Size = New System.Drawing.Size(140, 27)
        Me.btnCustomColor.TabIndex = 10
        Me.btnCustomColor.Text = "Custom"
        '
        'btnGray
        '
        Me.btnGray.BackColor = System.Drawing.Color.Silver
        Me.btnGray.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnGray.ColorFillSolid = System.Drawing.Color.Silver
        Me.btnGray.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGray.DesignerSelected = False
        Me.btnGray.FillType = CButtonLib.CButton.eFillType.Solid
        Me.btnGray.ImageIndex = 0
        Me.btnGray.Location = New System.Drawing.Point(137, 31)
        Me.btnGray.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnGray.Name = "btnGray"
        Me.btnGray.Size = New System.Drawing.Size(20, 20)
        Me.btnGray.TabIndex = 9
        Me.btnGray.Text = ""
        '
        'btnGreen
        '
        Me.btnGreen.BackColor = System.Drawing.Color.Green
        Me.btnGreen.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnGreen.ColorFillSolid = System.Drawing.Color.Green
        Me.btnGreen.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGreen.DesignerSelected = False
        Me.btnGreen.FillType = CButtonLib.CButton.eFillType.Solid
        Me.btnGreen.ImageIndex = 0
        Me.btnGreen.Location = New System.Drawing.Point(65, 31)
        Me.btnGreen.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnGreen.Name = "btnGreen"
        Me.btnGreen.Size = New System.Drawing.Size(20, 20)
        Me.btnGreen.TabIndex = 8
        Me.btnGreen.Text = ""
        '
        'btnBlack
        '
        Me.btnBlack.BackColor = System.Drawing.Color.Black
        Me.btnBlack.BorderColor = System.Drawing.Color.Silver
        Me.btnBlack.ColorFillSolid = System.Drawing.Color.Black
        Me.btnBlack.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBlack.DesignerSelected = False
        Me.btnBlack.FillType = CButtonLib.CButton.eFillType.Solid
        Me.btnBlack.ImageIndex = 0
        Me.btnBlack.Location = New System.Drawing.Point(113, 31)
        Me.btnBlack.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnBlack.Name = "btnBlack"
        Me.btnBlack.Size = New System.Drawing.Size(20, 20)
        Me.btnBlack.TabIndex = 7
        Me.btnBlack.Text = ""
        '
        'btnRed
        '
        Me.btnRed.BackColor = System.Drawing.Color.Red
        Me.btnRed.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnRed.ColorFillSolid = System.Drawing.Color.Red
        Me.btnRed.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRed.DesignerSelected = False
        Me.btnRed.FillType = CButtonLib.CButton.eFillType.Solid
        Me.btnRed.ImageIndex = 0
        Me.btnRed.Location = New System.Drawing.Point(41, 31)
        Me.btnRed.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnRed.Name = "btnRed"
        Me.btnRed.Size = New System.Drawing.Size(20, 20)
        Me.btnRed.TabIndex = 6
        Me.btnRed.Text = ""
        '
        'btnYellow
        '
        Me.btnYellow.BackColor = System.Drawing.Color.Yellow
        Me.btnYellow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnYellow.ColorFillSolid = System.Drawing.Color.Yellow
        Me.btnYellow.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnYellow.DesignerSelected = False
        Me.btnYellow.FillType = CButtonLib.CButton.eFillType.Solid
        Me.btnYellow.ImageIndex = 0
        Me.btnYellow.Location = New System.Drawing.Point(89, 31)
        Me.btnYellow.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnYellow.Name = "btnYellow"
        Me.btnYellow.Size = New System.Drawing.Size(20, 20)
        Me.btnYellow.TabIndex = 5
        Me.btnYellow.Text = ""
        '
        'cmbColors
        '
        Me.cmbColors.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cmbColors.Font = New System.Drawing.Font("Comic Sans MS", 10.0!, System.Drawing.FontStyle.Bold)
        Me.cmbColors.ForeColor = System.Drawing.Color.White
        Me.cmbColors.FormattingEnabled = True
        Me.cmbColors.Location = New System.Drawing.Point(17, 137)
        Me.cmbColors.Name = "cmbColors"
        Me.cmbColors.Size = New System.Drawing.Size(312, 27)
        Me.cmbColors.TabIndex = 4
        Me.cmbColors.Text = "Color Selector"
        '
        'btnBlue
        '
        Me.btnBlue.BackColor = System.Drawing.Color.Blue
        Me.btnBlue.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnBlue.ColorFillSolid = System.Drawing.Color.Blue
        Me.btnBlue.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBlue.DesignerSelected = False
        Me.btnBlue.FillType = CButtonLib.CButton.eFillType.Solid
        Me.btnBlue.ImageIndex = 0
        Me.btnBlue.Location = New System.Drawing.Point(17, 31)
        Me.btnBlue.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnBlue.Name = "btnBlue"
        Me.btnBlue.Size = New System.Drawing.Size(20, 20)
        Me.btnBlue.TabIndex = 3
        Me.btnBlue.Text = ""
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnAgryMan)
        Me.GroupBox1.Controls.Add(Me.btnArmNeck)
        Me.GroupBox1.Controls.Add(Me.btnStickWoman)
        Me.GroupBox1.Controls.Add(Me.btnArmsDown)
        Me.GroupBox1.Controls.Add(Me.btnArmsUp)
        Me.GroupBox1.Controls.Add(Me.btnArmsStraight)
        Me.GroupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.GroupBox1.Location = New System.Drawing.Point(667, 43)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(188, 380)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Stick Figures"
        '
        'btnArmNeck
        '
        Me.btnArmNeck.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnArmNeck.BackgroundImage = Global.CartoonApp.My.Resources.Resources.m_arms_up_neck
        Me.btnArmNeck.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnArmNeck.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        CBlendItems10.iColor = New System.Drawing.Color() {System.Drawing.Color.White, System.Drawing.Color.White}
        CBlendItems10.iPoint = New Single() {0.0!, 1.0!}
        Me.btnArmNeck.ColorFillBlend = CBlendItems10
        Me.btnArmNeck.ColorFillSolid = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnArmNeck.DesignerSelected = False
        Me.btnArmNeck.FillType = CButtonLib.CButton.eFillType.Solid
        Me.btnArmNeck.ImageIndex = 0
        Me.btnArmNeck.Location = New System.Drawing.Point(18, 194)
        Me.btnArmNeck.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnArmNeck.Name = "btnArmNeck"
        Me.btnArmNeck.Size = New System.Drawing.Size(70, 80)
        Me.btnArmNeck.TabIndex = 8
        Me.btnArmNeck.Text = ""
        '
        'btnStickWoman
        '
        Me.btnStickWoman.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnStickWoman.BackgroundImage = Global.CartoonApp.My.Resources.Resources.f_arms_straight
        Me.btnStickWoman.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnStickWoman.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        CBlendItems11.iColor = New System.Drawing.Color() {System.Drawing.Color.White, System.Drawing.Color.White}
        CBlendItems11.iPoint = New Single() {0.0!, 1.0!}
        Me.btnStickWoman.ColorFillBlend = CBlendItems11
        Me.btnStickWoman.ColorFillSolid = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnStickWoman.DesignerSelected = False
        Me.btnStickWoman.FillType = CButtonLib.CButton.eFillType.Solid
        Me.btnStickWoman.ImageIndex = 0
        Me.btnStickWoman.Location = New System.Drawing.Point(101, 108)
        Me.btnStickWoman.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnStickWoman.Name = "btnStickWoman"
        Me.btnStickWoman.Size = New System.Drawing.Size(70, 80)
        Me.btnStickWoman.TabIndex = 6
        Me.btnStickWoman.Text = ""
        '
        'btnArmsDown
        '
        Me.btnArmsDown.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnArmsDown.BackgroundImage = Global.CartoonApp.My.Resources.Resources.m_arms_down
        Me.btnArmsDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnArmsDown.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        CBlendItems12.iColor = New System.Drawing.Color() {System.Drawing.Color.White, System.Drawing.Color.White}
        CBlendItems12.iPoint = New Single() {0.0!, 1.0!}
        Me.btnArmsDown.ColorFillBlend = CBlendItems12
        Me.btnArmsDown.ColorFillSolid = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnArmsDown.DesignerSelected = False
        Me.btnArmsDown.FillType = CButtonLib.CButton.eFillType.Solid
        Me.btnArmsDown.ImageIndex = 0
        Me.btnArmsDown.Location = New System.Drawing.Point(18, 108)
        Me.btnArmsDown.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnArmsDown.Name = "btnArmsDown"
        Me.btnArmsDown.Size = New System.Drawing.Size(70, 80)
        Me.btnArmsDown.TabIndex = 7
        Me.btnArmsDown.Text = ""
        '
        'btnArmsUp
        '
        Me.btnArmsUp.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnArmsUp.BackgroundImage = Global.CartoonApp.My.Resources.Resources.m_arms_up
        Me.btnArmsUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnArmsUp.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        CBlendItems13.iColor = New System.Drawing.Color() {System.Drawing.Color.White, System.Drawing.Color.White}
        CBlendItems13.iPoint = New Single() {0.0!, 1.0!}
        Me.btnArmsUp.ColorFillBlend = CBlendItems13
        Me.btnArmsUp.ColorFillSolid = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnArmsUp.DesignerSelected = False
        Me.btnArmsUp.FillType = CButtonLib.CButton.eFillType.Solid
        Me.btnArmsUp.ImageIndex = 0
        Me.btnArmsUp.Location = New System.Drawing.Point(101, 22)
        Me.btnArmsUp.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnArmsUp.Name = "btnArmsUp"
        Me.btnArmsUp.Size = New System.Drawing.Size(70, 80)
        Me.btnArmsUp.TabIndex = 4
        Me.btnArmsUp.Text = ""
        '
        'btnArmsStraight
        '
        Me.btnArmsStraight.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnArmsStraight.BackgroundImage = Global.CartoonApp.My.Resources.Resources.m_arms_straight
        Me.btnArmsStraight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnArmsStraight.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        CBlendItems14.iColor = New System.Drawing.Color() {System.Drawing.Color.White, System.Drawing.Color.White}
        CBlendItems14.iPoint = New Single() {0.0!, 1.0!}
        Me.btnArmsStraight.ColorFillBlend = CBlendItems14
        Me.btnArmsStraight.ColorFillSolid = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnArmsStraight.DesignerSelected = False
        Me.btnArmsStraight.FillType = CButtonLib.CButton.eFillType.Solid
        Me.btnArmsStraight.ImageIndex = 0
        Me.btnArmsStraight.Location = New System.Drawing.Point(18, 22)
        Me.btnArmsStraight.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnArmsStraight.Name = "btnArmsStraight"
        Me.btnArmsStraight.Size = New System.Drawing.Size(70, 80)
        Me.btnArmsStraight.TabIndex = 5
        Me.btnArmsStraight.Text = ""
        '
        'PbSurface
        '
        Me.PbSurface.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.PbSurface.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PbSurface.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PbSurface.Cursor = System.Windows.Forms.Cursors.Cross
        Me.PbSurface.InitialImage = Nothing
        Me.PbSurface.Location = New System.Drawing.Point(27, 43)
        Me.PbSurface.Name = "PbSurface"
        Me.PbSurface.Size = New System.Drawing.Size(630, 380)
        Me.PbSurface.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PbSurface.TabIndex = 9
        Me.PbSurface.TabStop = False
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 628)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(880, 22)
        Me.StatusStrip1.TabIndex = 15
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'btnAgryMan
        '
        Me.btnAgryMan.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnAgryMan.BackgroundImage = Global.CartoonApp.My.Resources.Resources.m_arms_up_neck
        Me.btnAgryMan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAgryMan.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        CBlendItems9.iColor = New System.Drawing.Color() {System.Drawing.Color.White, System.Drawing.Color.White}
        CBlendItems9.iPoint = New Single() {0.0!, 1.0!}
        Me.btnAgryMan.ColorFillBlend = CBlendItems9
        Me.btnAgryMan.ColorFillSolid = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnAgryMan.DesignerSelected = True
        Me.btnAgryMan.FillType = CButtonLib.CButton.eFillType.Solid
        Me.btnAgryMan.ImageIndex = 0
        Me.btnAgryMan.Location = New System.Drawing.Point(101, 194)
        Me.btnAgryMan.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnAgryMan.Name = "btnAgryMan"
        Me.btnAgryMan.Size = New System.Drawing.Size(70, 80)
        Me.btnAgryMan.TabIndex = 9
        Me.btnAgryMan.Text = ""
        '
        'frmCartoon
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(880, 650)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PbSurface)
        Me.Controls.Add(Me.pnlHeader)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmCartoon"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.pnlHeader.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.TrackBrushSize, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.PbSurface, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CButton2 As CButtonLib.CButton
    Friend WithEvents btnClose As CButtonLib.CButton
    Friend WithEvents pnlHeader As System.Windows.Forms.Panel
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents RadioDashed As System.Windows.Forms.RadioButton
    Friend WithEvents RadioSolid As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents btnClear As CButtonLib.CButton
    Friend WithEvents btnSave As CButtonLib.CButton
    Friend WithEvents btnRedo As CButtonLib.CButton
    Friend WithEvents btnUndo As CButtonLib.CButton
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents TrackBrushSize As System.Windows.Forms.TrackBar
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnCustomColor As CButtonLib.CButton
    Friend WithEvents btnGray As CButtonLib.CButton
    Friend WithEvents btnGreen As CButtonLib.CButton
    Friend WithEvents btnBlack As CButtonLib.CButton
    Friend WithEvents btnRed As CButtonLib.CButton
    Friend WithEvents btnYellow As CButtonLib.CButton
    Friend WithEvents cmbColors As System.Windows.Forms.ComboBox
    Friend WithEvents btnBlue As CButtonLib.CButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnStickWoman As CButtonLib.CButton
    Friend WithEvents btnArmsDown As CButtonLib.CButton
    Friend WithEvents btnArmsUp As CButtonLib.CButton
    Friend WithEvents btnArmsStraight As CButtonLib.CButton
    Friend WithEvents PbSurface As System.Windows.Forms.PictureBox
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents lblPenColor As gLabel.gLabel
    Friend WithEvents ColorDialog1 As System.Windows.Forms.ColorDialog
    Friend WithEvents GLabel5 As gLabel.gLabel
    Friend WithEvents GLabel4 As gLabel.gLabel
    Friend WithEvents GLabel3 As gLabel.gLabel
    Friend WithEvents rbPenColor As System.Windows.Forms.RadioButton
    Friend WithEvents rbBGColor As System.Windows.Forms.RadioButton
    Friend WithEvents btnLoadBGImage As CButtonLib.CButton
    Friend WithEvents lblBGColor As gLabel.gLabel
    Friend WithEvents btnWhite As CButtonLib.CButton
    Friend WithEvents btnArmNeck As CButtonLib.CButton
    Friend WithEvents btnAgryMan As CButtonLib.CButton

End Class
