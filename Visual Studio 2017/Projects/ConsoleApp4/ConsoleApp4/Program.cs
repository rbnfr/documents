using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            var persons = new List<Person>()
            {
                new Person(){Id=1,Name="Pedro", Surname="Hurtado"},
                new Person(){Id=2,Surname="Lopez"}
            };
            var generic = persons.Select(c => new Generic { obj = c, Type = c.GetType() });
            // Validate persons

            var generics = ToGeneric(persons); // Metodo que convierte personas en objetos genericos. Luego se lo pasamos como objeto y nos devuelve el tipo.

            // Insert into table (...) values(1, 2)
            foreach (var generic in generics)
            {
                var table = generic.Type.Name;
                var sql = "INSERT INTO" + table.ToUpper();
                //var type = generic.GetType(); Integrado abajo
                var properties = generic.type.GetProperties(); // con System.Reflection.BindingFlags.NonPublic se pueden obtener los atributos publicos y privados.
                foreach (var property in properties)
                {
                    var value = property.GetValue(generic.Obj);
                    // Si queremos cambiar el valor a una persona
                    //property.SetValue --> falta
                    var attributes = property.GetCustom.Attributes();
                }
            }
        }
    }
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public void Save() { }
    }

    public interface IValid
    {
        bool IsValid(string value);
    }
    public class StringDataBase : Attribute
    {
        public StringDataBaseAttribute()
        {
            this.Required = true;
        }
        public int Length { get; set; }
        public bool; 
    }
    public static List<Generic> ToGeneric(IEnumerable<object> list)
    {
        return list.Select(c => new Generic { Obj = c, Type = c.GetType()} ).ToList(); // esta instrucción equivale a las 3 instrucciones siguientes 
        /*var generics = new List<Generic>();
        foreach (var obj in list)
        {
            generics.Add(new Generic() { Obj = obj, Type = obj.GetType() });
        }*/
    }
    public class Generic
    {
        public Object Obj { get; set; }
        public Type Type { get; set; }
    }
}
