Soup S = new Soup();
S.soup();
Washing S1 = new Washing();
S1.washing();
Chop S2 = new Chop();
S2.chop();
Ad S3 = new Ad();
S3.ad();
Console.WriteLine("Вы приготовили суп!!! ");
abstract class action
{
    static protected int[] x = { 0, 0, 0 };
    protected string[] a = { "добавили", "порезали", "взята", "вымыли" };
    protected void add(string name, int i, int q)
    {
        Console.WriteLine($"{name} {a[i]} ");
        x[q] += 1;
    }
}
class Soup : action
{
    private int q = 0;
    protected string[] b = { "Морковь", "Свекла", "Капуста" };
    public void soup()
    {
        Console.WriteLine("Выберите действие ");
        Console.WriteLine($"Чтобы взять морковь нажмите 0");
        Console.WriteLine($"Чтобы взять свеклу нажмите 1");
        Console.WriteLine($"Чтобы взять капусту нажмите 2");
        Console.WriteLine($"Чтобы закончить нажмите другую кнопку");
        try
        {
            q = Convert.ToInt32(Console.ReadLine());
            while (q == 0 || q == 1 || q == 2)
            {

                add(b[q], 2, q);

                q = Convert.ToInt32(Console.ReadLine());
            }
        }
        catch (Exception)
        {

        }

        Console.WriteLine("Вы взяли:");
        for (int j = 0; j <= 2; j++)
            Console.WriteLine($"{x[j]} {b[j]}");
    }
}
class Washing : Soup
{
    public int washing()
    {
        Console.WriteLine($"Чтобы вымыть овощи нажмите 1");
        int q = Convert.ToInt32(Console.ReadLine());
        if (q == 1)
        {
            Thread.Sleep(5000);
            Console.WriteLine($"Вы {a[3]}:");
            for (int j = 0; j <= 2; j++)
                Console.WriteLine($"{x[j]} {b[j]}");
            return 0;
        }
        else
            return washing();
    }
}
class Chop : Soup
{
    public int chop()
    {
        Console.WriteLine($"Чтобы порезать овощи нажмите 1");
        int q = Convert.ToInt32(Console.ReadLine());
        if (q == 1)
        {
            Thread.Sleep(5000);
            Console.WriteLine($"Вы {a[1]}:");
            for (int j = 0; j <= 2; j++)
                Console.WriteLine($"{x[j]} {b[j]}");
            return 0;
        }
        else
            return chop();
    }
}
class Ad : Soup
{
    public int ad()
    {
        Console.WriteLine($"Чтобы добавить овощи в кастрюлю нажмите 1");
        int q = Convert.ToInt32(Console.ReadLine());
        if (q == 1)
        {
            Thread.Sleep(5000);
            Console.WriteLine($"Вы {a[0]}:");
            for (int j = 0; j <= 2; j++)
                Console.WriteLine($"{x[j]} {b[j]}");
            return 0;
        }
        else
            return ad();
    }
}


