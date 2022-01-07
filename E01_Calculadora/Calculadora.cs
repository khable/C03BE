using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E01_Calculadora
{
    abstract class Calculadora
    {

        #region Properties

        public double Valor1 { get; set; }
        public double Valor2 { get; set; }
        public string Operador { get; set; }
        public double Resultado { get; set; }
        #endregion


        #region Constructor

        public CalculadoraSimples(double valor1, double valor2)
        {
            Valor1 = 0;
            Valor2 = 0;
            Operador = string.Empty;
            Resultado = 0;

        }
        public CalculadoraSimples(double valor1, double valor2, string operador)
        {
            Valor1 = valor1;
            Valor2 = valor2;
            Operador = operador;
            Resultado = 0;

        }



        #endregion



        #region Methods

        public void MostrarOperadores()
        {
            Console.Write("Operações:\n");

            //Console.Write


            string[] operadores = new string[]
                {
            "[+]",
            "[-]",
            "[*]" ,
            "[/]"
           };
            foreach (var escreverOps in operadores)
            {
                Console.WriteLine(escreverOps);
            }



        }


        public void LerValor1()
        {
            Console.Write("Valor 1 : ");
            Valor1 = Double.Parse(Console.ReadLine());
        }

        public void LerValor2()
        {
            Console.Write("Valor 2 : ");
            Valor2 = Double.Parse(Console.ReadLine());
        }

        public void LerOperador()
        {
            Console.Write("O operador é :  ");
            Operador = Console.ReadLine();

        }

        public bool VerificarOperador()
        {
            bool validado;

            switch (Operador)
            {
                case "+":
                    validado = true;
                    break;
                case "-":
                    validado = true;
                    break;
                case "*":
                    validado = true;
                    break;
                case "/":
                    validado = true;
                    break;
                default:
                    validado = false;
                    break;
            }

            return validado;
        }

        public void Soma()
        {
            Resultado = Valor1 + Valor2;
        }

        public void Subtracao()
        {
            Resultado = Valor1 - Valor2;
        }

        public void Multiplicacao()
        {
            Resultado = Valor1 * Valor2;
        }

        public void Divisao()
        {

            //Ainda temos de verificar o 2 operando !!!


            Resultado = Valor1 / Valor2;

            if (Valor2 == 0)
            {
                Resultado = 0;
            }
            else
            {
                Resultado = Valor1 / Valor2;
            }
        }


        public void TestarOperador()
        {
            switch (Operador)
            {
                case "+":
                    Soma();
                    break;
                case "-":
                    Subtracao();
                    break;
                case "*":
                    Multiplicacao();
                    break;
                case "/":
                    Divisao();
                    break;

                default:
                    Console.WriteLine("Operador Inválido");
                    break;



            }
        }

        public void RealizarOperacao()
        {


        }

        public void EscreverResultado()
        {
            Console.WriteLine($"\nO resultado é : {Resultado}");
        }



        #endregion


    }

}

