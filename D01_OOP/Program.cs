using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D01_OOP
{
    class Program
    {
        static void Main(string[] args)
        {


            #region Inheritance

           
            #region Create objects
            Person person1 = new Person();
            Person person2 = new Person("Carlos", "Ferreira");
            Student student1 = new Student();
            Student student2 = new Student("Abel", "Ribeiro");
            Student student3 = new Student("Carlos", "Ferreira", "Medecin", "Gaia");

            #endregion

            #region Call Methods

            person2.ListFullName();
            student3.ListAll();

            #endregion


            #endregion

            #region Encapsulation
            /* PrincipleEncapsulation encapsulation01= new PrincipleEncapsulation();
             encapsulation01.Name = "Carlos";
             encapsulation01.Surname = "Ribeiro";
             encapsulation01.List01();

             */
            #endregion

            #region PrinciplePolimorphism
            PrinciplePolimorphism baseclass01 = new PrinciplePolimorphism();
            PrinciplePolimorphismDerived derivedClass01 = new PrinciplePolimorphismDerived();            


            baseclass01.ListFullName();
            baseclass01.ListFullName("Manuel" , "Ferreira");
            baseclass01.ListFullNameUS("Ferreira", "Manuel");
            baseclass01.ListAll("Manuel", "Ribeiro", "Espinho");
            derivedClass01.ListAll("Manuel", "Ribeiro", "Espinho");
            #endregion

            #region Abstraction
            AbstractAnimal vertebrateAnimal = new VertebrateAnimal();
            AbstractAnimal invertebrateAnimal = new InvertebrateAnimal();

            vertebrateAnimal.Register();
            vertebrateAnimal.List("Gato");

            invertebrateAnimal.Register();
            invertebrateAnimal.List("Cao");


            #endregion


            Console.ReadKey();
        }
    }
}
