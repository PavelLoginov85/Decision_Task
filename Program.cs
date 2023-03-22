// // сделать массив из 12 эл-ов в диапазоне (-9 , 9) и найти сумму + и -
// int [] massive = MakeArray(12);
// Console.WriteLine($"[{String.Join(",", massive)}]");
// int plusSum = 0;
// int minsSum = 0;
// foreach (int el in massive){
//     plusSum += el > 0 ? el : 0;
//     minsSum += el < 0? el : 0;
// }

// Console.WriteLine($"Сумма всех + {plusSum},сумма всех отрицательных чисел {minsSum}");

// /*-------------------------------- Method---------------------------------*/

// int [] MakeArray(int quantity)
// {
//     int[] array = new int[quantity];
//     for (int i = 0; i < quantity; i++)
//     {
//         array [i] = new Random().Next(-9, 10);

//     }
//     return array;
// }





// Задача 1: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, 
//которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

int[] vassive = GetArray(15, 99, 1000);
int chert = 0;
foreach (int el in vassive)
{
    chert += el %2 > 0 ? 0 : 1;
}
Console.WriteLine($" Получился массив [{String.Join(",",vassive)}]");
Console.WriteLine($" Кол-во чётных чисел {chert}");
/*------------------------------------- Method ---------------------------------*/

int[] GetArray(int size, int min, int max)
{
    int[] massive = new int[size];
    for (int i = 0; i < size; i++)
    {
        massive[i] = new Random().Next(min, max);

    }
    return massive;



}