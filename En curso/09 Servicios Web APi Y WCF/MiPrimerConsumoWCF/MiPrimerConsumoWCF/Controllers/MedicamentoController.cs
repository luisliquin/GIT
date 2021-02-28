using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MiPrimerConsumoWCF.ServiceMedicamento;

namespace MiPrimerConsumoWCF.Controllers
{
    public class MedicamentoController : Controller
    {
        // GET: Medicamento
        public ActionResult Index(){
            return View();
        }

        public JsonResult listarMedicamentos() {
            MedicamentosClient oMedicamentosClient = new MedicamentosClient();
            var lista = oMedicamentosClient.listarMedicamentos()
                .Where(p => p.bhabilitado==1)
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
            return Json(lista, JsonRequestBehavior.AllowGet);
        }

        public JsonResult listarFormaFarmaceutica() {
            MedicamentosClient oMedicamentosClient = new MedicamentosClient();
            var lista = oMedicamentosClient.listarFormaFarmaceutica()
                .Select(p => new {
                    p.iidformafarmaceutica,
                    p.nombreFormaFarmaceutica
                 }).ToList();
            return Json(lista, JsonRequestBehavior.AllowGet);
        }

        public JsonResult recuperarMedicamento(int iidMedicamento) {
            MedicamentosClient oMedicamentosClient = new MedicamentosClient();
            var medicamento = oMedicamentosClient.recuperarMedicamento(iidMedicamento);
            return Json(medicamento, JsonRequestBehavior.AllowGet);
        }

        public int agregaryYEditarMedicamento(MedicamentoCLS omedicamentoCLS) {
            int rpta = 0;
            try {
                MedicamentosClient oMedicamentoClient = new MedicamentosClient();
                rpta = oMedicamentoClient.registrarYActualizarMedicamentos(omedicamentoCLS);
            } catch (Exception) {
                rpta = 0;
            }
            return rpta;
        }

        public int eliminarMedicamento(int iidMedicamento) {
            int rpta = 0;

            try {
                MedicamentosClient oMedicamentosClient = new MedicamentosClient();
                rpta = oMedicamentosClient.eliminarMedicamento(iidMedicamento);
            } catch (Exception) {
                rpta = 0;
            }
            return rpta;
        }


    }
}