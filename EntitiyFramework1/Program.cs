using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace EntitiyFramework1
{
    public class Program
    {
        static void Main(string[] args)
        {
            using (UserContext db = new UserContext())
            {
                //создание двух обьектов person
                Person firstPerson = new Person { Name = "Badri", Age = 56 };
                Person secondPerson = new Person { Name = "Vovan", Age = 66 };

                //добавляем их в бд
                db.persons.Add(firstPerson);
                db.persons.Add(secondPerson);
                db.SaveChanges();
                WriteLine("Objects saved successfully.");

                //вывод на консоль
                var persons = db.persons;
                WriteLine("Objects list:");
                foreach(Person m in persons)
                {
                    WriteLine("{0}.{1} - {2}", m.Id, m.Name, m.Age);
                }
            }
            Read();
        }
    }
}
