//VALIDATION sur l'extension de l'image edit

function validatedit() {

    var file = form.file.value;
    var reg = /(.*?)\.(jpg|jpeg|png)$/;

    if (file == '') {
        return true;
    }
    else {
        if (!file.match(reg)) {
            alert("L'image doit respecter le format: jpg, jpeg et png");
            return false;
        }
        else {
            return true;
        }
    }

}