using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E05_Pessoas_Interface
{
    interface IPessoa
    {
        #region Properties
        string nome { get;}
        double idade{ get;}
        string morada { get;}
        string email { get; }
        double telemovel { get; }


        #endregion

        #region Methods

        string Nome(string nome1);

        double Idade(double idade1);

        string Morada(string morada1);

        string Contacto(string email1 , double telemovel1); 


        #endregion


    }
}
