import { lastValueFrom } from "rxjs";

const username: string = 'Nicolas';

const sum = (a:number, b:number) =>{
    return a + b;
}

sum(1,3);

class Person{
     constructor(public age:number, public last_name:string){}
}

const nico = new Person(15, 'Molina');