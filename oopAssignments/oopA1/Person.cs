namespace oopA1;

public abstract class Person
{
    public string name { get; set; }
    public string email { get; set; }
    public string personid { get; set; }

    public abstract void ShowDetails();
}

public class Employee : Person
{
    public int emp_salary { get; set; }
    public string emp_joiningDate { get; set; }
    public string emp_type { get; set; }

    public override void ShowDetails()
    {
        Console.WriteLine("Employee Details");
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Email: " + email);
        Console.WriteLine("Person ID: " + personid);
        Console.WriteLine("Salary: " + emp_salary);
        Console.WriteLine("Joining Date: " + emp_joiningDate);
        Console.WriteLine("Employee Type: " + emp_type);
    }
}

public class Student : Person
{
    public int no_of_courses = 3;
    public void showcoursedetails() {
        Console.WriteLine("Course Details");
        System.Console.WriteLine("OOP - Maam Ayesha");
        System.Console.WriteLine("Discrete Structures - Maam Amna");
        System.Console.WriteLine("Financial Accounting - Sir Mushtaq");
    }
    public override void ShowDetails()
    {
        Console.WriteLine("Student Details");
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Email: " + email);
        Console.WriteLine("Person ID: " + personid);
        Console.WriteLine("No of Courses: " + no_of_courses);
    }
}

public class Management : Person
{
    public override void ShowDetails()
    {
        Console.WriteLine("Management Details");
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Email: " + email);
        Console.WriteLine("Person ID: " + personid);
    }
}
