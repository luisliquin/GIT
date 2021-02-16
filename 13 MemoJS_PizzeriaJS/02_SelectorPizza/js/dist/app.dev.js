"use strict";

var _calculadora = require("./modules/calculadora.js");

var _ingredientes = require("./modules/ingredientes.js");

var _paquetes = require("./modules/paquetes.js");

//importaciones de modulos

/*Globales*/
var pizzaSeleccionada = document.getElementById('sabor-pizza');
var ctnPizzaSeleccionada = document.querySelector('.pizza-seleccionada');
var cuadroPago = document.querySelector('.cuadro-pago');
/*Detectar sabor de pizza*/

pizzaSeleccionada.addEventListener('change', pizzaCantidadSabor);

function pizzaCantidadSabor() {
  var imagen = document.createElement('img');

  if (ctnPizzaSeleccionada.childNodes.length >= 2) {
    ctnPizzaSeleccionada.removeChild(ctnPizzaSeleccionada.childNodes[1]);
  }

  if (pizzaSeleccionada.value === 'hawaiana') {
    imagen.setAttribute('src', 'img/pizzahawaiana.png');
    imagen.setAttribute('alt', 'pizza-hawaiana');
  } else if (pizzaSeleccionada.value === 'pepperoni') {
    imagen.setAttribute('src', 'img/pizzapepperoni.png');
    imagen.setAttribute('alt', 'pizza-pepperoni');
  } else if (pizzaSeleccionada.value === 'vegetales') {
    imagen.setAttribute('src', 'img/pizzaveggie.png');
    imagen.setAttribute('alt', 'pizza-vegetales');
  } else if (pizzaSeleccionada.value === 'mexicana') {
    imagen.setAttribute('src', 'img/pizzamexicana.png');
    imagen.setAttribute('alt', 'pizza-mexicana');
  } else if (pizzaSeleccionada.value === 'camaron') {
    imagen.setAttribute('src', 'img/pizzacamaron.png');
    imagen.setAttribute('alt', 'pizza-camaron');
  } else if (pizzaSeleccionada.value === 'serrano') {
    imagen.setAttribute('src', 'img/pizzaserrano.png');
    imagen.setAttribute('alt', 'pizza-jamonserrano');
  }

  ctnPizzaSeleccionada.appendChild(imagen);
  setTimeout(function () {
    cuadroPago.style.opacity = '1';
  }, 500);

  _calculadora.pizzaCantidad.addEventListener('change', _calculadora.conteoPizzas);

  _ingredientes.extraQueso.addEventListener('change', _ingredientes.ingredienteExtraQueso);

  _ingredientes.extraPineapple.addEventListener('change', _ingredientes.ingredientePineapple);

  _ingredientes.extraCostillas.addEventListener('change', _ingredientes.ingredienteCostillas);

  _paquetes.refrescos.addEventListener('change', _paquetes.paqueteRefresco);

  _paquetes.donas.addEventListener('change', _paquetes.paqueteDonas);

  _paquetes.chocolate.addEventListener('change', _paquetes.paqueteChocolates);

  _paquetes.payFresa.addEventListener('change', _paquetes.paquetePay);
}