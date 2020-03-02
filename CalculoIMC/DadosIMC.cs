using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculoIMC
{
    public class DadosIMC
    {
        private double peso;
        private double altura;
        private double imc;
        private string sexo;
        private string classificacao;

       public DadosIMC() 
        {
            this.peso = 0;
            this.altura = 0;
            this.imc = 0;
            this.sexo = "";
            this.classificacao = "";
        }


        public void setPeso(double peso)
        {
            this.peso = peso;
        }

        public double getPeso()
        {
            return peso;
        }

        public void setAltura(double altura)
        {
            this.altura = altura;
        }

        public double getAltura()
        {
            return altura;
        }

        public void setSexo(string sexo)

        {
            var upSexo = sexo.Substring(0, 1).ToUpper();

            if (upSexo == "F"  || upSexo == "M")
            {
                this.sexo = upSexo;
            }
            else 
            {
                    Console.SetCursorPosition(Console.CursorLeft, Console.CursorTop - 1);
                    Console.Write("Informe o sexo corretamente: ");
                    setSexo(Convert.ToString(Console.ReadLine()));
            }
        }

        public string getSexo()
        {
            return sexo;
        }

        public double IMC()
        {
            return imc;
        }

        public string getClassificacao()
        {
            return classificacao;
        }


        public void CalcularIMC()
        {
            imc = peso / (altura * altura);
        }

        public double getIMC()
        {
            return imc;
        }


        //Calculos IMC

        public void ClassificacaoIMC()
        {

            var upSexo = sexo.Substring(0, 1).ToUpper();


            if (upSexo == "F")
            {
                if(imc < 19.5)
                {
                    classificacao = "Abaixo do Peso";
                }
                else if(imc >= 19.5 && imc < 25.7)
                {
                    classificacao = "No peso normal";
                }
                else if (imc >= 25.7 && imc < 27.3)
                {
                    classificacao = "Marginalmente acima do peso";
                }
                else if (imc >= 27.3 && imc < 32.3)
                {
                    classificacao = "Acima do peso";
                }
                else
                {
                    classificacao = "Obeso";
                }

                sexo = "Feminino";
            }

            else if (upSexo == "M")
            {
                if (imc < 20.7)
                {
                    classificacao = "Abaixo do Peso";
                }
                else if (imc >= 20.7 && imc < 26.4)
                {
                    classificacao = "No peso normal";
                }
                else if (imc >= 26.4 && imc < 27.8)
                {
                    classificacao = "Marginalmente acima do peso";
                }
                else if (imc >= 27.8 && imc < 31.1)
                {
                    classificacao = "Acima do peso";
                }
                else
                {
                    classificacao = "Obeso";
                }

                sexo = "Masculino";
            }

            else
            {
                Console.WriteLine("Algo deu errado, tente novamente!");
            }
        }
    }
}
