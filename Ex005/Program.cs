int n;
Console.WriteLine("Введите число:");
n=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Выводим все четные числа");
for(int x=2;x<=n; x=x+2)
    {
        Console.Write(x);
        Console.Write(", ");
    }
Console.ReadKey();
