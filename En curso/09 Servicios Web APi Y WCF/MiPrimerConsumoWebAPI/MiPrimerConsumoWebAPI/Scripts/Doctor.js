window.onload = function (){
    listarDoctor();
    previewImage();
    listarClinica();
   listarEspecialidad();
}

function listarClinica() {
    //console.log("listar clinica");
    fetch("http://192.168.0.3:8081/api/Clinica")
        .then(res => res.json())
        .then(res => {
//          console.log(res);
            llenarComboClinica(res)
        })
}

function llenarComboClinica(res) {
    var contenido = "<option value=''>--Seleccione</option>";
    for (var i = 0; i < res.length; i++) {
        contenido += "<option value='" + res[i].iidClinica + "'>" + res[i].nombreClinica + "</option>"
    }
    document.getElementById("cboClinica").innerHTML = contenido;
}

function listarEspecialidad() {
    fetch("http://192.168.0.3:8081/api/Especialidad")
        .then(res => res.json())
        .then(res => {
            llenarComboEspecialidad(res)
        })
}


function llenarComboEspecialidad(res) {
    var contenido = "<option value=''>--Seleccione</option>";
    for (var i = 0; i < res.length; i++) {
        contenido += "<option value='" + res[i].iidEspecialidad + "'>" + res[i].nombreEspecialidad + "</option>"
    }
    document.getElementById("cboEspecialidad").innerHTML = contenido;
}

function previewImage() {
    var fupFoto = document.getElementById("fupFoto");
    fupFoto.onchange = function () {

        //Foto elegida
        var foto = fupFoto.files[0];
        nombreArchivo = foto.name;

        //File reader leer la foto
        var file = new FileReader();

        file.onloadend = function () {
            document.getElementById("imgFoto").src = file.result;
        }

        file.readAsDataURL(foto);
    }
}

function listarDoctor() {
    fetch('http://192.168.0.3:8081/api/Doctor')
        .then(res => res.json())
        .then(res => {
            crearListado(res);
        });
}

function crearListado(res) {
    var contenido = "";

    contenido += "<table class='table'>";
    contenido += "<thead class = 'thead-dark'>";
    contenido += "<tr>";
    contenido += "<td>Id Doctor</td>";
    contenido += "<td>Nombre completo</td>";
    contenido += "<td>Nombre clinica</td>";
    contenido += "<td>Nombre especialidad</td>";
    contenido += "<td>Email</td>";
    contenido += "<td>Operaciones</td>";
    contenido += "</tr>";
    contenido += "</thead>";

    contenido += "<tbody>"
    for (var i = 0; i < res.length; i++) {
        contenido += "<tr>";
        contenido += "<td>" + res[i].iidDoctor + "</td>";
        contenido += "<td>" + res[i].nombreCompleto + "</td>";
        contenido += "<td>" + res[i].nombreClinica + "</td>";
        contenido += "<td>" + res[i].nombreEspecialidad + "</td>";
        contenido += "<td>" + res[i].email + "</td>";
        contenido += "<td>";
        contenido += "<button onclick='AbrirModal(" + res[i].iidDoctor + ")' class='btn btn-primary' data-toggle='modal' data-target='#exampleModal' > Editar </button>";
        contenido += "<button onclick='Eliminar(" + res[i].iidDoctor + ")' class='btn btn-danger'> Eliminar </button>";
        contenido += "</td>";
        contenido += "</tr>";
    }
    contenido += "</tbody>"
    contenido += "</table>";

    document.getElementById("divTabla").innerHTML = contenido;
}

function Eliminar(iidDoctor) {
    if (confirm("Desea eliminar realmente ??") == 1) {
        fetch("http://192.168.0.3:8081/api/Doctor?iidDoctor=" + iidDoctor, {
            method: "PUT"
        }).then(res => res.json())
            .then(res => {
                if (res == 1) {
                    alert("Se elmino correctamente");
                    listarDoctor();
                } else {
                    alert("Ocurrio un error");
                }
            })
    }
}

function Limpiar() {
    console.log('limpiar');
    var limpiar = document.getElementsByClassName("limpiar");
    var nlimpiar = limpiar.length;

    for (var i = 0; i < nlimpiar; i++) {
        limpiar[i].value = "";
    }
}

function AbrirModal(id) {
    Limpiar();
    if (id == 0) {
        document.getElementById("lblTitulo").innerHTML = "Agregar doctor";
    } else {
        fetch("http://192.168.0.3:8081/api/Doctor/?iidDoctor=" + id)
            .then(res => res.json())
            .then(res => {
                document.getElementById("txtIdDoctor").value = res.iidDoctor;
                document.getElementById("txtNombre").value = res.nombre;
                document.getElementById("txtApPaterno").value = res.apPaterno;
                document.getElementById("txtApMaterno").value = res.apMaterno;
                document.getElementById("cboClinica").value = res.iidClinica;
                document.getElementById("cboEspecialidad").value = res.iidespecialidad;
                document.getElementById("txtemail").value = res.email;
                document.getElementById("txtTelefonoCelular").value = res.telefonoCelular;
                document.getElementById("txtsueldo").value = res.sueldo;
                //radio
                var rbSexoMascu = document.getElementById("rbSexoMascu");
                var rbSexoFeme = document.getElementById("rbSexoFeme");
                if (res.iidSexo == 1) {
                    rbSexoMascu.checked = true;
                } else {
                    rbSexoFeme.checked = true;
                }
                //fechaContrato 2019-05-16T00:00:00
                document.getElementById("txtFechaContrato").value = res.fechaContrato.substr(0, 10);
                document.getElementById("imgFoto").src = res.archivo;
                nombreArchivo = res.nombre;
            });
        document.getElementById("lblTitulo").innerHTML = "Editar doctor";
    }
}

var nombreArchivo;

function Guardar() {
    console.log("entre a guardar datos");
    if (confirm("Desea guardar los cambios?") == 1) {
        var idDoctor = document.getElementById("txtIdDoctor").value;
        var nombre = document.getElementById("txtNombre").value;
        var apPaterno = document.getElementById("txtApPaterno").value;
        var apMaterno = document.getElementById("txtApMaterno").value;
        var idClinica = document.getElementById("cboClinica").value;
        var idEspecialidad = document.getElementById("cboEspecialidad").value;
        var email = document.getElementById("txtemail").value;
        var telefonoCelular = document.getElementById("txtTelefonoCelular").value;
        var sueldo = document.getElementById("txtsueldo").value;
        var fechaContrato = document.getElementById("txtFechaContrato").value;
        var foto = document.getElementById("imgFoto").src;

        var cboSexo;
        if (document.getElementById("rbSexoMascu").checked == 1) {
            cboSexo = 1;
        } else {
            cboSexo = 2;
        }

        /*
        if (foto != null) {
            var nombreArchivo = document.getElementById("fupFoto").files[0].name;
        }*/

        fetch("http://192.168.0.3:8081/api/Doctor", {
            headers: {
                'Content-Type': 'application/json'
            },
            method: 'POST',
            body: JSON.stringify({
                "IIDDOCTOR": idDoctor,
                "NOMBRE": nombre,
                "APPATERNO": apPaterno,
                "APMATERNO": apMaterno,
                "IIDCLINICA": idClinica,
                "IIDESPECIALIDAD": idEspecialidad,
                "EMAIL": email,
                "TELEFONOCELULAR": telefonoCelular,
                "IIDSEXO": cboSexo,
                "SUELDO": sueldo,
                "FECHACONTRATO": fechaContrato,
                "ARCHIVO": foto,
                "NOMBREARCHIVO": nombreArchivo,
                "BHABILITADO": 1
            })
        }).then(res => res.json())
            .then(res => {
                alert("Se ejecuto corectamente");
                listarDoctor();
                document.getElementById("btnClose").click();
            })
            .catch((error) => {
                alert("Hubo un error");
                console.log(error);
                listarDoctor();
                document.getElementById("btnClose").click();
            });
    }
}