namespace L7_2;

class Program
{
static void Main(string[] args)
   {
            Console.WriteLine("Press 1) Software Department 2) Computer Department");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    SoftwareDepartment softwareDepartment = new SoftwareDepartment();
                    softwareDepartment.InputMarks();
                    softwareDepartment.CalculateObtainedMarks();
                    softwareDepartment.CalculatePercentage();
                    softwareDepartment.DisplayMarksheet();
                    break;
                case 2:
                    ComputerDepartment computerDepartment = new ComputerDepartment();
                    computerDepartment.InputMarks();
                    computerDepartment.CalculateObtainedMarks();
                    computerDepartment.CalculatePercentage();
                    computerDepartment.DisplayMarksheet();
                    break;
                default:
                    Console.WriteLine("Invalid Choice");
                    break;
            }
        }
    }
