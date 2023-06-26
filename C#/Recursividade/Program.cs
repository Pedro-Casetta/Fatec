
string op = "0";
while (op != "3")
{
    Console.Clear();
    Console.WriteLine("MENU PRINCIPAL");
    Console.WriteLine("1 - Funções sem  vetor");
    Console.WriteLine("2 - Função com vetor");
    Console.WriteLine("3 - Sair");
    Console.Write("Digite a opção desejada: ");
    op = Console.ReadLine();
    if (op == "1")
    {
        int ni, nf;
        Console.Write("Numero Inicial: ");
        ni = int.Parse(Console.ReadLine());
        Console.Write("Numero Final: ");
        nf = int.Parse(Console.ReadLine());
        
        Console.WriteLine("MENU 2");
        Console.WriteLine("1 - Crescente");
        Console.WriteLine("2 - Decrescente");
        Console.WriteLine("3 - Impares");
        Console.WriteLine("4 - Somatório");
        Console.Write("Qual você quer? : ");
        string op2 = Console.ReadLine();

        if (op2 == "1")
            crescente(ni,nf);
        if (op2 == "2")
            decrescente(ni, nf);
        if (op2 == "3")
            impares(ni, nf);
        if (op2 == "4")
            Console.WriteLine(somatorio(ni, nf));
    }
    Console.ReadKey();
}

void crescente(int ni, int nf)
{
    if (ni <= nf)
    {
        Console.WriteLine(ni);
        crescente(ni + 1, nf);
    }
}

void decrescente(int ni, int nf)
{
    if (nf >= ni)
    {
        Console.WriteLine(nf);
        decrescente(ni, nf - 1);
    }
}

void impares(int ni, int nf)
{
    if (ni <= nf)
    {
        if (ni % 2 != 0)
        {
            Console.WriteLine(ni);
        }
        impares(ni + 1, nf);
    }
}

int somatorio(int ni, int nf)
{
    if (ni == nf)
      return ni;
    else
        return ni + somatorio(ni + 1,nf);
}