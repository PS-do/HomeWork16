using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using HomeWork16;

namespace Reader_json
{
    internal class Program
    {
        //2.    Необходимо разработать программу для получения информации о товаре из json-файла.
        //Десериализовать файл «Products.json» из задачи 1. Определить название самого дорогого товара.
        static void Main(string[] args)
        {
            string jsonString = String.Empty;
            using (StreamReader sr = new StreamReader("../../../Employees.json"))
            {
                jsonString = sr.ReadToEnd();
            }
            

            Employee[] employees = JsonSerializer.Deserialize<Employee[]>(jsonString);

            Employee самыйДорогойТовар=employees[0];
            foreach(Employee e in employees)
            {
                if (e.Цена_товара > самыйДорогойТовар.Цена_товара) самыйДорогойТовар = e;
            }

            Console.WriteLine($"{самыйДорогойТовар.Код_товара} {самыйДорогойТовар.Название_товара} {самыйДорогойТовар.Цена_товара}");
            Console.ReadKey();
        }
    }
}
