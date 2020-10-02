using Data;
using Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business
{
    public class LibroBL
    {
        //instanciando Dao
        LibroDAO dao = new LibroDAO();

        public IEnumerable<Libro> fnListaLibroseBL()
        {
            return dao.GetAllLibro();
        }

        public int fnAddLibro(Libro libro)
        {
            return dao.AddLibro(libro);
        }

        public int fnUptLibro(Libro libro) {
            return dao.UpdateLibro(libro);
        }
        public Libro fnLibroGet(int id)
        {
            return dao.LibroGet(id);
        }
        public int fnDelLibro(int id)
        {
            return dao.DelLibro(id);
        }
        }
}
