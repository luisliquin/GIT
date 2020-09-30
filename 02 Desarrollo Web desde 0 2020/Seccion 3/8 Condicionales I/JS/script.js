let num1 = 0;
let num2 = 5;

/* comdicional multiple*/
/*if(num > 0) {
    console.log(`${num1} es mayor que 0`);
}else if (num < 0){
    console.log(`${num1} es menor que 0`);
}else {
    console.log(`${num1} es igual que 0`);
}*/

/*oprdores logicos*/
if (num1> 0){
    if (num2> 0){
        console.log(`${num1} y ${num2} son mayores que 0`); 
    }else if (num2 < 0){
        console.log(`${num1} es mayor que 0 y ${num2} es menor que 0.`); 
    }else{
        console.log(`${num1} es mayor que 0 y ${num2} es igual que 0.`); 
    }
}else if (num1 < 0){
    if (num2 > 0){
        console.log(`${num1} no es mayor que 0 y ${num2} es mayor que 0.`); 
    }else if(num2 < 0){
        console.log(`${num1} y ${num2} son menores que 0.`); 
    }else{
        console.log(`${num1} es menor a 0 y ${num2} es igual a 0.`); 
    }
}else{
    if (num2 > 0){
        console.log(`${num1} es igual a 0 y ${num2} es mayor que 0.`); 
    }else if(num2 < 0){
        console.log(`${num1} es igual a 0 y ${num2} es menor que 0.`); 
    }else{
        console.log(`${num1} y ${num2} son iguales a 0.`); 
    }
}

let word = 'hola'

if (word.length > 4){
    console.log(`${word} tiene mas de 4 letras.`); 
}else if (word.length < 4){
    console.log(`${word} tiene menos de 4 letras.`); 
}else{
    console.log(`${word} es igual a 4 letras.`); 
}

let respuesta = true;

if(respuesta== true) console.log(`${respuesta} tiene el valor true`); 
if(respuesta== false) console.log(`${respuesta} tiene el valor false`); 

if(respuesta) console.log(`${respuesta} tiene el valor true`); 
if(!respuesta) console.log(`${respuesta} tiene el valor false`); 