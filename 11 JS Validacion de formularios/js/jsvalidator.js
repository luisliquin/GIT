class JSValidator{
    status = true;

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

    appendErrorsTag(input){
        let parent = input.parentNode;
        let span = document.createElement('span');
        span.setAttribute("class","error-msg");
        parent.appendChild(span);
    }

    validateForm(){
        this.form.addEventListener('submit', (e)=>{
            
            this.inputs.forEach( input =>{
                this.validateInput(input);
            });

            if(!this.status){
                //prevenir el envio del formulario
                e.preventDefault();
                console.log("Ha ocurrido un error de validacion");
            } else {
                console.log("El formulario se ha enviado");
            }

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

    init(){
        this.validateForm();
        return this;
    }
}

JSValidator.prototype._required = function(input){
    //Logica de la validacion
    let errors = true;
    if(errors){
        this.status = false;
    }
};

JSValidator.prototype._length = function(input){
    
};