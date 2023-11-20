using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
//libreria de lectura de archivos
using System.Data.OleDb;





namespace PryMendozaIE
{
    public partial class FrmMainCliente : Form
    {
        Validar objAccesoBD;

        public FrmMainCliente()
        {
            InitializeComponent();
            objAccesoBD = new Validar();


        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TxtUser_TextChanged(object sender, EventArgs e)
        {
           
        }

        //metodo para crear nodos
        private TreeNode CrearArbol(DirectoryInfo directoryInfo)
        {
            TreeNode treeNode = new TreeNode(directoryInfo.Name);

            foreach (var item in directoryInfo.GetDirectories())
            {
                treeNode.Nodes.Add(CrearArbol(item));
            }
            foreach (var item in directoryInfo.GetFiles())
            {
                treeNode.Nodes.Add(new TreeNode(item.Name));
            }
            return treeNode;
        }

        private void FrmMainCliente_Load(object sender, EventArgs e)
        { 
            //CONECTAR BASE 
            Validar objAccesoBD = new Validar();
            objAccesoBD.ConectarBaseDatos();
            LblEstadoConexion.Text = objAccesoBD.EstadoDeConexion;


            objAccesoBD.TraerDatos(Dgvsocios);


            //indico ruta
            string RutaArchivos = "C:\\Users\\Tomas\\Desktop\\BASE DE DATOS CASALES\\PROYECTO ACTUALIZADO\\PryMendozaIEFinal-master\\Resources\\Proveedores\\Listado de precios";
            //limpio nodos por si llega a venir cargado el archivo
            tv.Nodes.Clear();
            //asigno mi ruta de archivo a mi nuevo objeto
            DirectoryInfo directoryInfo = new DirectoryInfo(RutaArchivos);
            //CREO LOS NODOS A PARTAR DE MI FUNCION CREADA 
            tv.Nodes.Add(CrearArbol(directoryInfo));

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void nuevoRegistroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmNuevoCliente frmNuevoCliente = new FrmNuevoCliente();
            frmNuevoCliente.Show();
            this.Hide();
        }

        private void verRegistrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmGrid frmGrid = new FrmGrid();
            frmGrid.Show();
            this.Hide();
        }

        private void verRegistroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAseguradoresGrid frmAseguradoresGrid = new FrmAseguradoresGrid();
            frmAseguradoresGrid.Show();
            this.Hide();
        }

        private void nuevoRegistroToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmNuevoRegistroProveedor frmNuevoRegistroProveedor = new FrmNuevoRegistroProveedor();
            frmNuevoRegistroProveedor.Show();
            this.Hide();
        }

        private void tv_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void listView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

       

        private void tv_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {

           
        }

        private void BtnBd_Click(object sender, EventArgs e)
        {
            

        }

        private void BtnBD_Click_1(object sender, EventArgs e)
        {
            
        }
    }
}
 