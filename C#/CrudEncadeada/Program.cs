
tpno lista = null;
int opcao = 0;

while(opcao != 5)
{
    Console.Clear();
    Console.WriteLine("Exercício 18");
    Console.WriteLine("");
    Console.WriteLine("GERENCIADOR DE CADASTRO");
    Console.WriteLine("");
    Console.WriteLine("[1] - Inserir");
    Console.WriteLine("[2] - Exibir");
    Console.WriteLine("[3] - Alterar");
    Console.WriteLine("[4] - Excluir");
    Console.WriteLine("[5] - Sair");
    Console.WriteLine("");
    Console.Write("Digite o número da operação: "); opcao = int.Parse(Console.ReadLine());

    if(opcao == 1)
    {
        Console.Clear();
        Console.Write("Digite o nome: "); string nome = Console.ReadLine();
        Console.WriteLine("");
        Console.Write("Digite a idade: "); string idade = Console.ReadLine();
        Console.WriteLine("");
        Console.Write("Digite o whatsapp: "); string whats = Console.ReadLine();
        Inserir(ref lista, nome, idade, whats);
    }

    else if(opcao == 2)
    {
        Console.Clear();
        Exibir(lista);
    }
    
    else if(opcao == 3)
    {
        Alterar(lista);
    }

    else if(opcao == 4)
    {
        Excluir(ref lista);
    }
}


void Inserir(ref tpno l, string nome, string idade, string whats)
{
    tpno no = new tpno();
    no.nome = nome;
    no.idade = idade;
    no.whats = whats;
    if(l != null)
        no.prox = l;
    l = no;
}

void Exibir(tpno l)
{
    Console.WriteLine("NOME \t  | \t IDADE \t    | \t WHATSAPP ");
    Console.WriteLine("");
    while(l != null)
    {
        Console.WriteLine("-----------------------------------------------------");
        Console.WriteLine(l.nome + "\t  | \t" + l.idade + "\t  | \t" + l.whats);
        l = l.prox;
    }
    Console.WriteLine("");
    Console.WriteLine("Aperte 'ENTER' para prosseguir:");
    Console.ReadKey();
}

void Consulta(tpno l, string np, ref tpno ant, ref tpno atu)
{
    atu = l;
    ant = null;
    while(atu != null && np != atu.nome)
    {
        ant = atu;
        atu = atu.prox;
    }
}

void Alterar(tpno l)
{
    string np;
    tpno anterior = null, atual = null;
    Console.Write("Nome procurado: "); np = Console.ReadLine();
    Consulta(l, np, ref anterior, ref atual);
    if(atual != null)
    {
        Console.Clear();
        Console.WriteLine("DADOS ATUAIS");
        Console.WriteLine("");
        Console.WriteLine("Nome: " + atual.nome);
        Console.WriteLine("Idade: " + atual.idade);
        Console.WriteLine("Whatsapp: " + atual.whats);
        Console.WriteLine("");
        Console.WriteLine("Digite novos dados");
        Console.Write("Nome: "); atual.nome = Console.ReadLine();
        Console.Write("Idade: "); atual.idade = Console.ReadLine();
        Console.Write("Whatsapp: "); atual.whats = Console.ReadLine();
    }
    else
    {
        Console.WriteLine("Não encontrado!");
        Console.ReadKey();
    }
}

void Excluir(ref tpno l)
{
    string np;
    tpno anterior = null, atual = null;
    Console.Write("Nome procurado: "); np = Console.ReadLine();
    Consulta(l, np, ref anterior, ref atual);
    if(atual != null)
    {
        Console.Clear();
        Console.WriteLine("DADOS ATUAIS");
        Console.WriteLine("");
        Console.WriteLine("Nome: " + atual.nome);
        Console.WriteLine("Idade: " + atual.idade);
        Console.WriteLine("Whatsapp: " + atual.whats);
        Console.WriteLine("");
        Console.WriteLine("Aperte 'ENTER' para excluir:");
        Console.ReadKey();
        if(atual == l)
        {
            l = l.prox;
            atual.prox = null;
        }
        else if(atual.prox == null)
        {
            anterior.prox = null;
        }
        else
        {
            anterior.prox = atual.prox;
            atual.prox =null;
        }
        Console.WriteLine("");
        Console.WriteLine("Excluído com sucesso! Aperte 'ENTER' para prosseguir:");
        Console.ReadKey();

    }
    else
    {
        Console.WriteLine("Não encontrado!");
        Console.ReadKey();
    }
}


class tpno
{
    public string nome, idade, whats;
    public tpno prox = null;
}