//Задача 34: 1.
// 1.Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет 
// 2.количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

int[] numbers = new int[4];

void Array(int[] array, int min, int max)
{
  for (int i = 0; i < array.Length; i++ )
  {
    array[i] = new Random().Next(min, max);
  }
}
void PrintArray(int[] array)
{
    for (int i = 0; i<array.Length; i++ )
    {
    Console.Write(array[i] + " ");
  }
  Console.WriteLine();
}

int PosNegElem(int[] array)
{
    int num = 0;
    for (int i = 0; i<array.Length; i++ )
    {
    if (array[i] % 2 == 1)
    {
      num++;
    }
  }
  return num;
}

Array(numbers, 99, 1000);
PrintArray(numbers);
Console.WriteLine();

int num = PosNegElem(numbers);
Console.WriteLine($"Количество чётных чисел в массиве: {num}");
