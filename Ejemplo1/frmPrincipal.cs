using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo1
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            //Agrego un comentario para testear github
            InitializeComponent();
        }

        private void perfilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (var item in Application.OpenForms)// NO TE PERMITE ABRIR MAS VECES LA MISMA VENTANA SI ESTA ESTA ABIERTA
            {
                if (item.GetType() == typeof(Form1)) {

                    MessageBox.Show("YA EXISTE ESA VENTANA ABIERTA, TERMINE DE TRABAJAR ALLI");
                return;
            }
            }

            Form1 ventana = new Form1();
            ventana.MdiParent = this;
            ventana.Show(); // EL SHOWDIALOG NO FUNCIONA CON EL MDIPARENT   
        }

        private void tsbPerfilPersona_Click(object sender, EventArgs e)
        {
            Form1 ventana = new Form1();
            ventana.ShowDialog();
        }
    }
}
