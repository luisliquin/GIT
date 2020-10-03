let num = 2;

/*if(num % 2 == 0) console.log`${num} es par`;
else onsole.log`${num} es impar`;*/

(num % 2 == 0) ? console.log(`${num} es par`) : console.log(`${num} es impar`);

(num % 2 == 0) ?
    (
        console.log(`${num} es par`),
        console.log(`${num} es par 2`)
    )
    :
    (
        console.log(`${num} es impar`),
        console.log(`${num} es impar 2`)
    )