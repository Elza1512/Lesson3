//Задача 36: 
// 1. Задайте одномерный массив, заполненный случайными числами.
// 2. Найдите сумму элементов, стоящих на нечётных позициях (индексах).
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.Write($"Введите одномерный массив: ");
int number = Convert.ToInt32(Console.ReadLine()); 

int RandomNumbers(int number, int min, int max)
  {
  int[] randomNumbers = new int[number];
  int sumEl = 0;

    for (int i = 0; i < randomNumbers.Length; i++ ) 
    {
      randomNumbers[i] = new Random().Next(min, max);

      Console.Write(randomNumbers[i] + " ");

      if (i % 2 != 1)
      {
        sumEl = sumEl + randomNumbers[i];
      }
    }
  return sumEl;
  }
  
int randomNumbers =  RandomNumbers(number, 1, 10);
Console.WriteLine(" ");

Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях: {randomNumbers}");