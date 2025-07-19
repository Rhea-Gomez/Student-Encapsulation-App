namespace StudentEncapsulation
{
    public class Program
    {
        static void Main(string[] args)
        {
            bool flag;
            do
            {
                Console.Write("Enter your Roll number: ");
                int rollno = int.Parse(Console.ReadLine());

                Console.Write("Enter your name: ");
                string name = Console.ReadLine();

                Console.Write("Enter your cgpi: ");
                double cgpi = double.Parse(Console.ReadLine());

                Student student = new Student(rollno, name, cgpi);
                flag = student.ValidateStudentDetails();
                student.CalculatePercentage();
            } while (!flag);
        }
    }
}
