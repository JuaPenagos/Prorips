using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProripsClass;
using System.IO;


namespace Prorips
{
    public partial class frmInicio : Form
    {
        String tooltipCorregir = "Corregir Documentos";
        public frmInicio()
        {
           
            InitializeComponent();
            new ToolTip().SetToolTip(pictureBox1, tooltipCorregir);
            //picLogo.Image = Image.FromFile(Properties.Settings.Default.RutaLogo);
        }

        private void validarArchivosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String ruta ="";
            CargarArchivos cargarArchivos = new CargarArchivos();
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                ruta = folderBrowserDialog1.SelectedPath;
                cargarArchivos.cargarArchivosPlanos(ruta);
                
                frmResultadoValidacion frmResultadoValidacion = new frmResultadoValidacion { TopLevel = false };
                pnlPaginas.Controls.Add(frmResultadoValidacion);
                frmResultadoValidacion.Show();
                picLogo.Visible = false;
            }

            else
            {
                MessageBox.Show("debe elegir una ruta para continuar");
            }
            button1.Visible = true;

        }
        private void button1_Click(object sender, EventArgs e)
        {
            picLogo.Visible = false;
            frmInterfaceValidarArchivos frmInterfaceValidarArchivos = new frmInterfaceValidarArchivos { TopLevel = false };
            pnlPaginas.Controls.Clear();
            pnlPaginas.Controls.Add(frmInterfaceValidarArchivos);
            frmInterfaceValidarArchivos.Show();
            
        }

        
    }
}
