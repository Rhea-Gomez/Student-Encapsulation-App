using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentEncapsulation
{
    public class Student
    {
        private int rollno;
        private string name;
        private double cgpi;

        public int Rollno { get { return rollno; } set {rollno = value; } }
        public string Name { get { return name; } set { name = value; } }
        public double Cgpi { get { return cgpi; } set {cgpi = value; } }
        public bool flag;

        public Student(int rollno, string name, double cgpi )
        {
            Rollno = rollno;
            Name = name;
            Cgpi = cgpi;
        }

        public bool ValidateStudentDetails()
        {
            //bool flag = true;
            Console.WriteLine();
            if (Rollno < 0)
            {
                Console.WriteLine("Roll number cannot be negative");
                flag = false;
            }
            else
            {
                Console.WriteLine("Roll No: " + Rollno);
                flag = true;
            }

            if (Name.Length < 5)
            {
                Name = string.Empty;
                Console.WriteLine("Name: " + Name);
                //flag = false;
            }
            else
            {
                Console.Write("Name: " +Name);
                flag = true;
            }

            if (Cgpi < 0 || Cgpi > 10)
            {
                Console.WriteLine("CGPI will range between 1 to 10. Please enter valid CGPI");
                flag = false;
            }
            else
            {
                Console.WriteLine("CGPI: " + Cgpi);
                flag = true;
            }

            
                return flag;
        }

        public void CalculatePercentage()
        {
            double percentage;
            if(flag)
            {
                percentage = Cgpi * 10;
                Console.WriteLine("Percentage: " + percentage + "%");
            }
            else
            {
                Console.WriteLine("Entered details are incorrect");
            }
        }
    }
}
 