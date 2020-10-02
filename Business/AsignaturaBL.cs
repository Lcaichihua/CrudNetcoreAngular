using Data;
using Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business
{
    public class AsignaturaBL
    {
        //instanciando Dao
        AsignaturaDAO dao = new AsignaturaDAO();

        public IEnumerable<Asignatura> fnListaClienteBL()
        {
            return dao.GetAllAsignatura();
        }

        public int fnAddAsig(Asignatura asig)
        {
            return dao.AddAsignatura(asig);
        }

        public int fnUptAsig(Asignatura asig) {
            return dao.UpdateAsignatura(asig);
        }
        public Asignatura fnAsigGet(int id)
        {
            return dao.AsigGet(id);
        }
        public int fnDelAsignatura(int id)
        {
            return dao.DelAsignatura(id);
        }
        }
}
