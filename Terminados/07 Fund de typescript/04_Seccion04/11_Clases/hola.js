var Hello = /** @class */ (function () {
    function Hello(message) {
        this.message = message;
    }
    Hello.prototype.saludos = function () {
        return "saludos " + this.message;
    };
    return Hello;
}());
var hola = new Hello("Typescript");
console.log(hola.saludos());
