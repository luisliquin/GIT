var personaje =  function(x,y,nombre){
    this.x = 0;
    this.y = 0;
    this.nombre = nombre;
    
    //METODO 'ABAJO'
    this.abajo = function(){
        this.y += 10;
    }

    //METODO 'HABLAR'
    this.hablar = function(){
        console.log('Hola forastero me llamo ' + this.nombre);
    }
}

var personaje1 = new personaje(10,100,'Frodo');
var personaje2 = new personaje(220,300,'Sam');

personaje1.abajo();