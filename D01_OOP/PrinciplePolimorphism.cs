using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D01_OOP
{
    class PrinciplePolimorphism
    {

        #region Properties
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Location { get; set; }
        #endregion

        #region Methods
        //Overloading de metodos
        //Method overload == mesmo metodo com assinaturas diferentes
        public void ListFullName()
        {
            
            Console.WriteLine($"Fullname: {Name} {Surname}");
        }
       
        public void ListFullName(string name , string surname)
        {
            Name = name;
            Surname = surname;
            Console.WriteLine($"Fullname: {Name} {Surname} ");
        }

        public void ListFullNameUS(string surname, string name)
        {
            Name = name;
            Surname = surname;

            Console.WriteLine($"Fullname:  {Surname}  {Name}");
        }

        public virtual void ListAll(string name, string surname, string location)
        {
            Name = name;
            Surname = surname;
            Location = location;

            Console.WriteLine($"{Name} {Surname} mora em {Location}.");
        }

        #endregion


      
    }

    class PrinciplePolimorphismDerived : PrinciplePolimorphism
    {
        //Overriding de metodos
        //Method override = sobrescrita de metodos  --> metodos com a mesma assinatura ,  mas diferentes implementações
        #region Methods
        //Marca o  Metodo para overriding com o override (classe derivada)
        public override void ListAll(string name, string surname, string location)
        {
            Name = name;
            Surname = surname;
            Location = location;

            Console.WriteLine($"{Name} {Surname} lives in {Location}.");
        }
        #endregion




    }
}
