using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D04_LINQ
{
    class HelloWorld
    {

        #region Constructor

        #endregion

        #region Method Syntax
        public void HelloWorldMethodSyntax()
        {
            //1- criar um array de strings 
            string[] words =
            {
                "method" ,
                "hello" ,
                "worderful" ,
                "linq" ,
                "beautiful" ,
                "world"

            };

            //2. filtrar: palavras de comprimento igual a 5

            //var shortWords = words.Where(word => word.Length != 5);
            var shortWords = words.Where(word => word.Length == 5).OrderByDescending(word => word);

            //3. listar o array filtrado 
            foreach (var item in shortWords)
            {
                Console.WriteLine(item.ToUpper());
            }

          

        }
        #endregion

        #region Query Syntax
        public void HelloWorldQuerySyntax()
        {
            //1- criar um array de strings 
            string[] words =
            {
                "method" ,
                "hello" ,
                "worderful" ,
                "linq" ,
                "beautiful" ,
                "world"

            };

            //2. filtrar: palavras de comprimento igual a 5
            var shortWords =
                from word in words
                where word.Length == 5
                //orderby word descending
                select word;
           

            //3. listar o array filtrado 
            foreach (var item in shortWords)
            {
                Console.WriteLine(item.ToUpper());
            }

            Console.ReadKey();

        }

        #endregion

    }
}
