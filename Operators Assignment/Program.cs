using System;

// Employee class with Id, FirstName, and LastName properties
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

    // Overloading the equality operator "=="
    public static bool operator ==(Employee emp1, Employee emp2)
    {
        // Check if both objects are null or if the Ids are equal
        return ReferenceEquals(emp1, null) && ReferenceEquals(emp2, null) ||
               !ReferenceEquals(emp1, null) && !ReferenceEquals(emp2, null) &&
               emp1.Id == emp2.Id;
    }

    // Overloading the inequality operator "!=" by simply negating the equality operator
    public static bool operator !=(Employee emp1, Employee emp2)
    {
        return !(emp1 == emp2);
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Instantiating two Employee objects and assigning values to their properties
        Employee emp1 = new Employee(1, "John", "Doe");
        Employee emp2 = new Employee(2, "Jane", "Smith");

        // Comparing the two Employee objects using the overloaded operators
        Console.WriteLine("Employee 1 and Employee 2 are equal: " + (emp1 == emp2));
        Console.WriteLine("Employee 1 and Employee 2 are not equal: " + (emp1 != emp2));

        // Changing the Id of emp2 to make it equal to emp1
        emp2.Id = 1;

        // Comparing again after changing emp2's Id
        Console.WriteLine("Employee 1 and Employee 2 are equal: " + (emp1 == emp2));
        Console.WriteLine("Employee 1 and Employee 2 are not equal: " + (emp1 != emp2));

        Console.ReadLine(); // To keep console window open
    }
}
