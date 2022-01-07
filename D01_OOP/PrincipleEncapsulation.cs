using System;

namespace D01_OOP
{

    //Acess Modifiers : public , private
    //Por defeito as classes sao public ...  - ou seja ,  podem ser usadas noutras classes

    //Encapsulation
    //
    //variaveis + fields



    class PrincipleEncapsulation

    {

        #region Variáveis (publicas á classe , privadas fora da classe
        int value01 = 0;
        #endregion

        #region Fields(variavel de suporte á propriedade)
        private string _name;
        #endregion



        #region Properties
        //Classic (requer um field privado de suporte)
        //Surname = "lela"; // set
        //Console.WriteLine(Surname); // get
        public string Name
        {
            get
            {
                return _name;
            }

            set
            {
                _name = value;
            }
        }


        //Auto-Implemented
        public string Surname { get; set; }


        //Bodied expression (lambda operator =>)

        #endregion

        #region Methods
        public void List01()
        {

            Console.WriteLine($"{Name}  {Surname}");

        }


        //Por omissao do acess modifier , o metodo e private
        //No entanto , o metodo devia ser public
        void List02()
        {

        }
        #endregion


    }
}
