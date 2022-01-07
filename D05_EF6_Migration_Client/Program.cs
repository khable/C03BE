using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using D05_EF6_Migrations_DAL;

namespace D05_EF6_Migration_Client
{
    class Program
    {
        static void Main(string[] args)
        {

            try { 
            //Inicializar a base de dados
            Database.SetInitializer(new NullDatabaseInitializer<BibliotecaContext>());

            // inserir 1 editora
            ClientEditora.InserirEditora();

            //inserir 1 livro
            ClientLivro.InserirLivro();

            //fim
            Console.Write("Registos inseridos com sucesso!");
            Console.ReadKey();
        }
        catch (Exception)
            {
                Console.Write("Erro!");
            }


    }
}
}
