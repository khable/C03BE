using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E05_Pessoas_Interface
{
    class Funcionario : IPessoa
    {

        #region Properties
        public string nome { get; set; }
        public double idade { get; set; }
        public string morada { get; set; }
        public string email { get; set; }
        public double telemovel { get; set; }
        private string contacto;
        public double anosservico { get; set; }
        public double codigopostal { get; set; }
        public string habilitacoes { get; set; }
        #endregion

        #region Methods
        
        public string Nome(string nome1)
        {
            nome = nome1;
            return nome;

        }

        public double Idade(double idade1)
        {
            idade = idade1;
            return idade;
        }
       
        public string Morada(string morada1)
        {
            morada = morada1;
            return morada;
        }

        public string Contacto(string email1, double telemovel1)
        {
            email = email1;
            telemovel = telemovel1;
            contacto = $"{email1} {telemovel1} ";
            return contacto;
        }

        public double AnosServico(double as1)
        {
            anosservico = as1;
            return anosservico;

        }

        public double CodigoPostal(double cp)
        {
            codigopostal = cp;
            return codigopostal;
        }

        public string Habilitacoes(string habilitacoes1)
        {
            habilitacoes = habilitacoes1;
            return habilitacoes;
        }
        #endregion


    }
}
