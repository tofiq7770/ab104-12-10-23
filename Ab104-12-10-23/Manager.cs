using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ab104_12_10_23
{
    internal class Manager : Employee
    {
        public Manager(string name, bool isSuccessful, int salary) : base(name, isSuccessful, salary) { }

        public int GetPromotion(int salary)
        {
            Console.WriteLine("Menecer promosyon aldı.");

           salary = (Salary += 100);
            return salary;
        }
    }
}
