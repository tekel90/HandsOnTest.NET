using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HandsOnTest.CapaAccesoDatos;
using HandsOnTest.CapaEntidades;

namespace HandsOnTest.CapaLogicaNegocio
{
    public class Hora : Empleados
    {
        public override int SalarioAnual()
        {
            int HourlySalary = 60000;
            return 120 * HourlySalary * 12;
        }
    }
}