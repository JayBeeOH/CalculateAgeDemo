'-----------------------------------------------------------------------------------------
'           Notice of My Copyright and Intellectual Property Rights
'
' Any intellectual property contained within the program by Joseph L. Bolen remains the
' intellectual property of the Joseph L. Bolen. This means that no person may distribute,
' publish or provide such intellectual property to any other person or entity for any
' reason, commercial or otherwise, without the express written permission of Joseph L. Bolen.
'
'                 Copyright © 2018. All rights reserved.
'        All trademarks remain the property of their respective owners.
'-------------------------------------------------------------------------------------------
' Program Name:   Calculate Age Demo
'
' Author:         Joseph L. Bolen
' Date Created:   04 JAN 2018
'
' Description:    Demonstrate how to determine a person's age from their birthdate,
'
'                 Documentation is at:
'                   App's Visual Basic .NET code is at: https://pastebin.com/UB2aqCW9  

Module Module1

    Sub Main()
        Console.Write("Enter your birthdate (mm/dd/yyyy): ")
        Try
            Dim DOB As Date = Date.Parse(Console.ReadLine)
            Console.WriteLine($"Your age is: {GetAge(DOB)}")
        Catch ex As FormatException
            Console.WriteLine("Input Error: Birthday was not entered in correct format.")
        End Try

        Console.ReadKey()
    End Sub

    Private Function GetAge(birthdate As Date) As Integer
        Dim age As Integer = Today.Year - birthdate.Year
        Dim birthdayThisYear As New Date(Today.Year, birthdate.Month, birthdate.Day)
        If birthdayThisYear > Today Then
            age -= 1
        End If
        Return age
    End Function
End Module