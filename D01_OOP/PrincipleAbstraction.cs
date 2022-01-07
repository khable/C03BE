using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D01_OOP
{
    //Classe abstrata : 
    //nao pode ser instanciada
    //pode ter membros abstratos e nao abstratos
    //tem de ser herdada para podermos trabalhar com ela
    //Uma classe abstrata nao pode ser instanciada
    //Tem de ser herdada e todos os membros abstratos tem de ser implementados
    abstract class AbstractAnimal
    {

        #region Properties

        public abstract string Name { get; set; }

        public string Color { get; set; }

        public abstract bool Pet { get; set; }

        #endregion

        #region Methods
        //um metodo abstrato nao pode ser implementado na classe abstrata
        //tem de ser implementado na classe derivada com override e com a mesma assinatura
        public void Register()
        {
            Console.WriteLine($"\nA registar o Animal.\n");
        }


        public abstract void List(string name);


        public abstract void Domesticate();

        #endregion
    }


    class VertebrateAnimal : AbstractAnimal

    {

        #region Constants
        public const string TYPE = "Vertebrado ";

        #endregion


        #region Properties
        public override string Name { get; set; }
        public override bool Pet { get; set; }
        #endregion

        #region Methods

        public override void Domesticate()
        {

        }

        public override void List(string name)
        {
            //implementar

            Name = name;
            Console.WriteLine($"Animal :  {Name} ({TYPE})");


        }
        #endregion

    }


    class InvertebrateAnimal : AbstractAnimal
    {

        #region Constants

        public const string TYPE2 = "Invertebrado";
        #endregion


        #region Properties
        public override string Name { get; set; }
        public override bool Pet { get; set; }
        #endregion

        #region Methods

        public override void Domesticate()
        {

        }

        public override void List(string name)
        {
            //implementar



            Name = name;
            Console.WriteLine($"Animal :  {Name} ({TYPE2})");
        }
        #endregion


    }
}
