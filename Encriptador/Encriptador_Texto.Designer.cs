
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
            this.lstvwResultados = new System.Windows.Forms.ListBox();
            this.btnCopiar = new System.Windows.Forms.Button();
            this.rbDesencriptar = new System.Windows.Forms.RadioButton();
            this.rbEncriptar = new System.Windows.Forms.RadioButton();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.txtCadena = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
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
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lstvwResultados);
            this.groupBox1.Controls.Add(this.btnCerrar);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnCopiar);
            this.groupBox1.Controls.Add(this.rbDesencriptar);
            this.groupBox1.Controls.Add(this.rbEncriptar);
            this.groupBox1.Controls.Add(this.txtResultado);
            this.groupBox1.Controls.Add(this.btnReset);
            this.groupBox1.Controls.Add(this.btnEnviar);
            this.groupBox1.Controls.Add(this.txtCadena);
            this.groupBox1.Location = new System.Drawing.Point(27, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(717, 630);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // lstvwResultados
            // 
            this.lstvwResultados.FormattingEnabled = true;
            this.lstvwResultados.ItemHeight = 25;
            this.lstvwResultados.Location = new System.Drawing.Point(40, 347);
            this.lstvwResultados.Name = "lstvwResultados";
            this.lstvwResultados.Size = new System.Drawing.Size(651, 254);
            this.lstvwResultados.TabIndex = 6;
            this.lstvwResultados.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lstvwResultados_KeyDown);
            // 
            // btnCopiar
            // 
            this.btnCopiar.Location = new System.Drawing.Point(570, 263);
            this.btnCopiar.Name = "btnCopiar";
            this.btnCopiar.Size = new System.Drawing.Size(112, 34);
            this.btnCopiar.TabIndex = 5;
            this.btnCopiar.Text = "Copiar";
            this.btnCopiar.UseVisualStyleBackColor = true;
            this.btnCopiar.Click += new System.EventHandler(this.btnCopiar_Click);
            // 
            // rbDesencriptar
            // 
            this.rbDesencriptar.AutoSize = true;
            this.rbDesencriptar.Location = new System.Drawing.Point(31, 312);
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
            this.rbEncriptar.Location = new System.Drawing.Point(31, 277);
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
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(570, 186);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(112, 34);
            this.btnReset.TabIndex = 2;
            this.btnReset.Text = "Borrar";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(452, 186);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(112, 34);
            this.btnEnviar.TabIndex = 1;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // txtCadena
            // 
            this.txtCadena.Location = new System.Drawing.Point(83, 149);
            this.txtCadena.Name = "txtCadena";
            this.txtCadena.Size = new System.Drawing.Size(599, 31);
            this.txtCadena.TabIndex = 0;
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Resultado:";
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
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.TextBox txtCadena;
        private System.Windows.Forms.Button btnCopiar;
        private System.Windows.Forms.ListBox lstvwResultados;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}