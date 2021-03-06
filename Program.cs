/*
Seminar5
Задача №1
Условие: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. 
Найдите сумму отрицательных и положительных элементов массива.

int[] array = new int[12];
int pos = 0; int neg = 0;
for (int i = 0; i < 12; i++)
{
    array[i] = new Random().Next(-9, 10);
    if (array[i] > 0) pos = array[i] + pos;   // Внимание на первую задачу!
    else neg = array[i] + neg;
    Console.Write(array[i] + ", ");
}
Console.WriteLine($"Сумма положительных элементов равна {pos}, сумма отрицательных элементов равна {neg}");


Задача №2
Условие: Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот..

int[] array = new int[12];
for (int i = 0; i < 12; i++)
{
    array[i] = new Random().Next(-9, 10);
    Console.Write(array[i] + ", ");
}
Console.WriteLine();
for (int i = 0; i < 12; i++)
{
    Console.Write((array[i] * (-1)) + "");
}

Задача №3
 Условие: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.

int[] array = new int[15];
int tumbler = 0;
for (int i = 0; i < 15; i++)
{
    array[i] = new Random().Next(1, 20);
    Console.Write(array[i] + ", ");
}
Console.WriteLine("Введите число  ");
int num = Convert.ToInt32(Console.ReadLine());
for (int i = 0; i < 15; i++)
{
    if (array[i] == num)
    {
        Console.WriteLine("YES");
        tumbler = 1;
        break;
    }
}
if (tumbler == 0) Console.WriteLine("NO");


Задача №4
Условие: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99].

int[] array = new int[123];
int count = 0;
for (int i = 0; i < 123; i++)
{
    array[i] = new Random().Next(1, 1000);
    if (array[i] < 100 && array[i] > 9) count++;
}
Console.Write(count);


Задача №5
Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
Результат запишите в новом массиве.

Console.WriteLine("Введите размер массива ");
int num = Convert.ToInt32(Console.ReadLine());
int[] array = new int[num];

int dlina = 1;
if (num % 2 == 0) dlina = 0;
int[] array2 = new int[(num / 2) + dlina];

for (int i = 0; i < num; i++)
{
    array[i] = i + 1;
    Console.Write(array[i] + " ");
}
Console.WriteLine();
for (int i = 0; i < ((num / 2) + dlina); i++)
{
    array2[i] = array[i] * (array[num - i - 1]);
    if (i == num - i - 1) array2[i] = array[i];
    Console.Write(array2[i] + " ");
}

*/

//Домашняя работа C# №5
// Задача 1: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2


// int[] array = new int[20];
// int ChetSum = 0;
// for (int i = 0; i < array.Length; i++) 
// {
//     array[i] = new Random().Next(100, 999);
//     Console.Write(array[i] + " ");
//     if (array[i] % 2 == 0) ChetSum++;
// }
// Console.WriteLine();
// Console.WriteLine($"Количество чётных чисел в массиве равно {ChetSum}");



// Задача 2: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


// int[] array = new int[10];
// int NechetSum = 0;
// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = new Random().Next(10, 99);
//     Console.Write(array[i] + " ");
//     if (i % 2 == 1) NechetSum = NechetSum + array[i];

// }
// Console.WriteLine();
// Console.WriteLine($"Сумма нечётных элементов в массиве равно {NechetSum}");




// Задача 3: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76


// int[] array = new int[10];
// int MaxValue = 0, MinValue = 0, Diff = 0;
// for (int i = 0; i < array.Length; i++) 
// {
//     array[i] = new Random().Next(10, 99);
//     Console.Write(array[i] + " ");
//     if (array[i] > array[MaxValue])
//         MaxValue = i;
//     if (array[i] < array[MinValue])
//         MinValue = i;
//     Diff = array[MaxValue] - array[MinValue];
// }
// Console.WriteLine();
// Console.WriteLine($" Разница между максимальным элементом {MaxValue} и минимальным элементом {MinValue} массиве равна {Diff}");