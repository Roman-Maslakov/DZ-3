// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.WriteLine("Введите величину таблицы");
int N = Convert.ToInt32(Console.ReadLine());
double[] arrayN = new double[N];

for (int i = 0; i < N - 1; i++)
{
    arrayN[i] = Math.Pow(i + 1, 3);
    Console.Write(arrayN[i] + ", ");
}
Console.Write(Math.Pow(N, 3));