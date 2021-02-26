using CNTI.FACTUR.ENTITY.Encrypt;
using CNTI.FACTUR.ENTITY.Parametros;
using CNTI365.FACTUR.BUSINESS;
using CNTI365.FACTUR.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
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
            string token = "";
            var rpt = buregistroempresa.validarRegistro(paramss, token);
            return Json(new { dt = rpt });
        }

        [HttpPost]
        public ActionResult insertarEmpresa(HttpPostedFileBase file, string razonsocial, string ruc, string email, int idpais, int idmoneda, 
                                            string direccion, int idimpuesto, int idporcentaje, int vendeimpuesto,string username,
                                            string usuario, string contraseña){
            try {
                var clave = Encrypt.GetSHA256(contraseña);
                var filename = "";

                if (file!=null) {
                    string path = Server.MapPath("~/Content/img/img_empresas" + ruc + "/");
                    string filePath = string.Empty;

                    if (!Directory.Exists(path)) {
                        Directory.CreateDirectory(path);
                    }

                    filePath=path+Path.GetFileName(file.FileName);
                    file.SaveAs(filePath);
                    filename=file.FileName;
                }

                var paramss = new ENRegistroEmpresa();
                paramss.razonsocial = razonsocial;
                paramss.ruc = ruc;
                paramss.email=email;
                paramss.idpais=idpais;
                paramss.idmoneda=idmoneda;
                paramss.direccion=direccion;
                paramss.idimpuesto=idimpuesto;
                paramss.idporcentaje=idporcentaje;
                paramss.vendeimpuestos=vendeimpuesto;
                paramss.username=username;
                paramss.usuario=usuario;
                paramss.contraseña=clave;
                paramss.cantuser=1;
                paramss.cargo="superadmin";
                paramss.filename=filename;
                paramss.proyecto="FACTURA";

                string token = "";

                var rpt = buregistroempresa.insertarEmpresa(paramss, token);

                if (rpt.response=="ok") {
                    rpt=buregistroempresa.insertarUserAdminEmpresa(paramss, token);

                    if (rpt.response=="ok") {
                        string url = string.Format("https://localhost:44320/ActivarCuenta/ActivarCuenta/ruc" + ruc);
                        string para = email;
                        string asunto = "Activacion de cuenta | sistema de facturacion e inventario";
                        string mensaje = "<b>Gracias por registrarse</b>" + "<br/></br>" +
                            "Estas son sus credenciales de acceso" + "<br/></br/>" +
                            "Usuario: " + usuario + "<br/>" +
                            "Contraseña: " + contraseña + "<br/>" +
                            "Cargo: " + paramss.cargo + "<br/></br/>" +
                            "Para poder acceder al sistema debe poder primero poder activar la cuenta. Activela <a href=\""+ url +"\">aqui</a>" + "</br></br>" +
                            "Recuerde, esto es un periodo de prueba por 15 dias, para obtener una licencia escribenos al correo ventas@empresa.com";

                        MailMessage correo = new MailMessage();
                        correo.From=new MailAddress("systemafactur@empresa.com"); //Agregar dominio de la empresa
                        correo.To.Add(para);
                        correo.Subject=asunto;
                        correo.Body=mensaje;
                        correo.IsBodyHtml=true;
                        SmtpClient smtp = new SmtpClient("smtp-mail.outlook.com"); //cambiar por el nombre de la SMTP
                        string sCuentaCorreo = "luis_liquin@hotail.com"; // cambiar por el correo de la empresa
                        string sPassword = "test"; //cambiar pass de la empresa
                        NetworkCredential credential = new NetworkCredential(sCuentaCorreo, sPassword);
                        smtp.UseDefaultCredentials=false;
                        smtp.Credentials=credential;
                        smtp.Port=465; //cambiar puerto por el de la empresa
                        smtp.EnableSsl=true; //puede variar la configuracion
                        smtp.Send(correo);

                        return Json(new { dt = rpt });
                    } else {
                        return Json(new { dt = rpt });
                    }
                } else {
                    return Json(new { dt = rpt });
                }

                return Json(new {dt = rpt });
            } catch (Exception ex) {

                throw ex;
            }
        }
    }
}
