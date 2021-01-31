function inicializa(){
}


var mochila = [];
mochila.push('A');
mochila.push('B');
mochila.push('C');
mochila.push('D');
mochila.push('E');

function vender(){
    mochila.splice(2,1);
}

function muestraInventario(){
for (a=0; a<mochila.length;a++){
    console.log(a + '- ' + mochila[a]);
}
}