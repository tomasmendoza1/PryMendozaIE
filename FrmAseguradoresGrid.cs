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
    public partial class FrmAseguradoresGrid : MetroFramework.Forms.MetroForm
    {
        public FrmAseguradoresGrid()
        {
            InitializeComponent();
        }

        clsdatosproveedor x = new clsdatosproveedor();

        private void FrmAseguradoresGrid_Load(object sender, EventArgs e)
        {

        }

        private void BtnVerRegistros_Click(object sender, EventArgs e)
        {
            x.listar(Dgv);
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            FrmMainCliente frmMainCliente = new FrmMainCliente();
            frmMainCliente.Show();
            this.Hide();
        }
    }
}
