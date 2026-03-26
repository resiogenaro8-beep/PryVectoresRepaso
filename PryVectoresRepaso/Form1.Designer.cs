namespace PryVectoresRepaso
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
            this.gboCargadedatos = new System.Windows.Forms.GroupBox();
            this.txyNombre1 = new System.Windows.Forms.TextBox();
            this.BTNcARGA = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.gboListadeDatos = new System.Windows.Forms.GroupBox();
            this.lstPersonas = new System.Windows.Forms.ListBox();
            this.btnlistarfor = new System.Windows.Forms.Button();
            this.btnListarWhile = new System.Windows.Forms.Button();
            this.gboCargadedatos.SuspendLayout();
            this.gboListadeDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // gboCargadedatos
            // 
            this.gboCargadedatos.Controls.Add(this.label1);
            this.gboCargadedatos.Controls.Add(this.BTNcARGA);
            this.gboCargadedatos.Controls.Add(this.txyNombre1);
            this.gboCargadedatos.Location = new System.Drawing.Point(68, 59);
            this.gboCargadedatos.Name = "gboCargadedatos";
            this.gboCargadedatos.Size = new System.Drawing.Size(353, 178);
            this.gboCargadedatos.TabIndex = 0;
            this.gboCargadedatos.TabStop = false;
            this.gboCargadedatos.Text = "Carga de Datos";
            this.gboCargadedatos.Enter += new System.EventHandler(this.gboCargadedatos_Enter);
            // 
            // txyNombre1
            // 
            this.txyNombre1.Location = new System.Drawing.Point(172, 49);
            this.txyNombre1.Name = "txyNombre1";
            this.txyNombre1.Size = new System.Drawing.Size(100, 20);
            this.txyNombre1.TabIndex = 1;
            // 
            // BTNcARGA
            // 
            this.BTNcARGA.Location = new System.Drawing.Point(164, 127);
            this.BTNcARGA.Name = "BTNcARGA";
            this.BTNcARGA.Size = new System.Drawing.Size(108, 37);
            this.BTNcARGA.TabIndex = 2;
            this.BTNcARGA.Text = "Cargar";
            this.BTNcARGA.UseVisualStyleBackColor = true;
            this.BTNcARGA.Click += new System.EventHandler(this.BTNcARGA_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nombre y Apellido";
            // 
            // gboListadeDatos
            // 
            this.gboListadeDatos.Controls.Add(this.btnListarWhile);
            this.gboListadeDatos.Controls.Add(this.btnlistarfor);
            this.gboListadeDatos.Controls.Add(this.lstPersonas);
            this.gboListadeDatos.Location = new System.Drawing.Point(68, 296);
            this.gboListadeDatos.Name = "gboListadeDatos";
            this.gboListadeDatos.Size = new System.Drawing.Size(370, 206);
            this.gboListadeDatos.TabIndex = 1;
            this.gboListadeDatos.TabStop = false;
            this.gboListadeDatos.Text = "Lista de Datos";
            this.gboListadeDatos.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lstPersonas
            // 
            this.lstPersonas.FormattingEnabled = true;
            this.lstPersonas.Location = new System.Drawing.Point(34, 36);
            this.lstPersonas.Name = "lstPersonas";
            this.lstPersonas.Size = new System.Drawing.Size(120, 95);
            this.lstPersonas.TabIndex = 0;
            this.lstPersonas.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // btnlistarfor
            // 
            this.btnlistarfor.Location = new System.Drawing.Point(112, 154);
            this.btnlistarfor.Name = "btnlistarfor";
            this.btnlistarfor.Size = new System.Drawing.Size(108, 37);
            this.btnlistarfor.TabIndex = 3;
            this.btnlistarfor.Text = "listar con for";
            this.btnlistarfor.UseVisualStyleBackColor = true;
            this.btnlistarfor.Click += new System.EventHandler(this.btnlistarfor_Click);
            // 
            // btnListarWhile
            // 
            this.btnListarWhile.Location = new System.Drawing.Point(244, 154);
            this.btnListarWhile.Name = "btnListarWhile";
            this.btnListarWhile.Size = new System.Drawing.Size(108, 37);
            this.btnListarWhile.TabIndex = 4;
            this.btnListarWhile.Text = "listar con While";
            this.btnListarWhile.UseVisualStyleBackColor = true;
            this.btnListarWhile.Click += new System.EventHandler(this.btnListarWhile_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 544);
            this.Controls.Add(this.gboListadeDatos);
            this.Controls.Add(this.gboCargadedatos);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gboCargadedatos.ResumeLayout(false);
            this.gboCargadedatos.PerformLayout();
            this.gboListadeDatos.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gboCargadedatos;
        private System.Windows.Forms.TextBox txyNombre1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BTNcARGA;
        private System.Windows.Forms.GroupBox gboListadeDatos;
        private System.Windows.Forms.ListBox lstPersonas;
        private System.Windows.Forms.Button btnlistarfor;
        private System.Windows.Forms.Button btnListarWhile;
    }
}

