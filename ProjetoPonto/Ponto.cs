using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoPonto
{
    public class Ponto
    {
        private int x;
        private int y;
        //3.21
        public string descricao; // Novo atributo

        // Propriedade para o atributo x
        public int X
        {
            get { return x; }
            set { x = value; }
        }

        // Propriedade para o atributo y
        public int Y
        {
            get { return y; }
            set { y = value; }
        }

        // Propriedade para o atributo descricao
        public string Descricao
        {
            get { return descricao; }
            set { descricao = value; }
        }

        public int V1 { get; }
        public int V2 { get; }

        // metodo construtor
        public Ponto()
        {
            x = 0;
            y = 0;
            descricao = "Sem descrição";
        }

        public Ponto(int xInicial, int yInicial, string descricaoInicial)
        {
            x = xInicial;
            y = yInicial;
            descricao = descricaoInicial; // Inicialização do novo atributo
        }

        public Ponto(int v1, int v2)
        {
            V1 = v1;
            V2 = v2;
        }

        // fim do construtor

        public void IncrementarCoordenadas(int deltaX, int deltaY)
        {
            x = x + deltaX;
            y = y + deltaY;
        }
        public void ImprimirCoordenadas()
        {
            // imprime as coordenadas x e y e descricao
            Console.WriteLine("Descrição: {0}, x={1}, y={2}", descricao, x, y);
        }
        public void ZerarCoordenadas()
        {
            x = 0;
            y = 0;
        }

        public override string ToString()
        {
            return $"Descrição: {descricao}, x={x}, y={y}";
        }

    }
}
