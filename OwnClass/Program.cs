using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OwnClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Собственный класс:");
            Person p1 = new Person("Марио Лемье", new DateTime(1965, 10, 5), "Монреаль");
            Person p2 = new Person("Яромир Ягр", new DateTime(1972, 2, 15), "Кладно");
            Person[] persons = new Person[] { p1, p2 };

            Type[] type = new Type[persons.Length];

            for (int i = 0; i < type.Length; i++)
            {
                type[i] = typeof(Person);
                Console.WriteLine($"\tType is: {type[i].Name}");

                var propertyInfo = type[i].GetProperties();
                Console.WriteLine($"\tCount of properties - {propertyInfo.Length}");

                foreach (var info in propertyInfo)
                {
                    Console.WriteLine($"\t\t{info.Name}: {info.GetValue(persons[i])}");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\nCписок методов класса Console:");
            Type myType = typeof(Console);

            foreach (var info in myType.GetMethods())
            {
                Console.WriteLine("\t" + info);
            }
        }
    }
}
