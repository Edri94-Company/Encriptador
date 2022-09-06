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
    public partial class Encriptador_Texto : Form
    {
        public Encriptador_Texto()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
           
        }

        private void rbEncriptar_CheckedChanged(object sender, EventArgs e)
        {
            if (rbEncriptar.Checked == true)
            {
                rbDesencriptar.Checked = false;
            }
            else
            {
                rbDesencriptar.Checked = true;
            }
        }

        private void btnCopiar_Click(object sender, EventArgs e)
        {
           
        }

        private void lstvwResultados_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.C)
            {
                System.Text.StringBuilder copy_buffer = new System.Text.StringBuilder();
                foreach (object item in lstvwResultados.SelectedItems)
                    copy_buffer.AppendLine(item.ToString());

                if (copy_buffer.Length > 0)
                    Clipboard.SetText(copy_buffer.ToString());
            }
        }

        private void buttonPers11_Click(object sender, EventArgs e)
        {
            if (rbEncriptar.Checked == false && rbDesencriptar.Checked == false)
            {
                MessageBox.Show("Debe seleccionar una opcion.", "Error", MessageBoxButtons.OK);
            }
            else
            {
                Encriptacion encriptacion = new Encriptacion();

                if (txtCadena.Text != String.Empty)
                {
                    if (rbEncriptar.Checked == true)
                    {
                        txtResultado.Text = encriptacion.Encrypt(txtCadena.Text);
                    }
                    if (rbDesencriptar.Checked == true)
                    {
                        txtResultado.Text = encriptacion.Decrypt(txtCadena.Text);
                    }
                }

                string accion = (rbEncriptar.Checked) ? "Encriptado" : "Desencriptado";

                lstvwResultados.Items.Add($"[Original: {txtCadena.Text}] [{accion}: {txtResultado.Text}]");


                //Add items in the listview
                string[] arr = new string[3];
                ListViewItem item;

                //Add first item
                arr[0] = txtCadena.Text;
                arr[1] = txtResultado.Text;

                item = new ListViewItem(arr);
            }
        }

        private void buttonPers12_Click(object sender, EventArgs e)
        {
            txtResultado.Text = String.Empty;
            txtCadena.Text = String.Empty;
        }

        private void buttonPers13_Click(object sender, EventArgs e)
        {
            Clipboard.SetDataObject(txtResultado.Text, true);
        }
    }
}
