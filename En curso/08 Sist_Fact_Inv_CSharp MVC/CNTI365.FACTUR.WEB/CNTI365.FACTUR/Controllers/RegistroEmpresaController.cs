using CNTI.FACTUR.ENTITY.Parametros;
using CNTI365.FACTUR.BUSINESS;
using CNTI365.FACTUR.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CNTI365.FACTUR.Controllers {
    public class RegistroEmpresaController : Controller {
        private modelList model;
        private BUPais bupais;
        private BURegistroEmpresa buregistroempresa;
        public RegistroEmpresaController() {
            model=new modelList();
            bupais=new BUPais();
            buregistroempresa=new BURegistroEmpresa();
        }

        public ActionResult RegistroEmpresa(ENRegistroEmpresa paramss) {
            string token = "";
            model.listPais = bupais.listarPaises(paramss, token);
            model.listMoneda =bupais.listarMoneda(paramss, token);
            model.listTImpuesto=bupais.listarTImpuestos(paramss, token);
            model.listPImpuestos=bupais.listarPImpuestos(paramss, token);
            return View(model);
        }

        [AllowAnonymous]
        [HttpPost]
        public ActionResult validarRegistro(ENRegistroEmpresa paramss) {
            var rpt = buregistroempresa.validarRegistro(paramss);
            return Json(new {dt = rpt})
        }
    }
}
