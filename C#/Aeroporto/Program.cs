const int MAX = 20;
int opcao = 7;
int[] decolagem = new int[MAX];
int inicio = 0;
int fim = 0;

while (opcao != 6)
{
    Console.Clear();
    Console.WriteLine("CONTROLE DA PISTA DE DECOLAGEM");
    Console.WriteLine("");
    Console.WriteLine("[1] ADICIONAR AVIÃO NA FILA DE DECOLAGEM");
    Console.WriteLine("[2] QUANTIDADE DE AVIÕES NA FILA");
    Console.WriteLine("[3] AUTORIZAR DECOLAGEM DE UM AVIÃO");
    Console.WriteLine("[4] CONSULTAR AVIÕES NA FILA");
    Console.WriteLine("[5] VISUALIZAR PRIMEIRO AVIÃO DA FILA");
    Console.WriteLine("[6] SAIR");
    Console.WriteLine("");
    Console.Write("Digite aqui o número ao lado da opção desejada: ");
    opcao = int.Parse(Console.ReadLine());

    if (opcao == 1)
    {
        if (EstaCheia(fim, MAX) == false)
        {
            string op = "sim";
            while (op == "sim")
            {
                Console.Clear();
                Console.Write("Digite o número do avião que pretende decolar: ");
                int aviao = int.Parse(Console.ReadLine());
                Adicionar(decolagem, ref fim, aviao);
                Console.WriteLine("");
                Console.Write("Deseja inserir mais aviões? ('sim' ou 'nao')  : ");
                op = Console.ReadLine();
                if (EstaCheia(fim, MAX) == true && op == "sim")
                {
                    Console.WriteLine("");
                    Console.WriteLine("FILA DE DECOLAGEM ENCHEU! APERTE 'ENTER' PARA PROSSEGUIR ");
                    Console.ReadKey();
                    op = "nao";
                }
            }
        }
        else
        {
            Console.WriteLine("");
            Console.WriteLine("FILA DE DECOLAGEM ENCHEU! APERTE 'ENTER' PARA PROSSEGUIR ");
            Console.ReadKey();
        }
    }

    else if (opcao == 2)
    {
        if (EstaVazia(inicio, fim) == true)
        {
            Console.WriteLine("");
            Console.WriteLine("Não há aviões na fila. Aperte 'ENTER' para prosseguir");
            Console.ReadKey();
        }
        else
        {
            Console.WriteLine("");
            Console.WriteLine(ContarAviao(inicio, fim) + " Aviões na fila. Aperte 'ENTER' para prosseguir");
            Console.ReadKey();
        }
    }

    else if (opcao == 3)
    {
        if(EstaVazia(inicio, fim) == false)
        {
            int aviao = Decolar(decolagem, ref inicio);
            Console.WriteLine("");
            Console.WriteLine("O avião " + aviao + " vai decolar! Aperte 'ENTER' para prosseguir");
            Console.ReadKey();
        }
        else
        {
            Console.WriteLine("");
            Console.WriteLine("Todos os aviões da fila decolaram! Aperte 'ENTER' para prosseguir");
            Console.ReadKey();
        }
    }

    else if (opcao == 4)
    {
        if (EstaVazia(inicio, fim) == true)
        {
            Console.WriteLine("");
            Console.WriteLine("Não há aviões na fila. Aperte 'ENTER' para prosseguir");
            Console.ReadKey();
        }
        else
        {
            Console.WriteLine("");
            Console.WriteLine("Ordem de decolagem da esquerda para a direita");
            Console.WriteLine("");
            Console.Write("[");
            for (int i = inicio; i < fim; i = i + 1)
            {
                Console.Write(decolagem[i]);
                if (i != fim - 1)
                    Console.Write(",");
            }
            Console.WriteLine("]");
            Console.WriteLine("");
            Console.WriteLine("Aperte 'ENTER' para prosseguir");
            Console.ReadKey();
        }
    }

    else if (opcao == 5)
    {
        if (EstaVazia(inicio, fim) == true)
        {
            Console.WriteLine("");
            Console.WriteLine("Não há aviões na fila. Aperte 'ENTER' para prosseguir");
            Console.ReadKey();
        }
        else
        {
            Console.WriteLine("");
            Console.WriteLine("O primeiro da fila é o avião " + decolagem[inicio] + " - Aperte 'ENTER' para prosseguir");
            Console.ReadKey();
        }
    }
}

bool EstaCheia(int final, int limite)
{
    if (final == limite)
        return true;
    else
        return false;
}

bool EstaVazia(int inicio, int final)
{
    if (inicio == final)
        return true;
    else
        return false;
}

void Adicionar(int[] fila, ref int final, int aviao)
{
    fila[final] = aviao;
    final = final + 1;
}

int ContarAviao(int inicio, int fim)
{
    int contador = 0;
    while (inicio < fim)
    {
        contador = contador + 1;
        inicio += 1;
    }
    return contador;
}

int Decolar(int[] fila, ref int inicio)
{
    int av = fila[inicio];
    inicio += 1;
    return av;
}