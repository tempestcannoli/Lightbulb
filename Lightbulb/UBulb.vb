Public Class UBulb
    ' Klassisisene meetod kuvatava pildi määramiseks
    Private Sub selectMood(ByVal intMood As Integer)
        pbBulb.Image = imgloendbulb.Images(intMood)
    End Sub
    ' Avalik liidesmeetod
    Public Sub setMood(ByVal strMood As String)
        Select Case strMood
            Case "off"
                Me.selectMood(0)
            Case "on"
                Me.selectMood(1)
            Case Else
                Me.selectMood(0)
        End Select
    End Sub


End Class
