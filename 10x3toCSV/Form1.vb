Imports System.IO
Imports System.Text

Public Class Form1

    Private Sub btnBrowseFrom_Click(sender As Object, e As EventArgs) Handles btnBrowseFrom.Click
        Dim fd As OpenFileDialog = New OpenFileDialog()

        fd.Title = "Open File Dialog"
        fd.InitialDirectory = "C:\"
        fd.Filter = "All files (*.*)|*.*|All files (*.*)|*.*"
        fd.FilterIndex = 2

        If fd.ShowDialog() = DialogResult.OK Then
            txtFrom.Text = fd.FileName
        End If

        If txtTo.Text = "" Then
            Dim fileString As String = fd.FileName.ToString()
            Dim extentionIndex As Integer = fileString.LastIndexOf(".")

            Debug.WriteLine("Length of the file : " + fileString.Length.ToString)
            Debug.WriteLine("extension is at : " + extentionIndex.ToString)

            If rdoTxt.Checked Then
                Debug.WriteLine("add csv to name, .txtmake it .csv, leave name")
                txtTo.Text = fileString.Substring(0, extentionIndex) + "CSV.txt"
                Debug.WriteLine(txtTo.Text)
            Else
                Debug.WriteLine("make it .csv, leave name")
                txtTo.Text = fileString.Substring(0, extentionIndex) + ".csv"
                Debug.WriteLine(txtTo.Text)
            End If

        End If
    End Sub



    Private Sub btnBrowseTo_Click(sender As Object, e As EventArgs) Handles btnBrowseTo.Click
        Dim fd As OpenFileDialog = New OpenFileDialog()

        fd.Title = "Open File Dialog"
        fd.InitialDirectory = "C:\"
        fd.Filter = "All files (*.*)|*.*|All files (*.*)|*.*"
        fd.FilterIndex = 2
        fd.RestoreDirectory = True

        If fd.ShowDialog() = DialogResult.OK Then
            txtTo.Text = fd.FileName
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub

    Private Sub btnConvert_Click(sender As Object, e As EventArgs) Handles btnConvert.Click
        Dim reader As New StreamReader(txtFrom.Text, Encoding.Default)
        Dim lineCount = File.ReadAllLines(txtFrom.Text).Length
        Dim lines(lineCount) As String
        Dim linesFiltered(lineCount / 2 + 1) As String

        Dim first(5), second(5), third(5) As String

        Dim a As String
        Dim i As Integer = 0
        Do
            a = reader.ReadLine
            lines(i) = a
            i += 1
        Loop Until a Is Nothing
        reader.Close()
        ' array contains all lines in file
        i = 0
        Dim y As Integer = 0
        For Each item As String In lines
            If y Mod 2 = 0 Then
            Else
                linesFiltered(i) = item
                i += 1
            End If
            y += 1
        Next

        '53 char Ω            
        Dim fileToWrite As System.IO.StreamWriter
        fileToWrite = My.Computer.FileSystem.OpenTextFileWriter(txtTo.Text, True)
        Dim count As Integer = 0
        Dim keepGoing As Boolean = True
        Dim commaSkip As Boolean = True

        For Each x As String In linesFiltered
            Debug.WriteLine(x)
            If x IsNot Nothing Then

                If x.Chars(0).Equals("Ω"c) Then
                    Debug.WriteLine("EOF")
                    keepGoing = False
                ElseIf x.Chars(0).Equals("-"c) Then
                    Debug.WriteLine("Divider")
                ElseIf keepGoing Then

                    first(count) = x.Substring(0, CType(txtColumn.Text, Integer)).Trim()
                    second(count) = x.Substring(CType(txtColumn.Text, Integer) + 1, CType(txtColumn.Text, Integer)).Trim()
                    third(count) = x.Substring(CType(txtColumn.Text, Integer) * 2, CType(txtColumn.Text, Integer) - 8).Trim()

                    If count.Equals(5) Then

                        For Each t As String In first
                            If t.Equals(Nothing) Then
                            ElseIf t.Trim().Length() > 1 Then
                                If commaSkip = False Then
                                    fileToWrite.Write(" ^ ")
                                End If
                                fileToWrite.Write(t)
                                commaSkip = False
                            End If
                        Next
                        fileToWrite.WriteLine()
                        commaSkip = True

                        For Each t As String In second
                            If t.Equals(Nothing) Then
                            ElseIf t.Trim().Length() > 1 Then
                                If commaSkip = False Then
                                    fileToWrite.Write(" ^ ")
                                End If
                                fileToWrite.Write(t)
                                commaSkip = False
                            End If
                        Next
                        fileToWrite.WriteLine()
                        commaSkip = True

                        For Each t As String In third
                            If t.Equals(Nothing) Then
                            ElseIf t.Trim().Length() > 1 Then
                                If commaSkip = False Then
                                    fileToWrite.Write(" ^ ")
                                End If
                                fileToWrite.Write(t)
                                commaSkip = False
                            End If
                        Next
                        fileToWrite.WriteLine()
                        commaSkip = True
                        count = 0
                    Else

                        count += 1
                    End If
                End If
            End If
        Next

        fileToWrite.Close()
    End Sub
End Class
