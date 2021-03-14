using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using MiSegundaWebAPIConsumida.Clases;
using Newtonsoft.Json;

namespace MiSegundaWebAPIConsumida.CapaDatos {
    public class DoctorDAL {
        public async Task<List<DoctorCLS>> ListarDoctor() {
            string rpta = "";
            HttpClient cliente = new HttpClient();
            string url = "http://192.168.0.3:8081/api/Doctor";
            HttpResponseMessage response = await cliente.GetAsync(url);
            List<DoctorCLS> listaDoctor = new List<DoctorCLS>();
            if (response!=null) {
                rpta= await response.Content.ReadAsStringAsync();
                listaDoctor = JsonConvert.DeserializeObject<List<DoctorCLS>>(rpta);
            }
            return listaDoctor;
        }

        public async Task<List<EspecialidadCLS>> listarEspecialidad() {
            string rpta = "";
            HttpClient cliente = new HttpClient();
            string url = "http://192.168.0.3:8081/api/Especialidad";
            HttpResponseMessage response = await cliente.GetAsync(url);
            List<EspecialidadCLS> listaEspecialidad = new List<EspecialidadCLS>();
            if (response!=null) {
                rpta=await response.Content.ReadAsStringAsync();
                listaEspecialidad = JsonConvert.DeserializeObject<List<EspecialidadCLS>>(rpta);
            }
            return listaEspecialidad;
        }

        public async Task<List<ClinicaCLS>> listarClinica() {
            string rpta = "";
            HttpClient cliente = new HttpClient();
            string url = "http://192.168.0.3:8081/api/Clinica";
            HttpResponseMessage response = await cliente.GetAsync(url);
            List<ClinicaCLS> listaClinica = new List<ClinicaCLS>();
            if (response!=null) {
                rpta=await response.Content.ReadAsStringAsync();
                listaClinica = JsonConvert.DeserializeObject<List<ClinicaCLS>>(rpta);
            }
            return listaClinica;
        }

        public async Task<DoctorCLS> recuperarDoctor(int iidDoctor) {
            string rpta = "";
            HttpClient cliente = new HttpClient();
            string url="http://192.168.0.3:8081/api/Doctor/?iidDoctor=" + iidDoctor;
            HttpResponseMessage response = await cliente.GetAsync(url);
            DoctorCLS oDoctorCLS = new DoctorCLS();
            if (response!=null) {
                rpta=await response.Content.ReadAsStringAsync();
                oDoctorCLS=JsonConvert.DeserializeObject<DoctorCLS>(rpta);
            }
            return oDoctorCLS;
        }

        public async Task<int> eliminarDoctor(int iidDoctor) {
            int rpta = 0;
            HttpClient cliente = new HttpClient();
            string url="http://192.168.0.3:8081/api/Doctor/?iidDoctor=" + iidDoctor;
            DoctorCLS oDoctor = new DoctorCLS{
                iidDoctor = iidDoctor
            };
            var jsonRequest = JsonConvert.SerializeObject(oDoctor);
            var content = new StringContent(jsonRequest, Encoding.UTF8, "text/json");
            HttpResponseMessage response = await cliente.PutAsync(url, content);
            if (response!=null) {
                string rptaCadena = await response.Content.ReadAsStringAsync();
                rpta = int.Parse(rptaCadena);
            }
            return rpta;
        }
    }
}
