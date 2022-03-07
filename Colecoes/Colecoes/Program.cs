using System;
using Colecoes.Helper;
using static System.Console;

class Program
{
    static void Main()
    {
        Clear();
        WriteLine("Lets rock baby");
        int[] vetor = new int[10];
        for (int i = 0; i < vetor.Length; i++)
        {
            vetor[i] = i - 5;
        }
        WriteLine("perocrrendo o vetor com um foreach");
        foreach (var item in vetor)
        {
            WriteLine(item);
        }

        int[,] matriz = new int[4, 2]
        {
            {1,2},
            {3,4},
            {5,6},
            {7,8}
        };
        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            WriteLine("");
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                Write(matriz[i, j] + " , ");
            }
        }
        WriteLine("******************8 \n\n");

        int[] vetor1 = new int[10]
            {10,8,4,6,7,1,4,3,2,5};
        OperacoesArray op = new OperacoesArray();

        //bubble sort
        WriteLine("bubble sort");
        op.ImprimirVetor(vetor1);
        //op.OrdenaVetor(ref vetor1);
        // op.Ordenar(ref vetor1);
        op.ImprimirVetor(vetor1);

        // copiando arrays

        int[] vetorCopia = new int[10];
        WriteLine("******************8 \n\n");
        WriteLine("copia de vetores");
        WriteLine("vetor origem");
        op.ImprimirVetor(vetor1);
        WriteLine("vetor destino");
        op.ImprimirVetor(vetorCopia);
        op.CopiarVetor(ref vetor1, ref vetorCopia);
        WriteLine("vetor origem");
        op.ImprimirVetor(vetor1);
        WriteLine("vetor destino");
        op.ImprimirVetor(vetorCopia);

        WriteLine("******************8 \n\n");
        WriteLine("procurar valor");
        if (op.Existe(vetor1, 11))
        {
            WriteLine("achei!!!");
        }
        else
        {
            WriteLine("não achei!");
        }

        WriteLine("******************8 \n\n");
        WriteLine("verificando todos os elementos de um vetor");
        WriteLine(op.TodosMaiorQue(vetor1, 2));


        WriteLine("******************8 \n\n");
        WriteLine("encontrando um valor em um vetor");
        WriteLine("Enontrei o valor:" + op.EncontrarValor(vetor1, 7));
        WriteLine("Enontrei o valor:" + op.EncontrarValor(vetor1, 15));

        WriteLine("******************8 \n\n");
        WriteLine("encontrando o indice de um valor em um vetor");
        WriteLine("O valor procurado eta na posição:" + op.ObterIndice(vetor1, 7));

        WriteLine("******************8 \n\n");
        WriteLine("mudando a dimensão de um vetor");
        WriteLine("Comprimento original: " + vetor1.Length);
        op.Redimensionar(ref vetor1, 20);
        WriteLine("Comprimento final: " + vetor1.Length);

        string[] vetorstring = new string[vetor1.Length];
        vetorstring = op.ConverterParaString(vetor1);
        for (int k = 0; k < vetorstring.Length; k++)
        {
            System.Console.Write(vetorstring[k] + "   ");
        }

        WriteLine("******************8 \n\n");
        WriteLine("trabalhando com listas");

        List<string> estados = new List<string>();
        estados.Add("BA");
        estados.Add("SP");
        estados.Add("MG");

        string[] estadovetor = new string[2] { "SC", "RJ" };

        WriteLine($"quantidade de elementos na lista: {estados.Count} \n");
        // foreach (var item in estados)
        // {
        //     WriteLine(item);
        // }
        // for (int i = 0; i < estados.Count; i++)
        // {
        //     WriteLine($"elemento[{i}]: {estados[i]}");
        // }

        OperacoesLista opl = new OperacoesLista();
        opl.ImprimirListaString(estados);
        // estados.Remove("MG");
        estados.AddRange(estadovetor);
        WriteLine("**********");
        opl.ImprimirListaString(estados);
        estados.Insert(1, "PR");
        WriteLine("**********");
        opl.ImprimirListaString(estados);


        WriteLine("******************8 \n\n");
        WriteLine("trabalhando com Queue (Filas)");

        Queue<string> fila = new Queue<string>();

        fila.Enqueue("primeiro");
        fila.Enqueue("segundo");
        fila.Enqueue("terceiro");
        fila.Enqueue("quarto");
        WriteLine($"contagem: {fila.Count}");

        while (fila.Count > 0)
        {
            WriteLine($"próximo elemento a sair da fila: {fila.Peek()}");
            WriteLine($"saiu: {fila.Dequeue()}");
            WriteLine($"contagem: {fila.Count}");
            WriteLine($"**********************");
        }

        WriteLine("******************8 \n\n");
        WriteLine("trabalhando com Stacks (pilhas)");

        Stack<string> pilha = new Stack<string>();
        pilha.Push("primeiro a entrar");
        pilha.Push("segundo a entrar");
        pilha.Push("terceiro a entrar");
        pilha.Push("quarto a entrar");
        WriteLine($"contagem da pilha: {pilha.Count}");

        while (pilha.Count > 0)
        {
            WriteLine($"contagem da pilha: {pilha.Count}");
            WriteLine($"quem vai sair agora: {pilha.Peek()}");
            WriteLine($"{pilha.Pop()} saiu da pilha");
            WriteLine($"***************");
        }

        WriteLine("******************8 \n\n");
        WriteLine("trabalhando com Dictionary (dicionários chave/valor)");

        Dictionary<string, string> uf = new Dictionary<string, string>();
        uf.Add("SP", "São Paulo");
        uf.Add("BA", "Bahia");
        uf.Add("PE", "Pernambuco");
        uf.Add("PR", "Paraná");
        // uf.Add("SP", "São Paulo");

        foreach (KeyValuePair<string, string> item in uf)
        {
            WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
        }

        string valorprocurado = "PE";
        WriteLine($"valor procurado {valorprocurado} :: {uf[valorprocurado]}");
        uf[valorprocurado] = "pernambuco";
        WriteLine($"valor procurado {valorprocurado} :: {uf[valorprocurado]}");
        uf.Remove(valorprocurado);

        foreach (KeyValuePair<string, string> item in uf)
        {
            WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
        }

        valorprocurado = "BA";
        if (uf.TryGetValue(valorprocurado, out string ufencontrado))
        {
            WriteLine($"achei o valor procurado: {ufencontrado}");
        }
        else
        {
            WriteLine($"NÃO achei o valor procurado");
        }

        WriteLine("******************8 \n\n");
        WriteLine("trabalhando com LINQ");

        int[] numbers = new int[10] { 1, 4, 8, 0, 15, 19, 100, 19, 4, 100 };

        var paresQuery =
            from num in numbers
            where num % 2 == 0
            orderby num
            select num;

        var paresMetodo = numbers.Where(x => x % 2 == 0).OrderBy(x => x).ToList();

        WriteLine("original: " + string.Join(", ", numbers));
        WriteLine("pares por query: " + string.Join(", ", paresQuery));
        WriteLine("pares por query: " + string.Join(", ", paresMetodo));

        var minimo = numbers.Min();
        var maximo = numbers.Max();
        var medio = numbers.Average();

        WriteLine($"mínimo: {minimo}, máximo: {maximo}, média: {medio}");
        WriteLine($"somatório: {numbers.Sum()}");
        var numbersUnico = numbers.Distinct().ToArray();
        WriteLine("original: " + string.Join(", ", numbers));

        WriteLine("distintos: " + string.Join(", ", numbersUnico));






    }


}

