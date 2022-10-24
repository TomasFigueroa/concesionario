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
    public partial class Form1 : Form
    {
        private Autos autos = new Autos();
        private Stock stock = new Stock();
        public Form1()
        {
            InitializeComponent();
            dgautos.DataSource = autos.DT;
            LimpiarPantalla();
        }

     
        // boton de agregar
        private void Bt_agregar_Click(object sender, EventArgs e)
        {
            auto auto = new auto();
            if (Txt_patente.Text != "" || Txt_año.Text != "" || Txt_Marca.Text != "" || Txt_modelo.Text != "")
            {

                try // control de errores
                {
                    comprobar(txt_precio, errorP);
                    comprobar(Txt_año, errorA);
                    auto.Patente = Txt_patente.Text.ToUpper();
                    auto.Modelo = Txt_modelo.Text;
                    auto.Marca = Txt_Marca.Text.ToUpper();
                    auto.Estado = txt_disponible.Text;
                    auto.Precio = Convert.ToInt32(txt_precio.Text);
                    auto.Año = Convert.ToInt32(Txt_año.Text);
                    autos.CargarAutos(auto);
                }
                catch(Exception )
                {
                    comprobar(txt_precio, errorP);
                    comprobar(Txt_año,errorA);
                }
                
            }
        }
        // metodo para comprobar errores
        void comprobar(TextBox tex,ErrorProvider error)
        {
            bool con = false;
            foreach ( char caracter in tex.Text)
            if(!(char.IsDigit(caracter)))
            {
                    con = true;
            }
            if (con)
            {
                error.SetError(tex,"Nose aceptan datos no numericos");
            }
            else
            {
                error.Clear();
            }
        }
        // metodo para limpiar pantalla
        private void LimpiarPantalla()
        {
            Txt_año.Text = "";
            Txt_Marca.Text = "";
            Txt_modelo.Text = "";
            Txt_patente.Text = "";
            txt_disponible.Text = "";
            txt_precio.Text = "";

            Txt_patente.Focus();
        }
        // boton de buscar
        private void Bt_buscar_Click(object sender, EventArgs e)
        {
            Txt_modelo.Text = "";
            Txt_Marca.Text = "";
            Txt_año.Text = "";

            auto vehiculo = new auto();

            vehiculo = autos.BuscarAuto(Txt_patente.Text);

            if (vehiculo.Patente != null)
            {
                Txt_patente.Text = vehiculo.Patente.ToUpper();
                Txt_modelo.Text = vehiculo.Modelo;
                Txt_Marca.Text = vehiculo.Marca;
                txt_precio.Text = vehiculo.Precio.ToString();
                txt_disponible.Text = vehiculo.Estado;
                Txt_año.Text = vehiculo.Año.ToString();
            }

            Txt_año.Focus();
            Txt_año.SelectAll();
        }
        // boton de borrar
        private void Bt_borrar_Click(object sender, EventArgs e)
        {
            bool res = autos.BorrarAutos(Txt_patente.Text.ToUpper());

            if (res)
            {
                LimpiarPantalla();
            }
            else
            {
                Txt_patente.Focus();
                Txt_patente.SelectAll();
            }
        }
        // boton para abrir el segundo formulario
        public void Bt_stock_Click(object sender, EventArgs e)
        {

            Stock formularionuevo = new Stock();

            formularionuevo.ShowDialog();

        }
        bool Botom = false;

        // boton de modificar
        public void bt_Modificar_Click(object sender, EventArgs e)
        {


           
                Txt_modelo.Text = "";
                Txt_Marca.Text = "";
                Txt_año.Text = "";

                auto vehiculo = new auto();

                vehiculo = autos.BuscarAuto(Txt_patente.Text);

                if (vehiculo.Patente != null)
                {
                    Txt_patente.Text = vehiculo.Patente.ToUpper();
                    Txt_modelo.Text = vehiculo.Modelo;
                    Txt_Marca.Text = vehiculo.Marca;
                    txt_precio.Text = vehiculo.Precio.ToString();
                    txt_disponible.Text = vehiculo.Estado;
                    Txt_año.Text = vehiculo.Año.ToString();
                 Botom = true; 

                autos.BorrarAutos(Txt_patente.Text);
            }
                      


               

            }

        // boton para aceptar modificacion
        private void Bt_aceptar_Click(object sender, EventArgs e)
        {
            auto auto = new auto();
            
            if (Botom==true)
            {


                if (Txt_patente.Text != "" || Txt_año.Text != "" || Txt_Marca.Text != "" || Txt_modelo.Text != "")
                {


                    auto.Patente = Txt_patente.Text.ToUpper();
                    auto.Modelo = Txt_modelo.Text;
                    auto.Marca = Txt_Marca.Text;
                    auto.Estado = txt_disponible.Text;
                    auto.Precio = Convert.ToInt32(txt_precio.Text);
                    auto.Año = Convert.ToInt32(Txt_año.Text);
                    autos.Modificar(auto);

                    Txt_año.Focus();
                    Txt_año.SelectAll();

                    LimpiarPantalla();
                    Botom = false;



                }
            }
        }

      
    }
   
    }

