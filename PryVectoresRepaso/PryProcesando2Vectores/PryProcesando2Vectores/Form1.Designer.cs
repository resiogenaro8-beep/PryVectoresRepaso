namespace PryProcesando2Vectores
{
    partial class Form1
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
            this.gbCargaDeDatos = new System.Windows.Forms.GroupBox();
            this.BtnCargar = new System.Windows.Forms.Button();
            this.txtImporte = new System.Windows.Forms.TextBox();
            this.CboMes = new System.Windows.Forms.ComboBox();
            this.LblMes = new System.Windows.Forms.Label();
            this.LblImporte = new System.Windows.Forms.Label();
            this.GbLIstadoDeDatos = new System.Windows.Forms.GroupBox();
            this.DvgListar = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Btn = new System.Windows.Forms.Button();
            this.BtnListarConFor = new System.Windows.Forms.Button();
            this.gbCargaDeDatos.SuspendLayout();
            this.GbLIstadoDeDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DvgListar)).BeginInit();
            this.SuspendLayout();
            // 
            // gbCargaDeDatos
            // 
            this.gbCargaDeDatos.Controls.Add(this.BtnCargar);
            this.gbCargaDeDatos.Controls.Add(this.txtImporte);
            this.gbCargaDeDatos.Controls.Add(this.CboMes);
            this.gbCargaDeDatos.Controls.Add(this.LblMes);
            this.gbCargaDeDatos.Controls.Add(this.LblImporte);
            this.gbCargaDeDatos.Location = new System.Drawing.Point(12, 28);
            this.gbCargaDeDatos.Name = "gbCargaDeDatos";
            this.gbCargaDeDatos.Size = new System.Drawing.Size(300, 213);
            this.gbCargaDeDatos.TabIndex = 0;
            this.gbCargaDeDatos.TabStop = false;
            this.gbCargaDeDatos.Text = "Carga de Datos";
            // 
            // BtnCargar
            // 
            this.BtnCargar.Location = new System.Drawing.Point(171, 181);
            this.BtnCargar.Name = "BtnCargar";
            this.BtnCargar.Size = new System.Drawing.Size(121, 23);
            this.BtnCargar.TabIndex = 4;
            this.BtnCargar.Text = "Cargar";
            this.BtnCargar.UseVisualStyleBackColor = true;
            this.BtnCargar.Click += new System.EventHandler(this.BtnCargar_Click);
            // 
            // txtImporte
            // 
            this.txtImporte.Location = new System.Drawing.Point(171, 114);
            this.txtImporte.Name = "txtImporte";
            this.txtImporte.Size = new System.Drawing.Size(121, 20);
            this.txtImporte.TabIndex = 3;
            // 
            // CboMes
            // 
            this.CboMes.FormattingEnabled = true;
            this.CboMes.Location = new System.Drawing.Point(171, 50);
            this.CboMes.Name = "CboMes";
            this.CboMes.Size = new System.Drawing.Size(121, 21);
            this.CboMes.TabIndex = 2;
            // 
            // LblMes
            // 
            this.LblMes.AutoSize = true;
            this.LblMes.Location = new System.Drawing.Point(20, 50);
            this.LblMes.Name = "LblMes";
            this.LblMes.Size = new System.Drawing.Size(27, 13);
            this.LblMes.TabIndex = 1;
            this.LblMes.Text = "Mes";
            // 
            // LblImporte
            // 
            this.LblImporte.AutoSize = true;
            this.LblImporte.Location = new System.Drawing.Point(20, 117);
            this.LblImporte.Name = "LblImporte";
            this.LblImporte.Size = new System.Drawing.Size(42, 13);
            this.LblImporte.TabIndex = 0;
            this.LblImporte.Text = "Importe";
            // 
            // GbLIstadoDeDatos
            // 
            this.GbLIstadoDeDatos.Controls.Add(this.DvgListar);
            this.GbLIstadoDeDatos.Controls.Add(this.Btn);
            this.GbLIstadoDeDatos.Controls.Add(this.BtnListarConFor);
            this.GbLIstadoDeDatos.Location = new System.Drawing.Point(13, 301);
            this.GbLIstadoDeDatos.Name = "GbLIstadoDeDatos";
            this.GbLIstadoDeDatos.Size = new System.Drawing.Size(299, 283);
            this.GbLIstadoDeDatos.TabIndex = 1;
            this.GbLIstadoDeDatos.TabStop = false;
            this.GbLIstadoDeDatos.Text = "Listado  De Datos";
            // 
            // DvgListar
            // 
            this.DvgListar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DvgListar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.DvgListar.Location = new System.Drawing.Point(6, 43);
            this.DvgListar.Name = "DvgListar";
            this.DvgListar.Size = new System.Drawing.Size(285, 150);
            this.DvgListar.TabIndex = 7;
            this.DvgListar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DvgListar_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Mes";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Importe";
            this.Column2.Name = "Column2";
            // 
            // Btn
            // 
            this.Btn.Location = new System.Drawing.Point(171, 232);
            this.Btn.Name = "Btn";
            this.Btn.Size = new System.Drawing.Size(121, 23);
            this.Btn.TabIndex = 6;
            this.Btn.Text = "Listar Con While";
            this.Btn.UseVisualStyleBackColor = true;
            this.Btn.Click += new System.EventHandler(this.Btn_Click);
            // 
            // BtnListarConFor
            // 
            this.BtnListarConFor.Location = new System.Drawing.Point(6, 232);
            this.BtnListarConFor.Name = "BtnListarConFor";
            this.BtnListarConFor.Size = new System.Drawing.Size(121, 23);
            this.BtnListarConFor.TabIndex = 5;
            this.BtnListarConFor.Text = "LIstar Con For";
            this.BtnListarConFor.UseVisualStyleBackColor = true;
            this.BtnListarConFor.Click += new System.EventHandler(this.BtnListarConFor_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 596);
            this.Controls.Add(this.GbLIstadoDeDatos);
            this.Controls.Add(this.gbCargaDeDatos);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbCargaDeDatos.ResumeLayout(false);
            this.gbCargaDeDatos.PerformLayout();
            this.GbLIstadoDeDatos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DvgListar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbCargaDeDatos;
        private System.Windows.Forms.Label LblImporte;
        private System.Windows.Forms.ComboBox CboMes;
        private System.Windows.Forms.Label LblMes;
        private System.Windows.Forms.Button BtnCargar;
        private System.Windows.Forms.TextBox txtImporte;
        private System.Windows.Forms.GroupBox GbLIstadoDeDatos;
        private System.Windows.Forms.Button Btn;
        private System.Windows.Forms.Button BtnListarConFor;
        private System.Windows.Forms.DataGridView DvgListar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}

