Imports System
Imports System.Xml

Module Program

    'Clase en VB.Net
    Class Figure
        Public length As Double

        Public breadth As Double
        Public Sub DivisionFunction(ByVal n1 As Integer, ByVal n2 As Integer)
            Dim answer As Integer
            Try
                answer = n1 \ n2
            Catch ex As DivideByZeroException
                Console.WriteLine("Exception: {0}", ex)
            Finally
                Console.WriteLine("Answer is: {0}", answer)
            End Try
        End Sub

    End Class

    'Estructura en VB.Net
    Structure Struct
        Public x As Integer
        Public y As Integer
    End Structure

    Public Class Foo
        Public Property Bar As String
        Public Sub New(ByVal Bar As String)
            Me.Bar = Bar
        End Sub
    End Class

    Public Class ByValRef
        Public Sub RefTest(ByRef Baz As Foo)
            Baz.Bar = "Foo"
            Baz = New Foo("replaced")
        End Sub

        Public Sub ValTest(ByVal Baz As Foo)
            Baz.Bar = "Foo"
            Baz = New Foo("replaced")
        End Sub
    End Class


    Sub Main(args As String())
        Dim Rectangle As Figure = New Figure()
        Dim area As Double = 0.0

        Rectangle.length = 8.0

        Rectangle.breadth = 7.0
        area = Rectangle.length * Rectangle.breadth
        Console.WriteLine("Area of Rectangle is : {0}", area)

        Dim st As New Struct
        st.x = 10
        st.y = 20
        Dim sum As Integer = st.x + st.y
        Console.WriteLine("The result is {0}", sum)

        'Variable declaration in VB.NET:
        Dim x As Integer
        x = 10
        Dim name As String
        name = "John"

        Dim checker As Boolean
        checker = True

        Dim var_w As Boolean = True
        Dim var_x As Boolean = True

        Dim A As Boolean = True
        Dim B As Boolean = False

        Dim var_y As Integer = 5
        Dim var_z As Integer = 20

        'Logical Operators in VB.Net
        If (var_w And var_x) Then
            Console.WriteLine("var_w And var_x - is true")
        End If
        If (var_w Or var_x) Then
            Console.WriteLine("var_w Or var_x - is true")
        End If
        If (var_w Xor var_x) Then
            Console.WriteLine("var_w Xor var_x - is true")
        End If

        If (var_y And var_z) Then
            Console.WriteLine("var_y And var_z - is true")
        End If
        If (var_y Or var_z) Then
            Console.WriteLine("var_y Or var_z - is true")
        End If

        If (A Xor B) Then
            Console.WriteLine("A Xor B - is true")
        End If

        Console.WriteLine(" Operands var_w Xor var_x : {0}", var_w Xor var_x)
        Console.WriteLine(" Operands A Xor B : {0}", A Xor B)

        'Only logical operators
        If (var_w AndAlso var_x) Then
            Console.WriteLine("var_w AndAlso var_x - is true")
        End If
        If (var_w OrElse var_x) Then
            Console.WriteLine("var_w OrElse var_x - is true")
        End If

        var_w = False
        var_x = True
        If (var_w And var_x) Then
            Console.WriteLine("var_w And var_x - is true")
        Else
            Console.WriteLine("var_w And var_x - is not true")
        End If

        If (Not (var_w And var_x)) Then
            Console.WriteLine("Not operator var_w And var_x - is true", Not (var_w And var_x))
        End If

        'Bit Shift Operator Example in VB.Net
        Dim w2 As Integer = 50
        Dim x2 As Integer = 11
        Dim y2 As Integer = 0
        y2 = w2 And x2
        Console.WriteLine("y2 = w2 And x2 is {0}", y2)
        y2 = w2 Or x2

        Console.WriteLine("y2 = w2 Or x2 is {0}", y2)
        y2 = w2 Xor x2

        Console.WriteLine("y2 = w2 Xor x2  is {0}", y2)
        y2 = Not w2

        Console.WriteLine("y2 = Not w2 is {0}", y2)

        'Assignment Operator Example in VB.Net
        Dim x3 As Integer = 5

        Dim y3 As Integer

        y3 = x3
        Console.WriteLine(" y3 = x3 gives y3 = {0}", y3)

        y3 += x3
        Console.WriteLine(" y3 += x3 gives y3 = {0}", y3)

        y3 -= x3
        Console.WriteLine(" y3 -= x3 gives y3 = {0}", y3)

        y3 *= x3
        Console.WriteLine(" y3 *= x3 gives y3 = {0}", y3)

        'Miscellaneous Operator Example in VB.Net
        Dim x4 As Integer = 5
        Console.WriteLine(GetType(Integer).ToString())
        Console.WriteLine(GetType(String).ToString())
        Console.WriteLine(GetType(Double).ToString())

        Dim trippleValue = Function(val As Integer) val * 3
        Console.WriteLine(trippleValue(2))
        Console.WriteLine(If(x4 >= 0, "Positive", "Negative"))

        'How to Declare and Initialize an Array
        Dim myData() As Integer
        'Dim myData(10) As String
        myData = {11, 12, 22, 7, 47, 32}
        Dim students() As String = {"John", "Alice", "Antony", "Gloria", "jayden"}

        'Matrices de tamaño fijo
        Dim estudiantes(0 To 2) As String
        estudiantes(0) = "John"
        estudiantes(1) = "Alice"
        estudiantes(2) = "Antony"

        'Matrices dinámicas
        Dim nums() As Integer
        ReDim nums(1)
        nums(0) = 12
        nums(1) = 23

        For i = 0 To nums.Length - 1
            Console.WriteLine("Initial array element: {0}", nums(i))
        Next

        ReDim Preserve nums(2) 'conservamos los dos elementos que ya tiene
        nums(2) = 35

        For i = 0 To nums.Length - 1
            Console.WriteLine("Final array element: {0}", nums(i))
        Next

        'The Join Function
        Dim classmates As String
        classmates = Join(estudiantes, " , ")
        Console.WriteLine(classmates)

        'Eliminación de una matriz
        Erase nums
        Console.WriteLine("Delete array: {0}", nums)

        'Recuperar el contenido de una matriz
        Console.WriteLine("El primer estudiante es {0} ", estudiantes(0))

        Dim myarray() As String
        Dim guru99 As String
        Dim x6 As Integer

        'La función de división (The Split Function)
        guru99 = "Welcome, to, Guru99"
        myarray = Split(guru99, ", ")

        For x6 = LBound(myarray) To UBound(myarray)

            Console.WriteLine(myarray(x6))

        Next

        'VB.Net Comparison Operator
        Dim x5 As Integer = 11
        Dim y5 As Integer = 5

        If "world" <> "wifi" Then 'Not equal to
            Console.WriteLine("Not equal to: True")
        Else
            Console.WriteLine("Equal to")
        End If

        If (x5 = y5) Then
            Console.WriteLine("11=5 is True")
        Else
            Console.WriteLine(" 11=5 is False")
        End If

        If (x5 < y5) Then
            Console.WriteLine(" 11<5 is True")
        Else
            Console.WriteLine(" 11<5 is False")
        End If

        If (x5 > y5) Then
            Console.WriteLine(" 11>5 is True")
        Else
            Console.WriteLine(" 11>5 is False")
        End If

        x5 = 3
        y5 = 7
        If (x5 <= y5) Then
            Console.WriteLine(" 3<=7 is True")
        End If
        If (y5 >= x5) Then
            Console.WriteLine(" 7>=3 is True")
        End If

        'Substring Method
        Dim substOne As String = "Guru99"

        Dim subst As String = substOne.Substring(0, 4)
        Dim substTwo As String = substOne.Substring(4)
        Dim substThree As String = substOne.Substring(2, 2)

        Dim mid1 As Char = substOne(1)
        Console.WriteLine(mid1)
        Dim mid2 As String = substOne.Substring(1, 1)
        Console.WriteLine(mid2)

        Console.WriteLine("The substring is: {0}", subst)
        Console.WriteLine("The substring two is: {0}", substTwo)
        Console.WriteLine("The substring three is: {0}", substThree)

        'How To Use For Each Loop in VB.Net
        Dim myArrayOne() As Integer = {10, 3, 12, 23, 9}

        Dim item As Integer

        For Each item In myArrayOne
            Console.WriteLine(item)
        Next

        'Bucles for anidados en VB.Net
        Dim numsOne() As Integer = {12, 23, 35}

        Dim names() As String = {"Guru99", "alice", "antony"}

        For Each n As Integer In numsOne

            For Each z As String In names

                Console.Write(n.ToString & z & " ")
            Next
        Next

        'VB.Net Exit For and Continue For Statement
        Dim numsTwo() As Integer =
    {10, 12, 14, 17, 19, 23, 26, 31, 33, 37, 40, 48}

        For Each n As Integer In numsTwo

            If n >= 17 And n <= 25 Then
                Continue For
            End If

            Console.Write(n.ToString & " ")

            If n = 37 Then
                Exit For
            End If
        Next

        'VB.Net Select Case Statement Program Examples
        Dim nameOne As String

        nameOne = "Guru99"

        Select Case nameOne

            Case "John"
                Console.WriteLine("Hello John")

            Case "Guru99"
                Console.WriteLine("Hello Guru99")

            Case "Alice"
                Console.WriteLine("Hello Alice")

            Case "Joel"
                Console.WriteLine("Hello Joel")

            Case Else
                Console.WriteLine("unknown name")

        End Select
        Console.WriteLine("VB.NET is easy!")

        'ByRef vs ByVal
        Dim MyFoo As New Foo("-")
        Dim MyByValRef As New ByValRef()
        MyByValRef.RefTest(MyFoo)
        Console.WriteLine(MyFoo.Bar) ''# outputs replaced
        MyByValRef.ValTest(MyFoo)
        Console.WriteLine(MyFoo.Bar) ''# outputs Foo

        Rectangle.DivisionFunction(4, 0)

        Dim itemsXml As String
        Dim itemXml As String
        'Dim itemTextXml As String
        Dim getAtribItems As String
        Dim test1Node As XmlNode = Nothing

        Dim xmlText As String = "<?xml version='1.0' encoding='UTF-8'?><root><items id='A001'><item id='W01MB154' href='01MB154.html' media-type='application/xhtml+xml' /><item id='W000Title' href='000Title.html' media-type='application/xhtml+xml' /></items><itemrefs><itemref idref='W000Title' />Hello text<itemref idref='W01MB154' /></itemrefs></root>"
        Dim xmlDoc As XmlDocument = New XmlDocument()
        xmlDoc.LoadXml(xmlText)

        Dim itemRefList As XmlNodeList = xmlDoc.GetElementsByTagName("itemref")
        'itemsXml = xmlDoc.DocumentElement.SelectSingleNode("/root/items").InnerXml
        test1Node = xmlDoc.DocumentElement.SelectSingleNode("/root/items")
        'getAtribItems = xmlDoc.DocumentElement.SelectSingleNode("/root/items/item").Attributes.GetNamedItem("id").InnerXml
        getAtribItems = xmlDoc.DocumentElement.SelectSingleNode("/root/items").Attributes.GetNamedItem("id").InnerXml

        test1Node.InnerText = "Test inner text"

        Console.WriteLine("Doc completo ", xmlDoc)
        Console.WriteLine(getAtribItems)

        For Each xmlNode As XmlElement In itemRefList

            itemXml = xmlNode.Attributes.GetNamedItem("idref").InnerXml
            'itemTextXml = xmlNode.Attributes.GetNamedItem("idref").InnerText

            Console.WriteLine(itemXml)
            'Console.WriteLine("Inner text ", itemTextXml)
        Next
        Console.WriteLine(itemsXml)

        Console.ReadLine()
        Console.ReadKey()
    End Sub
End Module
