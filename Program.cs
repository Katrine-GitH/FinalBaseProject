// //Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам.
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись 
//исключительно массивами.
// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []
Char[] Array = new char[5];
Char[] Array2 = new char[3];
void FillArray(char[] Array, char[] Array2)
{
    for (int i = 0; i < 5; i++)
    {
        Console.WriteLine("Напишите строку массива");
        char n = Convert.ToChar(Console.ReadLine());
        Array[i] = n;
    }
    for (int i = 0; i < 3; i++)
    {
        Array2[i] = Array[i];
    }
}
void PrintArray(char[] Array2)
{
    for (int i = 0; i < Array2.Length; i++)
    {
        Console.WriteLine($"INDEX {i}={Array[i]}");
    }
}
FillArray(Array, Array2);
PrintArray(Array2);
