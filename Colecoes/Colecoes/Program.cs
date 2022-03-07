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

    }


}

