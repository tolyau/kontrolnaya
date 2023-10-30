﻿/*
Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам.
Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

Примеры:
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → []
*/

string[] name = { "Ольга", "Андрей", "Яна", "Никита", "Зоя", "Дмитрий", "Лев" }; 
int length = ArrayLength(name);
string[] sName = new string[length];
int ArrayLength(string[] str)
{
    int count = 0;
    for (int i = 0; i < str.Length; i++)
    {
        if (str[i].Length <= 3)
        {
            count++;
        }
    }
    return count;
}
for (int i = 0, j = 0; i < name.Length; )
{
    if (name[i].Length <= 3)
    {
        shortName[j] = name[i];
        j++;
    }
    i++;
}

System.Console.WriteLine(string.Join(", ", sName));