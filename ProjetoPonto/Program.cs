using ProjetoPonto;
using System.Collections;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Início do main...");

        ArrayList pontos = new ArrayList(); // Declara o ArrayList
        bool continuar = true;

        while (continuar)
        {
            Console.Write("Informe a coordenada x: ");
            if (!int.TryParse(Console.ReadLine(), out int x) || x < 0)
            {
                continuar = false;
                break;
            }

            Console.Write("Informe a coordenada y: ");
            if (!int.TryParse(Console.ReadLine(), out int y) || y < 0)
            {
                continuar = false;
                break;
            }

            Ponto ponto = new Ponto(x, y, $"Ponto ({x}, {y})");
            pontos.Add(ponto);
        }

        Console.WriteLine($"Total de pontos instanciados: {pontos.Count}");
        foreach (Ponto ponto in pontos)
        {
            Console.WriteLine(ponto.ToString());
        }

        Console.WriteLine("Fim do main...");
    }
}