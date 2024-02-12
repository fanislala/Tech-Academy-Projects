using System;

// Define the Employee class
class Employee
{
    // Properties
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }

    // Constructor
    public Employee(int id, string firstName, string lastName)
    {
        Id = id;
        FirstName = firstName;
        LastName = lastName;
    }

    // Overload the "==" operator to compare Employees based on their Id property
    public static bool operator ==(Employee emp1, Employee emp2)
    {
        // Check if both objects are null or if their Ids are equal
        return ReferenceEquals(emp1, null) && ReferenceEquals(emp2, null) || 
               !ReferenceEquals(emp1, null) && !ReferenceEquals(emp2, null) && emp1.Id == emp2.Id;
    }

    // Overload the "!=" operator by default
    public static bool operator !=(Employee emp1, Employee emp2)
    {
        // Return the negation of the result of the "==" operator
        return !(emp1 == emp2);
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Instantiate two Employee objects and assign values to their properties
        Employee emp1 = new Employee(1, "Ahmed", "Faisal");
        Employee emp2 = new Employee(1, "Ahmed", "Faisal"); // Note: Same Id as emp1

        // Compare the two Employee objects using the overloaded operators
        bool areEqual = emp1 == emp2;

        // Display the result of the comparison
        Console.WriteLine($"Are the two employees equal? {areEqual}");
    }
}