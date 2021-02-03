var sonido1, sonido2;
var musica;

sonido1 = new Howl({
    src: ['sound/efecto1.wav'],
    loop: false
});

sonido2 = new Howl({
    src: ['sound/efecto2.wav'],
    loop: false
}); 


musica = new Howl({
    src: ['music/01.mp3'],
    loop: true
}); 


function inicializa(){

   // musica.play();

    document.addEventListener('keydown', function (tecla){
        if(tecla.keyCode == 38){
            //arriba
            sonido1.play();
        }
        if(tecla.keyCode == 40){
            //abajo
            sonido2.play();
        }
        if(tecla.keyCode == 37){
        }
        if(tecla.keyCode == 39){
        }
    });
}