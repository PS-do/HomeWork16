﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork16
{
    class Employee
    {
        //1.    Необходимо разработать программу для записи информации о товаре в текстовый файл в формате json.
        //Разработать класс для моделирования объекта «Товар».
        //Предусмотреть члены класса
        //«Код товара» (целое число),
        //«Название товара» (строка),
        //«Цена товара» (вещественное число).
        //Создать массив из 5-ти товаров, значения должны вводиться пользователем с клавиатуры.
        //Сериализовать массив в json-строку, сохранить ее программно в файл «Products.json»
        public int Код_товара { get; set; }
        public string Название_товара  { get; set; }
        public double Цена_товара { get; set; } 
    }
}
