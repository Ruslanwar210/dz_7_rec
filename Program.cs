// Задача 1:
// Задайте значения M и N. Напишите программу, которая выведет  
//все натуральные числа в промежутке от M до N. Использовать рекурсию, не использовать циклы.


// using System;

// class Program
// {
//     static void Main()
//     {
//         Console.Clear();
//         // Ввод значений M и N пользователем
//         Console.Write("Введите значение M: ");
//         int m = int.Parse(Console.ReadLine());

//         Console.Write("Введите значение N: ");
//         int n = int.Parse(Console.ReadLine());

//         // Создание строки, содержащей натуральные числа от M до N, с помощью рекурсии
//         string result = GenerateNumbersStringInRange(m, n);

//         // Вывод результата
//         Console.WriteLine("Результат: " + result);
//     }

//     // Рекурсивная функция для генерации строки, содержащей натуральные числа от M до N
//     static string GenerateNumbersStringInRange(int m, int n)
//     {
//         if (m <= n)
//         {
//             string currentNumber = m.ToString();
//             string remainingNumbers = GenerateNumbersStringInRange(m + 1, n);

//             if (remainingNumbers != "")
//             {
//                 // Добавляем пробел между текущим числом и остальными числами
//                 currentNumber += " " + remainingNumbers;
//             }

//             return currentNumber;
//         }
//         else
//         {
//             return ""; // Пустая строка, если M превышает N
//         }
//     }
// }


// Задача 2:
// Напишите программу вычисления функции Аккермана с помощью рекурсии.Даны два неотрицательных числа m и n.


// using System;

// class Program
// {
//     static void Main()
//     {
//         Console.Clear();
//         // Ввод значений m и n пользователем
//         Console.Write("Введите значение m: ");
//         int m = int.Parse(Console.ReadLine());

//         Console.Write("Введите значение n: ");
//         int n = int.Parse(Console.ReadLine());

//         // Вычисление и печать результата функции Аккермана
//         int result = AckermannFunction(m, n);
//         Console.WriteLine($"A({m}, {n}) = {result}");
//     }

//     // Рекурсивная функция для вычисления функции Аккермана
//     static int AckermannFunction(int m, int n)
//     {
//         if (m == 0)
//         {
//             return n + 1;
//         }
//         else if (n == 0)
//         {
//             return AckermannFunction(m - 1, 1);
//         }
//         else
//         {
//             return AckermannFunction(m - 1, AckermannFunction(m, n - 1));
//         }
 
//     }
// }


// Задача 3:
// Задайте произвольный массив.Выведете его элементы, начиная с конца.Использовать рекурсию, не использовать циклы.


// using System;

// class Program
// {
//     static void Main()
//     {
//         Console.Clear();
//         // Получаем от пользователя размер массива
//         Console.Write("Введите размер массива: ");
//         int size = int.Parse(Console.ReadLine());

//         // Создаем произвольный массив с числами
//         int[] array = GenerateRandomArray(size);

//         // Выводим элементы массива в строку
//         Console.WriteLine("Элементы массива: " + OutputArrayAsString(array, 0));

//         // Выводим массив с конца
//         Console.WriteLine("Массив с конца:");
//         OutputArrayFromEnd(array, size - 1);
//     }

//     // Рекурсивная функция для генерации произвольного массива
//     static int[] GenerateRandomArray(int size)
//     {
//         if (size <= 0)
//         {
//             return new int[0]; // Возвращаем пустой массив неположительного размера
//         }

//         int[] array = new int[size];

//         // Заполняем массив значениями (для простоты используем последовательные значения)
//         for (int i = 0; i < size; i++)
//         {
//             array[i] = i + 1;
//         }

//         return array;
//     }

//     // Рекурсивная функция для вывода элементов массива в строку
//     static string OutputArrayAsString(int[] array, int index)
//     {
//         if (index < array.Length)
//         {
//             // Рекурсивно вызываем функцию с следующим индексом
//             string remainingNumbers = OutputArrayAsString(array, index + 1);

//             // Комбинируем текущий элемент с оставшимися числами
//             return $"{array[index]} {(remainingNumbers != "" ? remainingNumbers : "")}";
//         }

//         return ""; // Базовый случай: пустая строка, когда индекс превышает длину массива
//     }

//     // Рекурсивная функция для вывода массива с конца
//     static void OutputArrayFromEnd(int[] array, int index)
//     {
//         if (index >= 0)
//         {
//             // Выводим элемент массива по текущему индексу
//             Console.Write(array[index] + " ");

//             // Рекурсивно вызываем функцию с предыдущим индексом
//             OutputArrayFromEnd(array, index - 1);
//         }
//     }
// }
