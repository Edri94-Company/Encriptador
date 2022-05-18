
namespace Encriptador
{
    partial class frmContenedor
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonPers13 = new Encriptador.Botones.ButtonPers1();
            this.buttonPers12 = new Encriptador.Botones.ButtonPers1();
            this.buttonPers11 = new Encriptador.Botones.ButtonPers1();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.btnCerrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Encriptador.Properties.Resources.encriptacion;
            this.pictureBox1.Location = new System.Drawing.Point(6, 94);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(397, 300);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCerrar);
            this.groupBox1.Controls.Add(this.buttonPers13);
            this.groupBox1.Controls.Add(this.buttonPers12);
            this.groupBox1.Controls.Add(this.buttonPers11);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Location = new System.Drawing.Point(27, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(409, 657);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // buttonPers13
            // 
            this.buttonPers13.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonPers13.BackGroundColor = System.Drawing.Color.RoyalBlue;
            this.buttonPers13.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.buttonPers13.BorderRadius = 40;
            this.buttonPers13.BorderSize = 0;
            this.buttonPers13.FlatAppearance.BorderSize = 0;
            this.buttonPers13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPers13.ForeColor = System.Drawing.Color.White;
            this.buttonPers13.Location = new System.Drawing.Point(29, 591);
            this.buttonPers13.Name = "buttonPers13";
            this.buttonPers13.Size = new System.Drawing.Size(355, 60);
            this.buttonPers13.TabIndex = 5;
            this.buttonPers13.Text = "Cerrar";
            this.buttonPers13.TextColor = System.Drawing.Color.White;
            this.buttonPers13.UseVisualStyleBackColor = false;
            this.buttonPers13.Click += new System.EventHandler(this.buttonPers13_Click);
            // 
            // buttonPers12
            // 
            this.buttonPers12.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonPers12.BackGroundColor = System.Drawing.Color.RoyalBlue;
            this.buttonPers12.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.buttonPers12.BorderRadius = 40;
            this.buttonPers12.BorderSize = 0;
            this.buttonPers12.FlatAppearance.BorderSize = 0;
            this.buttonPers12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPers12.ForeColor = System.Drawing.Color.White;
            this.buttonPers12.Location = new System.Drawing.Point(29, 466);
            this.buttonPers12.Name = "buttonPers12";
            this.buttonPers12.Size = new System.Drawing.Size(355, 60);
            this.buttonPers12.TabIndex = 4;
            this.buttonPers12.Text = "Encriptador Archivos";
            this.buttonPers12.TextColor = System.Drawing.Color.White;
            this.buttonPers12.UseVisualStyleBackColor = false;
            this.buttonPers12.Click += new System.EventHandler(this.buttonPers12_Click);
            // 
            // buttonPers11
            // 
            this.buttonPers11.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonPers11.BackGroundColor = System.Drawing.Color.RoyalBlue;
            this.buttonPers11.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.buttonPers11.BorderRadius = 40;
            this.buttonPers11.BorderSize = 0;
            this.buttonPers11.FlatAppearance.BorderSize = 0;
            this.buttonPers11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPers11.ForeColor = System.Drawing.Color.White;
            this.buttonPers11.Location = new System.Drawing.Point(29, 400);
            this.buttonPers11.Name = "buttonPers11";
            this.buttonPers11.Size = new System.Drawing.Size(355, 60);
            this.buttonPers11.TabIndex = 3;
            this.buttonPers11.Text = "Encriptador Texto";
            this.buttonPers11.TextColor = System.Drawing.Color.White;
            this.buttonPers11.UseVisualStyleBackColor = false;
            this.buttonPers11.Click += new System.EventHandler(this.buttonPers11_Click);
            // 
            // panelContenedor
            // 
            this.panelContenedor.Location = new System.Drawing.Point(453, 12);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(770, 657);
            this.panelContenedor.TabIndex = 2;
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackgroundImage = global::Encriptador.Properties.Resources.conf_button;
            this.btnCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Location = new System.Drawing.Point(359, 30);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(44, 39);
            this.btnCerrar.TabIndex = 7;
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // frmContenedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(1233, 677);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmContenedor";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmContenedor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panelContenedor;
        private Botones.ButtonPers1 buttonPers11;
        private Botones.ButtonPers1 buttonPers12;
        private Botones.ButtonPers1 buttonPers13;
        private System.Windows.Forms.Button btnCerrar;
    }
}

