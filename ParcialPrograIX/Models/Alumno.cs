using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParcialPrograIX.Models
{
    public class Alumno
    {
        public int Id_Alumno { get; set; }
        public string Nombre1 { get; set; }
        public string Nombre2 { get; set; }
        public string Apellido1 { get; set; }
        public string Apellido2 { get; set; }
        public int Carne { get; set; }
        public string Carrera { get; set; }
        public DateTime Fecga_de_Ingreso { get; set; }
        public DateTime Fecha_Nac { get; set; }
        public string Correo_electronico { get; set; }
        public int Telefono { get; set; }
        public string Genero { get; set; }
    }
}
