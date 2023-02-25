using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.SQLite;
using WindowsFormsApp1.Logica;
using System.Collections;
using System.Reflection;
using Microsoft.Reporting.WinForms;

namespace WindowsFormsApp1.Reportes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region "Content methods" 


        private void List_Art()
        {
            SQLiteConnection conect = new  SQLiteConnection();
            try 
            {

                string query = "select a.id ,a.descripcion_art,a.marca_art,b.descrip_med,c.descripcion_cat,b.id as 'codigo_medida',c.id as 'codigo_categoria'  \r\nfrom tbl_articulos a \r\ninner join tbl_medidas b on a.codigo_med = b.id " +
                    "inner join tbl_categorias c on a.codigo_cat=c.id";
                conect = Conexion.getInstance().ConnectionCreate();

                SQLiteDataAdapter data = new SQLiteDataAdapter(query,conect);
                DataSet dataSet = new DataSet();
                data.Fill(dataSet);

                ReportDataSource file = new ReportDataSource("DataSet_Crud", dataSet.Tables[0]);
                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(file);
                reportViewer1.LocalReport.ReportEmbeddedResource = "CRU_ARTICULOS.Reportes.Report_Art.rdlc";
                reportViewer1.LocalReport.Refresh();
                reportViewer1.Refresh();
                reportViewer1.RefreshReport();
                //VIDEO 26 MIN 6:48 seg

            }
            catch(Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conect.State == ConnectionState.Open) conect.Close();
            }

        }

        #endregion

        private void Form1_Load(object sender, EventArgs e)
        {

            this.List_Art();
            this.reportViewer1.RefreshReport();
        }
    }
}
