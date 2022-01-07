using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E05_Pessoas_Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            Estagiario estagiario1 = new Estagiario();
            Funcionario funcionario1 = new Funcionario();
            Cliente cliente1 = new Cliente();

            //Estagiario
            Console.WriteLine("-------------- Estagiário ---------------");
            Console.WriteLine(estagiario1.Nome("Nome: Abel"));
            Console.Write("Idade: ");
            Console.WriteLine(estagiario1.Idade(26));
            Console.WriteLine(estagiario1.Morada("Morada: Melres"));
            Console.Write("Contacto: ");
            Console.WriteLine(estagiario1.Contacto("abelkhable@hotmail.com" , 918884848));
            Console.Write("Anos de Serviço: ");
            Console.WriteLine(estagiario1.AnosServico(1));

            Console.WriteLine("\n");
            //Funcionario
            Console.WriteLine("-------------- Funcionário ---------------");
            Console.WriteLine(funcionario1.Nome("Nome: Luis"));
            Console.Write("Idade: ");
            Console.WriteLine(funcionario1.Idade(40));
            Console.WriteLine(funcionario1.Morada("Morada : Porto"));
            Console.Write("Contacto: ");
            Console.WriteLine(funcionario1.Contacto("luis@hotmail.com" , 994991844));
            Console.Write("Anos de Serviço: ");
            Console.WriteLine(funcionario1.AnosServico(25));
            Console.Write("Código Postal: ");
            Console.WriteLine(funcionario1.CodigoPostal( 4555334));
            Console.WriteLine(funcionario1.Habilitacoes("Habilitacoes: 12º ano"));

            Console.WriteLine("\n");
            //Cliente
            Console.WriteLine("-------------- Cliente ---------------");
            Console.WriteLine(cliente1.Nome("Nome :Maria"));
            Console.Write("Idade: ");
            Console.WriteLine(cliente1.Idade(27));
            Console.WriteLine(cliente1.Morada("Morada :Maia"));
            Console.Write("Contacto: ");
            Console.WriteLine(cliente1.Contacto( "Marialinda@hotmail.com"  , 958581757));
            Console.Write("Numero do Cartão: ");
            Console.WriteLine(cliente1.NumeroCartao(94841414141334));
           

            Console.ReadKey();

        }
    }
}
