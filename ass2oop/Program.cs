using System;
using System.Drawing;

namespace ass2oop
{
    struct person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public person(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }
    struct point
    {
        public int X { get; set; }
        public int Y { get; set; }

        public point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public double DistanceTo(point other)
        {
            return Math.Sqrt(Math.Pow((double)other.X - (double)X, 2.0) + Math.Pow((double)other.Y - (double)Y, 2.0));
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1
            person[] people = new person[3];
            people[0] = new person("youssef", 25);
            people[1] = new person("sameh", 30);
            people[2] = new person("fathy", 22);
            foreach (var person in people)
            {
                Console.WriteLine($"Name: {person.Name}, Age: {person.Age}");
            }
            #endregion
            #region 2
            int x1 = 3;
            int y1 = 3;
            point p1 = new point(x1, y1);
            int x2 = 7;
            int y2 = 7;
            point p2 = new point(x2, y2);
            double distance = p1.DistanceTo(p2);
            Console.WriteLine($"The distance between the two points is: {distance:F2}");
            #endregion
            #region 3
            person[] people2 = new person[3];
            for (int i = 0; i < 3; i++)
            {
                string name = Console.ReadLine();
                int age = Convert.ToInt32(Console.ReadLine());
                people[i] = new person(name, age);
            }
            person oldest = people2[0];
            foreach (var person in people2)
            {
                if (person.Age > oldest.Age)
                {
                    oldest = person;
                }
            }
            Console.WriteLine($"The oldest person is {oldest.Name} with age {oldest.Age}.");
            #endregion
        }
    }
}