
//VALIDATION sur l'extension de l'image

function validate() {
   
    var file = form.file.value;
    var reg = /(.*?)\.(jpg|jpeg|png)$/;
    if (!file.match(reg)) {
        alert("L'image doit respecter le format: jpg, jpeg et png");
        return false;
    }
}