using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;
using System.Data;
using Business;
using Entity;

namespace Lucky.Controllers
{
    public class AsignaturaController : Controller
    {
        AsignaturaBL objasig = new AsignaturaBL();

        [HttpGet]
        [Route("api/Asignatura/Index")]
        public IEnumerable<Asignatura> Index()
        {
            return objasig.fnListaClienteBL();
        }

        [HttpPost]
        [Route("api/Asignatura/Create")]
        public int Create([FromBody] Asignatura asignatura)
        {
            return objasig.fnAddAsig(asignatura);
        }

        [HttpGet]
        [Route("api/Asignatura/Details/{id}")]
        public Asignatura Details(int id)
        {
            return objasig.fnAsigGet(id);
        }

        [HttpPut]
        [Route("api/Employee/Edit")]
        public int Edit([FromBody] Asignatura asignatura)
        {
            return objasig.fnUptAsig(asignatura);
        }

        [HttpDelete]
        [Route("api/Asignatura/Delete/{id}")]
        public int Delete(int id)
        {
            return objasig.fnDelAsignatura(id);
        }



    }
}
