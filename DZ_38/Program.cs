// Задача 38: 1.
// Задайте массив вещественных чисел. 2.Найдите разницу между максимальным и минимальным элементами массива.
// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

double[] Numbers = new double[5];
  for (int i = 0; i < Numbers.Length; i++ )
  {
    Numbers[i] = new Random().Next(1, 10);
    Console.Write(Numbers[i] + " ");
  }

double maxNumber = Numbers[0];
double minNumber = Numbers[0];

  for (int i = 1; i < Numbers.Length; i++)
  {
    if (maxNumber < Numbers[i])
    {
      maxNumber = Numbers[i];
    }
        if (minNumber > Numbers[i])
    {
      minNumber = Numbers[i];
    }
  }

  double diff = maxNumber - minNumber;
  Console.WriteLine(" ");
  Console.WriteLine($"Разница между между максимальным {maxNumber} и минимальным {minNumber} элементом массива: {diff}");
