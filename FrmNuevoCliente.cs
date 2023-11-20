using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PryMendozaIE
{
    public partial class FrmNuevoCliente : MetroFramework.Forms.MetroForm
    {
        public FrmNuevoCliente()
        {
            InitializeComponent();
        }

        private void FrmNuevoCliente_Load(object sender, EventArgs e)
        {
           
        }

        ClsDatos guardar = new ClsDatos();//instancio el objeto "guardar"

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            guardar.grabar(TxtNumero.Text, TxtEntidad.Text,TxtApertura.Text,TxtNumeroDeExpediente.Text,TxtJuzg.Text,TxtJurisd.Text,TxtDireccion.Text,TxtLiquidadoResponsable.Text); //llamo al procedimiento de clase que cree anteriormente 
           
            MessageBox.Show("Datos guardados correctamente");

            //Limpiar campos
            TxtNumero.Text = "";
            TxtEntidad.Text = "";
            TxtApertura.Text = "";
            TxtNumeroDeExpediente.Text = "";
            TxtJuzg.Text = "";
            TxtJurisd.Text = "";
            TxtDireccion.Text = "";
            TxtLiquidadoResponsable.Text = "";

        }

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            FrmMainCliente frmMainCliente = new FrmMainCliente();
            frmMainCliente.Show();
            this.Hide();
        }

        private void TxtNumero_Click(object sender, EventArgs e)
        {
            
        }

        private void TxtEntidad_Click(object sender, EventArgs e)
        {
           
        }

        private void TxtApertura_Click(object sender, EventArgs e)
        {
            
        }

        private void TxtNumeroDeExpediente_Click(object sender, EventArgs e)
        {
            
        }

        private void TxtJuzg_Click(object sender, EventArgs e)
        {
            
        }

        private void TxtJurisd_Click(object sender, EventArgs e)
        {
           
        }

        private void TxtDireccion_Click(object sender, EventArgs e)
        {
            
        }

        private void TxtLiquidadoResponsable_Click(object sender, EventArgs e)
        {
            
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
