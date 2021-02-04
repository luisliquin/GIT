var canvas; 
var ctx;
var FPS = 50;

//DIMENSIONES DE LAS CASILLAS
var anchoF = 50;
var altoF = 50;

//COLORES
var muro = '#000000';
var tierra = '#c6892f';

var escenario = [
    [0,0,0,0,0,0,0,0,0,0,0,0,0,0,0],
    [0,2,2,0,0,0,2,2,2,2,0,0,2,2,0],
    [0,0,2,2,2,2,2,0,0,2,0,0,2,0,0],
    [0,0,2,0,0,0,2,2,0,2,2,2,0,0,0],
    [0,0,2,2,2,0,0,2,0,0,0,2,0,0,0],
    [0,2,2,0,0,0,0,2,0,0,0,2,0,0,0],
    [0,0,2,0,0,0,2,2,2,0,0,2,2,2,0],
    [0,2,2,2,0,0,2,0,0,0,1,0,0,2,0],
    [0,2,2,3,0,0,2,0,0,2,2,2,2,2,0],
    [0,0,0,0,0,0,0,0,0,0,0,0,0,0,0]
]

var protagonista;

//CLASE JUGADOR
var jugador = function(){
    this.x = 100;
    this.y = 100;

    this.dibuja = function(){
        ctx.fillStyle = '#820c01';
        ctx.fillRect(this.x)
    }
}

function dibujaEscenario(){
    var color;

    for(y=0;y<10; y++){
        for(x=0;x<15;x++){
            if(escenario[y][x]==0){

            }
        }
    }
}