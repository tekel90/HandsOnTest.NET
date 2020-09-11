using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HandsOnTest.CapaEntidades
{
    public class Empleados
    {
        /*
        id (integer, optional),
        name (string, optional),
        contractTypeName (string, optional),
        roleId (integer, optional),
        roleName (string, optional),
        roleDescription (string, optional),
        hourlySalary (number, optional),
        monthlySalary (number, optional)
         */

        public int Id { get; set; }
        public int RoleId { get; set; }
        public string Name { get; set; }
        public string ContractTypeName { get; set; }
        public string RoleName { get; set; }
        public string RoleDescription { get; set; }
        public double HourlySalary { get; set; }
        public double MonthlySalary { get; set; }


    }
}