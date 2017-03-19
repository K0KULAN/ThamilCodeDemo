using Bigword.BLL;
using Bigword.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Greeter obj = new Greeter();

            Console.WriteLine("Please enter guest name ?: ");
            string name = Console.ReadLine();
            Console.WriteLine(obj.GetGreetingWords(name));

            Console.WriteLine("Press any key to get record from db");
            Console.ReadKey();

            GetRecordFromDB dbobj = new GetRecordFromDB();
            Console.WriteLine(dbobj.GetEmployeeRecord(1));

            Console.WriteLine("Press any key to print name from config file");
            Console.ReadKey();
            Console.WriteLine("Company name is : " + System.Configuration.ConfigurationManager.AppSettings["CompanyName"]);



            Console.WriteLine("Press any key to continue");

            Console.ReadKey();
        }
    }
}
