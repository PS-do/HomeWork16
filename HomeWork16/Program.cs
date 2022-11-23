using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.IO;
using System.Text.Encodings.Web;
using System.Text.Unicode;

namespace HomeWork16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.    Необходимо разработать программу для записи информации о товаре в текстовый файл в формате json.
            //Разработать класс для моделирования объекта «Товар».
            //Предусмотреть члены класса
            //«Код товара» (целое число),
            //«Название товара» (строка),
            //«Цена товара» (вещественное число).
            //Создать массив из 5-ти товаров, значения должны вводиться пользователем с клавиатуры.
            //Сериализовать массив в json-строку, сохранить ее программно в файл «Products.json»

            const int n = 5;
            Employee[] employees = new Employee[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Код товара");
                int код_товара;
                try
                {
                    код_товара = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception)
                {
                    код_товара = 0;
                    // throw;
                }

                Console.WriteLine("Название товара");
                string название_товара = Console.ReadLine();

                Console.WriteLine("Цена товара");
                int цена_товара;
                try
                {
                    цена_товара = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception)
                {
                    цена_товара = 0;
                    // throw;
                }

                employees[i] = new Employee() { Код_товара = код_товара, Название_товара = название_товара, Цена_товара = цена_товара };
            }

            JsonSerializerOptions options = new JsonSerializerOptions()
            {
                Encoder = JavaScriptEncoder.Create(UnicodeRanges.BasicLatin, UnicodeRanges.Cyrillic),
                WriteIndented = true
            };

            string jsonString = JsonSerializer.Serialize(employees, options);
            using (StreamWriter sw = new StreamWriter("../../../Employees.json"))
            {
                sw.WriteLine(jsonString);
            }
        }
    }
}
