using System;

namespace WindowsFormsApp1
{
    partial class Form_articulo
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_articulo));
            this.dataGridView_Listado_articulos = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_buscar = new System.Windows.Forms.TextBox();
            this.Btn_buscar = new System.Windows.Forms.Button();
            this.Btn_actualizar = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.Btn_nuevo = new System.Windows.Forms.Button();
            this.Btn_reporte = new System.Windows.Forms.Button();
            this.Btn_salir = new System.Windows.Forms.Button();
            this.txt_articulo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_marca = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_medida = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_categoria = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Btn_lupa_medida = new System.Windows.Forms.Button();
            this.Btn_lupa_categoria = new System.Windows.Forms.Button();
            this.Btn_cancelar = new System.Windows.Forms.Button();
            this.Btn_guardar = new System.Windows.Forms.Button();
            this.Extent_panel = new System.Windows.Forms.Panel();
            this.Extent_return = new System.Windows.Forms.Button();
            this.dataGridView_Extent = new System.Windows.Forms.DataGridView();
            this.Category_panel = new System.Windows.Forms.Panel();
            this.Category_return = new System.Windows.Forms.Button();
            this.dataGridView_Category = new System.Windows.Forms.DataGridView();
            this.Btn_eliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Listado_articulos)).BeginInit();
            this.Extent_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Extent)).BeginInit();
            this.Category_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Category)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_Listado_articulos
            // 
            this.dataGridView_Listado_articulos.AllowUserToAddRows = false;
            this.dataGridView_Listado_articulos.AllowUserToDeleteRows = false;
            this.dataGridView_Listado_articulos.AllowUserToOrderColumns = true;
            this.dataGridView_Listado_articulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Listado_articulos.Location = new System.Drawing.Point(14, 61);
            this.dataGridView_Listado_articulos.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGridView_Listado_articulos.Name = "dataGridView_Listado_articulos";
            this.dataGridView_Listado_articulos.ReadOnly = true;
            this.dataGridView_Listado_articulos.Size = new System.Drawing.Size(705, 361);
            this.dataGridView_Listado_articulos.TabIndex = 0;
            this.dataGridView_Listado_articulos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Listado_articulos_CellDoubleClick_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Buscar:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txt_buscar
            // 
            this.txt_buscar.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_buscar.Location = new System.Drawing.Point(88, 28);
            this.txt_buscar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_buscar.Name = "txt_buscar";
            this.txt_buscar.Size = new System.Drawing.Size(290, 27);
            this.txt_buscar.TabIndex = 2;
            // 
            // Btn_buscar
            // 
            this.Btn_buscar.BackColor = System.Drawing.Color.Cyan;
            this.Btn_buscar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_buscar.Location = new System.Drawing.Point(385, 28);
            this.Btn_buscar.Name = "Btn_buscar";
            this.Btn_buscar.Size = new System.Drawing.Size(74, 27);
            this.Btn_buscar.TabIndex = 3;
            this.Btn_buscar.Text = "Buscar";
            this.Btn_buscar.UseVisualStyleBackColor = false;
            this.Btn_buscar.Click += new System.EventHandler(this.Btn_buscar_Click);
            // 
            // Btn_actualizar
            // 
            this.Btn_actualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_actualizar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_actualizar.ImageKey = "editar-codigo (1).png";
            this.Btn_actualizar.ImageList = this.imageList1;
            this.Btn_actualizar.Location = new System.Drawing.Point(660, 450);
            this.Btn_actualizar.Name = "Btn_actualizar";
            this.Btn_actualizar.Size = new System.Drawing.Size(84, 57);
            this.Btn_actualizar.TabIndex = 4;
            this.Btn_actualizar.Text = "Actualizar";
            this.Btn_actualizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Btn_actualizar.UseVisualStyleBackColor = true;
            this.Btn_actualizar.Click += new System.EventHandler(this.Btn_actualizar_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "agregar-archivo.png");
            this.imageList1.Images.SetKeyName(1, "editar-codigo (1).png");
            this.imageList1.Images.SetKeyName(2, "delete-file.png");
            this.imageList1.Images.SetKeyName(3, "documentos.png");
            this.imageList1.Images.SetKeyName(4, "logout.png");
            // 
            // Btn_nuevo
            // 
            this.Btn_nuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_nuevo.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_nuevo.ImageKey = "agregar-archivo.png";
            this.Btn_nuevo.ImageList = this.imageList1;
            this.Btn_nuevo.Location = new System.Drawing.Point(557, 450);
            this.Btn_nuevo.Name = "Btn_nuevo";
            this.Btn_nuevo.Size = new System.Drawing.Size(84, 57);
            this.Btn_nuevo.TabIndex = 5;
            this.Btn_nuevo.Text = "Nuevo";
            this.Btn_nuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Btn_nuevo.UseVisualStyleBackColor = true;
            this.Btn_nuevo.Click += new System.EventHandler(this.Btn_nuevo_Click);
            // 
            // Btn_reporte
            // 
            this.Btn_reporte.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_reporte.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_reporte.ImageKey = "documentos.png";
            this.Btn_reporte.ImageList = this.imageList1;
            this.Btn_reporte.Location = new System.Drawing.Point(873, 450);
            this.Btn_reporte.Name = "Btn_reporte";
            this.Btn_reporte.Size = new System.Drawing.Size(84, 57);
            this.Btn_reporte.TabIndex = 7;
            this.Btn_reporte.Text = "Reporte";
            this.Btn_reporte.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Btn_reporte.UseVisualStyleBackColor = true;
            this.Btn_reporte.Click += new System.EventHandler(this.Btn_reporte_Click);
            // 
            // Btn_salir
            // 
            this.Btn_salir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_salir.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_salir.ImageKey = "logout.png";
            this.Btn_salir.ImageList = this.imageList1;
            this.Btn_salir.Location = new System.Drawing.Point(982, 450);
            this.Btn_salir.Name = "Btn_salir";
            this.Btn_salir.Size = new System.Drawing.Size(84, 57);
            this.Btn_salir.TabIndex = 8;
            this.Btn_salir.Text = "Salir";
            this.Btn_salir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Btn_salir.UseVisualStyleBackColor = true;
            // 
            // txt_articulo
            // 
            this.txt_articulo.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_articulo.Location = new System.Drawing.Point(737, 79);
            this.txt_articulo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_articulo.Name = "txt_articulo";
            this.txt_articulo.ReadOnly = true;
            this.txt_articulo.Size = new System.Drawing.Size(342, 23);
            this.txt_articulo.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(734, 61);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 19);
            this.label2.TabIndex = 9;
            this.label2.Text = "Articulo: (*)";
            // 
            // txt_marca
            // 
            this.txt_marca.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_marca.Location = new System.Drawing.Point(737, 158);
            this.txt_marca.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_marca.Name = "txt_marca";
            this.txt_marca.ReadOnly = true;
            this.txt_marca.Size = new System.Drawing.Size(342, 23);
            this.txt_marca.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(734, 140);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 19);
            this.label3.TabIndex = 11;
            this.label3.Text = "Marca: (*)";
            // 
            // txt_medida
            // 
            this.txt_medida.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_medida.Location = new System.Drawing.Point(737, 241);
            this.txt_medida.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_medida.Name = "txt_medida";
            this.txt_medida.ReadOnly = true;
            this.txt_medida.Size = new System.Drawing.Size(282, 23);
            this.txt_medida.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(734, 223);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 19);
            this.label4.TabIndex = 13;
            this.label4.Text = "Medida: (*)";
            // 
            // txt_categoria
            // 
            this.txt_categoria.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_categoria.Location = new System.Drawing.Point(737, 329);
            this.txt_categoria.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_categoria.Name = "txt_categoria";
            this.txt_categoria.ReadOnly = true;
            this.txt_categoria.Size = new System.Drawing.Size(282, 23);
            this.txt_categoria.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(734, 311);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 19);
            this.label5.TabIndex = 15;
            this.label5.Text = "Categoria: (*)";
            // 
            // Btn_lupa_medida
            // 
            this.Btn_lupa_medida.Location = new System.Drawing.Point(1026, 241);
            this.Btn_lupa_medida.Name = "Btn_lupa_medida";
            this.Btn_lupa_medida.Size = new System.Drawing.Size(57, 28);
            this.Btn_lupa_medida.TabIndex = 17;
            this.Btn_lupa_medida.Text = ":::";
            this.Btn_lupa_medida.UseVisualStyleBackColor = true;
            this.Btn_lupa_medida.Visible = false;
            this.Btn_lupa_medida.Click += new System.EventHandler(this.Btn_lupa_medida_Click);
            // 
            // Btn_lupa_categoria
            // 
            this.Btn_lupa_categoria.Location = new System.Drawing.Point(1026, 328);
            this.Btn_lupa_categoria.Name = "Btn_lupa_categoria";
            this.Btn_lupa_categoria.Size = new System.Drawing.Size(57, 28);
            this.Btn_lupa_categoria.TabIndex = 18;
            this.Btn_lupa_categoria.Text = ":::";
            this.Btn_lupa_categoria.UseVisualStyleBackColor = true;
            this.Btn_lupa_categoria.Visible = false;
            this.Btn_lupa_categoria.Click += new System.EventHandler(this.Btn_lupa_categoria_Click);
            // 
            // Btn_cancelar
            // 
            this.Btn_cancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Btn_cancelar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_cancelar.ForeColor = System.Drawing.Color.White;
            this.Btn_cancelar.Location = new System.Drawing.Point(766, 371);
            this.Btn_cancelar.Name = "Btn_cancelar";
            this.Btn_cancelar.Size = new System.Drawing.Size(114, 43);
            this.Btn_cancelar.TabIndex = 19;
            this.Btn_cancelar.Text = "Cancelar";
            this.Btn_cancelar.UseVisualStyleBackColor = false;
            this.Btn_cancelar.Visible = false;
            this.Btn_cancelar.Click += new System.EventHandler(this.Btn_cancelar_Click);
            // 
            // Btn_guardar
            // 
            this.Btn_guardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Btn_guardar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_guardar.ForeColor = System.Drawing.Color.White;
            this.Btn_guardar.Location = new System.Drawing.Point(919, 371);
            this.Btn_guardar.Name = "Btn_guardar";
            this.Btn_guardar.Size = new System.Drawing.Size(115, 43);
            this.Btn_guardar.TabIndex = 20;
            this.Btn_guardar.Text = "Guardar";
            this.Btn_guardar.UseVisualStyleBackColor = false;
            this.Btn_guardar.Visible = false;
            this.Btn_guardar.Click += new System.EventHandler(this.Btn_guardar_Click);
            // 
            // Extent_panel
            // 
            this.Extent_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Extent_panel.Controls.Add(this.Extent_return);
            this.Extent_panel.Controls.Add(this.dataGridView_Extent);
            this.Extent_panel.Location = new System.Drawing.Point(12, 437);
            this.Extent_panel.Name = "Extent_panel";
            this.Extent_panel.Size = new System.Drawing.Size(291, 316);
            this.Extent_panel.TabIndex = 21;
            this.Extent_panel.Visible = false;
            this.Extent_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.Exten_panel_Paint);
            // 
            // Extent_return
            // 
            this.Extent_return.BackColor = System.Drawing.Color.Cyan;
            this.Extent_return.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Extent_return.Location = new System.Drawing.Point(14, 277);
            this.Extent_return.Name = "Extent_return";
            this.Extent_return.Size = new System.Drawing.Size(264, 27);
            this.Extent_return.TabIndex = 4;
            this.Extent_return.Text = "Retornar";
            this.Extent_return.UseVisualStyleBackColor = false;
            this.Extent_return.Click += new System.EventHandler(this.Extent_return_Click);
            // 
            // dataGridView_Extent
            // 
            this.dataGridView_Extent.AllowUserToAddRows = false;
            this.dataGridView_Extent.AllowUserToDeleteRows = false;
            this.dataGridView_Extent.ColumnHeadersHeight = 34;
            this.dataGridView_Extent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView_Extent.Location = new System.Drawing.Point(13, 12);
            this.dataGridView_Extent.Name = "dataGridView_Extent";
            this.dataGridView_Extent.ReadOnly = true;
            this.dataGridView_Extent.Size = new System.Drawing.Size(265, 259);
            this.dataGridView_Extent.TabIndex = 0;
            this.dataGridView_Extent.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Extent_CellDoubleClick);
            // 
            // Category_panel
            // 
            this.Category_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Category_panel.Controls.Add(this.Category_return);
            this.Category_panel.Controls.Add(this.dataGridView_Category);
            this.Category_panel.Location = new System.Drawing.Point(324, 437);
            this.Category_panel.Name = "Category_panel";
            this.Category_panel.Size = new System.Drawing.Size(291, 316);
            this.Category_panel.TabIndex = 22;
            this.Category_panel.Visible = false;
            // 
            // Category_return
            // 
            this.Category_return.BackColor = System.Drawing.Color.Cyan;
            this.Category_return.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Category_return.Location = new System.Drawing.Point(14, 277);
            this.Category_return.Name = "Category_return";
            this.Category_return.Size = new System.Drawing.Size(264, 27);
            this.Category_return.TabIndex = 4;
            this.Category_return.Text = "Retornar";
            this.Category_return.UseVisualStyleBackColor = false;
            this.Category_return.Click += new System.EventHandler(this.Category_return_Click);
            // 
            // dataGridView_Category
            // 
            this.dataGridView_Category.AllowUserToAddRows = false;
            this.dataGridView_Category.AllowUserToDeleteRows = false;
            this.dataGridView_Category.ColumnHeadersHeight = 34;
            this.dataGridView_Category.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView_Category.Location = new System.Drawing.Point(13, 12);
            this.dataGridView_Category.Name = "dataGridView_Category";
            this.dataGridView_Category.ReadOnly = true;
            this.dataGridView_Category.Size = new System.Drawing.Size(265, 259);
            this.dataGridView_Category.TabIndex = 0;
            this.dataGridView_Category.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Category_CellDoubleClick);
            // 
            // Btn_eliminar
            // 
            this.Btn_eliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_eliminar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_eliminar.ImageKey = "delete-file.png";
            this.Btn_eliminar.ImageList = this.imageList1;
            this.Btn_eliminar.Location = new System.Drawing.Point(766, 450);
            this.Btn_eliminar.Name = "Btn_eliminar";
            this.Btn_eliminar.Size = new System.Drawing.Size(84, 57);
            this.Btn_eliminar.TabIndex = 23;
            this.Btn_eliminar.Text = "Eliminar";
            this.Btn_eliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Btn_eliminar.UseVisualStyleBackColor = true;
            this.Btn_eliminar.Click += new System.EventHandler(this.Btn_eliminar_Click);
            // 
            // Form_articulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(240)))), ((int)(((byte)(234)))));
            this.ClientSize = new System.Drawing.Size(1092, 519);
            this.Controls.Add(this.Btn_eliminar);
            this.Controls.Add(this.Category_panel);
            this.Controls.Add(this.Extent_panel);
            this.Controls.Add(this.Btn_guardar);
            this.Controls.Add(this.Btn_cancelar);
            this.Controls.Add(this.Btn_lupa_categoria);
            this.Controls.Add(this.Btn_lupa_medida);
            this.Controls.Add(this.txt_categoria);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_medida);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_marca);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_articulo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Btn_salir);
            this.Controls.Add(this.Btn_reporte);
            this.Controls.Add(this.Btn_nuevo);
            this.Controls.Add(this.Btn_actualizar);
            this.Controls.Add(this.Btn_buscar);
            this.Controls.Add(this.txt_buscar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView_Listado_articulos);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form_articulo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form_articulo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Listado_articulos)).EndInit();
            this.Extent_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Extent)).EndInit();
            this.Category_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Category)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_Listado_articulos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_buscar;
        private System.Windows.Forms.Button Btn_buscar;
        private System.Windows.Forms.Button Btn_actualizar;
        private System.Windows.Forms.Button Btn_nuevo;
        private System.Windows.Forms.Button Btn_reporte;
        private System.Windows.Forms.Button Btn_salir;
        private System.Windows.Forms.TextBox txt_articulo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_marca;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_medida;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_categoria;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Btn_lupa_medida;
        private System.Windows.Forms.Button Btn_lupa_categoria;
        private System.Windows.Forms.Button Btn_cancelar;
        private System.Windows.Forms.Button Btn_guardar;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Panel Extent_panel;
        private System.Windows.Forms.DataGridView dataGridView_Extent;
        private System.Windows.Forms.Button Extent_return;
        private System.Windows.Forms.Panel Category_panel;
        private System.Windows.Forms.Button Category_return;
        private System.Windows.Forms.DataGridView dataGridView_Category;
        private System.Windows.Forms.Button Btn_eliminar;

        public EventHandler categoria_TextChanged { get; private set; }
    }
}

