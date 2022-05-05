
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
            this.btnEncriptadorTxt = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.btnEncriptadorArchivos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Encriptador.Properties.Resources.encriptacion;
            this.pictureBox1.Location = new System.Drawing.Point(6, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(397, 300);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnEncriptadorArchivos);
            this.groupBox1.Controls.Add(this.btnEncriptadorTxt);
            this.groupBox1.Controls.Add(this.btnCerrar);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Location = new System.Drawing.Point(27, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(409, 657);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // btnEncriptadorTxt
            // 
            this.btnEncriptadorTxt.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnEncriptadorTxt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEncriptadorTxt.Location = new System.Drawing.Point(29, 336);
            this.btnEncriptadorTxt.Name = "btnEncriptadorTxt";
            this.btnEncriptadorTxt.Size = new System.Drawing.Size(355, 50);
            this.btnEncriptadorTxt.TabIndex = 2;
            this.btnEncriptadorTxt.Text = "Encriptador Texto";
            this.btnEncriptadorTxt.UseVisualStyleBackColor = false;
            this.btnEncriptadorTxt.Click += new System.EventHandler(this.btnEncriptadorTxt_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Location = new System.Drawing.Point(29, 599);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(355, 41);
            this.btnCerrar.TabIndex = 2;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.button1_Click);
            // 
            // panelContenedor
            // 
            this.panelContenedor.Location = new System.Drawing.Point(453, 15);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(770, 654);
            this.panelContenedor.TabIndex = 2;
            // 
            // btnEncriptadorArchivos
            // 
            this.btnEncriptadorArchivos.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnEncriptadorArchivos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEncriptadorArchivos.Location = new System.Drawing.Point(29, 403);
            this.btnEncriptadorArchivos.Name = "btnEncriptadorArchivos";
            this.btnEncriptadorArchivos.Size = new System.Drawing.Size(355, 50);
            this.btnEncriptadorArchivos.TabIndex = 2;
            this.btnEncriptadorArchivos.Text = "Encriptador Archivos";
            this.btnEncriptadorArchivos.UseVisualStyleBackColor = false;
            this.btnEncriptadorArchivos.Click += new System.EventHandler(this.btnEncriptadorTxt_Click);
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnEncriptadorTxt;
        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.Button btnEncriptadorArchivos;
    }
}

