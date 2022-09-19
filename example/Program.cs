// Написать программу, которая из массива строк формирует массив из строк, длина которых меньше либо равна
// 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исклбчительно массивами.

// ["hello", "2", "world", ":-)"] -> ["2", ":-)"]
// ["1234", "1567", "-2", "computer science"] -> ["-2"]
// ["Russia", "Denmark", "-2", "Kazan"] -> []

void PrintArray(string[] array)
{
    Console.Write("[");
    for (var i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);

        if (i != array.Length - 1)
            Console.Write(", ");
    }
    Console.Write("]");
    Console.WriteLine();
}
void ThreeSymbolArray(string[] array)
{
    string[] stringarray = new string[array.Length];
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            stringarray[i] = array[i];
            Console.Write($"{stringarray[i]}");
            if (i != array.Length - 1)
                Console.Write(", ");
        }
    }
    Console.Write("]");
    Console.WriteLine();
}

string[] array = { "hello", "2", "world", ":-)", "1234", "1567", "-2", "computer science", "Russia", "Denmark", "Kazan", "GG", "11", "(_)" };
PrintArray(array);
Console.WriteLine();
ThreeSymbolArray(array);
