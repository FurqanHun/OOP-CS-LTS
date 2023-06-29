namespace L6_4;
public class Employee
{
    public string name;
    public string dept;
    public string design;
    public void EmpName()
    {
        Console.WriteLine("Enter Employee Name: ");
        name = Console.ReadLine();
        Console.WriteLine("Employee Name: " + name);
    }
    public void DeptList()
    {
        Console.WriteLine("Enter Employee Department: ");
        dept = Console.ReadLine();
    }
    public void EmpDesig()
    {
        Console.WriteLine("Enter Employee Designation: ");
        design = Console.ReadLine();
    }
}
