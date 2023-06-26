int op = 0;
while ( op != 7)
{
    Console.WriteLine("MENU DE OPÇÕES");
    Console.WriteLine("2.Potenciação");
    Console.WriteLine("3.Potência ao cubo");
    Console.WriteLine("4.Máximo Divisor Comum");
    Console.WriteLine("5.Fibonacci");
    Console.WriteLine("6.Conversor binário");
    Console.WriteLine("7.Sair");
    Console.Write("Escolha uma opção: ");
    op = int.Parse(Console.ReadLine());

    if (op == 2)
    {
        Console.Write("Digite o primeiro número (x): ");
        int numx = int.Parse(Console.ReadLine());
        Console.Write("Digite o segundo número (y): ");
        int numy = int.Parse(Console.ReadLine());
        Console.WriteLine(potencia(numx, numy));
    }

    else if (op == 3)
    {
        Console.Write("Digite o algum número (n): ");
        int numero = int.Parse(Console.ReadLine());
        cubos(numero);
    }

    else if (op == 4)
    {
        Console.Write("Digite o primeiro número (x): ");
        int numx = int.Parse(Console.ReadLine());
        Console.Write("Digite o segundo número (y): ");
        int numy = int.Parse(Console.ReadLine());
        Console.WriteLine(mdc(numx, numy));
    }
    else if (op == 5)
    {
        Console.Write("Digite algum número (n): ");
        int numero = int.Parse(Console.ReadLine());
        Console.Write("Quer ela 'recursiva' ou 'iterativa'? ");
        string escolha = Console.ReadLine();
        if (escolha == "recursiva")
            Console.WriteLine(fibonacci(numero));
        else if (escolha == "iterativa")
            itefibonacci(numero);
    }
    else if (op == 6)
    {
        Console.Write("Digite um número: ");
        int numero = int.Parse(Console.ReadLine());
        conversor(numero);
    }
    Console.ReadKey();
}

int potencia(int x,int y)
{
    if (y == 0)
        return 1;
    return x * potencia(x, y - 1);
}

int cubos(int n)
{
    if (n == 0)
        return 0;
    Console.WriteLine(n * n * n);
    return cubos(n - 1);
}

int mdc(int x, int y)
{
    if (x == y)
        return x;
    else if (x < y)
        return mdc(y, x);
    return mdc(x-y, y);
}

int fibonacci(int n)
{
    Console.WriteLine(n);
    if (n >= 2)
        return fibonacci(n - 1) + fibonacci(n - 2);
    return n;
}

void itefibonacci(int n)
{
    for (; n >= 1; n -= 1)
    {
        if (n >= 2)
            Console.WriteLine((n - 1) + (n - 2));
        else
            Console.WriteLine(n);
    }
}

void conversor(int n)
{
    if (n == 1)
         Console.WriteLine(n);
    else if(n == 0)
        Console.WriteLine(n);
    else
    {
        conversor(n / 2);
        Console.WriteLine(n % 2);
    }
}