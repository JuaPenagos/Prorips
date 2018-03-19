using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Excel;
namespace ProripsClass
{
    public class ExportarArchivos
    {
        public void exportarArchivoTxt(string archiveName , StringBuilder builder)
        {
            String ruta;
            ruta = @"C:\Users\Penagoss\Downloads\";
            ruta = ruta + archiveName + ".txt";
            System.IO.File.WriteAllText(ruta, builder.ToString());


        }
        public void ExportarExcel(string ruta)
        {
            ruta = @"C:\Users\Penagoss\Downloads\pruebaExcel.xlsx";
            ProripsDataset.DatasetOrigin.TemporalDataset.archivosCargarDataTable archivosCargarDataTable = new ProripsDataset.DatasetOrigin.TemporalDataset.archivosCargarDataTable();
            ProripsDataset.DatasetOrigin.TemporalDatasetTableAdapters.archivosCargarTableAdapter archivosCargarTableAdapter = new ProripsDataset.DatasetOrigin.TemporalDatasetTableAdapters.archivosCargarTableAdapter();
            archivosCargarDataTable = archivosCargarTableAdapter.GetData();

            Microsoft.Office.Interop.Excel.Application excel = null;
            Microsoft.Office.Interop.Excel.Workbook book = null;

            try
            {

                excel = new Microsoft.Office.Interop.Excel.Application();

                if (!File.Exists(ruta))
                {
                    //Aqui se debe crear el archivo excel segun la ruta que se envia si no existe
                    //ExcelLibrary.DataSetHelper.CreateWorkbook(ruta);
                    excel.Workbooks.Add(ruta);
                }

                // Abrimos el libro de trabajo.
                book = excel.Workbooks.Open(ruta);

                int indiceColumna = 0;

                foreach (DataColumn col in archivosCargarDataTable.Columns)  //Columnas
                {
                    indiceColumna++;
                    excel.Cells[1, indiceColumna] = col.ColumnName;
                }

                int indiceFila = 0;

                foreach (DataRow row in archivosCargarDataTable.Rows)  //Filas
                {
                    indiceFila++;

                    indiceColumna = 0;

                    foreach (DataColumn col in archivosCargarDataTable.Columns)  //Columnas
                    {
                        indiceColumna++;
                        excel.Cells[indiceFila + 1, indiceColumna] = row[col.ColumnName];
                    }
                    excel.Columns.AutoFit();
                }

                //excel.Visible = true;
            }
            catch (Exception ex)
            {
                if (book != null)
                {
                    book.Saved = true;
                }

                throw new Exception(ex.Message);
            }
            finally
            {
                if (book != null)
                {
                    if (!book.Saved)
                    {
                        book.Save();
                    }
                    book.Close();
                }
                book = null;

                if (excel != null)
                {
                    // Si procede, cerramos Excel y disminuimos el recuento de referencias al objeto Excel.Application.
                    excel.Quit();

                    while (System.Runtime.InteropServices.Marshal.ReleaseComObject(excel) > 0)
                    {

                    }
                }
                excel = null;
            }
        }



        public void crearCarpeta()
        {

        }



    }
}
