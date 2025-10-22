Option Strict On
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

    '=================TRACKING & STORAGE=================
    Private throwsThisTurn As New List(Of Point)
    Private throwCount As Integer
    Private logFile As String = IO.Path.Combine(
    Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "DartGameLog.txt")


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
        'Randomize()
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


        throwCount += 1
        throwsThisTurn.Add(New Point(X, Y))

        IO.File.AppendAllText(logFile, $"{DateTime.Now:yyyy-MM-dd HH:mm:ss} - Throw {throwCount}: ({X},{Y})" & Environment.NewLine)

        currentRound = (throwCount - 1) Mod 3 + 1
        currentRoundToString = CStr(currentRound)

        If throwsThisTurn.Count = 3 Then
            round += 1
            roundString = CStr(round)

            Dim sb As New System.Text.StringBuilder()
            sb.AppendLine($"Round #{roundString}")

            For i As Integer = 0 To throwsThisTurn.Count - 1
                sb.AppendLine($"  Dart {i + 1} - ({throwsThisTurn(i).X}, {throwsThisTurn(i).Y})")
            Next

            IO.File.AppendAllText(logFile, Environment.NewLine)

            sb.AppendLine()

            If TextBox1 IsNot Nothing Then TextBox1.AppendText(sb.ToString())
            throwsThisTurn.Clear()
        End If
    End Sub
    '=================BUTTONS=================
    Private Sub ThrowButton_Click(sender As Object, e As EventArgs) Handles ThrowButton.Click
        ThrowDart()
        ThrowDart()
        ThrowDart()
    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        SetDefaultValues()

        throwsThisTurn.Clear()
        throwCount = 0
        roundString = ""
        currentRoundToString = ""

        If TextBox1 IsNot Nothing Then TextBox1.Clear()

        IO.File.AppendAllText(logFile, $"{Environment.NewLine}----- NEW GAME {DateTime.Now:yyyy-MM-dd HH:mm:ss} -----{Environment.NewLine}")
    End Sub

    Private Sub LogButton_Click(sender As Object, e As EventArgs) Handles LogButton.Click
        Try
            If IO.File.Exists(logFile) Then
                Process.Start("notepad.exe", logFile)
            Else
                MessageBox.Show("No log file found yet.", "Missing Log", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show("Error opening log file: " & ex.Message)
        End Try
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Private Sub ClearHistoryButton_Click(sender As Object, e As EventArgs) Handles ClearHistoryButton.Click

        If MessageBox.Show(
            "This will erase the entire YAM history file and reset counters. Do you really wish to cleanse the world of this?",
            "Clear History",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Warning
        ) = DialogResult.No Then
            Return
        End If

        Try
            ' Reset in-memory state
            throwsThisTurn.Clear()
            throwCount = 0
            round = 0
            currentRound = 0
            roundString = ""
            currentRoundToString = ""

            ' Clear on-screen log
            If TextBox1 IsNot Nothing Then TextBox1.Clear()

            ' Truncate the log file (overwrite with a header)
            IO.File.WriteAllText(logFile,
                $"----- YAMS CLEANSED {DateTime.Now:yyyy-MM-dd HH:mm:ss} -----{Environment.NewLine}")

            ' Optional: also reset the board visuals
            'SetDefaultValues()

            MessageBox.Show("YAM HISTORY CLEANSED.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            MessageBox.Show("ERROR CLEARING YAMS: " & ex.Message, "YAM :/",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    '=================FORM LOAD=================
    Private Sub DartBoardForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetDefaultValues()
        Randomize()

        throwsThisTurn.Clear()
        throwCount = 0
        round = 0
        currentRound = 0
        roundString = ""
        currentRoundToString = ""

        If TextBox1 IsNot Nothing Then TextBox1.Clear()
        If Not IO.File.Exists(logFile) Then IO.File.WriteAllText(logFile, "")
        IO.File.AppendAllText(logFile, $"{Environment.NewLine}----- SESSION START {DateTime.Now:yyyy-MM-dd HH:mm:ss} -----{Environment.NewLine}")

    End Sub


End Class
