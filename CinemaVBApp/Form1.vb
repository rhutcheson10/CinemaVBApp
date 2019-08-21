Public Class Form
    Public Function Adult_Before_5(quantity As Integer, person As String, day As Boolean, time As Integer) As Double
        Dim ticket_price = 14.5
        Dim total_price = ticket_price * quantity

        'Day being False means that it does not fall on a tuesday 
        If day = False And quantity > 0 And quantity <= 10 And person = "Adult" And time < 5 Then

            Return total_price

        End If


    End Function

    Public Function Adult_After_5(quantity As Integer, person As String, day As String, time As Integer) As Double
        Dim ticket_price = 17.5
        Dim total_price = ticket_price * quantity

        'Day being False means that it does not fall on a tuesday 
        If day = False And quantity > 0 And quantity <= 10 And person = "Adult" And time > 5 Then

            Return total_price


        End If


    End Function
    Public Function Adult_Tuesday(quantity As Integer, person As String, day As String) As Int32
        Dim ticket_price = 13
        Dim total_price = ticket_price * quantity

        'Day being True means that it falls on a tuesday 
        If day And quantity > 0 And quantity <= 10 = True And person = "Adult" Then


            Return total_price

        End If

    End Function

    Public Function Child_Under_16(quantity As Integer, person As String) As Int32
        Dim ticket_price = 12
        Dim total_price = ticket_price * quantity

        If quantity > 0 And quantity <= 10 And person = "Child" Then

            Return total_price

        End If


    End Function

    Public Function Senior(quantity As Integer, person As String) As Double
        Dim ticket_price = 12.5
        Dim total_price = ticket_price * quantity

        If quantity > 0 And quantity <= 10 And person = "Senior" Then

            Return total_price

        End If

    End Function
    Public Function Student(quantity As Integer, person As String, day As Boolean) As Int32
        Dim ticket_price = 14
        Dim total_price = ticket_price * quantity

        ' Day being False means that it does not fall on a tuesday 
        If day = False And quantity > 0 And quantity <= 10 And person = "Student" Then

            Return total_price

        End If

    End Function
    Public Function Family_Pass(quantity) As Integer
        Dim ticket_price = 46
        Dim total_price = ticket_price * quantity


        If quantity > 0 And quantity <= 10 Then


            Return total_price
        End If


    End Function

    Public Function Chick_Flick_Thursday(quantity As Integer, person As String) As Double
        Dim ticket_price = 21.5
        Dim total_price = ticket_price * quantity

        If quantity > 0 And quantity <= 10 And person = "Adult" Then

            Return total_price


        End If

    End Function
    Public Function Kids_Carers(quantity As Integer, day As Boolean, holiday As Boolean) As Integer
        Dim ticket_price = 12
        Dim total_price = ticket_price * quantity

        'Day being True means that it falls on Wednesday
        'Not a holiday is false beause it's assuming it's outside of holidays
        If day = True And holiday = False And quantity > 0 And quantity <= 10 Then

            Return total_price

        End If
    End Function



    Private Sub Cinemas_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
