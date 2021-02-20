/*interface Bird{
    fly(): void;
    layEggs(): void;
}

interface Fish{
    swim(): void;
    layEggs(): void;
}

declare function getSmallPet(): Fish | Bird;

let pet = getSmallPet;

function isFish(pet: Fish | Bird): pet is Fish{
    return (pet as Fish). swim !== undefined;
}

if(isFish(pet)){
    pet.swim();
}else{
    pet.fly();
}
*/


//INTERFACE
interface Animal {
    name: string;
}

interface Animal{
    size: number;
}

const animal: Animal = {
    
}

//TYPES

type Animal2 = {
    name: string;
}

type Animal2 = {
    size: number;
}