int opcaopai = 0;
const int N = 5;
registro[] vetor1 = new registro[N];
registro[] vetor2 = new registro[N];
registro[] vetor3 = new registro[N];

while (opcaopai != 4) // MENU PRINCIPAL
{
    int opcaofilho = 0;
    Console.Clear();
    Console.WriteLine("EXERCICIO 28");
    Console.WriteLine("");
    Console.WriteLine("[1] - Sem tratamento de colisão");
    Console.WriteLine("[2] - Tratamento de colisão linear");
    Console.WriteLine("[3] - Tratamento de colisão com lista encadeada");
    Console.WriteLine("[4] - Sair");
    Console.WriteLine("");
    Console.Write("Digite o número da opção: "); opcaopai = int.Parse(Console.ReadLine());

    while(opcaopai == 1 && opcaofilho != 4)                             // MENU "SEM TRATAMENTO DE COLISÃO"
    {
        Console.Clear();
        Console.WriteLine("Sem tratamento de colisão");
        Console.WriteLine("");
        Console.WriteLine("[1] - Inserir");
        Console.WriteLine("[2] - Alterar");
        Console.WriteLine("[3] - Relatar");
        Console.WriteLine("[4] - Sair");
        Console.WriteLine("");
        Console.Write("Digite o número da opção: "); opcaofilho = int.Parse(Console.ReadLine());
        if (opcaofilho == 1)
        {
            Console.Clear();
            Console.Write("Insira o nome: "); string nome = Console.ReadLine();
            Console.Write("Insira a idade: "); int idade = int.Parse(Console.ReadLine());
            Console.Write("Insira o whatsapp: "); string whats = Console.ReadLine();
            Insere1(vetor1, idade, nome, whats);
        }
        else if (opcaofilho == 2)
        {
            Console.Clear();
            Console.Write("Digite a idade: "); int idade = int.Parse(Console.ReadLine());
            Console.WriteLine("");
            Alterar1(vetor1, idade);
        }
        else if (opcaofilho == 3)
        {
            Relatar1(vetor1);
        }
    }

    while(opcaopai == 2 && opcaofilho != 4)                         // MENU "TRATAMENTO DE COLISÃO LINEAR"
    {
        Console.Clear();
        Console.WriteLine("Tratamento de colisão linear");
        Console.WriteLine("");
        Console.WriteLine("[1] - Inserir");
        Console.WriteLine("[2] - Alterar");
        Console.WriteLine("[3] - Relatar");
        Console.WriteLine("[4] - Sair");
        Console.WriteLine("");
        Console.Write("Digite o número da opção: "); opcaofilho = int.Parse(Console.ReadLine());
        if (opcaofilho == 1)
        {
            Console.Clear();
            Console.Write("Insira o nome: "); string nome = Console.ReadLine();
            Console.Write("Insira a idade: "); int idade = int.Parse(Console.ReadLine());
            Console.Write("Insira o whatsapp: "); string whats = Console.ReadLine();
            Insere2(vetor2, idade, nome, whats);
        }
        else if (opcaofilho == 2)
        {
            Console.Clear();
            Console.Write("Digite a idade: "); int idade = int.Parse(Console.ReadLine());
            Console.WriteLine("");
            Alterar2(vetor2, idade);
        }
        else if (opcaofilho == 3)
        {
            Relatar2(vetor2);
        }
    }

    while(opcaopai == 3 && opcaofilho != 4)                     // MENU "TRATAMENTO DE COLISÃO COM LISTA ENCADEADA"
    {
        Console.Clear();
        Console.WriteLine("Tratamento de colisão com lista encadeada");
        Console.WriteLine("");
        Console.WriteLine("[1] - Inserir");
        Console.WriteLine("[2] - Alterar");
        Console.WriteLine("[3] - Relatar");
        Console.WriteLine("[4] - Sair");
        Console.WriteLine("");
        Console.Write("Digite o número da opção: "); opcaofilho = int.Parse(Console.ReadLine());
        if (opcaofilho == 1)
        {
            Console.Clear();
            Console.Write("Insira o nome: "); string nome = Console.ReadLine();
            Console.Write("Insira a idade: "); int idade = int.Parse(Console.ReadLine());
            Console.Write("Insira o whatsapp: "); string whats = Console.ReadLine();
            Insere3(ref vetor3, idade, nome, whats);
        }
        else if (opcaofilho == 2)
        {
            Console.Clear();
            Console.Write("Digite a idade: "); int idade = int.Parse(Console.ReadLine());
            Console.WriteLine("");
            int pos = Hash(idade);
            Alterar3(ref vetor3[pos], idade);
        }
        else if (opcaofilho == 3)
        {
            int pos = 0;
            Console.Clear();
            Console.WriteLine("NOME         |   IDADE   |       WHATSAPP");
            Console.WriteLine("");
            Relatar3(vetor3, pos, ref vetor3[pos]);
            Console.WriteLine("\nAperte 'ENTER' para prosseguir:");
            Console.ReadKey();
        }
    }
}

int Hash(int chave)
{
    return (chave % N);
}

void Insere1(registro[] vetor, int idade, string nome, string whats)    // FUNCOES SEM TRATAMENTO COLISAO
{
    int pos = Hash(idade);
    vetor[pos] = new registro();
    vetor[pos].nome = nome;
    vetor[pos].idade = idade;
    vetor[pos].whats = whats;
}

registro[] Alterar1(registro[] vetor, int idade)
{
    int pos = 0;
    for (pos = 0; pos != N; pos++)
    {
        if (vetor[pos] != null && vetor[pos].idade == idade)
        {
            Console.WriteLine("Nome: " + vetor[pos].nome);
            Console.WriteLine("Whatsapp: " + vetor[pos].whats);
            Console.WriteLine("");
            Console.Write("Altere o nome: "); vetor[pos].nome = Console.ReadLine();
            Console.Write("Altere o Whatsapp: "); vetor[pos].whats = Console.ReadLine();
            return vetor;
        }
    }
    if (pos == 5)
    {
        Console.WriteLine("Não encontrado. Aperte 'ENTER' para prosseguir:");
        Console.ReadKey();
    }
    return vetor;
}

void Relatar1(registro[] vetor)
{
    Console.Clear();
    Console.WriteLine("NOME         |   IDADE   |       WHATSAPP");
    Console.WriteLine("");
    for(int pos = 0; pos < N; pos++)
    {
        if (vetor[pos] != null)
        {
            Console.WriteLine(vetor[pos].nome + "   |   " + vetor[pos].idade + "    |   " + vetor[pos].whats);
        }
    }
    Console.WriteLine("\nAperte 'ENTER' para prosseguir:");
    Console.ReadKey();
}

void Insere2(registro[] vetor, int idade, string nome, string whats)        // FUNCOES TRATAMENTO LINEAR
{
    int pos = Hash(idade);
    while(vetor[pos] != null && pos < 5)
    {
        pos++;
        pos = pos % N;
    }
    vetor[pos] = new registro();
    vetor[pos].nome = nome;
    vetor[pos].idade = idade;
    vetor[pos].whats = whats;
}

registro[] Alterar2(registro[] vetor, int idade)
{
    int pos = 0;
    for (pos = 0; pos != N; pos++)
    {
        if (vetor[pos] != null && vetor[pos].idade == idade)
        {
            Console.WriteLine("Nome: " + vetor[pos].nome);
            Console.WriteLine("Whatsapp: " + vetor[pos].whats);
            Console.WriteLine("");
            Console.Write("Altere o nome: "); vetor[pos].nome = Console.ReadLine();
            Console.Write("Altere o Whatsapp: "); vetor[pos].whats = Console.ReadLine();
            return vetor;
        }
    }
    if (pos == 5)
    {
        Console.WriteLine("Não encontrado. Aperte 'ENTER' para prosseguir:");
        Console.ReadKey();
    }
    return vetor;
}

void Relatar2(registro[] vetor)
{
    Console.Clear();
    Console.WriteLine("NOME         |   IDADE   |       WHATSAPP");
    Console.WriteLine("");
    for(int pos = 0; pos < N; pos++)
    {
        if (vetor[pos] != null)
        {
            Console.WriteLine(vetor[pos].nome + "   |   " + vetor[pos].idade + "    |   " + vetor[pos].whats);
        }
    }
    Console.WriteLine("\nAperte 'ENTER' para prosseguir:");
    Console.ReadKey();
}

void Insere3(ref registro[] vetor, int idade, string nome, string whats)                    //FUNCOES TRATAMENTO ENCADEADO
{
    int pos = Hash(idade);
    registro novo = new registro();
    novo.nome = nome;
    novo.idade = idade;
    novo.whats = whats;
    if (vetor[pos] != null)
        novo.prox = vetor[pos];
    vetor[pos] = novo;
}

void Alterar3(ref registro no, int idade)
{
    if (no == null)
    {
        Console.WriteLine("Não encontrado. Aperte 'ENTER' para prosseguir:");
        Console.ReadKey();
    }
    else if (no.idade == idade)
    {
        Console.WriteLine("Nome: " + no.nome);
        Console.WriteLine("Whatsapp: " + no.whats);
        Console.WriteLine("");
        Console.Write("Altere o nome: "); no.nome = Console.ReadLine();
        Console.Write("Altere o Whatsapp: "); no.whats = Console.ReadLine();
    }
    else
        Alterar3(ref no.prox, idade);
}

void Relatar3(registro[] vetor, int pos, ref registro reg)
{
    if (reg != null)
    {
        Console.WriteLine(reg.nome + "   |   " + reg.idade + "    |   " + reg.whats);
        Relatar3(vetor, pos, ref reg.prox);
    }
    else if (reg == null && pos != N - 1)
        Relatar3(vetor, pos + 1, ref vetor[pos + 1]);
}

class registro
{
    public int idade;
    public string nome, whats;
    public registro prox;
}