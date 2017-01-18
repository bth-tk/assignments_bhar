using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace assignment3
{
    class Program
    {
        static void Main(string[] args)
        {
            string con = "y";

            while (con == "y" || con == "Y")
            {
                 Console.WriteLine("Please select your operation \n 1. For adding student \n 2. For updating student \n 3. For Deleting student \n 4. To get student details \n 5. To get count");
            
                 int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        //add student
                        Console.WriteLine("Please enter Student First name : ");
                        string fname = Console.ReadLine();

                        Console.WriteLine("Please enter Student Last name : ");
                        string lname = Console.ReadLine();

                        Console.WriteLine("Please enter Student email id : ");
                        string email = Console.ReadLine();

                        Console.WriteLine("Please enter Student DOB : ");
                        int dob = int.Parse(Console.ReadLine());
                        student.addStudent(dob,email,fname,lname);
                        //string s[] = new string[] {fname,lname,email,dob };

                        break;

                    case 2:
                        // update student
                        Console.WriteLine("please enter student id to update");
                        string upd = Console.ReadLine();
                        student.updateStudent();
                        break;

                    case 3:
                        //deleting student
                        Console.WriteLine("please enter student id to delete");
                        string del = Console.ReadLine();
                        student.deleteStudent(del);
                        break;

                    case 4:

                        //get student details 
                        Console.WriteLine("Enter student ID to view details :");
                        string view = Console.ReadLine();
                        

                            break;
                    case 5:

                        //get student count 
                        break;


                    default:
                        Console.WriteLine("Please select legal option");
                        break;

                }
                Console.WriteLine("Do you wish to perform another operation: (y/n)");
                con = Console.ReadLine();

            }

            Console.WriteLine("Thanks for using Student info");
        }

    }


    

    class student
    {
       static int studentID;
        string studentFname;
        string studentLastname;
        int DOB;
        string studentEmail;
        public static int count = 1;

        //public student(int DOB, string studentEmail, string studentFname, string studentLastname) :this()
        //{
        //    studentID = count + 1000;
        //    this.DOB = DOB;
        //    this.studentEmail = studentEmail;
        //    this.studentFname = studentFname;
        //    this.studentLastname = studentLastname;
            
        //}

        public student()
        {
            count++;
        }

        public static void addStudent(int DOB,string studentEmail,string studentFname,string studentLastname)
        {
        getID();
        int Dob = DOB;
        string StudentEmail = studentEmail;
        string StudentFname = studentFname;
        string StudentLastname = studentLastname;
        //string[] s = new string[] {Dob,StudentEmail, };
        File.Create(@"C:\Users\Bharath Reddy\Documents\Visual Studio 2015\Projects\assignments_bhar\assignment3");
       // File.AppendAllLines(@"C:\Users\Bharath Reddy\Documents\Visual Studio 2015\Projects\assignments_bhar\assignment3", );
    }

       public static void updateStudent()
        {
            //File.
        }

        public static void deleteStudent(string id)
        {

        File.Delete(@"C:\Users\Bharath Reddy\Documents\Visual Studio 2015\Projects\assignments_bhar\assignment3");
        Console.WriteLine("Student file successfully deleted");

        }
       
        public static void getStudentDetails()
        {
        if (File.Exists(@"C:\Users\Bharath Reddy\Documents\Visual Studio 2015\Projects\assignments_bhar\assignment3"))
        {
            string [] s1 = File.ReadAllLines(@"C:\Users\Bharath Reddy\Documents\Visual Studio 2015\Projects\assignments_bhar\assignment3");
            //Console.WriteLine(File.ReadAllText(@"C:\Users\Bharath Reddy\Documents\Visual Studio 2015\Projects\assignments_bhar\assignment3"));

        }
        else
        {
            Console.WriteLine("No such id");
        }
    }

       public static int getCount()
        {
            return count;
        }
    public static int getID()
    {
        studentID = count + 10000;

        return studentID;
    }
}

}
