using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad_vježba_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("//2. zadatak");
            IceCream vanila = new IceCream("Vanila", 22.2, 43, "Vanila", "yellow");
            Cake cokoladna = new Cake("Čokoladna torta", 22.2, 43, true, "čokoladna");

            Console.WriteLine(vanila.ToString());
            Console.WriteLine(vanila.GetDessertType());

            Console.WriteLine(cokoladna.ToString());
            Console.WriteLine(cokoladna.GetDessertType());

            Console.ReadKey();

            Console.WriteLine("//5. zadatak prvi dio");

            Student student1 = new Student("Pero", "Perić", 20, "id888", (short)2);
            Student student2 = new Student("Ana", "Anić", 20, "id555", (short)1);
            Teacher teacher1 = new Teacher("Anka", "Anković", 35, "ankaankovic@gmail.com", "Baze podataka", 1020);
            Teacher teacher2 = new Teacher("Tomas", "Tomasović", 40, "tomastomasovic@gmail.com", "Algoritmi i programiranje", 1550);
            Teacher teacher3 = new Teacher("Klara", "Klarić", 37, "klaraklaric@gmail.com", "Web dizajn", 2020);

            List<Person> list = new List<Person>();
            list.Add(student1);
            list.Add(student2);
            list.Add(teacher1);
            list.Add(teacher2);
            list.Add(teacher3);

            double salaries = 0;
            foreach (Person person in list)
            {
                Console.WriteLine("Ime: " + person.Name + ", Prezime: " + person.Surname);
                if (person.GetType() == typeof(Teacher))
                {
                    Teacher teacher = person as Teacher;
                    salaries += teacher.Salary;
                }
            }
            Console.WriteLine("Prosjećna plaća: " + salaries/3);

            Console.ReadKey();

            Console.WriteLine("//5. zadatak drugi dio");

            /*Person p1 = new Person("Ivo","Ivic", 20);
            Person p2 = new Person("Ivo","Ivic", 20);
            Person p3 = new Student("Ivo","Ivic", 20, "0036312123", (short)3);
            Person p4 = new Student("Marko","Marić", 25, "0036312123", (short)5);*/

            Person p1 = new Person("Ivo", "Ivic", 20);
            Person p2 = new Person("Ivo", "Ivic", 20);
            Person p3 = new Student("Ivo", "Ivic", 20, "0036312123", (short)3);
            Person p4 = new Student("Marko", "Marić", 25, "0036312123", (short)5);

            Console.WriteLine(p1.Equals(p2));
            Console.WriteLine(p1.Equals(p3));
            Console.WriteLine(p3.Equals(p4));

            Console.ReadKey();
        }
    }
}
