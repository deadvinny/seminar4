// Задача 30: Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

// void FillArray(int[] collection)
// {
//     int length = collection.Length;
//     int index = 0;
//     while (index < length)
//     {
//         collection[index] = new Random().Next(0,2);
//         index++;
//     }
// }

// int[] array = new int[8];
// FillArray(array);
// // PrintArray(array);
// Console.WriteLine (string.Join(", ",array));


void MassGen(int num)
{
    int[] Array = new int[num];
    Console.Write($"Массив из {num} элементов - [");
    for (int i = 0; i < num-1; i++)
        {
            Array[i] = new Random().Next(2);
            Console.Write(Array[i] + ",");
        }
    Array[num-1] = new Random().Next(0,1);
    Console.Write(Array[num-1] + "]");
}

MassGen(8);