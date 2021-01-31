var canvas;
var ctx;
var FPS = 50;

var personaje = function(x,y){
    this.x = x;
    this.y = y;
    this.derecha = true;

    this.dibuja = function(){
        ctx.fillStyle = '#FF0000';
        ctx.fillRect(this.x, this.y, 50, 50);
    }

    this.mueve = function(velocidad){
        if(this.derecha == true)
            if(this.x <400)
                this.x+=velocidad;                
            else{
                this.derecha = false;
            }
        else{
            if(this.x > 50)
                this.x-=velocidad;
            else{
                this.derecha = true;
            }
        }
    }
}

var per1 = new personaje(10,50);
var per2 = new personaje(10,120);
var per3 = new personaje(10,230);

function inicializa(){
    canvas = document.getElementById('canvas');
    ctx = canvas.getContext('2d');

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
    per1.dibuja();
    per2.dibuja();
    per3.dibuja();

    per1.mueve(1);
    per2.mueve(3);
    per3.mueve(7);
    //console.log('funcion');
}