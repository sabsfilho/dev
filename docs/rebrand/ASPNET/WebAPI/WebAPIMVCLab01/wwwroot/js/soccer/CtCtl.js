const CtCtl = function() {
      
    const addButton = (act, method, nm, o) => {
        var btn = document.createElement('button');
        btn.innerText = nm;
        btn.onclick = () => {
            fetch(act, {
                method: method,
                body: JSON.stringify(o),
                headers: {"Content-type": "application/json; charset=UTF-8"}
              })
              .then(response => response.json()) 
              .then(json => console.log(json))
              .catch(err => console.log(err))
        };
        document.getElementsByTagName('body')[0].appendChild(btn);

    }

    const loadCountryList = (cb)=>{
            fetch('https://trial.mobiscroll.com/content/countries.json', {
                method: 'GET'
              })
              .then(response => response.json()) 
              .then(cb)
              .catch(err => console.log(err))
    };

    const buildCountrySelection = (pnt)=>{

        loadCountryList((d)=>{
            const xs = [];
            d.forEach(x => xs.push(x.text));
            const panel = $('<div class="country-selection"></div>'),
            input = $('<input id="countryinput" placeholder="type a country name here">');
            panel.append(input);
            pnt.append(panel);
            input.autocomplete({
                minLength: 1,
                source: xs,/*
                focus: function( event, ui ) {
                $( "#country-input" ).val( ui.item.text );
                return false;
                },
                select: function( event, ui ) {
                $( "#project" ).val( ui.item.text );
                $( "#project-id" ).val( ui.item.value );
                $( "#project-description" ).html( ui.item.desc );
                $( "#project-icon" ).attr( "src", "images/" + ui.item.icon );
        
                return false;
                }*/
            })
            /*.autocomplete( "instance" )._renderItem = function( ul, item ) {
                return $( "<li>" )
                .append( item)
                .appendTo( ul );
            }*/
        });

    };

    const addClubSelection = (pnt) =>{
        const panel = $('<div class="club-selection"></div>'),
        countrySelector = buildCountrySelection(panel);        

        pnt.append(panel)
    };

    const load = ()=>{
        /*
        addButton('/Pizza', 'GET', 'GET Teams');
        addButton('/Pizza', 'POST', 'POST Team', {"name":"Calab","isGlutenFree":false});
        addButton('/Pizza/3', 'PUT', 'PUT Team', {"id":"3", "name":"Calabresa"});
        addButton('/Pizza/2', 'DELETE', 'DELETE Team', {});
        */
       const main = $('<div id="main"></div>')

        $('body').append(main);

        addClubSelection(main);
    };

    return {
        load:load
    }
}();

window.onload = CtCtl.load;