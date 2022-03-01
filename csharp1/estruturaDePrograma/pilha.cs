using System;

namespace EstruturaDePrograma 
{
    public class Pilha
    {
        Posicao primeiro;   // declara primeiro como um objeto do tipo Posicao
                            // primeiro é um objeto restrito ao escopo da classe Pilha
        public void Empilha (object item)    
        {
            primeiro = new Posicao(primeiro,item);
        }

        public object Desempilha()
        {
            if (primeiro == null)
            {
                throw new InvalidOperationException("A pilha está vazia!");
            }
            object resultado = primeiro.item;
            primeiro = primeiro.proximo;
            return resultado;
        }
    }

    class Posicao
    {
        public Posicao proximo;
        public object item;
        public Posicao(Posicao proximo, object item)
        {
            this.proximo = proximo;
            this.item = item;
        }
    }
}