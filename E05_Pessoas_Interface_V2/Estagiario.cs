using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E05_Pessoas_Interface_V2
{
    class Estagiario : Funcionario
    {
        #region Properties
        public double faltadehorasinjustificadas { get; set; }
        #endregion

        #region Methods
        public double FaltaDeHorasInjustificadas(double faltadehorasinjustificadas1)
        {
            faltadehorasinjustificadas = faltadehorasinjustificadas1;
            return faltadehorasinjustificadas;
        }
        #endregion
    }
}
