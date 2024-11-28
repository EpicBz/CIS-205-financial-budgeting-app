using System;
using static System.Console;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class FlaglerBMIApp

    {

        static void Main(string[] args)

        {



            Student student = new Student();





            Write($"Please enter your Student ID: ");

            student.StudentID = Convert.ToInt32(ReadLine());



            Write($"Please enter your name: ");

            student.Name = Convert.ToString(ReadLine());



            Write($"Please enter your age: ");

            student.Age = Convert.ToString(ReadLine());



            Write($"Please enter your gender: ");

            student.Gender = Convert.ToString(ReadLine());



            Write($"Please enter your BMI: ");

            student.BMInumber = Convert.ToDouble(ReadLine());

            

            WriteLine($"Hello {student.Name} based on your BMI {student.BMInumber} and your age {student.Age} your weight status is "+student.status);



        }

        internal class Student

        {



            public int StudentID { get; set; }

            public string Name { get; set; }

            public string Age { get; set; }

            public string Gender { get; set; }

            public double BMInumber { get; set; }



            public string status = "";

            status = DetermineWeightStatus(Student.BMInumber);





            public string DetermineWeightStatus(double bmi)

            {
                string weightstatus;



                double[] BMI = { 18.5, 24.9, 25, 29.99, 30 };

                string[] Status = { "Underweight", "Normal", "Overweight", "Obese" };





                for (int i = 0; i < weightstatus; ++i)

                {

                    if (bmi >= BMI[i])

                        return $"{Status[i]}";



                    if (weightstatus > 30)

                        return "Obese";



                }

                return "Invalid";



            }
        }






    }

    internal class Student

    {



        public int StudentID { get; set; }

        public string Name { get; set; }

        public string Age { get; set; }

        public string Gender { get; set; }

        public double BMInumber { get; set; }



        public string[] status { get; set; }





        public string DetermineWeightStatus(int bmi, int weightstatus)

        {



            double[] BMI = { 18.5, 24.9, 25, 29.99, 30 };

            string[] Status = { "Underweight", "Normal", "Overweight", "Obese" };





            for (int i = 0; i < weightstatus; ++i)

            {

                if (bmi >= BMI[i])

                    return $"{Status[i]}";



                if (weightstatus > 30)

                    return "Obese";



            }

            return "Invalid";



        }
    }
}
