namespace L7_2;
 public class Marksheet
    {
        public int rollNo;
        public string name;
        public int[] marks = new int[5];
        public int ObtainedMarks;
        public int totalMarks = 500;
        public double percentage;
        public string Department;

        public void CalculateObtainedMarks()
        {
            ObtainedMarks = 0;
            foreach (int mark in marks)
            {
                ObtainedMarks += mark;
            }
        }

        public void CalculatePercentage()
        {
            percentage = ((double)ObtainedMarks / totalMarks) * 100;
        }

        public void DisplayMarksheet()
        {
            // Placeholder method, you can add your custom logic to display the marksheet
            Console.WriteLine("\n-------------------------------------");
            Console.WriteLine("\t\tMarks Sheet");
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Roll No: " + rollNo);
            Console.WriteLine("Department: " + Department);
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Marks: " + ObtainedMarks);
            Console.WriteLine("Percentage: " + percentage);
            Console.WriteLine("-------------------------------------");
        }
    }

    public class SoftwareDepartment : Marksheet
    {
        public void InputMarks()
        {
            Department = "Software Engineering";
            Console.WriteLine("Enter Roll No: ");
            rollNo = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Name: ");
            name = Console.ReadLine();
            Console.WriteLine("Enter Marks: ");
            Console.WriteLine("Enter English Marks: ");
            marks[0] = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Software Engineering Marks: ");
            marks[1] = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Maths Marks: ");
            marks[2] = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Physics Marks: ");
            marks[3] = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter OOP Marks: ");
            marks[4] = int.Parse(Console.ReadLine());
        }
    }

    public class ComputerDepartment : Marksheet
    {
        public void InputMarks()
        {
            Department = "Computer Science";
            Console.WriteLine("Enter Roll No: ");
            rollNo = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Name: ");
            name = Console.ReadLine();
            Console.WriteLine("Enter Marks: ");
            Console.WriteLine("Enter Computer Science Marks: ");
            marks[0] = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter English Marks: ");
            marks[1] = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Maths Marks: ");
            marks[2] = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Physics Marks: ");
            marks[3] = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Machine Learning Marks: ");
            marks[4] = int.Parse(Console.ReadLine());
        }
    }