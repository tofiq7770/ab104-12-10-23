using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Ab104_12_10_23
{
    internal class Assistant : Employee
    {
        public Assistant(string name, bool isSuccessful, int salary) : base(name, isSuccessful, salary) { }

        public void GetFeedback(Employee employee)
        {
            if (employee.IsSuccessful)
            {
                Console.WriteLine("Promosyon olacaq.");
            }
            else
            {
                Console.WriteLine("Promosyon olmaycaq.");
            }
        }
    }
}
