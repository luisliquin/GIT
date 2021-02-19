interface ObjectInterface {
    label: string;
    name?: string;
    readonly secret: number;
}

function printLabel(obj: ObjectInterface){
    if(obj.name) console.log('Contiene un Name!!!!!')
    console.log(obj.label)
}

const testObj : ObjectInterface = {secret: 1, label: 'prueba', name: 'existo!!'}

testObj.label = "Label 2"

printLabel(testObj);

export default{}