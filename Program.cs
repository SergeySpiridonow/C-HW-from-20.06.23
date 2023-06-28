/*
Задача 24: Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
7 -> 28
4 -> 10
8 -> 36
*/

// int SumFrom1ToN(int number)
// {
//     int sum = 0;
//     for (int i = 1; i <= number; i++)
//     {
//         sum += i; //sum = sum + i
//     }
//     // sum -= i   sum /= 10 (деление на 10)   sum *= 10 (умножение на 10)
//     return sum;
// }
// int InputNum (string message)
// {
//     Console.Write(message);
//     return int.Parse(Console.ReadLine()!);
// }
// int num = InputNum("Введите целое число: ");
// int sum = SumFrom1ToN(num);
// Console.WriteLine($"Сумма чисел от 1 до N равна {sum}.");







/*
ОТРЫВОК ИЗ 19-Й ЗАДАЧИ С ПАЛИНДРОМОМ
12345 -> 54321
12345 % 10 = 5
12345 / 10 = 1234
1234 % 10 = 4
5 * 10 + 4 = 54
1234 / 10 = 123
123 % 10 = 3
54 * 10 + 3 = 543
123 / 10 = 12
12 % 10 = 2
543 * 10 + 2 = 5432
12 / 10 = 1
1 % 10 = 1
5432 * 10 + 1 = 54321
*/

// int InputNum (string message)
// {
//     Console.Write(message);
//     return int.Parse(Console.ReadLine());
// }
// int ReverseNum(int number)
// {
//     int reversedNum = 0;
//     while (number != 0)
//     {
//         reversedNum = reversedNum * 10 + number % 10;
//         number /= 10;
//     }
//     return reversedNum;
// }

// bool Palindrome (int num, int rev)
// {
//     return num == rev;
// }

// int num = InputNum("Введите число: ");
// int rev = ReverseNum(num);
// bool res = Palindrome(num, rev);
// Console.WriteLine(res);







/*
Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.

456 -> 3
78 -> 2
89126 -> 5
*/

// int InputNum(string message)
// {
//     Console.Write(message);
//     return int.Parse(Console.ReadLine());
// }
// int Number(int num)
// {
//     int res = 0;
//     while (num != 0)
//     {
//         num /= 10;
//         res++;
//     }
//     return res;
// }
// int number = InputNum("Введите число: ");
// int result = Number(number);
// Console.Write($"Количество цифр в числе: " + result);

/*
Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.

4 -> 24
5 -> 120
*/

// int MultFrom1ToN(int number)
// {
//     int sum = 1;
//     for (int i = 1; i <= number; i++)
//     {
//         sum *= i; //sum = sum * i
//     }
//     // sum -= i   sum /= 10 (деление на 10)   sum *= 10 (умножение на 10)
//     return sum;
// }
// int InputNum (string message)
// {
//     Console.Write(message);
//     return int.Parse(Console.ReadLine()!);
// }
// int num = InputNum("Введите целое число: ");
// int sum = MultFrom1ToN(num);
// Console.WriteLine($"Произведение чисел от 1 до N равно {sum}.");

/*
Решение через ФАКТОРИАЛ
*/

// int InputNum(string message)
// {
//     Console.Write(message);
//     return int.Parse(Console.ReadLine()!);
// }

// int Factorial(int num)
// {
//     int count = 1; //Можно начать с 2-х для оптимизации
//     for (int i = 1; i <= num; i++)
//     {
//         count *= i;
//     }
//     return count;
// }
// int num = InputNum("Введите целое число: ");
// int res = Factorial(num);
// Console.WriteLine($"Факториал числа равен: {res}");

/*
напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке
*/

// int InputNum(string message)
// {
//     Console.Write(message);
//     return int.Parse(Console.ReadLine()!);
// }
// int[] ArrayRand(int size)
// {
//     int[] array = new int[size]; //Квадратными скобками обозначаем массив
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(0, 2); //Либо можем указать Next(2), т.к. идём от нуля
//     }
//     return array;
// }
// void PrintArray(int[] array)
// {
//     int size = array.Length;
//     for (int i = 0; i < size; i++)
//     {
//         Console.Write(array[i]+" ");
//     }
// }
// int len = InputNum("Введите длину массива: ");
// int[] arr = ArrayRand(len);
// PrintArray(arr);

/*
Как оставить 2 числа после запятой (но здесь будет математическое округление в большую сторону, если это заложено. Пример 0.12845 = 0.13)
*/

// double num = 0.12345;
// Console.WriteLine($"{num:f3}");