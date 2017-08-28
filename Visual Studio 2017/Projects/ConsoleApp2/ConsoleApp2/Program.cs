using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            var data = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var pares = data.Where(c => c % 2 == 0);
            var persons = new List<Person>() {
                new Person(){Name="Pedro"},
                new Person(){Name="Juan"},
                new Person(){Name="Fernando"},
            };
            var result = persons.Where(c => c.Name.Contains('o'));
            var Pedro = new Person() { Name = "Pedro" };
            var Juan = new Person() { Name = "Pedro" };
            var hermanos = Pedro + Juan;
            var codePedro = Pedro.GetHashCode();//Obtener el número de hash
            var codeJuan = Juan.GetHashCode();
            var iguales = Pedro.Equals(Juan);//Dice que es diferente, porque no está comparando la propiedad name
        }
    }
}
