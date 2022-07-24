function Check() {
    var pass1 = document.getElementById("password_1");
    var pass2 = document.getElementById("password_2");
    var age = document.getElementById("signupAge");

    if (pass1.value != pass2.value) {
        pass1.style.backgroundColor = "red";
        pass2.style.backgroundColor = "red";
        return false;
    }
    else {
        pass1.style.backgroundColor = "white";
        pass2.style.backgroundColor = "white";
        

    }

    if (pass1.value.length < 7 && pass2.value.length < 7) {
        pass1.style.borderColor = "red";
        pass2.style.borderColor = "red";
        return false;
    }
    else {
        pass1.style.borderColor = "white";
        pass2.style.borderColor = "white";
       

    }

    if (age.value <= 12) {
        age.style.borderColor = "red";
        return false;
    }
    else {
        age.style.borderColor = "white";
        
    }
    return true;
    
}
    function IsValid() {

        var pass1 = document.getElementById("password_1");
        var pass2 = document.getElementById("password_2");
        var age = document.getElementById("signupAge");
        if (pass1.value != pass2.value) {
            alert("the password is not match");
            return false;
        }
        if (age.value <= 12) {
            alert("you are too young");
            return false;
        }
           
        return true;
    }



