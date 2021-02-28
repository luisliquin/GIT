using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IdentityModel.Selectors;
using System.ServiceModel;

namespace ServiciosMedicamento.Clases {
    public class Autenticacion : UserNamePasswordValidator {
        public override void Validate(string userName, string password) {
            if (string.IsNullOrEmpty(userName)) {
                throw new ArgumentException("El usuario no puede ser nulo o vacio");
            }

            if (string.IsNullOrEmpty(password)) {
                throw new ArgumentException("El password no puede ser nulo o vacio");
            }

            //usuario: lhurol contraseña 1234
            if (!(userName.ToLower().Equals("lhurol")&&password.ToLower().Equals("1234"))) {
                throw new FaultException("Usuario y contraseña incorrecta");
            }

        }
    }
}