using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ServiceMedicamento;

namespace MiPrimerConsumoNetCore.Controllers {
    public class MedicamentoController : Controller {
        public IActionResult Index() {
            return View();
        }

        public async Task<JsonResult> listarMedicamentos() {
            MedicamentosClient omedicamentosClient = new MedicamentosClient();
            List<MedicamentoCLS> lista = await omedicamentosClient.listarMedicamentosAsync();
            var listaMedicamento = lista.Where(p => p.bhabilitado==1)
                .Select(p => new{
                    p.iidmedicamento,
                    p.nombre,
                    p.concentracion,
                    p.nombreFormaFarmaceutica,
                    p.stock,
                    p.precio,
                    p.presentacion
                });
            return Json(listaMedicamento);
        }

        public async Task<JsonResult> listarFormaFarmaceutica() {
            MedicamentosClient oMedicamentosClient = new MedicamentosClient();
            List<FormaFarmaceuticaCLS> lista = await oMedicamentosClient.listarFormaFarmaceuticaAsync();
            var listaFormFarmaceutica = lista.Select(p => new {
                p.iidformafarmaceutica,
                p.nombreFormaFarmaceutica
            });
            return Json(listaFormFarmaceutica);
        }

        public async Task<JsonResult> recuperarMedicamento(int iiMedicamento) {
            MedicamentosClient oMedicamentosClient = new MedicamentosClient();
            var medicamento = await oMedicamentosClient.recuperarMedicamentoAsync(iiMedicamento);
            return Json(medicamento);
        }
        ///////////
        public async Task<int> agregaryYEditarMedicamento([FromBody] MedicamentoCLS oMedicamentoCLS) {
            int rpta = 0;
            try {
                MedicamentosClient oMedicamentoClient = new MedicamentosClient();
                rpta= await oMedicamentoClient.registrarYActualizarMedicamentosAsync(oMedicamentoCLS);
            } catch (Exception) {
                rpta=0;
            }
            return rpta;
        }

        public async Task<int> eliminarMedicamento(int iidMedicamento) {
            int rpta = 0;

            try {
                MedicamentosClient oMedicamentosClient = new MedicamentosClient();
                rpta= await oMedicamentosClient.eliminarMedicamentoAsync(iidMedicamento);
            } catch (Exception) {
                rpta=0;
            }
            return rpta;
        }

        public async Task<JsonResult> buscarMedicamentosPorNombre(string nombreMedicamento) {
            MedicamentosClient oMedicamentosClient = new MedicamentosClient();
            var lista = await oMedicamentosClient.listarMedicamentosAsync();
            var listaBusqueda = lista.Where(p => p.bhabilitado==1 && p.nombre.ToLower().Contains(nombreMedicamento.ToLower()))
                    .Select(
                        p => new {
                            p.iidmedicamento,
                            p.nombre,
                            p.concentracion,
                            p.nombreFormaFarmaceutica,
                            p.stock,
                            p.precio,
                            p.presentacion
                        }
                    ).ToList();
            return Json(listaBusqueda);
        }
    }
}