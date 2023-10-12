using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ab104_12_10_23
{
    internal class Student
    {
        private string name;
        private int age;
        private int grade;

        public string Name
        {
            get 
            { 
                return name;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value) || Char.IsLower(value[0]) || value.Any(char.IsDigit))
                {
                    Console.WriteLine("Ad uygun deyil. Ad böyük hərflə başlamalıdır, kənarlarında boşluq olmamalıdır və içində rəqəm olmamalıdır.");
                    Console.Write("Adı yenidən daxil edin: ");
                    Name = Console.ReadLine();
                }
                else
                {
                    name = value;
                }
            }
        }

        public int Grade
        {
            get 
            { 
                return grade; 
            }
            set
            {
                if (value < 0 || 100 > value)
                {
                    Console.WriteLine("Qiymət 0 ilə 100 arasında olmalıdır.");
                    Console.Write("Qiyməti yenidən daxil edin: ");
                    Grade = int.Parse(Console.ReadLine());
                }
                else
                {
                    grade = value;
                }
            }
        }
        public int Age
        {
            get 
            { 
                return age;
            }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Yaş 0 və ya mənfi ola bilməz.");
                    Console.Write("Yaşı yenidən daxil edin: ");
                    Age = int.Parse(Console.ReadLine());
                }
                else
                {
                    age = value;
                }
            }
        }
    }
}
