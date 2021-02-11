/*strings*/
let  cadena = 'Hola Mundo';

/*PROPIEDADES*/
/*cadena*/
console.log(cadena.length);

/*to upper*/
let cadenaMayus = cadena.toUpperCase();
console.log(cadenaMayus);

/*to lower*/
let cadenaMinus = cadena.toLowerCase();
console.log(cadenaMinus);

/*indexof*/
console.log(cadena.indexOf('o'));
console.log(cadena.indexOf('Hola'));

/*replace*/
console.log(cadena.replace('Mundo', 'Youtube'));

/*substring*/
console.log(cadena.substring(3));
console.log(cadena.substring(3,7));

/*slice*/
console.log(cadena.slice(-3));
console.log(cadena.slice(2));
console.log(cadena.slice(0,-6));

/*trim*/
let cadena2 = ' Hola Youtube, estamos trabajando con cadenas';
console.log(cadena2);
console.log(cadena2.trim());

/*ECMA SCRIPT 6*/
/*start whith*/
console.log(cadena.startsWith('h'));
console.log(cadena.startsWith('H'));
console.log(cadena.startsWith('M',5));

/*end whith*/
console.log(cadena.endsWith('o'));
console.log(cadena.endsWith('a',4));
console.log(cadena.endsWith('n',8));
console.log(cadena.endsWith('Mundo'));

/*includes*/
console.log(cadena.includes('n'));
console.log(cadena.includes('a,5'));
console.log(cadena.includes('a,2'));

/*repeat*/
let cadena3 = 'Hola';
console.log(cadena3.repeat(3))
console.log('r'.repeat(3))

/*template string*/
let nombre = 'Juan';
let apellido = 'Gomez';
let edad = 20;

console.log(
    'hola ' + nombre + ' ' + apellido + '. Tienes ' + edad + ' años.');

console.log(
    `Hola ${nombre} ${apellido}. tienes ${edad} años.`);