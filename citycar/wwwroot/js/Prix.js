


function CheckDecimal() {
    var prix = form.prix.value;
    var decimal = /^?[0-9]+\.[0-9]/;
    if (prix.value.match(decimal)) {
        
        return true;
    }
    else {
       
        return false;
    }
}

