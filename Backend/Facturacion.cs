using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend
{

    public class Facturacion
    {
        public DataTable DG { get; set; } = new DataTable();
        public Facturacion()
        {
            DG.TableName = ("Facturacion");
            
            DG.Columns.Add("DNI", typeof(int));
            DG.Columns.Add("Nombre", typeof(string));
            DG.Columns.Add("Apellido", typeof(string));
            DG.Columns.Add("Patente", typeof(string));

            Leer_DG();
        }

        public bool CargarAutos(auto autos)
        {
            bool res = false;
            if (!Validar(autos))
            {

                DG.Rows.Add();
                int i = DG.Rows.Count - 1;

                DG.Rows[i]["DNI"] = autos.DNI;
                DG.Rows[i]["Nombre"] = autos.Nombre;
                DG.Rows[i]["Apellido"] = autos.Apellido;
                DG.Rows[i]["Patente"] = autos.Patente;

                DG.WriteXml("Facturacion.xml");

                res = true;
            }
            return res;
        }
        public void Leer_DG()
        {
            if (System.IO.File.Exists("Facturacion.xml"))
            {
                DG.ReadXml("Facturacion.xml");
            }
        }

        public auto BuscarAuto(string vehiculo)
        {
            auto auto = new auto();

            for (int i = 0; i < DG.Rows.Count; i++)
            {
                if (DG.Rows[i]["DNI"].ToString() == vehiculo)
                {
                    auto.DNI = DG.Rows[i]["DNI"].ToString();
                    auto.Apellido = DG.Rows[i]["Apellido"].ToString();
                    auto.Nombre = DG.Rows[i]["Nombre"].ToString();
                    auto.Patente = DG.Rows[i]["Patente"].ToString();
                    
                    break;
                }
            }

            return auto;
        }

        public int BuscarFilaAutos(string vehiculo)
        {
            int fila = -1;

            for (int i = 0; i < DG.Rows.Count; i++)
            {
                if (DG.Rows[i]["Patente"].ToString() == vehiculo)
                {
                    fila = i;
                    break;
                }
            }

            return fila;
        }
        private bool Validar(auto auto)
        {
            bool res = false;
            int fila = BuscarFilaAutos(auto.Patente);

            if (fila != -1)
            {
                res = true;
            }

            return res;
        }

    }

}
           