using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using WebApplication1.Models;

namespace WebApplication1.Repository
{
    public class PreguntaRepository : IPreguntaRepository
    {
        SqlConnection cn;
        Conexion con = new Conexion();

        public List<Pregunta> PreguntaCurso(string curso)
        {
            cn = con.getCon();
            List<Pregunta> listpreg = new List<Pregunta>();
            SqlCommand cmd = new SqlCommand("GetPreguntaCurso", cn);
            cmd.CommandType = CommandType.StoredProcedure; ;
            cmd.Parameters.AddWithValue("@Curso", curso);
            SqlDataAdapter sd = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            cn.Open();
            sd.Fill(dt);
            cn.Close();

            foreach (DataRow dr in dt.Rows)
            {
                listpreg.Add(new Pregunta
                {
                    PreguntaId=Convert.ToInt32(dr["PreguntaId"]),
                    pregunta = Convert.ToString(dr["pregunta"]),
                    opt1 = Convert.ToString(dr["opt1"]),
                    opt2 = Convert.ToString(dr["opt2"]),
                    opt3 = Convert.ToString(dr["opt3"]),
                    opt4 = Convert.ToString(dr["opt4"]),
                    contador = Convert.ToString(dr["contador"]),
                    Respuesta=Convert.ToString(dr["Respuesta"])
                });
            }

            return listpreg;
        }

       

        public List<Pregunta> Reader()
        {
            cn = con.getCon();
            List<Pregunta> listpreg = new List<Pregunta>();
            SqlCommand cmd = new SqlCommand("GetPreguntas", cn);
            cmd.CommandType = CommandType.StoredProcedure; ;
            SqlDataAdapter sd = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            cn.Open();
            sd.Fill(dt);
            cn.Close();

            foreach (DataRow dr in dt.Rows)
            {
                listpreg.Add(new Pregunta
                {
                    pregunta = Convert.ToString(dr["pregunta"]),
                    opt1 = Convert.ToString(dr["opt1"]),
                    opt2 = Convert.ToString(dr["opt2"]),
                    opt3 = Convert.ToString(dr["opt3"]),
                    opt4 = Convert.ToString(dr["opt4"]),
                    contador = Convert.ToString(dr["contador"])
                });
            }

            return listpreg;

        }
    }
}