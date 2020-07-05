using System;

namespace EstruturaDoProgramam
{
    public class Pilha
    {
        Posicao primeiro;

        public void Empilha(object item)
        {
            primeiro = new Posicao(primeiro, item);
        }

        public object Desempilha()
        {
            if (primeiro == null)
            {
                throw new InvalidOperationException();
            }
            object resultado = primeiro.item;
            primeiro = primeiro.proximo;
            return resultado;
        }

        internal bool Desmpilha()
        {
            throw new NotImplementedException();
        }

        private class Posicao
        {
            private Posicao primeiro;
            private object item;

            public Posicao(Posicao primeiro, object item)
            {
                this.primeiro = primeiro;
                this.item = item;
            }

            public Posicao proximo { get; internal set; }
        }
    }
}