using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prorips
{
    public partial class frmResultadoValidacion : Form
    {
        String resultadoLectura = "Lista de Archivos:";
        int numeroArchivos;
        String resultadoValidacionInicial;
        public frmResultadoValidacion()
        {
            InitializeComponent();
        }

        private void frmResultadoValidacion_Load(object sender, EventArgs e)
        {
            
            resultadoValidacionCargaArchivos();
            validacionValoresFacturas();
            txtListaErrores.Text = resultadoValidacionInicial;
            txtNumeroLienas.Text = numeroArchivos.ToString();
            txtListaArchivos.Text = resultadoLectura;
           

        }

        public void resultadoValidacionCargaArchivos()
        {
            int errores;
            ProripsDataset.DatasetOrigin.TemporalDataset.archivosCargarDataTable archivosCargarDataTable = new ProripsDataset.DatasetOrigin.TemporalDataset.archivosCargarDataTable();
            ProripsDataset.DatasetOrigin.TemporalDatasetTableAdapters.archivosCargarTableAdapter archivosCargarTableAdapter = new ProripsDataset.DatasetOrigin.TemporalDatasetTableAdapters.archivosCargarTableAdapter();
            archivosCargarDataTable = archivosCargarTableAdapter.GetData();
            numeroArchivos = archivosCargarDataTable.Count();
            ProripsDataset.DatasetOrigin.TemporalDataset.validacionNumeroRegistrosDataTable validacionNumeroRegistrosDataTable = new ProripsDataset.DatasetOrigin.TemporalDataset.validacionNumeroRegistrosDataTable();
            ProripsDataset.DatasetOrigin.TemporalDatasetTableAdapters.validacionNumeroRegistrosTableAdapter validacionNumeroRegistrosTableAdapter = new ProripsDataset.DatasetOrigin.TemporalDatasetTableAdapters.validacionNumeroRegistrosTableAdapter();

            validacionNumeroRegistrosDataTable = validacionNumeroRegistrosTableAdapter.GetData();
            resultadoValidacionInicial = "Validacion de Numero de Lineas";
            foreach (DataRow row in validacionNumeroRegistrosDataTable.Rows)
            {
                resultadoValidacionInicial = resultadoValidacionInicial + Environment.NewLine + "Archivo:  " + row[0].ToString() + "   Resultado:   " + row[2].ToString() + "   Numero de Lineas: " + row[1].ToString();
                
            }

            foreach (DataRow row in archivosCargarDataTable.Rows)
            {

                resultadoLectura = resultadoLectura + Environment.NewLine + row[1].ToString();
            }
            if (resultadoValidacionInicial.Contains("Incorrectas") == true)
            {
                resultadoValidacionInicial = resultadoValidacionInicial + Environment.NewLine +Environment.NewLine + "Los archivos no tiene los mismos numeros de lineas reportados en el archivo CT, antes de poder continuar por favor corrija los documentos  ";
                //button1.Enabled = false;
            }

        }
        public void validacionValoresFacturas()
        {
            
            ProripsDataset.DatasetOrigin.TemporalDataset.validacionValorFacturaDataTable validacionValorFacturaDataTable = new ProripsDataset.DatasetOrigin.TemporalDataset.validacionValorFacturaDataTable();
            ProripsDataset.DatasetOrigin.TemporalDatasetTableAdapters.validacionValorFacturaTableAdapter validacionValorFacturaTableAdapter = new ProripsDataset.DatasetOrigin.TemporalDatasetTableAdapters.validacionValorFacturaTableAdapter();

            validacionValorFacturaDataTable = validacionValorFacturaTableAdapter.GetData();


            resultadoValidacionInicial = resultadoValidacionInicial + "--------------------------------------------------------------------------" + Environment.NewLine;
            resultadoValidacionInicial = resultadoValidacionInicial + " Las Siguientes facturas presentan Errores en sus valores" + Environment.NewLine;
            foreach (DataRow row in validacionValorFacturaDataTable.Rows)
            {
                if (row[3].ToString().Equals("Incorrecto"))
                {
                    resultadoValidacionInicial = resultadoValidacionInicial + "Numero de factura:   " + row[0].ToString() + "   Valor de la factura en el archivo AF:  " + row[1].ToString() + "  Valor de la suma de los otros archivos:  " + row[2].ToString() + Environment.NewLine;
                }
            }
            
        }


    }
}
