// Задача 41: 
// 1. Пользователь вводит с клавиатуры M чисел.
// 2. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2

// -1, -7, 567, 89, 223-> 3

Console.WriteLine("Введите числа: ");
int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int count = 0;
 
for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] > 0)
    {
        count++;
    }
}
 
Console.WriteLine($"Количество чисел > 0: {count}");
