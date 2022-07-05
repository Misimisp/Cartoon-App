
Public Class StickFigureDimensions

    Private ReadOnly Yvalue As Integer

    Public Sub New(mouseY As Integer, mouseY1 As Integer)
        BaseUnit = (mouseY1 - mouseY) / 10
        Yvalue = mouseY
    End Sub

    Public ReadOnly BaseUnit As Integer

    ''' <summary> 
    ''' Get the diameter of the head for a stick figure 
    ''' </summary> 
    Public ReadOnly Property HeadDiameter() As Integer
        Get
            Return BaseUnit * 3
        End Get
    End Property

    ''' <summary> 
    ''' Get the radius of the head for a stick figure 
    ''' </summary> 
    Public ReadOnly Property HeadRadius() As Integer
        Get
            Return (BaseUnit * 3) / 2
        End Get
    End Property

    ''' <summary> 
    ''' Get the size of the body for a stick figure 
    ''' </summary> 
    Public ReadOnly Property BodySize() As Integer
        Get
            Return BaseUnit * 4
        End Get
    End Property

    ''' <summary> 
    ''' Get the middle size of the body for a stick figure 
    ''' </summary> 
    Public ReadOnly Property MidBody() As Integer
        Get
            Return Yvalue + (BaseUnit * 5)
        End Get
    End Property

    ''' <summary> 
    ''' Get the size of the leg for a stick figure 
    ''' </summary> 
    Public ReadOnly Property LegSize() As Integer
        Get
            Return BaseUnit * 3
        End Get
    End Property
End Class
