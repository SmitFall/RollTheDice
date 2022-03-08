'Fallon Smith
'RCET0265
'Spring 2022
'Roll the Dice
'https://github.com/SmitFall/RollTheDice

Option Explicit On
Option Strict On

Module RollTheDice

    Sub Main()
        Dim numbers(13) As Integer
        Dim temp As String
        Dim seperator As String = " |"
        Dim columnLength As Integer = 6
        Dim lineSeperator As String = "-"
        Dim LineLength As Integer = columnLength * (UBound(numbers) + 1)


        For i = 1 To 1000
            numbers(GetRandomInteger()) += 1
        Next

        For i = LBound(numbers) To UBound(numbers)
            temp = CStr(i) & " |"
            temp = temp.PadLeft(columnLength)
            Console.Write(temp)
        Next
        Console.WriteLine()
        'separator
        Console.Write(StrDup(LineLength, lineSeperator))
        'display contentents of randomNumber() array

        Console.WriteLine()

        For i = LBound(numbers) To UBound(numbers)

            temp = CStr(numbers(i)) & seperator
            temp = temp.PadLeft(columnLength)
            Console.Write(temp)
        Next
        Console.ReadLine()
    End Sub

    Function GetRandomInteger() As Integer
        Dim value As Integer
        Dim temp As Single

        Randomize()
        temp = (Rnd() * 12) + 1
        value = CInt(System.Math.Floor(CDbl(temp)))
        System.Math.Floor(CDbl(1))

        Return value

    End Function

End Module
