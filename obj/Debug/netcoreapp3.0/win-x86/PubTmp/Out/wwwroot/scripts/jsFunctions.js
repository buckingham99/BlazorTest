

window.appFunctions = {
    noRecords: function (searchText) {
        searchError
        //return alert('No Records for: ' + searchText);
    },
    changeTabs: function (tab) {
        // Declare all variables
        var i, tabpanes, navlinks;

        // Get all elements with class="tab-pane" and remove the class "active"
        navlinks = document.getElementsByClassName('nav-link');
        for (i = 0; i < navlinks.length; i++) {
            navlinks[i].className = navlinks[i].className.replace(' active', '');
        }
        for (i = 0; i < navlinks.length; i++) {
            if (navlinks[i].innerText == tab) {
                navlinks[i].className.replace('nav-link', 'nav-link active');
            }
        }

        tabpanes = document.getElementsByClassName('tab-pane');
        for (i = 0; i < tabpanes.length; i++) {
            tabpanes[i].className = tabpanes[i].className.replace(' active', '');
            if (tabpanes[i].attributes.Id.nodeValue == tab) {
                tabpanes[i].className.replace('nav-link', 'nav-link active');
            }
        }
        for (i = 0; i < tabpanes.length; i++) {
            if (tabpanes[i].attributes.Id.nodeValue == tab) {
                tabpanes[i].className.replace('nav-link', 'nav-link active');
            }
        }

        // Show the current tab, and add an "active" class to the button that opened the tab
        //document.getElementById(tab).style.display = "block";
        $("#" + tab).addClass(" active");
    },
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
    showModal: function (myModal, errorText) {
        if (errorText > "") {
            $('#' + myModal +  ".modal-body").append(errorText);
            $('#' + myModal).modal('show');
        }
        else
            $('#' + myModal).modal('show');
    },
    hideModal: function (myModal) {
        $('#' + myModal).modal('hide');
        if (myModal == 'searchError') {
            $('#' + myModal + ".modal-body").empty();
        }
        $('#map').empty();
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
    },
    showMap: function (CoordinateArray) {
        var map = new ol.Map({
            target: 'map',
            layers: [
                new ol.layer.Tile({
                    source: new ol.source.OSM()
                })
            ],
            view: new ol.View({
                center: ol.proj.fromLonLat([CoordinateArray[0], CoordinateArray[1]]),
                zoom: 16
            })
        });
        // popup
        var popup = new ol.Overlay.Popup();
        map.addOverlay(popup);
        ////Instantiate with some options and add the Control
        var geocoder = new Geocoder('nominatim', {
            provider: 'osm',
            lang: 'en',
            placeholder: 'Search for ...',
            limit: 10,
            debug: false,
            autoComplete: true,
            keepOpen: true,
            innerText: CoordinateArray[2]
        });
        map.addControl(geocoder);
        ////Listen when an address is chosen
        geocoder.on('addresschosen', function (evt) {
            console.info(evt);
            window.setTimeout(function () {
                popup.show(evt.coordinate, evt.address.formatted);
            }, 3000);
        });

    }
};