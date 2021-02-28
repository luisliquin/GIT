using ServiciosMedicamento.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace ServiciosMedicamento {
    [ServiceContract]
    public interface IMedicamentos {
        //Listado medicamentos
        [OperationContract]
        List<MedicamentoCLS> listarMedicamentos();

        //Lista forma farmaceutica
        [OperationContract]
        List<FormaFarmaceuticaCLS> listarFormaFarmaceutica();

        //Recuperar medicamento
        [OperationContract]
        MedicamentoCLS recuperarMedicamento(int iidmedicamento);

        //Agregar y editar medicamento
        [OperationContract]
        int registrarYActualizarMedicamentos(MedicamentoCLS oidmedicamentoCLS);

        //Eliminar medicamento
        [OperationContract]
        int eliminarMedicamento(int iidMedicamento);
    }
}
