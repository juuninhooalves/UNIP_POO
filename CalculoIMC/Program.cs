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
            dados.setPeso(Convert.ToDouble(Console.ReadLine()));

            Console.Write("Informe sua Altura: ");
            dados.setAltura(Convert.ToDouble(Console.ReadLine()));

            Console.Write("Informe seu sexo: ");
            dados.setSexo(Convert.ToString(Console.ReadLine()));


            //Processamento
            dados.CalcularIMC();
            dados.ClassificacaoIMC();
            Console.Clear();


            Console.WriteLine();
            Console.WriteLine("=========== Resultado IMC ==========");
            Console.WriteLine();
            Console.WriteLine("Peso           : " + dados.getPeso());
            Console.WriteLine("Altura         : " + dados.getAltura());
            Console.WriteLine("Sexo           : " + dados.getSexo());
            Console.WriteLine("IMC            : " + dados.getIMC());
            Console.WriteLine("Classificação  : " + dados.getClassificacao());
            Console.WriteLine("==================================");

            Console.ReadKey();

            //Console.WriteLine("Line 1");
            //Console.SetCursorPosition(Console.CursorLeft, Console.CursorTop - 1);
            //Console.WriteLine("Line 2");
            //Console.ReadKey();
        }
    }
}
