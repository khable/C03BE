using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E07_EF6_CodeFirst
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                //chamar 1 metodo static
                Blog.InsertBlog();
                //Blog.ListBlog();

                Post.InsertPost();
                Post.ListPost();
                
                //chamar 1 metodo the instancia(só void)
               // Blog blog01 = new Blog();
               // blog01.ListBlog();

                
                //ToDo: implementar inserir e listar posts

            }
            catch (Exception)
            {
                Console.WriteLine("\n\n\nAtencion , an error as occurred");
                //throw;

            }

            Console.ReadKey();
        }
        }
    }

