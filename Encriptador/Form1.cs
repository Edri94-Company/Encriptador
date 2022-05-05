using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace Encriptador
{
    public partial class frmContenedor : Form
    {
        public frmContenedor()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEncriptadorTxt_Click(object sender, EventArgs e)
        {
            AbrirFormEncriptadorTxt(new Encriptador_Texto());
        }

        private void AbrirFormEncriptadorTxt(object FrmEncriptadorTxt )
        {
            if (this.panelContenedor.Controls.Count > 0)  
                this.panelContenedor.Controls.RemoveAt(0);
            Form fh = FrmEncriptadorTxt as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(fh);
            this.panelContenedor.Tag = fh;
            fh.Show();
            
        }

        private void AbrirFormEncriptadorArchivos(object FrmEncriptadorArchivos)
        {
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);
            Form fh = FrmEncriptadorArchivos as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(fh);
            this.panelContenedor.Tag = fh;
            fh.Show();

        }

        private void btnEncriptadorArchivos_Click(object sender, EventArgs e)
        {
            AbrirFormEncriptadorTxt(new Encriptador_Archivos());
        }

        private void frmContenedor_Load(object sender, EventArgs e)
        {
            
        }
    }
}
