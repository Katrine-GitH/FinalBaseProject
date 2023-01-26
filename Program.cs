// //Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам.
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись 
//исключительно массивами.
// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []
string [] Array = new string[5];
string[] Array2 = new string[3];
void FillArray(string[] Array, string[] Array2)
{
    for (int i = 0; i < 5; i++)
    {
        Console.WriteLine("Напишите строку массива");
        string n = Convert.ToString(Console.ReadLine());
        Array[i] = n;
    }
    for (int i = 0; i < 3; i++)
    {
        Array2[i] = Array[i];
    }
}
void PrintArray(string[] Array2)
{
    for (int i = 0; i < Array2.Length; i++)
    {
        Console.WriteLine($"INDEX {i}={Array[i]}");
    }
}
FillArray(Array, Array2);
PrintArray(Array2);
