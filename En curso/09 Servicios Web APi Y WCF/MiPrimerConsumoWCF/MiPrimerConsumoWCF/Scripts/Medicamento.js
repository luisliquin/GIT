window.onload = function () {
    listarMedicamentos();
    listarFormaFarmaceutica();
}

function listarFormaFarmaceutica() {
    fetch("Medicamento/listarFormaFarmaceutica")
        .then(res => res.json())
        .then(res => {
            llenarCombo(res);
        });
}

function llenarCombo(res) {
    var contenido = "";
    contenido += "<option value=''>--Seleccione--</option>"

    for (var i = 0; i < res.length; i++) {
        contenido += "<option value='" + res[i].iidformafarmaceutica + "'>" + res[i].nombreFormaFarmaceutica + "</option>";
        // console.log(contenido);
    }
    document.getElementById("cboFormaFarmaceutica").innerHTML = contenido;
}

function filtrarDatos() {
    var nombreMedicamento = document.getElementById("txtBuscarNombreMedicamento").value;

    if (nombreMedicamento != "") {
        fetch("Medicamento/buscarMedicamentosPorNombre/?nombreMedicamento=" + nombreMedicamento)
            .then(res => res.json())
            .then(res => {
                listar(res);
            })
    } else {
        listarMedicamentos();
    }
}



function Limpiar() {
    var limpiar = document.getElementsByClassName("Limpiar");
    var nlimpiar = limpiar.length;
    for (var i = 0; i < nlimpiar; i++) {
        limpiar[i].value = "";
    }
}

function listarMedicamentos(){
    fetch("Medicamento/listarMedicamentos")
        .then(res => res.json())
        .then(res => {
            listar(res);
        });
}

function listar(res) {
    var contenido = "";
    contenido += "<table id='table' class = 'table'>";
    contenido += "<thead class = 'table-dark'>";

    //Deinimos la 1ra fila
    contenido += "<tr>";

    contenido += "<th>Id Medicamento</th>";
    contenido += "<th>Nombre</th>";
    contenido += "<th>Concentracion</th>";
    contenido += "<th>Forma Farmaceutica</th>";
    contenido += "<th>Stock</th>";
    contenido += "<th>Precio</th>";
    contenido += "<th>Presentacion</th>";
    contenido += "<th>Operaciones</th>";

    contenido += "</tr>";
    contenido += "</thead>";

    //Contenido
    contenido += "<tbody>";

    for (var i = 0; i < res.length; i++) {
        var item = res[i];
        contenido += "<tr>";
        contenido += "<td>" + item.iidmedicamento + "</td>";
        contenido += "<td>" + item.nombre + "</td>";
        contenido += "<td>" + item.concentracion + "</td>";
        contenido += "<td>" + item.nombreFormaFarmaceutica + "</td>";
        contenido += "<td>" + item.stock + "</td>";
        contenido += "<td>" + item.precio + "</td>";
        contenido += "<td>" + item.presentacion + "</td>";
        contenido += "<td><input type='button' class='btn btn-primary' onclick='abrirModal(" + item.iidmedicamento + ")' value='Editar'data-toggle='modal' data-target='#exampleModal'/>";
        contenido += "<input type='button' onclick='Eliminar(" + item.iidmedicamento + ")' class='btn btn-danger' value='Elminar'/> </td>";
        contenido += "</tr>";
    }

    contenido += "</tbody>";
    contenido += "</table>";

    document.getElementById("divTabla").innerHTML = contenido;
    $('#table').DataTable();
}

function Eliminar(iidmedicamento) {
    if (confirm("¿Desea eliminar realmente el registro?") == 1) {
        fetch("Medicamento/eliminarMedicamento/?iidMedicamento=" + iidmedicamento)
            .then(res => res.json())
            .then(res => {
                if (res == 1) {
                    listarMedicamentos();
                    alert("Se elimino correctamente");
                } else {
                    alert("Ocurrio un error");
                }
            })
    }
}

function abrirModal(iidMedicamento) {
    Limpiar();
    if (iidMedicamento === 0) {
        document.getElementById("lblTitulo").innerHTML = "Agregar Medicamento";
    } 
    else {
        //console.log(iidMedicamento);
        document.getElementById("lblTitulo").innerHTML = "Editar Medicamento";

        fetch("Medicamento/recuperarMedicamento/?iidMedicamento=" + iidMedicamento)
            .then(res => res.json())
            .then(res => {
                document.getElementById("txtIdMedicamento").value = res.iidmedicamento;
                document.getElementById("txtnombre").value = res.nombre;
                document.getElementById("txtconcentracion").value = res.concentracion;
                document.getElementById("cboFormaFarmaceutica").value = res.iidformafarmaceutica;
                document.getElementById("txtprecio").value = res.precio;
                document.getElementById("txtstock").value = res.stock;
                document.getElementById("txtpresentacion").value = res.presentacion;
            });
    }
}

function datosObligatorios() {
    //Significa que no hay errrores
    var exito = true;
    var contenido = "<ol style='color:red'>";
    var obligatorios = document.getElementsByClassName("obligatorio");
    var nobligatorio = obligatorios.length;

    for (var i = 0; i < nobligatorio; i++) {
        if (obligatorios[i].value === "") {
            exito = false;
            contenido += "<li>" + obligatorios[i].name + " es obligatorio</li>";
        }
    }
    contenido += "</ol>";
    return { exito, contenido };
}

function Guardar() {
    if (confirm("¿Deseas guardar los cambios?") == 1) {
        var objeto = datosObligatorios();

        if (objeto.exito == false) {
            document.getElementById("divError").innerHTML = objeto.contenido;
            return;
        } else {
            document.getElementById("divError").innerHTML = "";
        }

        //Capturar los valores
        var iidmedicamento = document.getElementById("txtIdMedicamento").value;
        var nombre = document.getElementById("txtnombre").value;
        var concentracion = document.getElementById("txtconcentracion").value;
        var iidformafarmaceutica = document.getElementById("cboFormaFarmaceutica").value;
        var precio = document.getElementById("txtprecio").value;
        var stock = document.getElementById("txtstock").value;
        var presentacion = document.getElementById("txtpresentacion").value;

        //Llamada al controller
        var objetoEnviar = {
            iidmedicamento,
            nombre,
            concentracion,
            iidformafarmaceutica,
            precio,
            stock,
            presentacion
        };

        fetch("Medicamento/agregaryYEditarMedicamento",{
            headers: {
                'Content-Type': 'application/json'
            },
            method: 'POST',
            body: JSON.stringify(objetoEnviar)
        }).then(res => res.json())
            .then(res => {
                if (res == 1) {
                    listarMedicamentos();
                    document.getElementById("btnCerrar").click();
                    alert("Se guardo correctamente");
                } else {
                    alert("Ocurrio un error");
                }
            })
    }
}

