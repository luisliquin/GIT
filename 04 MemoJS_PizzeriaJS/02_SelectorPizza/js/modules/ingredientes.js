import {calcularPrecioTotal, pizzaCantidad, listenerCalculos, interfazNoCheck} from './calculadora.js'

//Areglo de ingredientes
export let aarregloIngredientesExtra = [];

//Ingregientes extra
export let extraQueso = document.getElementById('extra-queso');
export let extraPineapple = document.getElementById('pineapple-mango');
export let extraCostillas = document.getElementById('costillas');

//contenedores del ingrediente extra
let ctnExtraQueso = document.querySelector('.extra-queso');
let ctnExtraPineapple = document.querySelector('.extrapineapple');
let ctnExtraCostillas = document.querySelector('.costillas');

//cantidad ingredientes extra
let cantidadQueso = document.getElementById('num-extraqueso');
let cantidadPineapple = document.getElementById('num-extrapineapple');
let cantidadCostillas = document.getElementById('num-extracostillas');

//Contenedores precio ingredientes extra
let ctnCantidadQueso = document.querySelector('.precio-cantidad.preing.paq-queso');
let ctnCantidadPineapple = document.querySelector('.precio-cantidad.preing.paq-pineapple');
let ctnCantidadCostillas = document.querySelector('.precio-cantidad.preing.paq-costillas');

//bloquear elementos de cantidad al inicio
cantidadQueso.disabled = true;
cantidadPineapple.disabled = true;
cantidadCostillas.disabled = true;

//funciones de ingredientex extra
export function ingredienteExtraQueso(){
    let precioExtraQueso;
    let imagen = document.createElement('img');

    if(extraQueso.checked){
        cantidadQueso.disabled = false;
        cantidadQueso.setAttribute('max', pizzaCantidad.value);

        if(parseInt(cantidadQueso.value) === 1){
            precioExtraQueso = 40;
            aarregloIngredientesExtra.push(precioExtraQueso);
            calcularPrecioTotal();
        }

        //Condicional para validar que se compre mas de una pizza
        if(parseInt(pizzaCantidad.value)>1){            
            listenerCalculos(cantidadQueso, 40, ctnCantidadQueso, aarregloIngredientesExtra);
        }

        imagen.setAttribute('src', 'img/extra-queso2.png');
        imagen.setAttribute('alt', 'extra-queso');
        ctnExtraQueso.appendChild(imagen);
    }else{
        cantidadQueso.disabled = true;
        precioExtraQueso + parseInt(ctnCantidadQueso.innerHTML.split(' ')[1]);

        if(aarregloIngredientesExtra.length > 1){
            let precioRestantes = aarregloIngredientesExtra.filter(precio => precio !== precioExtraQueso);
            aarregloIngredientesExtra = precioRestantes;
        }else{
            aarregloIngredientesExtra.splice(0,1);
        }

        interfazNoCheck(cantidadQueso, ctnCantidadQueso, ctnExtraQueso, 40);
    }
}


export function ingredientePineapple(){
    let precioExtraPineapple;
    let imagen = document.createElement('img');

    if(extraPineapple.checked){
        cantidadPineapple.disabled = false;
        cantidadPineapple.setAttribute('max', pizzaCantidad.value);

        if(parseInt(cantidadPineapple.value) === 1){
            precioExtraPineapple = 45;
            aarregloIngredientesExtra.push(precioExtraPineapple);
            calcularPrecioTotal();
        }

        //Condicional para validar que se compre mas de una pizza
        if(parseInt(pizzaCantidad.value)>1){            
            listenerCalculos(cantidadPineapple, 45, ctnCantidadPineapple, aarregloIngredientesExtra);
        }

        imagen.setAttribute('src', 'img/pineappleextra.png');
        imagen.setAttribute('alt', 'pineapple');
        ctnExtraPineapple.appendChild(imagen);
    }else{
        cantidadPineapple.disabled = true;
        precioExtraPineapple + parseInt(ctnCantidadPineapple.innerHTML.split(' ')[1]);

        if(aarregloIngredientesExtra.length > 1){
            let precioRestantes = aarregloIngredientesExtra.filter(precio => precio !== precioExtraPineapple);
            aarregloIngredientesExtra = precioRestantes;
        }else{
            aarregloIngredientesExtra.splice(0,1);
        }

        interfazNoCheck(cantidadPineapple, ctnCantidadPineapple, ctnExtraPineapple, 45);  
      }
}

export function ingredienteCostillas(){
    let precioExtraCostillas;
    let imagen = document.createElement('img');

    if(extraCostillas.checked){
        cantidadCostillas.disabled = false;
        cantidadCostillas.setAttribute('max', pizzaCantidad.value);

        if(parseInt(cantidadCostillas.value) === 1){
            precioExtraCostillas = 50;
            aarregloIngredientesExtra.push(precioExtraCostillas);
            calcularPrecioTotal();
        }

        //Condicional para validar que se compre mas de una pizza
        if(parseInt(pizzaCantidad.value)>1){            
            listenerCalculos(cantidadCostillas, 50, ctnCantidadCostillas, aarregloIngredientesExtra);
        }

        imagen.setAttribute('src', 'img/costillas.png');
        imagen.setAttribute('alt', 'costillas');
        ctnExtraCostillas.appendChild(imagen);
    }else{
        cantidadCostillas.disabled = true;
        precioExtraCostillas + parseInt(ctnCantidadCostillas.innerHTML.split(' ')[1]);

        if(aarregloIngredientesExtra.length > 1){
            let precioRestantes = aarregloIngredientesExtra.filter(precio => precio !== precioExtraCostillas);
            aarregloIngredientesExtra = precioRestantes;
        }else{
            aarregloIngredientesExtra.splice(0,1);
        }

        interfazNoCheck(cantidadCostillas, ctnCantidadCostillas, ctnExtraCostillas, 50);
    }
}