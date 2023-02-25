using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Data.SQLite;
using WindowsFormsApp1.Modelo;

namespace WindowsFormsApp1.Logica
{
    internal class Logica_Articulos
    {
        public DataTable ArtList(string quest)
        {
            SQLiteDataReader result;
            DataTable table = new DataTable();

            SQLiteConnection conn = new SQLiteConnection();

            try
            {
                conn = Conexion.getInstance().ConnectionCreate();
                quest = "%" + quest.Trim()+ "%";
                string query = "select a.id ,a.descripcion_art,a.marca_art,b.descrip_med,c.descripcion_cat,b.id as 'codigo_medida',c.id as 'codigo_categoria'  \r\nfrom tbl_articulos a \r\ninner join tbl_medidas b on  a.codigo_med =b.id " +
                    "inner join tbl_categorias c on a.codigo_cat=c.id " +
                    "where a.descripcion_art like '"+quest+"' ";
                SQLiteCommand sQLiteCommand = new SQLiteCommand(query,conn);
                conn.Open();
                result = sQLiteCommand.ExecuteReader();
                table.Load(result);
                return table;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally {

                if (conn.State == ConnectionState.Open) conn.Close();
               
            }

        }

        public String ArtSave(int option,Model_Articulos obj)
        {

            string response = "";
            string query = " ";
            SQLiteConnection conn = new SQLiteConnection();

            try
            {
                conn = Conexion.getInstance().ConnectionCreate();
                if(option == 1)//nuevo registro
                {

                    query = "insert into tbl_articulos" +
                        "(descripcion_art,marca_art,codigo_med,codigo_cat) " +
                        "values('"+obj.descripcion_art+"','"+obj.marca_art+"','"+obj.codigo_med+"','"+obj.codigo_cat+"')";

                }
                else 
                {
                    query = "update tbl_articulos set descripcion_art ='" + obj.descripcion_art + "', " +
                            "marca_art='" + obj.marca_art + "', " +
                            "codigo_med='" + obj.codigo_med + "', " +
                            "codigo_cat='" + obj.codigo_cat + "' " +
                            "where id='" + obj.id + "' ";
                }
                
               
                SQLiteCommand sQLiteCommand = new SQLiteCommand(query, conn);
                conn.Open();
                response = sQLiteCommand.ExecuteNonQuery()>=1 ? "OK" : "NOSE PUDO COMPLETAR EL PROCESO DE REGISTRO";// vamos aen enviar datos
                return response;
            }
            catch (Exception ex)
            {

               return response = ex.Message;
            }
            finally
            {

                if (conn.State == ConnectionState.Open) conn.Close();

            }

        }

        public DataTable ExtentList()
        {
            SQLiteDataReader result;
            DataTable table = new DataTable();

            SQLiteConnection conn = new SQLiteConnection();

            try
            {
                conn = Conexion.getInstance().ConnectionCreate();              
                string query = "select descrip_med,id from tbl_medidas";
                SQLiteCommand sQLiteCommand = new SQLiteCommand(query, conn);
                conn.Open();
                result = sQLiteCommand.ExecuteReader();
                table.Load(result);
                return table;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {

                if (conn.State == ConnectionState.Open) conn.Close();

            }

        }

        public DataTable CategoryList()
        {
            SQLiteDataReader result;
            DataTable table = new DataTable();

            SQLiteConnection conn = new SQLiteConnection();

            try
            {
                conn = Conexion.getInstance().ConnectionCreate();
                string query = "select descripcion_cat,id from tbl_categorias";
                SQLiteCommand sQLiteCommand = new SQLiteCommand(query, conn);
                conn.Open();
                result = sQLiteCommand.ExecuteReader();
                table.Load(result);
                return table;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {

                if (conn.State == ConnectionState.Open) conn.Close();

            }

        }

        public String ArtDelete(int id)
        {

            string response = "";
            string query = " ";
            SQLiteConnection conn = new SQLiteConnection();

            try
            {
                conn = Conexion.getInstance().ConnectionCreate();

                    query = "delete from tbl_articulos where id='" +id+ "'";
       

                SQLiteCommand sQLiteCommand = new SQLiteCommand(query, conn);
                conn.Open();
                response = sQLiteCommand.ExecuteNonQuery() >= 1 ? "OK" : "NOSE PUDO COMPLETAR EL PROCESO DE REGISTRO";// vamos aen enviar datos
                return response;
            }
            catch (Exception ex)
            {

                return response = ex.Message;
            }
            finally
            {

                if (conn.State == ConnectionState.Open) conn.Close();

            }

        }

    }
}
