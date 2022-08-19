int x;
Console.WriteLine("Введите первое число:");
x=Convert.ToInt32(Console.ReadLine());
int y;
Console.WriteLine("Введите второе число:");
y=Convert.ToInt32(Console.ReadLine());
int z;
Console.WriteLine("Введите третье число:");
z=Convert.ToInt32(Console.ReadLine());
if (x>y)
    {
        if (x>z)
        {
            Console.Write("Максимальное число ");
            Console.WriteLine(x);
        }
        else 
        {
            Console.Write("Максимальное число ");
            Console.WriteLine(z);
        }
    }
else
   {
        if (y>z)
        {
            Console.Write("Максимальное число ");
            Console.WriteLine(y);
        }
        else 
        {
            Console.Write("Максимальное число ");
            Console.WriteLine(z);
        }
     } 
