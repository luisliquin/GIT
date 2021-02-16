"use strict";

Object.defineProperty(exports, "__esModule", {
  value: true
});
exports.paqueteRefresco = paqueteRefresco;
exports.paqueteDonas = paqueteDonas;
exports.paqueteChocolates = paqueteChocolates;
exports.paquetePay = paquetePay;
exports.payFresa = exports.chocolate = exports.donas = exports.refrescos = exports.arregloPaquetesExtra = void 0;

var _calculadora = require("./calculadora.js");

var arregloPaquetesExtra = [];
exports.arregloPaquetesExtra = arregloPaquetesExtra;
var refrescos = document.getElementById('refresco');
exports.refrescos = refrescos;
var donas = document.getElementById('donas');
exports.donas = donas;
var chocolate = document.getElementById('chocolate');
exports.chocolate = chocolate;
var payFresa = document.getElementById('payfresa');
exports.payFresa = payFresa;
var cantidadRefresco = document.getElementById('cantidad-refresco');
var cantidadDonas = document.getElementById('cantidad-donas');
var cantidadChocolate = document.getElementById('cantidad-chocolate');
var cantidadPay = document.getElementById('cantidad-pay'); //contenedores de los paquetes extra

var ctnRefresco = document.querySelector('.refresco');
var ctnDonas = document.querySelector('.donas');
console.log(ctnDonas);
var ctnChocolate = document.querySelector('.chocolate');
var ctnPay = document.querySelector('.payfresa'); //contenedores precio paquetes extra

var ctnCantidadRefresco = document.querySelector('.precio-cantidad.paq-extra.paq-refresco');
var ctnCantidadDonas = document.querySelector('.precio-cantidad.paq-extra.paq-donas');
var ctnCantidadChocolates = document.querySelector('.precio-cantidad.paq-extra.paq-chocolate');
var ctnCantidadPay = document.querySelector('.precio-cantidad.paq-extra.paq-pay'); //bloqueo elementos de cantidad

cantidadRefresco.disabled = true;
cantidadDonas.disabled = true;
cantidadChocolate.disabled = true;
cantidadPay.disabled = true;

function paqueteRefresco() {
  var imagen = document.createElement('img');

  if (refrescos.checked) {
    cantidadRefresco.disabled = false;

    if (parseInt(cantidadRefresco.value) === 1) {
      var precioExtraRefresco = 40;
      arregloPaquetesExtra.push(precioExtraRefresco);
      (0, _calculadora.calcularPrecioTotal)();
    }

    (0, _calculadora.listenerCalculos)(cantidadRefresco, 40, ctnCantidadRefresco, arregloPaquetesExtra);
    imagen.setAttribute('src', 'img/refresco.png');
    imagen.setAttribute('alt', 'refresco');
    ctnRefresco.appendChild(imagen);
  } else {
    cantidadRefresco.disabled = true;

    var _precioExtraRefresco = parseInt(ctnCantidadRefresco.innerHTML.split(' ')[1]);

    if (arregloPaquetesExtra.length > 1) {
      var precioRestantes = arregloPaquetesExtra.filter(function (precio) {
        return precio !== _precioExtraRefresco;
      });
      exports.arregloPaquetesExtra = arregloPaquetesExtra = precioRestantes;
    } else {
      arregloPaquetesExtra.splice(0, 1);
    }

    (0, _calculadora.interfazNoCheck)(cantidadRefresco, ctnCantidadRefresco, ctnRefresco, 40);
  }
}

function paqueteDonas() {
  var imagen = document.createElement('img');

  if (donas.checked) {
    cantidadDonas.disabled = false;

    if (parseInt(cantidadDonas.value) === 1) {
      var precioExtraDonas = 35;
      arregloPaquetesExtra.push(precioExtraDonas);
      (0, _calculadora.calcularPrecioTotal)();
    }

    (0, _calculadora.listenerCalculos)(cantidadDonas, 35, ctnCantidadDonas, arregloPaquetesExtra);
    imagen.setAttribute('src', 'img/donnut.png');
    imagen.setAttribute('alt', 'donas');
    ctnDonas.appendChild(imagen);
  } else {
    cantidadDonas.disabled = true;

    var _precioExtraDonas = parseInt(ctnCantidadDonas.innerHTML.split(' ')[1]);

    if (arregloPaquetesExtra.length > 1) {
      var precioRestantes = arregloPaquetesExtra.filter(function (precio) {
        return precio !== _precioExtraDonas;
      });
      exports.arregloPaquetesExtra = arregloPaquetesExtra = precioRestantes;
    } else {
      arregloPaquetesExtra.splice(0, 1);
    }

    (0, _calculadora.interfazNoCheck)(cantidadDonas, ctnCantidadDonas, ctnDonas, 35);
  }
}

function paqueteChocolates() {
  var imagen = document.createElement('img');

  if (chocolate.checked) {
    cantidadChocolate.disabled = false;

    if (parseInt(cantidadChocolate.value) === 1) {
      var precioExtraChocolate = 25;
      arregloPaquetesExtra.push(precioExtraChocolate);
      (0, _calculadora.calcularPrecioTotal)();
    }

    (0, _calculadora.listenerCalculos)(cantidadChocolate, 25, ctnCantidadChocolates, arregloPaquetesExtra);
    imagen.setAttribute('src', 'img/chocolate.png');
    imagen.setAttribute('alt', 'chocolate');
    ctnChocolate.appendChild(imagen);
  } else {
    cantidadChocolate.disabled = true;

    var _precioExtraChocolate = parseInt(ctnCantidadChocolates.innerHTML.split(' ')[1]);

    if (arregloPaquetesExtra.length > 1) {
      var precioRestantes = arregloPaquetesExtra.filter(function (precio) {
        return precio !== _precioExtraChocolate;
      });
      exports.arregloPaquetesExtra = arregloPaquetesExtra = precioRestantes;
    } else {
      arregloPaquetesExtra.splice(0, 1);
    }

    (0, _calculadora.interfazNoCheck)(cantidadChocolate, ctnCantidadChocolates, ctnChocolate, 25);
  }
}

function paquetePay() {
  var imagen = document.createElement('img');

  if (payFresa.checked) {
    cantidadPay.disabled = false;

    if (parseInt(cantidadPay.value) === 1) {
      var precioExtraPay = 20;
      arregloPaquetesExtra.push(precioExtraPay);
      (0, _calculadora.calcularPrecioTotal)();
    }

    (0, _calculadora.listenerCalculos)(cantidadPay, 20, ctnCantidadPay, arregloPaquetesExtra);
    imagen.setAttribute('src', 'img/payfresa.png');
    imagen.setAttribute('alt', 'paquete-pay');
    ctnChocolate.appendChild(imagen);
  } else {
    cantidadPay.disabled = true;

    var _precioExtraPay = parseInt(ctnCantidadPay.innerHTML.split(' ')[1]);

    if (arregloPaquetesExtra.length > 1) {
      var precioRestantes = arregloPaquetesExtra.filter(function (precio) {
        return precio !== _precioExtraPay;
      });
      exports.arregloPaquetesExtra = arregloPaquetesExtra = precioRestantes;
    } else {
      arregloPaquetesExtra.splice(0, 1);
    }

    (0, _calculadora.interfazNoCheck)(cantidadPay, ctnCantidadPay, ctnPay, 20);
  }
}