using System;
using System.Xml.Linq;

/// <summary>
/// Класс демонстрирующий работу с массивами символов и строками.
/// </summary>
class ArrayExample
{
    /// <summary>
    /// Точка входа в программу. Собирает имя из массива букв
    /// и отправляет приветственное сообщение на каждом шаге.
    /// </summary>
    static void Main()
    {
        char[] letters = { 'f', 'r', 'e', 'd', ' ', 's', 'm', 'i', 't', 'h' };
        string name = "";
        int[] a = new int[10];

        for (int i = 0; i < letters.Length; i++)
        {
            name += letters[i];
            a[i] = i + 1;
            SendMessage(name, a[i]);
        }

        Console.ReadKey();
    }

    /// <summary>
    /// Выводит приветственное сообщение с текущим именем и счётчиком.
    /// </summary>
    /// <param name="name">Текущее накопленное имя из букв.</param>
    /// <param name="msg">Текущее значение счётчика.</param>
    static void SendMessage(string name, int msg)
    {
        Console.WriteLine("Hello, " + name + "! Count to " + msg);
    }
}