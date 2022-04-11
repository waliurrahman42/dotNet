
Imports SharedLibDemoProject

Module Module1

    Sub Main()
        Dim ob As New SharedLibrary()
        ob.Display()
        ob.Show()
        Dim calc As New Calculator()
        Console.WriteLine(calc.Add(40, 20, 40))

    End Sub

End Module
