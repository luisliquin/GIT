using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MiPrimerConsumoWCF.ServiceMedicamentos;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Net.Security;

namespace MiPrimerConsumoWCF.Controllers
{
    public class MedicamentoController : Controller
    {
        // GET: Medicamento
        public ActionResult Index(){
            ServicePointManager.ServerCertificateValidationCallback=new System.Net.Security.RemoteCertificateValidationCallback(remove);
            return View();
        }

        private bool remove(object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors) {
            return true;
        }

        public JsonResult listarMedicamentos() {
            MedicamentosClient oMedicamentosClient = new MedicamentosClient();
            oMedicamentosClient.ClientCredentials.UserName.UserName="lhurol";
            oMedicamentosClient.ClientCredentials.UserName.Password="1234";
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

        public JsonResult buscarMedicamentosPorNombre(string nombreMedicamento) {
            MedicamentosClient oMedicamentosClient = new MedicamentosClient();
            oMedicamentosClient.ClientCredentials.UserName.UserName="lhurol";
            oMedicamentosClient.ClientCredentials.UserName.Password="1234";
            var lista = oMedicamentosClient.listarMedicamentos()
                .Where(p => p.bhabilitado==1 && p.nombre.ToLower().Contains(nombreMedicamento.ToLower()))
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
            oMedicamentosClient.ClientCredentials.UserName.UserName="lhurol";
            oMedicamentosClient.ClientCredentials.UserName.Password="1234";
            var lista = oMedicamentosClient.listarFormaFarmaceutica()
                .Select(p => new {
                    p.iidformafarmaceutica,
                    p.nombreFormaFarmaceutica
                 }).ToList();
            return Json(lista, JsonRequestBehavior.AllowGet);
        }

        public JsonResult recuperarMedicamento(int iidMedicamento) {
            MedicamentosClient oMedicamentosClient = new MedicamentosClient();
            oMedicamentosClient.ClientCredentials.UserName.UserName="lhurol";
            oMedicamentosClient.ClientCredentials.UserName.Password="1234";
            var medicamento = oMedicamentosClient.recuperarMedicamento(iidMedicamento);
            return Json(medicamento, JsonRequestBehavior.AllowGet);
        }

        public int agregaryYEditarMedicamento(MedicamentoCLS omedicamentoCLS) {
            int rpta = 0;
            try {
                MedicamentosClient oMedicamentoClient = new MedicamentosClient();
                oMedicamentoClient.ClientCredentials.UserName.UserName="lhurol";
                oMedicamentoClient.ClientCredentials.UserName.Password="1234";
                rpta= oMedicamentoClient.registrarYActualizarMedicamentos(omedicamentoCLS);
            } catch (Exception) {
                rpta = 0;
            }
            return rpta;
        }

        public int eliminarMedicamento(int iidMedicamento) {
            int rpta = 0;

            try {
                MedicamentosClient oMedicamentosClient = new MedicamentosClient();
                oMedicamentosClient.ClientCredentials.UserName.UserName="lhurol";
                oMedicamentosClient.ClientCredentials.UserName.Password="1234";
                rpta= oMedicamentosClient.eliminarMedicamento(iidMedicamento);
            } catch (Exception) {
                rpta = 0;
            }
            return rpta;
        }


    }
}