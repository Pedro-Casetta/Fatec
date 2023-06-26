const int N = 5;
tpno[] vetor = new tpno[N];
int qtdc = 0;
int opcao = 0;

while (opcao != 4)
{
    Console.Clear();
    Console.WriteLine("Exercício 27");
    Console.WriteLine("");
    Console.WriteLine("TRATAMENTO DE COLISÃO LINEAR");
    Console.WriteLine("");
    Console.WriteLine("[1] - Inserir");
    Console.WriteLine("[2] - Recuperar");
    Console.WriteLine("[3] - Informar");
    Console.WriteLine("[4] - Sair");
    Console.WriteLine("");
    Console.Write("Digite o número da operação: "); opcao = int.Parse(Console.ReadLine());
 
    if (opcao == 1)
    {
        Console.Clear();
        Console.Write("Insira a nota: "); int nota = int.Parse(Console.ReadLine());
        Console.Write("Insira o nome: "); string nome = Console.ReadLine();
        Console.Write("Insira o email: "); string email = Console.ReadLine();
        InsereLinear(vetor, nota, nome, email, ref qtdc);
    }
    
    else if (opcao == 2)
    {
        Console.Clear();
        Console.Write("Digite a nota: "); int nota = int.Parse(Console.ReadLine());
        int pos = BuscaLinear(vetor, nota);
        if (pos == -1)
        {
            Console.WriteLine("Não encontrado");
            Console.ReadKey();
        }

        else
        {
            Console.WriteLine("Encontrado");
            Console.WriteLine("");
            Console.WriteLine("Nota: " + vetor[pos].nota);
            Console.WriteLine("Nome: " + vetor[pos].nome);
            Console.WriteLine("Email: " + vetor[pos].email);
            Console.ReadKey();
        }
    }
    
    else if (opcao == 3)
    {
        Console.WriteLine(qtdc);
        Console.ReadKey();
    }
}

int Hash(int chave)
{
    return chave % N;
}

void InsereLinear(tpno[] v, int nt, string n, string e, ref int qt)
{
    int pos = Hash(nt);
    while(v[pos] != null)
    {
        pos ++;
        pos = pos % N;
        qt ++;
    }
    v[pos] = new tpno();
    v[pos].nota = nt;
    v[pos].nome = n;
    v[pos].email = e;
}

int BuscaLinear(tpno[] v, int nt)
{
    int qtd = 0;
    int pos = Hash(nt);
    while ((v[pos] == null || v[pos].nota != nt) && qtd < N)
    {
        pos ++;
        pos = pos % N;
    }
    if (qtd < N)
        return pos;
    else
        return -1;
}

class tpno
{
    public int nota;
    public string nome, email;
}