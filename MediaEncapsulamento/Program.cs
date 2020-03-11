using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaEncapsulamento
{
    class Program
    {
        static void Main(string[] args)
        {
            Notas notas = new Notas();

            Console.WriteLine("Média Ponderada - UNIP");
            Console.WriteLine();
            //Input
            Console.Write("Digite a nota da sua NP1: ");
            notas.NP1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite a nota da sua NP2: ");
            notas.NP2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite a nota da sua PIM: ");
            notas.PIM = Convert.ToDouble(Console.ReadLine());

            //Processing
            notas.CalculaMedia();

            //Output
            Console.WriteLine();
            Console.WriteLine("=========== Resultado da Média ==========");
            Console.WriteLine();
            Console.WriteLine("NP1                : " + notas.NP1);
            Console.WriteLine("NP2                : " + notas.NP2);
            Console.WriteLine("PIM                : " + notas.PIM);
            Console.WriteLine("Média Final        : " + notas.MeP);
            Console.WriteLine();
            Console.WriteLine("==========================================");
            Console.WriteLine();

            Console.WriteLine("Tecle<ENTER> para continuar: ");
            Console.ReadKey();


            #region Metodo Professor 

            //Notas notas = new Notas();

            //Console.WriteLine("Média Ponderada - UNIP");
            //Console.WriteLine();

            //Console.Write("Digite a nota da sua NP1: ");
            //notas.setNP1(Convert.ToDouble(Console.ReadLine()));

            //Console.Write("Digite a nota da sua NP2: ");
            //notas.setNP2(Convert.ToDouble(Console.ReadLine()));

            //Console.Write("Digite a nota da sua PIM: ");
            //notas.setPIM(Convert.ToDouble(Console.ReadLine()));

            //notas.CalculaMedia();

            //Console.WriteLine();
            //Console.WriteLine("=========== Resultado da Média ==========");
            //Console.WriteLine();
            //Console.WriteLine("NP1                : " + notas.getNP1());
            //Console.WriteLine("NP2                : " + notas.getNP2());
            //Console.WriteLine("PIM                : " + notas.getPIM());
            //Console.WriteLine("Média Final        : " + notas.getMP());
            //Console.WriteLine();
            //Console.WriteLine("==========================================");
            //Console.WriteLine();

            //Console.WriteLine("Tecle<ENTER> para continuar: ");
            //Console.ReadKey();

            #endregion
        }
    }
}
