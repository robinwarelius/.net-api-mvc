// <---***---> Header <---***--->
document.querySelector("#menu-button").addEventListener("click", () => {
    document.querySelector("#menu").classList.toggle("hide");
});


// <---***---> Validate user input <---***--->

const validate = (event) => {

    switch (event.target.type) {

        case "text":
            textVerification(event.target, 2)
            break;

        case "email":
            emailValidation(event.target)
            break;   

        case "password":
            passwordVerification(event.target)
            break;
    }
}

const emailValidation = (target) => {

    const regEx = /^(([^<>()[\]\\.,;:\s@"]+(\.[^<>()[\]\\.,;:\s@"]+)*)|(".+"))@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\])|(([a-zA-Z\-0-9]+\.)+[a-zA-Z]{2,}))$/;

    if (!regEx.test(target.value)) {
        document.querySelector(`[data-valmsg-for="${target.id}"]`).innerHTML = `Not a valid email`
    }
    else {
        document.querySelector(`[data-valmsg-for="${target.id}"]`).innerHTML = ""
    }
}

const passwordVerification = (target) => {

    const regEx = /^(?=.*[a-z])(?=.*[A-Z])(?=.*[0-9])(?=.*[!@#\$%\^&\*])(?=.{8,})/;

    if (!regEx.test(target.value)) {
        document.querySelector(`[data-valmsg-for="${target.id}"]`).innerHTML = `Not a valid password`
    }
    else {
        document.querySelector(`[data-valmsg-for="${target.id}"]`).innerHTML = ""
    }
}

const textVerification = (target, minLength) => {

    if (target.value.length < minLength) {
        document.querySelector(`[data-valmsg-for="${target.id}"]`).innerHTML = `Not Valid. Must contain more then ${minLength} characters`
    }
    else {
        document.querySelector(`[data-valmsg-for="${target.id}"]`).innerHTML = ""
    }

}




// event.target.value = inmatat värde
// event.target.id = id på elementet
// event.target.type = datatyp på inmatat värde