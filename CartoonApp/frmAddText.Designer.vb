<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddText
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAddText))
        Dim CBlendItems2 As CButtonLib.cBlendItems = New CButtonLib.cBlendItems()
        Dim CBlendItems3 As CButtonLib.cBlendItems = New CButtonLib.cBlendItems()
        Dim CBlendItems4 As CButtonLib.cBlendItems = New CButtonLib.cBlendItems()
        Dim CBlendItems5 As CButtonLib.cBlendItems = New CButtonLib.cBlendItems()
        Me.pnlHeader = New System.Windows.Forms.Panel()
        Me.btnHeader = New CButtonLib.CButton()
        Me.btnClose = New CButtonLib.CButton()
        Me.TextboxStickFigure = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.SpinFontSize = New System.Windows.Forms.NumericUpDown()
        Me.CmbFontFamily = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.RadioItalic = New System.Windows.Forms.RadioButton()
        Me.RadioBold = New System.Windows.Forms.RadioButton()
        Me.RadioRegular = New System.Windows.Forms.RadioButton()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.lblColor = New gLabel.gLabel()
        Me.btnFontColor = New CButtonLib.CButton()
        Me.btnCancel = New CButtonLib.CButton()
        Me.btnOK = New CButtonLib.CButton()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.pnlHeader.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.SpinFontSize, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlHeader
        '
        Me.pnlHeader.Controls.Add(Me.btnHeader)
        Me.pnlHeader.Controls.Add(Me.btnClose)
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(400, 37)
        Me.pnlHeader.TabIndex = 0
        '
        'btnHeader
        '
        Me.btnHeader.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        CBlendItems1.iColor = New System.Drawing.Color() {System.Drawing.Color.White, System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))}
        CBlendItems1.iPoint = New Single() {0.0!, 0.2469136!, 1.0!}
        Me.btnHeader.ColorFillBlend = CBlendItems1
        Me.btnHeader.ColorFillSolid = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnHeader.Corners.All = 13
        Me.btnHeader.Corners.LowerLeft = 13
        Me.btnHeader.Corners.LowerRight = 13
        Me.btnHeader.Corners.UpperLeft = 13
        Me.btnHeader.Corners.UpperRight = 13
        Me.btnHeader.DesignerSelected = False
        Me.btnHeader.FillType = CButtonLib.CButton.eFillType.Solid
        Me.btnHeader.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.btnHeader.ImageIndex = 0
        Me.btnHeader.Location = New System.Drawing.Point(3, 3)
        Me.btnHeader.Name = "btnHeader"
        Me.btnHeader.SideImage = CType(resources.GetObject("btnHeader.SideImage"), System.Drawing.Image)
        Me.btnHeader.SideImageSize = New System.Drawing.Size(32, 32)
        Me.btnHeader.Size = New System.Drawing.Size(147, 30)
        Me.btnHeader.TabIndex = 3
        Me.btnHeader.Text = "Set Text For Drawing"
        Me.btnHeader.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.btnHeader.TextShadow = System.Drawing.Color.Gray
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
        Me.btnClose.Location = New System.Drawing.Point(355, 0)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(45, 37)
        Me.btnClose.TabIndex = 1
        Me.btnClose.Text = "X"
        Me.btnClose.TextShadow = System.Drawing.Color.Maroon
        '
        'TextboxStickFigure
        '
        Me.TextboxStickFigure.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TextboxStickFigure.Font = New System.Drawing.Font("Comic Sans MS", 14.0!)
        Me.TextboxStickFigure.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TextboxStickFigure.Location = New System.Drawing.Point(43, 69)
        Me.TextboxStickFigure.Multiline = True
        Me.TextboxStickFigure.Name = "TextboxStickFigure"
        Me.TextboxStickFigure.Size = New System.Drawing.Size(315, 81)
        Me.TextboxStickFigure.TabIndex = 1
        Me.TextboxStickFigure.Text = "Default Text"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.SpinFontSize)
        Me.GroupBox1.Controls.Add(Me.CmbFontFamily)
        Me.GroupBox1.Font = New System.Drawing.Font("Comic Sans MS", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.GroupBox1.Location = New System.Drawing.Point(43, 167)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(315, 70)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Font Family and Size"
        '
        'SpinFontSize
        '
        Me.SpinFontSize.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.SpinFontSize.Font = New System.Drawing.Font("Comic Sans MS", 12.0!)
        Me.SpinFontSize.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.SpinFontSize.Location = New System.Drawing.Point(249, 32)
        Me.SpinFontSize.Maximum = New Decimal(New Integer() {36, 0, 0, 0})
        Me.SpinFontSize.Minimum = New Decimal(New Integer() {8, 0, 0, 0})
        Me.SpinFontSize.Name = "SpinFontSize"
        Me.SpinFontSize.Size = New System.Drawing.Size(55, 30)
        Me.SpinFontSize.TabIndex = 1
        Me.SpinFontSize.Value = New Decimal(New Integer() {14, 0, 0, 0})
        '
        'CmbFontFamily
        '
        Me.CmbFontFamily.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.CmbFontFamily.Font = New System.Drawing.Font("Comic Sans MS", 12.0!)
        Me.CmbFontFamily.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.CmbFontFamily.FormattingEnabled = True
        Me.CmbFontFamily.Location = New System.Drawing.Point(11, 31)
        Me.CmbFontFamily.Name = "CmbFontFamily"
        Me.CmbFontFamily.Size = New System.Drawing.Size(225, 31)
        Me.CmbFontFamily.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.RadioItalic)
        Me.GroupBox2.Controls.Add(Me.RadioBold)
        Me.GroupBox2.Controls.Add(Me.RadioRegular)
        Me.GroupBox2.Font = New System.Drawing.Font("Comic Sans MS", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.GroupBox2.Location = New System.Drawing.Point(43, 252)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(315, 70)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Font Style"
        '
        'RadioItalic
        '
        Me.RadioItalic.AutoSize = True
        Me.RadioItalic.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RadioItalic.Font = New System.Drawing.Font("Comic Sans MS", 10.0!, System.Drawing.FontStyle.Italic)
        Me.RadioItalic.Location = New System.Drawing.Point(216, 36)
        Me.RadioItalic.Name = "RadioItalic"
        Me.RadioItalic.Size = New System.Drawing.Size(64, 23)
        Me.RadioItalic.TabIndex = 2
        Me.RadioItalic.Text = "Italic"
        Me.RadioItalic.UseVisualStyleBackColor = True
        '
        'RadioBold
        '
        Me.RadioBold.AutoSize = True
        Me.RadioBold.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RadioBold.Font = New System.Drawing.Font("Comic Sans MS", 10.0!, System.Drawing.FontStyle.Bold)
        Me.RadioBold.Location = New System.Drawing.Point(136, 36)
        Me.RadioBold.Name = "RadioBold"
        Me.RadioBold.Size = New System.Drawing.Size(55, 23)
        Me.RadioBold.TabIndex = 1
        Me.RadioBold.Text = "Bold"
        Me.RadioBold.UseVisualStyleBackColor = True
        '
        'RadioRegular
        '
        Me.RadioRegular.AutoSize = True
        Me.RadioRegular.Checked = True
        Me.RadioRegular.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RadioRegular.Font = New System.Drawing.Font("Comic Sans MS", 10.0!)
        Me.RadioRegular.Location = New System.Drawing.Point(35, 36)
        Me.RadioRegular.Name = "RadioRegular"
        Me.RadioRegular.Size = New System.Drawing.Size(76, 23)
        Me.RadioRegular.TabIndex = 0
        Me.RadioRegular.TabStop = True
        Me.RadioRegular.Text = "Regular"
        Me.RadioRegular.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.lblColor)
        Me.GroupBox3.Controls.Add(Me.btnFontColor)
        Me.GroupBox3.Font = New System.Drawing.Font("Comic Sans MS", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.GroupBox3.Location = New System.Drawing.Point(43, 337)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(315, 90)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Font Color"
        '
        'lblColor
        '
        Me.lblColor.BackColor = System.Drawing.Color.Blue
        Me.lblColor.Font = New System.Drawing.Font("Comic Sans MS", 30.0!)
        Me.lblColor.Location = New System.Drawing.Point(220, 22)
        Me.lblColor.Name = "lblColor"
        Me.lblColor.Size = New System.Drawing.Size(59, 52)
        Me.lblColor.TabIndex = 12
        Me.lblColor.Text = "  "
        '
        'btnFontColor
        '
        Me.btnFontColor.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        CBlendItems3.iColor = New System.Drawing.Color() {System.Drawing.Color.White, System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))}
        CBlendItems3.iPoint = New Single() {0.0!, 0.3611111!, 1.0!}
        Me.btnFontColor.ColorFillBlend = CBlendItems3
        Me.btnFontColor.Corners.UpperLeft = 19
        Me.btnFontColor.Corners.UpperRight = 19
        Me.btnFontColor.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnFontColor.DesignerSelected = False
        Me.btnFontColor.FillType = CButtonLib.CButton.eFillType.GradientPath
        Me.btnFontColor.ImageIndex = 0
        Me.btnFontColor.Location = New System.Drawing.Point(34, 34)
        Me.btnFontColor.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnFontColor.Name = "btnFontColor"
        Me.btnFontColor.Size = New System.Drawing.Size(140, 40)
        Me.btnFontColor.TabIndex = 11
        Me.btnFontColor.Text = "Font Color"
        '
        'btnCancel
        '
        Me.btnCancel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        CBlendItems4.iColor = New System.Drawing.Color() {System.Drawing.Color.White, System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))}
        CBlendItems4.iPoint = New Single() {0.0!, 0.3611111!, 1.0!}
        Me.btnCancel.ColorFillBlend = CBlendItems4
        Me.btnCancel.Corners.All = 19
        Me.btnCancel.Corners.LowerLeft = 19
        Me.btnCancel.Corners.LowerRight = 19
        Me.btnCancel.Corners.UpperLeft = 19
        Me.btnCancel.Corners.UpperRight = 19
        Me.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancel.DesignerSelected = True
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.FillType = CButtonLib.CButton.eFillType.GradientPath
        Me.btnCancel.ImageIndex = 0
        Me.btnCancel.Location = New System.Drawing.Point(54, 448)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(140, 40)
        Me.btnCancel.TabIndex = 12
        Me.btnCancel.Text = "Cancel"
        '
        'btnOK
        '
        Me.btnOK.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        CBlendItems5.iColor = New System.Drawing.Color() {System.Drawing.Color.White, System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))}
        CBlendItems5.iPoint = New Single() {0.0!, 0.3611111!, 1.0!}
        Me.btnOK.ColorFillBlend = CBlendItems5
        Me.btnOK.Corners.All = 19
        Me.btnOK.Corners.LowerLeft = 19
        Me.btnOK.Corners.LowerRight = 19
        Me.btnOK.Corners.UpperLeft = 19
        Me.btnOK.Corners.UpperRight = 19
        Me.btnOK.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnOK.DesignerSelected = False
        Me.btnOK.FillType = CButtonLib.CButton.eFillType.GradientPath
        Me.btnOK.ImageIndex = 0
        Me.btnOK.Location = New System.Drawing.Point(207, 448)
        Me.btnOK.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(140, 40)
        Me.btnOK.TabIndex = 13
        Me.btnOK.Text = "Ok"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 509)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(400, 22)
        Me.StatusStrip1.TabIndex = 14
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'frmAddText
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(400, 531)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TextboxStickFigure)
        Me.Controls.Add(Me.pnlHeader)
        Me.Font = New System.Drawing.Font("Comic Sans MS", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAddText"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "frmAddText"
        Me.pnlHeader.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.SpinFontSize, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pnlHeader As System.Windows.Forms.Panel
    Friend WithEvents btnClose As CButtonLib.CButton
    Friend WithEvents btnHeader As CButtonLib.CButton
    Friend WithEvents TextboxStickFigure As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents SpinFontSize As System.Windows.Forms.NumericUpDown
    Friend WithEvents CmbFontFamily As System.Windows.Forms.ComboBox
    Friend WithEvents RadioItalic As System.Windows.Forms.RadioButton
    Friend WithEvents RadioBold As System.Windows.Forms.RadioButton
    Friend WithEvents RadioRegular As System.Windows.Forms.RadioButton
    Friend WithEvents btnFontColor As CButtonLib.CButton
    Friend WithEvents lblColor As gLabel.gLabel
    Friend WithEvents btnCancel As CButtonLib.CButton
    Friend WithEvents btnOK As CButtonLib.CButton
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
End Class
