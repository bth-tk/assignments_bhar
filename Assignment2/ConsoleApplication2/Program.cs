using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student(121288, "sutdent1@email.com", "John", "Doe");
            Student student2 = new Student(022391, "student2@email.com", "Raj", "Mohan");
            Student student3 = new Student();
            student3.DOB = 061293;
            student3.email = "student3@email.com";
            student3.firstName = "JiM";
            student3.lastName = "Cooper";

            student1.GetCount();
            student2.GetCount();
            int i;
            i = student3.GetCount();
            Console.WriteLine("Total student count is: {0}", i);



            Console.WriteLine("\nstudent1 details are: \n Date of Birth is: {0} \n Email id is: {1} \n First name is: {2} \n Last name is: {3} \n Id number is: {4}", student1.DOB, student1.email, student1.firstName, student1.lastName, student1.Id());
            Console.WriteLine("\nstudent2 details are: \n Date of Birth is: {0} \n Email id is: {1} \n First name is: {2} \n Last name is: {3} \n Id number is: {4}", student2.DOB, student2.email, student2.firstName, student2.lastName, student2.Id());
            Console.WriteLine("\nstudent3 details are: \n Date of Birth is: {0} \n Email id is: {1} \n First name is: {2} \n Last name is: {3} \n Id number is: {4}", student3.DOB, student3.email, student3.firstName, student3.lastName, student3.Id());
            Console.ReadLine();
        }

    }

    public class Student
    {

        public static int count = 0;
        public int DOB;
        public string email;
        public string firstName;
        public string lastName;
        public static int studentId = 1000;

        //Console.WriteLine("inside class");
        //Console.WriteLine();

        public Student()
        {

        }

        public Student(int DOB, string email, string firstName, string lastName)
        {
            this.DOB = DOB;
            this.email = email;
            this.firstName = firstName;
            this.lastName = lastName;
            //this.studentId = studentId;

        }

        public int GetCount()
        {
            //Console.WriteLine("get count method")	;		
            count = count + 1;
            //Console.WriteLine(count)	;
            return count;
        }
        public int Id()
        {
            studentId = studentId + 1;
            //Console.WriteLine("inside id");
            return studentId;
        }


    }



}
    

