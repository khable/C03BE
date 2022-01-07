using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E07_EF6_CodeFirst
{  //tabela 1
    class Blog
    {

        #region Properties
        //scalar properties
        public int BlogID { get; set; } //PK + identity 
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }
        public string URL { get; set; }

        // 1 blog pode ter uma lista(n) de posts
        //Navigation property 
        public virtual List<Post> Posts { get; set; }
        #endregion
       




        #region Methods


        public static void InsertBlog()
        {
            using (var db = new BlogContext())
            {
                string newBlog;
                Blog blog = new Blog();

                Console.WriteLine("-------------------\nNovo Blog\n---------------------------");
                Console.Write("Blog: ");
                newBlog = Console.ReadLine();

                blog.Name = newBlog;

                db.Blog.Add(blog);

                db.SaveChanges();
            }
        }

        public static void ListBlog()
        {
           

            using (var db = new BlogContext())
            {
                var query = db.Blog.Select(r => r).OrderBy(r => r.BlogID);
               
                Console.WriteLine("\n\n-----------------------------------------------------------\nBlogs\n------------------------------------");

                foreach (var item in query)
                {
                    Console.WriteLine($"{item.BlogID} : {item.Name}");
                }
                Console.WriteLine("\n\n");
                Console.ReadKey();
            }
        }

        #endregion
    }
}
