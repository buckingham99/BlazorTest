window.appFunctions = {
    showPrompt: function (text) {
        return prompt(text, 'Type your name here');
    },
    displayWelcome: function (welcomeMessage) {
        document.getElementById('welcome').innerText = welcomeMessage;
    },
    returnArrayAsyncJs: function () {
        DotNet.invokeMethodAsync('BlazorSample', 'ReturnArrayAsync')
            .then(data => {
                data.push(4);
                console.log(data);
            });
    },
    sayHello: function (dotnetHelper) {
        return dotnetHelper.invokeMethodAsync('SayHello')
            .then(r => console.log(r));
    },
    showEditUserModal: function (myModal) {
        $('#editUserModal').modal('show').attr('backdrop','static'); 
    },
    hideEditUserModal: function (myModal) {
        $('#editUserModal').modal('hide');
    },
    setFocus: function (element) {
        element.focus();
    },
    showSpinner: function (element) {
        $('.loader').css('display', 'block');
    },
    hideSpinner: function () {
        $('.loader').css('display', 'none');
    },
    saveConfirmation: function () {
        $('.checked').click(function (e) {
            e.preventDefault();
            var dialog = $('<p>Are you sure?</p>').dialog({
                buttons: {
                    "Yes": function () { alert('you chose yes'); },
                    "No": function () { alert('you chose no'); },
                    "Cancel": function () {
                        alert('you chose cancel');
                        dialog.dialog('close');
                    }
                }
            });
        });
    }

};