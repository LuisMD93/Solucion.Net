using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Logica;
using WindowsFormsApp1.Modelo;

using static System.Windows.Forms.AxHost;

namespace WindowsFormsApp1
{
    public partial class Form_articulo : Form
    {
        public Form_articulo()
        {
            InitializeComponent();
        }

        #region "Variables Content"
        int optionActionFocus = 0;
        int nCodigo_ar = 0;
        int nCodigo_me = 0;
        int nCodigo_cat = 0;

        #endregion

        #region "Method Content"

        private void Method_Text_state(bool state) { 
            txt_articulo.ReadOnly = !state;
            txt_marca.ReadOnly = !state;
        }

        private void Method_Text_clear()
        {
            txt_articulo.Clear();
            txt_marca.Clear();
            txt_medida.Clear();
            txt_categoria.Clear();
        }


        private void Method_Button_state(bool state)
        {
           Btn_cancelar.Visible = state;
           Btn_guardar.Visible = state;
           Btn_lupa_categoria.Visible = state;
           Btn_lupa_medida.Visible = state;

            Btn_buscar.Enabled = !state;
            txt_buscar.Enabled = !state;
            dataGridView_Listado_articulos.Enabled = !state;


        }

        private void Method_Principal_Button_state(bool state)
        {

            Btn_nuevo.Enabled = state;
            Btn_eliminar.Enabled = state;
            Btn_actualizar.Enabled = state;
            Btn_reporte.Enabled = state;
            Btn_salir.Enabled = state;
            
        }


        private void Method_Artic_Format() 
        {
            dataGridView_Listado_articulos.Columns[0].Width =90;
            dataGridView_Listado_articulos.Columns[0].HeaderText = "CODIGO_ART";

            dataGridView_Listado_articulos.Columns[1].Width = 220;
            dataGridView_Listado_articulos.Columns[1].HeaderText = "ARTICULO";

            dataGridView_Listado_articulos.Columns[2].Width = 120;
            dataGridView_Listado_articulos.Columns[2].HeaderText = "MARCA";

            dataGridView_Listado_articulos.Columns[3].Width = 100;
            dataGridView_Listado_articulos.Columns[3].HeaderText = "MEDIDA";

            dataGridView_Listado_articulos.Columns[4].Width = 150;
            dataGridView_Listado_articulos.Columns[4].HeaderText = "CATEGORIA";

            dataGridView_Listado_articulos.Columns[5].Visible=false;
            dataGridView_Listado_articulos.Columns[6].Visible = false;

        }

        private void Method_Exten_Format()
        {
            dataGridView_Extent.Columns[0].Width = 150;
            dataGridView_Extent.Columns[0].HeaderText = "MEDIDA";

            dataGridView_Extent.Columns[1].Visible = false;


        }

        private void Method_art_List(string quest)
        {
            Logica_Articulos data = new Logica_Articulos();
            dataGridView_Listado_articulos.DataSource = data.ArtList(quest);
            this.Method_Artic_Format();
        }

        private void Method_extent_List()
        {
            Logica_Articulos data = new Logica_Articulos();
            dataGridView_Extent.DataSource = data.ExtentList();
            this.Method_Exten_Format();
        }


        private void Method_extent_Selected()
        {

            if (string.IsNullOrEmpty(Convert.ToString(dataGridView_Extent.CurrentRow.Cells["id"].Value)))
            {
                MessageBox.Show("Selecciones alguna medida ", "System", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                this.nCodigo_me = Convert.ToInt32(dataGridView_Extent.CurrentRow.Cells["id"].Value);
                txt_medida.Text = Convert.ToString(dataGridView_Extent.CurrentRow.Cells["descrip_med"].Value);
            }
        }


        private void Method_Category_Format()
        {
            dataGridView_Category.Columns[0].Width = 150;
            dataGridView_Category.Columns[0].HeaderText = "Categoria";

            dataGridView_Category.Columns[1].Visible = false;


        }

        private void Method_Category_List()
        {
            Logica_Articulos data = new Logica_Articulos();
            dataGridView_Category.DataSource = data.CategoryList();
            this.Method_Category_Format();
        }


        private void Method_Category_Selected()
        {

            if (string.IsNullOrEmpty(Convert.ToString(dataGridView_Category.CurrentRow.Cells["id"].Value)))
            {
                MessageBox.Show("Selecciones alguna categoria", "System", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                this.nCodigo_cat = Convert.ToInt32(dataGridView_Category.CurrentRow.Cells["id"].Value);
                txt_categoria.Text = Convert.ToString(dataGridView_Category.CurrentRow.Cells["descripcion_cat"].Value);
            }
        }

        private void Method_Article_Selected()
        {

            if (string.IsNullOrEmpty(Convert.ToString(dataGridView_Listado_articulos.CurrentRow.Cells["id"].Value)))
            {
                MessageBox.Show("Selecciones alguna categoria", "System", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                this.nCodigo_ar = Convert.ToInt32(dataGridView_Listado_articulos.CurrentRow.Cells["id"].Value);
                this.txt_medida.Text = Convert.ToString(dataGridView_Listado_articulos.CurrentRow.Cells["descrip_med"].Value);
                this.txt_categoria.Text= Convert.ToString(dataGridView_Listado_articulos.CurrentRow.Cells["descripcion_cat"].Value);
                this.txt_marca.Text= Convert.ToString(dataGridView_Listado_articulos.CurrentRow.Cells["marca_art"].Value);
                this.txt_articulo.Text = Convert.ToString(dataGridView_Listado_articulos.CurrentRow.Cells["descripcion_art"].Value);
                
                this.nCodigo_me = Convert.ToInt32(dataGridView_Listado_articulos.CurrentRow.Cells["codigo_medida"].Value);
                this.nCodigo_cat = Convert.ToInt32(dataGridView_Listado_articulos.CurrentRow.Cells["codigo_categoria"].Value);


                //MessageBox.Show("CODIGO_ART :"+ id + " MEDIDA :" +data+" ARTICULO : "+ descripcion_art + "  CATEGORIA "+cat+" MARCA : "+marca_art, "System", MessageBoxButtons.OK, MessageBoxIcon.Information);             

            }
        }

        #endregion


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (dataGridView_Listado_articulos.Rows.Count <= 0)
            {
                MessageBox.Show("Tabla vacia\n No hay datos para eliminar", "System", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string response = "";
                Logica_Articulos data = new Logica_Articulos();
                response = data.ArtDelete(nCodigo_ar);
                if (response.Equals("OK"))
                {
                    this.Method_art_List("%");
                    this.Method_Text_clear();
                    nCodigo_ar= 0;
                    nCodigo_cat= 0;
                    nCodigo_me= 0;
                    MessageBox.Show("Datos Eliminados", "System", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void Form_articulo_Load(object sender, EventArgs e)
        {
            this.Method_art_List("%");
            this.Method_extent_List();
            this.Method_Category_List();
        }

        private void Btn_nuevo_Click(object sender, EventArgs e)
        {
            optionActionFocus = 1; // 1 para que el boton guardar guarde
            this.Method_Text_state(true);
            this.Method_Text_clear();
            this.Method_Button_state(true);
            this.Method_Principal_Button_state(false);
            txt_articulo.Focus();

        }

        private void Btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Method_Text_state(false);
            this.Method_Text_clear();
            this.Method_Button_state(false);
            this.Method_Principal_Button_state(true);
            optionActionFocus = 0;
            nCodigo_ar = 0;
            nCodigo_me = 0;
            nCodigo_cat = 0;
        }

        private void Btn_actualizar_Click(object sender, EventArgs e)
        {
           
            if (nCodigo_ar > 0)
            {
                Btn_lupa_categoria.Visible = true;
                Btn_lupa_medida.Visible = true;
                this.Method_Text_state(true);
                Btn_cancelar.Visible = true;
                Btn_guardar.Visible = true;
            }
            else
            {
                MessageBox.Show("Campos vacio\n porfavor selecciona datos de la tabla para Editar", "System", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Btn_guardar_Click(object sender, EventArgs e)
        {
            string response = "" ,info="";
            Model_Articulos obj = new Model_Articulos();
                    
            obj.id = nCodigo_ar;
            obj.descripcion_art = txt_articulo.Text.Trim();
            obj.marca_art= txt_marca.Text.Trim();
            obj.codigo_med = nCodigo_me;
            obj.codigo_cat = nCodigo_cat;

            if(nCodigo_ar>0)
            {
                optionActionFocus = 2;// 2 para que el boton guardar guarde datos actualizados
                nCodigo_ar = 0;
                info = " Update Data";
            }
            else
            {
                optionActionFocus = 1;
                nCodigo_ar = 0;
                info = "Save Data";
            }
            
            Logica_Articulos callObject = new Logica_Articulos();
            response = callObject.ArtSave(optionActionFocus, obj);
       
            if (response.Equals("OK"))
            {
                this.Method_art_List("%");
                this.Method_Button_state(false);
                this.Method_Principal_Button_state(true);
                this.Method_Text_state(false);
                this.Method_Text_clear();
                optionActionFocus = 0;
                nCodigo_ar = 0;
                nCodigo_me = 0;
                nCodigo_cat = 0;
                MessageBox.Show("Sucesssfull , "+info,"System",MessageBoxButtons.OK,MessageBoxIcon.Information);

            } 
        }

        private void Exten_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Btn_lupa_medida_Click(object sender, EventArgs e)
        {
            Extent_panel.Location = txt_articulo.Location;
            Extent_panel.Visible=true;
            Btn_cancelar.Visible = false;
            Btn_guardar.Visible = false;
        }

        private void Extent_return_Click(object sender, EventArgs e)
        {
            Extent_panel.Visible= false;
            Btn_cancelar.Visible = true;
            Btn_guardar.Visible = true;
        }

        private void dataGridView_Extent_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Method_extent_Selected();
            Extent_panel.Visible = false;
            Btn_cancelar.Visible = true;
            Btn_guardar.Visible = true;

        }

        private void dataGridView_Category_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Method_Category_Selected();
            Category_panel.Visible = false;
            Btn_cancelar.Visible = true;
            Btn_guardar.Visible = true;
        }

        private void Btn_lupa_categoria_Click(object sender, EventArgs e)
        {
            Category_panel.Location = txt_articulo.Location;
            Category_panel.Visible = true;
            Btn_cancelar.Visible = false;
            Btn_guardar.Visible = false;
        }

        private void Category_return_Click(object sender, EventArgs e)
        {
            Category_panel.Visible = false;
            Btn_cancelar.Visible = true;
            Btn_guardar.Visible = true;
        }

        private void dataGridView_Listado_articulos_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            this.Method_Article_Selected();          
        }

        private void Btn_buscar_Click(object sender, EventArgs e)
        {
            this.Method_art_List(txt_buscar.Text.Trim());
        }

        private void Btn_eliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView_Listado_articulos.Rows.Count <= 0)
            {
                MessageBox.Show("Tabla vacia\n No hay datos para eliminar", "System", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string response = "";
                Logica_Articulos data = new Logica_Articulos();
                response = data.ArtDelete(nCodigo_ar);
                if (response.Equals("OK"))
                {
                    this.Method_art_List("%");
                    this.Method_Text_clear();
                    nCodigo_ar = 0;
                    nCodigo_cat = 0;
                    nCodigo_me = 0;
                    MessageBox.Show("Datos Eliminados", "System", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }

        private void Btn_reporte_Click(object sender, EventArgs e)
        {
            Reportes.Form1 Rpt = new Reportes.Form1();
            Rpt.ShowDialog();
        }
    }
}
