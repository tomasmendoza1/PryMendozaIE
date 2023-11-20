using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Libreria de base de datos 
using System.Data.OleDb;
using System.IO;
using System.Windows;
using System.Windows.Forms;
using System.Data;

namespace PryMendozaIE
{
    internal class Validar
    {
        // Conexion a objeto base de datos 
        OleDbConnection ConexionBd;

        string RutaDeArchivo;

        public string EstadoDeConexion;

        public string errores;

        //Me permite comandar la base de datos 
        OleDbCommand comandoBD;

        //Para ver los datos en mi interfaz
        OleDbDataReader LectorBD;

        public void ConectarBaseDatos()
        {
            try
            {
                //CODIGO DE DESEEO PROBAR
                RutaDeArchivo = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source= ../../Resources/Proveedores/EL_CLUB.accdb";

                ConexionBd = new OleDbConnection();

                ConexionBd.ConnectionString = RutaDeArchivo;

                ConexionBd.Open();

                EstadoDeConexion = "Conectado a la base";
            }
            catch (Exception exception)
            {
                //ERROR CAPTURADO
                EstadoDeConexion = "Error en la conecxión." + exception.Message;
            }
        }

        public void TraerDatos(DataGridView grilla)
        {
            try
            {
                //creo el comando en memoria
                comandoBD = new OleDbCommand(); 

                comandoBD.Connection = ConexionBd;

                //Defino el tipo de dato que voy a comandar 
                comandoBD.CommandType = System.Data.CommandType.TableDirect;

                //Defino que tabla voy a comandar
                comandoBD.CommandText = "SOCIOS";

                LectorBD = comandoBD.ExecuteReader();

                //Agrego columnas de la grilla
                grilla.Columns.Add("Nombre", "Nombre");
                grilla.Columns.Add("Apellido", "Apellido");
                grilla.Columns.Add("Edad", "Edad");
                grilla.Columns.Add("Ingreso", "Ingreso");
                grilla.Columns.Add("Puntaje", "Puntaje");

                while (LectorBD.Read())
                {
                    grilla.Rows.Add(LectorBD[1], LectorBD[2], LectorBD[4], LectorBD[6], LectorBD[7]);

                }
            }
            catch (Exception ex)
            {
                errores = ex.Message;
            }
        }

    }
}
