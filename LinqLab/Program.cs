using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqLab
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 10, 2330, 112233, 10, 949, 3764, 2942 };
            List<Student> students = new List<Student>();
            students.Add(new Student("Jimmy", 13));
            students.Add(new Student("Hannah Banana", 21));
            students.Add(new Student("Justin", 30));
            students.Add(new Student("Sarah", 53));
            students.Add(new Student("Hannibal", 15));
            students.Add(new Student("Phillip", 16));
            students.Add(new Student("Maria", 63));
            students.Add(new Student("Abe", 33));
            students.Add(new Student("Curtis", 10));

            //For nums: 
            //1 Find the Minimum value
            int minNum = nums.Min();
            Console.WriteLine($"Min value: {minNum}");
            //2 Find the Maximum value
            int maxNum = nums.Max();
            Console.WriteLine($"Max value: {maxNum}");
            //3 Find the Maximum value less than 10000
            int lessMax = nums.Where(x => x < 10000).Max();
            Console.WriteLine($"Maximum value less than 10000: {lessMax}");
            //4 Find all the values between 10 and 100
            List<int> btwn = nums.Where(x => x > 10 && x < 100).ToList();
            Console.WriteLine("Values between 10 and 100:");
            foreach (int num in btwn)
            {
                Console.WriteLine(num);
            }
            //5 Find all the Values between 100000 and 999999 inclusive
            List<int> btwnIncl = nums.Where(x => x >= 1000000 && x <= 999999).ToList();
            //6 Count all the even numbers
            int evenCount = nums.Count(x => x % 2 == 0);
            Console.WriteLine($"count of all even numbers: {evenCount}");

            //For students: 
            //1Find all students age of 21 and over(aka US drinking age)
            var drinkStudent = from s in students
                                where s.Age >= 21
                                select s;
            List<Student> drinkStudents = drinkStudent.ToList();
            //2Find the oldest student
            var oldStudent = students.OrderBy(x => x.Age).LastOrDefault();
            Console.WriteLine(oldStudent.Name);
            //3Find the youngest student
            var youngStudent = students.OrderBy(x => x.Age).FirstOrDefault();
            Console.WriteLine(youngStudent.Name);
            //4Find the oldest student under the age of 25
            var oldUnder = students.Where(x=> x.Age < 25).OrderBy(x => x.Age).LastOrDefault();
            Console.WriteLine(oldUnder.Name);
            //5Find all students over 21 and with even ages
            var overEven = students.Where(x => x.Age > 21 && x.Age % 2 == 0);
            List<Student> overEvens = overEven.ToList();
            foreach (Student o in overEvens)
            {
                Console.WriteLine(o.Name);
            }
            //6Find all teenage students(13 to 19 inclusive)
            var teen = students.Where(x => x.Age >= 13 && x.Age <= 19);
            List<Student> teens = teen.ToList();
            foreach (Student t in teens)
            {
                Console.WriteLine(t.Name);
            }
            //7Find all students whose name starts with a vowel
            var voweler = students.Where(x => x.Name.StartsWith("A") || x.Name.StartsWith("E") || x.Name.StartsWith("I") || x.Name.StartsWith("O") || x.Name.StartsWith("U"));
            List<Student> vowelies = voweler.ToList();
            foreach (Student v in vowelies)
            {
                Console.WriteLine(v.Name);
            }
        }
    }
}
