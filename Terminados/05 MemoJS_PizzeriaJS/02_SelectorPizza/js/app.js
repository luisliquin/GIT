//importaciones de modulos
import {pizzaCantidad, conteoPizzas} from './modules/calculadora.js';
import {ingredienteExtraQueso, extraQueso, ingredientePineapple, extraPineapple, ingredienteCostillas, extraCostillas} from './modules/ingredientes.js';
import {payFresa, paquetePay, paqueteRefresco, refrescos, paqueteDonas, donas, chocolate, paqueteChocolates} from './modules/paquetes.js';

/*Globales*/
const pizzaSeleccionada = document.getElementById('sabor-pizza');
const ctnPizzaSeleccionada = document.querySelector('.pizza-seleccionada');
const cuadroPago = document.querySelector('.cuadro-pago');

/*Detectar sabor de pizza*/
pizzaSeleccionada.addEventListener('change', pizzaCantidadSabor);

function pizzaCantidadSabor(){
    let imagen = document.createElement('img');

    if(ctnPizzaSeleccionada.childNodes.length >= 2){
        ctnPizzaSeleccionada.removeChild(ctnPizzaSeleccionada.childNodes[1]);    
    }

    if(pizzaSeleccionada.value === 'hawaiana'){
        imagen.setAttribute('src', 'img/pizzahawaiana.png');
        imagen.setAttribute('alt', 'pizza-hawaiana');
    }else if(pizzaSeleccionada.value === 'pepperoni'){
        imagen.setAttribute('src', 'img/pizzapepperoni.png');
        imagen.setAttribute('alt', 'pizza-pepperoni');
    }else if(pizzaSeleccionada.value === 'vegetales'){
        imagen.setAttribute('src', 'img/pizzaveggie.png');
        imagen.setAttribute('alt', 'pizza-vegetales');
    }else if(pizzaSeleccionada.value === 'mexicana'){
        imagen.setAttribute('src', 'img/pizzamexicana.png');
        imagen.setAttribute('alt', 'pizza-mexicana');
    }else if(pizzaSeleccionada.value === 'camaron'){
        imagen.setAttribute('src', 'img/pizzacamaron.png');
        imagen.setAttribute('alt', 'pizza-camaron');
    }else if(pizzaSeleccionada.value === 'serrano'){
        imagen.setAttribute('src', 'img/pizzaserrano.png');
        imagen.setAttribute('alt', 'pizza-jamonserrano');
    }
    ctnPizzaSeleccionada.appendChild(imagen);

    setTimeout(() => {
       cuadroPago.style.opacity = '1';
    }, 500);

    pizzaCantidad.addEventListener('change', conteoPizzas);
    extraQueso.addEventListener('change', ingredienteExtraQueso);
    extraPineapple.addEventListener('change', ingredientePineapple);
    extraCostillas.addEventListener('change', ingredienteCostillas);
    refrescos.addEventListener('change', paqueteRefresco);
    donas.addEventListener('change', paqueteDonas);
    chocolate.addEventListener('change', paqueteChocolates);
    payFresa.addEventListener('change', paquetePay);
}