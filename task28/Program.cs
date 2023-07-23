// Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

int GetSum(int limit)
{
    int sum = 1;
    for (int i = 2; i <= limit; i++)
    {
        sum = sum * i;
    }
    return sum;
}


int GetInfo(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int num = GetInfo("Введите число: ");


Console.WriteLine($"Произведение чисел от 1 до {num} равна {GetSum(num)}");