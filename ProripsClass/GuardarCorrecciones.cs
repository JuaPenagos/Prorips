using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProripsClass
{
    public class GuardarCorrecciones
    {
        ProripsDataset.DatasetOrigin.TemporalDatasetTableAdapters.QueriesTableAdapter procedimientosGuardado = new ProripsDataset.DatasetOrigin.TemporalDatasetTableAdapters.QueriesTableAdapter();
        public void guardarArchivoAC(string numFactura, string codPrestadorServicios, string varTipoIdentificacion, string numIdentificacion
                                    , string fecConsulta, string numAutorizacion, string codConsulta, string numFinalidadConsulta, string numCausaExterna
                                    , string codDiagnosticoPrincipal, string codDiagnosticoRelacionado1, string codDiagnosticoRelacionado2, string codDiagnosticoRelacionado3
                                    , string numTipoDiagnosticoPrincipal, string numValorConsulta, string numValorCuotaModeradora, string numValorNetoPagar, string varRuta)
        {
            procedimientosGuardado.spIngresarCorreccionArchivoAC(numFactura, codPrestadorServicios, varTipoIdentificacion, numIdentificacion
                                                                , fecConsulta, numAutorizacion, codConsulta, numFinalidadConsulta, numCausaExterna, codDiagnosticoPrincipal
                                                                , codDiagnosticoRelacionado1, codDiagnosticoRelacionado2, codDiagnosticoRelacionado3, numTipoDiagnosticoPrincipal
                                                                , numValorConsulta, numValorCuotaModeradora, numValorNetoPagar, varRuta);
        }
        public void guardarArchivoAD(string numFactura
           , string codPrestadorServicios
           , string codConcepto
           , string numCantidad
           , string numValorUnitario
           , string numValorTotalConcepto
           , string varRuta)
        {
            procedimientosGuardado.spIngresarCorreccionArchivoAD(numFactura
           , codPrestadorServicios
           , codConcepto
           , numCantidad
           , numValorUnitario
           , numValorTotalConcepto
           , varRuta);
        }
        public void guardarArchivoAF(string codPrestador
           , string varRazonSocial
           , string tipoIdentificacion
           , string numIdentificacion
           , string numFactura
           , string fecExpFactura
           , string fecIniFactura
           , string fecFinFacura
           , string codEntidadAdmin
           , string varNomEntidadAdmin
           , string numContrato
           , string varPlanBeneficios
           , string numPoliza
           , string numCopago
           , string numValorComision
           , string numvalorDescuentos
           , string numValorNetoFact
           , string varRuta)
        {
            procedimientosGuardado.spIngresarCorreccionArchivoAF(codPrestador
           , varRazonSocial
           , tipoIdentificacion
           , numIdentificacion
           , numFactura
           , fecExpFactura
           , fecIniFactura
           , fecFinFacura
           , codEntidadAdmin
           , varNomEntidadAdmin
           , numContrato
           , varPlanBeneficios
           , numPoliza
           , numCopago
           , numValorComision
           , numvalorDescuentos
           , numValorNetoFact
           , varRuta);
        }
        public void guardarArchivoAH(string numFactura
           , string codPrestadorServicios
           , string varTipoIdentificacion
           , string numIdentificacion
           , string numViaIngreso
           , string fecIngresoUsuario
           , string horaIngresoUsuario
           , string numAutorizacion
           , string codCausaExterna
           , string codDiagnosticoIngresoUsuario
           , string codDiagnosticoEgreso
           , string codDiagnosticoRelacionado1Egreso
           , string codDiagnosticoRelacionado2Egreso
           , string codDiagnosticoRelacionado3Egreso
           , string codDiagnosticoComplicacion
           , string numEstadoSalida
           , string codDiagnosticoCausaMuerte
           , string fecEgresoUsuario
           , string horaEgresoUsuario
           , string varRuta)
        {
            procedimientosGuardado.spIngresarCorreccionArchivoAH(numFactura
           , codPrestadorServicios
           , varTipoIdentificacion
           , numIdentificacion
           , numViaIngreso
           , fecIngresoUsuario
           , horaIngresoUsuario
           , numAutorizacion
           , codCausaExterna
           , codDiagnosticoIngresoUsuario
           , codDiagnosticoEgreso
           , codDiagnosticoRelacionado1Egreso
           , codDiagnosticoRelacionado2Egreso
           , codDiagnosticoRelacionado3Egreso
           , codDiagnosticoComplicacion
           , numEstadoSalida
           , codDiagnosticoCausaMuerte
           , fecEgresoUsuario
           , horaEgresoUsuario
           , varRuta);
        }
        public void guardarArchivoAM(string numFactura
           , string codPrestadorServicios
           , string varTipoIdentificacion
           , string numIdentificacion
           , string numAutorizacion
           , string codMedicamentos
           , string numTipoMedicamentos
           , string varNombreGenericoMedicamento
           , string varFormaFarmaceutica
           , string varConcentracionMedicamentos
           , string varUnidadMedidaMedicamento
           , string numUnidadMedicamentos
           , string numValorUnitarioMedicamento
           , string numValorTotalMedicamento
           , string varRuta)
        {
            procedimientosGuardado.spIngresarCorreccionArchivoAM(numFactura
           , codPrestadorServicios
           , varTipoIdentificacion
           , numIdentificacion
           , numAutorizacion
           , codMedicamentos
           , numTipoMedicamentos
           , varNombreGenericoMedicamento
           , varFormaFarmaceutica
           , varConcentracionMedicamentos
           , varUnidadMedidaMedicamento
           , numUnidadMedicamentos
           , numValorUnitarioMedicamento
           , numValorTotalMedicamento
           , varRuta);
        }
        public void guardarArchivoAN(string numFactura
           , string codPrestadorServicios
           , string varTipoIdentificacionMadre
           , string numIdentificacionMadre
           , string fecNacimientoRecienNacido
           , string horaNacimiento
           , string numEdadGestacional
           , string numControlPrenatal
           , string varSexo
           , string numPeso
           , string codDiagnosticoRecienNacido
           , string codCausaMuerte
           , string fecMuerteRecienNacido
           , string horaMuerteRecienNacido
           , string varRuta)
        {
            procedimientosGuardado.spIngresarCorreccionArchivoAN(numFactura
           , codPrestadorServicios
           , varTipoIdentificacionMadre
           , numIdentificacionMadre
           , fecNacimientoRecienNacido
           , horaNacimiento
           , numEdadGestacional
           , numControlPrenatal
           , varSexo
           , numPeso
           , codDiagnosticoRecienNacido
           , codCausaMuerte
           , fecMuerteRecienNacido
           , horaMuerteRecienNacido
           , varRuta);
        }
        public void guardarArchivoAP(string numFactura
           , string codPrestadorServicios
           , string varTipoIdentificacion
           , string numIdentificacion
           , string fecProcedimiento
           , string numAutorizacion
           , string codProcedimiento
           , string numAmbitoRealizacionProcedimiento
           , string numFinalProcedimiento
           , string numPersonalAtiende
           , string codDiagnosticoPrincipal
           , string codDiagnosticoRelacionado
           , string codComplicacion
           , string numFormaActoQuirurgico
           , string valorProcedimiento
           , string varRuta)
        {
            procedimientosGuardado.spIngresarCorreccionArchivoAP(numFactura
           , codPrestadorServicios
           , varTipoIdentificacion
           , numIdentificacion
           , fecProcedimiento
           , numAutorizacion
           , codProcedimiento
           , numAmbitoRealizacionProcedimiento
           , numFinalProcedimiento
           , numPersonalAtiende
           , codDiagnosticoPrincipal
           , codDiagnosticoRelacionado
           , codComplicacion
           , numFormaActoQuirurgico
           , valorProcedimiento
           , varRuta);
        }
        public void guardarArchivoAT(string numFactura
           , string codPrestadorServicios
           , string varTipoIdentificacion
           , string numIdentificacion
           , string numAutorizacion
           , string numTipoServicio
           , string codServicio
           , string varNombreServicio
           , string numCantidad
           , string numValorUnitarioMaterialeInsumos
           , string numValorTotalMaterialeseInsumos
           , string varRuta)
        {
            procedimientosGuardado.spIngresarCorreccionArchivoAT(numFactura
           , codPrestadorServicios
           , varTipoIdentificacion
           , numIdentificacion
           , numAutorizacion
           , numTipoServicio
           , codServicio
           , varNombreServicio
           , numCantidad
           , numValorUnitarioMaterialeInsumos
           , numValorTotalMaterialeseInsumos
           , varRuta);
        }
        public void guardarArchivoAU(string numFactura
           , string codPrestadorServicio
           , string varTipoIdentificacion
           , string numIdentificacion
           , string fecIngresoUsuarioObservacion
           , string horaIngresoUsuarioObservacion
           , string numAutorizacion
           , string numCausaExterna
           , string codDiagnosticoSalida
           , string codDiagnosticoRelacionado1Salida
           , string codDiagnosticoRelacionado2Salida
           , string codDiagnosticadoRelacionado3Salida
           , string numDestinoUsuarioSalidaObservacion
           , string numEstadoSalida
           , string codCausaMuerteUrgencias
           , string fecSalidaUsuarioObservacion
           , string horaSalidaUsuarioObservacion
           , string varRuta)
        {
            procedimientosGuardado.spIngresarCorreccionArchivoAU(numFactura
           , codPrestadorServicio
           , varTipoIdentificacion
           , numIdentificacion
           , fecIngresoUsuarioObservacion
           , horaIngresoUsuarioObservacion
           , numAutorizacion
           , numCausaExterna
           , codDiagnosticoSalida
           , codDiagnosticoRelacionado1Salida
           , codDiagnosticoRelacionado2Salida
           , codDiagnosticadoRelacionado3Salida
           , numDestinoUsuarioSalidaObservacion
           , numEstadoSalida
           , codCausaMuerteUrgencias
           , fecSalidaUsuarioObservacion
           , horaSalidaUsuarioObservacion
           , varRuta);
        }
        public void guardarArchivoCT(string codPrestador
           , string fecRemision
           , string codArchivo
           , string numRegistros
           , string varRuta)
        {
            procedimientosGuardado.spIngresarCorreccionArchivoCT(codPrestador
           , fecRemision
           , codArchivo
           , numRegistros
           , varRuta);
        }
        public void guardarArchivoUS(string varTipoIdentificacion
           , string numIdentificacion
           , string codEntidadAdmin
           , string numTipoUsuario
           , string varApellido1
           , string varApellido2
           , string varNombre1
           , string varNombre2
           , string numEdad
           , string numMedidaEdad
           , string varSexo
           , string codDptoResidencia
           , string codMunresidencia
           , string varZonaResidencia
           , string varRuta)
        {
            procedimientosGuardado.spIngresarCorreccionArchivoUS(varTipoIdentificacion
           , numIdentificacion
           , codEntidadAdmin
           , numTipoUsuario
           , varApellido1
           , varApellido2
           , varNombre1
           , varNombre2
           , numEdad
           , numMedidaEdad
           , varSexo
           , codDptoResidencia
           , codMunresidencia
           , varZonaResidencia
           , varRuta);
        }

    }
}
