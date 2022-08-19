int n;
Console.WriteLine("Введите число:");
n=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Выводим все четные числа");

for(int x=n*(-1);x<=n; x++)
    {
        Console.Write(x);
        if(x!=n) Console.Write(", ");
        else Console.WriteLine(".");
    }