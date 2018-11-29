using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary.Model;

namespace ClassLibrary
{
    public class Class1
    {
        public static string ok = "ok";
        public static string test()
        {
            return "Completed";
        }

        public static Employeemodel getEmp()
        {
            Employeemodel emp = new Employeemodel();
            emp.ID = 1;
            emp.EMPCODE = "001";
            return emp;
        }
    }
}
