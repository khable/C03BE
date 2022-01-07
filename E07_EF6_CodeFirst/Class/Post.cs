using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E07_EF6_CodeFirst
{   //tabela n 
    class Post
    {


        #region Properties
        //Scalar Properties
        public int PostID { get; set; } //Pk + identyty
        public int BlogID { get; set; } // FK
        public int CommentID { get; set; }
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }
        [Required]
        [MaxLength(200)]
        public string Content { get; set; }
        public DateTime PostDate { get; set; }


        //Navigation property
        //1 post pode ter somente 1  blog
        public virtual Blog Blog { get; set; }
        
        #endregion



        #region Methods
        public static void InsertPost()
        {

            using (var db = new BlogContext())
            {
                string newPost ,newContent;
                Post post = new Post();

                //vou ter de pedir ao user para escolher o blog onde vai inserir este novo Post

                //1 listar os blogs
                Console.Clear();
                Console.WriteLine("------------------------\nLista de blogs disponiveis\n-------------------");


                Console.WriteLine("Lista de blogs disponiveis");
                Blog.ListBlog();
                Console.WriteLine("--------------------------------------");


                //2 pedir ao user para escolher 1 blog pelo nº




                //3 verificar se esse nº de blog exista
                //3.1 obrigar o user a escolher 1 nº de blog existente(while)
                //ou
                //sair e dizer ao user para repetir a operaçao

                //3.2 se existir, pedir os outros dados do post e gravar



                Console.Write("NovoPost: ");
                newPost = Console.ReadLine();

                Console.Write("Texto: ");
                newContent = Console.ReadLine();



                post.BlogID = 1; //atenção !!! implementar 
                post.Name = newPost;
                post.Content = newContent;
                db.Post.Add(post);

                db.SaveChanges();
            }
        }


        public static void ListPost()
        {
            using (var db = new BlogContext())
            {
                var query = db.Post.Select(r => r).OrderBy(r => r.PostID);
                Console.Clear();
                Console.WriteLine("\n\n-----------------------------------------------------------\nPosts\n------------------------------------");
                

                foreach (var item in query)
                {
                    Console.WriteLine($"{item.BlogID} : {item.Name}");
                }
            }


        }
        #endregion
    }
}
