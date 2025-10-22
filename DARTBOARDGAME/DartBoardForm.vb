'Option Strict On
Option Explicit On
Option Compare Text
'Alexis Villagran
'10/21/25
'RCET

Imports System.IO
Imports System.Security.Cryptography.X509Certificates

Public Class DartBoardForm

    Public round As Integer                        'Global Variables
    Public roundString As String                   '""
    Public currentRound As Integer                 '""
    Public currentRoundToString As String          'Global Variables

    '=================SET DEFAUTL VALUES=================
    Sub SetDefaultValues()
        PictureBox.Refresh()
        PictureBox.BackColor = Color.Beige
        PictureBox.BorderStyle = BorderStyle.Fixed3D
        PictureBox.SizeMode = PictureBoxSizeMode.StretchImage
    End Sub

    '=================FUNCTIONS=================
    Function RandomNumber(max%) As Integer
        Dim rndNumber As Integer
        Randomize()
        rndNumber = CInt(Int((max + 1) * Rnd()))
        Return rndNumber
    End Function

    '=================DARTS=================

    Sub DartDraw(x%, y%)
        Dim g As Graphics = PictureBox.CreateGraphics()
        Dim dart As New Pen(Color.Black)
        Dim dartWidth% = 25

        g.DrawEllipse(dart, x - (dartWidth \ 2), y - (dartWidth \ 2), dartWidth, dartWidth)
        g.DrawLine(dart, x - 3, y, x + 3, y)
        g.DrawLine(dart, x, y - 3, x, y + 3)

        dart.Dispose()
        g.Dispose()
    End Sub

    Sub ThrowDart()
        Dim X As Integer = RandomNumber(PictureBox.Width)
        Dim Y As Integer = RandomNumber(PictureBox.Height)
        DartDraw(X, Y)
    End Sub
    '=================BUTTONS=================
    Private Sub ThrowButton_Click(sender As Object, e As EventArgs) Handles ThrowButton.Click
        ThrowDart()
        ThrowDart()
        ThrowDart()
    End Sub

    Private Sub DartBoardForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetDefaultValues()
    End Sub

End Class
