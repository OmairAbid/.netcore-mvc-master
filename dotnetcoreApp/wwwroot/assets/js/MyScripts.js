// Start global
var url = window.location.href.split("/");
var baseUrl = url[0] + "//" + url[2] + "/" + url[3];

// *End Global


//$('.actions').find('a')[1].href;

//El ement Type Selection

function OnTypeSelect(obj) {

    try {

        var Typevalue = document.getElementById('SelectedElementType');

        if (obj.id === "Buttontype") {
            try {

                Typevalue.value = $(obj).find('h5')[0].innerText;
                $('.actions').find('a')[1].href = "#next";
                $('.actions').find('a')[1].click();

            }
        catch (err) {
            console.log(err.message + " in OnTypeSelect() function line 27");
        }

    }
    else if (obj.id === "texttype") {
            try {

                Typevalue.value = $(obj).find('h5')[0].innerText;
                $('.actions').find('a')[1].click();
        }
        catch (err) {
                console.log(err.message + " in OnTypeSelect() function line 38");
        }
    }
    else if (obj.id === "Imagetype") {
            try {

                Typevalue.value = $(obj).find('h5')[0].innerText;
                $('.actions').find('a')[1].click();
        }
        catch (err) {
                console.log(err.message + " in OnTypeSelect() function line 48");
        }
    }
    else if (obj.id === "Formtype") {
            try {

                Typevalue.value = $(obj).find('h5')[0].innerText;
                $('.actions').find('a')[1].click();
        }
        catch (err) {
                console.log(err.message + " in OnTypeSelect() function line 58");
        }
    }
    else if (obj.id === "Videotype") {
            try {

                Typevalue.value = $(obj).find('h5')[0].innerText;
                $('.actions').find('a')[1].click();
        }
        catch (err) {
                console.log(err.message + " in OnTypeSelect() function line 68");
        }
    }
      
    }
    catch (err) {
        console.log(err.message);
    }
    

}

//*End Element Type Selection