"use strict";
exports.__esModule = true;
function printLabel(obj) {
    if (obj.name)
        console.log('Contiene un Name!!!!!');
    console.log(obj.label);
}
var testObj = { secret: 1, label: 'prueba', name: 'existo!!' };
testObj.label = "Label 2";
printLabel(testObj);
exports["default"] = {};
