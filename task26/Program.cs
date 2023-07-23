// Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

int GetSize(int num)
{
    int size = 0;
    while (num > 0)
    {
        num = num/10;
        size++;
    }
    return size;
}



int GetInfo(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int num = GetInfo("Введите число: ");


Console.WriteLine($"В числе {num} - {GetSize(num)} цифр");


// string GetInfo(string message)
// {
//     Console.Write(message);
//     return Console.ReadLine();
// }

// string num = GetInfo("Введите число: ");
// int lenght = num.Length;
// Console.WriteLine(lenght);
