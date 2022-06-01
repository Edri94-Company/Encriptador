
namespace Encriptador
{
    partial class Encriptador_Archivos
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Encriptador_Archivos));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonPers11 = new Encriptador.Botones.ButtonPers1();
            this.label8 = new System.Windows.Forms.Label();
            this.lblKeys = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tvConfiguraciones = new System.Windows.Forms.TreeView();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cboTipos = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblGuardar = new System.Windows.Forms.TextBox();
            this.lblArchivo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonPers11);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.lblKeys);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.tvConfiguraciones);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btnCerrar);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cboTipos);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lblGuardar);
            this.groupBox1.Controls.Add(this.lblArchivo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(27, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(717, 630);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
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
            this.buttonPers11.Location = new System.Drawing.Point(20, 507);
            this.buttonPers11.Name = "buttonPers11";
            this.buttonPers11.Size = new System.Drawing.Size(672, 60);
            this.buttonPers11.TabIndex = 14;
            this.buttonPers11.Text = "Encriptar Archivo";
            this.buttonPers11.TextColor = System.Drawing.Color.White;
            this.buttonPers11.UseVisualStyleBackColor = false;
            this.buttonPers11.Click += new System.EventHandler(this.buttonPers11_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Narrow", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(465, 213);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(227, 20);
            this.label8.TabIndex = 13;
            this.label8.Text = "Click en el elemnto que deseas editar";
            // 
            // lblKeys
            // 
            this.lblKeys.AutoSize = true;
            this.lblKeys.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblKeys.Location = new System.Drawing.Point(96, 469);
            this.lblKeys.Name = "lblKeys";
            this.lblKeys.Size = new System.Drawing.Size(0, 24);
            this.lblKeys.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(20, 469);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 24);
            this.label6.TabIndex = 11;
            this.label6.Text = "Keys:";
            // 
            // tvConfiguraciones
            // 
            this.tvConfiguraciones.Location = new System.Drawing.Point(12, 236);
            this.tvConfiguraciones.Name = "tvConfiguraciones";
            this.tvConfiguraciones.Size = new System.Drawing.Size(680, 230);
            this.tvConfiguraciones.TabIndex = 10;
            this.tvConfiguraciones.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.tvConfiguraciones_AfterCheck);
            this.tvConfiguraciones.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvConfiguraciones_AfterSelect);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 586);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Guardar en:";
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
            this.btnCerrar.TabIndex = 1;
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "Configuraciones:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(259, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "Ubicacion:";
            // 
            // cboTipos
            // 
            this.cboTipos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipos.FormattingEnabled = true;
            this.cboTipos.Location = new System.Drawing.Point(153, 152);
            this.cboTipos.Name = "cboTipos";
            this.cboTipos.Size = new System.Drawing.Size(100, 33);
            this.cboTipos.TabIndex = 8;
            this.cboTipos.SelectedIndexChanged += new System.EventHandler(this.cboTipos_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Tipo Archivo:";
            // 
            // lblGuardar
            // 
            this.lblGuardar.Location = new System.Drawing.Point(129, 583);
            this.lblGuardar.Name = "lblGuardar";
            this.lblGuardar.ReadOnly = true;
            this.lblGuardar.Size = new System.Drawing.Size(563, 31);
            this.lblGuardar.TabIndex = 6;
            // 
            // lblArchivo
            // 
            this.lblArchivo.Location = new System.Drawing.Point(358, 152);
            this.lblArchivo.Name = "lblArchivo";
            this.lblArchivo.ReadOnly = true;
            this.lblArchivo.Size = new System.Drawing.Size(334, 31);
            this.lblArchivo.TabIndex = 3;
            this.lblArchivo.DoubleClick += new System.EventHandler(this.lblArchivo_DoubleClick);
            this.lblArchivo.MouseHover += new System.EventHandler(this.lblArchivo_MouseHover);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(186, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(384, 43);
            this.label1.TabIndex = 2;
            this.label1.Text = "Encriptador Archivos";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Encriptador_Archivos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(770, 654);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Encriptador_Archivos";
            this.Text = "Encriptador_Archivos";
            this.Load += new System.EventHandler(this.Encriptador_Archivos_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox lblGuardar;
        private System.Windows.Forms.TextBox lblArchivo;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ComboBox cboTipos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.TreeView tvConfiguraciones;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblKeys;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ToolTip toolTip1;
        private Botones.ButtonPers1 buttonPers11;
    }
}