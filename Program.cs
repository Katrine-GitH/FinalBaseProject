// //Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам.
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись 
//исключительно массивами.
// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []
void FillArray(string[] Array)
{
    for (int i = 0; i < 5; i++)
    {
        Console.WriteLine("Напишите строку массива");
        string n = Convert.ToString(Console.ReadLine());
        Array[i] = n;
    }
}
string[] FilterArray(string[] Array)
{
    List<string> a = new List<string>();
    //a.
    //return Array;
    for (int i = 0; i < Array.Length; i++)
    {
        //Console.WriteLine($"INDEX {i}=");
        if (Array[i].Length<=3)
        {
            a.Add(Array[i]);
        }
    }
    string[] Result = new string[a.Count]; 
    a.CopyTo(Result);
    return Result;
}
void PrintArray(string[] Array)
{
    for (int i = 0; i < Array.Length; i++)
    {
        Console.WriteLine($"INDEX {i}={Array[i]}");
    }
}

string[] SourceArray = new string[5];
//string[] Array2 = new string[5];

FillArray(SourceArray);
string[] ResultArray = FilterArray(SourceArray);
PrintArray(ResultArray);
