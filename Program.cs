double a;
double b;
double total;
char oper;

Console.WriteLine("Введите первое число:");
a = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите оператор");
oper = Convert.ToChar(Console.ReadLine());

Console.WriteLine("Введите второе число:");
b = Convert.ToDouble(Console.ReadLine());

if (oper == '+')
{
    total = a + b;
    Console.WriteLine(a + " + " + b + " = " + total);
}

else if (oper == '-')
{
    total = a - b;
    Console.WriteLine(a + " - " + b + " = " + total);
}

else if (oper == '*')
{
    total = a * b;
    Console.WriteLine(a + " * " + b + " = " + total);
}

else if (oper == '/')
{
    if (b == 0)
    {
        Console.WriteLine("На 0 делить нельзя. Ошибка!");
    }
    else
    {
        total = a / b;
        Console.WriteLine(a + " / " + b + " = " + total);
    }
}
