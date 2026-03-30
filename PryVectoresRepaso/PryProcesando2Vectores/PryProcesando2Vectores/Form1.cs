using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PryProcesando2Vectores
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void DvgListar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        string[] Meses = new string[12] { "enero", "febrero", "marzo", "abril", "mayo", "junio", "julio", "agosto", "septiembre", "octubre", "noviembre", "diciembre" };
        Decimal[] Importes = new Decimal[12];
        private void BtnCargar_Click(object sender, EventArgs e)
        {
            Int32 i = CboMes.SelectedIndex;
            Decimal Importe = Convert.ToDecimal(txtImporte.Text);
            Importes[i] = Importes[i] + Importe;
            



            MessageBox.Show("el importe se cargo correctamente");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CboMes.Items.Clear();
            for (Int32 i = 0; i < Meses.Length; i++)
            {
                CboMes.Items.Add(Meses[i]);
            }
            CboMes.SelectedIndex = 0;
        }

        private void BtnListarConFor_Click(object sender, EventArgs e)
        {
            DvgListar.Rows.Clear();
            for (Int32 i = 0; i < Meses.Length; i++)
            {
                DvgListar.Rows.Add(Meses[i], Importes[i]);
            }
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            Listar();
            Int32 i = 0;
            DvgListar.Rows.Clear();
            while (i < Meses.Length)

            {
                DvgListar.Rows.Add(Meses[i], Importes[i]);
            }
        }
        private void Listar()
        {
            Int32 i = 0;
            DvgListar.Rows.Add(Meses  [i ], Importes [i]);
        }
    }   
}



