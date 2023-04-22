using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo1
{
    internal class Persona
    {
        public string Nombre { get; set; }
        public DateTime Fecha { get; set; }
        public string Chocolate { get; set; }

        public string Tipo { get; set; }

        public string ColorFavorito { get; set; }

        public string NumeroFavorito { get; set; }

       /*public string funcionTipo(bool queSera)
        {

            if (queSera)
              return  this.Tipo = "Muggle";
            else if (queSera)
               return  this.Tipo = "Wizard";
            else
                return this.Tipo = "Squibs"; 

        }
       */
        public void saludar() {

           MessageBox.Show("Nombre: " + this.Nombre + " Fecha:" + this.Fecha + ", " + this.Chocolate + ", es " + this.Tipo + ", su color favorito es " + this.ColorFavorito + ", su numero favorito es: " + this.NumeroFavorito);
                //"Nombre: " + nombre + " Fecha:" + fecha + ", " + chocolate + ", es " + tipo + ", su color favorito es " + colorFavorito + ", su numero favorito es: " + numeroFavorito;


        }

    }
}
