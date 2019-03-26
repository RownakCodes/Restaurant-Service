Module Module1

    Sub Starters()

        Dim startersgg(,) As String = {{0, "Spring Rolls"}, {1, "Soup"}, {2, "French Fries"}, {3, "Noodles"}, {4, "Exit"}}
        Dim ChoiceOfstarters As Integer
        Console.WriteLine("")
        Console.WriteLine("")
        Console.WriteLine("")

        For x = 0 To 4
            For j = 0 To 1
                Console.Write(startersgg(x, j) & "  ")
            Next
            Console.WriteLine("")
        Next

        Console.WriteLine("")
        Console.WriteLine("")
        Console.WriteLine("")
        Console.WriteLine("Enter the choice of your Refreshment by en   tering the respective number: ")
        Dim StarterFile As New IO.StreamWriter("D:\StarterList.txt")
        Dim orderStarterarray(10) As String

        For a = 0 To 5
            ChoiceOfstarters = CInt(Console.ReadLine())

            If (ChoiceOfstarters < 5) Then
                orderStarterarray(a) = startersgg(ChoiceOfstarters, 1)

                StarterFile.WriteLine(orderStarterarray(a))

                If (ChoiceOfstarters = 4) Then
                    Exit For
                End If
                Console.WriteLine("What else do you want?")
            Else
                Console.WriteLine("Try again: ")
                a = a - 1
            End If
        Next
        StarterFile.Close()

        Console.WriteLine("")
        Console.WriteLine("")
        Console.WriteLine("")

        Console.WriteLine("Your order Starters are: ")
        For x = 0 To 4

            Console.WriteLine(orderStarterarray(x))


        Next

    End Sub


    Sub Refreshments()
        Dim refreshmentsgg(,) As String = {{0, "Orange Juice"}, {1, "Mango Juice"}, {2, "Soft Drinks"}, {3, "Coffee"}, {4, "Exit"}}
        Dim ChoiceOfRefreshments As Integer

        For x = 0 To 4
            For j = 0 To 1
                Console.Write(refreshmentsgg(x, j) & "  ")
            Next
            Console.WriteLine("")
        Next

        Console.WriteLine("")
        Console.WriteLine("")
        Console.WriteLine("")


        Console.WriteLine("")
        Console.WriteLine("")
        Console.WriteLine("")
        Console.WriteLine("Enter the choice of your Refreshment by entering the respective number: ")

        Dim orderRefreshmentsarray(10) As String




        Dim RefreshmentFile As New IO.StreamWriter("D:\RefreshmentList.txt")
        For a = 0 To 5
            ChoiceOfRefreshments = CInt(Console.ReadLine())

            If (ChoiceOfRefreshments < 5) Then
                orderRefreshmentsarray(a) = refreshmentsgg(ChoiceOfRefreshments, 1)
                RefreshmentFile.WriteLine(orderRefreshmentsarray(a))

                If (ChoiceOfRefreshments = 4) Then
                    Exit For
                End If
                Console.WriteLine("What else do you want?")
            Else
                Console.WriteLine("Try again")
                a = a - 1
            End If
        Next

        Console.WriteLine("")
        Console.WriteLine("")

        Console.WriteLine("")

        RefreshmentFile.Close()





        Console.WriteLine("Your order Refreshments are: ")
        For x = 0 To 4

            Console.WriteLine(orderRefreshmentsarray(x))


        Next
    End Sub


    Sub MainCourse()
        Dim mainCoursegg(,) As String = {{0, "Briyani"}, {1, "Khichuri"}, {2, "Roast"}, {3, "Beef"}, {4, "Exit"}}
        Dim choiceOfMaincourse As Integer

        For x = 0 To 4
            For j = 0 To 1
                Console.Write(mainCoursegg(x, j) & "  ")
            Next
            Console.WriteLine("")
        Next


        Console.WriteLine("")
        Console.WriteLine("")
        Console.WriteLine("")
        Console.WriteLine("Enter the choice of your Main Course by entering the respective number: ")




        Dim MainFile As New IO.StreamWriter("D:\MainCourseFile.txt")
        Dim orderMainarray(10) As String

        For a = 0 To 5
            choiceOfMaincourse = CInt(Console.ReadLine())

            If (choiceOfMaincourse < 5) Then
                orderMainarray(a) = mainCoursegg(choiceOfMaincourse, 1)
                MainFile.WriteLine(orderMainarray(a))


                If (choiceOfMaincourse = 4) Then
                    Exit For
                End If
            Else
                Console.WriteLine("Try again: ")
                a = a - 1

            End If
            Console.WriteLine("What else do you want?")
        Next

        Console.WriteLine("")
        Console.WriteLine("")
        Console.WriteLine("")


        MainFile.Close()

        Console.WriteLine("Your order Main Course are: ")
        For x = 0 To 4

            Console.WriteLine(orderMainarray(x))


        Next

    End Sub


    Sub Deserts()
        Dim desert(,) As String = {{0, "Pudding"}, {1, "Custard"}, {2, "Sweets"}, {3, "Exit"}}
        Dim choiceOfDesert As Integer

        For x = 0 To 3
            For j = 0 To 1
                Console.Write(desert(x, j) & "  ")
            Next
            Console.WriteLine("")
        Next




        Console.WriteLine("")
        Console.WriteLine("")
        Console.WriteLine("")
        Console.WriteLine("Enter the choice of your Main Course by entering the respective number: ")

        Dim orderDesertarray(10) As String
        Dim DesertFile As New IO.StreamWriter("D:\DesertFile.txt")



        For a = 0 To 5
            choiceOfDesert = CInt(Console.ReadLine())

            If (choiceOfDesert < 4) Then
                orderDesertarray(a) = desert(choiceOfDesert, 1)
                DesertFile.WriteLine(orderDesertarray(a))

                If (choiceOfDesert = 3) Then
                    Exit For
                End If
                Console.WriteLine("What else do you want?")
            Else
                Console.WriteLine("Try again")
                a = a - 1
            End If
        Next

        DesertFile.Close()

        Console.WriteLine("")
        Console.WriteLine("")
        Console.WriteLine("")

        Console.WriteLine("Your order from Deserts are: ")
        For x = 0 To 10

            Console.WriteLine(orderDesertarray(x))


        Next
    End Sub


    Sub Main()

        Console.WriteLine("Welcome to SFC")
        Console.WriteLine("Feel free to use this software to order from your table and do remember, you are allowed to make only 5 orders from each group!")

        Console.WriteLine("")
        Console.WriteLine("")

        Dim cour(,) As String = {{0, "Refreshments"}, {1, "Starters"}, {2, "Main Course"}, {3, "Deserts"}, {4, "Exit"}}
        Dim choiceOfCourse As Integer

        For x = 0 To 4
            For j = 0 To 1
                Console.Write(cour(x, j) & "  ")
            Next
            Console.WriteLine("")
        Next

        Console.WriteLine("")
        Console.WriteLine("")
        Console.WriteLine("")
        Console.WriteLine("Enter the choice of your course by entering the respective number: ")

        For hell = 1 To 10
            choiceOfCourse = CInt(Console.ReadLine())
            Console.WriteLine("")
            Console.WriteLine("")


            Select Case choiceOfCourse
                Case 0
                    Refreshments()
                Case 1
                    Starters()
                Case 2
                    MainCourse()
                Case 3
                    Deserts()
                Case 4
                    Exit For
                Case Else
                    Console.WriteLine("Try again: ")
                    choiceOfCourse = choiceOfCourse - 1
            End Select




            Console.WriteLine("")
            Console.WriteLine("")
            Console.WriteLine("")
            For x = 0 To 4
                For j = 0 To 1
                    Console.Write(cour(x, j) & "  ")
                Next
                Console.WriteLine("")
            Next

            Console.WriteLine("Which course do you want to order next?")
        Next

        Console.WriteLine("")
        Console.WriteLine("")
        Console.WriteLine("")
        Console.WriteLine("")

        'Getting all of the orders from the files!


        Dim FinalCourse(5), FinalDesert(5), FinalRefreshment(5), FinalStarter(5) As String


        Dim a As Integer = 0
        Dim ReadingMainCourse As New IO.StreamReader("D:\MainCourseFile.txt")
        While a < UBound(FinalCourse)
            FinalCourse(a) = ReadingMainCourse.ReadLine
            a = a + 1
        End While
        ReadingMainCourse.Close()


        a = 0
        Dim ReadingDesert As New IO.StreamReader("D:\DesertFile.txt")
        While a < UBound(FinalDesert)
            FinalDesert(a) = ReadingDesert.ReadLine
            a = a + 1
        End While
        ReadingDesert.Close()


        a = 0
        Dim ReadingStarter As New IO.StreamReader("D:\StarterList.txt")
        While a < UBound(FinalStarter)
            FinalStarter(a) = ReadingStarter.ReadLine
            a = a + 1
        End While
        ReadingStarter.Close()


        a = 0
        Dim ReadingRefreshment As New IO.StreamReader("D:\RefreshmentList.txt")
        While a < UBound(FinalRefreshment)
            FinalRefreshment(a) = ReadingRefreshment.ReadLine
            a = a + 1
        End While
        ReadingRefreshment.Close()


        'Printing all the orders togeter: 


        Console.WriteLine("")
        Console.WriteLine("Your order from Refreshment is : ")
        For index = 0 To UBound(FinalRefreshment)
            Console.WriteLine(FinalRefreshment(index))
        Next

        Console.WriteLine("")
        Console.WriteLine("Your order from Starter is : ")
        For index = 0 To UBound(FinalStarter)
            Console.WriteLine(FinalStarter(index))
        Next


        Console.WriteLine("")
        Console.WriteLine("Your order from Main Course is : ")
        For index = 0 To UBound(FinalCourse)
            Console.WriteLine(FinalCourse(index))
        Next


        Console.WriteLine("")
        Console.WriteLine("Your order from Desert is : ")
        For index = 0 To UBound(FinalDesert)
            Console.WriteLine(FinalDesert(index))
        Next

    End Sub

End Module

