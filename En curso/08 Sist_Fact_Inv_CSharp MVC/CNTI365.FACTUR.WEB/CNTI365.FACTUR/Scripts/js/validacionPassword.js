document.getElementById('btnregistrar').disabled = true;
/*vamos a crear unas variables*/
let password = document.getElementById("txtcontraseña");
let confirPassword = document.getElementById("txtconfircontraseña");

$("#faeye").on("click", function () {
    if (password.type === 'password') {
        password.setAttribute('type', 'text');
        $("#faeye").hide();
        $("#faeyeslash").show();
    }
})

$("#faeyeslash").on("click", function () {
    if (password.type === 'text') {
        password.setAttribute('type', 'password');
        $("#faeye").show();
        $("#faeyeslash").hide();
    }
})

$("#txtcontraseña").keyup(function () {    
    let contraseña = $("#txtcontraseña").val();
    let confircontraseña = $("#txtconfircontraseña").val();

    console.log(contraseña);

    if (contraseña == "") {
        password.setAttribute('type', 'password');
        $("#faeyeslash").hide();
        $("#faeye").show();
        $("#msjpassword").html("").css("color", "red");
    } else {
        $("#faeye").show();

        if (!/[A-Z]/.test(contraseña)) {
            $("#msjpassword").html("Debe tener al menos una mayuscula").css("color", "red");
            $("#txtcontraseña").css("border-color", "red");
            document.getElementById('btnregistrar').disabled = true;
        } else if (!/[a-z]/.test(contraseña)) {
            $("#msjpassword").html("Debe tener al menos una minuscula").css("color", "red");
            $("#txtcontraseña").css("border-color", "red");
            document.getElementById('btnregistrar').disabled = true;
        } else if (!/[#@$%=!]/.test(contraseña)) {
            $("#msjpassword").html("Debe tener al menos un caracter especial").css("color", "red");
            $("#txtcontraseña").css("border-color", "red");
            document.getElementById('btnregistrar').disabled = true;
        } else if (contraseña.length < 8) {
            $("#msjpassword").html("Debe como minimo 8 caracteres").css("color", "red");
            $("#txtcontraseña").css("border-color", "red");
            document.getElementById('btnregistrar').disabled = true;
        } else if (confircontraseña !== "") {
            if (contraseña !== confircontraseña) {
                $("#msjpassword").html("Las contraseñas no coinciden").css("color", "red");
                $("#txtcontraseña").css("border-color", "red");
                document.getElementById('btnregistrar').disabled = true;
            } else {
                $("#msjpassword").html("").css("color", "red");
                $("#msjconfirpassword").html("").css("color", "red");
                $("#txtcontraseña").css("border-color", "");
                $("#txtconfircontraseña").css("border-color", "");
                document.getElementById('btnregistrar').disabled = false;                
            }
        } else {
            $("#msjpassword").html("").css("color", "red");
            $("#txtcontraseña").css("border-color", "");
            document.getElementById('btnregistrar').disabled = false;
        }
    }
})

/*******************************/
$("#confirfaeye").on("click", function () {
    if (confirPassword.type === 'password') {
        confirPassword.setAttribute('type', 'text');
        $("#confirfaeye").hide();
        $("#confirfaeyeslash").show();
    }
})

$("#confirfaeyeslash").on("click", function () {
    if (confirPassword.type === 'text') {
        confirPassword.setAttribute('type', 'password');
        $("#confirfaeye").show();
        $("#confirfaeyeslash").hide();
    }
})


$("#txtconfircontraseña").keyup(function () {
    let contraseña = $("#txtcontraseña").val();
    let confircontraseña = $("#txtconfircontraseña").val();

    console.log(confircontraseña);

    if (confircontraseña == "") {
        confirpassword.setAttribute('type', 'password');
        $("#confirfaeyeslash").hide();
        $("#confirfaeye").show();
        $("#msjconfirpassword").html("").css("color", "red");
    } else {
        $("#faeye").show();

        if (!/[A-Z]/.test(confircontraseña)) {
            $("#msjconfirpassword").html("Debe tener al menos una mayuscula").css("color", "red");
            $("#txtconfircontraseña").css("border-color", "red");
            document.getElementById('btnregistrar').disabled = true;
        } else if (!/[a-z]/.test(confircontraseña)) {
            $("#msjconfirpassword").html("Debe tener al menos una minuscula").css("color", "red");
            $("#txtconfircontraseña").css("border-color", "red");
            document.getElementById('btnregistrar').disabled = true;
        } else if (!/[#@$%=!]/.test(confircontraseña)) {
            $("#msjconfirpassword").html("Debe tener al menos un caracter especial").css("color", "red");
            $("#txtconfircontraseña").css("border-color", "red");
            document.getElementById('btnregistrar').disabled = true;
        } else if (contraseña.length < 8) {
            $("#msjconfirpassword").html("Debe como minimo 8 caracteres").css("color", "red");
            $("#txtconfircontraseña").css("border-color", "red");
        } else if (confircontraseña !== "") {
            if (confircontraseña !== contraseña) {
                $("#msjconfirpassword").html("Las contraseñas no coinciden").css("color", "red");
                $("#txtconfircontraseña").css("border-color", "red");
                document.getElementById('btnregistrar').disabled = true;
            } else {
                $("#msjpassword").html("").css("color", "red");
                $("#msjconfirpassword").html("").css("color", "red");
                $("#txtcontraseña").css("border-color", "");
                $("#txtconfircontraseña").css("border-color", "");
                document.getElementById('btnregistrar').disabled = false;
            }
        } else {
            $("#msjconfirpassword").html("").css("color", "red");
            $("#txtconfircontraseña").css("border-color", "");
            document.getElementById('btnregistrar').disabled = false;
        }
    }
})