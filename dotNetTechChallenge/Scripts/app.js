function processdata() {
    var personName = $.trim($('#txtPersonName').val());
    var inputNumber = $.trim($('#txtNumber').val());
    var isValidInput = true;

    if ((!personName) || (personName.length == 0)) {
        $('#nameValidation').removeClass('hide');
        isValidInput = false;
    }
    else {
        $('#nameValidation').addClass('hide');
    }

    if ((!inputNumber) || (inputNumber.length == 0) || (isNaN(inputNumber))) {
        $('#numberValidation').removeClass('hide');
        isValidInput = false;
    }
    else {
        $('#numberValidation').addClass('hide');
    }

    if (!isValidInput)
        return;

    var apiURL = "api/conversion";
    var numberinwords = '';
    
    $.get(apiURL, { number: inputNumber }, function (data) {
        $('#personName').text(personName);
        $('#numberWords').text(data);
        $('#outputsection').removeClass('hide');
    }
    );


}