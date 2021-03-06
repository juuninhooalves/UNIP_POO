﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetanguloEncapsulamento
{
    public class DadosRetangulo
    {
        private double ladoA { get; set; }
        private double ladoB { get; set; }
        private double perimetro { get; set; }
        private double area { get; set; }

        public DadosRetangulo()
        {
            this.ladoA = 0;
            this.ladoB = 0;
            this.perimetro = 0;
            this.area = 0;
        }

        public DadosRetangulo(double ladoA, double ladoB)
        {
            this.ladoA = 0;
            this.ladoB = 0;
            this.perimetro = 0;
            this.area = 0;
        }

        public DadosRetangulo(double ladoA, double ladoB, double ladoC)
        {
            this.ladoA = 0;
            this.ladoB = 0;
            this.perimetro = 0;
            this.area = 0;
        }

        public double LadoA
        {
            get { return ladoA; }
            set { this.ladoA = value; }
        }

        public double LadoB
        {
            get { return ladoB; }
            set { this.ladoB = value; }
        }

        public double Perimetro
        {
            get { return perimetro; }
        }

        public double Area
        {
            get { return area; }
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
