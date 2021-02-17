using CNTI.FACTUR.ENTITY.Parametros;
using CNTI.FACTUR.ENTITY.Response;
using CNTI365.FACTUR.CLIENTS;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNTI365.FACTUR.BUSINESS {
    public class BUPais {
        private Client client;

        public BUPais() {
            client=new Client();
        }

        public List<ResponsePais> listaPaises(ENRegistroEmpresa paramss, string token) {
            try {
                return JsonConvert.DeserializeObject<List<ResponsePais>>(client.Post<ENRegistroEmpresa>("RegistroEmpresa/listaPaises", paramss, token));
            } catch (Exception ex) {

                throw ex;
            }
        }
    }
}