// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, 
// которая покажет количество чётных чисел в массиве.
/*
int[] arrayZ34 = new int[8];

Console.WriteLine();
Console.WriteLine("__________________");
Console.WriteLine("Задача 34");
FillArray(arrayZ34);
Zadacha34(arrayZ34);

void FillArray(int[] currentArray)
{
    Random rand = new Random();
    for (int i = 0; i < currentArray.Length; i++)
    {
        currentArray[i] = rand.Next(100, 1000);
    }
}

void Zadacha34 (int[] currentArray)
{
    int count = 0;
    for (int i =0; i < currentArray.Length; i++)
    {
        if (currentArray[i] % 2 == 0) count++;
    }
    Console.WriteLine("В массиве четных чисел " + count);
}


// Задача 36. Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

int[] arrayZ36 = new int[8];

Console.WriteLine();
Console.WriteLine("__________________");
Console.WriteLine("Задача 36");
FillArray(arrayZ36);
Zadacha36(arrayZ36);

void FillArray(int[] currentArray)
{
    Random rand = new Random();
    for (int i = 0; i < currentArray.Length; i++)
    {
        currentArray[i] = rand.Next(100, 1000);
    }
}

void Zadacha36(int[] currentArray)
{
    int sum = 0;
    for (int i =0; i < currentArray.Length; i++)
    {
        if (i % 2 == 0) sum += currentArray[i];
    }
    Console.WriteLine("В массиве сума чисел с нечетными индексами равна " + sum);
}
*/

// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

Console.WriteLine();
Console.WriteLine("__________________");
Console.WriteLine("Задача 38");
double[] arrayDouble = new double[5];
Random rand = new Random();
for (int i = 0; i < arrayDouble.Length; i++)
{
     arrayDouble[i] = Convert.ToDouble(rand.Next(1000, 100000))/100;
     Console.WriteLine(arrayDouble[i]);
}