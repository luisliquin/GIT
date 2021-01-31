var canvas;
var ctx;
var FPS = 50;

var anchoF = 50;
var altoF = 50;

var muro   = '#044f14';
var puerta = '#3a1700';
var tierra = '#c6892f';
var llave  = '#c6bc00';

var escenario = [
    [0,0,0,0,0,0,0,0,0,0],
    [0,2,2,0,0,0,2,2,0,0],
    [0,0,2,2,2,2,2,0,0,0],
    [0,0,2,0,0,0,2,2,0,0],
    [0,0,2,2,2,0,0,2,0,0],
    [0,2,2,0,0,0,0,2,0,0],
    [0,0,2,0,0,0,2,2,2,0],
    [0,2,2,2,0,0,2,0,0,0],
    [0,2,2,2,0,0,2,0,0,0],
    [0,0,0,0,0,0,0,0,0,0]
];

function dibujaEscenario(){
    var color;
    for(y=0; y<10;y++){
        for(x=0; x<10; x++){
            if (escenario[y][x]==0)
                color = muro;
            if (escenario[y][x]==1)
                color = puerta;
            if (escenario[y][x]==2)
                color = tierra;   
            if (escenario[y][x]==3)
                color = tierra;   
            if (escenario[y][x]==4)
                color = tierra;   
            
            ctx.fillStyle = color;
            ctx.fillRect(x*anchoF, y*altoF, anchoF, altoF);
        }
    }
}

//OBJETO JUGADOR
var jugador = function(){
    this.x = 1;
    this.y = 1;
    this.color = '#820c01';

    this.dibuja = function(){
        ctx.fillStyle = this.color;
        ctx.fillRect(this.x*anchoF, this.y*altoF, anchoF, altoF);
    }

    this.margenes = function(x,y){
        var colision = false;

        if(escenario[y][x]==0){
            colision = true;
        }
        return(colision);
    }

    this.arriba = function(){
        if(this.margenes(this.x, this.y-1)==false)
            this.y--;
    }

    this.abajo = function(){
        if(this.margenes(this.x, this.y+1)==false)
        this.y++;
    }

    this.izquierda = function(){
        if(this.margenes(this.x-1, this.y)==false)
        this.x--;
    }

    this.derecha = function(){
        if(this.margenes(this.x+1, this.y)==false)
        this.x++;
    }
}

var protagonista;

function inicializa(){
    canvas = document.getElementById('canvas');
    ctx = canvas.getContext('2d');

    //CREAMOS AL JUGADOR
    protagonista = new jugador();

    //LECTURA DEL TECLADO
    document.addEventListener('keydown', function(tecla){
        if(tecla.keyCode ==38){
            protagonista.arriba();
        }
        if(tecla.keyCode ==40){
            protagonista.abajo();
        }
        if(tecla.keyCode ==37){
            protagonista.izquierda();
        }
        if(tecla.keyCode ==39){
            protagonista.derecha();
        }
    }
    );

    setInterval(function(){
        principal();
    },1000/FPS);
}

function borraCanvas(){
    canvas.width = 500;
    canvas.heigth = 400;
}

function principal(){
    borraCanvas();
    dibujaEscenario();
    protagonista.dibuja();
    //console.log('funcion');
}