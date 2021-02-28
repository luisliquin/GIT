using ServiciosMedicamento.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using ServiciosMedicamento.Models;

namespace ServiciosMedicamento {
    public class Medicamentos : IMedicamentos {
        int IMedicamentos.eliminarMedicamento(int iidMedicamento) {
            int rpta = 0;
            try {
                using (var bd = new MedicoEntities()) {
                    Medicamento oMedicamento = bd.Medicamento.Where(p=>p.IIDMEDICAMENTO==iidMedicamento).First();
                    oMedicamento.BHABILITADO=0;
                    bd.SaveChanges();
                    rpta=1;
                }
            } catch (Exception) {
                rpta=0;
            }
            return rpta;
        }    

        List<FormaFarmaceuticaCLS> IMedicamentos.listarFormaFarmaceutica() {
            List<FormaFarmaceuticaCLS> listaFormaFarmaceutica =
                new List<FormaFarmaceuticaCLS>();
            try {
                using (var bd = new MedicoEntities()) {
                    listaFormaFarmaceutica = bd.FormaFarmaceutica.Where(p => p.BHABILITADO == 1)
                        .Select(p=>new FormaFarmaceuticaCLS{
                        iidformafarmaceutica = p.IIDFORMAFARMACEUTICA,
                        nombreFormaFarmaceutica = p.NOMBRE
                    }).ToList();
                }
            } catch (Exception) {
                listaFormaFarmaceutica=null;
            }
            return listaFormaFarmaceutica;
        }

        List<MedicamentoCLS> IMedicamentos.listarMedicamentos() {
            List<MedicamentoCLS> listaMedicamento = new List<MedicamentoCLS>();
            try {
                using (var bd = new MedicoEntities()) {
                    listaMedicamento=(from medicamento in bd.Medicamento
                                      join FormaFarmaceutica in bd.FormaFarmaceutica
                                      on medicamento.IIDFORMAFARMACEUTICA equals
                                      FormaFarmaceutica.IIDFORMAFARMACEUTICA
                                      select new MedicamentoCLS {
                                          iidmedicamento=medicamento.IIDMEDICAMENTO,
                                          nombre=medicamento.NOMBRE,
                                          precio=(decimal)medicamento.PRECIO,
                                          nombreFormaFarmaceutica=FormaFarmaceutica.NOMBRE,
                                          concentracion=medicamento.CONCENTRACION,
                                          presentacion=medicamento.PRESENTACION,
                                          stock=(int)medicamento.STOCK,
                                          bhabilitado=(int)medicamento.BHABILITADO
                                      }).ToList();
                }
            } catch (Exception ) {
                listaMedicamento=null;
            }
            return listaMedicamento;
        }

        MedicamentoCLS IMedicamentos.recuperarMedicamento(int iidmedicamento) {
            MedicamentoCLS oMedicamentoCLS = new MedicamentoCLS();
            try {
                using (var bd = new MedicoEntities()) {
                    Medicamento oMedicamento = bd.Medicamento.Where(p=>p.IIDMEDICAMENTO == iidmedicamento).First();
                    oMedicamentoCLS.iidmedicamento=oMedicamento.IIDMEDICAMENTO;
                    oMedicamentoCLS.iidformafarmaceutica=(int)oMedicamento.IIDFORMAFARMACEUTICA;
                    oMedicamentoCLS.nombre=oMedicamento.NOMBRE;
                    oMedicamentoCLS.precio=(decimal)oMedicamento.PRECIO;
                    oMedicamentoCLS.stock=(int)oMedicamento.STOCK;
                    oMedicamentoCLS.concentracion=oMedicamento.CONCENTRACION;
                    oMedicamentoCLS.presentacion=oMedicamento.PRESENTACION;
                }
            } catch (Exception) {
                oMedicamentoCLS=null;
            }
            return oMedicamentoCLS;
        }

        int IMedicamentos.registrarYActualizarMedicamentos(MedicamentoCLS oMedicamentoCLS) {
            int rpta = 0;
            try {
                using (var bd = new MedicoEntities()) {
                    //Registrar 
                    if (oMedicamentoCLS.iidformafarmaceutica==0) {
                        Medicamento omedicamento = new Medicamento();
                        omedicamento.IIDMEDICAMENTO=oMedicamentoCLS.iidmedicamento;
                        omedicamento.NOMBRE=oMedicamentoCLS.nombre;
                        omedicamento.PRECIO=oMedicamentoCLS.precio;
                        omedicamento.STOCK=oMedicamentoCLS.stock;
                        omedicamento.IIDFORMAFARMACEUTICA=oMedicamentoCLS.iidformafarmaceutica;
                        omedicamento.CONCENTRACION=oMedicamentoCLS.concentracion;
                        omedicamento.PRESENTACION=oMedicamentoCLS.presentacion;
                        omedicamento.BHABILITADO=1;

                        bd.Medicamento.Add(omedicamento);
                        bd.SaveChanges();
                        rpta=1;
                    } else {
                        Medicamento oMedicamento = bd.Medicamento.Where(p=>p.IIDMEDICAMENTO == oMedicamentoCLS.iidmedicamento).First();
                        oMedicamento.IIDMEDICAMENTO = oMedicamentoCLS.iidmedicamento;
                        oMedicamento.NOMBRE=oMedicamentoCLS.nombre;
                        oMedicamento.PRECIO=oMedicamentoCLS.precio;
                        oMedicamento.STOCK=oMedicamentoCLS.stock;
                        oMedicamento.IIDFORMAFARMACEUTICA=oMedicamentoCLS.iidformafarmaceutica;
                        oMedicamento.CONCENTRACION=oMedicamentoCLS.concentracion;
                        oMedicamento.PRESENTACION=oMedicamentoCLS.presentacion;

                        bd.SaveChanges();
                        rpta=1;
                    }
                }
            } catch (Exception) {
                rpta=0;
            }
            return rpta;
        }
    }
}