namespace oopA1;

class Program
{
    static void Main(string[] args)
    {
        Employee person1 = new Employee();
        person1.name = "Ali";
        person1.email = "ali@xyz.com";
        person1.personid = "123";
        person1.emp_salary = 10000;
        person1.emp_joiningDate = "1/1/2020";
        person1.emp_type = "Permanent";
        person1.ShowDetails();

        System.Console.WriteLine("\n\n");
        Student person2 = new Student();
        person2.name = "Muhammad Furqan Khalil";
        person2.email = "BSE22F116@stu.smiu.edu.pk";
        person2.personid = "116";
        person2.ShowDetails();
        person2.showcoursedetails();

        System.Console.WriteLine("\n\n");
        Management person3 = new Management();
        person3.name = "Kashif";
        person3.email = "kashif@xyz.com";
        person3.personid = "789";
        person3.ShowDetails();

    }
}
