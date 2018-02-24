using ProripsDataset.DatasetOrigin.TemporalDatasetTableAdapters;
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
    public partial class frmInterfaceValidarArchivos : Form
    {

        public frmInterfaceValidarArchivos()
        {
            InitializeComponent();
            

        }
        public void RowsColor()
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {

                //dataGridView1.DefaultCellStyle.BackColor = Color.Red;
                dataGridView1[1, 1].Style.BackColor = Color.Red;
            }
        }

        private void frmInterfaceValidarArchivos_Load(object sender, EventArgs e)
        {
            spValidararchivoAFTableAdapter archivoAFTableAdapter = new spValidararchivoAFTableAdapter();
            spValidararchivoACTableAdapter archivoACTableAdapter = new spValidararchivoACTableAdapter();
            spValidararchivoADTableAdapter archivoADTableAdapter = new spValidararchivoADTableAdapter();
            spValidararchivoAHTableAdapter archivoAHTableAdapter = new spValidararchivoAHTableAdapter();
            spValidararchivoAMTableAdapter archivoAMTableAdapter = new spValidararchivoAMTableAdapter();
            spValidararchivoUSTableAdapter archivoUSTableAdapter = new spValidararchivoUSTableAdapter();
            spValidararchivoANTableAdapter archivoANTableAdapter = new spValidararchivoANTableAdapter();
            spValidararchivoAPTableAdapter archivoAPTableAdapter = new spValidararchivoAPTableAdapter();
            spValidararchivoATTableAdapter archivoATTableAdapter = new spValidararchivoATTableAdapter();
            spValidararchivoAUTableAdapter archivoAUTableAdapter = new spValidararchivoAUTableAdapter();
            archivoCTTableAdapter archivoCTTableAdapter = new archivoCTTableAdapter();

            


            archivoACTableAdapter.Fill(temporalDataset.spValidararchivoAC);
            archivoAFTableAdapter.Fill(temporalDataset.spValidararchivoAF);
            archivoADTableAdapter.Fill(temporalDataset.spValidararchivoAD);
            archivoAHTableAdapter.Fill(temporalDataset.spValidararchivoAH);
            archivoAMTableAdapter.Fill(temporalDataset.spValidararchivoAM);
            archivoUSTableAdapter.Fill(temporalDataset.spValidararchivoUS);
            archivoANTableAdapter.Fill(temporalDataset.spValidararchivoAN);
            archivoAPTableAdapter.Fill(temporalDataset.spValidararchivoAP);
            archivoATTableAdapter.Fill(temporalDataset.spValidararchivoAT);
            archivoAUTableAdapter.Fill(temporalDataset.spValidararchivoAU);
            archivoCTTableAdapter.Fill(temporalDataset.archivoCT);
            dataGridView1.DataSource = temporalDataset;

            if (temporalDataset.spValidararchivoAN.Rows.Count == 0)
            {
                tabArchivos.Controls.Remove(tabPageArchivoAN);
                
            }

            lblError.Text = "Los campos marcados con (*) tienen errores";
            lblError.ForeColor = Color.Red;

        }
    }

}

