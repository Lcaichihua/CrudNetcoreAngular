using Entity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace Data
{
   public class AsignaturaDAO
    {
        string connectionString = "Data Source=LAPTOP-JEUH607Q\\SQLEXPRESS;Initial Catalog=test_caichihua;integrated security=True; ";
        // record all 
        public IEnumerable<Asignatura> GetAllAsignatura()
        {
            try
            {
                List<Asignatura> lstasign = new List<Asignatura>();
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand("spGetAllAsignatura", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    con.Open();
                    SqlDataReader rdr = cmd.ExecuteReader();
                    while (rdr.Read())
                    {
                        Asignatura employee = new Asignatura();
                        employee.id_asig = Convert.ToInt32(rdr["id_asig"]);
                        employee.descripcion= rdr["descripcion"].ToString();

                        lstasign.Add(employee);
                    }
                    con.Close();
                }
                return lstasign;
            }
            catch
            {
                throw;
            }
        }
        // add
        public int AddAsignatura(Asignatura asignatura)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand("spAddAsignatura", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@descripcion", asignatura.descripcion);
               
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
                return 1;
            }
            catch
            {
                throw;
            }
        }
        //update
        public int UpdateAsignatura(Asignatura asignatura)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand("spUpdateAsignatura", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id_asig", asignatura.id_asig);
                    cmd.Parameters.AddWithValue("@descripcion", asignatura.descripcion);
                  
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
                return 1;
            }
            catch
            {
                throw;
            }
        }
        //Get the details of a particular employee
        public Asignatura AsigGet(int id)
        {
            try
            {
                Asignatura asig = new Asignatura();
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    string sqlQuery = "SELECT * FROM TB_Asignatura WHERE id_asig= " + id;
                    SqlCommand cmd = new SqlCommand(sqlQuery, con);
                    con.Open();
                    SqlDataReader rdr = cmd.ExecuteReader();
                    while (rdr.Read())
                    {
                        asig.id_asig = Convert.ToInt32(rdr["id_asig"]);
                        asig.descripcion = rdr["descripcion"].ToString();
                        
                    }
                }
                return asig;
            }
            catch
            {
                throw;
            }
        }
        //To Delete the record on a particular employee
        public int DelAsignatura(int id)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand("spDeleteAsignatura", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id_asig", id);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
                return 1;
            }
            catch
            {
                throw;
            }
        }


    }
}
