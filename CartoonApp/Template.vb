Module Template

#Region "Public Declare"

    Public drag As Boolean
    Private drawingPen As Pen
    Private timeCount As Integer
    Private timeLoad As New Timer
    Public PointX, PointY As Integer
   
#End Region

#Region "Form Movement"

    Public Sub MouseD(fm As Form)
        drag = True
        PointX = Windows.Forms.Cursor.Position.X - fm.Left
        PointY = Windows.Forms.Cursor.Position.Y - fm.Top
    End Sub

    Public Sub MouseM(fm As Form)
        If drag Then
            fm.Top = Windows.Forms.Cursor.Position.Y - PointY
            fm.Left = Windows.Forms.Cursor.Position.X - PointX
        End If
    End Sub

    Public Sub MouseU()
        drag = False
    End Sub

#End Region 'Form Movement

#Region "Check Error"

    Public Function CheckError(Reset As Boolean, message As String) As Boolean
        CheckError = Reset = False
        Select Case CheckError
            Case True
                MessageBox.Show(message, "Cartoon Application", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Select
        Return CheckError
    End Function

#End Region 'Check if font and text color are set

#Region "Get font style"

    Public Function GetFontStyle(rb As RadioButton, rb2 As RadioButton, rb3 As RadioButton) As FontStyle
        If rb.Checked Then
            GetFontStyle = FontStyle.Regular
        ElseIf rb2.Checked Then
            GetFontStyle = FontStyle.Bold
        ElseIf rb3.Checked Then
            GetFontStyle = FontStyle.Italic
        End If
        Return GetFontStyle
    End Function

#End Region

End Module