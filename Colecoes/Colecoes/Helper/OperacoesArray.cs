namespace Colecoes.Helper
{
    public class OperacoesArray
    {
        public void ImprimirVetor(int[] vetor)
        {
            for (int k = 0; k < vetor.Length; k++)
            {
                System.Console.Write(vetor[k] + "   ");
            }
            System.Console.WriteLine("");
        }

        public void OrdenaVetor(ref int[] vetor)
        {
            for (int i = 0; i < vetor.Length; i++)
            {
                for (int j = i + 1; j < vetor.Length; j++)
                {
                    //WriteLine($"vetor[{i}]={vetor[i]}  vetor[{j}]={vetor[j]}");
                    if (vetor[i] > vetor[j])
                    {
                        int temp = vetor[i];
                        vetor[i] = vetor[j];
                        vetor[j] = temp;
                    }
                }
            }

        }


        public void Ordenar(ref int[] vetor)
        {
            Array.Sort(vetor);
        }

        public void CopiarVetor(ref int[] vetorOrigem, ref int[] vetorDestino)
        {
            Array.Copy(vetorOrigem, vetorDestino, vetorOrigem.Length);
        }

        public bool Existe(int[] vetor, int valor)
        {
            return Array.Exists(vetor, elemento => elemento == valor);
        }

        public bool TodosMaiorQue(int[] vetor, int valor)
        {
            return Array.TrueForAll(vetor, elemento => elemento > valor);
        }

        public int EncontrarValor(int[] vetor, int valor)
        {
            return Array.Find(vetor, elemento => elemento == valor);
        }

        public int ObterIndice(int[] vetor, int valor)
        {
            return Array.IndexOf(vetor, valor);
        }

        public void Redimensionar(ref int[] vetor, int novoTamanho)
        {
            Array.Resize(ref vetor, novoTamanho);
        }

        public string[] ConverterParaString(int[] vetor)
        {
            return Array.ConvertAll(vetor, elemento => elemento.ToString());
        }


    }
}