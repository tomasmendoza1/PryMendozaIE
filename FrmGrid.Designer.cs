namespace PryMendozaIE
{
    partial class FrmGrid
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Dgv = new System.Windows.Forms.DataGridView();
            this.Numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Entidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.APERTURA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NUMERODEEXPTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JUZG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JURISD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIRECCION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LIQUIDADORRESPONSABLE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnVerRegistros = new MetroFramework.Controls.MetroButton();
            this.BtnVolver = new MetroFramework.Controls.MetroButton();
            this.BtnSalir = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Dgv
            // 
            this.Dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Numero,
            this.Entidad,
            this.APERTURA,
            this.NUMERODEEXPTE,
            this.JUZG,
            this.JURISD,
            this.DIRECCION,
            this.LIQUIDADORRESPONSABLE});
            this.Dgv.Location = new System.Drawing.Point(23, 154);
            this.Dgv.Name = "Dgv";
            this.Dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgv.Size = new System.Drawing.Size(757, 197);
            this.Dgv.TabIndex = 0;
            // 
            // Numero
            // 
            this.Numero.HeaderText = "N°";
            this.Numero.Name = "Numero";
            // 
            // Entidad
            // 
            this.Entidad.HeaderText = "Entidad";
            this.Entidad.Name = "Entidad";
            // 
            // APERTURA
            // 
            this.APERTURA.HeaderText = "APERTURA";
            this.APERTURA.Name = "APERTURA";
            // 
            // NUMERODEEXPTE
            // 
            this.NUMERODEEXPTE.HeaderText = "Nº EXPTE.";
            this.NUMERODEEXPTE.Name = "NUMERODEEXPTE";
            // 
            // JUZG
            // 
            this.JUZG.HeaderText = "JUZG.";
            this.JUZG.Name = "JUZG";
            // 
            // JURISD
            // 
            this.JURISD.HeaderText = "JURISD";
            this.JURISD.Name = "JURISD";
            // 
            // DIRECCION
            // 
            this.DIRECCION.HeaderText = "DIRECCION";
            this.DIRECCION.Name = "DIRECCION";
            // 
            // LIQUIDADORRESPONSABLE
            // 
            this.LIQUIDADORRESPONSABLE.HeaderText = "LIQUIDADOR RESPONSABLE";
            this.LIQUIDADORRESPONSABLE.Name = "LIQUIDADORRESPONSABLE";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PryMendozaIE.Properties.Resources.logo_boston_1;
            this.pictureBox1.Location = new System.Drawing.Point(20, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(757, 125);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // BtnVerRegistros
            // 
            this.BtnVerRegistros.Location = new System.Drawing.Point(206, 357);
            this.BtnVerRegistros.Name = "BtnVerRegistros";
            this.BtnVerRegistros.Size = new System.Drawing.Size(400, 25);
            this.BtnVerRegistros.TabIndex = 3;
            this.BtnVerRegistros.Text = "Ver registros";
            this.BtnVerRegistros.Click += new System.EventHandler(this.BtnVerRegistros_Click);
            // 
            // BtnVolver
            // 
            this.BtnVolver.Location = new System.Drawing.Point(206, 393);
            this.BtnVolver.Name = "BtnVolver";
            this.BtnVolver.Size = new System.Drawing.Size(400, 25);
            this.BtnVolver.TabIndex = 4;
            this.BtnVolver.Text = "Volver";
            this.BtnVolver.Click += new System.EventHandler(this.BtnVolver_Click);
            // 
            // BtnSalir
            // 
            this.BtnSalir.Location = new System.Drawing.Point(206, 431);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(400, 25);
            this.BtnSalir.TabIndex = 5;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // FrmGrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 477);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.BtnVolver);
            this.Controls.Add(this.BtnVerRegistros);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Dgv);
            this.Name = "FrmGrid";
            this.Opacity = 0.9D;
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.FrmGrid_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Dgv;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroButton BtnVerRegistros;
        private MetroFramework.Controls.MetroButton BtnVolver;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn Entidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn APERTURA;
        private System.Windows.Forms.DataGridViewTextBoxColumn NUMERODEEXPTE;
        private System.Windows.Forms.DataGridViewTextBoxColumn JUZG;
        private System.Windows.Forms.DataGridViewTextBoxColumn JURISD;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIRECCION;
        private System.Windows.Forms.DataGridViewTextBoxColumn LIQUIDADORRESPONSABLE;
        private MetroFramework.Controls.MetroButton BtnSalir;
    }
}