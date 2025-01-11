using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_03_OOP
{
    internal class Employees
    {
        #region Properties
        public int id { get; set; }
        public string? name { get; set; }
        public double salary { get; set; }
        public HireDate hiredate { get; set; }
        public Gender gender { get; set; }
        public SecurityLevel securitylevel { get; set; }
        #endregion

        #region Constructors
        public Employees(int id, string name, double salary, HireDate hiredate,Gender gender, SecurityLevel securitylevel)
        {
            this.id = id;
            this.name = name;
            this.salary = salary;
            this.hiredate= hiredate;
            this.gender = gender;
            this.securitylevel = securitylevel;
        }
        #endregion
        #region Methods

        public override string ToString()
        {
            return $"ID: {id} \nName: {name} \nSalary: {salary:c}\nHire Date: {hiredate} \nGender: {gender} \nSecurity Level: {securitylevel}";
            

        }

        public static  int CompareByHireDate(Employees e1, Employees e2)
        {
            DateTime date1 = new DateTime(e1.hiredate.year, e1.hiredate.month, e1.hiredate.year);
            DateTime date2 = new DateTime(e2.hiredate.year, e2.hiredate.month, e2.hiredate.year);
            return date1.CompareTo(date2);
        }
        #endregion
    }
}