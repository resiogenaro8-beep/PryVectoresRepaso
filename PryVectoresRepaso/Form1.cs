using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PryVectoresRepaso
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string[] usuarios = new string[10];
        Int32 INDICE = 0;
        private int i;

        private void gboCargadedatos_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BTNcARGA_Click(object sender, EventArgs e)
        {


            if (INDICE < 10)
            {
                usuarios[INDICE] = txyNombre1.Text;
                INDICE++;
                MessageBox.Show("El dato se cargo correctamente");
                txyNombre1.Text = "";
                listar();
            }
            else
            {
                MessageBox.Show("no se puede cargar mas datos");

            }


            {


            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnlistarfor_Click(object sender, EventArgs e)
        {
            for (Int32 i = 0; i < INDICE; i++) ;
            lstPersonas.Items.Add(usuarios[i]); 
        }

        private void btnListarWhile_Click(object sender, EventArgs e)
        {
            lstPersonas.Items.Clear();
            Int32 i = 0;
            while (i< INDICE) 
            {
                lstPersonas.Items.Add(usuarios[i]);
            }
        }
        private void listar()
        {
            for (Int32 i = 0; i < INDICE; i++) ;
            lstPersonas.Items.Add(usuarios[i]);
        }
    }
}



