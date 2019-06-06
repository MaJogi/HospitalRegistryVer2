using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Open.Core
{
    public static class Departments
    {
        public static string[] Department = new string[] { "Kirurgia", "Department2", "Department3" };
        public static string Surgery = Department.First();
        public static string Department3 = Department.Last();
    }
    
}
