Imports System


Public Class Employee
        Public Name As String
        Public Emp_id As Integer
        Public salary As Char

        ' Constructor to initialize the Employee object
        Public Sub New(name As String, Emp_id As Integer, salary As Char)
            Me.Name = name
            Me.Emp_id = Emp_id
            Me.salary = salary

        End Sub

        ' Function to display Employee details
        Public Sub DisplayDetails()
            Console.WriteLine("Name: " & Name)
            Console.WriteLine("Emp_id: " & Emp_id)
        Console.WriteLine("salary:" & salary)
        Console.WriteLine()
        End Sub
    End Class

    Module Program
    Sub Main()
        Dim Emp As New List(Of Employee)()

        Dim choice As Integer

        Do
            Console.WriteLine("Menu:")
            Console.WriteLine("1. Add Employee")
            Console.WriteLine("2. Display All Employees")
            Console.WriteLine("3. Delete")
            Console.WriteLine("4. Exit")
            Console.Write("Enter your choice: ")
            choice = Console.ReadLine()

            Select Case choice
                Case 1
                    Console.Write("Enter Employee name: ")
                    Dim name As String = Console.ReadLine()
                    Console.Write("Enter Employee Emp_id: ")
                    Dim Emp_id As Integer = Convert.ToInt32(Console.ReadLine())
                    Console.Write("Enter Employee salary: ")
                    Dim salary As Char = Console.ReadLine()(0)

                    ' Create a new Employee object and add it to the list
                    Dim employee As New Employee(name, Emp_id, salary)
                    Emp.Add(employee)
                    Console.WriteLine("Employee added successfully.")
                    Console.WriteLine()
                Case 2
                    If Emp.Count > 0 Then
                        Console.WriteLine("Details of all employees:")
                        For Each employee As Employee In Emp
                            employee.DisplayDetails()
                        Next
                    Else
                        Console.WriteLine("No Employee added yet.")
                    End If
                    Console.WriteLine()
                Case 3
                    If Emp.Count > 0 Then
                        Emp.Clear()
                        Console.WriteLine(" All Succesfully deleted")
                    Else
                        Console.WriteLine("No Employee added yet.")
                    End If
                    Console.WriteLine()

                Case 4
                    Console.WriteLine("Exiting program...")

                Case Else
                    Console.WriteLine("Invalid choice. Please enter a valid option.")
                    Console.WriteLine()
            End Select

        Loop While choice <> 3
    End Sub
End Module
