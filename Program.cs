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
// которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

// int[] vassive = GetArray(10, 99, 1000);
// int chert = 0;
// foreach (int el in vassive)
// {
//     chert += el %2 == 0 ? 1 : 0;
// }
// Console.WriteLine($" Получился массив [{String.Join(",",vassive)}]");
// Console.WriteLine($" Кол-во чётных чисел {chert}");
// /*------------------------------------- Method ---------------------------------*/

// int[] GetArray(int size, int min, int max)
// {
//     int[] massive = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         massive[i] = new Random().Next(min, max);

//     }
//     return massive;

// }


// Задача 2: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, 
//стоящих на нечётных индексах.

// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


//int[] SumElement(int size, int minValue, int maxValue);
// int [] SumNoChertEl = FindSumIndex(6, 1, 10);
// int sizeSumNoChertEl = SumNoChertEl.Length;
// int indexChertSum = 0;
// for(int i = 1; i < sizeSumNoChertEl; i = i+2 ){

//      indexChertSum +=SumNoChertEl[i];
// }


// Console.WriteLine($" Получился массив [{String.Join(",",SumNoChertEl)}]");
// Console.WriteLine($"Сумма чисел стоящих на нечётных индексах равна {indexChertSum}");


// /*-------------------------- Method -------------------------------*/

// int[] FindSumIndex(int quantity, int min, int max)
// {
//     int [] arrayEl = new int[quantity];
//     for (int i = 0; i < quantity; i++)
//     {
//         arrayEl[i] = new Random().Next(min, max);

//     }
// return arrayEl;
// }

// Задача 3: Задайте массив вещественных чисел. Найдите разницу между 
// максимальным и минимальным элементов массива.
// [3, 7.4, 22.3, 2, 78] -> 76



Console.Write("Укажите размер массива: ");
int n = Math.Abs(int.Parse(Console.ReadLine()!));
double[] s = diffBetween(n);

 double min = s[0];
 double max = s[0];


if (n > 20) {
    Console.WriteLine("Имейте совесть!, принимаются значения не более 20 ");
}

else{
Console.WriteLine($"[{String.Join("; ", s)}]");

foreach (double el in s)
{
    min = el < min? min = el : min;
    max = el > max? max = el : max;
}


double difference = Math.Round(max - min, 2);
Console.WriteLine($"Разница между Мах и Мин числом в указанном диапазоне равна:{difference}");


}
/*-------------------------- Method -------------------------------*/
double[] diffBetween(int size)
{

    double[] array = new double[size];
    Random rand = new Random();
    for (int i = 0; i < size; i++)
        array[i] = Math.Round((rand.NextDouble()) * 100, 2);
    return array;
}

