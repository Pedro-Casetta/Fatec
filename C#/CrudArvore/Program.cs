tp_no raiz = null;
int opcao = 0;

while(opcao != 5)
{
   Console.Clear();
   Console.WriteLine("Exercício 24");
   Console.WriteLine("");
   Console.WriteLine("ARVORE BINARIA");
   Console.WriteLine("");
   Console.WriteLine("[1] - Inserir");
   Console.WriteLine("[2] - Pesquisar");
   Console.WriteLine("[3] - Remover");
   Console.WriteLine("[4] - Exibir");
   Console.WriteLine("[5] - Sair");
   Console.WriteLine("");
   Console.Write("Digite o número da operação: "); opcao = int.Parse(Console.ReadLine());

   if(opcao == 1)
   {
      Console.Clear();
      Console.Write("Digite um valor: "); int valor = int.Parse(Console.ReadLine());
      Insere(ref raiz, valor);
   }

   else if(opcao == 2)
   {
      Console.Clear();
      Console.Write("Pesquise um valor: "); int vpesq = int.Parse(Console.ReadLine());
      Console.WriteLine("");
      tp_no raize = Busca(raiz, vpesq);
      if (raize != null)
      {
         Console.WriteLine("Valor encontrado! :  " + raize.valor);
      }
      else
         Console.WriteLine("Valor não encontrado.");
      Console.WriteLine("");
      Console.WriteLine("Aperte 'ENTER' para prosseguir:");
      Console.ReadKey();
   }
    
   else if(opcao == 3)
   {
      Console.Clear();
      Console.Write("Remova um valor: "); int vrem = int.Parse(Console.ReadLine());
      Console.WriteLine("");
      tp_no resultado = Remove(ref raiz, vrem);
      if (resultado != null)
         Console.WriteLine("Valor removido com sucesso! Aperte 'ENTER' para prosseguir:");
      else
         Console.WriteLine("Valor não encontrado. Aperte 'ENTER' para prosseguir:");
      Console.ReadKey();
   }

   else if(opcao == 4)
   {
      Console.Clear();
      Console.WriteLine("[1] - Em ordem");
      Console.WriteLine("[2] - Pré ordem");
      Console.WriteLine("[3] - Pós ordem");
      Console.WriteLine("");
      Console.Write("Escolha uma opção: "); int op = int.Parse(Console.ReadLine());
      Console.WriteLine("");
      if (op == 1)
         EmOrdem(raiz);
      else if (op == 2)
         PreOrdem(raiz);
      else if (op == 3)
         PosOrdem(raiz);
      Console.WriteLine("");
      Console.WriteLine("Aperte 'ENTER' para prosseguir:");
      Console.ReadKey();
   }
}

void Insere(ref tp_no r, int x)
{
   if (r == null)
   {
      r = new tp_no();
      r.valor = x;
   }
   else if (x < r.valor)
      Insere(ref r.esq, x);
   else
      Insere(ref r.dir, x);
}

tp_no Busca(tp_no r, int x)
{
   if (r == null)
      return null;
   else if (x == r.valor)
      return r;
   else if (x < r.valor)
      return Busca(r.esq, x);
   else
      return Busca(r.dir, x);
}

tp_no RetornaMaior(ref tp_no r)
{
   if (r.dir == null)
   {
      tp_no p = r;
      r = r.esq;
      return p;
   }
   else
      return RetornaMaior(ref r.dir);
}

tp_no Remove(ref tp_no r, int x)
{
   if (r == null)
      return null;     
   else if (x == r.valor)
   {       
      tp_no p = r;
      if (r.esq == null)        // nao tem filho esquerdo
         r = r.dir;
      else if (r.dir == null)  // nao tem filho direito
         r = r.esq;
      else                          // tem ambos os filhos
      {
         p = RetornaMaior(ref r.esq);
         r.valor = p.valor;
      }
      return p;
   }
   else if (x < r.valor)
      return Remove(ref r.esq, x);
   else
      return Remove(ref r.dir, x);
}

void EmOrdem(tp_no r)
{
   if (r != null)
   {
      EmOrdem(r.esq);
      Console.WriteLine(r.valor);
      EmOrdem(r.dir);
   }
}

void PreOrdem(tp_no r)
{
   if (r != null)
   {
      Console.WriteLine(r.valor);
      PreOrdem(r.esq);
      PreOrdem(r.dir);
   }
}

void PosOrdem(tp_no r)
{
   if (r != null)
   {
      PosOrdem(r.esq);
      PosOrdem(r.dir);
      Console.WriteLine(r.valor);
   }
}

class tp_no
{
   public tp_no esq;
   public int valor;
   public tp_no dir;
}