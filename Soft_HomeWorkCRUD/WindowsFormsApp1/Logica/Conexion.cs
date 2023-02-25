using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.SQLite;

namespace WindowsFormsApp1.Logica
{
    public class Conexion
    {
        private string BaseDatos;
        private static Conexion Conect = null;

        private Conexion()
        {
            this.BaseDatos = "./db_HomeWork.db";
        }

        public SQLiteConnection ConnectionCreate()
        {
            SQLiteConnection Cadena = new SQLiteConnection();
            try {

                Cadena.ConnectionString = "Data Source=" + this.BaseDatos;
            
            } catch (Exception ex) {

                Cadena = null;
                throw ex;
            }

            return Cadena;
        }

        public static Conexion getInstance() {

            if (Conect==null)
            {
                Conect = new Conexion();
            }

            return Conect;
        }

    }
}
