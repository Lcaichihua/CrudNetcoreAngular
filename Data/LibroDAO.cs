using Entity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace Data
{
   public class LibroDAO
    {
        string connectionString = "Data Source=LAPTOP-JEUH607Q\\SQLEXPRESS;Initial Catalog=test_caichihua;integrated security=True; ";
        // record all 
        public IEnumerable<Libro> GetAllLibro()
        {
            try
            {
                List<Libro> lstlibros = new List<Libro>();
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand("spGetAllLibro", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    con.Open();
                    SqlDataReader rdr = cmd.ExecuteReader();
                    while (rdr.Read())
                    {
                        Libro libro = new Libro();
                        libro.id_libro = Convert.ToInt32(rdr["id_libro"]);
                        libro.descripcion= rdr["descripcion"].ToString();
                        libro.asignatura = Convert.ToInt32(rdr["asignatura"]);
                        libro.stock = Convert.ToInt32(rdr["stock"]);

                        lstlibros.Add(libro);
                    }
                    con.Close();
                }
                return lstlibros;
            }
            catch
            {
                throw;
            }
        }
        // add
        public int AddLibro(Libro libro)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand("spAddLibro", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@descripcion", libro.descripcion);
                    cmd.Parameters.AddWithValue("@asignatura", libro.asignatura);
                    cmd.Parameters.AddWithValue("@stock", libro.stock);
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
        public int UpdateLibro(Libro libro)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand("spUpdateLibro", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id_asig", libro.id_libro);
                    cmd.Parameters.AddWithValue("@descripcion", libro.descripcion);
                    cmd.Parameters.AddWithValue("@asignatura", libro.asignatura);
                    cmd.Parameters.AddWithValue("@stock", libro.stock);


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
        public Libro LibroGet(int id)
        {
            try
            {
                Libro libro = new Libro();
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    string sqlQuery = "SELECT * FROM TB_Libro WHERE id_libro= " + id;
                    SqlCommand cmd = new SqlCommand(sqlQuery, con);
                    con.Open();
                    SqlDataReader rdr = cmd.ExecuteReader();
                    while (rdr.Read())
                    {
                        libro.id_libro = Convert.ToInt32(rdr["id_libro"]);
                        libro.descripcion = rdr["descripcion"].ToString();
                        
                    }
                }
                return libro;
            }
            catch
            {
                throw;
            }
        }
        //To Delete the record on a particular employee
        public int DelLibro(int id)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand("spDeleteLibro", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id_libro", id);
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
