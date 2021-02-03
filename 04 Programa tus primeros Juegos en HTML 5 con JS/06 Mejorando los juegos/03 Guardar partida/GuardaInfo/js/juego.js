function guardar(valor){
    localStorage.setItem("nombre_jugador", valor);
    console.log("dato guardado");
}

function cargar(){
    return(localStorage.getItem("nombre_jugador"));
}

function borrar(){
    localStorage.removeItem("nombre_jugador");
}

function inicializa(){
    document.addEventListener('keydown', function(tecla){
        
        if(tecla.keyCode ==38){
            //arriba
            guardar("Luis");
        }
        if(tecla.keyCode ==40){
            //abajo
            var dato = cargar();
            console.log(dato);
        }
        if(tecla.keyCode ==37){
            //izquierda
            borrar();
        }
        if(tecla.keyCode ==39){
            //derecha
        }
    })
}