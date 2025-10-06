using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace herovillano.Models
{
    public class Materia
    {
        public int ID { get; set; }
        public string? NombreMateria { get; set; }
        public string? Tipo { get; set; }
        public string? Horario { get; set; }
        public double Calificacion { get; set; }
        public String? Conexion { get; set; }

        public Materia() { }

        public Materia(int id, string nombreMateria, string tipo,
                        string horario, double calificacion, String conexion)
        {
            ID = id;
            NombreMateria = nombreMateria;
            Tipo = tipo;
            Horario = horario;
            Calificacion = calificacion;
            Conexion = conexion;
        }
        public DataTable conexion(string conexion)
        {
            DataTable dt = new DataTable();
            
            using ( = new SqlConnection) ;


                Console.WriteLine();
            String? conexion = "Server = HP\\\\MISCOSAS; \" +\r\n" +
                "\"Database = HeroeVillano; \" +\r\n                " +
                "\"Integrated Security = True;\" +\r\n                " +
                "\"TrustServerCertificate = True;";
        }

    }
        
    
}
