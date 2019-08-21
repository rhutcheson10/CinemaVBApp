Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports CinemaVBApp

<TestClass()> Public Class UnitTest1

    <TestMethod()> Public Sub Adult_Before_5_Test()


        Dim form1 As Form = New Form
        Dim adult_before_5 = form1.Adult_Before_5(1, "Adult", False, 4)


        Assert.AreEqual(14.5, adult_before_5)



    End Sub

    <TestMethod()> Public Sub Adult_After_5_Test()


        Dim form1 As Form = New Form
        Dim adult_after_5 = form1.Adult_After_5(1, "Adult", False, 6)

        Assert.AreEqual(17.5, adult_after_5)
    End Sub


    <TestMethod()> Public Sub Adult_Tuesday()


        Dim form1 As Form = New Form
        Dim adult_tuesday = form1.Adult_Tuesday(1, "Adult", True)

        Assert.AreEqual(13, adult_tuesday)
    End Sub

    <TestMethod()> Public Sub Child_Under_16()


        Dim form1 As Form = New Form
        Dim child_under_16 = form1.Child_Under_16(1, "Child")
        Assert.AreEqual(12, child_under_16)

    End Sub

    <TestMethod()> Public Sub Senior()

        Dim form1 As Form = New Form
        Dim senior = form1.Senior(1, "Senior")
        Assert.AreEqual(12.5, senior)

    End Sub

    <TestMethod()> Public Sub Student()

        Dim form1 As Form = New Form
        Dim student = form1.Student(1, "Student", False)
        Assert.AreEqual(14, student)

    End Sub

    <TestMethod()> Public Sub Chick_Flick()

        Dim form1 As Form = New Form
        Dim chick_flick = form1.Chick_Flick_Thursday(1, "Adult")
        Assert.AreEqual(21.5, chick_flick)

    End Sub

    <TestMethod()> Public Sub Kids_Carers()

        Dim form1 As Form = New Form
        Dim kids_carers = form1.Kids_Carers(1, True, False)
        Assert.AreEqual(12, kids_carers)

    End Sub

    <TestMethod()> Public Sub Family_Pass()

        Dim form1 As Form = New Form
        Dim family_pass = form1.Family_Pass(1)
        Assert.AreEqual(46, family_pass)

    End Sub

End Class