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
using ProripsDataset.DatasetOrigin.TemporalDatasetTableAdapters;

namespace Prorips
{
    public partial class frmPrincipal : Form
    {
        
        public frmPrincipal()
        {
           
            InitializeComponent();
            
            //picLogo.Image = Image.FromFile(Properties.Settings.Default.RutaLogo);
        }
        
        //private void validarArchivosToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    String ruta ="";
        //    CargarArchivos cargarArchivos = new CargarArchivos();
        //    if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
        //    {
        //        ruta = folderBrowserDialog1.SelectedPath;
        //        cargarArchivos.cargarArchivosPlanos(ruta);

            //        frmResultadoValidacion frmResultadoValidacion = new frmResultadoValidacion { TopLevel = false };
            //        pnlPaginas.Controls.Add(frmResultadoValidacion);
            //        frmResultadoValidacion.Show();
            //        picLogo.Visible = false;
            //    }

            //    else
            //    {
            //        MessageBox.Show("debe elegir una ruta para continuar");
            //    }
            //    btnCorregir.Visible = true;

            //}
        private void button1_Click(object sender, EventArgs e)
        {
            
            frmInterfaceValidarArchivos frmInterfaceValidarArchivos = new frmInterfaceValidarArchivos { TopLevel = false };
            pnlPaginas.Controls.Clear();
            pnlPaginas.Controls.Add(frmInterfaceValidarArchivos);
            frmInterfaceValidarArchivos.Show();
            
        }

        private void btnCargarArchivo_Click(object sender, EventArgs e)
        {
            String ruta = "";
            CargarArchivos cargarArchivos = new CargarArchivos();
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                ruta = folderBrowserDialog1.SelectedPath;
                cargarArchivos.cargarArchivosPlanos(ruta);

                frmResultadoValidacion frmResultadoValidacion = new frmResultadoValidacion { TopLevel = false };
                pnlPaginas.Controls.Add(frmResultadoValidacion);
                frmResultadoValidacion.Show();
                btnCorregir.Enabled = true;
            }

            else
            {
                MessageBox.Show("debe elegir una ruta para continuar");
            }
            btnCorregir.Visible = true;
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            frmInicio frminicio = new frmInicio { TopLevel = false };
            pnlPaginas.Controls.Add(frminicio);
            frminicio.Show();
        }

        private void informeErroresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExportarArchivos exportar = new ExportarArchivos();
            exportar.ExportarExcel("");
        }
    }
}
