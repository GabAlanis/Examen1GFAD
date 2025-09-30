namespace Examen1GFAD
{
    partial class FrmAfiliados
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
            this.DgvAfiliados = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Entidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Municipio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MsMenu = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opcionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reiniciarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CbMunicipio = new System.Windows.Forms.ComboBox();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpfin = new System.Windows.Forms.DateTimePicker();
            this.DtpInicio = new System.Windows.Forms.DateTimePicker();
            this.TxtAfiliados = new System.Windows.Forms.TextBox();
            this.lblFechaFin = new System.Windows.Forms.Label();
            this.lblFechaInicio = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.OfdAbrir = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.BtnFechas = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvAfiliados)).BeginInit();
            this.MsMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // DgvAfiliados
            // 
            this.DgvAfiliados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvAfiliados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Entidad,
            this.Municipio,
            this.Nombre,
            this.Fecha,
            this.Status});
            this.DgvAfiliados.Location = new System.Drawing.Point(13, 131);
            this.DgvAfiliados.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DgvAfiliados.Name = "DgvAfiliados";
            this.DgvAfiliados.RowHeadersWidth = 62;
            this.DgvAfiliados.Size = new System.Drawing.Size(1121, 354);
            this.DgvAfiliados.TabIndex = 0;
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 8;
            this.Id.Name = "Id";
            this.Id.Width = 150;
            // 
            // Entidad
            // 
            this.Entidad.HeaderText = "Entidad";
            this.Entidad.MinimumWidth = 8;
            this.Entidad.Name = "Entidad";
            this.Entidad.Width = 150;
            // 
            // Municipio
            // 
            this.Municipio.HeaderText = "Municipio";
            this.Municipio.MinimumWidth = 8;
            this.Municipio.Name = "Municipio";
            this.Municipio.Width = 200;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 8;
            this.Nombre.Name = "Nombre";
            this.Nombre.Width = 250;
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha de Afiliación";
            this.Fecha.MinimumWidth = 8;
            this.Fecha.Name = "Fecha";
            this.Fecha.Width = 150;
            // 
            // Status
            // 
            this.Status.HeaderText = "Estatus";
            this.Status.MinimumWidth = 8;
            this.Status.Name = "Status";
            this.Status.Width = 150;
            // 
            // MsMenu
            // 
            this.MsMenu.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.MsMenu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.MsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.opcionesToolStripMenuItem});
            this.MsMenu.Location = new System.Drawing.Point(0, 0);
            this.MsMenu.Name = "MsMenu";
            this.MsMenu.Size = new System.Drawing.Size(1287, 33);
            this.MsMenu.TabIndex = 1;
            this.MsMenu.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(88, 29);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(147, 34);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // opcionesToolStripMenuItem
            // 
            this.opcionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importarToolStripMenuItem,
            this.reiniciarToolStripMenuItem});
            this.opcionesToolStripMenuItem.Name = "opcionesToolStripMenuItem";
            this.opcionesToolStripMenuItem.Size = new System.Drawing.Size(103, 29);
            this.opcionesToolStripMenuItem.Text = "Opciones";
            // 
            // importarToolStripMenuItem
            // 
            this.importarToolStripMenuItem.Name = "importarToolStripMenuItem";
            this.importarToolStripMenuItem.Size = new System.Drawing.Size(184, 34);
            this.importarToolStripMenuItem.Text = "Importar";
            this.importarToolStripMenuItem.Click += new System.EventHandler(this.importarToolStripMenuItem_Click);
            // 
            // reiniciarToolStripMenuItem
            // 
            this.reiniciarToolStripMenuItem.Name = "reiniciarToolStripMenuItem";
            this.reiniciarToolStripMenuItem.Size = new System.Drawing.Size(184, 34);
            this.reiniciarToolStripMenuItem.Text = "Reiniciar";
            // 
            // CbMunicipio
            // 
            this.CbMunicipio.FormattingEnabled = true;
            this.CbMunicipio.Location = new System.Drawing.Point(571, 71);
            this.CbMunicipio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CbMunicipio.Name = "CbMunicipio";
            this.CbMunicipio.Size = new System.Drawing.Size(180, 28);
            this.CbMunicipio.TabIndex = 11;
            // 
            // txtEstado
            // 
            this.txtEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEstado.Location = new System.Drawing.Point(196, 63);
            this.txtEstado.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.ReadOnly = true;
            this.txtEstado.Size = new System.Drawing.Size(160, 30);
            this.txtEstado.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(407, 63);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 33);
            this.label2.TabIndex = 9;
            this.label2.Text = "Municipio:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(42, 63);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 33);
            this.label4.TabIndex = 8;
            this.label4.Text = "Estado:";
            // 
            // dtpfin
            // 
            this.dtpfin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpfin.Location = new System.Drawing.Point(441, 620);
            this.dtpfin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpfin.Name = "dtpfin";
            this.dtpfin.Size = new System.Drawing.Size(361, 30);
            this.dtpfin.TabIndex = 18;
            this.dtpfin.ValueChanged += new System.EventHandler(this.dtpfin_ValueChanged);
            // 
            // DtpInicio
            // 
            this.DtpInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpInicio.Location = new System.Drawing.Point(63, 620);
            this.DtpInicio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DtpInicio.Name = "DtpInicio";
            this.DtpInicio.Size = new System.Drawing.Size(358, 30);
            this.DtpInicio.TabIndex = 17;
            // 
            // TxtAfiliados
            // 
            this.TxtAfiliados.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtAfiliados.Location = new System.Drawing.Point(362, 516);
            this.TxtAfiliados.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtAfiliados.Name = "TxtAfiliados";
            this.TxtAfiliados.ReadOnly = true;
            this.TxtAfiliados.Size = new System.Drawing.Size(127, 30);
            this.TxtAfiliados.TabIndex = 16;
            // 
            // lblFechaFin
            // 
            this.lblFechaFin.AutoSize = true;
            this.lblFechaFin.Enabled = false;
            this.lblFechaFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaFin.Location = new System.Drawing.Point(528, 582);
            this.lblFechaFin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFechaFin.Name = "lblFechaFin";
            this.lblFechaFin.Size = new System.Drawing.Size(145, 33);
            this.lblFechaFin.TabIndex = 15;
            this.lblFechaFin.Text = "Fecha Fin";
            // 
            // lblFechaInicio
            // 
            this.lblFechaInicio.AutoSize = true;
            this.lblFechaInicio.Enabled = false;
            this.lblFechaInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaInicio.Location = new System.Drawing.Point(133, 582);
            this.lblFechaInicio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFechaInicio.Name = "lblFechaInicio";
            this.lblFechaInicio.Size = new System.Drawing.Size(173, 33);
            this.lblFechaInicio.TabIndex = 14;
            this.lblFechaInicio.Text = "Fecha Inicio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(67, 510);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(298, 33);
            this.label3.TabIndex = 13;
            this.label3.Text = "Cantidad de Afiliados:";
            // 
            // OfdAbrir
            // 
            this.OfdAbrir.FileName = "openFileDialog1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(822, 66);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 33);
            this.label1.TabIndex = 19;
            this.label1.Text = "Nombre:";
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(957, 66);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.ReadOnly = true;
            this.txtNombre.Size = new System.Drawing.Size(160, 30);
            this.txtNombre.TabIndex = 20;
            // 
            // BtnFechas
            // 
            this.BtnFechas.Location = new System.Drawing.Point(373, 678);
            this.BtnFechas.Name = "BtnFechas";
            this.BtnFechas.Size = new System.Drawing.Size(116, 45);
            this.BtnFechas.TabIndex = 21;
            this.BtnFechas.Text = "Buscar";
            this.BtnFechas.UseVisualStyleBackColor = true;
            this.BtnFechas.Click += new System.EventHandler(this.BtnFechas_Click);
            // 
            // FrmAfiliados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1287, 780);
            this.Controls.Add(this.BtnFechas);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpfin);
            this.Controls.Add(this.DtpInicio);
            this.Controls.Add(this.TxtAfiliados);
            this.Controls.Add(this.lblFechaFin);
            this.Controls.Add(this.lblFechaInicio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CbMunicipio);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DgvAfiliados);
            this.Controls.Add(this.MsMenu);
            this.MainMenuStrip = this.MsMenu;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmAfiliados";
            this.Text = "Afiliados";
            ((System.ComponentModel.ISupportInitialize)(this.DgvAfiliados)).EndInit();
            this.MsMenu.ResumeLayout(false);
            this.MsMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvAfiliados;
        private System.Windows.Forms.MenuStrip MsMenu;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem opcionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reiniciarToolStripMenuItem;
        private System.Windows.Forms.ComboBox CbMunicipio;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpfin;
        private System.Windows.Forms.DateTimePicker DtpInicio;
        private System.Windows.Forms.TextBox TxtAfiliados;
        private System.Windows.Forms.Label lblFechaFin;
        private System.Windows.Forms.Label lblFechaInicio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.OpenFileDialog OfdAbrir;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Entidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Municipio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button BtnFechas;
    }
}

