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

function Limpiar() {
    var limpiar = document.getElementsByClassName("Limpiar");
    var nlimpiar = limpiar.length;
    for (i = 0; i < nlimpiar; i++) {
        limpiar[i].value = "";
    }
}

function llenarCombo(res) {
    var contenido = "";
    contenido += "<option value=''>--Seleccione--<option>";
    for (i = 0; i < res.length; i++) {
        contenido += "<option value='" + res[i].iidformafarmaceutica + "'>" + res[i].nombreFormaFarmaceutica + "</option>";
        console.log(contenido);
    }
    document.getElementById("cboFormaFarmaceutica").innerHTML = contenido;
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
    contenido += "<table class = 'table'>";
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
        contenido += "<input type='button' class='btn btn-danger' value='Elminar'/> </td>";
        contenido += "</tr>";
    }

    contenido += "</tbody>";
    contenido += "</table>";

    console.log(contenido);

    document.getElementById("divTabla").innerHTML = contenido;
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
            })
    }
}