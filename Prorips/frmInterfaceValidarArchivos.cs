using ProripsClass;
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
            for (int i = 0; i < dgvArchivoAC.Rows.Count; i++)
            {

                //dataGridView1.DefaultCellStyle.BackColor = Color.Red;
                dgvArchivoAC[1, 1].Style.BackColor = Color.Red;
            }
        }
        #region"Load"

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
            spValidararchivoCTTableAdapter archivoCTTableAdapter = new spValidararchivoCTTableAdapter();
            spSeleccionarErroresTableAdapter ErroresTableAdapter = new spSeleccionarErroresTableAdapter();




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
            archivoCTTableAdapter.Fill(temporalDataset.spValidararchivoCT);
            ErroresTableAdapter.Fill(temporalDataset.spSeleccionarErrores);
            dgvArchivoAC.DataSource = temporalDataset;

            if (temporalDataset.spValidararchivoAC.Rows.Count == 0)
            {
                tabArchivos.Controls.Remove(tabPageArchivoAC);
            }

            if (temporalDataset.spValidararchivoAD.Rows.Count == 0)
            {
                tabArchivos.Controls.Remove(tabPageArchivoAD);
            }
            if (temporalDataset.spValidararchivoAF.Rows.Count == 0)
            {
                tabArchivos.Controls.Remove(tabPageArchivoAF);
            }
            if (temporalDataset.spValidararchivoAH.Rows.Count == 0)
            {
                tabArchivos.Controls.Remove(tabPageArchivoAH);
            }
            if (temporalDataset.spValidararchivoAM.Rows.Count == 0)
            {
                tabArchivos.Controls.Remove(tabPageArchivoAM);
            }
            if (temporalDataset.spValidararchivoAN.Rows.Count == 0)
            {
                tabArchivos.Controls.Remove(tabPageArchivoAN);
            }
            if (temporalDataset.spValidararchivoAP.Rows.Count == 0)
            {
                tabArchivos.Controls.Remove(tabPageArchivoAP);
            }
            if (temporalDataset.spValidararchivoAT.Rows.Count == 0)
            {
                tabArchivos.Controls.Remove(tabPageArchivoAT);
            }
            if (temporalDataset.spValidararchivoAU.Rows.Count == 0)
            {
                tabArchivos.Controls.Remove(tabPageArchivoAU);
            }
            if (temporalDataset.spValidararchivoUS.Rows.Count == 0)
            {
                tabArchivos.Controls.Remove(tabPageArchivoUS);
            }
            if (temporalDataset.spValidararchivoCT.Rows.Count == 0)
            {
                tabArchivos.Controls.Remove(tabPageArchivoCT);
            }

            lblError.Text = "Los campos marcados con (*) tienen errores";
            lblError.ForeColor = Color.Red;

        }
    
        #endregion
        #region"Guardar"

        private void btnGuardarCorreciones_Click(object sender, EventArgs e)
        {
            eliminar();
            ProripsClass.GuardarCorrecciones guardarCorrecciones = new ProripsClass.GuardarCorrecciones();
            foreach (DataGridViewRow row in dgvArchivoAC.Rows)
            {
                guardarCorrecciones.guardarArchivoAC(row.Cells[0].Value.ToString(), row.Cells[1].Value.ToString(), row.Cells[2].Value.ToString(), row.Cells[3].Value.ToString(),
                    row.Cells[4].Value.ToString(), row.Cells[5].Value.ToString(), row.Cells[6].Value.ToString(), row.Cells[7].Value.ToString(), row.Cells[8].Value.ToString(), row.Cells[9].Value.ToString(), row.Cells[10].Value.ToString(),
                    row.Cells[11].Value.ToString(), row.Cells[12].Value.ToString(), row.Cells[13].Value.ToString(), row.Cells[14].Value.ToString(), row.Cells[15].Value.ToString(), row.Cells[16].Value.ToString(), row.Cells[17].Value.ToString());

            }
            foreach (DataGridViewRow row in dgvArchivoAD.Rows)
            {
                guardarCorrecciones.guardarArchivoAD(row.Cells[0].Value.ToString(), row.Cells[1].Value.ToString(), row.Cells[2].Value.ToString(), row.Cells[3].Value.ToString(), row.Cells[4].Value.ToString(),
                    row.Cells[5].Value.ToString(), row.Cells[6].Value.ToString());
            }
            foreach (DataGridViewRow row in dgvArchivoAF.Rows)
            {
                guardarCorrecciones.guardarArchivoAF(row.Cells[0].Value.ToString(), row.Cells[1].Value.ToString(), row.Cells[2].Value.ToString(), row.Cells[3].Value.ToString(),
                    row.Cells[4].Value.ToString(), row.Cells[5].Value.ToString(), row.Cells[6].Value.ToString(), row.Cells[7].Value.ToString(), row.Cells[8].Value.ToString(), row.Cells[9].Value.ToString(), row.Cells[10].Value.ToString(),
                    row.Cells[11].Value.ToString(), row.Cells[12].Value.ToString(), row.Cells[13].Value.ToString(), row.Cells[14].Value.ToString(), row.Cells[15].Value.ToString(), row.Cells[16].Value.ToString(), row.Cells[17].Value.ToString());
            }
            foreach (DataGridViewRow row in dgvArchivoAH.Rows)
            {
                guardarCorrecciones.guardarArchivoAH(row.Cells[0].Value.ToString(), row.Cells[1].Value.ToString(), row.Cells[2].Value.ToString(), row.Cells[3].Value.ToString(),
                    row.Cells[4].Value.ToString(), row.Cells[5].Value.ToString(), row.Cells[6].Value.ToString(), row.Cells[7].Value.ToString(), row.Cells[8].Value.ToString(), row.Cells[9].Value.ToString(), row.Cells[10].Value.ToString(),
                    row.Cells[11].Value.ToString(), row.Cells[12].Value.ToString(), row.Cells[13].Value.ToString(), row.Cells[14].Value.ToString(), row.Cells[15].Value.ToString(), row.Cells[16].Value.ToString(), row.Cells[17].Value.ToString(), row.Cells[18].Value.ToString(), row.Cells[19].Value.ToString());
            }
            foreach (DataGridViewRow row in dgvArchivoAM.Rows)
            {
                guardarCorrecciones.guardarArchivoAM(row.Cells[0].Value.ToString(), row.Cells[1].Value.ToString(), row.Cells[2].Value.ToString(), row.Cells[3].Value.ToString(),
                    row.Cells[4].Value.ToString(), row.Cells[5].Value.ToString(), row.Cells[6].Value.ToString(), row.Cells[7].Value.ToString(), row.Cells[8].Value.ToString(), row.Cells[9].Value.ToString(), row.Cells[10].Value.ToString(),
                    row.Cells[11].Value.ToString(), row.Cells[12].Value.ToString(), row.Cells[13].Value.ToString(), row.Cells[14].Value.ToString());
            }
            foreach (DataGridViewRow row in dgvArchivoAN.Rows)
            {
                guardarCorrecciones.guardarArchivoAN(row.Cells[0].Value.ToString(), row.Cells[1].Value.ToString(), row.Cells[2].Value.ToString(), row.Cells[3].Value.ToString(),
                    row.Cells[4].Value.ToString(), row.Cells[5].Value.ToString(), row.Cells[6].Value.ToString(), row.Cells[7].Value.ToString(), row.Cells[8].Value.ToString(), row.Cells[9].Value.ToString(), row.Cells[10].Value.ToString(),
                    row.Cells[11].Value.ToString(), row.Cells[12].Value.ToString(), row.Cells[13].Value.ToString(), row.Cells[14].Value.ToString());
            }
            foreach (DataGridViewRow row in dgvArchivoAP.Rows)
            {
                guardarCorrecciones.guardarArchivoAP(row.Cells[0].Value.ToString(), row.Cells[1].Value.ToString(), row.Cells[2].Value.ToString(), row.Cells[3].Value.ToString(),
                    row.Cells[4].Value.ToString(), row.Cells[5].Value.ToString(), row.Cells[6].Value.ToString(), row.Cells[7].Value.ToString(), row.Cells[8].Value.ToString(), row.Cells[9].Value.ToString(), row.Cells[10].Value.ToString(),
                    row.Cells[11].Value.ToString(), row.Cells[12].Value.ToString(), row.Cells[13].Value.ToString(), row.Cells[14].Value.ToString(), row.Cells[15].Value.ToString());
            }
            foreach (DataGridViewRow row in dgvArchivoAT.Rows)
            {
                guardarCorrecciones.guardarArchivoAT(row.Cells[0].Value.ToString(), row.Cells[1].Value.ToString(), row.Cells[2].Value.ToString(), row.Cells[3].Value.ToString(),
                    row.Cells[4].Value.ToString(), row.Cells[5].Value.ToString(), row.Cells[6].Value.ToString(), row.Cells[7].Value.ToString(), row.Cells[8].Value.ToString(), row.Cells[9].Value.ToString(), row.Cells[10].Value.ToString(),
                    row.Cells[11].Value.ToString());
            }
            foreach (DataGridViewRow row in dgvArchivoAU.Rows)
            {
                guardarCorrecciones.guardarArchivoAU(row.Cells[0].Value.ToString(), row.Cells[1].Value.ToString(), row.Cells[2].Value.ToString(), row.Cells[3].Value.ToString(),
                    row.Cells[4].Value.ToString(), row.Cells[5].Value.ToString(), row.Cells[6].Value.ToString(), row.Cells[7].Value.ToString(), row.Cells[8].Value.ToString(), row.Cells[9].Value.ToString(), row.Cells[10].Value.ToString(),
                    row.Cells[11].Value.ToString(), row.Cells[12].Value.ToString(), row.Cells[13].Value.ToString(), row.Cells[14].Value.ToString(), row.Cells[15].Value.ToString(), row.Cells[16].Value.ToString(), row.Cells[17].Value.ToString());
            }
            foreach (DataGridViewRow row in dgvArchivoUS.Rows)
            {
                guardarCorrecciones.guardarArchivoUS(row.Cells[0].Value.ToString(), row.Cells[1].Value.ToString(), row.Cells[2].Value.ToString(), row.Cells[3].Value.ToString(),
                    row.Cells[4].Value.ToString(), row.Cells[5].Value.ToString(), row.Cells[6].Value.ToString(), row.Cells[7].Value.ToString(), row.Cells[8].Value.ToString(), row.Cells[9].Value.ToString(), row.Cells[10].Value.ToString(),
                    row.Cells[11].Value.ToString(), row.Cells[12].Value.ToString(), row.Cells[13].Value.ToString(), row.Cells[14].Value.ToString());
            }
            foreach (DataGridViewRow row in dgvArchivoCT.Rows)
            {
                guardarCorrecciones.guardarArchivoCT(row.Cells[0].Value.ToString(), row.Cells[1].Value.ToString(), row.Cells[2].Value.ToString(), row.Cells[3].Value.ToString(), dgvArchivoCT.Rows[0].Cells[4].Value.ToString());
            }
            refrecar();
            btnExportar.Enabled = true;
        }
        #endregion
        #region"Exportar"
        
        private void btnExportar_Click(object sender, EventArgs e)
        {
            
            ExportarArchivos exportar = new ExportarArchivos();
            int columncount = 0;
            StringBuilder ArchivoAC = new StringBuilder();
            StringBuilder ArchivoAD = new StringBuilder();
            StringBuilder ArchivoAF = new StringBuilder();
            StringBuilder ArchivoAH = new StringBuilder();
            StringBuilder ArchivoAM = new StringBuilder();
            StringBuilder ArchivoAN = new StringBuilder();
            StringBuilder ArchivoAP = new StringBuilder();
            StringBuilder ArchivoAT = new StringBuilder();
            StringBuilder ArchivoAU = new StringBuilder();
            StringBuilder ArchivoUS = new StringBuilder();
            StringBuilder ArchivoCT = new StringBuilder();
            if (temporalDataset.spValidararchivoAC.Rows.Count != 0)
            {

                foreach (DataGridViewRow row in dgvArchivoAC.Rows)
                {
                    columncount = dgvArchivoAC.Columns.Count - 1;
                    List<string> cols = new List<string>();
                    for (int j = 0; j < columncount; j++)
                    {
                        cols.Add(row.Cells[j].Value.ToString());
                    }

                    ArchivoAC.AppendLine(string.Join(",", cols.ToArray()));
                }
                exportar.exportarArchivoTxt(dgvArchivoAC.Rows[0].Cells[dgvArchivoAC.Columns.Count - 1].Value.ToString(), ArchivoAC);

            }
            if (temporalDataset.spValidararchivoAD.Rows.Count != 0)
            {
                foreach (DataGridViewRow row in dgvArchivoAD.Rows)
                {
                    columncount = dgvArchivoAD.Columns.Count - 1;
                    List<string> cols = new List<string>();
                    for (int j = 0; j < columncount; j++)
                    {
                        cols.Add(row.Cells[j].Value.ToString());
                    }

                    ArchivoAD.AppendLine(string.Join(",", cols.ToArray()));
                }
                exportar.exportarArchivoTxt(dgvArchivoAD.Rows[0].Cells[dgvArchivoAD.Columns.Count - 1].Value.ToString(), ArchivoAD);
            }
            if (temporalDataset.spValidararchivoAF.Rows.Count != 0)
            {
                foreach (DataGridViewRow row in dgvArchivoAF.Rows)
                {
                    columncount = dgvArchivoAF.Columns.Count - 1;
                    List<string> cols = new List<string>();
                    for (int j = 0; j < columncount; j++)
                    {
                        cols.Add(row.Cells[j].Value.ToString());
                    }

                    ArchivoAF.AppendLine(string.Join(",", cols.ToArray()));
                }
                exportar.exportarArchivoTxt(dgvArchivoAD.Rows[0].Cells[dgvArchivoAD.Columns.Count - 1].Value.ToString(), ArchivoAF);
            }
            if (temporalDataset.spValidararchivoAH.Rows.Count != 0)
            {
                foreach (DataGridViewRow row in dgvArchivoAH.Rows)
                {
                    columncount = dgvArchivoAH.Columns.Count - 1;
                    List<string> cols = new List<string>();
                    for (int j = 0; j < columncount; j++)
                    {
                        cols.Add(row.Cells[j].Value.ToString());
                    }

                    ArchivoAH.AppendLine(string.Join(",", cols.ToArray()));
                }
                exportar.exportarArchivoTxt(dgvArchivoAH.Rows[0].Cells[dgvArchivoAH.Columns.Count - 1].Value.ToString(), ArchivoAH);


            }
            if (temporalDataset.spValidararchivoAM.Rows.Count != 0)
            {
                foreach (DataGridViewRow row in dgvArchivoAM.Rows)
                {
                    columncount = dgvArchivoAM.Columns.Count - 1;
                    List<string> cols = new List<string>();
                    for (int j = 0; j < columncount; j++)
                    {
                        cols.Add(row.Cells[j].Value.ToString());
                    }

                    ArchivoAM.AppendLine(string.Join(",", cols.ToArray()));
                }
                exportar.exportarArchivoTxt(dgvArchivoAM.Rows[0].Cells[dgvArchivoAM.Columns.Count - 1].Value.ToString(), ArchivoAM);

            }
            if (temporalDataset.spValidararchivoAN.Rows.Count != 0)
            {
                foreach (DataGridViewRow row in dgvArchivoAN.Rows)
                {
                    columncount = dgvArchivoAN.Columns.Count - 1;
                    List<string> cols = new List<string>();
                    for (int j = 0; j < columncount; j++)
                    {
                        cols.Add(row.Cells[j].Value.ToString());
                    }

                    ArchivoAN.AppendLine(string.Join(",", cols.ToArray()));
                }
                exportar.exportarArchivoTxt(dgvArchivoAN.Rows[0].Cells[dgvArchivoAN.Columns.Count - 1].Value.ToString(), ArchivoAN);

            }
            if (temporalDataset.spValidararchivoAP.Rows.Count != 0)
            {
                foreach (DataGridViewRow row in dgvArchivoAP.Rows)
                {
                    columncount = dgvArchivoAP.Columns.Count - 1;
                    List<string> cols = new List<string>();
                    for (int j = 0; j < columncount; j++)
                    {
                        cols.Add(row.Cells[j].Value.ToString());
                    }

                    ArchivoAP.AppendLine(string.Join(",", cols.ToArray()));
                }
                exportar.exportarArchivoTxt(dgvArchivoAP.Rows[0].Cells[dgvArchivoAP.Columns.Count - 1].Value.ToString(), ArchivoAP);

            }
            if (temporalDataset.spValidararchivoAT.Rows.Count != 0)
            {
                foreach (DataGridViewRow row in dgvArchivoAT.Rows)
                {
                    columncount = dgvArchivoAT.Columns.Count - 1;
                    List<string> cols = new List<string>();
                    for (int j = 0; j < columncount; j++)
                    {
                        cols.Add(row.Cells[j].Value.ToString());
                    }

                    ArchivoAT.AppendLine(string.Join(",", cols.ToArray()));
                }
                exportar.exportarArchivoTxt(dgvArchivoAT.Rows[0].Cells[dgvArchivoAT.Columns.Count - 1].Value.ToString(), ArchivoAT);

            }
            if (temporalDataset.spValidararchivoAU.Rows.Count != 0)
            {
                foreach (DataGridViewRow row in dgvArchivoAU.Rows)
                {
                    columncount = dgvArchivoAU.Columns.Count - 1;
                    List<string> cols = new List<string>();
                    for (int j = 0; j < columncount; j++)
                    {
                        cols.Add(row.Cells[j].Value.ToString());
                    }

                    ArchivoAU.AppendLine(string.Join(",", cols.ToArray()));
                }
                exportar.exportarArchivoTxt(dgvArchivoAU.Rows[0].Cells[dgvArchivoAU.Columns.Count - 1].Value.ToString(), ArchivoAU);

            }
            if (temporalDataset.spValidararchivoUS.Rows.Count != 0)
            {
                foreach (DataGridViewRow row in dgvArchivoUS.Rows)
                {
                    columncount = dgvArchivoUS.Columns.Count - 1;
                    List<string> cols = new List<string>();
                    for (int j = 0; j < columncount; j++)
                    {
                        cols.Add(row.Cells[j].Value.ToString());
                    }

                    ArchivoUS.AppendLine(string.Join(",", cols.ToArray()));
                }
                exportar.exportarArchivoTxt(dgvArchivoUS.Rows[0].Cells[dgvArchivoUS.Columns.Count - 1].Value.ToString(), ArchivoUS);

            }
            if (temporalDataset.spValidararchivoCT.Rows.Count != 0)
            {

                foreach (DataGridViewRow row in dgvArchivoCT.Rows)
                {

                    columncount = dgvArchivoCT.Columns.Count - 1;
                    List<string> cols = new List<string>();
                    for (int j = 0; j < columncount; j++)
                    {
                        cols.Add(row.Cells[j].Value.ToString());
                    }

                    ArchivoCT.AppendLine(string.Join(",", cols.ToArray()));
                }
                exportar.exportarArchivoTxt(dgvArchivoCT.Rows[0].Cells[dgvArchivoCT.Columns.Count - 1].Value.ToString(), ArchivoCT);

            }

            
        }
        #endregion

        public void eliminar()
        {

            string rutaAC = "";
            string rutaAD = "";
            string rutaAF = "";
            string rutaAH = "";
            string rutaAM = "";
            string rutaAN = "";
            string rutaAP = "";
            string rutaAT = "";
            string rutaAU = "";
            string rutaCT = "";
            string rutaUS = "";


            if (dgvArchivoAC.Rows.Count != 0)
            {
                
                rutaAC = dgvArchivoAC.Rows[0].Cells[dgvArchivoAC.Columns.Count - 1].Value.ToString();
            }
            if (dgvArchivoAF.Rows.Count != 0)
            {
                rutaAF = dgvArchivoAF.Rows[0].Cells[dgvArchivoAF.Columns.Count - 1].Value.ToString();
            }
            if (dgvArchivoAD.Rows.Count != 0)
            {
                
                rutaAD = dgvArchivoAD.Rows[0].Cells[dgvArchivoAD.Columns.Count - 1].Value.ToString();
            }
            if (dgvArchivoAH.Rows.Count != 0)
            {
                rutaAH = dgvArchivoAH.Rows[0].Cells[dgvArchivoAH.Columns.Count - 1].Value.ToString();
            }
            if (dgvArchivoAM.Rows.Count != 0)
            {
                rutaAM = dgvArchivoAM.Rows[0].Cells[dgvArchivoAM.Columns.Count - 1].Value.ToString();
               
            }
            if (dgvArchivoUS.Rows.Count != 0)
            {
                rutaUS = dgvArchivoUS.Rows[0].Cells[dgvArchivoUS.Columns.Count - 1].Value.ToString();
             
            }
            if (dgvArchivoAN.Rows.Count != 0)
            {
                rutaAN = dgvArchivoAN.Rows[0].Cells[dgvArchivoAN.Columns.Count - 1].Value.ToString();
               
            }
            if (dgvArchivoAP.Rows.Count != 0)
            {
                rutaAP = dgvArchivoAP.Rows[0].Cells[dgvArchivoAP.Columns.Count - 1].Value.ToString();
                
            }
            if (dgvArchivoAT.Rows.Count != 0)
            {
                rutaAT = dgvArchivoAT.Rows[0].Cells[dgvArchivoAT.Columns.Count - 1].Value.ToString();
               
            }
            if (dgvArchivoAU.Rows.Count != 0)
            {
                rutaAU = dgvArchivoAU.Rows[0].Cells[dgvArchivoAU.Columns.Count - 1].Value.ToString();
            }            
            if (dgvArchivoCT.Rows.Count != 0)
            {
                rutaCT = dgvArchivoCT.Rows[0].Cells[dgvArchivoCT.Columns.Count - 1].Value.ToString();
            }
            archivosCargarTableAdapter archivos = new archivosCargarTableAdapter();
            archivos.EliminarArchivosRepetidos(rutaAC, rutaAD, rutaAF, rutaAH, rutaAM, rutaAN, rutaAP, rutaAT, rutaAU, rutaUS, rutaCT);
        }

        public void refrecar()
        {
            //dgvArchivoAC.Refresh();

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
            spValidararchivoCTTableAdapter archivoCTTableAdapter = new spValidararchivoCTTableAdapter();


            if (dgvArchivoAC.Rows.Count != 0)
            {
                archivoACTableAdapter.FillBy(temporalDataset.spValidararchivoAC, dgvArchivoAC.Rows[0].Cells[dgvArchivoAC.Columns.Count - 1].Value.ToString());

            }
            if (dgvArchivoAF.Rows.Count != 0)
            {
                archivoAFTableAdapter.FillBy(temporalDataset.spValidararchivoAF, dgvArchivoAF.Rows[0].Cells[dgvArchivoAF.Columns.Count - 1].Value.ToString());

            }
            if (dgvArchivoAD.Rows.Count != 0)
            {
                archivoADTableAdapter.FillBy(temporalDataset.spValidararchivoAD, dgvArchivoAD.Rows[0].Cells[dgvArchivoAD.Columns.Count - 1].Value.ToString());

            }
            if (dgvArchivoAH.Rows.Count != 0)
            {
                archivoAHTableAdapter.FillBy(temporalDataset.spValidararchivoAH, dgvArchivoAH.Rows[0].Cells[dgvArchivoAH.Columns.Count - 1].Value.ToString());

            }
            if (dgvArchivoAM.Rows.Count != 0)
            {
                archivoAMTableAdapter.FillBy(temporalDataset.spValidararchivoAM, dgvArchivoAM.Rows[0].Cells[dgvArchivoAM.Columns.Count - 1].Value.ToString());

            }
            if (dgvArchivoUS.Rows.Count != 0)
            {
                archivoUSTableAdapter.FillBy(temporalDataset.spValidararchivoUS, dgvArchivoUS.Rows[0].Cells[dgvArchivoUS.Columns.Count - 1].Value.ToString());

            }
            if (dgvArchivoAN.Rows.Count != 0)
            {
                archivoANTableAdapter.FillBy(temporalDataset.spValidararchivoAN, dgvArchivoAN.Rows[0].Cells[dgvArchivoAN.Columns.Count - 1].Value.ToString());

            }
            if (dgvArchivoAP.Rows.Count != 0)
            {
                archivoAPTableAdapter.FillBy(temporalDataset.spValidararchivoAP, dgvArchivoAP.Rows[0].Cells[dgvArchivoAP.Columns.Count - 1].Value.ToString());

            }
            if (dgvArchivoAT.Rows.Count != 0)
            {
                archivoATTableAdapter.FillBy(temporalDataset.spValidararchivoAT, dgvArchivoAT.Rows[0].Cells[dgvArchivoAT.Columns.Count - 1].Value.ToString());

            }
            if (dgvArchivoAU.Rows.Count != 0)
            {
                archivoAUTableAdapter.FillBy(temporalDataset.spValidararchivoAU, dgvArchivoAU.Rows[0].Cells[dgvArchivoAU.Columns.Count - 1].Value.ToString());

            }
            if (dgvArchivoCT.Rows.Count != 0)
            {
                archivoCTTableAdapter.FillBy(temporalDataset.spValidararchivoCT, dgvArchivoCT.Rows[0].Cells[dgvArchivoCT.Columns.Count - 1].Value.ToString());

            }
            dgvArchivoAC.DataSource = temporalDataset;

            if (temporalDataset.spValidararchivoAC.Rows.Count == 0)
            {
                tabArchivos.Controls.Remove(tabPageArchivoAC);
            }

            if (temporalDataset.spValidararchivoAD.Rows.Count == 0)
            {
                tabArchivos.Controls.Remove(tabPageArchivoAD);
            }
            if (temporalDataset.spValidararchivoAF.Rows.Count == 0)
            {
                tabArchivos.Controls.Remove(tabPageArchivoAF);
            }
            if (temporalDataset.spValidararchivoAH.Rows.Count == 0)
            {
                tabArchivos.Controls.Remove(tabPageArchivoAH);
            }
            if (temporalDataset.spValidararchivoAM.Rows.Count == 0)
            {
                tabArchivos.Controls.Remove(tabPageArchivoAM);
            }
            if (temporalDataset.spValidararchivoAN.Rows.Count == 0)
            {
                tabArchivos.Controls.Remove(tabPageArchivoAN);
            }
            if (temporalDataset.spValidararchivoAP.Rows.Count == 0)
            {
                tabArchivos.Controls.Remove(tabPageArchivoAP);
            }
            if (temporalDataset.spValidararchivoAT.Rows.Count == 0)
            {
                tabArchivos.Controls.Remove(tabPageArchivoAT);
            }
            if (temporalDataset.spValidararchivoAU.Rows.Count == 0)
            {
                tabArchivos.Controls.Remove(tabPageArchivoAU);
            }
            if (temporalDataset.spValidararchivoUS.Rows.Count == 0)
            {
                tabArchivos.Controls.Remove(tabPageArchivoUS);
            }
            if (temporalDataset.spValidararchivoCT.Rows.Count == 0)
            {
                tabArchivos.Controls.Remove(tabPageArchivoCT);
            }
            lblError.Text = "Los campos marcados con (*) tienen errores";
            lblError.ForeColor = Color.Red;

        }
    }
}

