import {calcularPrecioTotal, listenerCalculos, interfazNoCheck} from './calculadora.js'

export let arregloPaquetesExtra = [];

export let refrescos = document.getElementById('refresco');
export let donas = document.getElementById('donas');
export let chocolate = document.getElementById('chocolate');
export let payFresa = document.getElementById('payfresa');

let cantidadRefresco = document.getElementById('cantidad-refresco');
let cantidadDonas = document.getElementById('cantidad-donas');
let cantidadChocolate = document.getElementById('cantidad-chocolate');
let cantidadPay = document.getElementById('cantidad-pay');

//contenedores de los paquetes extra
let ctnRefresco = document.querySelector('.refresco');
let ctnDonas = document.querySelector('.donas');
console.log(ctnDonas);
let ctnChocolate = document.querySelector('.chocolate');
let ctnPay = document.querySelector('.payfresa');

//contenedores precio paquetes extra
let ctnCantidadRefresco = document.querySelector('.precio-cantidad.paq-extra.paq-refresco');
let ctnCantidadDonas = document.querySelector('.precio-cantidad.paq-extra.paq-donas');

let ctnCantidadChocolates = document.querySelector('.precio-cantidad.paq-extra.paq-chocolate');
let ctnCantidadPay = document.querySelector('.precio-cantidad.paq-extra.paq-pay');

//bloqueo elementos de cantidad
cantidadRefresco.disabled = true;
cantidadDonas.disabled = true;
cantidadChocolate.disabled = true;
cantidadPay.disabled = true;

export function paqueteRefresco(){
    let imagen = document.createElement('img');
    
    if(refrescos.checked){
        cantidadRefresco.disabled = false;

        if(parseInt(cantidadRefresco.value) === 1){
            let precioExtraRefresco = 40;
            arregloPaquetesExtra.push(precioExtraRefresco)
            calcularPrecioTotal();
        }
 
        listenerCalculos(cantidadRefresco, 40, ctnCantidadRefresco, arregloPaquetesExtra);
        
        imagen.setAttribute('src', 'img/refresco.png');
        imagen.setAttribute('alt', 'refresco');
        ctnRefresco.appendChild(imagen);
    }else{
        cantidadRefresco.disabled = true;
        let precioExtraRefresco = parseInt(ctnCantidadRefresco.innerHTML.split(' ')[1]);

        if(arregloPaquetesExtra.length > 1){
            let precioRestantes = arregloPaquetesExtra.filter(precio => precio !== precioExtraRefresco);
            arregloPaquetesExtra = precioRestantes;            
        }else{
            arregloPaquetesExtra.splice(0,1);
        }
        interfazNoCheck(cantidadRefresco, ctnCantidadRefresco, ctnRefresco, 40);
    }
}

export function paqueteDonas(){
    let imagen = document.createElement('img');
    
    if(donas.checked){
        cantidadDonas.disabled = false;

        if(parseInt(cantidadDonas.value) === 1){
            let precioExtraDonas = 35;
            arregloPaquetesExtra.push(precioExtraDonas)
            calcularPrecioTotal();
        }
 
        listenerCalculos(cantidadDonas, 35, ctnCantidadDonas, arregloPaquetesExtra);
        
        imagen.setAttribute('src', 'img/donnut.png');
        imagen.setAttribute('alt', 'donas');
        ctnDonas.appendChild(imagen);
    }else{
        cantidadDonas.disabled = true;
        let precioExtraDonas = parseInt(ctnCantidadDonas.innerHTML.split(' ')[1]);

        if(arregloPaquetesExtra.length > 1){
            let precioRestantes = arregloPaquetesExtra.filter(precio => precio !== precioExtraDonas);
            arregloPaquetesExtra = precioRestantes;            
        }else{
            arregloPaquetesExtra.splice(0,1);
        }
        interfazNoCheck(cantidadDonas, ctnCantidadDonas, ctnDonas, 35);
    }
}

export function paqueteChocolates(){
    let imagen = document.createElement('img');
    
    if(chocolate.checked){
        cantidadChocolate.disabled = false;

        if(parseInt(cantidadChocolate.value) === 1){
            let precioExtraChocolate = 25;
            arregloPaquetesExtra.push(precioExtraChocolate)
            calcularPrecioTotal();
        }
 
        listenerCalculos(cantidadChocolate, 25, ctnCantidadChocolates, arregloPaquetesExtra);
        
        imagen.setAttribute('src', 'img/chocolate.png');
        imagen.setAttribute('alt', 'chocolate');
        ctnChocolate.appendChild(imagen);
    }else{
        cantidadChocolate.disabled = true;
        let precioExtraChocolate = parseInt(ctnCantidadChocolates.innerHTML.split(' ')[1]);

        if(arregloPaquetesExtra.length > 1){
            let precioRestantes = arregloPaquetesExtra.filter(precio => precio !== precioExtraChocolate);
            arregloPaquetesExtra = precioRestantes;            
        }else{
            arregloPaquetesExtra.splice(0,1);
        }
        interfazNoCheck(cantidadChocolate, ctnCantidadChocolates, ctnChocolate, 25);
    }
}

export function paquetePay(){
    let imagen = document.createElement('img');
    
    if(payFresa.checked){
        cantidadPay.disabled = false;

        if(parseInt(cantidadPay.value) === 1){
            let precioExtraPay = 20;
            arregloPaquetesExtra.push(precioExtraPay)
            calcularPrecioTotal();
        }
 
        listenerCalculos(cantidadPay, 20, ctnCantidadPay, arregloPaquetesExtra);
        
        imagen.setAttribute('src', 'img/payfresa.png');
        imagen.setAttribute('alt', 'paquete-pay');
        ctnChocolate.appendChild(imagen);
    }else{
        cantidadPay.disabled = true;
        let precioExtraPay = parseInt(ctnCantidadPay.innerHTML.split(' ')[1]);

        if(arregloPaquetesExtra.length > 1){
            let precioRestantes = arregloPaquetesExtra.filter(precio => precio !== precioExtraPay);
            arregloPaquetesExtra = precioRestantes;            
        }else{
            arregloPaquetesExtra.splice(0,1);
        }
        interfazNoCheck(cantidadPay, ctnCantidadPay, ctnPay, 20);
    }
}