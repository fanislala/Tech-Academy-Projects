using System;

// Define the IQuittable interface
interface IQuittable
{
    // Method to quit
    void Quit();
}

// Define the Employee class inheriting from IQuittable interface
class Employee : IQuittable
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

    // Implement the Quit method defined in the IQuittable interface
    public void Quit()
    {
        Console.WriteLine($"{FirstName} {LastName} is quitting the job.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Create an object of type IQuittable using polymorphism
        IQuittable employee = new Employee(1, "Ahmed", "Faisal");

        // Call the Quit method on the object
        employee.Quit();
    }
}