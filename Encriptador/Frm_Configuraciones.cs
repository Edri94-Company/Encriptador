using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Encriptador
{
    public partial class Frm_Configuraciones : Form
    {
        public Frm_Configuraciones()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void PrenderConfiguracion(string key, bool prender)
        {
            string value = prender.ToString();
            string nombre_appconfig = "Encriptador.dll.config";

            bool bandera_archivo_existe = false;
            try
            {
                string appPath = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
                string[] appPath_arr = appPath.Split('\\');


                if (File.Exists(System.IO.Path.Combine(appPath, nombre_appconfig)))
                {
                    string configFile = System.IO.Path.Combine(appPath, nombre_appconfig);
                    ExeConfigurationFileMap configFileMap = new ExeConfigurationFileMap();
                    configFileMap.ExeConfigFilename = configFile;
                    System.Configuration.Configuration config = ConfigurationManager.OpenMappedExeConfiguration(configFileMap, ConfigurationUserLevel.None);
                    config.AppSettings.Settings[key].Value = value;
                    
                    config.Save();
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void swbPasswrds_CheckedChanged(object sender, EventArgs e)
        {
            if(swbPasswrds.Checked == true)
            {
                PrenderConfiguracion("campos_password", true);
            }
            else
            {
                PrenderConfiguracion("campos_password", false);
            }

        }

        private void CargarConfiguraciones()
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
                    case "campos_password":
                        if (configuracion.Value == "True")
                        {
                            swbPasswrds.Checked = true;
                        }
                        else if(configuracion.Value == "False")
                        {
                            swbPasswrds.Checked = false;
                        }
                        break;

                    default:
                    
                    break;
                }
            }
        }

        private void Frm_Configuraciones_Load(object sender, EventArgs e)
        {
            CargarConfiguraciones();
        }

        private void buttonPers11_Click(object sender, EventArgs e)
        {
            MessageBox.Show("check esta:" + swbPasswrds.Checked);
        }
    }
}
