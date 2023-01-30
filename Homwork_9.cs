// Задача 64: Выполнить с помощью рекурсии.Задайте значение N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от N до 1.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

System.Console.WriteLine("Введите число: ");
int N = int.Parse(Console.ReadLine()!);

System.Console.WriteLine(Numbers(1, N));

string Numbers (int start, int end)
{
    if(start == end) return start.ToString();
    return end + " " + Numbers(1, end-1);
}

// ИЛИ другой вариант

System.Console.WriteLine("Введите число: ");
int N = int.Parse(Console.ReadLine()!);

System.Console.WriteLine(Numbers(N, 1));


----------Methods--------------

string Numbers (int start, int end)
{
    if(start == end) return end.ToString();
    return start + " " + Numbers(start-1,1);
}

// Задача 66: Выполнить с помощью рекурсии.Задайте значения M и N. Напишите программу, 
//которая найдёт сумму натуральных элементов в промежутке от M до N.
//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30

System.Console.WriteLine("Введи начальное число:");
int m = int.Parse(Console.ReadLine()!);
System.Console.WriteLine("Введи конечное число:");
int n = int.Parse(Console.ReadLine()!);
// int sumOfElements = Sum(1, 15);
// System.Console.WriteLine($"{sumOfElements}");
Console.WriteLine($"Сумма элементов от {m} до {n} равна {Sum(m,n)}");

// ---------------Methods------------

int Sum(int start, int end)
{
    int sum = 0;
    if (start > end) return 0;
    return sum += start + Sum(start+1, end);
}

// Задача 68: Выполнить с помощью рекурсии.Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

System.Console.WriteLine("Введи число m:");
int m = int.Parse(Console.ReadLine()!);
System.Console.WriteLine("Введи число n:");
int n = int.Parse(Console.ReadLine()!);

Console.WriteLine($"Функция Аккермана от {m} и {n} равна {Ackermann(m,n)}");

// ---------------Methods----------

int Ackermann (int m, int n)
{
    if(m == 0) return n+1;
    else if(n==0) return Ackermann(m-1,1);
    else return Ackermann(m-1, Ackermann(m,n-1));
}