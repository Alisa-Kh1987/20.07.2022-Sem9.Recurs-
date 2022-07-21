//20.07.2022. Семинар 9 С#. Рекурсия.

//Задача 63. Задайте значение N. Напишите программу, которая выведет все натуральные числа от 1 до N.
//без рекурсии
/*
Console.Write("Input N: ");
int N = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i<=N; i++)
{
    Console.Write($"{i} ");
}

Console.WriteLine();

//с использованием метода void (вывод строкой)

void PrintNumbers(int number)
{
    for (int i = 1; i <= number; i++)
    {
    Console.Write($"{i} ");
    }
    Console.WriteLine();
}
Console.Clear();

Console.Write("Введите натуральное число: ");
int N = Convert.ToInt32(Console.ReadLine());
PrintNumbers(N);

//с использованием метода string

string PrintNumbersStringType(int number)
{
    string result = "";
    for (int i = 1; i <= number; i++)
    {
        result += i.ToString() + " ";
    }
    return result;
}
Console.Clear();
Console.Write("Введите натуральное число: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(PrintNumbersStringType(N));

/*
//с рекурсией
string PrintNumbersRecusiveType(int start, int end)
{
    if (start == end)
    {
        return start.ToString();
    }
    return (start + " " + PrintNumbersRecusiveType(start+1, end));
}
Console.Clear();
Console.Write("Введите натуральное число: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(PrintNumbersRecusiveType(1, N)) ;


//Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

string PrintNumbersRecusiveType(int start, int end)
{
    if (start == end)
    {
        return start.ToString();
    }
    return (start + " " + PrintNumbersRecusiveType(start+1, end));
}
Console.Clear();
Console.Write("Введите натуральное число M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите натуральное число N: ");
int N = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(PrintNumbersRecusiveType(M, N)) ;

//Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
//453 -> 12
//45 -> 9
//наше решение - сначала задача, потом метод. Можно сначала метод, потом задачу
Console.Write("Введите натуральное число N: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"{N}->{SumNumbers(N)}");
//метод
int SumNumbers(int number){
//начинаем описывать метод
    if (number ==0) return 0; //условие окончания нашей рекурсии
    return number%10 + SumNumbers(number/10);
}

//полезная ссылка на хабре https://habr.com/ru/post/275813/
int PowNumbers(int A, int B)
{
    if (B == 0) return 1;
    if (B == 1) return A;
    else return PowNumbers(A, B - 1) * A;
}
Console.Clear();
Console.WriteLine("Input A: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input B: ");
int B = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(PowNumbers(A, B));
*/
//Console.WriteLine($"answer -> {Math.Pow(A,B)}");
