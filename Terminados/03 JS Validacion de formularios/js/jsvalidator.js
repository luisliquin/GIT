class JSValidator {
    status = true;
    errors = [];
    via = 'http';

    validators = {
        minLength : 3,
        maxLength : 255,
    }

    msg = {
        required: `Este campo es requerido`,
        minLength: `Longitud no valida. Mínimo __minLength__ caracteres`,
        maxLength: `Longitud no valida. Máximo __maxLength__ caracteres`,
        email: `El campo de email no es válido`,
        integer: `El campo debe ser de tipo entero`,
        digit: `El valor debe ser un dígito`,
        url: `El campo debe ser una URL válida`
    }

    constructor(formId){
        this.setForm(formId);
        this.setInputs();
        this.parseInputs();
    }

    setForm(formId){
        this.form = document.getElementById(formId);
    }

    setInputs(){
        this.inputs = document.querySelectorAll(`#${this.form.id} .jsValidator`);
    }

    parseInputs(){
        this.inputs.forEach( input => {
            this.appendErrorsTag(input);
        });
    }

    setAjax(){
        this.via = 'ajax';
        return this;
    }

    setHttp(){
        this.via = 'http';
        return this;
    }

    appendErrorsTag(input){
        let parent = input.parentNode;
        let span = document.createElement('span');
        span.setAttribute("class","error-msg");
        parent.appendChild(span);
    }

    validateForm(){
        this.form.addEventListener('submit', (e)=>{
            //reiniciar los errores y cambiar status a true
            this.resetValidation();

            //recorrer cada uno de los inputs
            this.inputs.forEach( input =>{
                //validar cada input
                this.validateInput(input);
            });

            if(!this.status){
                //prevenir el envio del formulario
                e.preventDefault();
            } else {
                //Evaluar si se debe enviar ajax o http
                if (this.via == 'ajax'){
                    e.preventDefault();
                    this.submitHandler();
                }else{
                    //solo para fines demostrativos
                    e.preventDefault();
                    console.log('Se ha enviado con el navegador');
                }
            }
        });
    }

    validateInputs(){
        this.inputs.forEach( input => {
            input.addEventListener('input', (e) => {
                this.resetValidation();
                this.validateInput(input);
            });
        });
    }

    validateInput(input){
        let validators = input.dataset.validators;
        
        if(validators !== undefined){
            validators = validators.split(' ');

            validators.forEach(validator => {
                //si el validador es required => su metodo de validacion seria: _required(input)
                //si el validador es length => su metodo de validacion seria: _lentgh(input)
                this[`_${validator}`](input);
            });
        }       
    }

    setError(input, msg){
        //cambio el valor de status
        this.status = false;
        this.setStackError(input, msg);
        this.setErrorMessage(input, msg);
    }

    setStackError(input, msg){
        //añadiendo error para stack de errores
        this.errors.push({input: input, msg: msg});
    }

    setErrorMessage(input, msg){
        //adjuntando error para el usuario
        let span = input.nextElementSibling;
        span.innerHTML += (msg + '<br />');
    }

    resetValidation(){
        //cambiamos el valor del status 
        this.status = true;    
        this.resetStackError();
        this.resetErrorMessage();
    }

    resetStackError(){
        //pila de errores
        this.errors = [];
    }

    resetErrorMessage(){
      //quitar mensaje de error
      let spans = document.querySelectorAll(`#${this.form.id} .error-msg`)

      spans.forEach(span =>{
          span.innerHTML = "";
      });
    }

    submitHandler(){
        let data = new FormData(this.form);
        fetch(this.form.action, {
            method: this.form.method,
            body: data
        })
        .then(response => response.json())
        .then(data =>{
            console.log(data);
        })
        .catch(error => {
            console.log(error);
        })
    }

    init(){
        this.validateForm();
        this.validateInputs();
        return this;
    }
}

JSValidator.prototype._required = function(input){
    let value = input.value;
    let msg = this.msg.required;

    if(value.trim() === "" || value.length < 1){
        this.setError(input, msg);
    }
};

JSValidator.prototype._length = function(input){
    let value = input.value;
    let inputLength = value.length;
    let minLength = (input.dataset.validators_minlentgh !== undefined) ? Number(input.dataset.validators_minlength) : this.validators.minLength;
    let maxLength = (input.dataset.validators_maxlentgh !== undefined) ? Number(input.dataset.validators_maxlength) : this.validators.maxLength;

    let msg;

    if(inputLength < minLength){
        msg = this.msg.minLength.replace('__minLength__', minLength);
        this.setError(input, msg)
    }
    
    if(inputLength > maxLength){
        msg = this.msg.maxLength.replace('__maxLength__', maxLength);
        this.setError(input, msg)
    }
};

JSValidator.prototype._email = function (input){
    let value = input.value;
    let msg = this.msg.email;

    let pattern = new RegExp(/^(([^<>()[\]\\.,;:\s@\"]+(\.[^<>()[\]\\.,;:\s@\"]+)*)|(\".+\"))@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\])|(([a-zA-Z\-0-9]+\.)+[a-zA-Z]{2,}))$/i);

    if (!pattern.test(value) && value.trim() != ""){
        this.setError(input, msg);
    }
}

JSValidator.prototype._integer = function(input){
    let value = input.value;
    let msg = this.msg.integer;

    let pattern = new RegExp(/^[0-9]+$/);

    if(!pattern.test(value) && value.trim() !== ""){
        this.setError(input, msg);
    }
}

JSValidator.prototype._alphanumeric = function(input){
    let value = input.value;
    let msg = this.msg._alphanumeric;

    let pattern = new RegExp(/^[a-zA-Z0-9]+$/);

    if(!pattern.test(value) && value.trim !== ""){
        this.setError(input, msg);
    }
}

JSValidator.prototype._url = function(input){
    let value = input.value;
    let msg = this.msg.url;

    var pattern = RegExp(/^(https?|s?ftp):\/\/(((([a-z]|\d|-|\.|_|~|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])|(%[\da-f]{2})|[!\$&'\(\)\*\+,;=]|:)*@)?(((\d|[1-9]\d|1\d\d|2[0-4]\d|25[0-5])\.(\d|[1-9]\d|1\d\d|2[0-4]\d|25[0-5])\.(\d|[1-9]\d|1\d\d|2[0-4]\d|25[0-5])\.(\d|[1-9]\d|1\d\d|2[0-4]\d|25[0-5]))|((([a-z]|\d|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])|(([a-z]|\d|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])([a-z]|\d|-|\.|_|~|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])*([a-z]|\d|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])))\.)+(([a-z]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])|(([a-z]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])([a-z]|\d|-|\.|_|~|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])*([a-z]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])))\.?)(:\d*)?)(\/((([a-z]|\d|-|\.|_|~|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])|(%[\da-f]{2})|[!\$&'\(\)\*\+,;=]|:|@)+(\/(([a-z]|\d|-|\.|_|~|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])|(%[\da-f]{2})|[!\$&'\(\)\*\+,;=]|:|@)*)*)?)?(\?((([a-z]|\d|-|\.|_|~|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])|(%[\da-f]{2})|[!\$&'\(\)\*\+,;=]|:|@)|[\uE000-\uF8FF]|\/|\?)*)?(#((([a-z]|\d|-|\.|_|~|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])|(%[\da-f]{2})|[!\$&'\(\)\*\+,;=]|:|@)|\/|\?)*)?$/i);

    if(!pattern.test(value) && value.trim != ""){
        this.setError(input, msg);
    }
}