int n;
int x;
Console.WriteLine("Введите число:");
n=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Последняя цифра числа");
x=n%10;
Console.Write(x);
Console.ReadKey();