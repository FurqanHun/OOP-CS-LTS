namespace L6_4;

class Program
{
    static void Main(string[] args)
    {
        Employee emp = new Employee();
        emp.EmpName();
        emp.DeptList();
        emp.EmpDesig();

        System.Console.WriteLine("Employ Department: " + emp.dept);
        System.Console.WriteLine("Employ Designation: " + emp.design);
    }
}
