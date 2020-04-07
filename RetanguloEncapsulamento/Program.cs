using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetanguloEncapsulamento
{
    class Program
    {
        static void Main(string[] args)
        {
            DadosRetangulo Retangulo = new DadosRetangulo();

            //Entrada de dados
            Console.WriteLine("Retangulo: Calcula perimetro e area");
            Console.WriteLine();

            Console.WriteLine("Digite o lado A: ");
            Retangulo.LadoA = (Convert.ToDouble(Console.ReadLine()));
            Console.WriteLine("Digite o lado B: ");
            Retangulo.LadoB = (Convert.ToDouble(Console.ReadLine()));

            // processamento

           Retangulo.calcularPerimetro();
           Retangulo.calcularArea();


            Console.WriteLine();
            Console.WriteLine("  ===== RETANGULO ============");
            Console.WriteLine("Lado A    = " + Retangulo.LadoA);
            Console.WriteLine("Lado B    = " + Retangulo.LadoB);
            Console.WriteLine("Perimetro = " + Retangulo.Perimetro);
            Console.WriteLine("Area      = " + Retangulo.Area);

            Console.WriteLine("Tecle <Enter> para continuar: ");
            Console.ReadKey();
        }
    }
}
