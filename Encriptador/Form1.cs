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
using Encriptador.Helpers;

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
           
        }

        private void frmContenedor_Load(object sender, EventArgs e)
        {
            string nombre_appconfig = "Encriptador.dll.config";
            string appPath = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            string[] appPath_arr = appPath.Split('\\');
            string configFile = System.IO.Path.Combine(appPath, nombre_appconfig);
            ExeConfigurationFileMap configFileMap = new ExeConfigurationFileMap();
            configFileMap.ExeConfigFilename = configFile;
            System.Configuration.Configuration config = ConfigurationManager.OpenMappedExeConfiguration(configFileMap, ConfigurationUserLevel.None);

            foreach (KeyValueConfigurationElement configuracion in config.AppSettings.Settings)
            {
                switch (configuracion.Key)
                {
                    case "LOG.Escribe":
                        Log.EscribeLog = (configuracion.Value == "1");
                        break;
                    case "LOG.Ruta":
                        Log.RutaLog = configuracion.Value;
                        break;
                }
            }
        }

        private void buttonPers11_Click(object sender, EventArgs e)
        {
            AbrirFormEncriptadorTxt(new Encriptador_Texto());
        }

        private void buttonPers12_Click(object sender, EventArgs e)
        {
            AbrirFormEncriptadorTxt(new Encriptador_Archivos());
        }

        private void buttonPers13_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            AbrirFormConfiguraciones(new Frm_Configuraciones());
        }

        private void AbrirFormConfiguraciones(Frm_Configuraciones frm_Configuraciones)
        {
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);
            Form fh = frm_Configuraciones as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(fh);
            this.panelContenedor.Tag = fh;
            fh.Show();
        }
    }
}
