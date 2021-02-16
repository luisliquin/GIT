import { aarregloIngredientesExtra } from "./ingredientes.js";
import { arregloPaquetesExtra } from "./paquetes.js";

export let pizzaCantidad = document.getElementById('cantidad-pizza');
const precioCantidad = document.querySelector('.precio-cantidad');
let precioTotal = document.querySelector('.total-cantidad');

let precioExtra;
let cantidadExtra;

export function conteoPizzas(){
    let precioUnidad = 220;
    let cantidadTemporal = parseInt(pizzaCantidad.value);
    precioCantidad.innerHTML = (precioUnidad * cantidadTemporal);
    calcularPrecioTotal();
}

export function listenerCalculos(cantidadExtraIng, precioEstatico, ctnCantidad, arregloExtra = []){
    cantidadExtraIng.addEventListener('change', () =>{
        cantidadExtra = parseInt(cantidadExtraIng.value);
        
        if(cantidadExtra === 1){
            precioExtra = precioEstatico;

            if(arregloExtra.length > 1){
                const posicion = (index) => index === precioExtra + precioEstatico;
                const foundIndex = arregloExtra.findIndex(posicion);
                arregloExtra.splice(foundIndex,1,precioExtra);
            }else{
                arregloExtra.splice(0,1,precioExtra);
            }
        }else{
            precioExtra = precioEstatico * cantidadExtra;
            
            if(arregloExtra.length > 1){
                const posicion = (index) => index === precioEstatico || index === (precioExtra - precioEstatico) || index === (precioExtra + precioEstatico);
                const foundIndex = arregloExtra.findIndex(posicion);
                arregloExtra.splice(foundIndex,1, precioExtra);
            }else{
                arregloExtra.splice(0,1,precioExtra);
            }
        }

        ctnCantidad.innerHTML = '$ ' + precioExtra;
        calcularPrecioTotal();
    })
}

export function interfazNoCheck(cantidadIng, ctnCantidadIng, ctnIngrediente, precioInicial){
    cantidadIng.value = 1;
    ctnCantidadIng.innerHTML = '$ ' + precioInicial;
    ctnIngrediente.removeChild(ctnIngrediente.childNodes[1]); 
    calcularPrecioTotal();
}

export function calcularPrecioTotal(){
    if(aarregloIngredientesExtra.length > 0){
        let sumador = (total, actual) => total + actual;
        let ingredientesExtra = aarregloIngredientesExtra.reduce(sumador);
        precioTotal.innerHTML = `$` + (parseInt(precioCantidad.innerHTML) + ingredientesExtra);

        if(arregloPaquetesExtra.length > 0){
            let sumadorPaquetes = (total, actual) => total + actual;
            let paquetesExtra = arregloPaquetesExtra.reduce(sumadorPaquetes);
            precioTotal.innerHTML = '$' + (parseInt(precioCantidad.innerHTML) + ingredientesExtra + paquetesExtra);
        }
    }else if(arregloPaquetesExtra.length > 0){
        let sumadorPaquetes = (total, actual) => total + actual;
        let paquetesExtra = arregloPaquetesExtra.reduce(sumadorPaquetes);
        precioTotal.innerHTML = '$' + (parseInt(precioCantidad.innerHTML) + paquetesExtra);
    }else{
        precioTotal.innerHTML = '$' + parseInt(precioCantidad.innerHTML);
    }
}