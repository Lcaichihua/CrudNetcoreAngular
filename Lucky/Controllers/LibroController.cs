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

    public class LibroController : ControllerBase
    {

        LibroBL objlib = new LibroBL();
    

        [HttpGet]
        [Route("api/Libro/Index")]
        public IEnumerable<Libro> Index()
        {
            return objlib.fnListaLibroseBL();
        }

        [HttpPost]
        [Route("api/Libro/Create")]
        public int Create([FromBody] Libro libro)
        {
            return objlib.fnAddLibro(libro);
        }

        [HttpGet]
        [Route("api/Libro/Details/{id}")]
        public Libro Details(int id)
        {
            return objlib.fnLibroGet(id);
        }

        [HttpPut]
        [Route("api/Libro/Edit")]
        public int Edit([FromBody] Libro libro)
        {
            return objlib.fnUptLibro(libro);
        }

        [HttpDelete]
        [Route("api/Libro/Delete/{id}")]
        public int Delete(int id)
        {
            return objlib.fnDelLibro(id);
        }

    }
}
