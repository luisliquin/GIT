using CNTI365.FACTUR.ENTITY.Parametros;
using CNTI365.FACTUR.ENTITY.Response;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNTI365.FACTUR.DATOS {
    public class DAPaises {
        public List<ResponsePais> listarPaises(ENRegistroEmpresa paramss) {
            try {
                string cs = ConfigurationManager.ConnectionStrings["Conexion"].ConnectionString;
                var lista = new List<ResponsePais>();

                using (SqlConnection conn = new SqlConnection(cs)) {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("usp_listarPaises", conn);
                    cmd.CommandType=CommandType.StoredProcedure;

                    using (SqlDataReader rdr = cmd.ExecuteReader()) {
                        while (rdr.Read()) {
                            var resul = new ResponsePais();
                            resul.idpais=Convert.ToInt32(rdr["idpais"]);
                            resul.pais=Convert.ToString(rdr["pais"]);
                            lista.Add(resul);
                        }
                    }
                }
                return lista;
            } catch (Exception ex) {

                throw ex;
            }
        }
    }
}
