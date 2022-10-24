using Backend;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace concesionario
{

    public partial class Stock : Form
    {

        private Facturacion stock = new Facturacion();


        public Stock()
        {
            
            InitializeComponent();
            Dgstock.DataSource = stock.DG;
            
            LimpiarPantalla();
            
        }

       





        // boton de agregar segundo formulario
        private void Bt_Agregar_Click(object sender, EventArgs e)
        {

            auto auto = new auto();
            
            if (txt_dni.Text != "" || txt_nombre.Text != "" || txt_apellido.Text != "" || txt_patente.Text != "")

            {

                try
                {
                    auto.Patente = txt_patente.Text.ToUpper();
                    auto.DNI = txt_dni.Text;
                    auto.Apellido = txt_apellido.Text;
                    auto.Nombre = txt_nombre.Text;

                    stock.CargarAutos(auto);
                }
                catch (Exception)
                {
                    comprobar(txt_dni,errorD);
                    
                }
                
            }




        }
        // metodo para comprobar errores
        void comprobar(TextBox tex, ErrorProvider error)
        {
            bool con = false;
            foreach (char caracter in tex.Text)
                if (!(char.IsDigit(caracter)))
                {
                    con = true;
                }
            if (con)
            {
                error.SetError(tex, "Nose aceptan datos no numericos");
            }
            else
            {
                error.Clear();
            }
        }



        // boton para buscar
        private void Bt_buscar_Click(object sender, EventArgs e)
        {

            txt_nombre.Text = "";
            txt_apellido.Text = "";
            txt_patente.Text = "";

            auto vehiculo = new auto();

            vehiculo = stock.BuscarAuto(txt_dni.Text);

            if (vehiculo.DNI != null)
            {
                txt_patente.Text = vehiculo.Patente.ToUpper();
                txt_dni.Text = vehiculo.DNI;
                txt_apellido.Text = vehiculo.Apellido;
                txt_nombre.Text = vehiculo.Nombre;
            }

      
        }

        // metodo de limpiar pantalla
        private void LimpiarPantalla()
        {
            txt_patente.Text = "";
            txt_nombre.Text = "";
            txt_apellido.Text = "";
            

            txt_dni.Focus();
        }

        private void Dgstock_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }
    }
}
