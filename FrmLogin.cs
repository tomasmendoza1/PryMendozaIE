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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void TxtUser_Enter(object sender, EventArgs e)
        {
            if (TxtUser.Text == "Usuario")
            {
                TxtUser.Text = "";
                TxtUser.ForeColor = Color.LightGray;
            }
        }

        private void TxtUser_Leave(object sender, EventArgs e)
        {
            if (TxtUser.Text == "")
            {
                TxtUser.Text = "Usuario";
                TxtUser.ForeColor = Color.DimGray;
            }
        }

        private void TxtPass_Enter(object sender, EventArgs e)
        {
            if (TxtPass.Text == "Contraseña")
            {
                TxtPass.Text = "";
                TxtPass.ForeColor = Color.LightGray;
                TxtPass.UseSystemPasswordChar = true;
            }
        }

        private void TxtPass_Leave(object sender, EventArgs e)
        {
            if (TxtPass.Text=="")
            {
                TxtPass.Text = "Contraseña";
                TxtPass.ForeColor = Color.DimGray;
                TxtPass.UseSystemPasswordChar = false;
            }
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnMinizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            Login objUsuario = new Login();

            objUsuario.ValidarUsuario(TxtUser.Text, TxtPass.Text);

            if (objUsuario.estadoConexion == "El Usuario fue encontrado!")
            {
                MessageBox.Show("Ingrese al sistema...");
                objUsuario.RegistroLogInicioSesion();
            }
            else
            {
                MessageBox.Show("Accseso denegado");
                objUsuario.RegistroLogInicioSesion();
            }

            FrmMainCliente frmMainCliente = new FrmMainCliente();
            frmMainCliente.Show();
            this.Hide();

            //Tomar Nombre de txt Usuario y llevarlo al otro formulario

            frmMainCliente.TxtUserBienvenido.Text = this.TxtUser.Text;
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
