namespace PryMendozaIE
{
    partial class FrmLogin
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
            this.PanelBorder = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.PanelLine = new System.Windows.Forms.Panel();
            this.TxtUser = new System.Windows.Forms.TextBox();
            this.TxtPass = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LlblTitulo = new System.Windows.Forms.Label();
            this.BtnLogin = new System.Windows.Forms.Button();
            this.LinkPass = new System.Windows.Forms.LinkLabel();
            this.BtnMinizar = new System.Windows.Forms.PictureBox();
            this.BtnCerrar = new System.Windows.Forms.PictureBox();
            this.PanelBorder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnMinizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelBorder
            // 
            this.PanelBorder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.PanelBorder.Controls.Add(this.pictureBox3);
            this.PanelBorder.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelBorder.Location = new System.Drawing.Point(0, 0);
            this.PanelBorder.Name = "PanelBorder";
            this.PanelBorder.Size = new System.Drawing.Size(250, 300);
            this.PanelBorder.TabIndex = 0;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::PryMendozaIE.Properties.Resources.logo_boston_1;
            this.pictureBox3.Location = new System.Drawing.Point(3, 70);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(244, 105);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // PanelLine
            // 
            this.PanelLine.BackColor = System.Drawing.Color.Gray;
            this.PanelLine.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.PanelLine.Location = new System.Drawing.Point(306, 92);
            this.PanelLine.Name = "PanelLine";
            this.PanelLine.Size = new System.Drawing.Size(400, 1);
            this.PanelLine.TabIndex = 1;
            // 
            // TxtUser
            // 
            this.TxtUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.TxtUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtUser.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtUser.ForeColor = System.Drawing.Color.Gray;
            this.TxtUser.Location = new System.Drawing.Point(306, 70);
            this.TxtUser.Name = "TxtUser";
            this.TxtUser.Size = new System.Drawing.Size(400, 20);
            this.TxtUser.TabIndex = 1;
            this.TxtUser.Text = "Usuario";
            this.TxtUser.Enter += new System.EventHandler(this.TxtUser_Enter);
            this.TxtUser.Leave += new System.EventHandler(this.TxtUser_Leave);
            // 
            // TxtPass
            // 
            this.TxtPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.TxtPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtPass.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPass.ForeColor = System.Drawing.Color.Gray;
            this.TxtPass.Location = new System.Drawing.Point(306, 116);
            this.TxtPass.Name = "TxtPass";
            this.TxtPass.Size = new System.Drawing.Size(400, 20);
            this.TxtPass.TabIndex = 2;
            this.TxtPass.Text = "Contraseña";
            this.TxtPass.Enter += new System.EventHandler(this.TxtPass_Enter);
            this.TxtPass.Leave += new System.EventHandler(this.TxtPass_Leave);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panel1.Location = new System.Drawing.Point(306, 138);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 1);
            this.panel1.TabIndex = 4;
            // 
            // LlblTitulo
            // 
            this.LlblTitulo.AutoSize = true;
            this.LlblTitulo.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LlblTitulo.ForeColor = System.Drawing.Color.DimGray;
            this.LlblTitulo.Location = new System.Drawing.Point(450, 9);
            this.LlblTitulo.Name = "LlblTitulo";
            this.LlblTitulo.Size = new System.Drawing.Size(85, 33);
            this.LlblTitulo.TabIndex = 7;
            this.LlblTitulo.Text = "Login";
            // 
            // BtnLogin
            // 
            this.BtnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.BtnLogin.FlatAppearance.BorderSize = 0;
            this.BtnLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.BtnLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLogin.ForeColor = System.Drawing.Color.Gainsboro;
            this.BtnLogin.Location = new System.Drawing.Point(306, 202);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(400, 40);
            this.BtnLogin.TabIndex = 3;
            this.BtnLogin.Text = "Ingresar";
            this.BtnLogin.UseVisualStyleBackColor = false;
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // LinkPass
            // 
            this.LinkPass.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.LinkPass.AutoSize = true;
            this.LinkPass.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LinkPass.LinkColor = System.Drawing.Color.DimGray;
            this.LinkPass.Location = new System.Drawing.Point(399, 254);
            this.LinkPass.Name = "LinkPass";
            this.LinkPass.Size = new System.Drawing.Size(204, 17);
            this.LinkPass.TabIndex = 0;
            this.LinkPass.TabStop = true;
            this.LinkPass.Text = "¿Has olvidado tu contraseña?";
            // 
            // BtnMinizar
            // 
            this.BtnMinizar.Image = global::PryMendozaIE.Properties.Resources.minimizar;
            this.BtnMinizar.Location = new System.Drawing.Point(728, 13);
            this.BtnMinizar.Name = "BtnMinizar";
            this.BtnMinizar.Size = new System.Drawing.Size(20, 20);
            this.BtnMinizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnMinizar.TabIndex = 11;
            this.BtnMinizar.TabStop = false;
            this.BtnMinizar.Click += new System.EventHandler(this.BtnMinizar_Click);
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.Image = global::PryMendozaIE.Properties.Resources.icone_x_grise;
            this.BtnCerrar.Location = new System.Drawing.Point(754, 15);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(13, 13);
            this.BtnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnCerrar.TabIndex = 10;
            this.BtnCerrar.TabStop = false;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(780, 300);
            this.Controls.Add(this.BtnMinizar);
            this.Controls.Add(this.BtnCerrar);
            this.Controls.Add(this.LinkPass);
            this.Controls.Add(this.BtnLogin);
            this.Controls.Add(this.LlblTitulo);
            this.Controls.Add(this.TxtPass);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.TxtUser);
            this.Controls.Add(this.PanelLine);
            this.Controls.Add(this.PanelBorder);
            this.ForeColor = System.Drawing.Color.LightGray;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmLogin";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmLogin";
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            this.PanelBorder.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnMinizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnCerrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PanelBorder;
        private System.Windows.Forms.Panel PanelLine;
        public System.Windows.Forms.TextBox TxtUser;
        private System.Windows.Forms.TextBox TxtPass;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LlblTitulo;
        private System.Windows.Forms.Button BtnLogin;
        private System.Windows.Forms.LinkLabel LinkPass;
        private System.Windows.Forms.PictureBox BtnCerrar;
        private System.Windows.Forms.PictureBox BtnMinizar;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}