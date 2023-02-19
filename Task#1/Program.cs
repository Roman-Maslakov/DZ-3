// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

// ||Простое решение без массива|| (если решить нужно было не обязательно с помощью массива)

// Console.WriteLine("Введите пятизначное число");
// int G = Convert.ToInt32(Console.ReadLine());

// if (G / 10000 > 9 || G / 10000 == 0) Console.WriteLine("Это же не пятизначное число)");
// else if (G / 10000 == G % 10 && (G / 1000) % 10 == (G / 10) % 10)
//     Console.WriteLine("Да, введенное число является палиндромом");
// else Console.WriteLine("Нет, число палиндромом не является");

int[] array = new int[5];

Console.WriteLine("Введите пятизначное число. Пропишите каждый разряд построчно");

for (int i = 0; i < array.Length; i++)
{
    while (true)
    {
        array[i] = Convert.ToInt32(Console.ReadLine());
        if (array[i] >= 0 && array[i] <= 9) break;
        else Console.WriteLine("Вам необходимо ввести цифру, находящуюся в разряде числа, то есть цифру от 0 до 9");
    }
}

if (array[0] == 0)
{
    Console.WriteLine("Введите цифру для последнего разряда, число не может начинаться с 0-я)");
    while (true)
    {
        array[0] = Convert.ToInt32(Console.ReadLine());
        if (array[0] >= 1 && array[0] <= 9) break;
        else Console.WriteLine("Вам необходимо ввести цифру, находящуюся в последнем разряде числа, то есть цифру от 1 до 9");
    }
}

if (array[0] == array[4] && array[1] == array[3])
    Console.WriteLine("Да, введенное число является палиндромом");
else Console.WriteLine("Нет, число палиндромом не является");
