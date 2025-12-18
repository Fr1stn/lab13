class Program
{
    static int EXC(int a, int b)
    {
        if (a == 0 && b == 0)
        {
            throw new Exception("Выражение не имеет смысла!");
        }
        if (b == 0)
        {
            throw new Exception("На 0 делить нельзя!");
        }
        return a / b;
    }
    static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("Введите делимое:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите делитель");
            int b = Convert.ToInt32(Console.ReadLine());
            int s = EXC(a, b);
            Console.WriteLine(s);
        }
        catch(Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}


