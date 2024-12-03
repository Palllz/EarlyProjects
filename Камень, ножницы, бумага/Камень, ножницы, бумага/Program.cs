int act()
{
    Console.WriteLine("Выберите Действие: ");
    Console.WriteLine("Чтобы запустить калькулятор нажмите 1");
    Console.WriteLine("Чтобы сравнить 2 случайных числа в диапазоне нажмите 2");
    Console.WriteLine("Чтобы сыграть в \"Камень, ножницы, бумага\" нажмите 3");
    Console.WriteLine("Чтобы выйти из программы нажмите 0");
    Char q = Convert.ToChar(Console.ReadLine());
    switch (q)
    {
        case '0':
            return 0; ;
        case '1':
            mass();
            break;
        case '2':
            Console.WriteLine("Введите a и b "); int a = Convert.ToInt32(Console.ReadLine()); int b = Convert.ToInt32(Console.ReadLine());
            ran(a, b);
            break;
        case '3':
            game();
            break;
        default:
            Console.WriteLine("Ошибка");
            break;
    };
    return act();
}
object mass()  //сложение массивов
{
    Console.WriteLine("Сложение массивов");
    Console.Write("Введите размер 2 массивов "); int n = Convert.ToInt32(Console.ReadLine());
    int[] a = new int[n];
    int[] b = new int[n];
    int[] c = new int[n];
    for (int i = 0; i < n; i++)
    {
        Console.Write($"a[{i}]="); a[i] = Convert.ToInt32(Console.ReadLine());
        Console.Write($"b[{i}]="); b[i] = Convert.ToInt32(Console.ReadLine());
    }
    for (int i = 0; i < n; i++)
        c[i] = a[i] + b[i];
    Console.Write("Результат:");
    for (int i = 0; i < n; i++)
        Console.Write($"\t{c[i]}");
    Console.WriteLine();
    return mat();
}
object mat() //сложение матриц
{
    Console.WriteLine("Сложение матриц");
    Console.Write("Введите колличество строк "); int n = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите колличество столбцов "); int m = Convert.ToInt32(Console.ReadLine());
    int[,] a = new int[n, m];
    int[,] b = new int[n, m];
    int[,] c = new int[n, m];
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            Console.Write($"a[{i},{j}]="); a[i, j] = Convert.ToInt32(Console.ReadLine());
            Console.Write($"b[{i},{j}]="); b[i, j] = Convert.ToInt32(Console.ReadLine());
        }
    }
    for (int i = 0; i < n; i++)
        for (int j = 0; j < m; j++)
            c[i, j] = a[i, j] + b[i, j];
    Console.WriteLine("Результат:");
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
            Console.Write($"\t{c[i, j]}");
        Console.WriteLine();
    }
    return dis();
}

object dis()  //дискриминант
{
    Console.WriteLine("Нахождение дискриминанта");
    Console.WriteLine("Введите a,b and c");
    double a = Convert.ToDouble(Console.ReadLine());
    double b = Convert.ToDouble(Console.ReadLine());
    double c = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine($"{a}x^2+{b}x+{c}=0");
    Console.WriteLine($"Результат: {b * b - 4 * a * c}");
    return 0;
}
object ran(dynamic a, dynamic b)
{
    Random c = new Random();
    Random d = new Random();
    return sr(c.Next(a, b), d.Next(a, b));
}
int sr(dynamic a, dynamic b)
{
    Console.WriteLine($"c={a}");
    Console.WriteLine($"d={b}");
    if (a == b)
        Console.WriteLine("Числа равны");
    else if (a > b)
        Console.WriteLine("c больше d");
    else
        Console.WriteLine("c меньше d");
    return 0;
}
object game()
{
    dynamic c, i = 0, j = 0, q = 1;
    string[] a = { "Камень", "Ножницы", "Бумага" };
    string[] b = { "Камень", "Ножницы", "Бумага" };
    Random r = new Random();
    Console.WriteLine("Выберите действие: 0-Камень, 1-Ножницы, 2-Бумага, 3-Закончить игру");
    while (q != 3)
    {
        q = Convert.ToInt32(Console.ReadLine());
        if (q == 3)
            return 0;
        c = r.Next(0, 3);
        Console.WriteLine($"У вас:{b[q]}\tУ компьютера:{a[c]}");
        if (((q == 0) && (c == 1)) || ((q == 1) && (c == 2)) || ((q == 2) && (c == 0)))
            i++;
        else if (q == c)
            Console.WriteLine("Ничья");
        else j++;
        Console.WriteLine($"Cчет:\tУ вас:   {i}\tУ компьютера:   {j}");
    }
    return 0;
}
act();

