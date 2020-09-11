using HandsOnTest.CapaEntidades;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

namespace HandsOnTest.CapaAccesoDatos
{
    public class HomeController : Controller
    {
        public async System.Threading.Tasks.Task<ActionResult> Index()
        {
            //http://masglobaltestapi.azurewebsites.net/api/Employees
            var httpClient = new HttpClient();
            var json = await httpClient.GetStringAsync("http://masglobaltestapi.azurewebsites.net/api/Employees");
            var ListaEmpleados = JsonConvert.DeserializeObject<List<Empleados>>(json);

            return View(ListaEmpleados);
        }
    }
}