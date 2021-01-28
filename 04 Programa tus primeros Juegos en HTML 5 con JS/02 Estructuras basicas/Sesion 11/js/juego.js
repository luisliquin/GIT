var numeroCPU = 0;
var numeroUsuario = 0;

numeroCPU = Math.floor((Math.random() * 10) + 1);

do{
    numeroUsuario = parseInt(prompt("Adivina el numero que he pensado"));
    if(numeroUsuario==numeroCPU){
        console.log("haz acertado");
    }else{
        if (numeroCPU < numeroUsuario){
            alert("El numero es mas pequeño");
        }else{
            alert("El numero es mayor");
        }
    }
}while(numeroUsuario!=numeroCPU);