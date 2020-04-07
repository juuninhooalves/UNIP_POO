using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculoIMC
{
    class Program
    {
        static void Main(string[] args)
        {

            DadosIMC dados = new DadosIMC();


            Console.WriteLine("Calculo de Indice de Massa Corporal");
            Console.WriteLine();


            Console.Write("Informe seu Peso: ");
            dados.Peso = (Convert.ToDouble(Console.ReadLine()));

            Console.Write("Informe sua Altura: ");
            dados.Altura = (Convert.ToDouble(Console.ReadLine()));

            Console.Write("Informe seu sexo: ");
            dados.Sexo = (Convert.ToString(Console.ReadLine()));


            //Processamento
            dados.CalcularIMC();
            dados.ClassificacaoIMC();
            Console.Clear();


            Console.WriteLine();
            Console.WriteLine("=========== Resultado IMC ==========");
            Console.WriteLine();
            Console.WriteLine("Peso           : " + dados.Peso);
            Console.WriteLine("Altura         : " + dados.Altura);
            Console.WriteLine("Sexo           : " + dados.Sexo);
            Console.WriteLine("IMC            : " + dados.IMC);
            Console.WriteLine("Classificação  : " + dados.Classificacao);
            Console.WriteLine("==================================");

            Console.ReadKey();

            //Console.WriteLine("Line 1");
            //Console.SetCursorPosition(Console.CursorLeft, Console.CursorTop - 1);
            //Console.WriteLine("Line 2");
            //Console.ReadKey();
        }
    }
}
