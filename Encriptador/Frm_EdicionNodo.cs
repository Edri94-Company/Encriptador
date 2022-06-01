using Encriptador.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Encriptador
{
    public partial class Frm_EdicionNodo : Form
    {
        public TreeNode nodo;
        Encriptacion encriptacion;
        public string valor_nuevo;
        public string grupo;

        public Frm_EdicionNodo()
        {
            InitializeComponent();
        }

        private void Frm_EdicionNodo_Load(object sender, EventArgs e)
        {
            encriptacion = new Encriptacion();

            if(this.nodo != null)
            {
                string key = nodo.Text.Split(':')[0].Trim();
                string value = nodo.Text.Split(':')[1].Trim();

                if (grupo == "")
                {
                    lblNodo.Text = key;
                }
                else
                {
                    lblNodo.Text = grupo + "." + key;
                }
                txtValue.Text = value;
            }
            else
            {
                this.Close();
            }
            
        }

        public void EstableceParametros(TreeNode nodo, string grupo = "")
        {
            this.nodo = nodo;
            this.grupo = grupo;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtValue.Text = nodo.Text.Split(':')[1];
            rbEncrypt.Checked = false;
            rbDecrypt.Checked = false;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if(rbEncrypt.Checked == true)
            {
                rbDecrypt.Checked = false;

                txtValue.Text = encriptacion.Encrypt(txtValue.Text);
                
            }

        }

        private void rbDecrypt_CheckedChanged(object sender, EventArgs e)
        {
            if (rbDecrypt.Checked == true)
            {
                rbEncrypt.Checked = false;
                txtValue.Text = encriptacion.Decrypt(txtValue.Text);
            }
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            if(txtValue.Text != "")
            {
                string key = nodo.Text.Split(':')[0];
                valor_nuevo = key + ":" + txtValue.Text;
                this.Close();
            }
            else
            {
                MessageBox.Show("No puede ir vacio el campo VALUE");
            }
        }
    }
}
