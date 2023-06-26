Console.Clear();
Console.WriteLine("");
Console.WriteLine("Exercício 8");
Console.WriteLine("");
Console.Write("Escreva seu nome completo: ");
string nome = Console.ReadLine();
char[] pilha = new char[nome.Length];
int topo = 0;
int i = 0;

while (i < nome.Length)
{
    while (i < nome.Length && nome[i] != ' ')
    {
        Insere(pilha, ref topo, nome[i]);
        i += 1;
    }
    while (EstaVazia(ref topo) == false)
    {
        char letra = Remove(pilha, ref topo);
        Console.Write(letra);
    }
    i += 1;
    Console.Write(" ");
}

void Insere(char[] pilha, ref int topo, char n)
{
        pilha[topo] = n;
        topo += 1;
}

char Remove(char[] pilha, ref int topo)
{
    topo -= 1;
    return pilha[topo];
}

bool EstaVazia(ref int topo)
{
    if (topo == 0)
        return true;
    else
        return false;
}