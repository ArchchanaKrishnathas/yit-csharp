using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            //string name = "Archchana";
            //Console.WriteLine(name);
            //string name1 = Console.ReadLine();
            //Console.WriteLine(name1);

            //Int32 number = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("number is " + number);




            Console.Write("Enter Your First Name: ");
            string fname = Console.ReadLine();

            Console.Write("Enter Your Last Name: ");
            string lname = Console.ReadLine();

            Console.Write("Enter DOB (yyyy-MM-dd): ");
            DateTime dob = Convert.ToDateTime(Console.ReadLine());

            Console.Write("Enter Address: ");
            string address = Console.ReadLine();

            Console.Write("Enter Telephone No: ");
            string telephone = Console.ReadLine();

            Console.Write("Enter Gender: ");
            string gender = Console.ReadLine();

            Console.Write("Enter NIC: ");
            string nic = Console.ReadLine();

            Console.WriteLine("**********************");
            Console.WriteLine("My Information");
            Console.WriteLine("**********************");
            Console.WriteLine("First Name  :" + fname);
            Console.WriteLine("Last Name:  :" + lname);
            Console.WriteLine("DOB         :" + dob.ToString("yyyy-MM-dd"));
            Console.WriteLine("Address     :" + address);
            Console.WriteLine("Tp No       :" + telephone);
            Console.WriteLine("Gender      :" + gender);
            Console.WriteLine("NIC         :" + nic);
            Console.WriteLine("**********************");



        }
    }
}
