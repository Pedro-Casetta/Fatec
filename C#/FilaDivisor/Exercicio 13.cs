const int MAX = 20;

void Insere(int[] fila, ref int final, int variavel)
{
    fila[final] = variavel;
    final += 1;
}

int Remove(int[] fila, ref int inicio)
{
    int variavel = fila[inicio];
    inicio += 1;
    return variavel;
}

bool EstaVazia(int inicio, int final)
{
    if (inicio == final)
        return true;
    else
        return false;
}

bool EstaCheia(int final, int MAX)
{
    if (final == MAX)
        return true;
    else
        return false;
}

int[] fila = new int [MAX];
int inicio = 0;
int final = 0;

int[] filaMA = new int[MAX];
int iMA = 0;
int fMA = 0;

int[] filame = new int[MAX];
int ime = 0;
int fme = 0;

int variavel = 1;
int vdivisor = 0;

Console.Clear();
while (variavel != 0)
{
    Console.WriteLine("");
    Console.Write("Digite um número inteiro: ");
    variavel = int.Parse(Console.ReadLine());
    if (EstaCheia(final, MAX) == false)
    {
        if (variavel != 0)
            Insere(fila, ref final, variavel);
    }
    if (EstaCheia(final, MAX) == true)
        variavel = 0;
}

Console.WriteLine("");
Console.Write("Digite o número divisor: ");
vdivisor = int.Parse(Console.ReadLine());

for (int i = 0; i < final; i++)
{
    int validado = Remove(fila, ref inicio);
    if (validado < vdivisor)
        Insere(filame, ref fme, validado);
    else
        Insere(filaMA, ref fMA, validado);
}

Console.WriteLine("");
Console.Write("[");
for (int i = 0; i < fme; i++)
{
    if (EstaVazia(ime, fme) == false)
    {
        Console.Write(Remove(filame, ref ime));
    }
    if (i != fme - 1)
        Console.Write(",");
}
Console.WriteLine("] fila menor que o divisor");

Console.WriteLine("");
Console.WriteLine("[" + vdivisor + "] divisor");
Console.WriteLine("");

Console.Write("[");
for (int i = 0; i < fMA; i++)
{
    if (EstaVazia(iMA, fMA) == false)
    {
        Console.Write(Remove(filaMA, ref iMA));
    }
    if (i != fMA - 1)
        Console.Write(",");
}
Console.WriteLine("] fila igual ou maior que o divisor");
Console.WriteLine("");
