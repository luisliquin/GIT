function tablas(){
    for(tabla = 1; tabla < 10; tabla++){
        console.log("tabla del " + tabla);
        
        for(multiplicador = 1; multiplicador < 11; multiplicador++){
            var resultado = tabla * multiplicador;
            console.log(tabla + " X " + multiplicador + " = " + resultado);
        }
    }
}