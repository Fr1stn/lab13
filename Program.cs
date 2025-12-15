Console.WriteLine("Введите первое число:");
double a = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите второе число:");
double b = Convert.ToDouble(Console.ReadLine());
try
{
    double s = a / b;
    Console.WriteLine(s);
}
catch(DivideByZeroException)
{
    if (b == 0)
    {
        Console.WriteLine("Ошибка при делении на 0.");
    }
    else if (a == 0 && b == 0)
    {
        Console.WriteLine("Ошибка!");
    }
}