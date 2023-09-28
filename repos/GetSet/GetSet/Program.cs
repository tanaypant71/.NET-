using System;

class Student
{
    // Private fields to store student information
    private string name;
    private int age;

    public string Name
    {
        // Getter
        get { return name; }
        // Setter
        set { name = value; } 
    }

    // Property to get and set the student's age
    public int Age
    {
        get 
        { 
            return age; 
        } 
        set
        {
            // check if age is non-negative
            if (value >= 0)
                age = value;
            else
                Console.WriteLine("Age cannot be negative.");
        }
    }
}

class Program
{
    static void Main()
    {
        Student student = new Student();

        student.Name = "John";
        student.Age = 20;

        // Access and display student properties
        Console.WriteLine("Student Name: " + student.Name);
        Console.WriteLine("Student Age: " + student.Age);

        Console.WriteLine("***********************************");

        // checking an invalid age 
        student.Age = 5; 
        //here we will be getting error

        Console.ReadKey();
    }
}
