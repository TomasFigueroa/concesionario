
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend
{
    
    public class Autos
    {
        public DataTable DT { get; set; } = new DataTable();

        public Autos()
        {    

            DT.TableName = "Autos";
            DT.Columns.Add("Patente", typeof(string));
            DT.Columns.Add("Modelo", typeof(string));
            DT.Columns.Add("Marca", typeof(string));
            DT.Columns.Add("Año", typeof(int));
            DT.Columns.Add("Precio", typeof(string));
            DT.Columns.Add("Estado", typeof(string));
                
            

           
            
            Leer_DT();
        }
        // metodo para cargar los autos
        public bool CargarAutos(auto autos)
        {
            bool res = false;
            if (!Validar(autos))
            {
                
                DT.Rows.Add();
                int i = DT.Rows.Count - 1;

                DT.Rows[i]["Patente"] = autos.Patente;
                DT.Rows[i]["Modelo"] = autos.Modelo;
                DT.Rows[i]["Marca"] = autos.Marca;
                DT.Rows[i]["Año"] = autos.Año;
                DT.Rows[i]["Precio"] = autos.Precio;
                DT.Rows[i]["Estado"] = autos.Estado;

                DT.WriteXml("Autos.xml");

                res = true;
            }
            return res;
        }
        
    
        // metodo para borrar los autos
        public bool BorrarAutos(string vehiculo)
        {
            bool res = false;
            int fila = BuscarFilaAutos(vehiculo);

            if (fila != -1)
            {
                DT.Rows[fila].Delete();
                DT.WriteXml("Autos.xml");
                res = true;
            }

            return res;
        }
        // metodo para buscar por fila
        public int BuscarFilaAutos(string vehiculo)
        {
            int fila = -1;

            for (int i = 0; i < DT.Rows.Count; i++)
            {
                if (DT.Rows[i]["Patente"].ToString() == vehiculo)
                {
                    fila = i;
                    break;
                }
            }

            return fila;
        }
        // metodo de buscar
        public auto BuscarAuto(string vehiculo)
        {
            auto auto = new auto();

            for (int i = 0; i < DT.Rows.Count; i++)
            {
                if (DT.Rows[i]["Patente"].ToString() == vehiculo)
                {
                    auto.Patente = DT.Rows[i]["Patente"].ToString();
                    auto.Modelo = DT.Rows[i]["Modelo"].ToString();
                    auto.Marca = DT.Rows[i]["Marca"].ToString();
                    auto.Estado = DT.Rows[i]["Estado"].ToString();
                    auto.Año = System.Convert.ToInt32(DT.Rows[i]["Año"]);
                    auto.Precio = System.Convert.ToInt32(DT.Rows[i]["Precio"]);
                    break;
                }
            }

            return auto;
        }

        private void Leer_DT()
        {
            if (System.IO.File.Exists("Autos.xml"))
            {
                DT.ReadXml("Autos.xml");
            }
        }
        // metodo para validar 
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
        // metodo para modificar
        public bool Modificar(auto autos)
        {
            bool res = false;
            

                DT.Rows.Add();
                int i = DT.Rows.Count - 1;

                DT.Rows[i]["Patente"] = autos.Patente;
                DT.Rows[i]["Modelo"] = autos.Modelo;
                DT.Rows[i]["Marca"] = autos.Marca;
                DT.Rows[i]["Año"] = autos.Año;
                DT.Rows[i]["Precio"] = autos.Precio;
                DT.Rows[i]["Estado"] = autos.Estado;

                DT.WriteXml("Autos.xml");

                res = true;
            
            return res;
        }
    }
}

