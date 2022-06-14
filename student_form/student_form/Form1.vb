Imports Microsoft.Office.Interop
Imports System.Runtime.InteropServices


Public Class Form1

    Dim file As String = "D:\fatima\doc\studentform.xlsx"

    Dim app As Excel.Application = New Excel.Application()
    Dim book As Excel.Workbook = app.Workbooks.Open(file)
    Dim sheet As Excel.Worksheet = app.Worksheets(1)

    Dim r As Integer


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        r = 2
        Do Until sheet.Range("a" & r).Text = ""
            r = r + 1

        Loop

        sheet.range("a" & r).value = id1.Text
        sheet.range("b" & r).value = name1.Text
        sheet.range("c" & r).value = email1.Text
        sheet.range("d" & r).value = number1.Text
        sheet.range("e" & r).value = dob1.Text
        sheet.range("f" & r).value = gender1.Text


        id1.Text = ""
        name1.Text = ""
        email1.Text = ""
        number1.Text = ""
        dob1.Text = ""
        gender1.Text = ""
        book.Save()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        app.Visible = True
        sheet.Range("A1").Value = "ID"
        sheet.Range("B1").Value = "Full Name"
        sheet.Range("C1").Value = "Email"
        sheet.Range("D1").Value = "Mobile No"
        sheet.Range("E1").Value = "DOB"
        sheet.Range("F1").Value = "Gender"

        With sheet.Range("A1", "F1")
            .Font.Bold = True
            .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
            .Borders.LineStyle = Excel.XlLineStyle.xlContinuous
            .Borders.Weight = 2D
        End With
    End Sub



    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        id1.Text = ""
        name1.Text = ""
        email1.Text = ""
        number1.Text = ""
        dob1.Text = ""
        gender1.Text = ""
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        book.Save()
        book.Close()
        app = Nothing
        Close()

    End Sub
End Class
