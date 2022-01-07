using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E05_Pessoas_Interface_V2
{
    class FuncionarioNormal : Funcionario
    {


        #region Properties
        public double horasextra { get; set; }
        #endregion

        #region Methods
        public double HorasExtra(double horasextra1)
        {
            horasextra = horasextra1;
            return horasextra;
        }
        #endregion

    }
}