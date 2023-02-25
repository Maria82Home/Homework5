//Homework5.
//Task1. Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.

/*
int[] GetRandomThreeDigitsArray(int size)
{
  int[] array = new int[size];
  for (int i = 0; i < size; i++) array[i] = new Random().Next(100, 1000);
  return array;
}

void ShowArray(int[] array)
{
  for (int i = 0; i < array.Length; i++) Console.Write(array[i] + " ");
  Console.WriteLine();
}

int PositiveNumbers(int[] array)
{
  int count = 0;
  for (int i = 0; i < array.Length; i++)
    if (array[i] % 2 == 0) count++;
  return count;
}

Console.Write("Input array size: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] arr = GetRandomThreeDigitsArray(size);
ShowArray(arr);
Console.WriteLine(PositiveNumbers(arr));
*/

//Task2.Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.

/*
int[] CreateRandomArray(int size, int minValue, int maxValue)
{
  int[] array = new int[size];
  for (int i = 0; i < size; i++) array[i] = new Random().Next(minValue, maxValue + 1);
  return array;
}

void ShowArray(int[] array)
{
  for (int i = 0; i < array.Length; i++) Console.Write(array[i] + " ");
  Console.WriteLine();
}

int SumOfElements(int[] array)
{
  int sum = 0;
  for (int i = 1; i < array.Length; i += 2) sum += array[i];
  return sum;
};

Console.Write("Input quantity of elements:");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min posible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max posible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] newArray = CreateRandomArray(size, min, max);
ShowArray(newArray);
Console.WriteLine(SumOfElements(newArray));
*/

//Task3.Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.

double[] GetArray(int size)
{
  double[] array = new double[size];
  for (int i = 0; i < size; i++)
  {
    Console.Write("Input element of array: ");
    array[i] = Convert.ToDouble(Console.ReadLine());
  }
  return array;
}

void ShowArray(double[] array)
{
  for (int i = 0; i < array.Length; i++) Console.Write(array[i] + " ");
  Console.WriteLine();
}

double FindMin(double[] array)
{
  double min = array[0];
  for (int i = 1; i < array.Length; i++)
    if (array[i] < min) min = array[i];
  return min;
}

double FindMax(double[] array)
{
  double max = array[0];
  for (int i = 1; i < array.Length; i++)
    if (array[i] > max) max = array[i];
  return max;
}

Console.Write("Input size of array: ");
int size = Convert.ToInt32(Console.ReadLine());
double[] array = GetArray(size);
ShowArray(array);
Console.WriteLine(FindMax(array)-FindMin(array));