int opcao = 0;
Tipo l = null;

while(opcao != 3)
{
    Console.Clear();
    Console.WriteLine("Exercício de Lista Encadeada");
    Console.WriteLine("");
    Console.WriteLine("[1] - Inserir");
    Console.WriteLine("[2] - Remover");
    Console.WriteLine("[3] - Sair");
    Console.WriteLine("");
    Console.Write("Digite o número da opção: ");
    opcao = int.Parse(Console.ReadLine());

    if (opcao == 1)
    {
        Console.Clear();
        Console.WriteLine("");
        Console.Write("Digite um número para a lista: ");
        int valor = int.Parse(Console.ReadLine());
        Insere(ref l, valor);
    }

    else if(opcao == 2)
    {
        Console.WriteLine("");
        Console.WriteLine("Valor removido da lista: " + Remove(ref l).v);
        Console.Write("'ENTER' para prosseguir: ");
        Console.ReadKey();
    }
}

void Insere(ref Tipo lista, int variavel)
{
    Tipo no = new Tipo();
    no.v = variavel;
    if (lista != null)
        no.prox = lista;
    lista = no;
}

Tipo Remove(ref Tipo lista)
{
    Tipo no = null;
    if(lista != null)
    {
        no = lista;
        lista = lista.prox;
        no.prox = null;
    }
    return no;
}

class Tipo
{
    public int v;
    public Tipo prox;
}