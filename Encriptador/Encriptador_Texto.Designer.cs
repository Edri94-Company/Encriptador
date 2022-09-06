
namespace Encriptador
{
    partial class Encriptador_Texto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Encriptador_Texto));
            this.btnCerrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonPers13 = new Encriptador.Botones.ButtonPers1();
            this.buttonPers12 = new Encriptador.Botones.ButtonPers1();
            this.buttonPers11 = new Encriptador.Botones.ButtonPers1();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lstvwResultados = new System.Windows.Forms.ListBox();
            this.rbDesencriptar = new System.Windows.Forms.RadioButton();
            this.rbEncriptar = new System.Windows.Forms.RadioButton();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.txtCadena = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCerrar.BackgroundImage")));
            this.btnCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Location = new System.Drawing.Point(656, 27);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(44, 39);
            this.btnCerrar.TabIndex = 0;
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(186, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(324, 43);
            this.label1.TabIndex = 1;
            this.label1.Text = "Encriptador Texto";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonPers13);
            this.groupBox1.Controls.Add(this.buttonPers12);
            this.groupBox1.Controls.Add(this.buttonPers11);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lstvwResultados);
            this.groupBox1.Controls.Add(this.btnCerrar);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.rbDesencriptar);
            this.groupBox1.Controls.Add(this.rbEncriptar);
            this.groupBox1.Controls.Add(this.txtResultado);
            this.groupBox1.Controls.Add(this.txtCadena);
            this.groupBox1.Location = new System.Drawing.Point(27, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(717, 630);
            this.groupBox1.TabIndex = 2;
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
            this.buttonPers13.Location = new System.Drawing.Point(521, 263);
            this.buttonPers13.Name = "buttonPers13";
            this.buttonPers13.Size = new System.Drawing.Size(161, 37);
            this.buttonPers13.TabIndex = 10;
            this.buttonPers13.Text = "Copiar";
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
            this.buttonPers12.Location = new System.Drawing.Point(570, 186);
            this.buttonPers12.Name = "buttonPers12";
            this.buttonPers12.Size = new System.Drawing.Size(112, 34);
            this.buttonPers12.TabIndex = 9;
            this.buttonPers12.Text = "Borrar";
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
            this.buttonPers11.Location = new System.Drawing.Point(459, 184);
            this.buttonPers11.Name = "buttonPers11";
            this.buttonPers11.Size = new System.Drawing.Size(105, 36);
            this.buttonPers11.TabIndex = 8;
            this.buttonPers11.Text = "Enviar";
            this.buttonPers11.TextColor = System.Drawing.Color.White;
            this.buttonPers11.UseVisualStyleBackColor = false;
            this.buttonPers11.Click += new System.EventHandler(this.buttonPers11_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Resultado:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Texto:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lstvwResultados
            // 
            this.lstvwResultados.FormattingEnabled = true;
            this.lstvwResultados.HorizontalScrollbar = true;
            this.lstvwResultados.ItemHeight = 25;
            this.lstvwResultados.Location = new System.Drawing.Point(40, 322);
            this.lstvwResultados.Name = "lstvwResultados";
            this.lstvwResultados.ScrollAlwaysVisible = true;
            this.lstvwResultados.Size = new System.Drawing.Size(651, 279);
            this.lstvwResultados.TabIndex = 6;
            this.lstvwResultados.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lstvwResultados_KeyDown);
            // 
            // rbDesencriptar
            // 
            this.rbDesencriptar.AutoSize = true;
            this.rbDesencriptar.Location = new System.Drawing.Point(203, 187);
            this.rbDesencriptar.Name = "rbDesencriptar";
            this.rbDesencriptar.Size = new System.Drawing.Size(136, 29);
            this.rbDesencriptar.TabIndex = 4;
            this.rbDesencriptar.TabStop = true;
            this.rbDesencriptar.Text = "Desencriptar";
            this.rbDesencriptar.UseVisualStyleBackColor = true;
            // 
            // rbEncriptar
            // 
            this.rbEncriptar.AutoSize = true;
            this.rbEncriptar.Location = new System.Drawing.Point(91, 187);
            this.rbEncriptar.Name = "rbEncriptar";
            this.rbEncriptar.Size = new System.Drawing.Size(106, 29);
            this.rbEncriptar.TabIndex = 4;
            this.rbEncriptar.TabStop = true;
            this.rbEncriptar.Text = "Encriptar";
            this.rbEncriptar.UseVisualStyleBackColor = true;
            this.rbEncriptar.CheckedChanged += new System.EventHandler(this.rbEncriptar_CheckedChanged);
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(120, 226);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.ReadOnly = true;
            this.txtResultado.Size = new System.Drawing.Size(562, 31);
            this.txtResultado.TabIndex = 3;
            // 
            // txtCadena
            // 
            this.txtCadena.Location = new System.Drawing.Point(83, 149);
            this.txtCadena.Name = "txtCadena";
            this.txtCadena.Size = new System.Drawing.Size(599, 31);
            this.txtCadena.TabIndex = 0;
            // 
            // Encriptador_Texto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(770, 654);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Encriptador_Texto";
            this.Text = "Encriptador_Texto";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbDesencriptar;
        private System.Windows.Forms.RadioButton rbEncriptar;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.TextBox txtCadena;
        private System.Windows.Forms.ListBox lstvwResultados;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Botones.ButtonPers1 buttonPers11;
        private Botones.ButtonPers1 buttonPers12;
        private Botones.ButtonPers1 buttonPers13;
    }
}