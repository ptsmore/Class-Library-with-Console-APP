using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;
using ClassLibrary.Model;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string getdata = Class1.ok;
            string result = Class1.test() + getdata;
            Console.WriteLine(result);
            Employeemodel getEmployee = Class1.getEmp();
            Console.WriteLine(getEmployee.EMPCODE);
        }
    }
}
