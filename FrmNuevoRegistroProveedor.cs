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
    public partial class FrmNuevoRegistroProveedor : MetroFramework.Forms.MetroForm
    {
        public FrmNuevoRegistroProveedor()
        {
            InitializeComponent();
        }

        private void FrmNuevoRegistroProveedor_Load(object sender, EventArgs e)
        {

        }

        clsdatosproveedor guardar = new clsdatosproveedor();

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            guardar.grabar(TxtNumero.Text, TxtEntidad.Text, TxtApertura.Text, TxtNumeroDeExpediente.Text, TxtJuzg.Text, TxtJurisd.Text, TxtDireccion.Text, TxtLiquidadoResponsable.Text); //llamo al procedimiento de clase que cree anteriormente 

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

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
