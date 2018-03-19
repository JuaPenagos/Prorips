using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProripsDataset;
using System.IO;
using System.Data;

namespace ProripsClass
{
    public class CargarArchivos
    {
        public void cargarArchivosPlanos(String ruta)
        {
            ProripsDataset.DatasetOrigin.TemporalDataset.archivosCargarDataTable archivosCargarDataTable = new ProripsDataset.DatasetOrigin.TemporalDataset.archivosCargarDataTable();
            ProripsDataset.DatasetOrigin.TemporalDatasetTableAdapters.archivosCargarTableAdapter archivosCargarTableAdapter = new ProripsDataset.DatasetOrigin.TemporalDatasetTableAdapters.archivosCargarTableAdapter();
            DirectoryInfo documentos = new DirectoryInfo(ruta);
            Console.WriteLine("No search pattern returns:");
            archivosCargarTableAdapter.DeleteQuery();
            archivosCargarTableAdapter.EliminarTablasArchivos();
            foreach (var documento in documentos.GetFiles("*.txt"))
            {
                String rutaArchivo;
                String nombreArchivo;
                String abreviatura;
                String tabla;
                rutaArchivo = documento.FullName;
                nombreArchivo = documento.Name.Substring(0, documento.Name.Length - 4);
                abreviatura = documento.Name.Substring(0, 2);
                tabla = "varchivo" + abreviatura;

                archivosCargarTableAdapter.insertarRegistros(rutaArchivo, nombreArchivo, abreviatura, tabla, false);

            }
            archivosCargarDataTable = archivosCargarTableAdapter.GetData();
            
            foreach (DataRow row in archivosCargarDataTable.Rows)
            {
                archivosCargarTableAdapter.CargarArchivos(row[3].ToString(), row[0].ToString(), row[1].ToString());
                archivosCargarTableAdapter.ActualizarCampoNombreArchivos("temporal.archivo" + row[2].ToString(), row[1].ToString());
            }
            ProripsDataset.DatasetOrigin.TemporalDatasetTableAdapters.QueriesTableAdapter queries = new ProripsDataset.DatasetOrigin.TemporalDatasetTableAdapters.QueriesTableAdapter();
            queries.spGenerarListaErrores();
                int numeroArchivos;
            numeroArchivos = archivosCargarDataTable.Count();
        }
        

    }
}