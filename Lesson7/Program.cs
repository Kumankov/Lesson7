// Задача 47. Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9
double [,] FillArray(int str, int col)
{
double[,] Massive = new double[str,col];
for (int i=0; i< str; i++)
    {
        for (int j=0; j< col; j++)
        {
            Massive[i,j] =  new Random().Next(-100,100)*new Random().NextDouble();   
            Console.Write($"{Massive[i,j]}    ");              
        }
        Console.WriteLine();
    }
return Massive;
}
Console.WriteLine("Задача 47");
Console.WriteLine("Введите m для задачи 47");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите n для задачи 47");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("Массив, заполенный случайными числами:");
double[,] massive2=FillArray (m,n);

// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет
Console.WriteLine("Задача 50");
Console.WriteLine("Введите номер строки элемента для задачи 50");
int k = int.Parse(Console.ReadLine());
Console.WriteLine("Введите номер столбца элемента для задачи 50");
int l = int.Parse(Console.ReadLine());
if ((k>=m)||(l>=n)) Console.WriteLine("Такого элемента в массиве нет");
else Console.WriteLine($"Выбранный элемент массива: {massive2[k,l]}");

// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
void AverageArrayCollums(int[,] MassiveInt)
{
int str = MassiveInt.GetLength(0);
int col = MassiveInt.GetLength(1);
double[] AverageArray = new double [col]; 
Console.Write("Среднее арифметическое каждого столбца заданного массива: ");
for (int j=0; j< col; j++)
    {
        double sum = 0;
            for (int i=0; i< str; i++)
            sum = sum + MassiveInt[i,j];       
        AverageArray[j]= sum/str;
        if (j==col-1) Console.WriteLine($"{Math.Round(AverageArray[j],3)}.");
        else Console.Write($"{Math.Round(AverageArray[j],3)}, ");
    } 
}
int[,] array = {{1,4,7,2}, {5,9,2,3},{8,4,2,4}};
Console.WriteLine("Задача 50");
AverageArrayCollums(array);
