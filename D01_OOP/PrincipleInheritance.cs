using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D01_OOP
{
    class PrincipleInheritance
    {
        #region Properties
        public string Name { get; set; }
        #endregion

        #region Methods

        public void ListName()
        {
            Console.WriteLine($"Name: {Name}");
        }

        #endregion

    }

    class InheritanceChild : PrincipleInheritance
    {
        #region Properties
        public string Surname { get; set; }
        #endregion

        #region Methods

        public void ListSurname()
        {
            Console.WriteLine($"Surname : {Surname} ");
        }
        #endregion
    }


    //properties : name , surname , fullname
    //Constructors : vazio ,passar todos os valores 
    //methods : listfullname
    class Person
    {


        #region Properties
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Fullname { get; set; }

        #endregion

        #region Constructors
        public Person()
        {
            Name = string.Empty;
            Surname = string.Empty;
            Fullname = string.Empty;
        }

        public Person(string name, string surname)
        {
            Name = name;
            Surname = surname;
            Fullname = $"{Name} {Surname}";
        }
        #endregion

        #region Methods

        public void ListFullName()
        {
            Fullname = $"{Name} {Surname}";
            Console.WriteLine($"Fullname: {Fullname}");
        }

        #endregion


    }



    //properties - course , location
    //Constructors
    //Method - listall 
    class Student : Person
    {
        #region Properties
        public string Course { get; set; }
        public string Location { get; set; }
        #endregion

        #region Constructor
        //mapear este constructor para o 1º da base class
        public Student() : base()
        {

        }
        // mapear este construtor para o 2º da base class
        public Student(string name, string surname) : base(name, surname)
        {


        }

        //este e o novo construtor da nova class

        public Student(string name, string surname, string course, string location)
        {
            Name = name;
            Surname = surname;
            Fullname = $"{Name} {Surname}";
            Course = course;
            Location = location;
        }
        #endregion

        #region Methods

        public void ListAll()
        {
            Console.WriteLine($"\n O formando {Fullname} está a estudar o curso de {Course} na faculdade de {Location}");
            Console.WriteLine($"\n O formando {Name} {Surname}  está a estudar o curso de {Course} na faculdade de {Location}");
        }

        #endregion
    }

}
