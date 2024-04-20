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
            fetch('/assets/flag-icons/country.json', {
                method: 'GET'
              })
              .then(response => response.json()) 
              .then(cb)
              .catch(err => console.log(err))
    };

    const addCountryPanel = (pnt)=>{
        
    };

    const addCountrySelection = (pnt)=>{
        const panel = $('<div class="countryselection"></div>'),
        accord = $('<div class="clubs"></div>').accordion({ collapsible: true });
        pnt.append(panel);        
        pnt.append(accord);

        loadCountryList((d)=>{
            const xs = [];
            d.forEach(x => xs.push({ value: x.name, code: x.code }));
            const input = $('<input class="countryinput" placeholder="type a country name here">');
            panel.append(input);
            const setValue = item=>`<span class="fi fi-${item.code}"></span><span>${item.value}</span>`;
            input.autocomplete({
                minLength: 1,
                source: xs
            })
            .autocomplete( "instance" )._renderItem = function( ul, item ) {
                return $( "<li>" )
                .append(setValue(item))
                .appendTo( ul );
            };
            const addBtn = $(`<button class="ui-button ui-widget ui-corner-all ui-button-icon-only" title="clique para adicionar o país selecionado">
              <span class="ui-icon ui-icon-plusthick"></span> clique para adicionar o país selecionado
            </button>`).click(function(){addCountryPanel(pnt)});
            panel.append(addBtn)
        });

    };

    const addClubSelection = (pnt) =>{
        const panel = $('<div class="club-selection"></div>');
        addCountrySelection(panel);

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