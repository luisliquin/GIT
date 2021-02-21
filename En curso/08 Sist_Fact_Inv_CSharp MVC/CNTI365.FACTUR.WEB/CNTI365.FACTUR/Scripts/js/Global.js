function Post(url, paramss) {
    return ajaxMethod(url, "POST", paramss)
}

function ajaxMethod(url, method, paramss) {
    return $.ajax({
        url: window.appURL + url,
        method: method,
        async: false,
        cache: false,
        data: paramss
    }).fail(function (jqXHR, textStatus, errorThrown){
        console.debug(jqXHR);
        console.debug(textStatus);
        console.log(errorThrown);
    })
}

function fnBaseURLWeb(url) {
    return window.appURL + url;
}