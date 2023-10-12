using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ab104_12_10_23
{
    internal class Employee
    {
        public string Name { get; set; }
        public bool IsSuccessful { get; set; }


        public int _salary;

        public Employee(string name, bool isSuccessful, int salary)
        {
            Name = name;
            IsSuccessful = isSuccessful;
            Salary = salary;
        }

        public int Salary
        {
            get
            { 
                return _salary;
            }
            set
            {
                if (value >= 0)
                {
                    _salary = value;
                }
                else
                {
                    Console.WriteLine("Maaş menfi ola bilmez.");
                }
            }
        }
    }


}
