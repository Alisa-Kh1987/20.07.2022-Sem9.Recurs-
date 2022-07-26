/*
//Задача 64: Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
//A = 3; B = 5 -> 243 (3⁵)
//A = 2; B = 3 -> 8

int PowNumbers(int A, int B)
{
    if (B == 0) return 1;
    else return PowNumbers(A, B - 1) * A;
}
Console.Clear();
Console.WriteLine("Input A: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input B: ");
int B = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(PowNumbers(A, B));

//Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30

int SumNumbersRec(int M, int N)
{
    if (M == N)
    {
        return M;
    }
    else
    {
        return M + SumNumbersRec(M + 1, N - 1) + N;
    }
}

Console.Write("Введите натуральное число M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите натуральное число N: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"{SumNumbersRec(M, N)}");


//Задача 68. Напишите программу вычисления функции Аккермана с помощью рекурсии. 
//Даны два неотрицательных числа m и n (m = 2, n = 3 -> A(m,n) = 9).

int Ack(int m, int n)
{
  if (m == 0) return n + 1;
  else if (n == 0) return Ack(m - 1, 1);
  else return Ack(m - 1, Ack(m, n - 1));
}

Console.Clear();

Console.WriteLine("Введите m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите n: ");
int n = Convert.ToInt32(Console.ReadLine());

int functionAkkerman = Ack(m, n);

Console.Write($"Ack(m,n) = {functionAkkerman} ");
*/