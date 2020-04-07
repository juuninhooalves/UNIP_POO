using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetanguloEncapsulamento
{
    class MetodoProfessor
    {
        private double ladoA;
        private double ladoB;
        private double perimetro;
        private double area;

        public MetodoProfessor()
        {
            this.ladoA = 0;
            this.ladoB = 0;
            this.perimetro = 0;
            this.area = 0;
        }

        public MetodoProfessor(double ladoA, double ladoB)
        {
            this.ladoA = 0;
            this.ladoB = 0;
            this.perimetro = 0;
            this.area = 0;
        }

        public MetodoProfessor(double ladoA, double ladoB, double ladoC)
        {
            this.ladoA = 0;
            this.ladoB = 0;
            this.perimetro = 0;
            this.area = 0;
        }

        public void setLadoA(double ladoA)
        {
            this.ladoA = ladoA;
        }
        public double getLadoA()
        {
            return ladoA;
        }
        public void setLadoB(double ladoB)
        {
            this.ladoB = ladoB;
        }
        public double getLadoB()
        {
            return ladoB;
        }

        public double getPerimetro()
        {
            return perimetro;
        }

        public double getArea()
        {
            return area;
        }

        public void calcularPerimetro()
        {
            perimetro = ladoA * 2 + ladoB * 2;
        }
        public void calcularArea()
        {
            area = ladoA * ladoB;
        }
    }
}