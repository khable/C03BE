using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D02_Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {

            User user1 = new User("Antonio" , "12345");

            User user2 = new User("Carlos", "123");

            user1.Validate(user1.UserName , user1.UserPassword);
            user2.Validate(user2.UserName, user2.UserPassword);


            Console.ReadKey();
            //desafio criar um user pedindo os valores na consola


        }
    }
}
