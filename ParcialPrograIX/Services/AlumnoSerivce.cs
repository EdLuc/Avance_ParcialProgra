using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;
using ParcialPrograIX.Models;
using Dapper;

namespace ParcialPrograIX.Services
{
    public class AlumnoSerivce
    {
        private SqlConnection _Conn = new SqlConnection();
        private static SqlConnection GetSqlConnection()
        {
            return new SqlConnection(@"Data Source=localhost; Initial Catalog=AlumnosUdeO; Integrated Security=True; Pooling=False");   
        }
        public Alumno GetAlumnoById(int id)
        {
            _Conn = GetSqlConnection();
            _Conn.Open();
            //Select 
            var alumno = _Conn.Query<Alumno>("SELECT * FROM Alumno").Where(f => f.Id_Alumno == id).ToList();
            return alumno.Count != 0 ? alumno.First() : null;
        }
        public IEnumerable<Alumno> GetAlumnos()
        {
            _Conn = GetSqlConnection();
            _Conn.Open();
            //Select 
            var alumno = _Conn.Query<Alumno>("SELECT * FROM Alumno").ToList();
            return alumno;
        }
    }
}
