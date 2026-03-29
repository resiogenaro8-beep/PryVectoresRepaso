using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PryEdResioG
{
    public partial class FrmEstructuraDeDatos: Form
    {
        public FrmEstructuraDeDatos()
        {
            InitializeComponent();
        }

        private void sailrToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void datosDelDesarrolladorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEstructuraDeDatos v = new FrmEstructuraDeDatos();
            v.ShowDialog();
        }
    }
         
}
