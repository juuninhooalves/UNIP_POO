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
            Retangulo.ladoA = (Convert.ToDouble(Console.ReadLine()));
            Console.WriteLine("Digite o lado B: ");
            Retangulo.ladoB = (Convert.ToDouble(Console.ReadLine()));

            // processamento

           Retangulo.calcularPerimetro();
           Retangulo.calcularArea();


            Console.WriteLine();
            Console.WriteLine("  ===== RETANGULO ============");
            Console.WriteLine("Lado A    = " + Retangulo.ladoA);
            Console.WriteLine("Lado B    = " + Retangulo.ladoB);
            Console.WriteLine("Perimetro = " + Retangulo.perimetro);
            Console.WriteLine("Area      = " + Retangulo.area);

            Console.WriteLine("Tecle <Enter> para continuar: ");
            Console.ReadKey();
        }
    }
}
