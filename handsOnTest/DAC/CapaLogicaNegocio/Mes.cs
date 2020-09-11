using HandsOnTest.CapaAccesoDatos;
using HandsOnTest.CapaEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HandsOnTest.CapaLogicaNegocio
{
    public class Mes : Empleados
    {
        public override int SalarioAnual()
        {
            int MonthtlySalary = 80000;
            return MonthtlySalary * 12;

        }
    }
}