using CNTI365.FACTUR.DATOS;
using CNTI365.FACTUR.ENTITY.Parametros;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CNTI365.WEBSERVICE.Controllers {
    [RoutePrefix("api/RegistroEmpresa")]
    public class RegistroEmpresaController : ApiController {
        private DAPaises dapaises;

        public RegistroEmpresaController() {
            dapaises = new DAPaises();
        }

        [HttpPost]
        [Route("listarPaises")]
        public IHttpActionResult listarPaises(ENRegistroEmpresa paramss) {
            try {
                var rpt = dapaises.listarPaises(paramss);
                return Ok(rpt);
            } catch (Exception ex) {

                throw ex;
            }
        }

        [HttpPost]
        [Route("listarMoneda")]
        public IHttpActionResult listarMoneda(ENRegistroEmpresa paramss) {
            try {
                var rpt = dapaises.listarMoneda(paramss);
                return Ok(rpt);
            } catch (Exception ex) {

                throw ex;
            }
        }

        [HttpPost]
        [Route("listarTImpuestos")]
        public IHttpActionResult listarTImpuestos(ENRegistroEmpresa paramss) {
            try {
                var rpt = dapaises.listarTImpuestos(paramss);
                return Ok(rpt);
            } catch (Exception ex) {

                throw ex;
            }
        }
    }
}