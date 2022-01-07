﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E04_CalculadoraExtra_Interface
{
    class CalculadoraSimples : ICalculadoraExtra

    {
        #region Properties
        public double Valor1 { get; set; }
        public double Valor2 { get; set; }
        public double Valor3 { get; set; }
        public double Valor4 { get; set; }
        public double Resultado { get; set; }
        #endregion

        #region Methods
        public double Divisao(double v1, double v2)
        {
            Valor1 = v1;
            Valor2 = v2;
            Resultado = v1 / v2;
            return Resultado;
        }

        public double Multiplicacao(double v1, double v2)
        {
            Valor1 = v1;
            Valor2 = v2;
            Resultado = v1 * v2;
            return Resultado;
        }

        public double Multiplicacao(double v1, double v2, double v3)
        {
            Valor1 = v1;
            Valor2 = v2;
            Valor3 = v3;

            Resultado = v1 * v2 * v3;
            return Resultado;
        }

        public double Multiplicacao(double v1, double v2 , double v3 , double v4)
        {
            Valor1 = v1;
            Valor2 = v2;
            Valor3 = v3;
            Valor4 = v4;
            Resultado = v1 * v2 * v3 * v4;
            return Resultado;
        }

        public double Soma(double v1, double v2)
        {
            Valor1 = v1;
            Valor2 = v2;
            Resultado = v1 + v2;
            return Resultado;
        }

        public double Soma(double v1, double v2, double v3)
        {
            Valor1 = v1;
            Valor2 = v2;
            Valor3 = v3;
            Resultado = v1 + v2 + v3;
            return Resultado;
        }

        public double Subtracao(double v1, double v2)
        {
            Valor1 = v1;
            Valor2 = v2;
            Resultado = v1 - v2;
            return Resultado;
        }

        public double RaizQuadrada(double v1)
        {
            Valor1 = v1;

            Resultado = Math.Sqrt(Valor1);
            return Resultado;
        }

        #endregion

    }
}
