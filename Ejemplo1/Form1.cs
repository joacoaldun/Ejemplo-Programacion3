using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace Ejemplo1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string elem = txtNombre.Text;
            lvElementos.Items.Add(elem);
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cboColorFavorito.Items.Add("Rojo");
            cboColorFavorito.Items.Add("Verde");
            cboColorFavorito.Items.Add("Negro");
        }

        private void btnVerPerfil_Click(object sender, EventArgs e)
        {

            Persona persona = new Persona();

            persona.Nombre = txtNombre.Text;

            persona.Fecha = dtpFechaNacimiento.Value;



            //string nombre = txtNombre.Text;
            //DateTime fecha = dtpFechaNacimiento.Value;
            ////operador ternario
            //string chocolate = ckbChocolate.Checked == true ? "Le gusta el chocolate" : "Odia el chocolate";

            persona.Chocolate = ckbChocolate.Checked == true ? "Le gusta el chocolate" : "Odia el chocolate";

            //string tipo;
            //if (rbtMuggle.Checked)
            //    tipo = "Muggle";
            //else if (rbtWizard.Checked)
            //    tipo = "Wizard";
            //else 
            //    tipo = "Squibs"; 


            if (rbtMuggle.Checked)
                persona.Tipo = "Muggle";
            else if (rbtWizard.Checked)
                persona.Tipo = "Wizard";
            else
                persona.Tipo = "Squibs";

            persona.ColorFavorito = cboColorFavorito.SelectedItem.ToString();

            persona.NumeroFavorito = numNumerosFavoritos.Value.ToString();

            //string colorFavorito = cboColorFavorito.SelectedItem.ToString();
            //string numeroFavorito = numNumerosFavoritos.Value.ToString();
           
            persona.saludar();

            //string mensaje = chocolate + ", es " + tipo + ", su color favorito es " + colorFavorito + ", su numero favorito es: " + numeroFavorito;
            //MessageBox.Show("Nombre: " + nombre + " Fecha:" + fecha + ", " + mensaje);  
        }
    }
}
